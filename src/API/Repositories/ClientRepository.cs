using API.DemoDapper.Interfaces.IRepositories;
using API.EntityFramework.Entities;
using API.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;


namespace API.DemoDapper.Repositories
{
    public class ClientRepository : IClientRepository
    {
        

        private readonly ExampleDBContext _context;

        public ClientRepository(ExampleDBContext context)
        {
            _context = context;
        }

        public ClientRepository()
        {            

        }
        public void Delete(Client client)
        {
            _context.Cliente.Remove(client);
        }

        public List<Client> Get(int page = 1, int size = 10)
        {

            return _context.Set<Client>().Skip((page-1)*size).Take(size)
                                 .AsNoTracking()
                                 .ToList();
        }

        public Client? GetById(int id)
        {
            return _context.Cliente.ToHashSet().FirstOrDefault(x => x.Id == id);
        }

        public Client? GetByName(string name)
        {
            return _context.Cliente.ToHashSet().Where(x => x.Name == name).FirstOrDefault();
        }

        public int Insert(Client client)
        {
            _context.Cliente.Add(client);
            return client.Id;
        }

        public void Update(Client client)
        {
            _context.Set<Client>().Update(client);
        }
    }
}
