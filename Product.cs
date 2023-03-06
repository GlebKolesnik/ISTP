using System;
using System.Collections.Generic;

namespace BD2._0;

public partial class Product
{
    public int Id { get; set; }

    public int Clothes { get; set; }

    public int Shoes { get; set; }

    public int Accessories { get; set; }

    public virtual Accessory AccessoriesNavigation { get; set; } = null!;

    public virtual Clothe ClothesNavigation { get; set; } = null!;

    public virtual Shoe ShoesNavigation { get; set; } = null!;
}
