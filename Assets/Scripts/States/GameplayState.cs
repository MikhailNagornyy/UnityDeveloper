using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class GameplayState : GameState
    {

        public LevelController levelController;
        public PlayerController playerController;
        public GameState gameOverState;
        public TMP_Text scoreText;

        protected override void OnEnable()
        {
            base.OnEnable();

            levelController.enabled = true;
            playerController.enabled = true;

            GameEvents.onCollisionStone += OnGameOver;
            GameEvents.onStickHit += OnStickHit;
        }

        private void OnStickHit()
        {
            scoreText.text = $"HScore : {levelController.score}";
        }
        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }
        protected override void OnDisable()
        {
            base.OnDisable();

            levelController.enabled = false;
            playerController.enabled = false;

            GameEvents.onCollisionStone -= OnGameOver;
        }
    }
}
