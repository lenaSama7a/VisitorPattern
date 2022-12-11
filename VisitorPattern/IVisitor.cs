using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class IVisitor
    {
        public abstract void Visit(House house);
        public abstract void Visit(Factory factory);
        public abstract void Visit(Company company);
        public abstract void Visit(TaxCollectorCompany taxCollectorCompany);

    }
}
