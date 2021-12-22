# Crisalix Test - Unity Developer

## Decisions taken

### General Philosophy
* Make the app as most understanding, traceable and flexible as possible.
* For this reason, I have tried to make as few properties visible as possible on the GameObjects.
* I have created a MainManager that initialized the rest of the Manager and scripts.
* Managers are saved as prefab.


### Data management:
 * I have chosen to define the data in scriptable objects because it allows maintaining a clear structure for every object.
 * There are scriptable objects to store the data, and classes with this data inside the game. because in the case of changing the input, the logic for the rest of the software won't change. We only should change the DataManager initialization.
 
 ### UI
 *
 
 ### Communication between modules
 *

## Contact

David Elfau - [LinkedIn profile](https://www.linkedin.com/in/delfau/)

Project Link: [https://github.com/david-elfau/anti-stress-balls](https://github.com/david-elfau/anti-stress-balls)

<p align="right">(<a href="#top">back to top</a>)</p>
