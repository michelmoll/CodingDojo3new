using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private string newName;

        public string NewName
        {
            get { return newName; }
            set { newName = value; }
        }
        private ObservableCollection<String> softwareList;

        public ObservableCollection<String> SoftwareList
        {
            get { return softwareList; }
            set { softwareList = value; }
        }


    }
}
