using ApiOngMieAuEtc_e_Tal.Models;
using ApiOngMieAuEtc_e_Tal.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiOngMieAuEtc_e_Tal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdoptingController : ControllerBase
    {
        private readonly AdoptingService _adoptingService;

        public AdoptingController(AdoptingService adoptingService)
        {
            _adoptingService = adoptingService;
        }
        [HttpGet]
        public ActionResult<List<Adopting>> Get() => _adoptingService.Get();

        [HttpGet("{id:length(24)}", Name = "GetAdopting")]
        public ActionResult<Adopting> Get(string id)
        {
            var adopting = _adoptingService.Get(id);

            if (adopting == null)
                return NotFound();

            return Ok(adopting);
        }
        [HttpPost]
        public ActionResult<Adopting> Create(Adopting adopting)
        {
            _adoptingService.Create(adopting);
            return CreatedAtRoute("GetAdopting", new { id = adopting.Id.ToString() }, adopting);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Adopting adoptingIn)
        {
            var adopting = _adoptingService.Get(id);

            if (adopting == null)
            {
                return NotFound();
            }

            adoptingIn.Id = id;

            _adoptingService.Update(id, adoptingIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var adopting = _adoptingService.Get(id);

            if (adopting == null)
            {
                return NotFound();
            }

            _adoptingService.Remove(id);

            return NoContent();
        }
    }
}
