using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace TPGarage.Client.Models
{
    public class Brand : ObservableObject
    {
        #region Fields
        private string _Name;
        private ObservableCollection<Model> _Models;
        #endregion

        #region Properties
        public string Name { get => this._Name; set => SetProperty(nameof(Name), ref this._Name, value); }
        public ObservableCollection<Model> Models => this._Models;
        #endregion

        #region Constructors
        public Brand()
        {
            this._Models = new ObservableCollection<Model>();
        }
        #endregion
    }
}