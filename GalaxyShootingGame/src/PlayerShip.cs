using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class PlayerShip
{
    private Texture2D _texture;
    private Vector2 _position;
    private float _speed = 5f;

    public PlayerShip(Texture2D texture, Vector2 initialPosition)
    {
        _texture = texture;
        _position = initialPosition;
    }

    public void Update(GameTime gameTime)
    {
        var keyboardState = Keyboard.GetState();

        if (keyboardState.IsKeyDown(Keys.W))
            _position.Y -= _speed;
        if (keyboardState.IsKeyDown(Keys.S))
            _position.Y += _speed;
        if (keyboardState.IsKeyDown(Keys.A))
            _position.X -= _speed;
        if (keyboardState.IsKeyDown(Keys.D))
            _position.X += _speed;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, _position, Color.White);
    }
}
