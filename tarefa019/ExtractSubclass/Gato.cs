namespace ExtractSubclass
{
    public class Gato : AnimalRefatorada
    {
        public override void FazerBarulho()
        {
            Miar();
        }

        private void Miar()
        {
            Console.WriteLine("Miar");
        }
    }
}