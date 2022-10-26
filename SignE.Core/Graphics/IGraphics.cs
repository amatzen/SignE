namespace SignE.Core.Graphics
{
    public interface IGraphics
    {
        // Primitive Shapes
        void DrawCircle(float x, float y, float r);
        void DrawRectangle(float x, float y, int w, int h);
        
        // Sprites
        ISprite CreateSprite(string path);
        void DrawSprite(ISprite sprite, float x, float y);
    }
}