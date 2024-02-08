using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;



namespace workaround
{
    class program
    {
        static void Main(string[] args)
        {



           

            Person person1 = new Person();
            person1.FirstName = "MUHAMMED SELİM";
            person1.LastName = "TAŞ";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity = 123;


            Person person2 = new Person();
            person2.FirstName = "Kerem";
            person2.LastName = "Güzel";
            person2.DateOfBirthYear = 1990;
            person2.NationalIdentity = 567;
           

            PttManager pttManeger = new PttManager(new PersonManager());
            pttManeger.giveMask(person1);
            pttManeger.giveMask(person2);


           

            Console.ReadLine();

           


        }
    }

}


