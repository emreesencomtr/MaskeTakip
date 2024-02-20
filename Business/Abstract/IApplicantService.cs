using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService  //interface ne demek? kelime anlamı arayüz demek
    {
        void ApplyForMask(Person person);
        

        List<Person> GetList();




        bool CheckPerson(Person person);
        
    }
}

