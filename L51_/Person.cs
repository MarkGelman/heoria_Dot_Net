using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L51_
{
    class Person
    {
        private string name;
        public string Name { 
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        public override string ToString()
        {
            return $"Person name {Name}";
        }
    }
}
