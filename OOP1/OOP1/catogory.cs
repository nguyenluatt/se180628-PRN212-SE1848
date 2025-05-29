using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


{
    
        Console.OutputEncoding=Encoding.UTF8;
            category c1 = new category();
        c1.ID=1;
            c1.Name="abc";
            c1.printInFor();
            c1.name="def";
            Console.WriteLine("sau khi doi gia tri");
             c1.printInFor();
    Console.WriteLine("EMPLOYEE");
    Employee e1=new Employee();
    e1.Id=1;
    e1.IdCard = "001";
    e1.Name = "an";
    e1.Email = "abc@gamil.com";
    e1.phone = "0204060800";
    e1.PrintInfor();
    Employee e2=new Employee();
    {
        Id=2,
        Idcard = "001",
        Name="quin",
        Email="quin@gmail.com",
        phone = "0854323211"
    };
    Console.WriteLine("=EMPLOYEE");
    e2.PrintInfor();
}