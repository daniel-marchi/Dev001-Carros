using System;
using System.Collections.Generic;
using CarroPartes;

namespace ConsoleTeste01
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá tudo bem?");
            Console.WriteLine("");

            var carros = new List<Carro>();

            carros.Add(new Carro(EnumCor.Amarelo));
            carros.Add(new Carro(EnumCor.Azul, CarroStatus.Andando));
            carros.Add(new Carro());
            carros.Add(new Carro(EnumCor.Verde, CarroStatus.Capotando));

            // Para cada carro na lista carros...
            foreach (var carro in carros)
            {
                switch (carro.Status)
                {
                    case CarroStatus.Andando:
                        carro.Status = carro.Parar();
                        break;
                    case CarroStatus.Parado:
                        carro.Status = carro.Andar();
                        break;
                    default:
                        Console.WriteLine("Vish... Deu ruim!!!");
                        break;
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Fim");
            Console.WriteLine("");
        }
    }
}