namespace cours1
{
    public class Exercice3
    {
        List<Instrument> instruments = new List<Instrument> {
            new Guitare(),
            new Piano(),
            new Batterie()
        };

        public void Lancer()
        {
            foreach (var instrument in instruments)
            {
                instrument.Accorder();
                instrument.Jouer();
            }
        }
    }

    interface IInstrument
    {
        void Jouer();
        void Accorder();
    }

    abstract class Instrument : IInstrument
    {
        protected string nom;

        public Instrument(string nom)
        {
            this.nom = nom;
        }

        public virtual void Jouer() => Console.WriteLine($"Jouer un instrument générique ({nom})");
        public abstract void Accorder();
    }

    class Guitare : Instrument
    {
        public Guitare() : base("Guitare") { }
        public override void Jouer() => Console.WriteLine("La guitare joue des accords.");
        public override void Accorder() => Console.WriteLine("Accorder la guitare en Mi.");
    }

    class Piano : Instrument
    {
        public Piano() : base("Piano") { }
        public override void Jouer() => Console.WriteLine("Le piano joue une mélodie.");
        public override void Accorder() => Console.WriteLine("Accorder le piano avec un diapason.");
    }

    class Batterie : Instrument
    {
        public Batterie() : base("Batterie") { }
        public override void Jouer() => Console.WriteLine("La batterie joue un rythme.");
        public override void Accorder() => Console.WriteLine("Accorder la batterie en ajustant les peaux.");
    }
}
