using System;
using System.Collections.Generic;

namespace Academy.Models;

public partial class Holiday
{
    public byte HolidayId { get; set; }

    public string HolidayName { get; set; } = null!;

    public byte Diration { get; set; }

    public byte? Month { get; set; }

    public byte? Day { get; set; }

    public virtual ICollection<DaysOff> DaysOffs { get; set; } = new List<DaysOff>();
}
