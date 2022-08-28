using WebApiExample.Data;
using WebApiExample.Models;

namespace WebApiExample.Negocio
{
    public class ClsUsuarios
    {
        private readonly TestDataBaseContext _context;

        public ClsUsuarios(TestDataBaseContext context)
        {
            _context = context;
        }
        public async Task<List<SpGetUsuariosResult>> GetUsuarios(string? IdUsuario)
        {
            IdUsuario = IdUsuario == null ? null : IdUsuario.ToString();
            List<SpGetUsuariosResult> ListUsuarios = await _context.GetProcedures().SpGetUsuariosAsync(IdUsuario);
            return ListUsuarios;
        }
        
    }
}
