using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int scorePerBump = -10;
    ScoreBoard scoreBoard;

    public void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    private void OnTriggerEnter(Collider other)
    {
        scoreBoard.increasescore(scorePerBump);
        Destroy(gameObject);
    }
}
