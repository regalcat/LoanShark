using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S_E_319
{ 
    abstract class ItemBaseClass
    {
        public string Name { get; protected set; }
        public string Owner { get; protected set; }
        public string Borrower { get; protected set; }
        public string Category { get; protected set; }

        public string type() { return "item"; }

        public ItemBaseClass() { }

        public ItemBaseClass(XmlNode node)
        {
            XmlAttributeCollection attributes = node.Attributes;
            if (attributes.GetNamedItem("owner") != null)
                Owner = attributes.GetNamedItem("owner").Value;
            else
                Owner = "";
            if (attributes.GetNamedItem("borrower") != null)
                Borrower = attributes.GetNamedItem("borrower").Value;
            else
                Borrower = "";
            if (attributes.GetNamedItem("category") != null)
                Category = attributes.GetNamedItem("category").Value;
            else
                Category = "";
        }

        public virtual void putIntoElement(XmlElement cur)
        {
            cur.SetAttribute("name", Name);
            cur.SetAttribute("owner", Owner);
            cur.SetAttribute("borrower", Borrower);
            cur.SetAttribute("category", Category);
        }

        public virtual string getSearchValues()
        {
            return Name + Owner + Borrower + Category;
        }
        
    }
}
