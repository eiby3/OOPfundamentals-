using System;

namespace fundamentosOrientacaoOBJ
{
    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa()
        {
            
        }
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa other)
        {
            return Id == other.Id;
        }
    }
    public class PessoaFisica : Pessoa 
    {
        public string CPF { get; set; }
    }
    public class PessoaJuridica : Pessoa
    {
        public string CPNJ { get; set; }
    }
}