using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LybraryManagent
{
    public class Program


    {


        
        static void Main(string[] args)
        {



            booklist blist = new booklist();
            Memberlist mbl = new Memberlist();
            borrow mn = new borrow();
            

            //User us = new User();
            string chon;

            do
            {
                Console.Clear();
                Console.WriteLine("PLEASE AN OPTION:");
                Console.WriteLine("1. Inser a new book...");
                Console.WriteLine("2. Inser a User...");
                Console.WriteLine("3. List Book...");
                Console.WriteLine("4. List Member...");
                Console.WriteLine("5. List Borrow Book...");
                Console.WriteLine("6. Search a Book...");
                Console.WriteLine("7. Search a Member...");

                Console.WriteLine("8. Exit...");
                Console.Write("Option:");
                chon = Console.ReadLine();
                


                switch (chon)
                {
                    case "1":
                      blist.Input();
                      

                        break;
                    case "2":

                        mbl.Input();
                        

                        break;
                    case "3":
                        blist.Display();
                        //us.Show();
                        break;
                    case "4":
                        mbl.Display();
                        break;
                    case "5":
                        mn.Input();
                        break;
                    case "6":
                      string bookname;
                        Console.Write("Input the book name:");
                        bookname = Console.ReadLine();

                        blist.Search(bookname);
                        break;
                    case "7":
                        string username;
                        Console.Write("Input the name:");
                        username = Console.ReadLine();

                        mbl.Search(username);
                        break;
                    case "8":
                        Console.Write("bye!");
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;

                        Console.ReadLine();
                }
            }
            while (chon != "8");
            Console.ReadKey();
        }
    }

}  
    
       

 
  
