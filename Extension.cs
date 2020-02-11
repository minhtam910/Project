using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using LinqToExcel.Attributes;

namespace Project
{
    class Extension
    {
        [ExcelColumn("Extension")]
        public String ExtensionID { get; set; }
        [ExcelColumn("Note")]
        public String Note { get; set; }
    }
}
