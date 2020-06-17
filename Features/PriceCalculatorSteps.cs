using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Features
{
    [Binding]
    public class PriceCalculatorSteps
    {
        private string sku { get; set; }
        private int amount { get; set; }
        private int totalPrice { get; set; }

        [Given(@"I enter SKU number '(.*)'")]
        public void InputSKU(string inputSku)
        {
            sku = inputSku;
        }

        [Given(@"I enter purchase amount (.*)")]
        public void InputAmount(int inputAmount)
        {
            amount = inputAmount;
        }

        [When(@"I clicks calculate")]
        public void ClickCalculate()
        {
            var calculator = new Calculator();
            calculator.Sku = sku;
            calculator.Amount = amount;
            totalPrice = calculator.CalculatePriceToPay();
        }

        [Then(@"the calculator shows (.*) as the total price to pay")]
        public void Calculate(int expectedPrice)
        {
            Assert.That(totalPrice, Is.EqualTo(expectedPrice));
        }
    }
}