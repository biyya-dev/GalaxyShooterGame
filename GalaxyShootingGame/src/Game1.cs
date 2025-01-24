using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private PlayerShip _player;
    private Texture2D _backgroundTexture;
    private Vector2 _backgroundPosition;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        _backgroundPosition = Vector2.Zero;
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // Load resources
        _backgroundTexture = Content.Load<Texture2D>("background");
        var playerTexture = Content.Load<Texture2D>("player");
        _player = new PlayerShip(playerTexture, new Vector2(400, 500));
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _player.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        _spriteBatch.Begin();
        _spriteBatch.Draw(_backgroundTexture, _backgroundPosition, Color.White);
        _player.Draw(_spriteBatch);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
