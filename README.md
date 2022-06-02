# PauseMenuText
Allows you to change the pause menu text through a JSON configuration file easily

## Editing

Edit it, open `PauseMenuText.sln` in Visual Studio or Rider (if you're fancy 😎)

## Compilation

To build it, run `build.cmd`. The `dist` folder can be copied to your server resources.

## Installation

Grab the latest version from the releases page.

Afterwards, you can use `ensure PauseMenuText` in your server.cfg or server console to start the resource. You should make sure that this is after the `ensure chat` and such is ran.

Finally, you'll want to modify the `config.json` file in the folder to what models and names you want to map to.

The structure is as follows:

```json
{
  "title": "Title",
  "subtitle": "Subtitle",
  "map": "Map name",
  "status": "Status",
  "game": "Game",
  "info", "Info",
  "settings": "Settings",
  "rockstar_editor": "Rockstar Editor"
}
```
