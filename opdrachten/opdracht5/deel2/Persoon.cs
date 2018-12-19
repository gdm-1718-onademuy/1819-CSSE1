// we roepen genereerwachtwoord methode op (die string teruggeeft) ==> welke gaat hij uitvoeren? die van de subklasse (van de child, niet van parent)
// gebruiker bestaat al, overerven van gebruiker (':')

namespace deel2
{
    public class Persoon : Gebruiker, Opleiding
    {
        private string Naam;
        public string Voornaam
        {
            get{ return this.Voornaam;}
            set{ return this.Voornaam = value;}
        }
        public string VolledigeNaam
        {
            get;
        }

        public string GenereerWachtwoord()
        {
            return "Persoon - wachtwoord";
        }
        public string GenereerWachtwoord(int input)
        {   
            return "Test1";
        }
       public string GenereerWachtwoord(string input)
        {
            return "Test2";
        }
        /*
        MAG/KAN NIET
        public string GenereerWachtwoord()
        {
            return "89734";
        }
        */
    
    }
}



// EXAMENVRAAG
// KAN IK IN C# MULTIPLE INHERITANCE TOEPASSEN? (meerdere klassen overerven)
// je kan wel van een klasse overerven en hiervan inter..
