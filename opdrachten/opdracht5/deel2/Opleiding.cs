// 1 methode= getWifiCode

namespace deel2
{
    // overerving dmv ':'
    public class Opleiding : IInformatie
    {         
        // is een veld, want begint niet met hoofdletter   
        private string afkortingCampus;
        // protected = (#) type integer
        protected int campusNummer;
        // achterliggend: standaard default functionaliteit gebruiken, this.campus; geeft de return
        // dus maakt onzichtbaar een variabele aan, als je gaat debuggen, zie je dat er op de campus een waarde gezet is
        public string Campus{
            get; // waarde ophalen
            set; // waarde instellen
        }
        string GetWifiCode(){
            return "code";
        }
        public Opleiding(){
            // eerste 4 letters vd campusnaam hierin opslaan
            this.afkortingCampus = this.Campus.Substring(0,3);
        }
        public string ToString()
        {
            // specifieke is functie (maar eig een methode)
            // implementatie om object weer te geven als een string
            // waarom this? slaat op het object zelf
            return string.Format("Campus {0} - campusNummber {1}", this.Campus, this.campusNummer);
        }

    }
}