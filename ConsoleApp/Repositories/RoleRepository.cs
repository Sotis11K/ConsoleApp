using ConsoleApp.Contexts;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
