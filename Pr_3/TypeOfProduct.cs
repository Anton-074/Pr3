﻿using System;
using System.Collections.Generic;

namespace Pr_3;

public partial class TypeOfProduct
{
    public int Id { get; set; }

    public string TypeOfProduct1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}