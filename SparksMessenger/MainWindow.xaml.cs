using System;
using System.Windows;
using SparksMessenger.Controller;

namespace SparksMessenger
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private BroadcastController controller { get; set; }
		public MainWindow()
		{
			InitializeComponent();
			controller = new BroadcastController();
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			controller.SendSignOnMessage(Guid.NewGuid());
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			controller.Close();
		}
	}
}
