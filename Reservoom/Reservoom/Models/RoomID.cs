using System;

namespace Reservoom.Models;

public class RoomID
{
    public RoomID(int floorNumber, int roomNumber)
    {
        FloorNumber = floorNumber;
        RoomNumber = roomNumber;
    }

    public override string ToString()
    {
        return $"{FloorNumber}:{RoomNumber}";
    }

    public int FloorNumber { get; }
    public int RoomNumber { get; }

    public override bool Equals(object? obj)
    {
        return obj is RoomID roomID &&
            FloorNumber == roomID.FloorNumber &&
            RoomNumber == roomID.RoomNumber;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FloorNumber, RoomNumber);
    }
}
