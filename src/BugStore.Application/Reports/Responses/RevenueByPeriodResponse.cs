﻿namespace BugStore.Domain.Responses.Reports
{
    public class RevenueByPeriodResponse
    {
        public int Year { get; set; }
        public string Month { get; set; } = string.Empty;
        public int TotalOrders { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
