using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class NcProgram
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public string Comment { get; set; }
        public string Path { get; set; }
    }
}
