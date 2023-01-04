namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient httpClient= new HttpClient();

    List<Monkey> monkeys= new ();
    public async Task<List<Monkey>> GetMonkeys()
    {
        if(monkeys.Count > 0)
        {
            return monkeys;
        }

        return monkeys;
    }
}
