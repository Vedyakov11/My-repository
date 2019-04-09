using System.Windows.Controls;

namespace MailSender.Views
{
    /// <summary>
    /// Логика взаимодействия для RecipientEditor.xaml
    /// </summary>
    public partial class RecipientEditor : UserControl
    {
        public RecipientEditor()
        {
            InitializeComponent();
        }

        private void OnValidationError(object sender, ValidationErrorEventArgs e)
        {
            if(!(e.Source is Control control)) return;

            control.ToolTip = e.Action == ValidationErrorEventAction.Added ? e.Error.ErrorContent.ToString() : "";
        }
    }
}
