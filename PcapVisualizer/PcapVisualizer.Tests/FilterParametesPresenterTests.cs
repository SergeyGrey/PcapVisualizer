using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    /// <summary>
    /// Тестирование представления параметров визуализатора
    /// </summary>
    [TestFixture]
    class FilterParametesPresenterTests
    {
        /// <summary>
        /// Представление параметров визуализатора
        /// </summary>
        private FilterParametersPresenter _presenter;

        /// <summary>
        /// Вид параметров визуализатора
        /// </summary>
        private Mock<IFilterParametersView> _viewMock;

        /// <summary>
        /// Предварительная настройка
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _viewMock = new Mock<IFilterParametersView>();
            _viewMock.Setup(view => view.ViewModel).Returns(new FilterParametersViewModel());
            _presenter = new FilterParametersPresenter(_viewMock.Object);
        }

        /// <summary>
        /// Проверка корректности работы конструктора c параметром
        /// </summary>
        [Test]
        public void WithMockConstructorShouldInitializeView()
        {
            Assert.That(_viewMock.Object.ViewModel, Is.Not.Null);

            Assert.That(_presenter.View, Is.EqualTo(_viewMock.Object));
        }

        /// <summary>
        /// Проверка корректности работы конструктора
        /// </summary>
        [Test]
        public void ConstructorShouldInitializeView()
        {
            var searchParametersViewMock = new FilterParametesViewMock();
            var searchParametersPresenter = new FilterParametersPresenter(searchParametersViewMock);
            Assert.That(searchParametersPresenter.View, Is.EqualTo(searchParametersViewMock));
        }

        /// <summary>
        /// Проверка вызова свойства модели
        /// </summary>
        [Test]
        public void WithMock()
        {
            var searchParametersViewModel = new FilterParametersViewModel();
            _presenter.Initialize(searchParametersViewModel);

            _viewMock.VerifySet(v => v.ViewModel = searchParametersViewModel, Times.Once());
            _viewMock.VerifyGet(v => v.ViewModel, Times.Never);
        }

        /// <summary>
        /// Проверка инициализации модели
        /// </summary>
        [Test]
        public void InitializeShouldSetViewModel()
        {
            var searchParametersViewMock = new FilterParametesViewMock();
            var searchParametersPresenter = new FilterParametersPresenter(searchParametersViewMock);
            var searchParametersViewModel = new FilterParametersViewModel();

            searchParametersPresenter.Initialize(searchParametersViewModel);

            Assert.That(searchParametersViewMock.ViewModel, Is.EqualTo(searchParametersViewModel));
        }
    }
}
