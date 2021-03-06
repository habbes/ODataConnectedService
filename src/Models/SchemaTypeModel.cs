﻿using System.ComponentModel;

namespace Microsoft.OData.ConnectedService.Models
{
    class SchemaTypeModel : INotifyPropertyChanged
    {
        private bool _isSelected;

        public SchemaTypeModel(): this(null, null)
        {
        }

        public SchemaTypeModel(string name, string shortName)
        {
            Name = name;
            ShortName = shortName;
        }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSelected"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
