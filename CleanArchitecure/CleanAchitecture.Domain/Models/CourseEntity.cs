﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanAchitecture.Domain.Models
{
    public class CourseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
