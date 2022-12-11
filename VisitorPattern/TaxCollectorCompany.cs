using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class TaxCollectorCompany : ITaxHolder
    {
        //public List<ITaxHolder> TaxHolders = new();

        public override void Accept(IVisitor visitor)
        {
            TaxHolders.ForEach(it => it.Accept(visitor));
            visitor.Visit(this);
        }

    }

}
