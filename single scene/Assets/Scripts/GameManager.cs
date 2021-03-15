using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public static int score;
    public static GameObject[] pickups;
    public static int count;
    public TMP_Text time;

    public TMP_Text scoretxt;

    private Vector3 StartPos;

    public static int scorepts = 1;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = player.transform.position;
        score = 0;
        pickups = GameObject.FindGameObjectsWithTag("pickups");
        count = pickups.Length;
        PauseGame();
    }


    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        scoretxt.text = ":" + score;
        time.text = startTime.ToString("F0");
    }

     public void RespawnPlayer()
    {
        player.transform.position = StartPos;
        score = 0;
    }

     public void PauseGame()
     {
         Time.timeScale = 0;
         
     }

     public void UnPauseGame()
     {
         Time.timeScale = 1;
     }
     
     public void Quit()
     {
         //If we are running in a standalone build of the game
#if UNITY_STANDALONE
         //Quit the application
         Application.Quit();
#endif

         //If we are running in the editor
#if UNITY_EDITOR
         //Stop playing the scene
         UnityEditor.EditorApplication.isPlaying = false;
#endif
     }
}
