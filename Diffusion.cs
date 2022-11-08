using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHeritage
{
    public abstract class Diffusion
    {
        protected String titre;
        protected int annee;

        public Diffusion(string titre, int annee)
        {
            this.titre = titre;
            this.annee = annee;
        }

        public String gettitre()
        {
            return titre;
        }

        public int getannee()
        {
            return annee;
        }

        public abstract String getInfos();

    }


    public class Serie : Diffusion
    {
        private int nbEpisode;

        public Serie(String titre, int annee, int nbEpisode) : base(titre, annee)
        {
            this.nbEpisode = nbEpisode;
        }

        public override string getInfos()
        {
            return base.annee + " " + base.titre + "(Nombre d'épisode = " + nbEpisode;
        }

        public int getnbEpisode()
        {
            return nbEpisode;
        }
    }

    public class Film : Diffusion
    {
        private int recette;

        public Film(String titre, int annee, int recette) : base(titre, annee)
        {
            this.recette = recette;
        }

        public override string getInfos()
        {
            return base.annee + " " + base.titre + "(recette = " + recette;
        }

        public int getRecette()
        {
            return recette;
        }
    }

   


}
