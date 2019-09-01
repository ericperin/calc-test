using System;
using Xunit;

namespace Softplan.Calc.Tests
{
    public class JurosTests
    {
        [Fact]
        public void Should_return_error_when_interest_rate_is_null()
        {
            Assert.Equal(1, 0);
        }
    }
}
