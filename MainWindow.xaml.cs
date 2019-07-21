using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
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
using CsvHelper;
using RentParser.ViewModel;
using RentParser.Views;

namespace RentParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; }

        public string ImportFilename { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            DataContext = ViewModel;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.LoadTransactions();
        }

        private void DefineTableStructure()
        {
            //GridView grdView = new GridView();
            //grdView.AllowsColumnReorder = true;

            ////Date column
            //GridViewColumn dateColumn = new GridViewColumn();
            //dateColumn.DisplayMemberBinding = new Binding("Date");
            //dateColumn.Header = "Date";
            //dateColumn.Width = 120;
            //grdView.Columns.Add(dateColumn);

            ////Date column
            //GridViewColumn amountColumn = new GridViewColumn();
            //amountColumn.DisplayMemberBinding = new Binding("Amount");
            //amountColumn.Header = "Amount";
            //amountColumn.Width = 120;
            //grdView.Columns.Add(amountColumn);

            ////Payee column
            //GridViewColumn payeeColumn = new GridViewColumn();
            //payeeColumn.DisplayMemberBinding = new Binding("Payee");
            //payeeColumn.Header = "Payee";
            //payeeColumn.Width = 120;
            //grdView.Columns.Add(payeeColumn);

            ////From column
            //GridViewColumn fromColumn = new GridViewColumn();
            //fromColumn.DisplayMemberBinding = new Binding("OtherPartyAccount");
            //fromColumn.Header = "OtherPartyAccount";
            //fromColumn.Width = 120;
            //grdView.Columns.Add(fromColumn);

            //DataTable dt = new DataTable();
            //dt.Columns.Add(new DataColumn("Date", typeof(string)));
            //dt.Columns.Add(new DataColumn("Amount", typeof(string)));
            //dt.Columns.Add(new DataColumn("Payee", typeof(string)));
            //dt.Columns.Add(new DataColumn("From", typeof(string)));
            //DataRow dr = dt.NewRow();
            //dr["Date"] = 1;
            //dr["Amount"] = 2;
            //dr["Payee"] = 3;
            //dr["From"] = 4;
            //dt.Rows.Add(dr);
            //dt.Rows.Add(dr);
            //dt.Rows.Add(dr);

            //transaction_view.View.BindData

            //transaction_view.View = grdView;
            //transaction_view.DataContext = dt;

        }

        private void Import_file_btn_Click(object sender, RoutedEventArgs e)
        {
            //DefineTableStructure();
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    ImportFilename = openFileDialog.FileName;
            //    import_file_text.Text = ImportFilename;

            //    using (TextReader reader = File.OpenText(ImportFilename))
            //    {
            //        CsvReader csv = new CsvReader(reader);
            //        csv.Configuration.Delimiter = ",";
            //        csv.Configuration.MissingFieldFound = null;
            //        while (csv.Read())
            //        {
            //            TransactionEntry transaction = csv.GetRecord<TransactionEntry>();
            //            Transactions.Add(transaction);
            //            _transactionCollection.Add(transaction);
            //        }
            //    }
            //}

            //transaction_view.DataContext = _transactionCollection;
            //DefineTableStructure();

            //import_file_text.Text = "Done";
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TransactionEntry selectedEntry = ((TransactionEntry)((ListViewItem)sender).Content);
            TransactionDetailsView detailsView = new TransactionDetailsView(selectedEntry);
            detailsView.Show();
        }
    }
}
