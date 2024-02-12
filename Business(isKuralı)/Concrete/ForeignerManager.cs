using Business_isKuralı_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_isKuralı_.Concrete
{
    public class ForeignerManager : IApplicantService // Yabancıların
    {
        public void ApplyForMask(Person person) => throw new NotImplementedException();

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
