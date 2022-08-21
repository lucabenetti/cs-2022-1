namespace ExtractSubclass
{
    public class Cachorro : AnimalRefatorada
    {
        public override void FazerBarulho()
        {
            Latir();
        }

        private void Latir()
        {
            Console.WriteLine("Latir");
        }
    }
}