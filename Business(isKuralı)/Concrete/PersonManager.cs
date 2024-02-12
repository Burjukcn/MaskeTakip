using Business_isKuralı_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Business_isKuralı_.Concrete
{
    public class PersonManager: IApplicantService  // (İŞ SINIFI   = OPERASYON TUTMAK İÇİN KULLANIRIZ)
    {
        //ÇIPLAK CLASS KALMASIN

        // encapulation
        public void ApplyForMask(Person person) // (Maske için başvuru) parametere olarak Person vericeyiz 
        {

        }
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)  //mernise bağlanıcak bu adam doğru adam mı diye kontrol edicek
        {   
            //mernis kontrolü yapılacak
            return true;
        }
    }
}
