using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burger : MonoBehaviour
{
    // Start is called before the first frame update
   public int burgerValue = 10;

   public void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.CompareTag("Player")) {
           ScoreManager.instance.ChangeScore(burgerValue);
       }
   }
}
