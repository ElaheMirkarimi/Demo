using Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
