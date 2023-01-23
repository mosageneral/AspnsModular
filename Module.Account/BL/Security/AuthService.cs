using BL.Infrastructure;
using BL.Security;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Module.Account.DL.Entities.UserEntites;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Module.Account.BL.Security
{
    internal interface IAuthenticateService
    {
        User AuthenticateUser(ApiLoginModelDTO request, out string token);
    }


    internal class TokenAuthenticationService : IAuthenticateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserManagementService _userManagementService;
        private readonly VariableConfig _tokenManagement;

        public TokenAuthenticationService(IUnitOfWork unitOfWork, IUserManagementService service, IOptions<VariableConfig> tokenManagement)
        {
            _userManagementService = service;
            _tokenManagement = tokenManagement.Value;
            _unitOfWork = unitOfWork;
        }

        public User AuthenticateUser(ApiLoginModelDTO request, out string token)
        {

            token = string.Empty;
            var user = _userManagementService.IsValidUser(request.Cred, request.Password);
            if (user != null)
            {
                var UserRolesIds = _unitOfWork.UserRolesRepository.GetMany(a => a.UserId == user.Id).Select(a=>a.RoleId).ToHashSet();
                
                List<Claim> ClaimList = new List<Claim>();
                foreach (var item in UserRolesIds)
                {
                
                    var AllRolesPermessions = _unitOfWork.PermissionRoleRepository.GetMany(a => a.RoleId == item).ToHashSet();
                    foreach (var PermissionId in AllRolesPermessions)
                    {
                        var Permission = _unitOfWork.PermissionRepository.GetById(PermissionId.PermissionId);
                        if (Permission!=null)
                        {
                            
                            ClaimList.Add(new Claim(ClaimTypes.Role, Permission.NameEn));

                        }

                    }

                }

                ClaimList.Add(new Claim(ClaimTypes.Name, request.Cred));
                ClaimList.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
              
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenManagement.TokenSecret));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
                var expireDate = DateTime.Now.AddMinutes(_tokenManagement.TokenExpire);
                ClaimList.Add(new Claim(ClaimTypes.DateOfBirth, expireDate.ToString()));
                var tokenDiscriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(ClaimList),
                    Expires = expireDate,
                    SigningCredentials = credentials
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenObj = tokenHandler.CreateToken(tokenDiscriptor);
                token = tokenHandler.WriteToken(tokenObj);
            }
            return user;
        }
    }

    internal interface IUserManagementService
    {
        User IsValidUser(string username, string password);
        Guid? getUserId(string username);
    }

    internal class UserManagementService : IUserManagementService
    {
        private readonly IUnitOfWork _uow;
        public UserManagementService(IUnitOfWork uow) { _uow = uow; }

        public User IsValidUser(string UserName, string password)
        {
            var user = _uow.UserRepository.GetMany(ent => ent.UserName.ToLower() == UserName.ToLower().Trim() && ent.Password == EncryptANDDecrypt.EncryptText(password) ).ToHashSet();
            return user.Count() == 1 ? user.FirstOrDefault() : null;
        }

        public Guid? getUserId(string username)

        {
            // Get user id by name 
            var user = _uow.UserRepository.GetMany(ent => ent.UserName.ToLower() == username.ToLower().Trim()).ToHashSet();
            return user.Count() == 1 ? user.FirstOrDefault().Id : null;
        }





    }
}
