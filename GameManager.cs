using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float endDelay = 1f;
    bool gameHasEnded = false;
    public GameObject restartLevelUI;
    public GameObject score;
    public Transform tri;
    public Vector3 a1;
    
    // Start is called before the first frame update
    public void End()
        {
            if(gameHasEnded == false )
            {
                gameHasEnded = true; 
                
            }
            restartLevelUI.SetActive(true);
            score.SetActive(false);
            tri.transform.position = a1;

        }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
