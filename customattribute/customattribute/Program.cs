using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customattribute
{

    [AttributeUsage(AttributeTargets.Class |
      AttributeTargets.Constructor |
      AttributeTargets.Field |
      AttributeTargets.Method |
      AttributeTargets.Parameter |
      AttributeTargets.Property,
      AllowMultiple = true)]

    public class Customattribute : Attribute
    {
       

        public int eid { get; set; }
        public string ename { get; set; }
        public int eage { get; set; }


    }
}
