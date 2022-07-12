# Tips and tricks

If you have trouble beating the game here are a few tips and tricks

## Sticky keys

The shift key is used to jump, which can trigger the sticky key dialog when used repeatedly.
Press the left shift key 5 times in a row to trigger the popup, then click the blue link,
then uncheck the checkbox that shows the dialog on repeated shift key presses.

## Friendly fire

This game has no friendly fire.

## Enemy health

There's two basic enemy types: the weak enemy and the strong enemy.
The weak enemy is present in chapters 1 and 2. It has 4 health.
The strong enemy has 8 health.
It can be found in the last level of chapters 1 and 2 as well as throughout the entire chapter 3.

The Laser Pistol and Shotgun are able to one-shot weak enemies.
The laser pistol requires all bullets to hit though as it fires exactly four.

## Enemy behavior

Below is an incomplete list of enemies and their strategies.

### Walking enemies

They will walk on their assigned route until they spot you or get hit.
At this point they will stop and randomly fire a few times before resuming their routines.
The fire pattern depends on the gun they have.

### Sniper

They never move and always try to shoot directly at you in a constant interval.
They can shoot in any direction. Their shots do 2 (weak enemy) or 4 (strong enemy) damage.

### Suicide bomber

When they spot you they will start randomly running back and forth,
but are more likely to run towards you than away from you.
They explode when touched. Eventually they go back to their idle state.
This enemy is exclusively found in chapter 2.

### Car

Enemies on cars (exclusively found in chapter 2) will randomly drive back and forth,
and try to shoot you with the machine gun mounted on top.

### Mecha suits

These enemies will behave like the walking enemies, except there's no random element.
They fire once, then resume their routine unless you're still in their line of sight.

Both mecha suits possess a rocket launcher,
but the minigun mecha is more likely to use it.

## Patience

Having patience helps a lot. Enemies will try to shoot you,
but they also lose interest eventually and go back to their routine.

There's no time limit on any level.

## Bullet travel time

Try to shoot enemies when they're as far away as possible.
Bullets take time to travel, this gives you more time to shoot.

## Keep guns reloaded

Especially applies to the Uzi as this will likely be your best weapon for a long time.
Always hold the fire key down until the magazine is completely spent.
You avoid a situation where you want to shoot an ememy but can't get 4 shots off at once.

## Snipers

Snipers are often on ledges, which hinders their ability to shoot downwards.
Getting below them at a 45° angle should prevent you from getting hit,
but still allow you to shoot them when jumping.
Use a gun that fires multiple pellets for maximum effect.

## Enemies below you

Since you cannot fire downwards, enemies on a lower level than you can be a pain to deal with.
Either use one of your grenades or use a gun that has bullets sink down (laser pistol, shotgun, gauss rifle).

## Screen edge

Projectiles will not form outside of the screen edge.
You can use this against tough enemies to quickly shoot at them and then retreat.

You can also abuse this.
By keeping stationary enemies (such as the sniper) at the very edge
you can fire at them without them being able to fire at you

## Secrets

The game has a few secret areas and some guns are only obtainable via them.
The game uses the "walk through wall" type of secret.
To find them, just keep watching your bullets as they fly.
When a bullet hits a wall it disappears with yellow sparks,
but it will fly through the fake walls unobstructed.

A few secrets are hidden in the ground,
usually in a location you would never go such as barbed wire.

Some secrets are better than others, and not all contain guns.
The machine gun secret for example is pretty useless
because the secret is halfway through level 18,
and you get the gun at the start of the next level legitimately.

On the other hand, you can find the laser pistol which can kill weak enemies in one shot in level 5.

I'm not aware of a complete list of secrets and items.
If you're good at reverse engineering, you may want to try to extract map data from the game.
It's made with an old version of multimedia fusion by clickteam as far as I know.

The levels documentation features all secrets that I know of.

## Non-working gun

There's a non-working gun in game called the "laser rifle".
Because it doesn't works, it's not included in the cheat utility.

If you want to give yourselelf this gun,
edit the ini at `%LOCALAPPDATA%\VirtualStore\Windows\Commando.dat`
and add `LaserRifle=1` to the `[Weapons]` section.
It will appear in the gun list at the top of the screen but won't be selectable.

## Unobtainable items

The armour, helmet and jetpack are not legitimately obtainable as far as I know.

## Screen scroll

The screen scrolls autoamtically and slowly adjusts to your walking direction
so you see more in front of you than behind you.
This can be a pain in sections where you have to repeatedly change direction.

You can force the screen to scroll by looking in the desired direction,
and just jumping repeatedly without moving.

## Placing grenades with the gauss rifle

The gauss rifle grenades are quite bouncy which makes them difficult to accurately place.
They will bounce off enemies and lose a lot of momentum, so try to hit them with the projectile.

A different way of placing them is by abusing a bug.
When you fire the gun while facing a wall on the left,
the grenades will teleport upwards to the end of the wall.
Doing the same on a wall on the right will make them drop down,
unless you fire while close to the upper edge of the wall, then they teleport upwards too.
This can be a useful mechanic to place grenades next to a sniper.

## Fire the rocket launcher higher

You can only fire the rocket launcher when stationary,
however, when you jump in-place the game considers you stationary
at the frame where your feet touch the ground.
This means you can fire the rocket launcher while holding the jump and fire key.
The rocket however fires a frame after the game accepts the key press,
at which point the jump will also occur.
This makes the rocket fire slighly higher
and allows it to barely clear obstacles that are as tall as the player.

# Trivia

Some useless knowledge about the game.
This reveals the plot, so if you're into plots of badly designed dumb video games,
do not read before having played the game.

## Savegames

The game only has one savegame.
Starting a new game immediately overwrites the previous one.
If you want multiple savegames you must copy the INI file manually.

## Death

When you die you have to start from the previouscheckpoint.
The game will however not respawn any enemies,
even those killed after the last checkpoint.

Collected guns are also retained.

## Cutscenes

The game is best played from start to finish completely in one session.
Using the menu options to instead start in chapter 2 or 3 skips their first cutscene.
You also start with the pistol only, losing any weapons you collected in earlier chapters.
Having the gauss rifle available in the last chapter will make your life a lot easier.

## Story

The story of the game is fairly simply and nothing special.
Knowing the story is optional,
so mashing the ESC key will not make you miss out on much.

### Chapter 1

At 4 AM terrorists steal nuclear warheads from a convoy in south Texas.
You're responsible for retrieving them again.
Some cuban terrorists claim responsibility
so you're dropped into the Amazon rainforrest in the first chapter.
In the last level they escape (what surprise) but crash over a war zone.

### Chapter 2

The military locates the crashsite in Afganistan, so you're sent there next.
The people you're fighting there are not associated with this entire business going on,
and are merely "in the way".
Towards the end you get to engage against the real people behind this.
In the last level, it's relevaled that there's a traitor among you,
who escapes again.

### Chapter 3

They track him to Alaska so you're sent there next.
Complete the game and your character is promised a medal.

## Names

Your character is named Phil, your enemy is Simon.

## Level names

The level names I just made up.
The chapters are named in the menu as "Jungle Escapades", "Desert Capers", "Ice Schennanigans".

In the cutscenes we get to know that:

- The jungle is the Amazon rainforrest
- The desert is Afganistan
- The ice levels are Alaska

## Secret images

There are 3 secrets with a custom background.

- The first one seems to be the "Goatse" image but mostly obscured
- The second is some cartoon figure
- The third one is the top half of a naked man

See also: https://en.wikipedia.org/wiki/Goatse.cx
