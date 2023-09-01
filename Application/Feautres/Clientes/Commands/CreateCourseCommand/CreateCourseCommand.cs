using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feautres.Clientes.Commands.CreateCourseCommand
{
    public class CreateCourseCommand : IRequest<Response<int>>
    {
        public string CourseCode { get; set; }
        public DateTime DischargeDate { get; set; }
        public bool State { get; set; }
        public int NumberGraduates { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryMedium { get; set; }
        public string Seller { get; set; }
        public string CollegeLevel { get; set; }
        public string CollegeName { get; set; }
        public string CollegeCourse { get; set; }
        public string SchoolLocation { get; set; }
        public int Commission { get; set; }
        public double Total { get; set; }
    }

    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Course> _repositoryAsync;

        private readonly IMapper _mapper;
        public CreateCourseCommandHandler(IRepositoryAsync<Course> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }


        public async Task<Response<int>> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<Course>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.Id);
        }
    }
}
