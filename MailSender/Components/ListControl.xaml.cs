using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace MailSender.Components
{
    public  partial class ListControl : UserControl
    {
        #region PanelName : string - Название панели

        public static readonly DependencyProperty PanelNameProperty =
            DependencyProperty.Register(
                nameof(PanelName),
                typeof(string),
                typeof(ListControl),
                new PropertyMetadata("Панель"));

        public string PanelName
        {
            get => (string) GetValue(PanelNameProperty);
            set => SetValue(PanelNameProperty, value);
        }

        #endregion

        #region Items : IEnumerable - элементы списка

        public static readonly DependencyProperty ItemsProperty = 
            DependencyProperty.Register(
                nameof(Items), 
                typeof(IEnumerable), 
                typeof(ListControl), 
                new PropertyMetadata(default(IEnumerable)));

        public  IEnumerable Items
        {
            get => (IEnumerable) GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        #endregion

        #region SelectedElement : object - Выбранный элэмент

        public static readonly DependencyProperty SelectedElementProperty =
            DependencyProperty.Register(
                nameof(SelectedElement),
                typeof(object),
                typeof(ListControl),
                new PropertyMetadata(default(object)));

        public object SelectedElement
        {
            get => (object)GetValue(SelectedElementProperty);
            set => SetValue(SelectedElementProperty, value);
        }

        #endregion

        #region DisplayMemberPath : string - Имя свойства, выводимого на экран

        public static readonly DependencyProperty DisplayMemberPathProperty = 
            DependencyProperty.Register(
            nameof(DisplayMemberPath), 
            typeof(string), 
            typeof(ListControl), 
            new PropertyMetadata(default(string)));

        public string DisplayMemberPath
        {
            get => (string) GetValue(DisplayMemberPathProperty);
            set => SetValue(DisplayMemberPathProperty, value);
        }

        #endregion

        #region MyRegion

        public static readonly DependencyProperty ItemTemplateProperty = 
            DependencyProperty.Register(
            nameof(DataTemplate), 
            typeof(DataTemplate), 
            typeof(ListControl), 
            new PropertyMetadata(default(DataTemplate)));

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate) GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        #endregion

        public ListControl() => InitializeComponent();
    }
}
