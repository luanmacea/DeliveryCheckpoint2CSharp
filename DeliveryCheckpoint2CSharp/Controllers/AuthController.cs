using DeliveryCheckpoint2CSharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DeliveryCheckpoint2CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Username == model.Username && u.SenhaHash == model.Senha);

            if (usuario == null)
                return Unauthorized("Usuário ou senha inválidos.");

            // Aqui deveria retornar token JWT ou similar, mas por simplicidade retorna dados básicos.
            return Ok(new { usuario.Id, usuario.Username, usuario.Tipo });
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Senha { get; set; }
    }
}
