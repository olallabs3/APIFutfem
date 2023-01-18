using APIfutfem.Models;
using APIfutfem.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIfutfem.Controllers;

[ApiController]
[Route("[controller]")]
public class JugadoraController : ControllerBase
{
    public JugadoraController()
    {
    }

    [HttpGet]
    public ActionResult<List<Jugadora>> GetAll() =>
    JugadoraService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Jugadora> Get(int id)
    {
        var jugadora = JugadoraService.Get(id);

        if (jugadora == null)
            return NotFound();

        return jugadora;
    }

    [HttpPost]
    public IActionResult Create(Jugadora jugadora)
    {
        JugadoraService.Add(jugadora);
        return CreatedAtAction(nameof(Get), new { id = jugadora.Id }, jugadora);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Jugadora jugadora)
    {
        if (id != jugadora.Id)
            return BadRequest();

        var existingPizza = JugadoraService.Get(id);
        if (existingPizza is null)
            return NotFound();

        JugadoraService.Update(jugadora);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var jugadora = JugadoraService.Get(id);

        if (jugadora is null)
            return NotFound();

        JugadoraService.Delete(id);

        return NoContent();
    }
}