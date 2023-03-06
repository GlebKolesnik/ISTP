using System;
using System.Collections.Generic;

namespace BD2._0;

public partial class Clothe
{
    public int Id { get; set; }

    public int Color { get; set; }

    public int Type { get; set; }

    public int Size { get; set; }

    public int Brand { get; set; }

    public int Price { get; set; }

    public virtual Brand BrandNavigation { get; set; } = null!;

    public virtual Color ColorNavigation { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual Size SizeNavigation { get; set; } = null!;

    public virtual Type TypeNavigation { get; set; } = null!;
}
