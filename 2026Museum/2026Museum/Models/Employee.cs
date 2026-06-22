using System;
using System.Collections.Generic;

namespace _2026Museum.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Excursion> Excursions { get; set; } = new List<Excursion>();
}
