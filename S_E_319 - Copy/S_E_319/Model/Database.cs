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
        List<BookItem> database;

        public Database()
        {
            database = new List<BookItem>();
        }

        public Database(String file) : this()
        {
            load(file);
        }

        public void replace(int item, BookItem book)
        {
            database[item] = book;
        }

        public void load(String file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNode root = doc.FirstChild;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                database.Add(new BookItem(root.ChildNodes[i]));
            }
        }

        public void save(String file)
        {
            XmlDocument xml = new XmlDocument();
            XmlElement cur;
            BookItem book;
            for (int i = 0; i < database.Count; i++)
            {
                book = database[i];
                cur = xml.CreateElement("item");
                cur.SetAttribute("author", book.Author);
                cur.SetAttribute("isbn", book.ISBN);
                cur.SetAttribute("name", book.Name);
                cur.SetAttribute("owner", book.Owner);
                cur.SetAttribute("borrower", book.Borrower);
                cur.SetAttribute("category", book.Category);
            }
            xml.Save(file);
        }

    }
}
