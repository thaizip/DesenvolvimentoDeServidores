using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03
{
    public class pessoa
    {
        private int Id;
        private string Nome;
        private string Telefone;

        public pessoa(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;

        }
        
        public int GetId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }

        public string GetNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string GetTelefone()
        {
            return Telefone;
        }
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }




}
