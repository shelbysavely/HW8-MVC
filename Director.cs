﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MVC10.Models;

public partial class Director
{
    public string DirectorName { get; set; }

    public int DirectorId { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}