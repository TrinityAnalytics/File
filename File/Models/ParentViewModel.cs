using System;
using System.Collections.Generic;

namespace File.Models
{
    public class ParentViewModel
    {
        public string name { get; set; }

        public List<ChildViewModel> listChilds { get; set; }
    }
}