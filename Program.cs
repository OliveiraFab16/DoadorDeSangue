using System;

namespace DoadorDeSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
           
            Console.WriteLine("--- Pelo Horario De Brasília Agora São:");
            DateTime horaSistema = DateTime.Now;
            Console.WriteLine($"Hora Do Sistema: {horaSistema}");
        

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
                    
            if (idade <= 18)
            {
              Console.WriteLine($"Nome:{nome}");
              Console.WriteLine("Você Não Pode Ser Doador(a) De Sangue");
              Console.WriteLine("A Idade Minima Para doar É De 18 Anos!");
              Console.WriteLine("Pressione ENTER para sair!");
              Console.ReadKey();
            }
            if (idade >= 18 && idade <= 67)
            {
                Console.WriteLine($"Nome:{nome}");
                Console.WriteLine("Você Pode Ser Doador(a) De Sangue");
                Console.WriteLine("A Idade Minima Para doar É De 18 Anos");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (idade  >= 67 && idade <= 84 ) 
            {
              Console.WriteLine($"Nome:{nome}");
              Console.WriteLine("Você Não Pode Ser Doador(a) De Sangue");
              Console.WriteLine("A Idade Minima Para doar É De 18 Anos");
              Console.WriteLine("Pressione ENTER para sair!");
              Console.ReadKey();
            }
              
        }
    }
}
