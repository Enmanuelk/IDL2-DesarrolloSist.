using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAplication

namespace WebAplication
{
    [ApiController]

    [Route("api/autores")]
    public class AutoresControllers: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AutoresControllers(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<IActionResult<List<AutoresControllers>>> Get() 
        {
            return await context.Autores.ToListAsync();
        }

        [HttpGet]

        public async Task<IActionResult<Post (Autor autor)
        {
            context.Add(autor);
            await context.SaveChanged
        }
    }
}
