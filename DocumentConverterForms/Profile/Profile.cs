using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverterForms
{
    public class Profile
    {
        public string Name { get; set; }
        public int ProfileKey { get; set; }
        public ExcelParseSettings ExcelParseSettings { get; set; }
        public FileConversionSettings FileConversionSettings { get; set; }
    }
}
