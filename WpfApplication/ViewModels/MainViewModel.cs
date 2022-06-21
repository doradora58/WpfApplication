using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.ViewModels
{
    using WpfTaskApplication.Commands;
    using WpfApplication.Models;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.OpenMessageDialogCommand = new OpenMessageDialogCommand();
            this.UserModel = new UserModel();
        }

        public OpenMessageDialogCommand OpenMessageDialogCommand { get; set; }

        public UserModel UserModel { get; set; }
    }
}
