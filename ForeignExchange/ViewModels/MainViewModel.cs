namespace ForeignExchange.ViewModels
{
	using System;
	using System.Collections.ObjectModel;
    using System.Windows.Input;
    using ForeignExchange.Models;
    using GalaSoft.MvvmLight.Command;

    public class MainViewModel
    {
        #region Properties
        public string Amount
        {
            get;
            set;
        }

        public ObservableCollection<Rate> MyProperty
        {
            get;
            set;
        }

        public Rate SourceRate
        {
            get;
            set;
        }

		public Rate TargetRate
		{
			get;
			set;
		}

        public bool IsRunning
		{
			get;
			set;
		}

		public bool IsEnabled
		{
			get;
			set;
		}

		public string Result
		{
			get;
			set;
		}


        #endregion



        public MainViewModel()
        { 
        }

        #region Command

        public ICommand ConvertCommand
        {
            get
            {
                return new RelayCommand(Convert);
            }
        }

        void Convert()
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
