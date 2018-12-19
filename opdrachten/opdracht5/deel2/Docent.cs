namespace deel2
{
    public class Docent : Persoon
    {
        // list opleiding
        public List opleiding
        {
            
        }
        public string emailAdres;
        public override int GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }
    }
}