using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosBFF.Core
{
    public class BusinessObject<T>
    {
        public bool HasError { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }

    }
}
