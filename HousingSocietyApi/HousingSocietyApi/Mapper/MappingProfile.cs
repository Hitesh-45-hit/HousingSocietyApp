using AutoMapper;
using HousingSocietyApi.Core.DTO;
using HousingSocietyApi.DataModel.Tables;

namespace PointsSystem.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<account_grp_mst_DTO, account_grp_mst>();
            CreateMap<install_mst_DTO, install_mst>();
        }

    }
}
