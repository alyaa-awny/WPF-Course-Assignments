using System.Collections.Generic;
using System.Windows;

namespace day2
{
    /// <summary>
    /// Interaction logic for ListOfStudents.xaml
    /// </summary>
    public partial class ListOfStudents : Window
    {
        public List<Student> Students { get; set; }
        public ListOfStudents()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new(){Id=1,Name="Alyaa",   Grade=80 ,Img="/img6.jpg"},
                new(){Id=2,Name="Amira",   Grade=70 ,Img="/img5.jpg"},
                new(){Id=3,Name="Heba",  Grade=95 ,Img="/img3.jpg"},
                new(){Id=4,Name="Bassem", Grade=60 ,Img="/img12.jpg"},
                new(){Id=5,Name="Shimaa",  Grade=85 ,Img="/img5.jpg"},
                new(){Id=6,Name="Hala", Grade=90  ,Img="/img4.jpg"},
            };
            lst.ItemsSource = Students;
        }
    }
}
