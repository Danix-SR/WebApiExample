using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Negocio;
using WebApiExample.Data;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    /// <summary>
    /// Controlador Usuarios
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly TestDataBaseContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UsuariosController(TestDataBaseContext context)
        {
            _context = context;
        }

        // Documentacion APIs
        // https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0
        /// <summary>
        /// Get Usuarios por ID
        /// </summary>
        /// <remarks>
        /// Sample Request:
        ///     POST
        ///     
        ///     {
        ///         "date": "2022-08-28T03:12:01.110Z",
        ///         "temperatureC": 0,
        ///         "temperatureF": 0,
        ///         "summary": "string"
        ///     }
        /// </remarks>
        /// <response code = "200"> Bien </response>
        /// <response code = "400"> Mal </response>
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
