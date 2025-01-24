Level {
    Background: "background.png"
    Player: { ShipType: "Falcon", Speed: 5, FireRate: 2 }
    Enemies: [
        { Type: "Drone", Count: 5, Speed: 2, SpawnInterval: 3 },
        { Type: "Bomber", Count: 2, Speed: 1, SpawnInterval: 5 }
    ]
    PowerUps: [
        { Type: "Health", SpawnTime: 10 },
        { Type: "Shield", SpawnTime: 20 }
    ]
}
