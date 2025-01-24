Level {
    Background: "background.png"
    Player: { ShipType: "Falcon", Speed: 6, FireRate: 3 }
    Enemies: [
        { Type: "Drone", Count: 8, Speed: 3, SpawnInterval: 2 },
        { Type: "Bomber", Count: 4, Speed: 2, SpawnInterval: 4 },
        { Type: "Boss", Count: 1, Speed: 1, SpawnInterval: 10 }
    ]
    PowerUps: [
        { Type: "Health", SpawnTime: 15 },
        { Type: "DoubleDamage", SpawnTime: 25 }
    ]
}

