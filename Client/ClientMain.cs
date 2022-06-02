using System.Threading.Tasks;
using CitizenFX.Core;
using PauseMenuText.Client.Models;

namespace PauseMenuText.Client;

public class ClientMain : BaseScript
{
    private readonly Configuration _configuration;

    public ClientMain()
    {
        Debug.WriteLine("Constructor called for PauseMenuText, by dnlib");

        _configuration = ConfigurationLoader.LoadConfiguration();
    }

    [Tick]
    public Task HandleTickAsync()
    {
        MenuTextLoader.SetTitle(_configuration.Title, _configuration.Subtitle);
        MenuTextLoader.SetTabText(_configuration);
        
        return Task.FromResult(true);
    }
}