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
        public CoreTabUserControl()
        {
            InitializeComponent();
        }

        private void manageAPIKeysTab_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Core.Classes.DynamicLoadingControl.CoreTabUserControlLoaded == false)
            {
                manageAPIKeysGrid.Children.Add(new ManageAPIKeysUserControl());
                Core.Classes.DynamicLoadingControl.CoreTabUserControlLoaded = true;
            }
        }
    }
}
