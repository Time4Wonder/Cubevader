using Evader.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Evader.UI
{
    public class PauseScreen : MonoBehaviour
    {
        public GameObject pauseMenu;
        public GameObject HUD;
        public GameObject deathScreen;

        public TextMeshProUGUI score;
        public HUD hud;

        public static bool GameIsPaused = false;


        public void Pause()
        {
            pauseMenu.SetActive(true);
            HUD.SetActive(false);
            score.text = "SCORE: " + hud.score.ToString();

            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        public void Continue()
        {
            pauseMenu.SetActive(false);
            HUD.SetActive(true);

            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        public void BackToMenu()
        {
            if (hud.score > PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("score", (int)hud.score);
            }

            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape))
            {
                if (!deathScreen.activeSelf) 
                {
                    if (GameIsPaused)
                    {
                        Continue();
                    }
                    else
                    {
                        Pause();
                    }
                }
                
            }
        }

    }
}