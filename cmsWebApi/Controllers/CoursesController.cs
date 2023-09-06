using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cmsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        public CoursesController()
        {
            
        }

        [HttpGet]
        public string GetCourses(){
            return "Hello, World!";
        }

        
    }
}