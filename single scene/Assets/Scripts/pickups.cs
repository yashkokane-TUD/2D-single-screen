using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour
{
    private int bonus = 100;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            GameManager.score = GameManager.score + GameManager.scorepts;
            Destroy(gameObject);
        }
    }
}
