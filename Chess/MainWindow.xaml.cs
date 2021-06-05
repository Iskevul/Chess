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

        private Piece piece;
        private Button piecePosition;
        public string pieceName;
        public Dictionary<string, string> buttonsBook = new Dictionary<string, string>{
            {"A1", "rookWhite"},
            {"B1", "knightWhite"},
            {"C1", "bishopWhite"},
            {"D1", "kingWhite"},
            {"E1", "queenWhite"},
            {"F1", "bishopWhite"},
            {"G1", "knightWhite"},
            {"H1", "rookWhite"},

            {"A2", "pawnWhite"},
            {"B2", "pawnWhite"},
            {"C2", "pawnWhite"},
            {"D2", "pawnWhite"},
            {"E2", "pawnWhite"},
            {"F2", "pawnWhite"},
            {"G2", "pawnWhite"},
            {"H2", "pawnWhite"},

            {"A3", ""},
            {"B3", ""},
            {"C3", ""},
            {"D3", ""},
            {"E3", ""},
            {"F3", ""},
            {"G3", ""},
            {"H3", ""},

            {"A4", ""},
            {"B4", ""},
            {"C4", ""},
            {"D4", ""},
            {"E4", ""},
            {"F4", ""},
            {"G4", ""},
            {"H4", ""},

            {"A5", ""},
            {"B5", ""},
            {"C5", ""},
            {"D5", ""},
            {"E5", ""},
            {"F5", ""},
            {"G5", ""},
            {"H5", ""},

            {"A6", ""},
            {"B6", ""},
            {"C6", ""},
            {"D6", ""},
            {"E6", ""},
            {"F6", ""},
            {"G6", ""},
            {"H6", ""},

            {"A7", "pawnBlack"},
            {"B7", "pawnBlack"},
            {"C7", "pawnBlack"},
            {"D7", "pawnBlack"},
            {"E7", "pawnBlack"},
            {"F7", "pawnBlack"},
            {"G7", "pawnBlack"},
            {"H7", "pawnBlack"},

            {"A8", "rookBlack"},
            {"B8", "knightBlack"},
            {"C8", "bishopBlack"},
            {"D8", "queenBlack"},
            {"E8", "kingBlack"},
            {"F8", "bishopBlack"},
            {"G8", "knightBlack"},
            {"H8", "rookBlack"},
        };
        public Dictionary<int, string> letters = new Dictionary<int, string>
        {
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"},
            {5, "E"},
            {6, "F"},
            {7, "G"},
            {8, "H"},
        };
        public bool openFigures = false;
        public bool selectFigure = false;

        public int ClickX = 0;
        public int ClickY = 0;

        public void SelectBase(int x, int y)
        {
            ClickX = x;
            ClickY = y;
            selectFigure = true;
        }

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
            placeFigure(D1, "kingWhite", 40, 70);
            placeFigure(E1, "queenWhite", 40, 70);
            placeFigure(F1, "bishopWhite", 40, 60);
            placeFigure(G1, "knightWhite", 40, 60);
            placeFigure(H1, "rookWhite", 40, 60);

            placeFigure(A7, "pawnBlack", 40, 60);
            placeFigure(B7, "pawnBlack", 40, 60);
            placeFigure(C7, "pawnBlack", 40, 60);
            placeFigure(D7, "pawnBlack", 40, 60);
            placeFigure(E7, "pawnBlack", 40, 60);
            placeFigure(F7, "pawnBlack", 40, 60);
            placeFigure(G7, "pawnBlack", 40, 60);
            placeFigure(H7, "pawnBlack", 40, 60);

            placeFigure(A8, "rookBlack", 40, 60);
            placeFigure(B8, "knightBlack", 40, 60);
            placeFigure(C8, "bishopBlack", 40, 60);
            placeFigure(D8, "kingBlack", 40, 70);
            placeFigure(E8, "queenBlack", 40, 70);
            placeFigure(F8, "bishopBlack", 40, 60);
            placeFigure(G8, "knightBlack", 40, 60);
            placeFigure(H8, "rookBlack", 40, 60);
        }

        private void Field_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            StackPanel buttonContent = (StackPanel)clickedButton.GetType().GetProperty("Content").GetValue(clickedButton);
            int row = Grid.GetRow(clickedButton);
            int col = Grid.GetColumn(clickedButton);
            string buttonName = clickedButton.Name;
            //pieceName = buttonsBook[buttonName];

            //select
            if (!selectFigure)
            {
                //var selectedPiece = buttonsBook[buttonName];
                pieceName = buttonsBook[buttonName];
                piece = PieceMaker.Make(pieceName, col, row);
                piecePosition = clickedButton;
                selectFigure = true;
                buttonsBook[buttonName] = "";
                return;
            }


            // move
            //if (clickedButton.Content == null && piece.Move(col, row) && selectFigure)
            if (selectFigure && piece.Move(col, row) && clickedButton.Content == null)
            {
                clickedButton.Content = piecePosition.Content;
                buttonName = clickedButton.Name;
                buttonsBook[buttonName] = pieceName;
                piecePosition.Content = null;
                piecePosition = clickedButton;
                selectFigure = false;
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
