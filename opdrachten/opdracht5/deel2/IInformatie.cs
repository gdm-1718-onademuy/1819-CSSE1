// property met een hoofdletter, een veld niet
// property kan veranderen, veld blijft hetzelfde
namespace deel2
{
    public interface IInformatie
    {
        //private string type;
        //public
        string GroepType
        {
            get;
            set;
        }
        //methode om in string over te zetten
        string ToString();
    }
}

