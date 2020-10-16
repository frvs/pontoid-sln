using System;
using Domain.Entities.LogExceptions.Interfaces;
using Domain.Entities.Schools;
using Domain.Entities.Schools.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/schools")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        private readonly ILogExceptionService _logExceptionService;

        public SchoolController(ISchoolService schoolService, ILogExceptionService logExceptionService)
        {
            _schoolService = schoolService;
            _logExceptionService = logExceptionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var response = _schoolService.GetAll();
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
                var response = _schoolService.GetById(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] School school)
        {
            try
            {
                var response = _schoolService.Create(school);
                return Created(school.Id, response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] School school)
        {
            try
            {
                _schoolService.Update(school);
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
                var response = _schoolService.Delete(id);
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
