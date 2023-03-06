using System;
using System.Collections.Generic;

namespace BD2._0;

public partial class Size
{
    public int Id { get; set; }

    public int Size1 { get; set; }

    public virtual ICollection<Clothe> Clothes { get; } = new List<Clothe>();
}
