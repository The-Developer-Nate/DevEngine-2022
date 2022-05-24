using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silk.NET;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace DevEngine_2022.Engine
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
                UpdatesPerSecond = 500
            });
            window.Update += dt => Update((float)dt);
            window.Load += OnStart;
            window.Run();
        }

        protected void OnStart() { }
        protected void Update(float dt) { }

    }
}
