using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication
{
    public class Result : IEnumerable
    {
        public string Inn { get; set; }
        public int Sum { get; set; }
        public int RumSum { get; set; }
        public int Deliverys { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}