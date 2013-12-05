
/* used to store and test some code but fell out of use
 * 
 * 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
 
namespace S_E_319
{
    class Database
    {
        List<ItemBaseClass> database;

        public Database()
        {
            database = new List<ItemBaseClass>();
        }

        public Database(String file) : this()
        {
            load(file);
        }

        public Database search(String search)
        {
            Database found = new Database();
            foreach (BookItem b in database)
            {
                if(b.getSearchValues().Contains(search))
                    found.add(b);
            }
            return found;
        }

        public ItemBaseClass get(int item)
        {
            return database[item];
        }

        public void replace(int item, BookItem book)
        {
            database[item] = book;
        }

        public void replace(BookItem old, BookItem young)
        {
            database.Remove(old);
            database.Add(young);
        }

        public void add(ItemBaseClass book)
        {
            database.Add(book);
        }

        public void delete(int item)
        {
            database.RemoveAt(item);
        }

        public void add(string name, string author, string isbn, string owner, string category)
        {
            database.Add(new BookItem(name, author, isbn, owner, category));
        }

        public void delete(BookItem book)
        {
            database.Remove(book);
        }

        public void load(String file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNode root = doc.FirstChild;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                if(root.ChildNodes[i].Name.Equals("book"))
                    add(new BookItem(root.ChildNodes[i]));
                else
                    add(new MiscItem(root.ChildNodes[i]));
            }
        }

        public void save(String file)
        {
            XmlDocument xml = new XmlDocument();
            XmlElement cur, root;
            root = xml.CreateElement("root");
            ItemBaseClass book;
            for (int i = 0; i < database.Count; i++)
            {
                // setting attributes is not the best way to do this
                // but i didn't feel like messing around with right now
                // probably will be implemented in a day or two
                book = database[i];
                cur = xml.CreateElement(book.type());
                book.putIntoElement(cur);
                root.AppendChild(cur);
            }
            xml.Save(file);
        }

    }
}
*/