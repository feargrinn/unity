﻿using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{

    public Transform player;
    public Text scoreText;
    void Update(){
        scoreText.text = player.position.x.ToString("0");
    }
}
