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
    public class AutoController : ControllerBase
    {
        private readonly AppBDContext context;
        public AutoController(AppBDContext context)
        {
            this.context = context;
        }
        // GET: api/<AutoController>
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return context.autos.ToList();
        }

        // GET api/<AutoController>/5
        [HttpGet("{id}")]
        public Auto Get(long id)
        {
            var auto = context.autos.FirstOrDefault(a => a.auto_id == id);
            return auto;
        }

        // POST api/<AutoController>
        [HttpPost]
        public ActionResult Post([FromBody] Auto auto)
        {
            try
            {
                context.autos.Add(auto);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT api/<AutoController>/2
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] Auto auto)
        {
            if (auto.auto_id == id)
            {
                context.Entry(auto).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }

        // DELETE api/<AutoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var auto = context.autos.FirstOrDefault(a => a.auto_id == id);
            if (auto != null)
            {
                context.autos.Remove(auto);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}