namespace deel2
{
    public class Student : Persoon
    {
        public string Emailadres{
            get;
            set;
        }
        //waarom Opleiding ipv string?
        public Opleiding Opleiding{
            get;
            set;
        }
        public override string GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }
    }
}