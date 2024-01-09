using BYDPlatform.Domain.Entities;
using BYDPlatform.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Modularity;

namespace BYDPlatform.Http.Api.Controllers;

[ApiController]
[Route("user")]
[DependsOn(typeof(EntityFrameworkCoreModule))]
public class UserController:AbpControllerBase
{
    private IRepository<User> _repository;

    public UserController(IRepository<User> repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<User> Create([FromBody] User user)
    {
        User u;
        try
        {
            u =await _repository.InsertAsync(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return u;
    }
}