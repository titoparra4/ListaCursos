using ListaCursos.Interfaces;
using ListaCursos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ListaCursos.Provider
{
    public class WebApiCoursesprovider : ICoursesProvider
    {
        private readonly IHttpClientFactory httpClientFactory;

        public WebApiCoursesprovider(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public Task<(bool IsSuccess, int? Id)> AddAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Course>> GetAllAsync()
        {
            var client = httpClientFactory.CreateClient("coursesService");

            var response = await client.GetAsync("api/courses");

            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                //var results = JsonSerializer.Parse<ICollection<Course>>(content, new JsonSerializerOption() { PropertyNameCaseInsensitive = true });

                //return results;
            }

            return null;
        }

        public Task<Course> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Course>> SearchAsync(string search)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
