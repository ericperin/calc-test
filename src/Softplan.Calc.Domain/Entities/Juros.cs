using System;

namespace Softplan.Calc.Domain.Entities
{
    public class Juros
    {
        public Juros(double valor)
        {
            Valor = valor;
        }
        public double Valor { get; private set; }

        public decimal Calcula(decimal valorInicial, int meses)
        {
            var potencia = Math.Pow(1 + Valor, meses);
            var valorFinal = Convert.ToDecimal(Convert.ToDouble(valorInicial) * potencia);

            return Decimal.Round(valorFinal, 2);
        }
    }
}
