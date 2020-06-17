using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Features.Others
{
    [Binding]
    public class ImpossibleToDoSteps
    {
        private int inputA { get; set; }
        private int inputB { get; set; }
        private int additionResult { get; set; }

        [Given(@"the user enters (.*) and (.*)")]
        public void GivenTheUserEntersAnd(int a, int b)
        {
            inputA = a;
            inputB = b;
        }
        
        [When(@"make the addtion")]
        public void WhenMakeTheAddtion()
        {
            additionResult = inputA + inputB;
        }
        
        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(int expectedAnswer)
        {
            Assert.That(additionResult, Is.EqualTo(expectedAnswer));
        }
    }
}
