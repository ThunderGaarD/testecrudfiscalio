using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testecrudfiscalio.Models
{
    public class Item { 
        public int IdNota { get; set; }
        public int IdItem { get; set; }
        public string Produto {  get; set; }
        public decimal Valor { get; set; }
    }
    
}
