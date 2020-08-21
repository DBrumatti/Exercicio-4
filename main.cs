using System;

class MainClass {

  static void Main(string[] args)
  {
    double nota1, nota2, nota3, nota4, media;
    Console.WriteLine("Digite a nota 1: ");
    nota1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a nota 2: ");
    nota2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a nota 3: ");
    nota3 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a nota 4: ");
    nota4 = Convert.ToDouble(Console.ReadLine());
    
    media = (nota1 + nota2 + nota3 + nota4) / 4 ;
    Console.WriteLine("A média do aluno é: " + media);
    Console.ReadKey();
  }
}

  