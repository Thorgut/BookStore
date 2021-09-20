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

namespace BookStore
{
    /// <summary>
    /// SelectBookWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class SelectBookWindow : Window
    {
        BookListWindow booklistwindow = new BookListWindow();
        Boolean nextconfirm = false;
        public SelectBookWindow()
        {
            InitializeComponent();
           
        }
        public SelectBookWindow(BookListWindow booklist)
        {
            booklistwindow = booklist;
            InitializeComponent();

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                NextButton.IsEnabled = true;


        }

        private void Confirm_Unchecked(object sender, RoutedEventArgs e)
        {
            NextButton.IsEnabled = false;
        }

        private void CategoryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem tempitem = (ComboBoxItem)CategoryBox.SelectedItem;
            if (tempitem == null)
            {
                BookBox.Items.Clear();
                return;
            }
            else if (tempitem.Content.Equals("Adventure"))
            {
                BookBox.Items.Clear();
                BookBox.Items.Add("Tarzan");
                BookBox.Items.Add("Harry Potter");
                BookBox.Items.Add("Game Of Thrones");
                
            }
            else if (tempitem.Content.Equals("Classics"))
            {
                BookBox.Items.Clear();
                BookBox.Items.Add("Jane Eyre");
                BookBox.Items.Add("War and Peace");
                BookBox.Items.Add("Les Misérables");
            }
            else if (tempitem.Content.Equals("Science Fiction"))
            {
                BookBox.Items.Clear();
                BookBox.Items.Add("Dune");
                BookBox.Items.Add("Jurassic Park");
                BookBox.Items.Add("The Left Hand of Darkness");
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {


            nextconfirm = true;
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (BookBox.SelectedItem != null) {
             
                booklistwindow.AddBookToList((string)BookBox.SelectedItem);
                MessageBox.Show("Selected Book added!");
                }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (nextconfirm == true)
            {
                booklistwindow.Show();
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }
}
