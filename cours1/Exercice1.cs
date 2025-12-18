using System.Drawing;

namespace cours1
{
    public class Exercice1
    {
        List<Animal> animaux = new List<Animal> {
            new Chien(),
            new Chat()
        };

        public void Lancer()
        {
            foreach (var a in animaux)
            {
                a.Vocaliser();
            }
        }

    }

    abstract class Animal
    {
        public abstract void Vocaliser();
    }

    class Chien : Animal
    {
        public override void Vocaliser() => Console.WriteLine("Le chien dit : Woof!");
    }

    class Chat : Animal
    {
        public override void Vocaliser() => Console.WriteLine("Le chat dit : Miaou!");
    }
}
