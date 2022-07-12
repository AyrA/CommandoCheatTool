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

## INI file handling

The game writes to the INI file every time you enter a new level
and loads from the file when you continue an existing game.

This means changing values only has an effect if you haven't yet used "continue game" on the menu.

You don't have to exit a running game if you want to make changes to the file multiple times,
simply press `F2` in the game to reset it to the menu screen.

## Game issues

The game has the occasional issue, being almost 20 years of age.
The most common issues I found are shown below:

### Game window is tiny

The game runs in 320x200 resolution.
This was done to achieve the cartoonish and pixellated effect.
The problem is that modern Windows will no longer allow you to change the resolution this far down.
To fix this, press `WIN` + `NUMPAD +` on your keyboard to start the zoom utility
and zoom in until the game covers most of the screen.
Using `WIN` + `NUMPAD -` you can zoom out again when you're done gaming.

### Crash when starting new game or continuing a game

When this happens, simply restart the game.
There seems to be some race condition on modern machines that occasionally causes the game to crash
when using one of the mentioned menu options.
I occasionally need 3 to 5 tries until it works.

Note: This issue only happens when you launch the game, not when resetting with `F2`.
Instead of exiting and restarting the game completely when you change game values,
use `F2` instead.

### Cannot clear the elevator in level 6 (Airport)

The elevator is exactly as tall as the tallest obstacle you can clear.
Due to rounding errors, you will occasionally fail to jump over it.
Just keep trying, you will eventually make it.

### Infinite firing sound on level 18 (Mecha Assembly Facility)

This seems to be a bug caused by faster machines.
I don't have a solution for this.
The only notable thing you get in this level is the machine gun and rocket launcher.
If the sound is unbearable, just skip the level using the cheat tool
and give you the guns manually.
You will miss out on the last part of the level
which features a near endless stream of support characters fighting alongside you.

### Cannot use explosives to kill enemies in mecha suits

This seems to be coded into the game this way.
They only become vulnerable to explosive damage in level 18.

### Rocket launcher fires very slow

No it doesn't. It fires unnaturally fast in the first two chapters for some reason.
The firing rate in the last chapter is what it was intended with.

I assume the default fire rate is lowered only in the last chapter
because it's the only one where you can legitimately obtain the rocket launcher.

### Medic will not heal the player

Medics only heal you when you fall below 6 hitpoints.

### Cannot use remote controlled grenades

Remote controlled grenades are thrown and triggered using the `Z` key.
This key is notorious for being in different locations on the keyboard
depending on the keyboard layout. Make sure you're actually using the correct key.
Also, you cannot use this grenade while another one is already out.
You must wait until other active grenades have exploded.

If you ever make a game, either do not use `Z` or silently adapt the settings for different layouts.