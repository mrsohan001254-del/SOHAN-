# 🚗 Open Road Driving - Infinite Road Game

A 3D open-world driving game built with **Unity** featuring infinite road generation, realistic car physics, AI traffic, and dynamic scoring system.

## 🎮 Game Features

✅ **Infinite Road Generation** - Endless driving experience  
✅ **Realistic Car Physics** - Acceleration, braking, turning  
✅ **AI Traffic System** - Dynamic traffic cars  
✅ **Speedometer & UI** - Real-time speed and distance tracking  
✅ **Dynamic Camera** - Switch between 3rd person & top-down views  
✅ **Collision Detection** - Realistic car collisions  
✅ **Score System** - Track distance traveled  

## 🎮 Controls

| Key | Action |
|-----|--------|
| **W / ↑** | Accelerate |
| **S / ↓** | Brake/Reverse |
| **A / ←** | Turn Left |
| **D / →** | Turn Right |
| **C** | Change Camera View |
| **ESC** | Pause/Resume |

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── CarController.cs        # Main car physics & controls
│   ├── RoadGenerator.cs        # Infinite road generation
│   ├── TrafficSystem.cs        # AI traffic management
│   ├── UIManager.cs            # Speedometer & HUD
│   ├── CameraController.cs     # Camera switching
│   └── GameManager.cs          # Main game logic
├── Prefabs/
│   ├── PlayerCar.prefab
│   ├── TrafficCar.prefab
│   └── RoadSegment.prefab
└── Scenes/
    └── MainGame.unity
```

## 🚀 How to Set Up

### Prerequisites
- **Unity 2020.3 LTS** or higher
- **C# knowledge** (basic)

### Installation Steps

1. **Clone the repository**
```bash
git clone https://github.com/mrsohan001254-del/SOHAN-.git
cd SOHAN-
```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open Project"
   - Select the project folder
   - Wait for Unity to import assets

3. **Create the Scene**
   - Go to `Assets/Scenes/`
   - Right-click → Create → Scene
   - Name it `MainGame`
   - Save it

4. **Set Up Prefabs**
   - Create 3D Objects (Cube) for:
     - PlayerCar (scale: 2x1x4, tag: "Player")
     - TrafficCar (scale: 2x1x3)
     - RoadSegment (scale: 20x0.5x50, material: gray)

5. **Add Scripts to GameObjects**
   - PlayerCar → Add CarController
   - TrafficCar → Add TrafficSystem
   - Main Camera → Add CameraController
   - Empty GameObject → Add GameManager
   - Canvas → Add UIManager

6. **Create UI Canvas**
   - Right-click Scene → UI → Text - TextMeshPro
   - Create speedText and distanceText
   - Create Image for speedBar

7. **Press Play** 🎮

## 📊 Script Details

### CarController.cs
Handles player car movement, acceleration, braking, and wheel rotation.

**Key Variables:**
- `maxSpeed` - Maximum speed (50 km/h)
- `acceleration` - Acceleration rate (10 units/s²)
- `braking` - Braking force (15 units/s²)
- `turnSpeed` - Turning responsiveness (5)

### RoadGenerator.cs
Generates infinite road segments dynamically.

**Key Variables:**
- `segmentLength` - Length of each road piece (50 units)
- `activeSegments` - Number of segments to keep active (5)

### TrafficSystem.cs
Manages AI traffic cars spawning and movement.

**Key Variables:**
- `maxTrafficCars` - Number of traffic cars (5)
- `trafficSpeed` - Speed of AI cars (15 km/h)

### UIManager.cs
Updates speedometer and distance display.

### CameraController.cs
Provides smooth 3rd person and top-down camera views.

### GameManager.cs
Main game logic and pause functionality.

## 🎨 Customization

### Change Car Color
```csharp
GetComponent<Renderer>().material.color = Color.red;
```

### Adjust Car Speed
Open `CarController.cs` and modify:
```csharp
public float maxSpeed = 100f;  // Increase for faster car
```

### Add More Traffic
In `TrafficSystem.cs`:
```csharp
public int maxTrafficCars = 10;  // More AI cars
```

## 🐛 Troubleshooting

**Problem:** Car falls through road
- **Solution:** Add Rigidbody & Collider to road segments

**Problem:** Camera not following car
- **Solution:** Assign PlayerCar to CameraController's playerCar field

**Problem:** Traffic not spawning
- **Solution:** Create TrafficCar prefab and assign to TrafficSystem

## 🤝 Contributing

Feel free to fork, modify, and improve this project!

## 📝 License

Open source - Free to use and modify

## 🎯 Future Features

- 🏆 Leaderboard system
- 🛣️ Multiple road types (city, highway, mountain)
- 🎨 Car customization
- 💨 Power-ups and obstacles
- 🎵 Sound effects and music
- 📱 Mobile controls support

## 👨‍💻 Author

**Sohan** - Open Road Driving Game Developer

---

**Enjoy driving! 🚗💨