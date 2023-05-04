using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace Projeto_TCC
{
    public static class Usuario
    {
       
        public static string email;
        public static bool logado;
        public  static int id_usuario;
        public static String getMD5hash(string senha)
        {
            System.Security.Cryptography.MD5 mds = System.Security.Cryptography.MD5.Create();
            byte[] imputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = mds.ComputeHash(imputBytes);
            StringBuilder sb = new StringBuilder();
            //ler cada caractere e converter
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
   

}
