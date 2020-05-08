using System;

namespace ConsoleTeste01
{
    class Carro
    {
        #region Propriedades
        public EnumCor Cor { get; set; }
        public DateTime DataFabricacao { get; set; }
        public int QtdBancos { get; }
        public int QtdPortas { get; set; }
        public CarroStatus Status { get; set; }

        #endregion

        #region Construtores

        public Carro() : this(EnumCor.Branco)
        {
        }

        public Carro(EnumCor cor) : this(cor, CarroStatus.Parado)
        {
        }

        public Carro(EnumCor cor, CarroStatus status)
        {
            Cor = cor;
            Status = status;

            Console.WriteLine($"Carro Criado:\r\n\t- Cor:{cor}\r\n\t- Status:{status}");
            Console.WriteLine("");
        }

        #endregion

        #region Metodos
        public CarroStatus Andar()
        {
            Console.WriteLine($"Carro {Cor} andando....");

            return CarroStatus.Andando;
        }

        public CarroStatus Parar()
        {
            Console.WriteLine("Carro parando");

            return CarroStatus.Parado;
        }

        public void Buzinar()
        {
            Console.WriteLine("Bip!!!");
        }

        #endregion

    }

    public enum CarroStatus
    {
        Parado,
        Andando,
        Derrapando,
        Capotando
    }

    public enum EnumCor
    {
        Branco,
        Azul,
        Verde,
        Amarelo,
        Roxo
    }
}