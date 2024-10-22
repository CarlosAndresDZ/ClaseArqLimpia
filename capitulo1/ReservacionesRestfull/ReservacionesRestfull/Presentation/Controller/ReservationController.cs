using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservacionesRestfull.Bussiness.Services;
using ReservacionesRestfull.Data.DTO_s;

namespace ReservacionesRestfull.Presentation.Controller
{
    [Route("api/[controller]")]  //http://ip:port/api/Reservation
    [ApiController]

    //POST --> insert
    //PUT --> Update
    //PATCH --> actualizacion parcial
    //GET --> Consultas
    //DELETE --> Borrar
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public IActionResult Create ([FromBody]ReservationDTO dto)
        {
            try { 
                var result = _reservationService.Insert(dto);
                return result>0 ? Created() : BadRequest();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet] //http://ip:port/api/Reservation
        public IActionResult GetAll()
        {
            return Ok(_reservationService.GetAll());
        }

        [HttpGet("rooms")] //http://ip:port/api/Reservation/rooms
        public IActionResult GetAvailableRooms()
        {
            return Ok(_reservationService.GetAvailableRooms());
        }
    }
}
