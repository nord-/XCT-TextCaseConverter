using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GitApp1
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		private string _licensePlate;
		public event PropertyChangedEventHandler PropertyChanged;

		public string LicensePlate
		{
			get => _licensePlate;
			set
			{
				if (value == _licensePlate) return;
				_licensePlate = value;
				OnPropertyChanged();
			}
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
