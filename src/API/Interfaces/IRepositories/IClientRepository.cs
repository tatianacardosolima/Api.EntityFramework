using API.EntityFramework.Entities;

namespace API.DemoDapper.Interfaces.IRepositories
{
    public interface IClientRepository
    {
        int Insert(Client client);
        void Update(Client client);
        void Delete(Client client);
        Client GetById(int id);
        Client GetByName(string Name);

        List<Client> Get(int page = 1, int size = 10);
    }
}
