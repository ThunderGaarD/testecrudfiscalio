using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace testecrudfiscalio
{
    public class NotaFiscal {
        public int IdNota { get; set; }
        public string Emissor { get; set; }
        public DateTime Data { get; set; }
    }
   
}
