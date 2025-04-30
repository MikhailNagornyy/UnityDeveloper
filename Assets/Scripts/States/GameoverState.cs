using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Golf
{
    public class GameoverState : GameState
    {
        public GameState mainMenuState;
        public LevelController levelController;

        public void Restart()
        {
            levelController.ClearStone(); 

            Exit();
            mainMenuState.Enter();
        }
    }
}
