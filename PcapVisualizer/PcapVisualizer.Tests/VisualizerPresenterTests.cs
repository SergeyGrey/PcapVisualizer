using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    /// <summary>
    /// Тестирование представления визуализатора
    /// </summary>
    class VisualizerPresenterTests
    {
        /// <summary>
        /// Представление визуализатора
        /// </summary>
        private VisualizerPresenter _presenter;

        /// <summary>
        /// Вид визуализатора
        /// </summary>
        private Mock<IVisualizerView> _viewMock;

        /// <summary>
        /// Вид параметров визуализатора
        /// </summary>
        private Mock<IFilterParametersView> _viewParametersMock;

        /// <summary>
        /// Предварительная настройка
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _viewParametersMock = new Mock<IFilterParametersView>();
            _viewParametersMock.Setup(view => view.ViewModel).Returns(new FilterParametersViewModel());

            _viewMock = new Mock<IVisualizerView>();
            _viewMock.Setup(view => view.ControlView).Returns(_viewParametersMock.Object);
            _viewMock.Setup(view => view.ViewModel).Returns(new VisualizerViewModel());

            _presenter = new VisualizerPresenter(_viewMock.Object, new FilterParametersPresenter(_viewParametersMock.Object));
        }

        /// <summary>
        /// Проверка работы конструктора с параметром
        /// </summary>
        [Test]
        public void WithMockConstructorShouldInitializeView()
        {
            Assert.That(_viewMock.Object.ViewModel, Is.Not.Null);

            Assert.That(_presenter.View, Is.EqualTo(_viewMock.Object));
        }

        /// <summary>
        /// Проверка работы конструктора
        /// </summary>
        [Test]
        public void ConstructorShouldInitializeView()
        {
            var searchViewMock = new VisualizerViewMock();
            searchViewMock.ControlView = new FilterParametesViewMock();

            var searchPresenter = new VisualizerPresenter(searchViewMock, new FilterParametersPresenter(new FilterParametesViewMock()));
            Assert.That(searchPresenter.View, Is.EqualTo(searchViewMock));
        }

        /// <summary>
        /// Проверка вызова свойств модели
        /// </summary>
        [Test]
        public void WithMock()
        {
            var searchViewModel = new VisualizerViewModel();
            _presenter.Initialize(searchViewModel);

            _viewMock.VerifySet(v => v.ViewModel = searchViewModel, Times.Once());
            _viewMock.VerifyGet(v => v.ViewModel, Times.AtMost(2));
        }

        /// <summary>
        /// Проверка инициализации модели
        /// </summary>
        [Test]
        public void InitializeShouldSetViewModel()
        {
            var searchViewMock = new VisualizerViewMock();
            searchViewMock.ControlView = new FilterParametesViewMock();

            var searchPresenter = new VisualizerPresenter(searchViewMock, new FilterParametersPresenter(new FilterParametesViewMock()));
            var searchViewModel = new VisualizerViewModel();

            searchPresenter.Initialize(searchViewModel);

            Assert.That(searchViewMock.ViewModel, Is.EqualTo(searchViewModel));
        }
    }
}
