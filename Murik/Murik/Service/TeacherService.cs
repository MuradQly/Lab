using Murik.Entities;
using System.Text.Json;

namespace Murik.Service
{
    internal class TeacherService : IService<Teacher>
    {
        private DbEntity _db;
        public TeacherService()
        {
            _db = GetDbEntity();
        }

        public void Add(Teacher entity)
        {
            _db.Teachers.Add(entity);
        }

        public void Delete(int id)
        {
            foreach (var teacher in _db.Teachers)
            {
                if (teacher.Id == id)
                {
                    _db.Teachers.Remove(teacher);
                }
            }
        }

        public Teacher Get(int id)
        {
            foreach (var teacher in _db.Teachers)
            {
                if(teacher.Id == id) return teacher;
            }
            return null;
        }

        public List<Teacher> GetAll()
        {
            List<Teacher> result = new List<Teacher>();
            result = _db.Teachers;
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
