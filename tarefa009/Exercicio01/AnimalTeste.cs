using System;
using System.Collections.Generic;

namespace Tarefa009
{
    public class AnimalTeste
    {
        public static void Testar()
        {
            var cachorro = new Cachorro();
            var cavalo = new Cavalo();
            var preguica = new Preguica();

            EmitirSom(cachorro);
            EmitirSom(cavalo);
            EmitirSom(preguica);

            var veterinario = new Veterinario();
            veterinario.Examinar(cachorro);
            veterinario.Examinar(cavalo);
            veterinario.Examinar(preguica);

            var zoologico = new Zoologico();

            zoologico.Jaulas = new List<Jaula>()
            {
                new Jaula(cachorro),
                new Jaula(cavalo),
                new Jaula(preguica),
                new Jaula(cachorro),
                new Jaula(cavalo),
                new Jaula(preguica),
                new Jaula(cachorro),
                new Jaula(cavalo),
                new Jaula(preguica),
                new Jaula(cachorro)
            };

            foreach (var jaula in zoologico.Jaulas)
            {
                Console.WriteLine(jaula.Animal.EmitirSom());

                if (jaula.Animal is Cachorro || jaula.Animal is Cavalo)
                {
                    Console.WriteLine(jaula.Animal.Movimentar());
                }
            }
        }

        private static void EmitirSom(Animal animal)
        {
            Console.WriteLine(animal.EmitirSom());
        }
    }
}
