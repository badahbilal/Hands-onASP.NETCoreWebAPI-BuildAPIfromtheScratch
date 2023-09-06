using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmdDataRepository.Models;
using System.Collections;

namespace cmdDataRepository.Repositories
{
    public class InMemoryCmsRepository : ICmsRepository
    {
        public InMemoryCmsRepository()
        {
            
        }

        public IEnumerable<Course> GetAllCourses(){
            
            return new List<Course>();
        }
    }
}