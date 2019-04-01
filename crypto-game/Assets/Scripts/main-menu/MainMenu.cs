using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public int level;

    // Use this for initialization
    private void Start() {
	
	}

    private void Update() {
	
	}
    //lvl 1 load
    public void LoadLVL() => SceneManager.LoadScene(level, LoadSceneMode.Single);
    //app exit
    public void ExitGame() => Application.Quit();
}