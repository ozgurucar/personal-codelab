public class Light
{
    public bool lightOn = false;

    public void LightOn()
    {
        Console.WriteLine("Light On!");
        lightOn = true;
    }

    public void LightOff()
    {
        Console.WriteLine("Light Off!");
        lightOn = false;
    }
}