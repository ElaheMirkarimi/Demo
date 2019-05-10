using Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
