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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GameClasses;
using System.Collections;

namespace Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public bool openFigures = false;

        public void placeFigure(Button button, string figure, int width, int height)
        { 
          
            Image img = new Image();
            img.Source = new BitmapImage(new Uri(@$"Resources\{figure}.png", UriKind.Relative));
            img.Width = width;
            img.Height = height;

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.Children.Add(img);
            button.GetType().GetProperty("Content").SetValue(button, stackPnl);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            placeFigure(A2, "pawnWhite", 40, 60);
            placeFigure(B2, "pawnWhite", 40, 60);
            placeFigure(C2, "pawnWhite", 40, 60);
            placeFigure(D2, "pawnWhite", 40, 60);
            placeFigure(E2, "pawnWhite", 40, 60);
            placeFigure(F2, "pawnWhite", 40, 60);
            placeFigure(G2, "pawnWhite", 40, 60);
            placeFigure(H2, "pawnWhite", 40, 60);

            placeFigure(A1, "rookWhite", 40, 60);
            placeFigure(B1, "knightWhite", 40, 60);
            placeFigure(C1, "bishopWhite", 40, 60);
            placeFigure(D1, "kingWhite", 40, 60);
            placeFigure(E1, "queenWhite", 40, 60);
            placeFigure(F1, "bishopWhite", 40, 60);
            placeFigure(G1, "knightWhite", 40, 60);
            placeFigure(H1, "rookWhite", 40, 60);
        }
        private void A2_Click(object sender, RoutedEventArgs e)
        {
            placeFigure(A2, "whitePawn", 40, 60);
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        private void F2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        private void G2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        private void H2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(checkBox.IsChecked.ToString()))
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"Resources\pawnWhite.png", UriKind.Relative));
                img.Width = 40;
                img.Height = 60;

                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);
                sender.GetType().GetProperty("Content").SetValue(sender, stackPnl);
            }
        }

        







        //private string GetKeyAndValue(object sender)
        //{
        //    MessageBox.Show($"{sender.GetType().GetProperty("Name").GetValue(sender)}");
        //    return sender.GetType().GetProperty("Name").GetValue(sender).ToString();
        //}
    }

    //public class NotifyPropertyChanged : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}
    //
    //public class RelayCommand : ICommand
    //{
    //    private readonly Action<object> _execute;
    //    private readonly Func<object, bool> _canExecute;
    //
    //    public event EventHandler CanExecuteChanged
    //    {
    //        add { CommandManager.RequerySuggested += value; }
    //        remove { CommandManager.RequerySuggested -= value; }
    //    }
    //
    //    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    //    {
    //        _execute = execute;
    //        _canExecute = canExecute;
    //    }
    //
    //    public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
    //    public void Execute(object parameter) => _execute(parameter);
    //}
    //
    //public class Cell : NotifyPropertyChanged
    //{
    //    private State _state;
    //    private bool _active;
    //
    //    public State State
    //    {
    //        get => _state;
    //        set
    //        {
    //            _state = value;
    //            OnPropertyChanged(); // сообщить интерфейсу, что значение поменялось, чтобы интефейс перерисовался в этом месте
    //        }
    //    }
    //    public bool Active // это будет показывать, что ячейка выделена пользователем
    //    {
    //        get => _active;
    //        set
    //        {
    //            _active = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //}
    //
    //public class Board : IEnumerable<Cell>
    //{
    //    private readonly Cell[,] _area;
    //
    //    public State this[int row, int column]
    //    {
    //        get => _area[row, column].State;
    //        set => _area[row, column].State = value;
    //    }
    //
    //    public Board()
    //    {
    //        _area = new Cell[8, 8];
    //        for (int i = 0; i < _area.GetLength(0); i++)
    //            for (int j = 0; j < _area.GetLength(1); j++)
    //                _area[i, j] = new Cell();
    //    }
    //
    //    public IEnumerator<Cell> GetEnumerator()
    //        => _area.Cast<Cell>().GetEnumerator();
    //
    //    IEnumerator IEnumerable.GetEnumerator()
    //        => _area.GetEnumerator();
    //
    //    //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    //    //{
    //    //    throw new NotImplementedException();
    //    //}
    //}
}
