using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Negocio;
using WebApiExample.Data;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly TestDataBaseContext _context;

        public UsuariosController(TestDataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/GetUsiarios")]
        public async Task<IActionResult> GetUsuarios(string? id)
        {
            try
            {
                ClsUsuarios clsUsuarios = new ClsUsuarios(_context);
                var list = await clsUsuarios.GetUsuarios(id);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }

        }
    }
}
