using Business_isKuralı_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_isKuralı_.Abstract
{
    public interface IApplicantService// BaşvuranService =>interface(Arayüz demektir)
    {
        void ApplyForMask(Person person); // (Maske için başvuru) parametere olarak Person vericeyiz 

        List<Person> GetList();
    

        bool CheckPerson(Person person);  //mernise bağlanıcak bu adam doğru adam mı diye kontrol edicek
      
    }

    public class Person
    {
        public string FirstName { get; internal set; }
    }
}   /// 3 syntax  INTERFACEDE 3  METOTLARIN İMZASI YAZILDI 
    /// INTERFACELER belli metotların imzasını barındırırlar bir birinin alternatifi olan sistemlerin farklı implemantation yapmalarını sağlarlar .

