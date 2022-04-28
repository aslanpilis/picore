using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataTables
{
    public class dtcolumn
    {
        //public dtcolumn();

        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public dtsearch search { get; set; }
    }
}
