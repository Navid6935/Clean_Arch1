using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using CleanArch.Domain.Models.Interfaces;
using CleanArch.Indra.Data.Repository;

namespace CleanArch.Application.Services
{

    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCources()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }


    }
}
