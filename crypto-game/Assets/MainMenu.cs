using UnityEngine;
//using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public int level;

	// Use this for initialization
	void Start() {
	
	}
	
	// Update is called once per frame
	void Update() {
	
	}
	public void loadLVL()
	{
		SceneManager.LoadScene(level, LoadSceneMode.Single);
	}
	public void exitGame()
	{
		Application.Quit();
	}
}