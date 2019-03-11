using UnityEngine;
//using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public int level;

	// Use this for initialization
	void Start() {
	
	}

	void Update() {
	
	}
    //lvl 1 load
	public void loadLVL()
	{
		SceneManager.LoadScene(level, LoadSceneMode.Single);
	}
    //app exit
	public void exitGame()
	{
		Application.Quit();
	}
}