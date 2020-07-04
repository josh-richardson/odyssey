Odyssey
======================

Odyssey is an application designed to force you to focus on writing. It is a simple RichText editor which allows you to configure a time or a word-count goal, and allows you to lock yourself out of any other application until the goal is complete.

<p align="center">
  <img src="https://i.imgur.com/8XEZhXx.png" alt="Odyssey configuration window" />
</p>



### Features:

- [x] Time-based goal mode
- [x] Word-based goal mode
  - [x] Disable clipboard
  - [x] Gibberish detection
- [x] Locked down mode (other apps can't be used until the goal is reached)
- [x] Rich text editing
- [x] Incrementally save drafts every 5 minutes
- [x] Dark mode
- [ ] Cloud-based draft saving

### Download:

##### Windows:
The current release is an early alpha and may be buggy. No installation is required. You can download it from the releases page [here](https://github.com/josh-richardson/odyssey/releases). 

##### Linux & macOS:
As Odyssey is written in C# and uses WinForms, it is not natively compatible with Linux or macOS. However, Wine compatibility for this binary is good. To use Odyssey on macOS/Linux, invoke `wine Odyssey.exe` and install the Mono libraries necessary to run it. The locked-down mode may not work correctly on all desktop environments & shells, however all other functionality is there.

### Usage:
Firstly select a goal type (how long you want to write for, or how many words you want to write), then configure the various options. Note that if you enable the 'Prevent exiting' checkbox, Odyssey won't allow you to use any other programs on your PC until your chosen goal has been reached.


### Screenshots:
![Odyssey main editing window](https://i.imgur.com/y5EObMs.png "Editor window")
![Odyssey main editing window](https://i.imgur.com/i6Ddtdp.png "Dark mode")
