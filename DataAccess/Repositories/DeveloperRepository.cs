using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.Repositories;

public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
{
    public DeveloperRepository(ApplicationContext context) : base(context)
    {
    }
    public IEnumerable<Developer> GetPopularDevelopers(int count)
    {
        return Context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
    }
}
