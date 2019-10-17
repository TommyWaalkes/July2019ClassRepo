using System;
using System.Collections.Generic;

namespace EntityDbFirst
{
    public partial class Cat
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public bool? IsDeclawed { get; set; }
    }
}
