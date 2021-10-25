using Evader.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Evader.UI
{
    public class DeathScreen : MonoBehaviour
    {
        public TextMeshProUGUI score;
        public HUD hud;

        public void BackToMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        public void PlayAgain()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void Start()
        {
            score.text = "SCORE: " + hud.score.ToString();
        }

    }
}