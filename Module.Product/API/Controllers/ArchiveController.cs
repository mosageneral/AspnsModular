//using AutoMapper;
//using BL.Infrastructure;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using Module.Archive.BL.Helper;
//using Module.Archive.DL.DTO;
//using Module.Archive.DL.Entities.ArchiveEntities;
//using Shared.Infrastructure.Extensions;
//using Shared.Models.Constant;
//using Shared.Models.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;
//using File = Module.Archive.DL.Entities.ArchiveEntities.File;

//namespace Module.Archive.Controllers
//{
//    [ApiController]
//    [EnableCors("MyPolicy")]
//    [Route("/api/Archive/[controller]")]
//    [ClaimRequirement(ClaimTypes.Role, PermissionsConst.Archive)]
//    internal class ArchiveController:ControllerBase
//    {
//        private readonly IGetUserById getUserById;
//        private readonly IUnitOfWork unitOfWork;

//        private readonly IMapper Mapper;
//        private readonly IHostingEnvironment hostingEnvironment;

//        public ArchiveController(IGetUserById getUserById, IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment _hostingEnvironment)
//        {
//            this.getUserById = getUserById;
//            this.unitOfWork = unitOfWork;
//            Mapper = mapper;
//            hostingEnvironment = _hostingEnvironment;
//        }
//        #region Archive Building Block
//        //Archive Building Block Apis


//        [HttpPost,Route("AddBulk")]
//        public async Task<IActionResult> AddBulk()
//        {
//            return Ok();
//        }
//        [HttpGet,Route("GetAllBuidlings")]
//        public async Task<IActionResult> GetAllBuidlings()
//        {
//            return  Ok( unitOfWork.ArchiveBuildingRepository.GetAll());
//        }
//        [HttpGet, Route("GetBuidlingById")]
//        public async Task<IActionResult> GetBuidlingById(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveBuildingRepository.GetById(Id));
//        }
//        [HttpPost,Route("AddBuidling")]
//        public async Task<IActionResult> AddBuidling(ArchiveBuilding archiveBuilding)
//        {
//            unitOfWork.ArchiveBuildingRepository.Add(archiveBuilding);
//            unitOfWork.Save();
//            return Ok(archiveBuilding);
//        }
//        [HttpGet,Route("DeleteBuidling")]
//        public async Task<IActionResult> DeleteBuidling(Guid Id)
//        {
//            unitOfWork.ArchiveBuildingRepository.Delete(Id);
//            unitOfWork.Save();
//            return Ok();
//        }
//        [HttpPost, Route("EditBuidling")]
//        public async Task<IActionResult> EditBuidling(ArchiveBuilding archiveBuilding)
//        {
            
//            unitOfWork.ArchiveBuildingRepository.Update(archiveBuilding);
//            unitOfWork.Save();
//            return Ok();
//        }
//        #endregion



//        #region Archive Floor Block
//        //Archive Floor Block Apis
//        [HttpGet, Route("GetAllFloors")]
//        public async Task<IActionResult> GetAllFloors()
//        {
//            return Ok(unitOfWork.ArchiveFloorRepository.GetAll());
//        }
//        [HttpGet, Route("GetAllFloorsByBuildingId")]
//        public async Task<IActionResult> GetAllFloorsByBuildingId(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveFloorRepository.GetMany(a=>a.ArchiveBuildingId==Id).ToHashSet());
//        }
//        [HttpGet, Route("GetFloorById")]
//        public async Task<IActionResult> GetFloorById(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveFloorRepository.GetById(Id));
//        }
//        [HttpPost, Route("AddFloor")]
//        public async Task<IActionResult> AddFloor(ArchiveFloorDTO archiveFloordto)
//        {
//            var Floor = Mapper.Map<ArchiveFloor>(archiveFloordto);

//            unitOfWork.ArchiveFloorRepository.Add(Floor);
//            unitOfWork.Save();
//            return Ok(Floor);
//        }
//        [HttpGet, Route("DeleteFloor")]
//        public async Task<IActionResult> DeleteFloor(Guid Id)
//        {
//            unitOfWork.ArchiveFloorRepository.Delete(Id);
//            unitOfWork.Save();
//            return Ok();
//        }
//        [HttpPost, Route("EditFloor")]
//        public async Task<IActionResult> EditFloor(ArchiveFloor archiveFloor)
//        {

//            unitOfWork.ArchiveFloorRepository.Update(archiveFloor);
//            unitOfWork.Save();
//            return Ok();
//        }
//        #endregion


//        #region Archive Room Block
//        //Archive Room Block Apis
//        [HttpGet, Route("GetAllRooms")]
//        public async Task<IActionResult> GetAllRooms()
//        {
//            return Ok(unitOfWork.ArchiveRoomRepository.GetAll());
//        }
//        [HttpGet, Route("GetAllRoomsByFloorId")]
//        public async Task<IActionResult> GetAllRoomsByFloorId(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveRoomRepository.GetMany(a=>a.ArchiveFloorId==Id).ToHashSet());
//        }
//        [HttpGet, Route("GetRoomById")]
//        public async Task<IActionResult> GetRoomById(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveRoomRepository.GetById(Id));
//        }
//        [HttpPost, Route("AddRoom")]
//        public async Task<IActionResult> AddRoom(ArchiveRoomDTO archiveRoomdto)
//        {
//            var Room = Mapper.Map<ArchiveRoom>(archiveRoomdto);
//            unitOfWork.ArchiveRoomRepository.Add(Room);
//            unitOfWork.Save();
//            return Ok(Room);
//        }
//        [HttpGet, Route("DeleteRoom")]
//        public async Task<IActionResult> DeleteRoom(Guid Id)
//        {
//            unitOfWork.ArchiveRoomRepository.Delete(Id);
//            unitOfWork.Save();
//            return Ok();
//        }
//        [HttpPost, Route("EditRoom")]
//        public async Task<IActionResult> EditRoom(ArchiveRoom archiveRoom)
//        {

//            unitOfWork.ArchiveRoomRepository.Update(archiveRoom);
//            unitOfWork.Save();
//            return Ok();
//        }
//        #endregion


//        #region Archive Cell Block
//        //Archive Cell Block Apis
//        [HttpGet, Route("GetAllCells")]
//        public async Task<IActionResult> GetAllCells()
//        {
//            return Ok(unitOfWork.ArchiveCellRepository.GetAll());
//        }
//        [HttpGet, Route("GetAllCellsByCupboardId")]
//        public async Task<IActionResult> GetAllCellsByCupboardId(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveCellRepository.GetMany(a=>a.ArcivecupboardId==Id).ToHashSet());
//        }
//        [HttpGet, Route("GetCellById")]
//        public async Task<IActionResult> GetCellById(Guid Id)
//        {
//            return Ok(unitOfWork.ArchiveCellRepository.GetById(Id));
//        }
//        [HttpPost, Route("AddCell")]
//        public async Task<IActionResult> AddCell(ArchiveCellDTO archiveCelldto)
//        {
//            var Cell = Mapper.Map<ArchiveCell>(archiveCelldto);
//            unitOfWork.ArchiveCellRepository.Add(Cell);
//            unitOfWork.Save();
//            return Ok(Cell);
//        }
//        [HttpGet, Route("DeleteCell")]
//        public async Task<IActionResult> DeleteCell(Guid Id)
//        {
//            unitOfWork.ArchiveCellRepository.Delete(Id);
//            unitOfWork.Save();
//            return Ok();
//        }
//        [HttpPost, Route("EditCell")]
//        public async Task<IActionResult> EditCell(ArchiveCell archiveCell)
//        {

//            unitOfWork.ArchiveCellRepository.Update(archiveCell);
//            unitOfWork.Save();
//            return Ok();
//        }
//        #endregion


//        #region Archive cupboard Block
//        //Archive cupboard Block Apis
//        [HttpGet, Route("GetAllcupboards")]
//        public async Task<IActionResult> GetAllcupboards()
//        {
//            return Ok(unitOfWork.ArchivecupboardRepository.GetAll());
//        }
//        [HttpGet, Route("GetAllcupboardsByRoomId")]
//        public async Task<IActionResult> GetAllcupboardsByRoomId(Guid Id)
//        {
//            return Ok(unitOfWork.ArchivecupboardRepository.GetMany(a=>a.ArchiveRoomId==Id).ToHashSet());
//        }
//        [HttpGet, Route("GetcupboardById")]
//        public async Task<IActionResult> GetcupboardById(Guid Id)
//        {
//            return Ok(unitOfWork.ArchivecupboardRepository.GetById(Id));
//        }
//        [HttpPost, Route("Addcupboard")]
//        public async Task<IActionResult> Addcupboard(ArchiveCupboardDTO archivecupboarddto)
//        {
//            var Cupboard = Mapper.Map<Arcivecupboard>(archivecupboarddto);

//            unitOfWork.ArchivecupboardRepository.Add(Cupboard);
//            unitOfWork.Save();
//            return Ok(Cupboard);
//        }
//        [HttpGet, Route("Deletecupboard")]
//        public async Task<IActionResult> Deletecupboard(Guid Id)
//        {
//            unitOfWork.ArchivecupboardRepository.Delete(Id);
//            unitOfWork.Save();
//            return Ok();
//        }
//        [HttpPost, Route("Editcupboarding")]
//        public async Task<IActionResult> Editcupboard(Arcivecupboard archivecupboard)
//        {

//            unitOfWork.ArchivecupboardRepository.Update(archivecupboard);
//            unitOfWork.Save();
//            return Ok();
//        }
//        #endregion
//        #region Dashboard
//        [HttpGet,Route("Dashboard")]
//        public async Task<IActionResult> Dashboard()
//        {
//            var BuildingCount = unitOfWork.ArchiveBuildingRepository.GetAll().Count();
//            var FloorCount = unitOfWork.ArchiveFloorRepository.GetAll().Count();
//            var RoomCount = unitOfWork.ArchiveRoomRepository.GetAll().Count();
//            var cupcoradCount = unitOfWork.ArchivecupboardRepository.GetAll().Count();
//            var CellCount = unitOfWork.ArchiveCellRepository.GetAll().Count();
//            return Ok(new { BuildingCount= BuildingCount, FloorCount= FloorCount, RoomCount= RoomCount, cupcoradCount= cupcoradCount, CellCount= CellCount });
//        }
//        #endregion
//        #region File Block
//        [HttpGet,Route("GetAllFiles")]
//        public async Task<IActionResult> GetAllFiles()
//        {
//            return Ok(unitOfWork.FileRepository.GetAll());
//        }
//        [HttpGet, Route("GetFileById")]
//        public async Task<IActionResult> GetFileById(Guid Id)
//        {
//            return Ok(unitOfWork.FileRepository.GetById(Id));
//        }
//        [HttpGet, Route("GetFilesByCellId")]
//        public async Task<IActionResult> GetFilesByCellId(Guid Id)
//        {
//            return Ok(unitOfWork.FileRepository.GetMany(a=>a.ArchiveCellId==Id).ToHashSet());
//        }
//        [HttpGet, Route("GetFileByCellId")]
//        public async Task<IActionResult> GetFileByCellId(Guid Id)
//        {
//            return Ok(unitOfWork.FileRepository.GetMany(a=>a.ArchiveCellId==Id).ToHashSet());
//        }
//        [HttpPost,Route("AddFile")]
//        public async Task<IActionResult> AddFile([FromForm]FileDTO fileDTO)
//        {
//          var ImageName = FileHelper.FileUpload(fileDTO.FilePath, hostingEnvironment, FileConst.FilesPath);
//            var File = new File();
//            File.ArchiveCellId = fileDTO.ArchiveCellId;
//            File.UserId= fileDTO.UserId;
//            File.FileName = fileDTO.FileName;
//            File.FilePath=ImageName;
//            unitOfWork.FileRepository.Add(File);
//            unitOfWork.Save();
//            return Ok(File);
//        }
//        [HttpGet,Route("DownLoadFile")]
//        public async Task<IActionResult> DownLoadFile(Guid FileId,Guid UserId)
//        {
//            var FileTransaction = new FileTransactionHistory();
//            FileTransaction.CreatedAt = DateTime.Now;
//            FileTransaction.UserId= UserId;
//            FileTransaction.FileId  =FileId;
//            FileTransaction.TransactionAr = "تم تحميل الملف";
//            FileTransaction.TransactionEn = "File Downloaded";
//            unitOfWork.FileTransactionHistoryRepository.Add(FileTransaction);
//            unitOfWork.Save();

//            return Ok(FileTransaction);
//        }
//        [HttpGet, Route("WithDrawFile")]
//        public async Task<IActionResult> WithDrawFile(Guid FileId, Guid UserId)
//        {
//            var FileTransaction = new FileTransactionHistory();
//            FileTransaction.CreatedAt = DateTime.Now;
//            FileTransaction.UserId = UserId;
//            FileTransaction.FileId = FileId;
//            FileTransaction.TransactionAr = "تم سحب الملف";
//            FileTransaction.TransactionEn = "File Withdrawed";
//            unitOfWork.FileTransactionHistoryRepository.Add(FileTransaction);
//            unitOfWork.Save();

//            return Ok(FileTransaction);
//        }
//        [HttpGet, Route("ReturnFile")]
//        public async Task<IActionResult> ReturnFile(Guid FileId, Guid UserId)
//        {
//            var FileTransaction = new FileTransactionHistory();
//            FileTransaction.CreatedAt = DateTime.Now;
//            FileTransaction.UserId = UserId;
//            FileTransaction.FileId = FileId;
//            FileTransaction.TransactionAr = "تم إرجاع الملف";
//            FileTransaction.TransactionEn = "File Returned";
//            unitOfWork.FileTransactionHistoryRepository.Add(FileTransaction);
//            unitOfWork.Save();

//            return Ok(FileTransaction);
//        }

//        [HttpGet,Route("GetFileTransaction")]
//        public async Task<IActionResult > GetFileTransaction(Guid FileId)
//        {
//          var data=  unitOfWork.FileTransactionHistoryRepository.GetMany(a => a.FileId == FileId).OrderByDescending(a => a.CreatedAt).ToHashSet();
//            var List = new List<object>();
//            foreach (var item in data)
//            {
//                var ob = new 
//                {
//                    Event = item.TransactionAr,
//                    Date = item.CreatedAt,
//                    User = getUserById.GetUser(item.UserId)

//                };
//                List.Add(ob);
//            }
            
//            return Ok(List);
//;        }
//        #endregion
//    }
//}
