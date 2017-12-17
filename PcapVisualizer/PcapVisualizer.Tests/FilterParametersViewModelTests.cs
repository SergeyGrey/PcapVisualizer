using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class FilterParametersViewModelTests
    {
        private FilterParametersViewModel _model;

        [SetUp]
        public void SetUp()
        {
            _model = new FilterParametersViewModel();
        }

        [Test]
        public void SetFileTest()
        {
            _model.SetSelectedFile(null, "filepath");
            Assert.That(_model.SelectedFile, Is.EqualTo("filepath"));
        }
        
        [Test]
        public void SetAndGetprotocolTests()
        {
            _model.SelectedProtocolState = (int) ProtocolState.HTTP;
            Assert.That(_model.SelectedProtocolState, Is.EqualTo((int)ProtocolState.HTTP));

            _model.ResetProtocol(null, null);

            Assert.That(_model.SelectedProtocolState, Is.EqualTo((int)ProtocolState.All));
        }

        [Test]
        public void FilterStateChangedTest()
        {
            bool filterStarted = false;
            int newState = (int)ProtocolState.TCP;

            bool visualStateUpdated = false;

            _model.FilterChanged += delegate(object sender, FilterParameters parameters)
            {
                filterStarted = true;
                newState = (int) parameters.SelectedProtocol;
            };

            _model.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            {
                visualStateUpdated = true;
            };

            _model.ResetProtocol(null, null);

            Assert.True(filterStarted);
            Assert.That(newState, Is.EqualTo((int) ProtocolState.All));

            Assert.True(visualStateUpdated);
        }
    }
}