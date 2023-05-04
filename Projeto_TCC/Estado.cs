using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC
{
    public class Estado
    {
        public int id_estado { get; set; }
        
        public string uf { get; set; }
        public Estado(int id_estado,string nome, string uf)
        {
            this.id_estado = id_estado;
            
            this.uf = uf;
        }
    }
}
