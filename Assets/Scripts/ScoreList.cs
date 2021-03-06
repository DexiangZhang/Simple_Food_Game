using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreList : MonoBehaviour
{
    public Text text;
    const int MAX = 5;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        string key = "Score";
        for (int i = 0; i < MAX; i++)
        {
            string current = key + i;
            if (PlayerPrefs.HasKey(current))
            {
                text.text += PlayerPrefs.GetInt(current) + "\n";
            }
        }

    }
}
