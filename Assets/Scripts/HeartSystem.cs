using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] hearts;
    public int life;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life <=0) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("End Screen");
        }
        if (life < 1) {
            Destroy(hearts[0].gameObject);
        }
        if (life < 2) {
            Destroy(hearts[1].gameObject);
        }
        if (life < 3) {
            Destroy(hearts[2].gameObject);
        }

    }


    void OnCollisionEnter2D(Collision2D col) {
       if(col.transform.CompareTag("enemy")) {
          life -=1;
       }
   }



}
