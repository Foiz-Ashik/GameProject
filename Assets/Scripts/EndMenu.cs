using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("level1");
        
    }
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start Menu");
        
    }
    
}
