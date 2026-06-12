
partial class Program
{
    static void Interfaces()
    {

    }

    interface IForceUser
    {
        int PowerLevel { get; set; }
        string? LightsaberColor { get; set; }

        void UseForce();
    }


    class Jedi : IForceUser
    {
        public int PowerLevel { get; set; }
        public string? LightsaberColor { get; set; }

        public void UseForce()
        {
            WriteLine("Soy un jedi con sable de luz");
        }
    }

    class Sith : Jedi, IForceUser
    {
        public new void UseForce()
        {
            WriteLine("llll");
        }
    }

}