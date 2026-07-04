using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ModelSynk.DataAccess.Enums;
using ModelSynk.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ModelSynk.ViewModels
{
    public partial class DataSourceSelectorViewModel : ViewModelBase
    {
        private readonly Window _dialog;

        public List<DataSourceViewModel> DataSources { get; set; }

        public ObservableCollection<DataSourceType> Types
        {
            get;
        } = new(DataSourceViewHelper.GetDataSourceComboBoxItems());

        public DataSourceSelectorViewModel(Window dialog, List<DataSourceViewModel> dataSources)
        {
            _dialog = dialog;
            DataSources = dataSources;
        }

        [ObservableProperty]
        private DataSourceViewModel _selectedDataSource;

        [RelayCommand]
        private void Confirm()
        {
            _dialog.Close(SelectedDataSource);
        }

        [RelayCommand]
        private void Cancel()
        {
            _dialog.Close(null);
        }
    }
}
