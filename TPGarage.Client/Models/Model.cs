using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TPGarage.Client.Models
{
    public class Model : ObservableObject
    {
        #region Fields
        private string _Name;
        #endregion

        #region Properties
        public string Name { get => this._Name; set => SetProperty(nameof(Name), ref this._Name, value); }
        #endregion
    }
}