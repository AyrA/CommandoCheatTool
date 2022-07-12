# Game controls

*There's also a menu option for them but not all keys may be listed*

- Movement: Arrow keys
- Jump: `SHIFT`
- Fire: `CTRL`
- Select gun: `1234567890-=`
- Throw grenades: `zxc`
- Exit game: `Q` (Need to confirm with `Y`/`N` afterwards)
- Skip cutscene (some): `ESC`
- Reset game: `F2`

Note: The game ignores the users keyboard layout and will not remap keys.
This means french and german users may find using `Z` for a grenade or `-` for the rocket launcher awkward.

This game listens to keys globally, even when it doesn't has focus.

# Game issues

The game has the occasional issue, being almost 20 years of age.
But it can still be played on a modern Windows 10 machine (32 and 64 bits) with minimal issues.

The most common issues I found are shown below:

## Game window is tiny

The game runs in 320x200 resolution.
This was done to achieve the cartoonish and pixellated effect.
The problem is that modern Windows will no longer allow you to change the resolution this far down.
To fix this, press `WIN` + `NUMPAD +` on your keyboard to start the zoom utility
and zoom in until the game covers most of the screen.
Using `WIN` + `NUMPAD -` you can zoom out again when you're done gaming.

## Crash when starting new game or continuing a game

When this happens, simply restart the game.
There seems to be some race condition on modern machines that occasionally causes the game to crash
when using one of the mentioned menu options.
It also crashes when using the "Quit" option but you likely won't notice since you're exiting the game anyways.

It occasionally needs 3 to 5 tries until it works.

Note: This issue only happens when you launch the game, not when resetting with `F2`.
Instead of exiting and restarting the game completely when you change game values,
use `F2` instead.

Tip: Use the cheat tool to launch the game.
It automatically detects when the game crashes and shows a prompt to relaunch it.
This means restarting the game on error is a simple `ENTER` key press.

## Cannot progress further in levels with support characters

Support characters will stop moving when they're too far away from you.
Do not try to get far ahead of them because you usually cannot exit a level
until you completed their sequence.

## Cannot clear the elevator in level 7 (Airport)

The elevator is exactly as tall as the tallest obstacle you can clear.
Due to rounding errors, you will occasionally fail to jump over it.
Just keep trying, you will eventually make it.

## Boots don't work in level 13 (Oil Refinery)

You likely died after collecting them.
Doing so still shows them as equipped sometimes, but you have to collect them again.

## Cannot complete level 14 (Crash Site)

This level is in fact a bit weird.
Partially through the level you will get a partner that fights with you.
This person will eventually just stop moving without giving a reason as to why.
Just complete the level normally. Once you are at the very end and cannot progress further,
walk back and you will find that the support character has advanced forwards too.

## Infinite firing sound on level 19 (Mecha Assembly Facility)

This seems to be a bug caused by faster machines.
I don't have a solution for this except to turn off the sound temporarily.
The only notable things you get in this level are the machine gun and rocket launcher.
If the sound is unbearable, just skip the level using the cheat tool
and give you the guns manually.
You will miss out on the last part of the level though,
which features a near endless stream of support characters fighting alongside you.

## Cannot use grenades in level 20 (Rocket Launch Facility)

Known issue. It happens sometimes and only in some locations.

## Cannot use explosives to kill enemies in mecha suits

This seems to be coded into the game this way.
They only become vulnerable to explosive damage in level 18 for some reason.

## Rocket launcher fires very slow

No it doesn't. You cheated yoursef one and found that it fires fast in the first two chapters.
The firing rate in the last chapter is what it was intended with.

I assume the default fire rate is lowered only in the last chapter
because it's the only one where you can legitimately obtain the rocket launcher.

## Medic will not heal the player

Medics only heal you when you fall below 6 hitpoints.
Since 6 is maximum under normal circumstances you usually don't notice this,
but playing with health boosted to 10 creates this issue.
A medic will still heal you up to 10 once you fall below 6 though.

## Cannot use remote controlled grenades

Remote controlled grenades are thrown and triggered using the `Z` key.
This key is notorious for being in different locations on the keyboard
depending on the keyboard layout. Make sure you're actually using the correct key.
Also, you cannot use this grenade while another one is already out.
You must wait until other active grenades have exploded.
To throw multiple grenates, always throw the remote controlled first.

If you ever make a game, either do not use `Z` or silently adapt the settings for different layouts.

## Falling out of the game

The game prevents you normally from doing this by placing an invisible wall at the start and end of each level.
This wall is not infinitely tall however.

The game is not prepared for you having the jetpack,
and there are a few levels where you can escape out of the level.
If you fall out of the map you will not die. Press `F2` to reset to the menu and then continue the game.
The level will start from the beginning because checkpoints are not saved in the savegame.

There's one location where you can legitimately fall out of the level
because of a hidden springboard placed close enough to the start of the level.

## Cannot walk to the right or not at all anymore

If you can only walk to the left you've found another obscure bug.
You can either try to complete the level anyways (you can still jump),
or press `F2` to reset.
The bug can rarely trigger while being in the game itself,
but seems to be more likely to appear when you start interacting with other applications.

## Gun X unobtainable

Not all guns are available in all chapters.
Additionally, the gauss rifle is only available in a secret location.
Check the level help for a list of all secrets I know of.

The gauss rifle is hidden in a secret in the oil refinery.

## Helmet disappears after death

This is purely cosmetic (just like the helmet itslef).
It appears again in the next level.
