using Application.Wrappers;
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
        public async Task<Response<int>> Handle(CreateContractCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
