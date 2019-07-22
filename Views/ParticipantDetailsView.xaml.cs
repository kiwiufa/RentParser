using RentParser.Model;
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

namespace RentParser.ViewModel
{
    /// <summary>
    /// Interaction logic for ParticipantDetailsView.xaml
    /// </summary>
    public partial class ParticipantDetailsView : Window
    {
        public ParticipantDetailsViewModel ViewModel { get; set; }
        public bool Modified { get; set; }

        public ParticipantDetailsView(ParticipantDetailsViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

        private void Name_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void key_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Comment_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
