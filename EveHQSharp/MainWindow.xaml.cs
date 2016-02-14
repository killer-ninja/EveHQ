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

namespace EveHQSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Initialization
        public MainWindow()
        {
            InitializeComponent();
        }

        private void coreGrid_Initialized(object sender, EventArgs e)
        {
            coreGrid.Children.Add(new Core.UserControls.CoreTabUserControl());
        }
        #endregion

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        #region DynamicLoadingEvents
        private void pilotTab_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Core.Classes.DynamicLoadingControl.PilotManagerTabUserControlLoaded == false)
            {
                pilotGrid.Children.Add(new PilotManager.UserControls.PilotManagerTabUserControl());
                Core.Classes.DynamicLoadingControl.PilotManagerTabUserControlLoaded = true;
            }
        }
        #endregion
    }
}
