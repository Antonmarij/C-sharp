﻿using System;

namespace Reservoom.Models;

public class Reservation
{
    public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
    {
        RoomID = roomID;
        StartTime = startTime;
        EndTime = endTime;
    }

    public RoomID RoomID { get; }
    public string Username { get; }
    public DateTime StartTime { get; }
    public DateTime EndTime { get; }
    public TimeSpan Length
    {
        get
        {
            return EndTime.Subtract(StartTime);
        }
    }