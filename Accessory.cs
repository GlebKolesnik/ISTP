using System;
using System.Collections.Generic;

namespace BD2._0;

public partial class Accessory
{
    public int Id { get; set; }

    public int Type { get; set; }

    public int Brand { get; set; }

    public int Price { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
