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

namespace MyWorldMapControl
{
    public delegate void MapClickedEventHandler(object o, MapClickedEventArgs e);

    public class MapClickedEventArgs : EventArgs
    {
        public readonly int Region;

        public MapClickedEventArgs(int num)
        {
            Region = num;
        }

    }


    /// <summary>
    /// Interaction logic for WorldMapControl.xaml
    /// </summary>
    public partial class WorldMapControl : UserControl
    {
        public event MapClickedEventHandler MapClicked;

        public WorldMapControl()
        {
            InitializeComponent();
        }

        private void PathSouthAmerica_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MapClicked != null)
                MapClicked(new object(), new MapClickedEventArgs(2));
        }
        
        private void PathNorthAmerica_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MapClicked != null)
                MapClicked(new object(), new MapClickedEventArgs(1));
        }

        private void PathEurope_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MapClicked != null)
                MapClicked(new object(), new MapClickedEventArgs(3));
        }

        private void PathAfrica_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MapClicked != null)
                MapClicked(new object(), new MapClickedEventArgs(4));
        }

        private void PathAsia_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MapClicked != null)
                MapClicked(new object(), new MapClickedEventArgs(5));
        }

        private void PathOceania_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MapClicked != null)
                MapClicked(new object(), new MapClickedEventArgs(6));
        }
    }
}
