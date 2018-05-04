using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjetoSoma.Modelo
{
   public class Controler
    {
    
        private string num1;
        private string num2;
        private string op;
        private string resposta;
       // como relacionar o num1 do private string comm o num1 do public controle:

           
        public Controle ( string num1, string num2, string op)
        {
            // enxerga quem esta mais proximo, ambos são do public controle
            // this.num1 é para identificar o num1 deste comando
            //this é a representação desta classe em que e le está (ppublic controle), 
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            calcular();
            //fora desse bloco ninguem enxerga o num
            
        }
        

        public void calcular ()

               Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
           
            try
            {
        //this pertence a classe inteira, o resultado é para todos
                n1 = Convert.ToDouble(this.num1);
                n2 = Convert.ToDouble(this.num2);
                if (this.op.Equals("+"))
                {
                    resultado = n1 + n2;
                }
                if (this.op.Equals("-"))
                {
                    resultado = n1 - n2;
                }

                if (this.op.Equals("*"))
                {
                    resultado = n1 * n2;
                }

                if (this.op.Equals("/"))
                {
                    if (n2 == 0)
                    {
                       this.resposta = "Divisão por zero";
                    }
                }
                else
                {
                    this.resultado = n1 / n2;
                   this.resposta = resultado.ToString();
                }
            }
            catch (FormatException e)
            {
               this.resposta = "Digite um número válido";
            }
        }
          #endregion
    }

        
    }
           
}
