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
using System.Windows.Shapes;
using System.Diagnostics;

namespace BlockGame
{
    /// <summary>
    /// Interaktionslogik für Config.xaml
    /// </summary>
    public partial class Config : Window
    {

        private Button btnSave = new Button();
        private Button btnQuit = new Button();
        private Player playerOne;
        private Player playerTwo;
        private Label lblPlayerNameOne = new Label();
        private Label lblPlayerNameTwo = new Label();
        private TextBox tbPlayerNameOne = new TextBox();
        private TextBox tbPlayerNameTwo = new TextBox();
        private StackPanel spPlayerOne = new StackPanel();
        private StackPanel spPlayerTwo = new StackPanel();
        private StackPanel spButtonBar = new StackPanel();
        private StackPanel spMenue = new StackPanel();

        public Config(Player playerOne,Player playerTwo)
        {
            InitializeComponent();

            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            this.btnSave.Content = "Save";
            this.btnSave.Click += btnSave_Click;
            this.btnQuit.Content = "Quit";
            this.btnQuit.Click += btnQuit_Click;
            this.lblPlayerNameOne.Content = "Spieler 1 Name: ";
            this.lblPlayerNameTwo.Content = "Spieler 2 Name: ";
            this.tbPlayerNameOne.Width = 150;
            this.tbPlayerNameTwo.Width = 150;

            this.spPlayerOne.Orientation = Orientation.Horizontal;
            this.spPlayerOne.HorizontalAlignment = HorizontalAlignment.Center;
            this.spPlayerOne.Children.Add(lblPlayerNameOne);
            this.spPlayerOne.Children.Add(tbPlayerNameOne);

            this.spPlayerTwo.Orientation = Orientation.Horizontal;
            this.spPlayerTwo.HorizontalAlignment = HorizontalAlignment.Center;
            this.spPlayerTwo.Children.Add(lblPlayerNameTwo);
            this.spPlayerTwo.Children.Add(tbPlayerNameTwo);

            this.spButtonBar.Orientation = Orientation.Horizontal;
            this.spButtonBar.HorizontalAlignment = HorizontalAlignment.Center;
            this.spButtonBar.Children.Add(btnQuit);
            this.spButtonBar.Children.Add(btnSave);

            this.spMenue.Children.Add(spPlayerOne);
            this.spMenue.Children.Add(spPlayerTwo);
            this.spMenue.Children.Add(spButtonBar);

            this.container.Children.Add(spMenue);
        }

        void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine(this.ToString() + ": Quit");

            this.DialogResult = false;
        }

        void btnSave_Click(object sender, RoutedEventArgs e)
        {
            this.playerOne.setName(tbPlayerNameOne.Text);
            this.playerOne.setRectangle(Brushes.Gray);
            this.playerTwo.setName(tbPlayerNameOne.Text);
            this.playerTwo.setRectangle(Brushes.Gray);
            
            Trace.WriteLine(this.playerOne.ToString());
            Trace.WriteLine(this.playerTwo.ToString());

            this.DialogResult = true;
        }


    }
}
