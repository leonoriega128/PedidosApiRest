using Application.Wrappers;
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
}
