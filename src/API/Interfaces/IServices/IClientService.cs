using API.EntityFramework.Entities;

namespace API.DemoDapper.Interfaces.IServices
{
    public interface IClientService
    {
        void AddNew(Client client);

        void Update(Client client);

        void Delete(int id);
        
        Client GetById(int id);

        List<Client> Get(int page = 1, int size = 10);
    }
}
