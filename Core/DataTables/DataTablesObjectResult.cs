using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataTables
{
    public  class DataTablesObjectResult
    {
        public DataTablesObjectResult()
        {
            data = new List<object>();
        }
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<object> data { get; set; }

    }
}
