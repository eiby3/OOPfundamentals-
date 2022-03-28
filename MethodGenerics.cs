namespace fundamentosOrientacaoOBJ
{
    public class MethodGenerics
    {
        public void Method()
        {
            var person = new Person();
            var payment = new Payment(1);
            var subscription = new Subscription();

            var context = new DataContext<Person, Payment, Subscription>();
            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
        }
    }
    public class DataContext<P, PA, S>
        where P : Person
        where PA : Payment
        where S : Subscription //limitando os tipos genericos
    {
        public void Save(P entity)
        {

        }
        public void Save(PA entity)
        {

        }
        public void Save(S entity)
        {

        }
    }
    public class Person { }
    public class Payment
    {
        public int Id { get; set; }
        public Payment(int id)
        {
            Id = id;
        }
    }
    public class Subscription
    {

    }
}