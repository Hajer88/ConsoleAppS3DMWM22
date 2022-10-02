using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppS3DMWM22
{
    public static class ExtensionClass
    {
        public static decimal TotalPrix(this ListProduits listProduits)
        {
            decimal total = 0;
            foreach(Produit p in listProduits.produits)
            {
                total+=p.Price;
                
            }
            //Console.WriteLine(total);
            return total;

        }
    }
}
