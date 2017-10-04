namespace ForeignExchange.ViewModels
{
	using System;
	using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Input;
    using ForeignExchange.Models;
    using GalaSoft.MvvmLight.Command;

    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Atributes
        bool _isRunning;
        string _result;
        #endregion



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
			get
			{
				return _isRunning;
			}
			set
			{
				if (_isRunning != value)
				{
					_isRunning = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(IsRunning)));
				}
			}
		}

		public bool IsEnabled
		{
			get;
			set;
		}

		public string Result
		{
			get
			{
                return _result;
			}
			set
			{
				if (_result != value)
				{
					_result = value;
					PropertyChanged?.Invoke(
						this,
						new PropertyChangedEventArgs(nameof(IsRunning)));
				}
			}
		}


        #endregion



        #region Constructors
        public MainViewModel()
        {
            LoadRates();
        }

        #endregion


        #region Methods
        void LoadRates()
        {
            IsRunning = true;
            Result = "Loading Rates...!";
        }

        #endregion





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
