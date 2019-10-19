using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();


        public StudentStore()


        {
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 25,
                Name = "Elkin",
                LastName = "Silva",
                Nit = "123456"
            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Juan",
                LastName = "Perez",
                Nit = "654123"
            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 20,
                Name = "Maria",
                LastName = "Perez",
                Nit = "789456"
            });
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents(){
            return this.Students;
        }
    }
}