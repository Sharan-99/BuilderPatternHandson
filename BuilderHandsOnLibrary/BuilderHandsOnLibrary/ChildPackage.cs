using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHandsOnLibrary
{
    public class ChildPackage : Builder
    {
        private Product _product = new Product();
	 
	    public override void BuildSweet()
	    {
	        _product.Add("Sweet1");
			_product.Add("Sweet2");
	    }
	 
	    public override void BuildSavory()
	    {
	      _product.Add("Savory1");
	    }

		 public override Product GetResult()
		 {
			  return _product;
		 }

    }
}
