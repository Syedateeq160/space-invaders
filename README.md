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

# Code Comparison: Boilerplate vs Ateeq's Update

This document compares the key differences between the boilerplate code (Ahmed's code) and Ateeq's update, highlighting changes in behavior, mechanics, and structure.

| **Aspect**                           | **Boilerplate **                                                             | **Ateeq's Update **                                                                                          |
|--------------------------------------|---------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| **Projectile Movement**              | Lasers can move both horizontally and vertically based on `horizontalValue` and `verticalValue`. | Projectiles move only vertically using `verticalValue`.                                                                  |
| **Projectile Lifetime Management**   | Uses `Destroy(gameObject, destroyAfter)` for laser lifetime.                                 | Same method (`Destroy(gameObject, destroyAfter)`), but no projectile pooling mechanism.                                  |
| **Collision Detection**              | Collisions are detected with the player or other game objects using `OnTriggerEnter2D`.       | Similar collision detection, but only focuses on player-enemy interaction.                                               |
| **Laser Firing**                     | Lasers are shot by enemies with random timing and targeting based on `RandomEnemyShooting()`. | Player shoots projectiles with a button press (`Input.GetButtonDown("Jump")`).                                           |
| **Laser Instantiation**              | Lasers are instantiated from randomly selected enemy positions (top, mid, bot).              | Projectiles are instantiated from the player's position when the shooting button is pressed.                              |
| **Movement of Player**               | No player movement code; focus is on enemies and laser behavior.                             | Player movement is restricted by screen edges, only allowing horizontal movement within bounds.                           |
| **Enemy Movement**                   | Enemies move horizontally and vertically within a specified range using `Move()` and `moveUpNDown()`. | No enemy movement is implemented in Ateeq's update.                                                                      |
| **Laser Behavior and Effects**       | Lasers are destroyed after a set time or on collision with the player.                        | Projectiles are destroyed after a set time, but behavior is focused only on player shooting.                              |
| **Sound Effects**                    | Sound effects for enemies being destroyed and lasers colliding with the player.              | Destruction sound played for enemies when they are hit by projectiles.                                                   |
| **GameObject Pooling**               | No pooling implemented for lasers.                                                          | No pooling implemented; projectiles are destroyed after use.                                                             |
| **Shooting Mechanism**               | Enemies shoot lasers randomly with time intervals based on `RandomEnemyShooting()`.           | Player shoots projectiles when the jump button is pressed (`Input.GetButtonDown("Jump")`).                               |

## Key Differences:
1. **Projectile Movement**:
   - The Boilerplate code allows both horizontal and vertical movement for lasers, while Ateeq’s update limits the projectiles to vertical movement.
   
2. **Shooting Mechanism**:
   - In the Boilerplate, enemies shoot randomly, while in Ateeq's update, the player shoots projectiles upon pressing a button.

3. **Laser Behavior**:
   - Both codes handle laser destruction after a time delay, but the Boilerplate adds random enemy shooting, while Ateeq’s update only focuses on player firing projectiles.

4. **Enemy Movement**:
   - The Boilerplate includes movement for enemies (horizontal and vertical), while Ateeq's update does not have enemy movement.



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
