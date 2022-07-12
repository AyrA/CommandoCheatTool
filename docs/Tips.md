# Tips and tricks

If you have trouble beating the game here are a few tips and tricks

## Sticky keys

The shift key is used to jump, which can trigger the sticky key dialog when used repeatedly.
Press the left shift key 5 times in a row to trigger the popup, then click the blue link,
then uncheck the checkbox that shows the dialog on repeated shift key presses.

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

Some secrets are hidden in the ground,
usually in a location you would never go such as barbed wire.

Some secrets are better than others, and not all contain guns.
The machine gun secret for example is pretty useless
because the secret is halfway through level 18,
and you get the gun at the start of the next level legitimately.

On the other hand, you can find the laser pistol which can kill weak enemies in one shot in level 5.

I'm not aware of a complete list of secrets and items.
If you're good at reverse engineering, you may want to try to extract map data from the game.
It's made with an old version of multimedia fusion by clickteam as far as I know.

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
This makes the rocket fire slighly higher and allows it to barely clear obstacles that are as tall as the player.
