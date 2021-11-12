using System;

namespace Exerc_13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Informe os valores descubra se forma um triangulo retangulo");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor da Hipotenusa: ");
            s.setNum1(double.Parse(Console.ReadLine()));

            Console.Write("Informe o valor do 1° cateto: ");
            s.setNum2(double.Parse(Console.ReadLine()));

            Console.Write("Informe o valor do 2° cateto: ");
            s.setNum3(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

        }
    }
}