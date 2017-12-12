namespace PcapVisualizer.UI
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// Элемент список с выбором
    /// </summary>
    [DefaultProperty("Items")]
    [DefaultEvent("SelectedIndexChanged")]
    [ComVisible(true)]
    [DefaultBindingProperty("Text")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public class SmallComboBox : ComboBox
    {
        /// <summary>
        /// Конструктор списка
        /// </summary>
        public SmallComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Получает или задает выбранный индекс
        /// </summary>
        [Browsable(true)]
        public int MySelectedIndex
        {
            get { return SelectedIndex; }
            set { SelectedIndex = value; }
        }
    }
}