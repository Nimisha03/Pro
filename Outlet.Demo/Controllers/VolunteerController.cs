using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Outlet.Demo.BusinessServices.contracts;
using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Outlet.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private readonly IVolunteerService _volunteerservice;
        private readonly IMapper _mapper;
        public  VolunteerController(IVolunteerService volunteerservice,IMapper mapper)
        {
            _volunteerservice = volunteerservice;
            _mapper = mapper;
        }
        //// GET: api/<VolunteerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<VolunteerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<OutletController>
        [HttpPost("api/register/volunteers")]
        public bool Post([FromBody] VolunteerDto volunteermodel)
        {
            var volunteer = _mapper.Map<Volunteer>(volunteermodel);
            var register = _volunteerservice.AddVolunteer(volunteer);
            return register;
        }

        //// PUT api/<VolunteerController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<VolunteerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
