using System;
using Moq;
using NUnit.Framework;
using System.Windows.Input;
using WpfCalculatorApplication;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorViewModelTests
    {
        private CalculatorViewModel _viewModel;

        [SetUp]
        public void SetUp()
        {
            _viewModel = new CalculatorViewModel();
        }

        [Test]
        public void ViewModelInitializationTest()
        {
            Assert.That(_viewModel.Result.Equals("some random text"));
        }
    }
}
