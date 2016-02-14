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

namespace EveHQSharp.Core.UserControls
{
    /// <summary>
    /// Interaction logic for CoreTabUserControl.xaml
    /// </summary>
    public partial class CoreTabUserControl : UserControl
    {
        #region Initialization
        public CoreTabUserControl()
        {
            InitializeComponent();
        }

        private void dashboardGrid_Initialized(object sender, EventArgs e)
        {
            dashboardGrid.Children.Add(new DashboardUserControl());
        }
        #endregion

        #region DynamicLoadingEvents
        private void manageAPIKeysTab_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Classes.DynamicLoadingControl.CoreTabUserControlLoaded == false)
            {
                manageAPIKeysGrid.Children.Add(new EveAPI.UserControls.ManageAPIKeysUserControl());
                Classes.DynamicLoadingControl.CoreTabUserControlLoaded = true;
            }
        }

        private void manageCrestTokensTab_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Classes.DynamicLoadingControl.manageCrestTokensTabUserControlLoaded == false)
            {
                manageCrestTokensGrid.Children.Add(new EveAPI.UserControls.ManageCrestTokensUserControl());
                Classes.DynamicLoadingControl.manageCrestTokensTabUserControlLoaded = true;
            }
        }

        private void settingsTab_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Classes.DynamicLoadingControl.settingsTabUserControlLoaded == false)
            {
                settingsGrid.Children.Add(new SettingsUserControl());
                Classes.DynamicLoadingControl.settingsTabUserControlLoaded = true;
            }
        }
        #endregion
    }
}
