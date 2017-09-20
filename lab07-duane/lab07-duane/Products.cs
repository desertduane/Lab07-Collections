using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_duane
{
    class Products
    {
        public Product NewProduct { get; set; }
        public string Clearance { get => "Everything Must Go!"; set { } }
        public string Sale { get => "50% off"; set { } }

 
    }

    enum Product
    {
        glasses,
        book,
        computer,
        table,
        chair,
        hat, 
        jacket, 
        backpack,
        shoes,
        bike,
        phone
    }
}
