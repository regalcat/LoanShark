using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S_E_319
{
    class MiscItem : ItemBaseClass
    {
        #region Constructors

        public MiscItem(string name, string owner, string category)
        {
            Name = name;
            Owner = owner;
            Borrower = "N/A";
            Category = category;
        }

        public MiscItem(XmlNode node)
            : base(node)
        { }

        #endregion
    }
}
