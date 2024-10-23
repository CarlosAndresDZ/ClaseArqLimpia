﻿using EjercicioCapas.Bussiness.Entities;
using EjercicioCapas.Data.DTO_s;
using EjercicioCapas.Data.Repositories;

namespace EjercicioCapas.Bussiness.Services
{
    public class BookServiceImpl : IBookService
    {
        private readonly AutorRepository _userRepository;
        private readonly ReservationRepository _reservationRepository;
        private readonly RoomRepository _roomRepository;

        public BookServiceImpl(UserRepository userRepository, 
            ReservationRepository reservationRepository, 
            RoomRepository roomRepository)
        {
            _reservationRepository = reservationRepository;
            _userRepository = userRepository;
            _roomRepository = roomRepository;

        }
        public List<Reservation> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public List<Room> GetAvailableRooms()
        {
            return _roomRepository.GetAvailable();
        }

        public int Insert(ReservationDTO dto)
        {
            //busqueda de usuario
            var user = new User();
            try
            {
                user = _userRepository.FindById(dto.UserId);
            }
            catch(Exception ex) { 
                Console.WriteLine($"No existe el Usuario {ex.Message}"); 
                throw ex;
            }

            //busqueda de cuarto
            var room = new Room();
            try
            {
                room = _roomRepository.FindbyId(dto.RoomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No existe el Cuarto {ex.Message}");
                throw ex;
            }

            if (room.Available)
            {
                Reservation reservation = new Reservation()
                {
                    UserId = dto.UserId,
                    RoomId = dto.RoomId,
                    Begin = dto.Begin,
                    End = dto.End
                };
                int result=_reservationRepository.Insert(reservation);
                room.Available = false;
                _roomRepository.Update(room);
                return result;
            }
            throw new Exception($"Habitacion no disponible {room.Id}");
        }




    }
}