# Fahrenheit

Fahrenheit/OpenFFX is a set of libraries, tools and general documentation with the goal of discovering as much as possible about Final Fantasy X and X-2's internals.

# Build prerequisites

Fahrenheit is built with .NET 6 and uses Roslyn source generation. It is tested in Visual Studio 2022's latest generally available version; it should work in Visual Studio Code as well with the .NET 6 SDK installed.

# Runtime prerequisites

Fahrenheit only and exclusively supports [the Steam version of Final Fantasy X/X-2 HD Remaster](https://store.steampowered.com/app/359870/).

Fahrenheit assumes usage of [ffgriever's External File Loader for Final Fantasy X/X-2 HD Remaster](https://gitlab.com/ffgriever/ffx-x-2-hd-external-file-loader).

Setup of the External File Loader is explained in [this post in the Moogles and Mods Discord server](https://discord.com/channels/371784427162042368/574658827572740106/984592365635387442). A utility script to perform this automatically will be provided later.

The External File Loader can coexist with Untitled Project X. For instructions, consult [this post by faospark in the Moogles and Mods Discord server](https://discord.com/channels/371784427162042368/555521597339861013/980001416401793044).

# Planned projects

These are not listed in any particular order.

[ ] Fahrenheit.DEdit (a text editor for the game with full macro substitution support)

[ ] Fahrenheit.UIEdit (allows movement and recoloring- even resizing- of the in-game interface)

[ ] Fahrenheit.VMEdit (event script editing and X/X-2 VM instruction disassembly)

[ ] Continual work on mapping all the game's symbols to allow for decompilation, not just disassembly, of event scripts.

# When is [project I'm interested in] releasing?

I work on Fahrenheit in my spare time and work and study full-time. It will release when it's ready. Please do not ask about release dates of tools.

# I noticed a bug or have something to add.

Submit an issue or pull request, respectively.

# Where can I discuss Fahrenheit or ask questions?

Currently, in the [Moogles and Mods Discord server](https://discord.gg/XdK5cVqPDQ) in #ff10-mod-dev or #ff10-discussion. Please be advised that while X-2 support _is_ intended to be a part of Fahrenheit, it's not being worked on actively.
