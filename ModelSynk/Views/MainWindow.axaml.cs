using Avalonia.Controls;
using ModelSynk.ViewModels;

namespace ModelSynk.Views
{
    public partial class MainWindow : Window
    {
        private DataSourceViewModel _selectedDataSource;
        public MainWindow()
        {
            InitializeComponent();
            //Get DataSource
            var dataSourceSelector = new DataSourceSelectorWindow();
            //dataSourceSelector.DataContext = 
        }
    }
}