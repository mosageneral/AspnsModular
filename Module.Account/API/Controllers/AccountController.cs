using BL.Infrastructure;
using BL.Security;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module.Account.BL.Security;
using Module.Account.DL.DTO;
using Module.Account.DL.Entities.UserEntites;
using Shared.Infrastructure.Extensions;
using Shared.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("/api/Account/[controller]")]
  //  [ClaimRequirement(ClaimTypes.Role, PermissionsConst.Admin)]

    internal class AccountController:ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAuthenticateService authenticateService;

        public AccountController(IUnitOfWork unitOfWork,IAuthenticateService authenticateService)
        {
            this.unitOfWork = unitOfWork;
            this.authenticateService = authenticateService;
        }
        [HttpGet,Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(unitOfWork.UserRepository.GetAll());
        }

        [HttpGet, Route("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(unitOfWork.RoleRepository.GetAll());
        }
        [HttpGet, Route("getAllPermission")]
        public async Task<IActionResult> getAllPermission()
        {
            return Ok(unitOfWork.PermissionRepository.GetAll());
        }
        [HttpPost,Route("AddUser")]
        public IActionResult AddUser (User user)
        {
            user.Password = EncryptANDDecrypt.EncryptText(user.Password);
            user.IsActive = true;
            unitOfWork.UserRepository.Add(user);
            unitOfWork.Save();
          
            return Ok(user);
        }
        //[HttpPost, Route("AddUser")]
        //public async Task<IActionResult> AddUser(User user)
        //{
        //   user.Password = EncryptANDDecrypt.EncryptText(user.Password);
        //    unitOfWork.UserRepository.Add(user);
        //    unitOfWork.Save();
        //    return Ok(user);
        //}
        [HttpGet,Route("GetAllRolesWithPermissions")]
        public async Task<IActionResult> GetAllRolesWithPermissions()
        {
            var Roles = unitOfWork.RoleRepository.GetAll();
            List<object> RolesPermissionsList = new List<object>();
            foreach (var item in Roles)
            {
                var permissionIds = unitOfWork.PermissionRoleRepository.GetMany(a => a.RoleId == item.Id).Select(a => a.PermissionId).ToHashSet();
                List<Permission> permissions = new List<Permission>();

                foreach (var permission in permissionIds)
                {
                    var Per = unitOfWork.PermissionRepository.GetById(permission);
                    permissions.Add(Per);
                }
                RolesPermissionsList.Add(new {Role = item,Permissions = permissions});
            }
            return Ok(RolesPermissionsList);
        }
        [HttpPost,Route("Login")]
        public async Task<IActionResult> Login(ApiLoginModelDTO request)
        {
        
         var User =  authenticateService.AuthenticateUser(request,out var Token);
            
            if (User == null)
            {
                return BadRequest(new { Status = "Invaild User" });
            }
            User.Password = null;
            return Ok(new {Token = Token, User = User });
        }

        [HttpPost,Route("AddUserToRole")]
        public async Task<IActionResult> AddUserToRole(AddUserToRoleDTO dTO)
        {
            UserRoles userRoles = new UserRoles();
            userRoles.UserId = dTO.UserId;
            userRoles.RoleId = dTO.RoleId;
            unitOfWork.UserRolesRepository.Add(userRoles);
            unitOfWork.Save();
            return Ok(userRoles);
        }
        [HttpPost, Route("AddPermissionToRole")]
        public async Task<IActionResult> AddPermissionToRole(AddPermissionToRoleDTO dTO)
        {
            PermissionRoles userRoles = new PermissionRoles();
            userRoles.PermissionId = dTO.PermissionId;
            userRoles.RoleId = dTO.RoleId;
            unitOfWork.PermissionRoleRepository.Add(userRoles);
            unitOfWork.Save();
            return Ok(userRoles);
        }
    }
}
