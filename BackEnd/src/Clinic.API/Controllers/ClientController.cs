using System.Diagnostics.Eventing.Reader;
using Clinic.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    public IEnumerable<Client> _client = new Client[] {
            new Client() {
                ClientId = 1,
                Name = "Peter",
                BirthDate = "11/12/2024",
                Phone = "1195565484",
                Email = "text@email.com",
                Address = "rua: Antonio Bandeira, 45",
                MedicalHistory = "Descrição"
            },
            new Client() {
                ClientId = 2,
                Name = "Mary",
                BirthDate = "11/12/2000",
                Phone = "1597546816",
                Email = "Test@email.com",
                Address = "rua: Mark, 1245",
                MedicalHistory = "Description"
            }
        };
    public ClientController()
    {
       
    }

    [HttpGet]
    public IEnumerable<Client> Get()
    {
        return _client;
    }

    [HttpGet("{id}")]
    public IEnumerable<Client> Get(int id)
    {
        return _client.Where(client => client.ClientId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de post";
    }
}
