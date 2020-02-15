using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PLayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }

    public void gameSoundOn()
    {
        //code for game sound on
        Debug.Log("Sound On");
    }

    public void gameSoundOff()
    {
        //code for game sound off
        Debug.Log("Sound Off");
    }

    public void gameMusicOn()
    {
        //code for game music on
        Debug.Log("Music On");
    }

    public void gameMusicOff()
    {
        //code for game music off
        Debug.Log("Music Off");
    }
}
