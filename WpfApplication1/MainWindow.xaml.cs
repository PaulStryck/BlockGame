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

namespace BlockGame
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button btnStart = new Button();
        private Button btnConfigure = new Button();
        private Button btnQuit = new Button();
        private StackPanel spMenue = new StackPanel();
        private Style syMenue = new Style();
        private Player playerOne = new Player();
        private Player playerTwo = new Player();

        public MainWindow()
        {
            InitializeComponent();

            //Add Button and Menue styling
            btnStart.Content = "Start";
            btnStart.Style = syMenue;
            btnStart.Click += btnStart_Click;
            btnConfigure.Content = "Configure";
            btnConfigure.Style = syMenue;
            btnConfigure.Click += btnConfigure_Click;
            btnQuit.Content = "Quit";
            btnQuit.Style = syMenue;
            btnQuit.Click += btnQuit_Click;
            
            //Added Buttons to Menue
            spMenue.Children.Add(btnStart);
            spMenue.Children.Add(btnConfigure);
            spMenue.Children.Add(btnQuit);
            spMenue.Width = 200;

            //Added Menue to displayed container
            container.Children.Add(spMenue);
        }

        void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnConfigure_Click(object sender, RoutedEventArgs e)
        {
            Config config = new Config(this.playerOne,this.playerTwo);
            config.ShowDialog();
        }

        void btnStart_Click(object sender, RoutedEventArgs e)
        {
            PlayingField playingField = new PlayingField(this.playerOne,this.playerTwo);
            playingField.ShowDialog();
        }
    }
}
