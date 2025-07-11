﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAllStudents() 
        {
            string[] studentsArray = new string[] { "John", "Jane", "Mark", "Dave", "Phil"};
            return Ok(studentsArray);
        }
    }
}
