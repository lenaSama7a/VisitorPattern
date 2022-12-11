using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class ITaxHolder
    {
        public List<ITaxHolder> TaxHolders = new();
        public abstract void Accept(IVisitor visitor);
    }
}
