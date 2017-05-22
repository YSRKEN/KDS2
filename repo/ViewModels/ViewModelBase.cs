namespace KDS2.ViewModels {
	using System.ComponentModel;
	class ViewModelBase : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged(string parameter) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parameter));
	}
}
