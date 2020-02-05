using CleanAchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<CourseEntity> Courses { get; set; }
    }
}
