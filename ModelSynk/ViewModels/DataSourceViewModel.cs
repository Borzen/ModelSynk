using CommunityToolkit.Mvvm.ComponentModel;
using ModelSynk.DataAccess.Enums;
using ModelSynk.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ModelSynk.ViewModels
{
    public partial class DataSourceViewModel : ViewModelBase
    {
        public DataSourceType Type { get; set; }

        public string Logo { get { return DataSourceViewHelper.GetDataSourceLogo(Type); } }

        public string Name { get; set; }

        public string ConnectionString { get; set; }

        

    }
}
