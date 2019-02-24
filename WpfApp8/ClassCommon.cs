using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public class ClassCommon
    {
    }


    public class Families : ObservableCollection<Family>
    {

    }

    public class Family
    {
        public int ID { get; set; }
        public string FamilyName { get; set; }
        public People Merbers { get; set; }

    }

    public class People : ObservableCollection<Person>
    {

    }
    public class Person
    {
        public int ID { get; set; }
        public string PersonName { get; set; }
        public Likes PLike { get; set; }
    }

    public class Likes : ObservableCollection<Like>
    {

    }
    public class Like
    {
        public string LikeName { get; set; }
    }
}
