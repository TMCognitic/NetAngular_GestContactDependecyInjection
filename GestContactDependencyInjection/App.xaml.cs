using GestContactDependencyInjection.ViewModels.Messages;
using GestContactDependencyInjection.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tools.Patterns.Mediator;

namespace GestContactDependencyInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ResourceLocator ResourceLocator
        {
            get { return (ResourceLocator)Resources["Locator"]; }
        }

        public App()
        {
            Messenger<WindowTypes>.Default.OnMessage += OnWindowsMessage;
        }

        private void OnWindowsMessage(WindowTypes message)
        {
            switch (message)
            {
                case WindowTypes.Main:
                    break;
                case WindowTypes.AddContact:
                    AddContactWindow window = new AddContactWindow();
                    window.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
