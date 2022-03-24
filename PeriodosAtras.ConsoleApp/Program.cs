using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            TempoPassado tempoPassado = new TempoPassado();

            DateTime ontem = new DateTime(2022,03,23);

            string ontemPorExtenso = tempoPassado.Verificar(ontem); 

            Console.WriteLine(ontemPorExtenso); //Um dia atrás

            DateTime anteOntem = new DateTime(2022, 03, 22);

            string anteOntemPorExtenso = tempoPassado.Verificar(anteOntem); 

            Console.WriteLine(anteOntemPorExtenso); //Dois dias atrás

            DateTime tresDiasAtras = new DateTime(2022, 03, 21);

            string tresDiasPorExtenso = tempoPassado.Verificar(tresDiasAtras);

            Console.WriteLine(tresDiasPorExtenso); //Três dias atrás

            DateTime quatroDiasAtras = new DateTime(2022, 03, 20);

            string quatroDiasPorExtenso = tempoPassado.Verificar(quatroDiasAtras);

            Console.WriteLine(quatroDiasPorExtenso); //Quatro dias atrás

            DateTime cincoDiasAtras = new DateTime(2022, 03, 19);

            string cincoDiasPorExtenso = tempoPassado.Verificar(cincoDiasAtras);

            Console.WriteLine(cincoDiasPorExtenso); //Cinco dias atrás

            DateTime seisDiasAtras = new DateTime(2022, 03, 18);

            string seisDiasPorExtenso = tempoPassado.Verificar(seisDiasAtras);

            Console.WriteLine(seisDiasPorExtenso); //Seis dias atrás

            DateTime umaSemanaAtras = new DateTime(2022, 03, 17);

            string umaSemanasPorExtenso = tempoPassado.Verificar(umaSemanaAtras);

            Console.WriteLine(umaSemanasPorExtenso); //1 semana atrás

            DateTime SemanaMais1D = new DateTime(2022, 03, 16);

            string SemanaMais1DPorExtenso = tempoPassado.Verificar(SemanaMais1D);

            Console.WriteLine(SemanaMais1DPorExtenso); //1 semana e 1 dia atrás



        }

        #region testes Felipe
        /**
         *   var data = new DateTime();
            Console.WriteLine("Informe a data: " + data);
            
            Console.WriteLine("---------------------------------------------------");

            DateTime date1 = new DateTime();

            Console.WriteLine(date1);

            Console.ReadLine();
         * 
         */


        #endregion
    }
}
