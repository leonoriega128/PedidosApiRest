using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region DTOs
            CreateMap<ContractC, ContractCDTO>();
            CreateMap<Course, CourseDTO>();
            CreateMap<DressItem, DressItemDTO>();
            #endregion

            #region Commands
            //CreateMap<CreateContractCommand, ContractC>();
            //CreateMap<CreateDressItemCommand, DressItem>();
            //CreateMap<CreateCourseCommand, Course>();

            #endregion
        }
    }
}
