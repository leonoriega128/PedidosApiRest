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

namespace Application.Feautres.Clientes.Commands.CreateContractCommand
{
    public class CreateContractCommand : IRequest<Response<int>>
    {
        public int ContractId { get; set; }
        public int ItemId { get; set; }
        public DateTime? CreatedDate { get; set; } = default(DateTime?);
        public DateTime UpdateDate { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, Response<int>>
    {
        private readonly IRepositoryAsync<ContractC> _repositoryAsync;

        private readonly IMapper _mapper;
        public CreateContractCommandHandler(IRepositoryAsync<ContractC> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }




        public async Task<Response<int>> Handle(CreateContractCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<ContractC>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.Id);
        }
    }
}
