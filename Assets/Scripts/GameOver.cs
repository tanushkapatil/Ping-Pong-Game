using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("PongGame"); 
    }
}
