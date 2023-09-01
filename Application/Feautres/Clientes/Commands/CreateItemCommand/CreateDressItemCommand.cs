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

namespace Application.Feautres.Clientes.Commands.CreateItemCommand
{
    public class CreateDressItemCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class CreateDressItemCommandHandler : IRequestHandler<CreateDressItemCommand, Response<int>>
    {
        private readonly IRepositoryAsync<DressItem> _repositoryAsync;

        private readonly IMapper _mapper;
        public CreateDressItemCommandHandler(IRepositoryAsync<DressItem> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }


        public async Task<Response<int>> Handle(CreateDressItemCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<DressItem>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.Id);
        }
    }
}
