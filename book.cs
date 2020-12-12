using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LybraryManagent
{

    public interface Ibook
    {
        int ID { get; set; }
        int quantity { get; set; }
        string bookname { get; set; }
        string booktype { get; set; }
        string authorname { get; set; }
        DateTime Publishdate { get; set; }
    }
    public class book:Ibook
    {
        int id;
        string Bookname;
        string type;
        string author;
        int Quantity;
        DateTime date;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }

        public string bookname
        {
            get
            {
                return Bookname;
            }
            set
            {
                Bookname = value;
            }
        }

        public string booktype
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string authorname
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public DateTime Publishdate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    



        
        public book()
        {
            ID = 0;
            bookname = "";
            booktype = "";
            authorname = "";
            quantity = 0;
            Publishdate = DateTime.Today;
        }
      
        
       
        //ArrayList booklist = new ArrayList();
       //public Dictionary<int, book> booklist = new Dictionary<int, book>();

        



        
        public  book(int _id, string _Bookname, string _type, string _author, int _Quantity, DateTime _date)
        {
            ID = _id;
            bookname = _Bookname;
            booktype = _type;
            authorname = _author;
            quantity = _Quantity;
            Publishdate = _date;
        }

        

        public void Display()
        {
            Console.WriteLine("Book Name:" + this.Bookname);
            Console.WriteLine("Book Type:" + this.type);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Publishing Date:" + this.date);
            
        }
       




        static int BID = 0;
        public void Booklist()
        {
           List<book> bklist = new List<book>();

           
            ID = ++BID;

          
            Console.Write("Name of book:");
            bookname = Console.ReadLine();
            

            Console.Write("Publish date: ");
            DateTime dt;
            while (!DateTime.TryParse(Console.ReadLine(), out dt))
                Console.Write("Re enter Publish date:");
            Publishdate = dt;
           


            Console.Write("Author of book:");
            authorname = Console.ReadLine();
            

            Console.Write("Type of book:");
            booktype = Console.ReadLine();
           


            Console.Write("Quantity:");
            quantity = int.Parse(Console.ReadLine());

           
        
        
      
              
        }
       
    }
    class booklist
    {
        List<book> bklist = new List<book>();

        //public book this[int index]
        //{
        //    get { return bklist[index]; }
        //    set { bklist[index] = value; }
        //}
        public void Input()
        {

            book bl = new book();
            bl.Booklist();
            bklist.Add(bl);
        }
        public void Display()
        {
            foreach (book bl in bklist)
            {
                bl.Display();
            }
            Console.ReadKey();
        }
        public void Search(string bookname)
        {

            foreach (book bl in bklist)
            {
                if (bl.bookname == bookname)
                {
                    bl.Display();
                    break;
                }

            }
        }
    }
}
