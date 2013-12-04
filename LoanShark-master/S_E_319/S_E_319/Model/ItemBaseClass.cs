using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_E_319
{ 
    abstract class ItemBaseClass
    {
        public string Name { get; protected set; }
        public string Owner { get; protected set; }
        public string Borrower { get; protected set; }
        public string Category { get; protected set; }

        
    }
}
