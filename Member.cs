using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LybraryManagent
{
 
  public  class Member
    {

        public int ID { get; set; }


        public string username { get; set; }



        public int cmt { get; set; }
       
       
        public string address { get; set; }
        
        public void Display()
        {
            Console.WriteLine("Name:" + this.username);
            Console.WriteLine("Cmnd" + this.cmt);
            Console.WriteLine("Address" + this.address);
            Console.ReadKey();

        }
       
        public Member()
        {
            ID = 0;
            cmt = 0;
            username = "";
            address = "";

        }

      
        static int MID = 0;
        public void AddaMember()
        {
            ID = ++MID;

            Console.Write("User Name:");
            username = Console.ReadLine();
           

            Console.Write("User ID:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
                Console.Write("Re enter User ID:");
            cmt = id;
         

            Console.Write("User Address:");
            address = Console.ReadLine();
          
           
        }
        
        
    }
    
}
