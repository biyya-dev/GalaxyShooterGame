using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class PowerShip
{
    public enum PowerUpType
    {
        Health,
        Shield,
        DoubleDamage,
        SpeedBoost,
        FireRateBoost
    }

    private Texture2D _texture;
    private Vector2 _position;
    private PowerUpType _type;
    private float _duration; // How long the power-up lasts (if temporary)

    public bool IsActive { get; private set; } = true; // Whether the power-up is available to pick up

    public PowerShip(Texture2D texture, Vector2 position, PowerUpType type, float duration = 0)
    {
        _texture = texture;
        _position = position;
        _type = type;
        _duration = duration; // Set 0 for permanent effects (e.g., health restore)
    }

    public void Update(GameTime gameTime)
    {
        // Optional: Add movement or animations for the power-up (e.g., drifting or rotating)
    }

    public void ApplyEffect(PlayerShip player)
    {
        if (!IsActive) return;

        switch (_type)
        {
            case PowerUpType.Health:
                player.IncreaseHealth(50); // Increase player health
                break;
            case PowerUpType.Shield:
                player.ActivateShield(10); // Activate shield for 10 seconds
                break;
            case PowerUpType.DoubleDamage:
                player.ActivateDoubleDamage(_duration);
                break;
            case PowerUpType.SpeedBoost:
                player.ModifySpeed(2.0f, _duration); // Temporarily boost speed
                break;
            case PowerUpType.FireRateBoost:
                player.ModifyFireRate(0.5f, _duration); // Temporarily decrease fire interval
                break;
        }

        IsActive = false; // Disable 
