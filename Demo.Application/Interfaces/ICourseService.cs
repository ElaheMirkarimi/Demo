using Demo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
