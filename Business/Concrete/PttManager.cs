using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager :ISupplierService
    {
         private IApplicantService _applicantService; //interfaceler belli method imzalarını barındırırlar. birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlar. yani yabancı uyruklukları farklı check ederim onun kuralı farklıdır. 

        public PttManager( IApplicantService applicantService) //Constructor nedir? kelime anlamı oluşturucu demek. yani class oluştuğunda newlendiği zaman bllok önce çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); //iş sınıfı veri erişim sınıflar için başka bir iş sınıfını kullanırken newliyorsa bu uygulama direnç gösterir. Peki ne demek? newlendiği zaman personmanager'e bağlısındır.

          
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + "için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + "için MASKE VERİLEMEDİ");
            }
;        }
    }
}
