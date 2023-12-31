﻿using System.Collections;

namespace Reservoom.Models;

public class Hotel
{
    private readonly ReservationBook _reservationBook;

    public string Name { get; }

    public Hotel(string name)
    {
        Name = name;

        _reservationBook = new ReservationBook();
    }

    public IEnumerable<Reservation> GetReservationsForUser(string username)
    {
        return _reservationBook.GetReservationsForUser(username);
    }

    public void MakeReservation(Reservation reservation)
    {
        _reservationBook.AddReservation(reservation);
    }
}
