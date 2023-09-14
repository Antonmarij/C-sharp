using System.Collections.Generic;

namespace Reservoom.Models;

public class ReservationBook
{
    private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservations;

    public ReservationBook()
    {
        _roomsToReservations = new Dictionary<RoomID, List<Reservation>>();
    }
}
