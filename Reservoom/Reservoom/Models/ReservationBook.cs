﻿using System.Collections.Generic;
using System.Linq;

namespace Reservoom.Models;

public class ReservationBook
{
    private readonly List<Reservation> _reservations;
    public ReservationBook()
    {
        _reservations = new List<Reservation>();
    }

    public IEnumerable<Reservation> GetReservationsForUser(string username)
    {
        return _reservations.Where(r => r.Username == username);
    }

    public void AddReservation(Reservation reservation)
    {
        foreach (Reservation existingReservation in _reservations)
        {
            if (existingReservation.Conflicts(reservation))
            {
                throw new ReservationConflictException();
            }
        }

        _reservations.Add(reservation);
    }

}
