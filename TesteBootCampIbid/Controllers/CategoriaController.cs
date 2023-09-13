using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteBootCampIbid.Data;
using TesteBootCampIbid.Models;

namespace TesteBootCampIbid.Controllers
{
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet("categorias")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {
            try
            {
                var categorias = await context.Categorias.ToListAsync();
                return Ok(categorias);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Falha interna");
            }
        }

        [HttpGet("categorias/{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {
            try
            {
                var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
                if (categoria == null)
                    return NotFound("Não encontrado");

                return Ok(categoria);
            }
            catch
            {
                return StatusCode(500, "Falha interna");
            }
        }

        [HttpGet("categoria/{categoriaId}/protudos")]
        public async Task<IActionResult> GetProductsByCategory(int categoriaId, [FromServices] AppDbContext context)
        {
            try
            {

                var produtos = await context.Produtos.Where(x => x.ProdutoCategoriaId == categoriaId).ToListAsync();
                if (produtos == null)
                    return NotFound("Não encontrado");
                return Ok(produtos);
            }
            catch
            {
                return StatusCode(500, "Falha interna");
            }
        }

        [HttpPut("categoria/{id:int}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] Categoria categoria, [FromServices] AppDbContext context)
        {
            var model = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
                return NotFound("Não encontrado");

            model.Nome = categoria.Nome;

            context.Categorias.Update(model);
            context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("categoria/{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (categoria == null)
                return NotFound("Não encontrado");

            context.Categorias.Remove(categoria);
            context.SaveChanges();
            return Ok(categoria);
        }


    }
}
