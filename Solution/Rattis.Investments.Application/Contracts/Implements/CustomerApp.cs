using Rattis.Investments.Application.Contracts.Interfaces;
using Rattis.Investments.Domain.Interfaces.Repositories;

namespace Rattis.Investments.Application.Contracts.Implements
{
    public class CustomerApp : ICustomerApp
    {
        private readonly IClienteRepository _clienteRepository;

        public CustomerApp(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public string GetCustumerDocument(int id)
        {
            return _clienteRepository.GetCPFWithOnlyNumbers(id);
        }
    }
}
