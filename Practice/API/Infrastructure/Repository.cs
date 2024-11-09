using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using API.ModelDto;

namespace API.Infrastructure
{
    public class Repository : IRepository 
    {
        List <ToDo> db;
        public Repository()
        {
            db = new List<ToDo>
            {
            new ToDo{ Id=1,Text="Текст 1",Title="Title 1" },
            new ToDo{ Id=2,Text="Текст 2",Title="Title 2" },
            new ToDo{ Id=3,Text="Текст 3",Title="Title 3" },
            };
        }

        public ToDo Append(ToDoDto toDoDto)
        {
          int id = db.Max(x => x.Id)+1;
           ToDo model = new ToDo
           {
            Id = id,
            Text = toDoDto.Text,
            Title = toDoDto.Title,
           };
           db.Add(model);
           return model;
        }

        public List<ToDo> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ToDo ReadById(int id)
         {
            for (int i = 0; i < db.Count; i++)
            {
           if(db[i].Id == id) return db[i];
            }
            return null;
         }

         public bool Remove(int id)
         {
             for (int i = 0; i < db.Count; i++)
            {
              if(db[i].Id == id) 
              {
                db.RemoveAt(i);
                return true;
              }
            }
            return false;
         }
    }
}