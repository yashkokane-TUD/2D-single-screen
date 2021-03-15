using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    private int Bonus = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            GameManager.score = GameManager.score + Bonus;
            Destroy(gameObject);
        }
    }
}