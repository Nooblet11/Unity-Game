using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    int scorePerBump = 50;
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
