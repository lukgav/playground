using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_playground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // // Create the StackPanel 
            // StackPanel stackPanel = new StackPanel(); 
            // this.Content = stackPanel; 

            // // Create the Button 
            // Button button = new Button();
            // button.Content = "Click Me"; 
            // button.HorizontalAlignment = HorizontalAlignment.Left; 
            // button.Margin = new Thickness(150); 
            // button.VerticalAlignment = VerticalAlignment.Top; 
            // button.Width = 75; 
            // stackPanel.Children.Add(button); 
        }
    }
}
