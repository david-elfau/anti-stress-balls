# Crisalix Test - Unity Developer

## Decisions taken

### General Philosophy
 * Make the app as most understanding, traceable and flexible as possible.
 * For this reason, I have tried to make as few properties visible as possible on the GameObjects.
 * I have created a MainManager that initialized the rest of the Manager and scripts.
 * Managers are saved as prefab.
 * I have avoided using the “update”, ”awake” unity functions to have control over the life cycle.


### Data management:
* I have chosen to define the data in scriptable objects because it allows maintaining a clear structure for every object.
* There are scriptable objects to store the data, and classes with this data inside the game. Because in the case of changing the input, the logic for the rest of the software won't change. We only should change the DataManager initialization.

 
### Event Bus
* I have created an Event Bus to allow the modules to listen and trigger generic events.
* Events are triggered  with an event name and a parameter object.
* Name is gotten from an enumeration of events name to avoid typo errors.
* Parameter objects are managed by the class "ParameterBusObject" to create methods to handle different objects easily.

 ### Interaction
 * Selectors are separated into their own class (type, color, size).
 * Buttons trigger events when they are tapped.
 * Events are listened to by the UI manager. This indicates the subpanels to update depending on the input.
 
 ### Black ball implementation
 * To allow a specific behavior on the black ball I have created an abstract color (IBallColor).
 * All colors are subclasses of the abstract color.
 * Black color is a specific type of color with a method to fix a size (BallColorOverridesSize).
 * The rest of the colors have a basic behavior (BallColor).
 * Method “DoOverrideDefaultSize” indicates to the size panel if this color has a different behaviour.
 * This structure is repeated on the ScriptableObjects.

 ### Shaders on UI
 * I have used Universal Render Pipeline and Shader Graph
 * I have created an overlay to the buttons to show when they are selected.
 * Buttons selected and non selected use the same shader, but different material. Material changes the parameters of the shader.
 * I have applied the type and color selector. They share materials and shaders.


## Contact

David Elfau - [LinkedIn profile](https://www.linkedin.com/in/delfau/)

Project Link: [https://github.com/david-elfau/anti-stress-balls](https://github.com/david-elfau/anti-stress-balls)

<p align="right">(<a href="#top">back to top</a>)</p>
