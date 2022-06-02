using CitizenFX.Core;
using CitizenFX.Core.Native;
using PauseMenuText.Client.Models;

namespace PauseMenuText.Client;

public class MenuTextLoader : BaseScript
{
    public static void SetTitle(string title, string subtitle)
    {
        API.N_0xb9449845f73f5e9c("SHIFT_CORONA_DESC");
        API.PushScaleformMovieFunctionParameterBool(true);
        API.PopScaleformMovieFunction();
        API.N_0xb9449845f73f5e9c("SET_HEADER_TITLE");
        API.PushScaleformMovieFunctionParameterString(title);
        API.PushScaleformMovieFunctionParameterBool(true);
        API.PushScaleformMovieFunctionParameterString(subtitle);
        API.PushScaleformMovieFunctionParameterBool(true);
        API.PopScaleformMovieFunctionVoid();
    }

    public static void SetTabText(Configuration configuration)
    {
        API.AddTextEntry("PM_SCR_MAP", configuration.Map);
        API.AddTextEntry("PM_SCR_STA", configuration.Status);
        API.AddTextEntry("PM_SCR_GAM", configuration.Game);
        API.AddTextEntry("PM_SCR_INF", configuration.Info);
        API.AddTextEntry("PM_SCR_SET", configuration.Settings);
        API.AddTextEntry("PM_SCR_RPL", configuration.RockstarEditor);
    }
}