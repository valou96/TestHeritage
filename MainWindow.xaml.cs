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

namespace TestHeritage
{
    
    public partial class MainWindow : Window
    {
        private List<Diffusion> LesDiffusions = new List<Diffusion>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MajLstDiffusion()
        {
            LesDiffusions.Clear();
            foreach(Diffusion uneDiffusion in LesDiffusions)
            {
                LesDiffusions.Add(uneDiffusion);
                
            }
        }

        private void RestrictionAjout()
        {
            /*LblRecette.Visibility = RdbFilm.Checked;
            TxtRecette.Visibility = RdbFilm.Checked;
            LblNbepisode.Visibility = !RdbFilm.Checked;
            TxtNbepisode.Visibility = !RdbFilm.Checked;*/
        }
        

        private void RdbFilm_checked(object sender, EventArgs e)
        {
            RestrictionAjout();
        }

        private void RdbSerie_checked(object sender, EventArgs e)
        {
            RestrictionAjout();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Diffusion uneDiffusion;
            if ((bool)RdbFilm.IsChecked)
            {
                uneDiffusion = new Film(TxtTitre.Text, int.Parse(TxtAnnee.Text), int.Parse(TxtRecette.Text));
            }
            else
            {
                uneDiffusion = new Serie(TxtTitre.Text, int.Parse(TxtAnnee.Text), int.Parse(TxtNbepisode.Text));
            }
            LesDiffusions.Add(uneDiffusion);
            MajLstDiffusion();
        }
    }
}
