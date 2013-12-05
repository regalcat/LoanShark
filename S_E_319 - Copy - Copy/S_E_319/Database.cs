using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections.Generic;

namespace S_E_319
{
    class Database
    {
        List<BookItem> BookItem;

        public Database()
        {
            database = new List<BookItem>();
        }

        public Database(String file) : this()
        {
            load(file);
        }

        public void edit(int item)
        {
            database.edit(item);
        }

        public void load(String file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNode root = doc.getFirstChild();
            XmlNode current;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                database.append(new BookItem(root.ChildNotes[i]);
            }
        }

        public void save(String file)
        {
            XmlDocument xml = new XmlDocument();
            XmlElement cur;
            Xmlnode node;
            for (int i = 0; i < database.length; i++)
            {
                node = database[i];
                cur = xml.createElement("item");
                cur.setAttribute("author", node.getAuthor());
                cur.setAttribute("isbn", node.getISBN());
                cur.setAttribute("name", node.getName());
                cur.setAttribute("owner", node.getOwner());
                cur.setAttribute("borrower", node.getBorrower());
                cur.setAttribute("category", node.getCategory());
            }
            xml.save(file);
        }

    }
}
