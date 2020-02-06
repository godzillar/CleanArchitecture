using CleanAchitecture.Domain.Commands;
using CleanAchitecture.Domain.Interfaces;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        private readonly IMediatorHandler bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus) {
            this.courseRepository = courseRepository;
            this.bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var command = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);
            
            bus.SendCommand(command);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = courseRepository.GetCourses()
            };
        }
    }
}
