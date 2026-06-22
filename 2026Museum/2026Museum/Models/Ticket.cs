using System;
using System.Collections.Generic;

namespace _2026Museum.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public string TicketType { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime SaleDate { get; set; }

    public int? VisitorId { get; set; }

    public virtual Visitor? Visitor { get; set; }
}
