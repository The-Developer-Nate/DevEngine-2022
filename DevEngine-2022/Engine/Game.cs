using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silk.NET;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace DevEngine.Engine
{
    public class Game
    {

        IWindow window;

        internal GL CreateGL() => window?.CreateOpenGL();

        public void Close() => window?.Close();

        /// <summary>
        /// Creates a new game instance.
        /// </summary>
        public Game(string title)
        {
            window = Window.Create(new WindowOptions()
            {
                Title = title,
                UpdatesPerSecond = 500,
                Size = new Silk.NET.Maths.Vector2D<int>(720, 720),
                Position = new Silk.NET.Maths.Vector2D<int>(0,0)
            });
            window.Update += dt => Update((float)dt);
            window.Load += OnStart;
            window.Run();
        }

        protected void OnStart() { }
        protected void Update(float dt) { }

    }
}
