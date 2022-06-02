using Newtonsoft.Json;

namespace PauseMenuText.Client.Models;

public class Configuration
{
    [JsonProperty("title")] public string Title { get; set; }

    [JsonProperty("subtitle")] public string Subtitle { get; set; }

    [JsonProperty("map")] public string Map { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("game")] public string Game { get; set; }

    [JsonProperty("info")] public string Info { get; set; }

    [JsonProperty("settings")] public string Settings { get; set; }

    [JsonProperty("rockstar_editor")] public string RockstarEditor { get; set; }
}