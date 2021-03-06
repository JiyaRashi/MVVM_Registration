//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SampleCustomersDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SampleCustomersDataSource { }
#else

	public class SampleCustomersDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleCustomersDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/DesignTimeSampleData;component/SampleData/SampleCustomersDataSource/SampleCustomersDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Customers _Customers = new Customers();

		public Customers Customers
		{
			get
			{
				return this._Customers;
			}
		}
	}

	public class Customers : System.Collections.ObjectModel.ObservableCollection<CustomersItem>
	{ 
	}

	public class CustomersItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Id = string.Empty;

		public string Id
		{
			get
			{
				return this._Id;
			}

			set
			{
				if (this._Id != value)
				{
					this._Id = value;
					this.OnPropertyChanged("Id");
				}
			}
		}

		private string _FirstName = string.Empty;

		public string FirstName
		{
			get
			{
				return this._FirstName;
			}

			set
			{
				if (this._FirstName != value)
				{
					this._FirstName = value;
					this.OnPropertyChanged("FirstName");
				}
			}
		}

		private string _LastName = string.Empty;

		public string LastName
		{
			get
			{
				return this._LastName;
			}

			set
			{
				if (this._LastName != value)
				{
					this._LastName = value;
					this.OnPropertyChanged("LastName");
				}
			}
		}
	}
#endif
}
