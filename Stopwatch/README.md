# Stopwatch Project
## Code Structure
The project consists of the following main components:

### `Program`
The entry point of the application. It initializes the `UI` and `Stopwatch` classes, subscribes to events, and handles user input to control the stopwatch.

### `UI`
Handles the user interface and displays commands, messages, and the current stopwatch time. Key methods include:
- `Command()`: Displays available commands to the user.
- `StartClock()`, `StopClock()`, `ResetClock()`: Updates the console UI based on the current state of the stopwatch.
- `DisplayClock()`: Formats and displays the elapsed time in HH:MM:SS format.

### `Stopwatch`
Implements the core stopwatch functionality. It tracks elapsed time, manages the running state, and raises events for start, stop, and reset actions. Key methods include:
- `Start()`: Starts the stopwatch and raises the `OnStarted` event.
- `Stop()`: Stops the stopwatch and raises the `OnStopped` event.
- `Reset()`: Resets the stopwatch and raises the `OnReset` event.
- `Tick()`: Increments the elapsed time.

### `TimeService`
Provides utility methods for time calculations, such as converting elapsed seconds into hours, minutes, and seconds.
