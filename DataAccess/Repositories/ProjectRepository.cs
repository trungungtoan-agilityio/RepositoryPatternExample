using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.Repositories;

public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    public ProjectRepository(ApplicationContext context) : base(context)
    {
    }
}
