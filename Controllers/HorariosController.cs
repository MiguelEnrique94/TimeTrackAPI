using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TimeTrackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : ControllerBase
    {
        private List<DateTime> horarios = new List<DateTime>(); // Use uma estrutura de dados adequada para armazenar os horários

        // GET: api/horarios
        [HttpGet]
        public ActionResult<IEnumerable<DateTime>> GetHorarios()
        {
            return Ok(horarios);
        }

        // POST: api/horarios
        [HttpPost]
        public ActionResult AddHorario(DateTime horario)
        {
            horarios.Add(horario);
            return Ok();
        }

        // DELETE: api/horarios/{horario}
        [HttpDelete("{horario}")]
        public ActionResult RemoveHorario(DateTime horario)
        {
            horarios.Remove(horario);
            return Ok();
        }

    }
}