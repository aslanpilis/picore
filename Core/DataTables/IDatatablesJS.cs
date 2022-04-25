using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataTables
{
    public interface IDatatablesJS
    {
        public DataTablesObjectResult getresults(DatatablesObject filters, string tablename, string privatewhere);

    }
}
