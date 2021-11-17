using MvvmGen;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUITreeViewTest
{
    [ViewModel]
    public partial class MainWindowViewModel
    {
        [Property]
        ObservableCollection<MyItem> myItems;
    }

    [ViewModel]
    public partial class MyItem
    {
        public string Name { get; set; }

        public override string ToString() => Name;

        [Property]
        private bool? isSelected;

        [Property]
        private bool isExpanded;

        [Property]
        private ObservableCollection<MyItem> children = new ObservableCollection<MyItem>();
    }
}
