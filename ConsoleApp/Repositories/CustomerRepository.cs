using ConsoleApp.Contexts;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }
}
