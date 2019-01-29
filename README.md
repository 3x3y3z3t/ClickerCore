# ClickerCore v1.3

This is a template aims for simplify the creation of clicker tools.
With some basic setups you can have a functional clicker, while still leave room for customization.

## Usage
1. Create your own class that derive from `Exw.ClickerCore.Clicker` class. This will be the clicker.
2. Override the following method:
    * `void Init()` (required)
    * `void OnIdle()`
    * `void OnRunning()`
    * `bool ShouldClick()`
3. Now your clicker is ready to run. Call `Start()` to start clicking, `Pause()` to temporarily stop clicking, and call `Stop()` when you are about to close the clicker.

*Optional:* You can create your own monitor (some kind of user-interface) and query information from the clicker. This is up to you to implement the monitor.

## Example
You can take a look at the [Stealer Clicker](https://github.com/3x3y3z3t/Stealer) as an example of usage.
