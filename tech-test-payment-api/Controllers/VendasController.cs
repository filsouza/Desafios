using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.NewFolder;

namespace tech_test_payment_api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class VendasController : ControllerBase
  {
    VendaUseCase vendaUc = new VendaUseCase();
    private static readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    private readonly ILogger<VendasController> _logger;

    public VendasController(ILogger<VendasController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Get(int Id_Pedido)
    {
      var venda = vendaUc.GetVenda(Id_Pedido);
      return Ok(venda);
    }

    [HttpPost]
    public IActionResult Post([FromBody]Venda venda)
    {
      var teste = new Venda();
      if (venda.vendedor != null)
      {
       teste = vendaUc.InserirVenda(venda);
      }
      return Created("", teste);
    }

    [HttpPut]
    public IEnumerable<WeatherForecast> Put()
    {
      var rng = new Random();
      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = rng.Next(-20, 55),
        Summary = Summaries[rng.Next(Summaries.Length)]
      })
      .ToArray();
    }
  }
}
