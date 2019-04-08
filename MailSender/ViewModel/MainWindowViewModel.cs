using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.Entityes;
using MailSender.Servises.Interfaces;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRecipientsData _recipientsData;

        private string _Title = "Рассыльщик почты";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        private string _Status = "Готов.";

        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        private double _Progress = 0.3;

        public double Progress
        {
            get => _Progress;
            set => Set(ref _Progress, value);
        }

        public ObservableCollection<Recipient> Recipients { get; } = new ObservableCollection<Recipient>();

        private Recipient _selectedRecipient;

        public Recipient SelectedRecipient
        {
            get => _selectedRecipient;
            set => Set(ref _selectedRecipient, value);
        }

        public ICommand LoadDataCommand { get; }

        public ICommand SaveRecipientCommand { get; }

        public MainWindowViewModel(IRecipientsData RecipientsData)
        {
            _recipientsData = RecipientsData;
            

            LoadDataCommand = new RelayCommand(OnLoadDataCommandExecuted);
            SaveRecipientCommand = new RelayCommand<Recipient>(OnSaveRecipientCommandExecuted, CanOnSaveRecipientCommandExecuted);
        }

        private void OnLoadDataCommandExecuted()
        {
            Recipients.Clear();
            foreach (var recipient in _recipientsData.GetItems())
                Recipients.Add(recipient);
        }

        private void OnSaveRecipientCommandExecuted(Recipient recipient)
        {
            _recipientsData.Edit(recipient);
        }

        private bool CanOnSaveRecipientCommandExecuted(Recipient recipient) => recipient != null;
    }
}
