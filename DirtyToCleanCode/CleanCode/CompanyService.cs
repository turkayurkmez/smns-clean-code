using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                new Company(){ Name ="ABC", HourlyRate=125},
                new Company(){ Name ="Acme", HourlyRate=150}

            };

        }
    }
}
