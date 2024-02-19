
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PROJET_CAMP.components
{
    public partial class Emplacement : UserControl
    {
        public Emplacement()
        {
            InitializeComponent();
            Height = 63;
        }


        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Emplacement), new PropertyMetadata(string.Empty));

        public string Title
        {
            get { return (string) GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty AngleProperty =
           DependencyProperty.Register("Angle", typeof(string), typeof(Emplacement), new PropertyMetadata("0"));

        public string Angle
        {
            get { return (string)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        public static readonly RoutedEvent ViewEmplacementEvent = 
            EventManager.RegisterRoutedEvent(nameof(ViewEmplacementClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Emplacement));

        public event RoutedEventHandler ViewEmplacementClick {
            add { AddHandler(ViewEmplacementEvent, value);  }
            remove { RemoveHandler(ViewEmplacementEvent, value); }
        }

        private void OnViewEmplacementClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ViewEmplacementEvent));
        }
    }
}
