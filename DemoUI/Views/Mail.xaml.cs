using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DemoUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mail : Page
    {
        internal ObservableCollection<Message1> Messages { get; set; } = new ObservableCollection<Message1>();
        public Mail()
        {
            this.InitializeComponent();
            InvertedListView.ItemsSource = Messages;
        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            Messages.Add(new Message1());
            InvertedListView.ItemsSource = Messages;
        }
        
        private void btnReceiveMessage_Click(object sender, RoutedEventArgs e)
        {
            Messages.Add(new Message1("Hello", "Test", HorizontalAlignment.Left));
            InvertedListView.ItemsSource = Messages;
        }

        private void ContactDeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            var message = item as Message1;
            Messages.Remove(message);
        }
    }
}
