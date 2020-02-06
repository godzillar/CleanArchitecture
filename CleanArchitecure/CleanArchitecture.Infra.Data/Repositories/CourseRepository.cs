using CleanAchitecture.Domain.Interfaces;
using CleanAchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext context;

        public CourseRepository(UniversityDBContext context) {
            this.context = context;
        }

        public void Add(CourseEntity course)
        {
            context.Add(course);
            context.SaveChanges();
        }

        public IEnumerable<CourseEntity> GetCourses()
        {
            return context.Courses;
        }
    }
}
