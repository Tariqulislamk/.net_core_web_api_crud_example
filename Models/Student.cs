using System;
using System.Collections.Generic;

namespace DotNETCoreWebAPI.Models;

public partial class Student
{
    public int StId { get; set; }

    public string StName { get; set; } = null!;

    public string StClass { get; set; } = null!;
}
