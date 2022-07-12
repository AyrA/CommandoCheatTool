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

### commando.dat contents

This is an INI file with 5 sections: Status, Check, Weapons, Items, Levels

After a game over, the ini file will only contain 3 of the 5 sections with minimal contents:

```INI
[Status]
Health=6
Lives=3
[Check]
Check=666
[levels]
desert=1
ice=1
```

Note: Despite this file, starting a new game always starts with 20 lives.

#### [Status]

Contains general game values.

##### Health

Number from 0-10 that specifies your health.
0 will kill you immediately when you start a level.
Numbers outside of this range are clamped to fit.
Above 6 requires the "armour" item.

##### Lives

Number from 0 to 999'999'999.
Higher numbers are clamped. Maxing out this value will make it overflow the UI.
Zero will trigger a game over.

##### Level

The current level you're at.
Levels in this game are a bit weird, because menu screens and intermissions are also coded as levels.
Levels 1-5 are various screens such as the game over screen or main menu.
Level 6 is the intro to the first level and 7 the real first level.
To convert the level number in the cheat tool to the real level number, just add 5 to it.
Setting this too high, clamps it down to the outro.

Unusual levels:

- 1: Game intro
- 2: Main menu
- 3: The "game over" screen (Caution! Will erase your savegame when used)
- 4: The "quit" option

##### score

This is your game score. Killing enemies and collecting items increases this.
At 3000 you're given an extra life and the score resets.
Going above is correctly accounted for.
Setting it to 9100 for example gives you 3 lives when you start the game
and then resets the counter to 100.

#### [Check]

This section has only one value: `Check=666`

I have no idea why this is there.
I thought it was a kind of marker or bitmask for something, but changing the value has no effect.

#### [Weapons]

This contains the weapons. To enable a weapon, add the setting with a value of 1.
The pistol (key `1`) is always available and thus not included in the INI at all.

In regards to reload: Reloading happens exclusively automatically.
Some can be interrupted and some don't.
Reload in this case means an extended period where you cannot fire a gun,
and potentially not move either.

##### GaussPistol

Key `2`

Fires a bit slower than the pistol.
Bullets also fly faster and pass through enemies,
allowing you to hit multiple enemies at once.
Damage per bullet seems to be randomized.

##### Uzi

Key `3`

Fires 4 pistol-like shots in quick succession, then needs time to reload.
The bullet count is remembered across gun and level switches,
so be sure to always use the entire magazine.

##### LaserPistol

Key `4`

Shoots 4 bullets in a single burst that travel only a short distance and tend to fall down.
Since weak enemies take 4 bullets to kill, this can kill them in one shot fired point blank at them.

No idea what's up with the name. I assume this was once supposed to be something different.

##### Rifle

Key `5`

A sniper rifle really. Bullets fly faster than the pistol and do 4 damage each.
Reloads after each shot, during which the player is stationary.
Can only be fired when stationary.

##### Shotgun

Key `6`

Shoots 6 bullets in a single burst.
They tend to spray first, then drop to the ground.
Basically a better version than the laser pistol.

Requires a reload after each shot, during which the player has to be stationary.
However, it can be fired while moving, and it's reloaded once the player becomes stationary.
This permits firing the gun, then retreating to safety for reloading.

##### minigun

Key `7`

Gun that goes **brrrrrrrrt**.
Fires very fast, bullets fly faster than pistol bullets.
Player must be stationary to fire it.
Will not fire immediately, but requires time for the barrel to spin up,
after which it fires for as long as the fire key is held down.
Stopping to shoot allows immediate player movement again.
In other words, the "reload" is before firing, not after.

The gun is held lower than other guns. So low in fact that it will occasionally hit dead enemies.

Note that the title is not wrong. This entry in the INI starts with a lowercase "m"

##### Flamer

Key `8`

A flame thrower. Close range only. The flame slightly fans out,
allowing to hit enemies that are a bit further down.

##### MachineGun

Key `9`

This is the machine gun that some of your allies carry.
Fires a bit slower than the minigu,
but has no reload and will not hinder player movement at all.

##### GaussRifle

Key `0`

Only obtainable in a single secret location.
Fires grenades fairly fast. Will not hinder player movement at all.
Grenades bounce heavily. Range is up to the screen edge when fired mid air.
Explosions are weaker than those from the rocket launcher

##### RocketLauncher

Key `-`

Slow firing, powerful weapon.
Can only fire when stationary.
Jumping in place is considered stationary on the single frame where you touch the ground.

The gun is slightly bugged.
It fires faster in the first two chapters where it's unobtainable.

##### LaserRifle

Key `=`

Unobtainable, non-working gun.

#### [Items]

This section holds grenades and secret items

##### grenade

- Value range: 0-6
- Key: `c`

Standard grenade. Triggers shortly after being thrown.
Fairly big explosion.

##### napalm

- Value range: 0-6
- Key: `x`

After a short delay, shoots a stream of fire upwards and burns all enemies passing through it,
then eventually explodes. The fire is not damaging to the player.

Possible bug: Throwing two of them makes one fire column horizontal.

##### satchel

- Value range: 0-6
- Key: `z`

Explodes when the `z` key is pressed again.
Smaller explosion than standard grenades.

Possible bug: You cannot throw this while other active grenades are currently existing.

##### armour

Enabled by assigning it a value of 1

Adds 4 extra hitpoints to the player

Bug: Medics will not heal you when you're above 5 hitpoints.
Since this item is not legitimately obtainable, it was likely never coded into the medics logic.

##### helmet

Enabled by assigning it a value of 1

Looks fancy but doesn't seems to provide anything.

##### jetpack

Enabled by assigning it a value of 1

Allows double jumping.
The exhaust can damage enemies and trigger explosive items.

#### [Levels]

This section contains unlocked levels.

Note: The game ignores this. Levels are unlocked in `levels.dat`

Possible settings are `desert=1` and `ice=1`

Warning: Trying to unlock the ice chapter but not the desert chapter will unlock neither of them.

### levels.dat contents

The levels.dat file contains only a single section with empty name and two potential settings.

A complete levels.dat looks like this:

```INI
[]
desert=1
ice=1
```

This unlocks the desert level and ice level.

Warning: Trying to unlock the ice chapter but not the desert chapter will unlock neither of them.
In other words, a valid levels.dat file contists of either:

- The very first line only
- The first two lines
- All 3 lines

## INI file handling

The game writes to the INI file every time you enter a new level
and loads from the file when you continue an existing game.

This means changing values only has an effect if you haven't yet used "Continue Game" on the menu.

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

### Falling out of the game

The game prevents you normally from doing this by placing an invisible wall at the start and end of each level.
This wall is not infinitely tall however.

The game is not prepared for you having the jetpack,
and there are a few levels where you can escape out of the level.
If you fall out of the map you will not die. Press `F2` to reset to the menu and then continue the game.
The level will start from the beginning because checkpoints are not saved in the savegame.

There's one location where you can legitimately fall out of the level
because of a hidden springboard placed close enough to the start of the level.

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
but still allow you to shoot them when jumping.
Use a gun that fires multiple pellets for maximum effect.

### Enemies below you

Since you cannot fire downwards, enemies on a lower level than you can be a pain to deal with.
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

### Screen scroll

The screen scrolls autoamtically and slowly adjusts to your walking direction
so you see more in front of you than behind you.
This can be a pain in sections where you have to repeatedly change direction.

You can force the screen to scroll by looking in the desired direction,
and just jumping repeatedly without moving.

### Placing grenades with the gauss rifle

The gauss rifle grenades are quite bouncy which makes them difficult to accurately place.
They will bounce off enemies and lose a lot of momentum, so try to hit them with the projectile.

A different way of placing them is by abusing a bug.
When you fire the gun while facing a wall on the left,
the grenades will teleport upwards to the end of the wall.
Doing the same on a wall on the right will make them drop down,
unless you fire while close to the upper edge of the wall, then they teleport upwards too.
This can be a useful mechanic to place grenades next to a sniper.

### Fire the rocket launcher higher

You can only fire the rocket launcher when stationary,
however, when you jump in-place the game considers you stationary
at the frame where your feet touch the ground.
This means you can fire the rocket launcher while holding the jump and fire key.
The rocket however fires a frame after the game accepts the key press,
at which point the jump will also occur.
This makes the rocket fire slighly higher and allows it to barely clear obstacles that are as tall as the player.
