using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Reservoom.Exceptions;

public class ReservationConflictException : Exception
{
    public Reservation ExistingReservation { get; }
    public Reservation IncomingReservation { get; }


    public ReservationConflictException(Reservation existingReservation)
    {
    }

    public ReservationConflictException(string? message, Reservation existingReservation, Reservation incomingReservation) : base(message)
    {
        ExistingReservation = existingReservation;
        IncomingReservation = incomingReservation;
    }

    public ReservationConflictException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ReservationConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public override bool Equals(object? obj)
    {
        return obj is ReservationConflictException exception &&
               EqualityComparer<Reservation>.Default.Equals(ExistingReservation, exception.ExistingReservation) &&
               EqualityComparer<Reservation>.Default.Equals(IncomingReservation, exception.IncomingReservation);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ExistingReservation, IncomingReservation);
    }
}
