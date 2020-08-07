Swords & Shovels Basic Combat and Game Loop
pluralsight.com

Example Level:

- Open Scenes/Main

This scene contains a small demo level, hero character, and a few patrolling NPCs.
Click to move and attack NPCs. Right click for stomp AEO attack. The Hero's health regenerates at 5hp/second.
The NPC Controller component on each NPC defines a list of waypoints used to determine partol area.

To Use:

- Any scene can be tested in the editor by simply running it. If the game loop is desired, run the Scenes/Boot scene to load a level. This starts with a simple splash screen. If the hero character dies, the level will reload.

Creating and Loading Custom Levels:

To use the character and NPCs in a custom level:

- Ensure ground surfaces have colliders on the "Clickable" layer 
- Bake a navmesh
- Place Common/Prefabs/Main Character on the navmesh
- Place at least one Common/Prefabs/NPC on the navmesh
- Optionally add Common/Prefabs/Main Camera (this camera will automatically follow the player)
- Set the camera view as needed
- Run

To load a custom level using the game manager:

- Add your level to the Build Settings (ex. "Level 1")
- Open Scenes/Boot
- Select the GameManager object in the hierarchy and enter the new scene name (ex. "Level 1") in the Scene To Load field on the Scene Load Utility component.
- Run