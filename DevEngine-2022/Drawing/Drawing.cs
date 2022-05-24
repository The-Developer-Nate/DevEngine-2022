using DevEngine.Engine;
using Silk.NET.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEngine.Drawing
{
    public class Drawing
    {

        private GL gl;

        public Drawing(Game game)
        {
            gl = game.CreateGL(); 

        }
    }
}
