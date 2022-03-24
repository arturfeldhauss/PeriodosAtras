using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class TempoPassado
    {
        public string Verificar(DateTime data)
        {
            TimeSpan resultado = DateTime.Now - data;

            int semanas = resultado.Days / 7;

            int dias = resultado.Days % 7;

            if (resultado.Days == 1)
                return "Um dia atrás";

            if (resultado.Days == 2)
                return "Dois dias atrás";

            if (resultado.Days == 3)
                return "Tres dias atrás";

            if (resultado.Days == 4)
                return "Quatro dias atrás";

            if (resultado.Days == 5)
                return "Cinco dias atrás";

            if (resultado.Days == 6)
                return "Seis dias atrás";

            if (resultado.Days == 7)
                return "1 semana atrás";

            if (resultado.Days == 8)
                return "1 semana e 1 dia atrás";

            return "";
        }
    }

}
