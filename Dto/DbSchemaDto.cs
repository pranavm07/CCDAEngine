using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class DbSchemaDto
    {
        public string DBName { get; set; }

        public string Schema { get; set; }

        public string TableName { get; set; }

        public string TableType { get; set; }
    }
}
