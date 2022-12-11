using System;
using VisitorPattern;

namespace LenaVisitorPattern
{
    public class Tests
    {
public static void Main()
        {
            ITaxHolder houseA = new House();
            ITaxHolder companyA = new Company();
            ITaxHolder factoryA = new Factory();

            ITaxHolder taxCollectorCompany = new TaxCollectorCompany();

            IVisitor visitor = new VisitorA();

            taxCollectorCompany.TaxHolders.Add(houseA);
            taxCollectorCompany.TaxHolders.Add(companyA);
            taxCollectorCompany.TaxHolders.Add(factoryA);

            taxCollectorCompany.Accept(visitor);

        }
    }
}