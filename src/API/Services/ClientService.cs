using API.DemoDapper.Interfaces.IRepositories;
using API.DemoDapper.Interfaces.IServices;
using API.EntityFramework.Entities;

namespace API.DemoDapper.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public void AddNew(Client client)
        {
            client.Id =  _clientRepository.Insert(client);            
        }

        public void Delete(int id)
        {
            var client = GetById(id);
            if (client != null)
                _clientRepository.Delete(client);
            else
                throw new Exception("Id not found!");
        }

        public List<Client> Get(int page = 1, int size = 10)
        {
            return _clientRepository.Get(page, size);
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void Update(Client client)
        {
            _clientRepository.Update(client);
        }
    }
}
