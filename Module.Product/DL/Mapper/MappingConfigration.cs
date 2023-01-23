

using AutoMapper;
using Module.Archive.DL.DTO;
using Module.Archive.DL.Entities.ArchiveEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Mapping
{

    public class MappingConfigration : Profile
    {

        
        public MappingConfigration()
        {
            // Add as many of these lines as you need to map your objects
           CreateMap<ArchiveBuilding, ArchiveBuildingDTO>(MemberList.Source).ReverseMap();
           CreateMap<ArchiveFloor, ArchiveFloorDTO>(MemberList.Source).ReverseMap();
           CreateMap<ArchiveRoom, ArchiveRoomDTO>(MemberList.Source).ReverseMap();
           CreateMap<Arcivecupboard, ArchiveCupboardDTO>(MemberList.Source).ReverseMap();
           CreateMap<ArchiveCell, ArchiveCellDTO>(MemberList.Source).ReverseMap();

        }
    }
}
