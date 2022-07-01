using System;

namespace Tarefa009
{
    public class Veterinario
    {
        public void Examinar(Animal animal)
        {
            Console.WriteLine(animal.EmitirSom());
        }
}
