using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC
{
    public class Cadastro1
    {
        public int id_cadastro { get; set; }
        public string Nome { get; set; }
        public string nome_responsavel { get; set; }
        public string cpf_responsavel { get; set; }
        public string cpf { get; set; }
        public string como_ficou_sabendo { get; set; }
        public string rg_responsavel { get; set; }
        public string rg { get; set; }
        public string e_mail { get; set; }
        public DateTime data_nascimento { get; set; }
        public string numero_telefone { get; set; }
        public string senha { get; set; }
        public int id_endereco { get; set; }
        public int id_escolaridade { get; set; }
    }
}
