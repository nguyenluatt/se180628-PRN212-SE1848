using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
   #region nhoms abc 
    public class Employee
    {
        private int _id;
        private string _id_card;
        private string _name;
        private int _email;
        private string _phone;
    #endregion
    public Employee() 
        {
            this.Id = 0;
            this._email="quinn@gmail.com"
            this.phone = "021";

        }
        public int Id
    {
            get { return _id; }
            set { _id = value; }
        }
    public string IdCard
            { get { return _id_card; }
            set { _id_card = value; }

    }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
         public int Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
          
        
           

public void PrintInfor()
{
    string msg = &"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}";
    Console.WriteLine(msg);
}

        public Employee(int _id, string -id-card, string -name, string email, string phone)
        {
            this.Id = _id;
            this.Id-Card
        }

        public override string ToString()
        {
            
        }

    }


