using System.Collections.ObjectModel;
using System.Windows;
using HospitalDateBase.WorkWIthDateBase;


namespace HospitalDateBase
{
 
    public partial class MainWindow
    {
        public readonly ObservableCollection<string> TableNameList = new() { "1", "2", "3" };
        
        
        public MainWindow()
        {
            InitializeComponent();
            
            TableName.ItemsSource = TableNameList;
        }

        private void ConnectButton_OnClick(object sender, RoutedEventArgs e)
        {
            HDB.IncludeDateBase();
        }

        private void CreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            HDB.CreateTable();
        }
    }
}