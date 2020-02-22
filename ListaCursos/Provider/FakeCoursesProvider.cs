using ListaCursos.Interfaces;
using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Provider
{
    public class FakeCoursesProvider : ICoursesProvider
    {
        private readonly List<Course> repo = new List<Course>();
        public FakeCoursesProvider()
        {
            repo.Add(new Course()
            {
                Id = 1,
                Name = ".Net Core",
                Author = "Tito Parra",
                Description = "Conoce los principios de .Net Core",
                Uri = "https://titoparra.com"
            });
            repo.Add(new Course()
            {
                Id = 2,
                Name = "MSSQL",
                Author = "Tito Parra",
                Description = "Conoce los principios de MSSQL",
                Uri = "https://titoparra.com"
            });
            repo.Add(new Course()
            {
                Id = 3,
                Name = "Xamarin",
                Author = "Tito Parra",
                Description = "Conoce los principios de Xamarin",
                Uri = "https://titoparra.com"
            });
        }
        public Task<ICollection<Course>> GetAllAsync()
        {
            return Task.FromResult((ICollection<Course>)repo.ToList());
        }

        public Task<Course> GetAsync(int id)
        {
            return Task.FromResult(repo.FirstOrDefault(c => c.Id == id));
        }

        public Task<ICollection<Course>> SearchAsync(string search)
        {
            return Task.FromResult((ICollection<Course>)repo.Where(c => c.Name.ToLowerInvariant().Contains(search.ToLowerInvariant())).ToList());
        }

        public Task<bool> UpdateAsync(int id, Course course)
        {
            var courseToUpdate = repo.FirstOrDefault(c => c.Id == id);
            if(courseToUpdate != null)
            {
                courseToUpdate.Name = course.Name;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Author = course.Author;
                courseToUpdate.Uri = course.Uri;

                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
