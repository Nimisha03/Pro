using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Outlet.Demo.BusinessServices.contracts;
using Outlet.Demo.DataServices.Data.Entities;
using System.Collections.Generic;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Outlet.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletController : ControllerBase
    {
        private readonly IOutletService _outletservice;
        private readonly IMapper _mapper;
        public OutletController(IOutletService outletservice,IMapper mapper)
        {
            _outletservice = outletservice;
            _mapper = mapper;
        }

        // POST api/<OutletController>
        [HttpPost("api/verify/admin")]
        public bool Post(AdminDto adminmodel)
        {
            var adminorg = _mapper.Map<Admin>(adminmodel);
            return _outletservice.CheckAdmin( adminorg);
            
        }

        // GET: api/<OutletController>
        [HttpGet]
        public IEnumerable<OutletDto> Get()
        {
            var allmodel= _outletservice.GetAllOutlets();
            return _mapper.Map<IEnumerable<OutletDto>>(allmodel);
            
        }

        // GET api/<OutletController>/5
        [HttpGet("{id}")]
        public IEnumerable<OutletDto> Get(int id)
        {
            var output = _outletservice.GetAOutlet(id);
            return _mapper.Map<IEnumerable<OutletDto>>(output);
          
        }

        // POST api/<OutletController>
        [HttpPost]
        public bool Post(OutletDto outletmodel)
        {
            var outletin = _mapper.Map<Outlet1>(outletmodel);
            return _outletservice.AddOutlet((outletin));
        }

        // PUT api/<OutletController>/5
        [HttpPut("{id}")]
        public bool Put(int id, OutletDto outletmodel)
        {
            var outlet = _mapper.Map<Outlet1>(outletmodel);
            var result = _outletservice.UpdateOutlet(id, outlet);
            return result;
        }

        // DELETE api/<OutletController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var response = _outletservice.DeleteOutlet(id);
            return response;
        }

        
    }
}
