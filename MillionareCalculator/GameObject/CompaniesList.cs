using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareCalculator.GameObject
{
    class CompaniesList
    {
        private List<Company> _Companies = new List<Company>();

        public List<Company> Companies
        {
            get { return _Companies; }
            set { _Companies = value; }
        }

        public CompaniesList()
        {
            Company company = new Company(100,5,15,50);
            _Companies.Add(company);
            company = new Company(150,5,15,50);
            _Companies.Add(company);
            company = new Company(200,5,15,50);
            _Companies.Add(company);
        }
    }
}
