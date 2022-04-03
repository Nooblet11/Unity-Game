using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    [SerializeField] public GameObject one;
    [SerializeField] public GameObject two;
    int i;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] stageList = new GameObject[10];
        stageList[0] = one;
        stageList[1] = two;
        int randGen = Random.Range(0,2);
        bool j = false;
        while (j == false)
        {

            if (randGen == i)
            {
                Instantiate(stageList[i]);
                j = true;
                Debug.Log(randGen);
            }
            else
            {
                i++;
            }
        }
    }
}
