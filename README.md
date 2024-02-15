# Player Movement Script

This Unity script provides basic player movement functionality using the CharacterController component. It includes parameters for speed, gravity, ground detection, and jumping.

## Features
- Smooth player movement with adjustable speed.
- Realistic gravity simulation for natural falling.
- Jump functionality with adjustable jump height.
- Ground detection prevents double jumping.

## Usage
1. **Attach Script:** Attach this script to the player GameObject in your Unity scene.

2. **Assign CharacterController:**
   - Add a CharacterController component to the player GameObject.
   - Assign the CharacterController component to the `controller` variable in the Inspector.

3. **Adjust Parameters:**
   - Tweak parameters like `speed`, `gravity`, and `jumpheight` in the Inspector to suit your game.

4. **Input Configuration:**
   - Ensure your Unity Input Manager has a configured "Jump" key.

5. **Example Code:**
   ```csharp
   public class movement : MonoBehaviour
   {
       // ... (Your existing code here)
   }
   
## Notes
- Adjust the groundcheck position and groundist for accurate ground detection.
- Feel free to customize and build upon this script for your Unity game. Happy coding!