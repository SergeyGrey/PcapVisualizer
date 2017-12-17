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
    /// <summary>
    /// Тестирование работы подели параметров фильтра
    /// </summary>
    [TestFixture]
    class FilterParametersViewModelTests
    {
        private FilterParametersViewModel _model;

        /// <summary>
        /// Иинициализация до тестов
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _model = new FilterParametersViewModel();
        }

        /// <summary>
        /// Проверка обновления свойства выбранного файла
        /// </summary>
        [Test]
        public void SetFileTest()
        {
            _model.SetSelectedFile(null, "filepath");
            Assert.That(_model.SelectedFile, Is.EqualTo("filepath"));
        }
        
        /// <summary>
        /// Проверка усатновки значения выбранного протокола
        /// </summary>
        [Test]
        public void SetAndGetprotocolTests()
        {
            _model.SelectedProtocolState = (int) ProtocolState.HTTP;
            Assert.That(_model.SelectedProtocolState, Is.EqualTo((int)ProtocolState.HTTP));

            _model.ResetProtocol(null, null);

            Assert.That(_model.SelectedProtocolState, Is.EqualTo((int)ProtocolState.All));
        }

        /// <summary>
        /// Проверка события изменения протокола
        /// </summary>
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