
partial class Program
{
    static void AbstractClassExamples()
    {
        HomeAppliance myWhaser = new WashingMaching();
        myWhaser.Brand = "Samsung";
        myWhaser.TurnOn();
        myWhaser.ShowBrand();

        HomeAppliance myMicroWave = new MicroWave();
        myMicroWave.Brand = "LG";
        myMicroWave.TurnOn();
        myMicroWave.ShowBrand();

    }

    abstract class HomeAppliance
    {
        public string? Brand { get; set; }

        public abstract void TurnOn();
        public void ShowBrand()
        {
            WriteLine($"Esta appliance es de la marca {Brand}");
        }
    }

    class WashingMaching : HomeAppliance
    {
        public override void TurnOn()
        {
            WriteLine("🎰 encendiendo la maquina de lavado ");
        }
    }

    class MicroWave : HomeAppliance
    {
        public override void TurnOn()
        {
            WriteLine($"🔥 el microondas esta encendiendo");
        }
    }

}