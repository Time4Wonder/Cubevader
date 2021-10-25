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
    }

}