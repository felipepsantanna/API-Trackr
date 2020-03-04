using System.Linq;
using System.Threading.Tasks;
using API.TRACKR.Data;
using API.TRACKR.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.TRACKR.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IConfiguration _config;
        public UsuariosController(IConfiguration config)
        {
            _config = config;
        }

        // GET usuarios
        [HttpGet]
        public JsonResult Get()
        {
            Usuario u = new Usuario();
            u.ID = 1;
            u.Nome = "jose";
            u.Email = "jose@jose.com.br";

            List<Usuario> us = new List<Usuario>();
            us.Add(u);


            return Json(us);
        }

        // GET usuarios/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return id.ToString();
        }


        //POST usuario
        [HttpPost]
        public bool Post([FromBody] string value)
        {
            return true;
        }

    }
}