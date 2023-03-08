namespace OverTheHillsAndFarAway;

public abstract class TelephoneSubject
{
    private List<IObserver> _teletubbies;

    public TelephoneSubject()
    {
        _teletubbies = new List<IObserver>();
    }
    public void registerTeletubby(IObserver observer)
    {
        _teletubbies.Add(observer);
    }

    public void unregisterTeletubby(IObserver observer)
    {
        _teletubbies.Remove(observer);

    }

    public void notifyTeletubby(int num)
    {
        foreach (var teletubby in _teletubbies)
        {
            teletubby.update(num);
        }
    }

}