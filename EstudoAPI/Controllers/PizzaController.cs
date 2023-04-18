using Microsoft.AspNetCore.Mvc;
using EstudoAPI.Services;
using EstudoAPI.Models;

namespace EstudoAPI.Controllers
{
    [ApiController]
    [Route("pizzas")]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pizza>> getAll() =>PizzaService.getAll();
        [HttpGet("{id}")]
        public ActionResult<Pizza> get(int id)
        {
            var pizza = PizzaService.get(id);
            if(pizza == null)
            return NotFound();
            return pizza;
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaService.add(pizza);
            return CreatedAtAction(nameof(get), new {id=pizza.id},pizza);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.get(id);
            if(pizza is null)
                return NotFound();
            PizzaService.remove(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,Pizza pizza)
        {
            if (id != pizza.id)
                return BadRequest();
            var existingPizza = PizzaService.get(id);
            if (existingPizza is null)
                return NotFound();
            PizzaService.update(pizza);
            return NoContent();
        }
    }
}