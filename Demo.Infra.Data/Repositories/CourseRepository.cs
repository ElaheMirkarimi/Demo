using Demo.Domain.Interfaces;
using Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private DemoDBContext _context;

        public CourseRepository(DemoDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
