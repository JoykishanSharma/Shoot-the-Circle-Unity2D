using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
	private bool gameHasEnded = false;
	public Rotator rotator;
	public Spawner spawner;
	public Animator animator;
	public void EndGame()
	{
		if(gameHasEnded)
			return;
		
		rotator.enabled = false;
		spawner.enabled = false;
		
		animator.SetTrigger("EndGame");
		
		gameHasEnded = true;
		Debug.Log("Game Ended");
	}
	
	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
