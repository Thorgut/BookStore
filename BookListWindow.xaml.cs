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
    /// BookListWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class BookListWindow : Window
    {
        List<String> Books = new List<string>();
        public BookListWindow()
        {
            InitializeComponent();
        }
        public void AddBookToList(string book)
        {
            Books.Add(book);
            ListBoxItem tempbook = new ListBoxItem();
            tempbook.Content = book;
            BookListBox.Items.Add(tempbook);
        }

        private void AddAnotherButton_Click(object sender, RoutedEventArgs e)
        {
            SelectBookWindow SelectBook = new SelectBookWindow(this);
            SelectBook.Show();
            Hide();

        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            foreach (ListBoxItem s in BookListBox.SelectedItems.OfType<ListBoxItem>().ToList())
            {
                BookListBox.Items.Remove(s);
                Books.Remove(s.Content.ToString());
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Environment.Exit(0);
        }
    }
}
