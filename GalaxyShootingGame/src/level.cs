using System.Collections.Generic;

public class Level
{
    public string Background { get; set; }
    public List<EnemyShip> Enemies { get; set; }
    public List<PowerUp> PowerUps { get; set; }

    public Level()
    {
        Enemies = new List<EnemyShip>();
        PowerUps = new List<PowerUp>();
    }
}
