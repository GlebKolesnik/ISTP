using System;
using System.Collections.Generic;

namespace BD2._0;

public partial class Type
{
    public int Id { get; set; }

    public int Type1 { get; set; }

    public virtual ICollection<Clothe> Clothes { get; } = new List<Clothe>();
}
