[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Write your Devlog here!
Michael Lopez, he / him

The plan that I previously created which described the general format for how the game would be made is pretty accurate, although I did miss some details. When considering the objects of the game, I previosuly thought that only the cat and seeds would be GameObjects, but I forgot that the UI of the game are also GameObjects. The game has two important UI objects which display how many seeds have already been planted by the user and how many seeds the user has remaining. Both of these UI objects are used by the Plant Count UI script, which is also another object inside the game. Also, while the seeds are GameObjects, now that I created the game I can be more specific and say that you have to create a Prefab for the seed and then write code, using the built-in Instantiate method and passing in correct arguments, to spawn new seed objects at the user's current location. The cat GameObject that the user controls has a script object attached to it called Player, which handles the main logic of the game, such as movement and seed planting. As for attributes, I was right when I said that the cat would have an attribute that tracked the seed limit of the user. As for actions, I was right when I said that the cat's actions include movement and planting seeds. To get into more detail, the cat would move when the user presses WASD or arrow keys and when the user presses the Space key this would call the method PlantSeed which handles instantiating a new seed at the cat's current location and then PlantSeed calls another method, the UpdateSeeds method, which is located inside the Plant Count UI script object, which handles updating the UI to display the correct seed information.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
