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

namespace Polygone
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Cote = 0;
            int Angle = 0;
            int MemeTaille = 0;
            int NombreParallele = 0;

            string Error = "";
            bool isError = false;
            
            if(!int.TryParse(NombreCote.Text, out Cote))
            {
                Error = "Le cote doit être un entier.";
                isError = true;
            }
            if(!int.TryParse(AngleDroit.Text, out Angle) && !String.IsNullOrEmpty(AngleDroit.Text))
            {
                Error += "Le nombre d'angle droit doit être un entier.";
                isError = true;
            }
            if(!int.TryParse(Taille.Text, out MemeTaille) && !String.IsNullOrEmpty(Taille.Text))
            {
                Error += "Le nombre de cote ayant la même taille doit être un entier.";
                isError = true;
            }
            if(!int.TryParse(Parrallele.Text, out NombreParallele) && !String.IsNullOrEmpty(Parrallele.Text))
            {
                Error += "Le nombre de coté parallele doit être un entier.";
                isError = true;
            }

            if (isError)
            {
                Resultat.Text = Error;
                Resultat.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }



           
            
        }
    }
}
