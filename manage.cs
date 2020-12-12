using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace LybraryManagent
{
    public interface Imanage
    {
        int ID { get; }
        List<book> books { get; set; }
        Iuse username { get; set; }
        int quantity { get; set; }
        DateTime borrowdate { get; set; }
        DateTime returndate { get; set; }

        double deposit { get; set; }
        double cost { get; set; }
        void Display();

    }
    class manage : Imanage
    {
        int _ID;
        public int ID
        {
            get { return _ID; }
            set{_ID=0;}
        }
    
        List<book> _books;
        public List<book> books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }
        }
        Iuse _username;
        public Iuse username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        int _quantity;
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;

            }
        }

        DateTime _borrowdate;
        public DateTime borrowdate
        {
            get
            {
                return _borrowdate; 
            }
            set
            {
                _borrowdate = value;
            }
        }
        DateTime _returndate;

        public DateTime returndate
        {
            get
            {
                return _returndate;

            }
            set
            {
                _returndate = value;
            }
        }
        double _deposit;
        public double deposit
        {
            get
            {
                return _deposit;
            }
            set
            {
                _deposit = value;
            }
        }
        double _cost;
        public double cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Name of book:" + books);
            Console.WriteLine("Member: "+ username);
            Console.WriteLine("Borrow Date:"+ borrowdate);
            Console.WriteLine("Return Date: " + returndate);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Deposit: " +deposit);
            Console.WriteLine("Cost: " + cost);

        }

       
       
        

        static int BID = 0;
        public void BorrowaBook()
        {

            manage mn = new manage();

            mn.ID = BID++;


            Console.Write("Name of book:");
            

            Console.Write("Member:");
     

          

            Console.Write("Borrow date: ");
            DateTime bdt;
            while (!DateTime.TryParse(Console.ReadLine(), out bdt))
                Console.Write("Re enter  date:");
            mn.borrowdate = bdt;
          

            Console.Write("Return date: ");
            DateTime rdt;
            while (!DateTime.TryParse(Console.ReadLine(), out rdt))
                Console.Write("Re enter date:");
            mn.returndate = rdt;
           



            Console.Write("Deposit: ");
            mn.deposit = double.Parse(Console.ReadLine());
           

            Console.Write("Cost:");
            mn.cost = double.Parse(Console.ReadLine());
           


            Console.Write("Quantity:");
            mn.quantity = int.Parse(Console.ReadLine());
            
        }
       
        }
    public class borrow
    {
        List<manage> Manage = new List<manage>();

        public void Display()
        {
            foreach (manage ul in Manage)
            {
                ul.Display();
            }
            Console.ReadKey();
        }
        public void Input()
        {

            manage ul = new manage();
            ul.BorrowaBook();
            Manage.Add(ul);
        }
    }



}

  
