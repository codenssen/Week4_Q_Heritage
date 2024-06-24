
namespace Week4_Q_Heritage
{
    public abstract class Animal
    {
        protected string _name;
        protected int _legsCount;
        protected bool _hairy;

        public Animal(string name, int legsCount, bool hairy)
        {
            _name = name;
            _legsCount = legsCount;
            _hairy = hairy;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{_name} se déplace...");
            Console.WriteLine(_hairy ? "...avec les poils au vent." : "vec la peau nue.");

        }

        public void Eat()
        {
            Console.WriteLine($"{_name} mange");
        }

    }

    public class Biped : Animal
    {
        public Biped(string name) : base (name, 2, true)
        {

        }

        public override void Move()
        {
            Console.WriteLine($"{_name} se déplace à {_legsCount} jambes car il est bipède");
        }

    }

    public class Quadriped : Animal
    {
        public Quadriped(string name) : base(name, 4, true)
        {

        }

        public override void Move()
        {
            Console.WriteLine($"{_name} se déplace à {_legsCount} jambes car il est quadripède");
        }

    }
}
