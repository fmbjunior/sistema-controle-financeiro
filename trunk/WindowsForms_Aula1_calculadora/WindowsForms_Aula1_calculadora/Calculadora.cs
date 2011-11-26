using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_Aula1_calculadora
{
    public class Calculadora
    {

        public double num1 {get;set;}
        public double num2 { get; set; }
        public double resultado { get; set; }
        public char op { get; set; }



        public void calcular(char op) 
        {
     
            switch (op)
            { 
                case '+':
                    resultado=soma();
                    break;

                case '-':
                    resultado = subtracao();
                    break;

                case '*':
                    resultado = multiplicao();
                    break;

                case '/':
                    resultado = divisao();
                    break;
            
            }
           
        
        }




        // Operações
        private double soma()
        {
            return num1 + num2;
        }

        private double subtracao()
        {
            return num1 - num2;
        }

        private double multiplicao()
        {
            return num1 * num2;
        }

        private double divisao()
        {
            return num1 / num2;
        }

       
    }
}
