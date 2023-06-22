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

namespace Binding_Practic
{
    public partial class MainWindow : Window
    {        
        public List<User>? Users { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Users = new Bogus.Faker<User>()
           .RuleFor(u => u.FirstName, f => f.Person.FirstName)
           .RuleFor(u => u.LastName, f => f.Person.LastName)
           .RuleFor(u => u.Address, f => f.Address.ToString())
           .RuleFor(u => u.Email, f => f.Person.Email)
           .RuleFor(u => u.Phone, f => f.Person.Phone)
           .RuleFor(u => u.ImageUrl, f => f.Person.Avatar).Generate(150);


            
        }

        
    }
}
