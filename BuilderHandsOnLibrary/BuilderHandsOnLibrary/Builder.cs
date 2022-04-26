using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHandsOnLibrary
{
    public abstract class Builder
    {
        public abstract void BuildSweet();
	    public abstract void BuildSavory();
        public abstract Product GetResult();

    }
}
