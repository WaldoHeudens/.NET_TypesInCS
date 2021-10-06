using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesInCS
{
    internal class TestClass
    {
        public int Id {  get; set; }
        public string Name {  get; set; }  

        public TestClass()
        {
            // Als goede praktijk:  Voorzie altijd een default-constructor, als ook een andere constructor aanwezig is
        }

        public TestClass (int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name:" + Name;
        }
    }
}
