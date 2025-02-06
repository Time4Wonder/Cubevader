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

        private void OnEnable()
        {
            score.text = "SCORE: " + hud.score.ToString();

            if(hud.score > PlayerPrefs.GetInt("score"))
                PlayerPrefs.SetInt("score", (int)hud.score);
        }

        private void Update()
        {
            if(Input.GetKey(KeyCode.Space))
            {
                PlayAgain();
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                BackToMenu();
            }
        }
    }
}