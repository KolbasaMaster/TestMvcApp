using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Result : IEnumerable
    {
        public string Inn { get; set; }
        public string Name { get; set; }
        public int Sum { get; set; }
        public int RubSum { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}