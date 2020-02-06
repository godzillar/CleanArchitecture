using CleanAchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanAchitecture.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<CourseEntity> GetCourses();

        void Add(CourseEntity course);
    }
}
