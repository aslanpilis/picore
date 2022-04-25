using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataTables
{
    public class DatatablesObject
    {
        public string dbtype { get; set; }
        public int draw { get; set; }
        public dtcolumn[] columns { get; set; }
        public dtorder[] order { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public string dataqueryname { get; set; }
        public dtsearch search { get; set; }
        public string sortorder { get; }
        public IEnumerable<string> additionalvalues { get; set; }

    }
}
