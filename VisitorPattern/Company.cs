using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Company : ITaxHolder
    {
        public override void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
