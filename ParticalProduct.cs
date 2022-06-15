using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FinalEX
{
    public partial class Product
    {
        public string  TableTitle
        {
            get
            {
                string a = ProductType.Title;
                return ProductType.Title + " | " + Title;
            }
        }

        public string Materialsss
        {
            get
            {
                string str = "Материалы: ";
                List < ProductMaterial > pm = ProductMaterial.ToList();
                for (int i = 0; i < ProductMaterial.Count; i++)
                {
                    str += ", "+pm[i].Material.Title;
                }
                return str;
            }
        }


        public string AllCoast
        {
            get
            {
                int coast = 0;
                List<ProductMaterial> pm = ProductMaterial.ToList();
                for (int i = 0; i < ProductMaterial.Count; i++)
                {
                    coast += (int)pm[i].Count * (int)pm[i].Material.Cost;                    
                }
                if (coast == 0)
                {
                    coast = 0;
                }
                return coast+"";
            }
        }

    }
}
