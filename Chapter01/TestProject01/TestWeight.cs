using System;
using System.IO.IsolatedStorage;
using System.Net.Mail;
using System.Threading.Channels;
using Targil01;
using Xunit.Abstractions;

namespace TestProject01
{
    public class TestWeight
    {
        private readonly ITestOutputHelper _output;

        public TestWeight(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void Constractor_DefualtValues()
        {
            Weight weight = new Weight();

            Console.Out.WriteLine(weight.Gram);
            Console.Out.WriteLine(weight.Kilo);

        }
        [Fact]
        public void Constractor_TotalGram()
        {
            Weight weight = new Weight(3256);

            Assert.Equal(3, weight.Kilo);
            Assert.Equal(256, weight.Gram);

            _output.WriteLine($"weight.Kilo:{weight.Kilo}, weight.Gram:{weight.Gram}");


        }
    }
}