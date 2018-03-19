using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Services
{
    public class Service1
    {
        public Service2 _service { get; set; }

        public Service1(Service2 s2)
        {
            _service = s2;
        }

        public void Call()
        {
            _service.Call();
        }
    }
}
