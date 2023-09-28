class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Mamífero");
            Console.WriteLine("2 - Ave");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=======================================");

            int escolhaClasse = int.Parse(Console.ReadLine());

            if (escolhaClasse == 0)
                break;

            Animal animal = null;

            if (escolhaClasse == 1)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Escolha a espécie:");
                Console.WriteLine("1 - Cão");
                Console.WriteLine("2 - Gato");
                Console.WriteLine("3 - Elefante");
                Console.WriteLine("4 - Cavalo");
                Console.WriteLine("=======================================");

                int escolhaEspecie = int.Parse(Console.ReadLine());

                switch (escolhaEspecie)
                {
                    case 1:
                        animal = new Cao(10.5, 4);
                        break;
                    case 2:
                        animal = new Gato(5.0, 4);
                        break;
                    case 3:
                        animal = new Elefante(5000.0, 4);
                        break;
                    case 4:
                        animal = new Cavalo(600.0, 4);
                        break;
                }

                if (animal != null)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine($"Peso: {animal.Peso} kg");
                    Console.WriteLine($"Quantidade de Patas: {animal.QuantidadePatas}");
                    Console.WriteLine("=======================================");
                }
            }
            else if (escolhaClasse == 2)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Escolha a espécie:");
                Console.WriteLine("1 - Andorinha");
                Console.WriteLine("2 - Pato");
                Console.WriteLine("3 - Galinha");
                Console.WriteLine("=======================================");

                int escolhaEspecie = int.Parse(Console.ReadLine());

                switch (escolhaEspecie)
                {
                    case 1:
                        animal = new Andorinha(0.1, 2);
                        break;
                    case 2:
                        animal = new Pato(1.0, 2);
                        break;
                    case 3:
                        animal = new Galinha(2.0, 2);
                        break;
                }

                if (animal != null)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine($"Peso: {animal.Peso} kg");
                    Console.WriteLine($"Quantidade de Patas: {animal.QuantidadePatas}");
                    Console.WriteLine("=======================================");
                }
            }

            if (animal != null)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Escolha a ação:");
                Console.WriteLine("1 - Andar");
                Console.WriteLine("2 - Comer");
                if (animal is Cao)
                {
                    Console.WriteLine("3 - Atacar");
                }
                if (animal is IVoavel)
                {
                    Console.WriteLine("4 - Voar");
                }
                Console.WriteLine("=======================================");

                int escolhaAcao = int.Parse(Console.ReadLine());

                switch (escolhaAcao)
                {
                    case 1:
                        animal.Andar();
                        break;
                    case 2:
                        animal.Comer();
                        break;
                    case 3:
                        if (animal is Cao)
                        {
                            ((Cao)animal).Atacar();
                        }
                        break;
                    case 4:
                        if (animal is IVoavel)
                        {
                            ((IVoavel)animal).Voar();
                        }
                        break;
                }
            }
        }
    }
}