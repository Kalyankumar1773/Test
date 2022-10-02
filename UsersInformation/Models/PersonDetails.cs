using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;
using UsersInformation.ViewModel;

namespace UsersInformation.Models
{
    public class PersonDetails :ViewModelBase
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Age { get; set; }
        public string? Qualification { get; set; }

    }
}
