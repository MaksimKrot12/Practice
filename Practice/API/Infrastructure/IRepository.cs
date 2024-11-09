using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using API.ModelDto;

namespace API.Infrastructure
{
    public interface IRepository
    {
        List<ToDo> ReadAll();
        ToDo ReadById(int id);
        bool Remove (int id);
        ToDo Append(ToDoDto toDoDto );
    }   //bool Update(int id);
}