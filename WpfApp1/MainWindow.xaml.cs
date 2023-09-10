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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //myButton.FontSize = 12;
            //myButton.Content = "Lieo";

            TextBlock myTB = new TextBlock();
            myTB.Text = "Hello Lieo";
            this.Content = myTB;
            myTB.Inlines.Add(" Inline data is cool");
            myTB.TextWrapping = TextWrapping.Wrap;

            myTB.Inlines.Add(new Run(" Lorem ipsum donor omg lol nrt how cool")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Strikethrough,
            });
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
    