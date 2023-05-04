using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC
{
    internal class Endereco
    {
        public int id_endereco { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public  int numero_casa { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public int cep { get; set; }
        public string complemento { get; set; }
        
    }
}
