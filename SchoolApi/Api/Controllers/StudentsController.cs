using System;
using Domain.Entities.LogExceptions.Interfaces;
using Domain.Entities.Students;
using Domain.Entities.Students.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogExceptionService _logExceptionService;
        public StudentsController(IStudentService studentService, ILogExceptionService logExceptionService)
        {
            _studentService = studentService;
            _logExceptionService = logExceptionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var response = _studentService.GetAll();
                return Ok(response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] string id)
        {
            try
            {
                var response = _studentService.GetById(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            try
            {
                var response = _studentService.Create(student);
                return Created(student.Id, response);

            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Student student)
        {
            try
            {
                _studentService.Update(student);
                return Ok();
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] string id)
        {
            try
            {
                var response = _studentService.Delete(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }
    }
}
