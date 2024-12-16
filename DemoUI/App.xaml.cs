using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using UseCases.Classes;
//using Autofac;
using DataAccess.Gateways;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DemoUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public string AppName = "Demo App";
        private Window m_window;
        public Config Config { get; set; }

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            //var container = ConfigurationEngine.Configure();
            //using (var scope = container.BeginLifetimeScope())
            //{
            //    try
            //    {
            //        Config = scope.Resolve<Config>();
            //        ApiKeyGateway keyGateway = new ApiKeyGateway(Config);
            //        Config.LoadApiKeyChain(keyGateway); 
            //    }
            //    catch
            //    { }
            //}

            m_window = WindowHelper.CreateWindow();
            //Create a Frame to act as the navigation context
            Frame rootFrame = new Frame();
            rootFrame.NavigationFailed += OnNavigationFailed;
            rootFrame.Navigate(typeof(Views.MainPage), args.Arguments);

            //Place the frame in the current window
            m_window.Content = rootFrame;
            m_window.Activate();
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load page " + e.SourcePageType.FullName);
        }
       
    }
}
