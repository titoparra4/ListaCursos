﻿using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Interfaces
{
    public interface ICoursesProvider
    {
        Task<ICollection<Course>> GetAllAsync();

        Task<ICollection<Course>> SearchAsync(string search);

        Task<Course> GetAsync(int id);
    }
}
