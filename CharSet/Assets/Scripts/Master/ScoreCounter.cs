using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evader.Player;
using UnityEngine.UI;

namespace Evader.Master
{
    public class ScoreCounter : MonoBehaviour
    {
        private GameObject player;
        public Text scoreUI;
        private float score;
        private const string ScoreKey = "score";

        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            score = player.transform.position.z;
            scoreUI.text = score.ToString();
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetFloat(ScoreKey, score);
        }
        
        public float CallbackScore()
        {
            float score = PlayerPrefs.GetFloat(ScoreKey);
            return score;
        }
    }

}