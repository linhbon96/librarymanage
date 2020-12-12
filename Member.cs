using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LybraryManagent
{
    public interface Iuse
    {
        int ID { get; }
        string username { get; set; }
        int cmt { get; set; }
        string address { get; set; }
        void Display();

    }
    class Member:Iuse
    {
        int _id;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = 1;
            }
        }
        string _username;
        public string username
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

        int _cmt;
        public int cmt
        {
            get
            {
                return _cmt;
            }
            set
            {
                _cmt = value;

            }
        }
        string _address;
        public string address
        {
            get
            {
                return _address;
            }
            set
            {

                _address = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Name:" + this._username);
            Console.WriteLine("Cmnd" + this._cmt);
            Console.WriteLine("Address" + this._address);
            Console.ReadKey();

        }
       
        public Member()
        {
            _id = 0;
            _cmt = 0;
            _username = "";
            _address = "";

        }
        public Member(int _ID, int _CMT,string _NAME,string _ADDRESS)
        {
            _id = _ID;
            _cmt = _CMT;
            _username = _NAME;
            _address = _ADDRESS;
        }
      
        static int MID = 0;
        public void bookUser()
        {
            
            Console.Write("User Name:");
            username = Console.ReadLine();
           

            Console.Write("User ID:");
            int ID;
            while (!int.TryParse(Console.ReadLine(), out ID))
                Console.Write("Re enter User ID:");
            cmt = ID;
         

            Console.Write("User Address:");
            address = Console.ReadLine();
          
           
        }
        
        
    }
    public class Memberlist
    {
        List<Member> member = new List<Member>();
        //public Member this[int inde]
        //{
        //    get { return member[inde]; }
        //    set { member[inde] = value; }
        //}
        public void Display()
        {
            foreach (Member ul in member)
            {
                ul.Display();
            }
            Console.ReadKey();
        }
        public void Input()
        {

            Member ul = new Member();
            ul.bookUser();
            member.Add(ul);
        }
        public void Search(string Name)
        {

            foreach (Member pt in member)
            {
                if (pt.username == Name)
                {
                    pt.Display();
                    break;
                }
            }
        }
    }
}
