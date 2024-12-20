# Space Invaders Game - Enhanced Version

This is a customized version of the classic Space Invaders game, featuring unique graphics, audio, UI, and gameplay mechanics. Below are the highlights of the added features:

## Features

### Graphics
- 🎨 **Custom Background Image**: A new immersive backdrop for the game.  
- 🚀 **Tank/Player Image**: Redesigned tank/player sprite.  
- 👾 **Unique Invader Designs**: Fresh and creative enemy visuals.

### Audio
- 🎵 **Background Music**: Updated with a new and engaging soundtrack.  
- 🔫 **Firing Sound Effects**: Custom sounds for shooting.  
- 💥 **Invader Destruction SFX**: Satisfying sound effects for alien defeats.

### User Interface (UI)
- 🖥️ **Starting Screen**: Includes a play button for a seamless start.  
- 📊 **Dynamic Score Display**: Real-time score tracking during gameplay.  
- 🔄 **Restart Button**: Quick and easy game reset functionality.

### Gameplay Mechanics
- 🔀 **Enhanced Invader Movement**: More dynamic and challenging alien patterns.  
- 💣 **Retaliation Fire**: Invaders shoot back, increasing difficulty.  
- 🛡️ **Dodge Mechanic**: Player can avoid incoming bullets for added strategy.  
- 🌈 **Colored Bullets**: Visual feedback for player and invader shots.  
- 🏆 **Win/Loss Conditions**: Clear endgame scenarios for victory or defeat.

### Game Flow Improvements
- 🔁 **Restart Functionality**: Restart the game without reloading.  
- 🥇 **Victory and Defeat States**: Clear and rewarding game-ending conditions.

---

# Code Comparison: Boilerplate vs New Update

This document compares the key differences between the boilerplate code and the new update, highlighting changes in behavior, mechanics, structure, and new features added in the update.

| **Aspect**                           | **Boilerplate Code**                                                             | **New Update**                                                                                          |
|--------------------------------------|---------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| **Projectile Movement**              | Lasers can move both horizontally and vertically based on `horizontalValue` and `verticalValue`. | Projectiles move only vertically using `verticalValue`.                                                                  |
| **Projectile Lifetime Management**   | Uses `Destroy(gameObject, destroyAfter)` for laser lifetime.                                 | Same method (`Destroy(gameObject, destroyAfter)`), but no projectile pooling mechanism.                                  |
| **Collision Detection**              | Collisions are detected with the player or other game objects using `OnTriggerEnter2D`.       | Similar collision detection, but only focuses on player-enemy interaction.                                               |
| **Laser Firing**                     | Lasers are shot by enemies with random timing and targeting based on `RandomEnemyShooting()`. | Player shoots projectiles with a button press (`Input.GetButtonDown("Jump")`).                                           |
| **Laser Instantiation**              | Lasers are instantiated from randomly selected enemy positions (top, mid, bot).              | Projectiles are instantiated from the player's position when the shooting button is pressed.                              |
| **Movement of Player**               | No player movement code; focus is on enemies and laser behavior.                             | Player movement is restricted by screen edges, only allowing horizontal movement within bounds.                           |
| **Enemy Movement**                   | Enemies move horizontally and vertically within a specified range using `Move()` and `moveUpNDown()`. | No enemy movement is implemented in the new update.                                                                      |
| **Laser Behavior and Effects**       | Lasers are destroyed after a set time or on collision with the player.                        | Projectiles are destroyed after a set time, but behavior is focused only on player shooting.                              |
| **Sound Effects**                    | Sound effects for enemies being destroyed and lasers colliding with the player.              | Destruction sound played for enemies when they are hit by projectiles.                                                   |
| **GameObject Pooling**               | No pooling implemented for lasers.                                                          | No pooling implemented; projectiles are destroyed after use.                                                             |
| **Shooting Mechanism**               | Enemies shoot lasers randomly with time intervals based on `RandomEnemyShooting()`.           | Player shoots projectiles when the jump button is pressed (`Input.GetButtonDown("Jump")`).                               |

## New Update Features

The previous game lacked the following key features:

- No score
- No game ending
- No levels

### New Update Features:
1. **Different Music** - Added music to the game for different stages and actions.
2. **Background Image** - Included a background image to enhance visual aesthetics.
3. **Tank Image** - Customized the player’s tank image.
4. **Invaders Image** - Customized enemy invader images for a unique look.
5. **Movement of Invaders** - Implemented movement mechanics for the invaders.
6. **Firing Music** - Added sound effects for when projectiles are fired.
7. **Color of Bullet** - Introduced different colors for the bullets.
8. **Starting Screen** - Added a starting screen before the game begins.
9. **Score** - Introduced a score system to track player progress.
10. **Retaliation Fire** - Implemented retaliation fire from enemies after being shot at.
11. **Restart Game Button** - Added a button to restart the game after it ends.
12. **Ability to Dodge Bullets** - Enabled the player to dodge enemy projectiles.
13. **Win/Loss Condition** - Set up win/loss conditions based on player progress.

## Key Differences:
1. **Projectile Movement**:
   - The Boilerplate code allows both horizontal and vertical movement for lasers, while the new update limits the projectiles to vertical movement.
   
2. **Shooting Mechanism**:
   - In the Boilerplate, enemies shoot randomly, while in the new update, the player shoots projectiles upon pressing a button.

3. **Laser Behavior**:
   - Both codes handle laser destruction after a time delay, but the Boilerplate adds random enemy shooting, while the new update only focuses on player firing projectiles.

4. **Enemy Movement**:
   - The Boilerplate includes movement for enemies (horizontal and vertical), while the new update does not have enemy movement.

This table summarizes the changes and differences between the boilerplate code and the new update for a clearer understanding of code behavior, design choices, and new features added in the update.



## How to Play
1. **Start the Game**: Click the "Play" button on the starting screen.  
2. **Shoot and Dodge**: Use the controls to fire at invaders while dodging their bullets.  
3. **Win the Game**: Destroy all invaders to achieve victory!  
4. **Restart**: Use the restart button to try again after a win or loss.

---

## Setup and Play

1. Clone the repository.
2. Open the project in Unity.
3. Configure the project settings as needed.
4. Build and run the project.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more information.
