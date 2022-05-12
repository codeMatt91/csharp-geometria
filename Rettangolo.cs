
namespace MyApp
{
    internal class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;

        public Rettangolo()
        {
            baseRettangolo = 0; 
            altezzaRettangolo = 0;
        }

        public Rettangolo(int a, int b)
        {
            baseRettangolo = a;
            altezzaRettangolo = b;
        }

        public int calcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area; 
        }

        public int calcolaPerimetro()
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("-- Rettangolo 1 --");
            Console.WriteLine("altezza: {0}", altezzaRettangolo);
            Console.WriteLine("base: {0}", baseRettangolo);

            Console.WriteLine("perimetro: {0}", this.calcolaPerimetro());
            Console.WriteLine("area: {0}", this.calcolaArea());
        }

        public void Disegna()
        {
            Console.Write("+");
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");
            for (int i = 1; i < (altezzaRettangolo - 1); ++i)
                Console.WriteLine("|{0}|", new String(' ', (int)(baseRettangolo - 2)));
            Console.Write("+");
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");
        }
    }
}