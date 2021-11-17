using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUITreeViewTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            ViewModel = new MainWindowViewModel();

            ObservableCollection<MyItem> root = new ObservableCollection<MyItem>();

            MyItem item1 = new MyItem() { Name = "Item1" };
            root.Add(item1);
            item1.Children.Add(new MyItem() { Name = "Item1.1" });
            item1.Children.Add(new MyItem() { Name = "Item1.2" });
            item1.Children.Add(new MyItem() { Name = "Item1.3" });

            MyItem item2 = new MyItem() { Name = "Item2" };
            root.Add(item2);
            item2.Children.Add(new MyItem() { Name = "Item2.1" });
            item2.Children.Add(new MyItem() { Name = "Item2.2" });
            item2.Children.Add(new MyItem() { Name = "Item2.3" });

            MyItem item3 = new MyItem() { Name = "Item3" };
            root.Add(item3);
            item2.Children.Add(new MyItem() { Name = "Item3.1" });
            item2.Children.Add(new MyItem() { Name = "Item3.2" });
            item2.Children.Add(new MyItem() { Name = "Item3.3" });

            ViewModel.MyItems = root;

            MyItemView.DataContext = ViewModel;
        }

        MainWindowViewModel ViewModel;
    }
}
