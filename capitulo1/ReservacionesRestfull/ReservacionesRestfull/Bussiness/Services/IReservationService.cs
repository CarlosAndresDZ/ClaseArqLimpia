using ReservacionesRestfull.Bussiness.Entities;
using ReservacionesRestfull.Data.DTO_s;

namespace ReservacionesRestfull.Bussiness.Services
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        int Insert(ReservationDTO dto);
        List<Room> GetAvailableRooms();

    }
}
