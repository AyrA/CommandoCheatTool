# Commando Cheat Tool

This is a tool for a mostly unknown game from the Windows XP era, called commando.
Made by a now defunct group called "Fallen Angel Industries"

[Review and Download](http://www.reloaded.org/download/Commando/266/)

It's a fairly difficult 2D platformer and shooter.
The game has the occasional issues, see below for potential problems and solutions.

## Usage

Simply double click the tool and set the values as desired.
Click the links for more information.
Each gun has a tool tip text that shows more information about it.

If you place the cheat tool inside of the game directory,
you can directly launch the game from the tool itself.

## INI file

This cheat tool edits the ini file of commando.
It's not a live cheating tool (aka. "Trainer") and more resembles a savegame editor.

The ini files were originally placed in the Windows directory.
Because Windows no longer allows you to do this without running as administrator,
Microsoft added a compatibility feature that redirects these requests into a local directory of your user profile.
The directory in question is `%LOCALAPPDATA%\VirtualStore\Windows`.
In this directory you will find `commando.dat` and `levels.dat` which are INI files.

If you want to make the game portable,
all you have to do is copy the files to the given location before starting it
and copying them back after exiting the game.

## INI file handling

The game writes to the INI file every time you enter a new level
and loads from the file when you continue an existing game.

This means changing values only has an effect if you haven't yet used "Continue Game" on the menu.

You don't have to exit a running game if you want to make changes to the file multiple times,
simply press `F2` in the game to reset it to the menu screen.

## More documentation

Check the `docs` folder for more documentation on the INI file format and the game itself.

