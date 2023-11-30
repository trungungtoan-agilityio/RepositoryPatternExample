using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DeveloperController(IUnitOfWork unitOfWork) : ControllerBase
{
    public IActionResult GetPopularDevelopers([FromQuery]int count)
    {
        var popularDevelopers = unitOfWork.Developers.GetPopularDevelopers(count);
        return Ok(popularDevelopers);

    }
    [HttpPost]
    public IActionResult AddDeveloperAndProject()
    {
        var developer = new Developer
        {
            Followers = 100,
            Name = "Join Doe"
        };
        
        var project = new Project
        {
            Name = "Project 1"
        };
        
        unitOfWork.Developers.Add(developer);
        unitOfWork.Projects.Add(project);
        unitOfWork.Complete();
        
        return Ok();
    }
}
