using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class VisitorA : IVisitor
    {
        public int Taxes = 0;

        public override void Visit(House house)
        {
            Taxes += 5;
            Console.WriteLine("Collected Houses Taxes");
        }

        public override void Visit(Factory factory)
        {
            Taxes += 10;
            Console.WriteLine("Collected Factories Taxes");
        }

        public override void Visit(Company company)
        {
            Taxes += 15;
            Console.WriteLine("Collected Companies Taxes");
        }

        public override void Visit(TaxCollectorCompany taxCollectorCompany)
        {
            Console.WriteLine("Taxes Collected = " + Taxes);
        }
    }
}
