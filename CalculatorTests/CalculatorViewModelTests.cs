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
            Assert.That(_viewModel.Result.Equals("0"));
        }

        [Test]
        public void NumberButtonCommandTest()
        {
            _viewModel.Result = string.Empty;
            _viewModel.NumberButtonCommand.Execute(5);
            _viewModel.NumberButtonCommand.Execute(2);
            Assert.That(_viewModel.Result.Equals("52"));
        }

        [Test]
        public void ArithematicCommandTest()
        {
            _viewModel.Result = string.Empty;
            _viewModel.NumberButtonCommand.Execute(5);
            _viewModel.NumberButtonCommand.Execute(2);
            _viewModel.ArithematicButtonCommand.Execute("+");
            _viewModel.NumberButtonCommand.Execute(2);
            Assert.That(_viewModel.Result.Equals("52+2"));
        }

        [Test]
        public void EqualsTest()
        {
            _viewModel.Result = string.Empty;
            _viewModel.NumberButtonCommand.Execute(5);
            _viewModel.NumberButtonCommand.Execute(2);
            _viewModel.ArithematicButtonCommand.Execute("+");
            _viewModel.NumberButtonCommand.Execute(2);
            Assert.That(_viewModel.Result.Equals("52+2"));
            _viewModel.ArithematicButtonCommand.Execute("=");
            Assert.That(_viewModel.Result.Equals("54"));
        }
    }
}
