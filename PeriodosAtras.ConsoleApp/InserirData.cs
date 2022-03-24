using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    internal class InserirData
    {
        public int data;
        public int horas;
        public int minutos;
        public int segundos;

        public int Data()
        {
            var data = new DateTime();
            Console.WriteLine("Informe a data: " + data);

            return this.data;
            
           
        }
    }

   
}
