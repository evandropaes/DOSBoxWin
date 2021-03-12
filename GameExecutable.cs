using System;
using System.Collections.Generic;
using System.Text;

namespace DosBlaster
{
    public class GameExecutable
    {
        Game _game;
        string _exePath;

        public GameExecutable(Game game, string exePath)
        {
            _game = game;
            _exePath = exePath;
        }

        public Game Game
        {
            get { return _game; }
        }

        public string ExePath
        {
            get { return _exePath; }
        }
    }
}
