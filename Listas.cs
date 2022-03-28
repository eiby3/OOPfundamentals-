using System.Collections.Generic;

namespace fundamentosOrientacaoOBJ
{
    public class Listas
    {
        public static void Listar()
        {
            IList<Payment> payments = new List<Payment>();
            IEnumerable<Payment> payEnumerable = new List<Payment>();

            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            foreach (var pay in payments)
            {
                System.Console.WriteLine(pay.Id);
            }

            var paidPayments = new List<Payment>();
            paidPayments.AddRange(payments);
        }
    }
}