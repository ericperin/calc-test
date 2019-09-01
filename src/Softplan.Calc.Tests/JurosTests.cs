using System;
using Xunit;
using Softplan.Calc.Domain.Entities;

namespace Softplan.Calc.Tests
{
    public class JurosTests
    {
        [Fact]
        public void Should_return_same_value_when_interest_rate_is_zero()
        {
            var valor = 100;
            var result = new Juros(0);
            
            Assert.Equal(valor, result.Calcula(valor, 10));
        }

        [Fact]
        public void Should_return_1051_when_interest_rate_is_1percent()
        {
            var result = new Juros(0.01);
            
            Assert.Equal(Convert.ToDecimal(105.1), result.Calcula(100, 5));
        }
    }
}
