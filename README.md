# Shooter Microgame
## Game Mechanics
This game is an experimental shooter that expands on the original Rollball example. The game is played in third person perspective and allows players to shoot bullets in one direction towards obstacles around the map. The goal of the game is to make all of these obstacles disappear, as well as reduce their collective health values to 0. This is the only winning condition, and there is no loss condition.

## Unique Features
This game contains a shooting mechanic that was not covered in the original Rollball example or any other game demos in class. This shooting mechanic is triggered by left mouse button clicks, and for every click a new bullet is spawned. Upon hitting a wall, the bullet is destroyed immediately. Otherwise, the bullet remains for 5 seconds in the game map before being destroyed. If the bullet collides with an obstacle, this decreases the obstacle's individual health value (hidden from the player) as well as the collective health bar on the top of the screen. This collective health bar contains the total health value of all obstacles that exist on the map. Upon reaching 0 health, an obstacle will disappear from the map. 

## Resources Used
Some resources I have used in addition to the Unity official documentation as well as the in-class demos are:
https://learn.unity.com/tutorial/using-c-to-launch-projectiles#5fd7a2b2edbc2a0021c6985a
https://www.youtube.com/watch?v=ZzkIn41DFFo

The first link points to a tutorial which uses the old Input System to simulate launching projectiles. The second link points to a tutorial for health bar creation. 
