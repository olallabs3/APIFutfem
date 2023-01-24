using APIfutfem.Models;
using APIfutfem.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIfutfem.Controllers;

[ApiController]
[Route("[controller]")]
public class EquipoController : ControllerBase
{
    public EquipoController()
    {
    }

    [HttpGet]
    public ActionResult<List<Equipo>> GetAll() =>
    EquipoService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Equipo> Get(int id)
    {
        var equipo = EquipoService.Get(id);

        if (equipo == null)
            return NotFound();

        return equipo;
    }

    [HttpPost]
    public IActionResult Create(Equipo equipo)
    {
        EquipoService.Add(equipo);
        return CreatedAtAction(nameof(Get), new { id = equipo.Id }, equipo);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Equipo equipo)
    {
        if (id != equipo.Id)
            return BadRequest();

        var existingEquipo = EquipoService.Get(id);
        if (existingEquipo is null)
            return NotFound();

        EquipoService.Update(equipo);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var equipo = EquipoService.Get(id);

        if (equipo is null)
            return NotFound();

        EquipoService.Delete(id);

        return NoContent();
    }
}