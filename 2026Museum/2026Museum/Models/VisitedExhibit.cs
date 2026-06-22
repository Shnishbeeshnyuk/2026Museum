using System;
using System.Collections.Generic;

namespace _2026Museum.Models;

public partial class VisitedExhibit
{
    public int VisitorId { get; set; }

    public int ExhibitId { get; set; }

    public DateTime VisitDate { get; set; }

    public virtual Exhibit Exhibit { get; set; } = null!;

    public virtual Visitor Visitor { get; set; } = null!;
}
