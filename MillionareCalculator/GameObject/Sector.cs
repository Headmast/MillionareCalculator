using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareCalculator.GameObject
{
    class Sector
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        
        private List<Company> companies = new List<Company>();

        public Sector()
        {
            Company company = new Company(100,5,15,50);
            companies.Add(company);
            company = new Company(150,5,15,50);
            companies.Add(company);
            company = new Company(200,5,15,50);
            companies.Add(company);
        }

        public int GetAllTax () 
        {
            int sectorTax = 0;
            this.companies.ForEach(company => sectorTax += company.GetAllTax());
            return sectorTax;
        }
    }
}
