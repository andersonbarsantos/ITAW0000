using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class ItemView
    {
        public ItemView(string name, string valor)
        {
            Name = name;
            Valor = valor;
        }

        public string Name { get; set; }
        public string Valor { get; set; }
    }
}