﻿using System;

namespace BookFast.Contracts.Models
{
    public class BookingDetails
    {
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset ToDate { get; set; }
    }
}