using Murik.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Murik.Service
{
    internal class StudentService : IService<Student>
    {
        private DbEntity _db;
        public StudentService()
        {
            _db = new DbEntity();
        }
        public void Add(Student entity)
        {
            _db.Students.Add(entity);
        }
        public void Delete(int id)
        {
            foreach (var student in _db.Students)
            {
                if (student.Id == id)
                {
                    _db.Students.Remove(student);

                }
            }

        }
        public Student Get(int id)
            {
            foreach(var student in _db.Students)
            {
                if(student.Id == id) return student;
            }
            return null;
        }
        public List<Student>GetAll()
        {
            List<Student> result = new List<Student>();
            result = _db.Students;
            return result;
        }
        

        public void Save()
        {
            string json = JsonSerializer.Serialize(_db);
            File.WriteAllText("db.json", json);
        }

        private DbEntity GetDbEntity()
        {
            string json = File.ReadAllText("db.json");
            DbEntity db = JsonSerializer.Deserialize<DbEntity>(json);
            return db;

        }
    }
}
        



    

