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

namespace WpfApp8
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Families families = new Families();

            Person person1 = new Person();
            person1.ID = 1;
            person1.Name = "小三";
            People people1 = new People();
            people1.Add(person1);
            Family family1 = new Family();
            family1.ID = 1;
            family1.Name = "张三家";
            family1.Merbers = people1;
            families.Add(family1);
            Like like1 = new Like();
            like1.Name = "潇洒";
            Likes likes = new Likes();
            likes.Add(like1);
            person1.PLike = likes;

            Person person2 = new Person();
            person2.ID = 2;
            person2.Name = "小四";
            People people2 = new People();
            people2.Add(person2);
            Family family2 = new Family();
            family2.Name = "李四家";
            family2.ID = 2;
            family2.Merbers = people2;
            families.Add(family2);
            Like like2 = new Like();
            like2.Name = "干活";
            Likes likes2 = new Likes();
            likes2.Add(like2);
            person2.PLike = likes2;

            this.gd.DataContext = families;
        }
    }
}
