using UnityEngine;

public class globalVar : MonoBehaviour
{
    public static float volValue = 0.6f;
    public static string lang = "rus";

    void Awake()
    {
        if (Application.systemLanguage == SystemLanguage.Russian)
            lang = "rus";
        else
            lang = "eng";
    }
}
