using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silk.NET;
using Silk.NET.Core.Contexts;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace DevEngine.Engine
{
    public class Game
    {

        public IWindow window;

        internal GL CreateGL() => window?.CreateOpenGL();

        public void Close() => window?.Close();

        public Action OnStart;
        public Action<double> Update;
        public Action<double> Render;
        public Action Closing;

        /// <summary>
        /// Creates a new game instance.
        /// </summary>
        public Game(string title, int width, int height, int x = 0, int y = 0)
        {
            window = Window.Create(new WindowOptions()
            {
                Title = title,
                UpdatesPerSecond = 500,
                Size = new Silk.NET.Maths.Vector2D<int>(width, height),
                Position = new Silk.NET.Maths.Vector2D<int>(x, y),
                IsContextControlDisabled = true,
            });
            window.Update += dt => Update((float) dt);
            window.Render += _ => Render((float) _);
            window.Load += OnStart;
            window.Closing += Closing;
        }

        public void Start()
        {
            window.Run();
        }

    }
}
