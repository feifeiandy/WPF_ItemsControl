using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WpfApp8
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> students;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            students = new ObservableCollection<Student>();
            for (int i = 0; i < 15; i++)
            {
                Student student = new Student();
                student.Id = i;
                student.Name = "选手" + i;
                students.Add(student);
            }
            this.ic.ItemsSource = students;
            this.LST.ItemsSource = students;

            Student st = new Student();
            st.Id = 100;
            st.Name = "选手100";
            this.ct.Content = st;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int id = (int)button.Tag;
            (students.Where(c=>c.Id==id)).FirstOrDefault().Name="选手"+id+"获胜！";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.Id = students.Last().Id + 1;
            student.Name = "选手"+student.Id;
            students.Add(student);
        }
    }

    class Student : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {

                id = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                }
            }
        }

        private string name;
        public string Name
        {

            get { return name; }
            set
            {
                name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
