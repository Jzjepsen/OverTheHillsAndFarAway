namespace OverTheHillsAndFarAway;

public class Lala : IObserver
{
    public Lala(TubbyTelephoneTelephoneSubject tubbyTelephoneTelephoneSubject)
    {
        tubbyTelephoneTelephoneSubject.registerTeletubby(this);
    }
    public void update(int num)
    {
        Console.WriteLine("Lala number: "+ num);
    }
}