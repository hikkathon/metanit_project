using metanit_wpf_mvvm.ViewModels;
using System.Windows;

namespace Viwes.metanit_wpf_mvvm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
