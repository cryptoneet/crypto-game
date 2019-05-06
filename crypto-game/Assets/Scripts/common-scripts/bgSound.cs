using UnityEngine;

public class bgSound : MonoBehaviour
{
    private static bgSound _instance;
    private static AudioSource audMain;

    public static bgSound instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<bgSound>();

                //Tell unity not to destroy this object when loading a new scene!
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            //If I am the first instance, make me the Singleton
            _instance = this;
            audMain = _instance.gameObject.GetComponent<AudioSource>();
            DontDestroyOnLoad(this);
        }
        else
        {
            //If a Singleton already exists and you find
            //another reference in scene, destroy it!
            if (this != _instance)
            {
                Destroy(_instance.gameObject);
                _instance = this;
                audMain = _instance.gameObject.GetComponent<AudioSource>();
            }
        }
    }
    private void Update()
    {
        audMain.volume = globalVar.volValue;
    }
    public void Play()
    {
        //Play some audio!
    }
}
