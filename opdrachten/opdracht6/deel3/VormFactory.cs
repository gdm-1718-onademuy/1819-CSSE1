namespace AbstractFactory
{
    public class VormFactory
    {
        public IVorm GetVorm(string typeVorm)
        {
            if(typeVorm == null)
            {
                return null;
            }
            else if (typeVorm.Equals("Cirkel"))
            {
                return new Cirkel();
            }
            return null;
        }
    }
}