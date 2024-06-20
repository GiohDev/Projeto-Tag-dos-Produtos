using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Globalization;

namespace Projeto_Tag_dos_Produtos.Entities {
    internal class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }




        public UsedProduct() {
        
        }

        public UsedProduct(string name, double price , DateTime manufactureDate)
             : base (name, price){
            
            this.ManufactureDate = manufactureDate;

        }

        public override string PriceTag() {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: "
                + ManufactureDate
                + ")";







        }

    }
}
