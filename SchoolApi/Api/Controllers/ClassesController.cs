using System;
using Api.Dtos;
using Domain.Entities.Classes;
using Domain.Entities.Classes.Interfaces;
using Domain.Entities.LogExceptions.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/classes")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;
        private readonly ILogExceptionService _logExceptionService;

        public ClassesController(IClassService classService, ILogExceptionService logExceptionService)
        {
            _classService = classService;
            _logExceptionService = logExceptionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var response = _classService.GetAll();
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
                var response = _classService.GetById(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateClassDto classDto)
        {
            try
            {
                var response = _classService.Create(classDto.Class, classDto.SchoolId);
                return Created(classDto.Class.Id, response);
            }
            catch (Exception e)
            {
                _logExceptionService.LogException(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Class classe)
        {
            try
            {
                _classService.Update(classe);
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
                var response = _classService.Delete(id);
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
