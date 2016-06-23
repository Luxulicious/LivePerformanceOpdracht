using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Winkel
    {
        public List<Meer> Meren { get; set; }
        public List<Artikel> Artikelen { get; set; }
        public List<IBoot> Boten { get; set; }
        public List<Gebruiker> Gebruikers { get; set; }
        public Gebruiker IngelogdeGebruiker { get; set; }

        public List<Meer> GetMeren()
        {
            throw new NotImplementedException();
        }

        public List<Artikel> GetArtikelen()
        {
            throw new NotImplementedException();
        }

        public List<IBoot> GetBoten()
        {
            throw new NotImplementedException();
        }

        public List<Gebruiker> GetGebruikers()
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string email, string wachtwoord)
        {
            //TODO Nieuwe ingelogde gebruiker
            throw new NotImplementedException();
        }
    }
}
