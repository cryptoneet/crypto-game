using UnityEngine;

public class globalVar : MonoBehaviour
{
    public static float volValue = 0.6f;
    public static string lang = "rus";

    public void setLang(string lg)
    {
        lang = lg;
    }
}
