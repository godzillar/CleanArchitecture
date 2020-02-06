﻿using CleanAchitecture.Domain.Commands;
using CleanAchitecture.Domain.Interfaces;
using CleanAchitecture.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanAchitecture.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new CourseEntity()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            courseRepository.Add(course);

            return Task.FromResult(true);
        }
    }
}
