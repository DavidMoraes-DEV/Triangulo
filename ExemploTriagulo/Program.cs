using ExemploTriagulo;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triagulo x, y;
            x = new Triagulo();
            y = new Triagulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CI));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CI));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }/*Conceitos IMPORTANTES para utilizar CLASSES, OBJETOS e ATRIBUTOS
      para definir uma classe para um OBJETO (triagulo) do problema exemplo
      para que a organização fique mais nítida dispençando a necessidade de
      se utilizar diversas variáveis soltas no código. Aprendendo também como
      criar uma classe (TRIAGULO) e utiliza-la para atribuir variáveis desse
      programa para dentro dessa classe.

      Aula explicativa desse código sobre classe:
      Criando uma Classe com três atributos para representar melhor um Triângulo.

      Conceito de Método: Método é uma FUNÇÃO dentro da CLASSE.
      
      Aula explicativa sobre o conceito de Método:
      Criando um método para obtermos os benefícios de reaproveitamento e delegação.
    */
    }