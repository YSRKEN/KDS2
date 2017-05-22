namespace KDS2 {
	using System.Windows;
	using KDS2.Views;
	using KDS2.ViewModels;
	/// <summary>
	/// App.xaml の相互作用ロジック
	/// </summary>
	public partial class App : Application {
		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
			// メイン画面を作成して表示する
			var mv = new MainView();
			mv.DataContext = new MainViewModel();
			mv.Show();
		}
	}
}
