using System;
using System.Collections.Generic;
using System.Text;
using VolumeDrive.ViewModels.Base;

namespace VolumeDrive.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title;
        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnPropertyChanged();
            //    Set(ref _Title, ref value);
            //    set => Set(ref _Title, ref value);
            //}
            set => Set(ref _Title, ref value);
        }
        #endregion
    }
}
