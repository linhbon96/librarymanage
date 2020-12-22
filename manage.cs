using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace LybraryManagent
{
    //public interface Imanage
    //{
       
    //}

    class manage 
    {
        List<Member> mbl = new List<Member>();
        List<book> listbook = new List<book>();
        int ID { get; set; }
        List<book> books { get; set; }
        Member username { get; set; }
        int quantity { get; set; }
        DateTime borrowdate { get; set; }
        DateTime returndate { get; set; }

        double deposit { get; set; }
        double cost { get; set; }
        
        

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
        public void BorrowaBook(List<book> allBooks, List<Member> allmembers)
        {

            manage mn = new manage();

            mn.ID = BID++;

            Console.Write("Member:");
            int memberID = int.Parse(Console.ReadLine());
            Member member = Program.SearchMemberByID(Member.Equals(memberID));
            

            Console.Write("Name of book:");
            string book =  Console.ReadLine();
            

            
            

          

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
  


}

  
