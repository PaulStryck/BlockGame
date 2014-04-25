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

namespace BlockGame
{
    /// <summary>
    /// Interaktionslogik für PlayingField.xaml
    /// </summary>
    public partial class PlayingField : Window
    {
        private RowDefinition rowOne = new RowDefinition();
        private RowDefinition rowTwo = new RowDefinition();
        private RowDefinition rowThree = new RowDefinition();
        private RowDefinition rowFour = new RowDefinition();
        private RowDefinition rowFive = new RowDefinition();
        private RowDefinition rowSix = new RowDefinition();

        private ColumnDefinition columnOne = new ColumnDefinition();
        private ColumnDefinition columnTwo = new ColumnDefinition();
        private ColumnDefinition columnThree = new ColumnDefinition();
        private ColumnDefinition columnFour = new ColumnDefinition();
        private ColumnDefinition columnFive = new ColumnDefinition();

        private Player playerOne;
        private Player playerTwo;

        private Button btnQuit = new Button();

        public PlayingField(Player playerOne,Player playerTwo)
        {
            InitializeComponent();

            this.KeyDown += PlayingField_KeyDown;
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            this.btnQuit.Content = "Quit";
            this.btnQuit.Click += btnQuit_Click;

            Grid.SetRow(this.btnQuit,5);

            Grid.SetColumn(this.playerOne.getRectangle(), 0);
            Grid.SetRow(this.playerOne.getRectangle(), 0);

            Grid.SetColumn(this.playerTwo.getRectangle(), 5);
            Grid.SetRow(this.playerTwo.getRectangle(), 5);

            this.playingFieldContainer.RowDefinitions.Add(rowOne);
            this.playingFieldContainer.RowDefinitions.Add(rowTwo);
            this.playingFieldContainer.RowDefinitions.Add(rowThree);
            this.playingFieldContainer.RowDefinitions.Add(rowFour);
            this.playingFieldContainer.RowDefinitions.Add(rowFive);
            this.playingFieldContainer.RowDefinitions.Add(rowSix);

            this.playingFieldContainer.ColumnDefinitions.Add(columnOne);
            this.playingFieldContainer.ColumnDefinitions.Add(columnTwo);
            this.playingFieldContainer.ColumnDefinitions.Add(columnThree);
            this.playingFieldContainer.ColumnDefinitions.Add(columnFour);
            this.playingFieldContainer.ColumnDefinitions.Add(columnFive);

            this.playingFieldContainer.Children.Add(this.playerOne.getRectangle());
            this.playingFieldContainer.Children.Add(this.playerTwo.getRectangle());
            this.playingFieldContainer.Children.Add(this.btnQuit);
        }

        void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        void PlayingField_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.S:
                    this.playerOne.moveDown();
                    Grid.SetRow(this.playerOne.getRectangle(), this.playerOne.getPositon()[0]);
                    break;
                case Key.W:
                    this.playerOne.moveUp();
                    Grid.SetRow(this.playerOne.getRectangle(), this.playerOne.getPositon()[0]);
                    break;
                case Key.A:
                    this.playerOne.moveLeft();
                    Grid.SetColumn(this.playerOne.getRectangle(), this.playerOne.getPositon()[1]);
                    break;
                case Key.D:
                    this.playerOne.moveRight();
                    Grid.SetColumn(this.playerOne.getRectangle(), this.playerOne.getPositon()[1]);
                    break;
                case Key.Down:
                    this.playerTwo.moveDown();
                    Grid.SetRow(this.playerTwo.getRectangle(), this.playerTwo.getPositon()[0]);
                    break;
                case Key.Up:
                    this.playerTwo.moveUp();
                    Grid.SetRow(this.playerTwo.getRectangle(), this.playerTwo.getPositon()[0]);
                    break;
                case Key.Left:
                    this.playerTwo.moveLeft();
                    Grid.SetColumn(this.playerTwo.getRectangle(), this.playerTwo.getPositon()[1]);
                    break;
                case Key.Right:
                    this.playerTwo.moveRight();
                    Grid.SetColumn(this.playerTwo.getRectangle(), this.playerTwo.getPositon()[1]);
                    break;
            }
        }
    }
}
