using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareCalculator.GameObject
{
    class Company
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _SectorId;

        public int SectorId
        {
            get { return _SectorId; }
            set { _SectorId = value; }
        }

        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Price;

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private int _Tax;

        public int Tax
        {
            get { return _Tax; }
            set { _Tax = value; }
        }

        private int _Rent;

        public int Rent
        {
            get { return _Rent; }
            set { _Rent = value; }
        }

        private int _BuildingPrice;

        public int BuldingPrice
        {
            get { return _BuildingPrice; }
            set { _BuildingPrice = value; }
        }

        private int _CountBuildings;

        public int CountBuldings
        {
            get { return _CountBuildings; }
            set { _CountBuildings = value; }
        }

        private Boolean _IsMonopolyBuilding;

        public Boolean IsMonopolyBuilding
        {
            get { return _IsMonopolyBuilding; }
            set { _IsMonopolyBuilding = value; }
        }

        public int GetAllRent ()
        {
            return this.Rent;
        }

        public int GetAllTax ()
        {
            return this.Tax;
        }

        public Company(int price, int rent, int tax, int buildingPrice)
        {
            _Price = price;
            _Rent = rent;
            _Tax = tax;
            _BuildingPrice = buildingPrice;
        }

        public Company(int id, String name, int price, int rent, int tax, int buildingPrice)
        {
            _Id = id;
            _Name = name;
            _Price = price;
            _Rent = rent;
            _Tax = tax;
            _BuildingPrice = buildingPrice;
        }
    }
}
