using Microsoft.AspNetCore.Mvc;
using Proevento.API.Models;

namespace ProEvento.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return new Evento[] { };
    }

    [HttpGet]
    public Evento GetById (int id)
    {
        return new Evento();
    }
}
