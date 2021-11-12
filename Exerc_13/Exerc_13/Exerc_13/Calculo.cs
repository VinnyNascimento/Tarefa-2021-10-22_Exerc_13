using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_13
{
    class Calculo
    {
        #region atributos
        private double num1;
        private double num2;
        private double num3;
        private double resultado;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.num3 = 0;
        }

        public Calculo(double num1, double num2, double num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }

        public void setNum3(double num3)
        {
            this.num3 = num3;
        }

        public double getNum1()
        {
            return this.num1;
        }

        public double getNum2()
        {
            return this.num2;
        }
        public double getNum3()
        {
            return this.num3;
        }
        public double getResultado()
        {
            return this.resultado;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            this.resultado = (this.num2 * this.num2) + (this.num3 * this.num3);

            if (this.resultado == this.num1 * this.num1)
            {
                Console.Write("Os valores inseridos são de um triângulo retângulo");
            }

            else
            {
                Console.Write("Os valores inseridos não são de um triângulo retângulo");
            }
        }
        #endregion
    }
}