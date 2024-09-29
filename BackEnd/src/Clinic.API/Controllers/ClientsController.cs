using System.Diagnostics.Eventing.Reader;
using Clinic.API.Data;
using Clinic.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    public readonly DataContext _context;
    public ClientsController(DataContext context)
    {
       _context = context;
    }

    [HttpGet]
    public IEnumerable<Client> Get()
    {
        return _context.Clients;
    }

    [HttpGet("{id}")]
    public Client GetById(int id)
    {
        return _context.Clients.FirstOrDefault(client => client.ClientId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de post";
    }
}
