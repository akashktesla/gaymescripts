using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Text pscoreText;
    public Text hscoreText;
    public int a;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (a>PlayerPrefs.GetInt("HighScore",a))
        {
            PlayerPrefs.SetInt("HighScore",a);
        }
        
        a = FindObjectOfType<playercollision>().s+FindObjectOfType<player2collisionscript2>().t;
        scoreText.text = a.ToString();
        pscoreText.text = a.ToString();
        hscoreText.text=PlayerPrefs.GetInt("HighScore").ToString();

    }
}
