using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ForeignerManager : IApplecantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }

        public void saveDbIsimler(Person person)
        {
           //db ye kaydetme kodları buraya yazılıyor.
        }
    }
}
