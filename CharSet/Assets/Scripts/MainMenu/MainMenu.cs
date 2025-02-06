using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Evader;
using TMPro;

namespace Evader.Menu {

    public class MainMenu : MonoBehaviour
    {
        public TextMeshProUGUI highscore;

        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void QuitGame()
        {
            Debug.Log("Quit Game.");
            Application.Quit();
        }

        public void RefreshHighscoreToText()
        {
            
        }

        private void Start()
        {
            highscore.text = "Your Highscore: " +  PlayerPrefs.GetInt("score").ToString();
        }

    }
}