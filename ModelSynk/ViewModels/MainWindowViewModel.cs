namespace ModelSynk.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly object _settingsService;

        public MainWindowViewModel(object settingsService)
        {
            _settingsService = settingsService;
        }
    }
}
