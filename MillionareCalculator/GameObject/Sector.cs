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

        public Sector(List<Company> companies)
        {
            this.companies = companies;
        }

        public int IsMonopoly(Company company)
        {
            return 0;
        }

        public int GetAllTax () 
        {
            int sectorTax = 0;
            this.companies.ForEach(company => sectorTax += company.GetAllTax());
            return sectorTax;
        }
    }
}
