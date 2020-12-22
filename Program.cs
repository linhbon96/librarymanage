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

        static List<Member> mbl = new List<Member>();
        static List<book> listbook = new List<book>();
        static List<manage> mn = new List<manage>();

        public static void Main(string[] args)
        {





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
                Console.WriteLine("5. Borrow Book...");
                Console.WriteLine("6. Search a Book...");
                Console.WriteLine("7. Search a Member...");

                Console.WriteLine("9. Exit...");
                Console.Write("Option:");
                chon = Console.ReadLine();



                switch (chon)
                {
                    case "1":
                        Input(listbook);


                        break;
                    case "2":

                        Input(mbl);

                        break;
                    case "3":
                        Display(listbook);

                        break;
                    case "4":
                        Display(mbl);
                        break;
                    case "5":
                       Console.WriteLine("Book name: ");
                        
                        Input(mn);
                        break;
                    case "6":
                        SearchbookByName(listbook);
                        break;
                    case "7":

                        SearchMemberByName(mbl);
                        break;
                    case "8":

                        break;
                    case "9":
                        Console.Write("bye!");
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;

                        Console.ReadLine();
                }
            }
            while (chon != "9");
            Console.ReadKey();
        }



        public static void SearchbookByID(List<book> list)
        {
            Console.Write("Input book ID: ");
            int BID = int.Parse(Console.ReadLine());

            foreach (book b in list)
            {
                if (b.ID == BID)
                {
                    b.Display();
                    break;
                }
            }


        }

        public static void SearchbookByName(List<book> list)
        {
            Console.Write("Input book name: ");
            String name = Console.ReadLine();

            foreach (book bl in list)
            {
                if (bl.bookname.Equals(name))
                {

                    bl.Display();
                    break;
                }
            }
        }
        static void Input(List<book> list)
        {

            book bl = new book();
            bl.AddaBook();
            list.Add(bl);
        }
        static void Display(List<book> list)
        {
            foreach (book ul in list)
            {
                ul.Display();
            }
            Console.ReadKey();
        }
        public static void SearchMemberByName(List<Member> list)
        {
            Console.Write("Input member name: ");
            String name = Console.ReadLine();

            foreach (Member mb in list)
            {
                if (mb.username == name)
                {
                    mb.Display();
                    break;
                }
            }


        }
        public static void SearchMemberByID(List<Member> list)
        {
            Console.Write("Input member ID: ");
            int mID = int.Parse(Console.ReadLine());

            foreach (Member mb in list)
            {
                if (mb.ID == mID)
                {
                    mb.Display();
                    break;
                }
            }


        }
        static void Display(List<Member> list)
        {
            foreach (Member ul in list)
            {
                ul.Display();
            }
            Console.ReadKey();
        }
        static void Input(List<Member> list)
        {
            Member mb = new Member();
            mb.AddaMember();
            list.Add(mb);
        }
        static void Display(List<manage> list)
        {
            foreach (manage ul in list)
            {
                ul.Display();
            }
            Console.ReadKey();
        }
        static void Input(List<manage> list)
        {

            manage ul = new manage();
            ul.BorrowaBook();
            list.Add(ul);

        }

       

        

    }

}





