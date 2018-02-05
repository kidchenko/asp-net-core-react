using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        // GET api/todos
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return new Todo[] { new Todo { Id = 1, Text = "value1"} , new Todo { Id = 2, Text = "value2"} };
        }

        // GET api/todos/5
        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            return new Todo{ Id = id, Text = "Todo" };
        }

        // POST api/todos
        [HttpPost]
        public IActionResult Post([FromBody]Todo todo)
        {
            return CreatedAtAction("Get", new { id = todo.Id}, todo);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
    public class Todo 
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
