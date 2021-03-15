using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static GameObject[] pickups;
    public static int count;

    public TMP_Text scoretxt;
   
 

    public static int scorepts = 1;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        pickups = GameObject.FindGameObjectsWithTag("pickups");
        count = pickups.Length;
    }


    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        scoretxt.text = ":" + score;
        

    }
}
