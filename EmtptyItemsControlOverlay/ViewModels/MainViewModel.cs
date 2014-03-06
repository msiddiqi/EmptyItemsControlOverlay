using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmtptyItemsControlOverlay.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<string> Students { get; set; }

        public string EmptyText { get; set; }

        public MainViewModel()
        {
            EmptyText = "Empty Text. How ??";
            Students = new ObservableCollection<string>();
            Students.Add("Muhammad");
        }
    }
}
