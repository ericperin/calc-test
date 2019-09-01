using System;
using Xunit;
using Softplan.Calc.Domain.Entities;

namespace Softplan.Calc.Tests
{
    public class JurosTests
    {
        [Fact]
        public void Should_return_error_when_interest_rate_is_null()
        {
            var result = new Juros(0.01);
            
            Assert.Equal(Convert.ToDecimal(105.1), result.Calcula(100, 5));
        }
    }
}
