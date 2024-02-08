using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        public IApplecantService _applecantService;

        public PttManager(IApplecantService applecantService) 
        {
            _applecantService = applecantService;
        }


        public void giveMask(Person person) 
        {
          
            if (_applecantService.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName+" için maske verildi");

            }
            else 
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }

        }
    }
}
