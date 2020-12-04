using ApiAuto.Contexts;
using ApiAuto.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppBDContext context;
        public UsuarioController(AppBDContext context)
        {
            this.context = context;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return context.usuarios.ToList();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public Usuario Get(long id)
        {
            var usuario = context.usuarios.FirstOrDefault(u => u.usuario_id == id);
            return usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                context.usuarios.Add(usuario);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] Usuario usuario)
        {
            if (usuario.usuario_id == id)
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var usuario = context.usuarios.FirstOrDefault(u => u.usuario_id == id);
            if (usuario != null)
            {
                context.usuarios.Remove(usuario);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}