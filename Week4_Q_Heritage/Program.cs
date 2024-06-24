namespace Week4_Q_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biped homme = new Biped("Bob");
            Biped singe = new Biped("Abu");

            homme.Eat();
            homme.Move();
            singe.Eat();
            singe.Move();

            Quadriped elephant = new Quadriped("Babar");
            Quadriped tortue = new Quadriped("Franklin");
            Quadriped lézard = new Quadriped("Oscar");

            elephant.Eat();
            elephant.Move();
            tortue.Eat();
            tortue.Move();
            lézard.Eat();
            lézard.Move();

        }
    }
}
