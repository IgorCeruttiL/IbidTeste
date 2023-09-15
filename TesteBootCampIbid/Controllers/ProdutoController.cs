using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using TesteBootCampIbid.Data;
using TesteBootCampIbid.Models;

namespace TesteBootCampIbid.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("produtos")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {
            try
            {
                var produtos = await context.Produtos.ToListAsync();
                return Ok(produtos);
            }
            catch
            {
                return StatusCode(500, "Falha interna");
            }
        }
        [HttpGet("produto/{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id, [FromServices] AppDbContext context)
        {
            try
            {
                var produto = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
                if (produto == null)
                    return NotFound("Produto não encontrado");
                return Ok(produto);
            }
            catch
            {
                return StatusCode(500, "Falha interna");
            }
        }

        [HttpPost("produto")]
        public async Task<IActionResult> PostAsync([FromBody] Produto produto, [FromServices] AppDbContext context)
        {
            var model = new Produto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                ProdutoCategoriaId = produto.ProdutoCategoriaId,
            };

            context.Produtos.Add(model);
            await context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut("produto/{id:int}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] Produto produtoAtualizado, [FromServices] AppDbContext context)
        {
            var model = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
                return NotFound("Produto não encontrado");

            model.Nome = produtoAtualizado.Nome;
            model.Descricao = produtoAtualizado.Descricao;

            try
            {
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Falha interna");
            }
        }


        [HttpDelete("produto/{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var model = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
                return NotFound("Não encontrado");

            context.Produtos.Remove(model);
            await context.SaveChangesAsync();
            return Ok(model);
        }
    }
}
