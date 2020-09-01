using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;
using CleanArch.Domain.Models.Interfaces;
using CleanArch.Indra.Data.Context;

namespace CleanArch.Indra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UnivercityDBContext _context;

        public CourseRepository(UnivercityDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
