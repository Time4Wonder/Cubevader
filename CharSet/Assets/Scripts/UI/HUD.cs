using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evader.Player;
using UnityEngine.UI;

namespace Evader.UI
{
    public class HUD : MonoBehaviour
    {
        private GameObject player;
        public Text scoreUI;
        public float score;
        private const string ScoreKey = "score";

        
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        void Update()
        {
            score = player.transform.position.z;
            score = (int)score;
            scoreUI.text = score.ToString();
        }
    }
}