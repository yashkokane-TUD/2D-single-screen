using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            GameManager.score = GameManager.score + GameManager.scorepts;
            Destroy(gameObject);
        }
    }
}
