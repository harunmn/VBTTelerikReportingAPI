﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VBTTelerikReportingAPI.Entities
{
    public partial class SummaryOfSalesByYear
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
