﻿using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;
        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
