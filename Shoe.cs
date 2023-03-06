﻿using System;
using System.Collections.Generic;

namespace BD2._0;

public partial class Shoe
{
    public int Id { get; set; }

    public int Color { get; set; }

    public int Type { get; set; }

    public int Size { get; set; }

    public int Brand { get; set; }

    public int Price { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
