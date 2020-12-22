using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LybraryManagent
{

    //public interface Ibook
    //{
    //    int ID { get; set; }
    //    int quantity { get; set; }
    //    string bookname { get; set; }
    //    string booktype { get; set; }
    //    string authorname { get; set; }
    //    DateTime Publishdate { get; set; }
    //}
    public class book//:Ibook
    {
        public int ID { get; set; }
        public string bookname { get; set; }
        public string type { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public DateTime date { get; set; }
        
    



        
        public book()
        {
            ID = 0;
            bookname = "";
            type = "";
            author = "";
            quantity = 0;
            date = DateTime.Today;
        }
      

        public void Display()
        {
            Console.WriteLine("Book Name:" + this.bookname);
            Console.WriteLine("Book Type:" + this.type);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Publishing Date:" + this.date);
            
        }

        static int BID = 0;
        public void AddaBook()
        {
           

           
            ID = ++BID;

          
            Console.Write("Name of book:");
            bookname = Console.ReadLine();
            

            Console.Write("Publish date: ");
            DateTime dt;
            while (!DateTime.TryParse(Console.ReadLine(), out dt))
                Console.Write("Re enter Publish date:");
            date = dt;
           


            Console.Write("Author of book:");
            author = Console.ReadLine();
            

            Console.Write("Type of book:");
            type = Console.ReadLine();
           


            Console.Write("Quantity:");
            int qtt;
            while(!int.TryParse(Console.ReadLine(), out qtt))
                Console.Write("re enter:");
            quantity = qtt;
         
        }      
    }
    
}
