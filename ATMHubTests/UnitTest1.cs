namespace SWCBank;

public class UnitTest1
{
    [Fact]
    public void startHubTest1()
    {
        ATM_Hub hub = new();
        hub.startHub();
        Assert.Equal(3, hub.connected_ATMs.Count);
    }
}
