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
They only become vulnerable to explosive damage in level 17 for some reason.

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

## Tips and tricks

If you have trouble beating the game here are a few tips and tricks

### Sticky keys

The shift key is used to jump, which can trigger the sticky key dialog when used repeatedly.
Press the left shift key 5 times in a row to trigger the popup, then click the blue link,
then uncheck the checkbox that shows the dialog on repeated shift key presses.

### Patience

Having patience helps a lot. Enemies will try to shoot you,
but they also lose interest eventually and go back to their routine.

There's no time limit on any level.

### Bullet travel time

Try to shoot enemies when they're as far away as possible.
Bullets take time to travel, this gives you more time to shoot.

### Keep guns reloaded

Especially applies to the Uzi as this will likely be your best weapon for a long time.
Always hold the fire key down until the magazine is completely spent.
You avoid a situation where you want to shoot an ememy but can't get 4 shots off at once.

### Snipers

Snipers are often on ledges, which hinders their ability to shoot downwards.
Getting below them at a 45° angle should prevent you from getting hit,
but still allow you to shoot them. Use a gun that fires multiple pellets for maximum effect

### Enemies below you

Since you cannot fire downwards, enemies on a lower level than you can be an exreme pain.
Either use one of your grenades or use a gun that has bullets sink down (laser pistol, shotgun, gauss rifle).

### Screen edge

Projectiles will not form outside of the screen edge.
You can use this against tough enemies to quickly shoot at them and then retreat.

You can also abuse this.
By keeping stationary enemies (such as the sniper) at the very edge
you can fire at them without them being able to fire at you

### Secrets

The game has a few secret areas and some guns are only obtainable via them.
The game uses the "walk through wall" type of secret.
To find them, just keep watching your bullets as they fly.
When a bullet hits a wall it disappears with yellow sparks,
but it will fly through the fake walls unobstructed.

Some secrets are hidden in the ground,
usually in a location you would never go such as barbed wire.

Some secrets are better than others, and not all contain guns.
The machine gun secret for example is pretty useless
because the secret is halfway through level 17,
and you get the gun at the start of the next level legitimately.

On the other hand, you can find the laser pistol which can kill weak enemies in one shot in level 4.

I'm not aware of a complete list of secrets and items.
If you're good at reverse engineering, you may want to try to extract map data from the game.
It's made with an old version of multimedia fusion by clickteam as far as I know.

### Non-working gun

There's a non-working gun in game called the "laser rifle".
Because it doesn't works, it's not included in the cheat utility.

If you want to give yourselelf this gun,
edit the ini at `%LOCALAPPDATA%\VirtualStore\Windows\Commando.dat`
and add `LaserRifle=1` to the `[Weapons]` section.
It will appear in the gun list at the top of the screen but won't be selectable.

### Unobtainable items

The armour, helmet and jetpack are not legitimately obtainable as far as I know.
