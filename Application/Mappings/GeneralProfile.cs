using Application.DTOs;
using Application.Feautres.Clientes.Commands.CreateContractCommand;
using Application.Feautres.Clientes.Commands.CreateCourseCommand;
using Application.Feautres.Clientes.Commands.CreateItemCommand;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CreateMap<CreateContractCommand, ContractC>();
            CreateMap<CreateDressItemCommand, DressItem>();
            CreateMap<CreateCourseCommand, Course>();

            #endregion
        }
    }
}
