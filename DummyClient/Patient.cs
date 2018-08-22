using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DummyClient
{
  public class Patient
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }

        public string ForeignLeyColumn { get; set; }
    }
}
