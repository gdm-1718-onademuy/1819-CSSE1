// velden bovenaan, dan properties en dan methods

namespace deel2
{
    public class Gebruiker
    {   
        // velden
        protected string wachtwoord;
        public string Gebruikersnaam
        {
            get;
            set;
        }
        // virtual => 
        public virtual string GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }
        public void GenereerGebruikersnaam()
        {   
            this.Gebruikersnaam= test;            
        }
        // zelfde naam als klasse, dan geen methode, dit is defaultconstructor (deze moet je eig nie aanmaken, maar wij wel)
        public  Gebruiker()
        {
            this.wachtwoord = GenereerWachtwoord();
        }

        

    }
}