using System;
using System.Collections.Generic;

namespace _2026Museum.Models;

public partial class Visitor
{
    public int VisitorId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<VisitedExhibit> VisitedExhibits { get; set; } = new List<VisitedExhibit>();
}
