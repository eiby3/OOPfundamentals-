using System;

namespace fundamentosOrientacaoOBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Dinheiro = 100;
            System.Console.WriteLine(pagamento.Dinheiro);

            var pessoa = new Pessoa();
            var pessoaJuridica = new PessoaJuridica();

            //upcast
            pessoa = new PessoaFisica();
            pessoa = pessoaJuridica;
            //downcast
            pessoaJuridica = (PessoaJuridica)pessoa;

            //Equals
            var pessoaA = new Pessoa(1, "Abe");
            var pessoaB = new Pessoa(1, "Abe");
            //Compara endereco armazenado, sempre vai ser diferente.
            Console.WriteLine(pessoaA == pessoaB); //False

            //Implementando interface na class Pessoa
            Console.WriteLine(pessoaA.Equals(pessoaB)); //True

            //Delegate
            var pagar = new Pagamento.Pagar(Pagamento.RealizarPagamento);
            pagar(25);

            //Events
            Rooms room = new Rooms(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.Reserve();
            room.Reserve();
            room.Reserve();
            room.Reserve();
            room.Reserve();
            room.Reserve();

            //listas
            Listas.Listar();
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }
    }

    public class Pagamento
    {
        public DateTime Vencimento { get; set; }
        private int _dinheiro;
        public int Dinheiro
        {
            get
            {
                return _dinheiro;
            }
            set
            {
                int taxa = 10;
                _dinheiro = value - taxa;
            }
        }
        //Delegate
        public delegate void Pagar(double valor);
        public static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento concluido no valor de {valor}");
        }
    }



}
