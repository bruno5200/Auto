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
    public class TiempoController : ControllerBase
    {
        private readonly AppBDContext context;
        public TiempoController(AppBDContext context)
        {
            this.context = context;
        }
        // GET: api/<TiempoController>
        [HttpGet]
        public IEnumerable<Tiempo> Get()
        {
            return context.tiempo.ToList();
        }

        // GET api/<TiempoController>/5
        [HttpGet("{id}")]
        public Tiempo Get(long id)
        {
            var tiempo = context.tiempo.FirstOrDefault(t => t.tiempo_id == id);
            return tiempo;
        }

        // POST api/<TiempoController>
        [HttpPost]
        public ActionResult Post([FromBody] Tiempo tiempo)
        {
            try
            {
                context.tiempo.Add(tiempo);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT api/<TiempoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] Tiempo tiempo)
        {
            if (tiempo.tiempo_id == id)
            {
                context.Entry(tiempo).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }

        // DELETE api/<TiempoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var tiempo = context.tiempo.FirstOrDefault(t => t.tiempo_id == id);
            if (tiempo != null)
            {
                context.tiempo.Remove(tiempo);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}