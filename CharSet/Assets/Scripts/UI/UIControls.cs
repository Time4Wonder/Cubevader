using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Evader.UI
{
    public class UIControls : MonoBehaviour
    {
        public GameObject hud;
        public GameObject pauseMenu;

        private void Update()
        {
            Pause();
        }

        public void Pause()
        {
            
            if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Space))
            {
                hud.SetActive(false);
                pauseMenu.SetActive(true);
            }
        }
    }
}