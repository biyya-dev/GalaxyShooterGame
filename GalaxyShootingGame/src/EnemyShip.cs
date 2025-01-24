using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class EnemyShip
{
    private Texture2D _texture;
    private Vector2 _position;
    private float _speed;

    public EnemyShip(Texture2D texture, Vector2 initialPosition, float speed)
    {
        _texture = texture;
        _position = initialPosition;
        _speed = speed;
    }

    public void Update(GameTime gameTime)
    {
        _position.Y += _speed; // Move enemy downward
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, _position, Color.White);
    }
}
