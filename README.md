# SC4Backup

SC4Backup is a utility for SimCity 4 that automatically backs up city saves in case of corruption and provides an easy interface for restoring backups.

Features include:

* Ability to back up automatically after quitting the game and on every single save.
* Backup management, with the ability to set quotas on how many saves can be maintained.
* Platform-agnostic implementation for porting to other operating systems.

# Installation

SC4Backup is rather incomplete at the moment, and so the only way to run it would be to build from source. Windows users with Visual Studio should be able to simply clone the repository and build the solution.

Releases will be provided here and on the [STEX](http://community.simtropolis.com/files/) once a "0.9" (beta) build is ready.

# Major issues

All issues can be tracked in the bugtracker. The known *major* issues with SC4Backup are:

* **Backups and backup management have not actually been implemented yet.** Right now what you do get is a neat interface for seeing thumbnails for cities. Backups will probably be done within the next couple of days.
* **Support for other languages is not available.** SC4Backup assumes all new cities are prefixed by "City - New City," so any installations that use translated prefixes (such as "City - Nueva Ciudad") will fail to account for this and produce useless backups. Internationalization support would also be nice to have at some point.
* **Support for the Mac OS X version is not available** due to a lack of availability of a Mac build server. A significant effort has been made to make this implementation platform-agnostic so that it can run on OS X with Mono once built for it.