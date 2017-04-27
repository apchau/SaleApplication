using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Customer
    {
        private string pCustid, pFName, pMInitial, pLName, pStreet, pCity, pState, pCountry, pNumber;

        public Customer(string custid, string fName, string mInitial, string lName, string street, string city, string state, string country, string number)
        {
            pCustid = custid;
            pFName = fName;
            pMInitial = mInitial;
            pLName = lName;
            pStreet = street;
            pCity = city;
            pState = state;
            pCountry = country;
            pNumber = number;
        }

        public string Staffid
        {
            get { return pCustid; }
            set { pCustid = value; }
        }

        public string FName
        {
            get { return pFName; }
            set { pFName = value; }
        }

        public string MInitial
        {
            get { return pMInitial; }
            set { pMInitial = value; }
        }

        public string LName
        {
            get { return pLName; }
            set { pLName = value; }
        }
        public string Street
        {
            get { return pStreet; }
            set { pStreet = value; }
        }
        public string City
        {
            get { return pCity; }
            set { pCity = value; }
        }
        public string State
        {
            get { return pState; }
            set { pState = value; }
        }
        public string Country
        {
            get { return pCountry; }
            set { pCountry = value; }
        }
        public string PhoneNumber
        {
            get { return pNumber; }
            set { pNumber = value; }
        }

        public override string ToString()
        {
            return pCustid + ", " + pFName + " " + pMInitial + " " + pLName;
        }
    }
}
