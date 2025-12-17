using System.Drawing;

namespace cours1
{
    public class Exercice2
    {
        List<Vehicule> vehicules = new List<Vehicule> {
            new Voiture(),
            new Velo()
        };

        public void Lancer()
        {
            foreach (var vehicule in vehicules)
            {
                vehicule.Demarrer();
                vehicule.Arreter();
            }
        }

    }

    interface IVehicule
    {
        void Demarrer();
        void Arreter();
    }

    abstract class Vehicule : IVehicule
    {
        protected Color couleur;
        public abstract void Demarrer();
        public abstract void Arreter();
    }

    class Voiture : Vehicule
    {
        public Voiture() { couleur = Color.Red; }
        public override void Demarrer() => Console.WriteLine("La voiture démarre son moteur.");
        public override void Arreter() => Console.WriteLine($"La voiture rouge s'arrête.");
    }

    class Velo : Vehicule
    {
        public Velo() { couleur = Color.Green; }
        public override void Demarrer() => Console.WriteLine("Le vélo démarre en pédalant.");
        public override void Arreter() => Console.WriteLine($"Le vélo vert s'arrête avec les freins.");
    }

}
