using Business_isKuralı_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_isKuralı_.Concrete
{
    public class PttManager: ISupplierService
    {
        public IApplicantService _applicantService; // FİELD olarak verdik BURAYI

        public PttManager()
        {
        }

        public PttManager(IApplicantService applicantService)  // bu yapıya CONSTRACTOR deriz  new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }

        public PttManager(ForeignerManager foreignerManager)
        {
            ForeignerManager = foreignerManager;
        }

        public ForeignerManager ForeignerManager { get; }

        public void GiveMask(Person person) //Maske Verme Operasyonu    Burası sadece  Personlara bağlıdır 
        {
            PttManager personManager= new PttManager(new ForeignerManager());
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
