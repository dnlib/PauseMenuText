using CitizenFX.Core;
using CitizenFX.Core.Native;
using Newtonsoft.Json;
using PauseMenuText.Client.Models;

namespace PauseMenuText.Client;

public class ConfigurationLoader : BaseScript
{
    public static Configuration LoadConfiguration()
    {
        var fileContents = API.LoadResourceFile(API.GetCurrentResourceName(), "config.json");
        return JsonConvert.DeserializeObject<Configuration>(fileContents);
    }
}