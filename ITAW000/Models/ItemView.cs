using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class ItemView
    {
        public ItemView(string name, string valor , string total = "")
        {
            Name = name;
            Valor = valor;
            Total = total;
        }

        public string Name { get; set; }
        public string Valor { get; set; }
        public string Total { get; set; }
    }
}