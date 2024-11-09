using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using API.Infrastructure;
using API.Model;
using API.ModelDto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoApiController : ControllerBase
    {
        private readonly IRepository repository;
        public TodoApiController(IRepository repository) => this.repository = repository;
        
        [HttpGet]
        public List<ToDo> GetAll() => repository.ReadAll();
        
         [HttpGet("{id}")]
        public ToDo GetById(int id) => repository.ReadById(id);

         [HttpDelete("{id}")]
        public bool Delete(int id) => repository.Remove(id);

        [HttpPost()]
        public ToDo Add(ToDoDto model) => repository.Append(model);
        
        //[HttpPut()]
        //public bool Update(int id, ToDoDto model) => repository.Update(id, model);
        }
}