using System;
using System.Collections.Generic;

namespace _2026Museum.Models;

public partial class Exhibit
{
    public int ExhibitId { get; set; }

    public string UniqueNumber { get; set; } = null!;

    public string ExhibitName { get; set; } = null!;

    public string ExhibitType { get; set; } = null!;

    public int? HallId { get; set; }

    public virtual Hall? Hall { get; set; }

    public virtual ICollection<VisitedExhibit> VisitedExhibits { get; set; } = new List<VisitedExhibit>();
}
