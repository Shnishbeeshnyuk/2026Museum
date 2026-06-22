using System;
using System.Collections.Generic;

namespace _2026Museum.Models;

public partial class Excursion
{
    public int ExcursionId { get; set; }

    public string ExcursionName { get; set; } = null!;

    public DateTime ExcursionDate { get; set; }

    public int MaxParticipants { get; set; }

    public int? GuideId { get; set; }

    public virtual Employee? Guide { get; set; }
}
