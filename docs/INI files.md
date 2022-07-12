# commando.dat contents

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

## [Status]

Contains general game values.

### Health

Number from 0-10 that specifies your health.
0 will kill you immediately when you start a level.
Numbers outside of this range are clamped to fit.
Above 6 requires the "armour" item.

### Lives

Number from 0 to 999'999'999.
Higher numbers are clamped. Maxing out this value will make it overflow the UI.
Zero will trigger a game over.

### Level

The current level you're at.
Levels in this game are a bit weird, because menu screens and intermissions are also coded as levels.
Levels 1-4 are various screens such as the game over screen or main menu.
Level 5 is the first intro to the first chapter and 7 the real first level (6 is the parachute drop sequence).
To convert the level number in the cheat tool to the real level number, just add 4 to it.
Setting this too high clamps it down to the last outro.

Unusual levels:

- 1: Game intro
- 2: Main menu
- 3: The "game over" screen (Caution! Will erase your savegame when used)
- 4: The "quit" option

### score

This is your game score. Killing enemies and collecting items increases this.
At 3000 you're given an extra life and the score resets.
Going above is correctly accounted for.
Setting it to 9100 for example gives you 3 lives when you start the game
and then resets the counter to 100.

## [Check]

This section has only one value: `Check=666`

I have no idea why this is there.
I thought it was a kind of marker or bitmask for something, but changing the value has no effect.

## [Weapons]

This contains the weapons. To enable a weapon, add the setting with a value of 1.
The pistol (key `1`) is always available and thus not included in the INI at all.

In regards to reload: Reloading happens exclusively automatically.
Some can be interrupted and some don't.
Reload in this case means an extended period where you cannot fire a gun,
and potentially not move either.

### GaussPistol

Key `2`

Fires a bit slower than the pistol.
Bullets also fly faster and pass through enemies,
allowing you to hit multiple enemies at once.
Damage per bullet seems to be randomized.

### Uzi

Key `3`

Fires 4 pistol-like shots in quick succession, then needs time to reload.
The bullet count is remembered across gun and level switches,
so be sure to always use the entire magazine.

### LaserPistol

Key `4`

Shoots 4 bullets in a single burst that travel only a short distance and tend to fall down.
Since weak enemies take 4 bullets to kill, this can kill them in one shot fired point blank at them.

No idea what's up with the name. I assume this was once supposed to be something different.

### Rifle

Key `5`

A sniper rifle really. Bullets fly faster than the pistol and do 4 damage each.
Reloads after each shot, during which the player is stationary.
Can only be fired when stationary.

### Shotgun

Key `6`

Shoots 6 bullets in a single burst.
They tend to spray first, then drop to the ground.
Basically a better version than the laser pistol.

Requires a reload after each shot, during which the player has to be stationary.
However, it can be fired while moving, and it's reloaded once the player becomes stationary.
This permits firing the gun, then retreating to safety for reloading.

### minigun

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

### Flamer

Key `8`

A flame thrower. Close range only. The flame slightly fans out,
allowing to hit enemies that are a bit further down.

### MachineGun

Key `9`

This is the machine gun that some of your allies carry.
Fires a bit slower than the minigu,
but has no reload and will not hinder player movement at all.

### GaussRifle

Key `0`

Only obtainable in a single secret location.
Fires grenades fairly fast. Will not hinder player movement at all.
Grenades bounce heavily. Range is up to the screen edge when fired mid air.
Explosions are weaker than those from the rocket launcher

### RocketLauncher

Key `-`

Slow firing, powerful weapon.
Can only fire when stationary.
Jumping in place is considered stationary on the single frame where you touch the ground.

The gun is slightly bugged.
It fires faster in the first two chapters where it's unobtainable.

### LaserRifle

Key `=`

Unobtainable, non-working gun.

## [Items]

This section holds grenades and secret items

### grenade

- Value range: 0-6
- Key: `c`

Standard grenade. Triggers shortly after being thrown.
Fairly big explosion.

### napalm

- Value range: 0-6
- Key: `x`

After a short delay, shoots a stream of fire upwards and burns all enemies passing through it,
then eventually explodes. The fire is not damaging to the player.

Possible bug: Throwing two of them makes one fire column horizontal.

### satchel

- Value range: 0-6
- Key: `z`

Explodes when the `z` key is pressed again.
Smaller explosion than standard grenades.

Possible bug: You cannot throw this while other active grenades are currently existing.

### armour

Enabled by assigning it a value of 1

Adds 4 extra hitpoints to the player

Bug: Medics will not heal you when you're above 5 hitpoints.
Since this item is not legitimately obtainable, it was likely never coded into the medics logic.

### helmet

Enabled by assigning it a value of 1

Looks fancy but doesn't seems to provide anything.

### jetpack

Enabled by assigning it a value of 1

Allows double jumping.
The exhaust can damage enemies and trigger explosive items.

## [Levels]

This section contains unlocked levels.

Note: The game ignores this. Levels are unlocked in `levels.dat`

Possible settings are `desert=1` and `ice=1`

Warning: Trying to unlock the ice chapter but not the desert chapter will unlock neither of them.

# levels.dat contents

The levels.dat file contains only a single section with empty name and two potential settings.

A complete levels.dat looks like this:

```INI
[]
desert=1
ice=1
```

This unlocks the desert chapter and ice chapter.

Warning: Trying to unlock the ice chapter but not the desert chapter will unlock neither of them.
In other words, a valid levels.dat file contists of either:

- The very first line only
- The first two lines
- All 3 lines