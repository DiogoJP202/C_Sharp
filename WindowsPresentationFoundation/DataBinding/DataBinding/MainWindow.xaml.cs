using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataBinding.Data;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> People = new List<Person>
        {
            new Person{Name = "Jannick", Age = 30},
            new Person{Name = "Marc", Age = 20},
            new Person{Name = "Maria", Age = 40},
            new Person{Name = "Scott", Age = 35},
            new Person{Name = "Lucas", Age = 27 },

        };

        public MainWindow()
        {
            InitializeComponent();
            // Assigning our People List to our ListBox control:
            ListBoxPeople.ItemsSource = People;
        }

        private void SendData_Button(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            string text = string.Empty;

            foreach (Person person in selectedItems)
            {
                text += $"Name: {person.Name}, Age: {person.Age}\n";
            }
            
            MessageBox.Show(text, "Items selected:");
        }
    }
}