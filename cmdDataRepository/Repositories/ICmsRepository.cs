using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmdDataRepository.Models;

namespace cmdDataRepository.Repositories
{
    public interface ICmsRepository
    {
        IEnumerable<Course> GetAllCourses();
    }
}