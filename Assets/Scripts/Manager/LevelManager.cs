using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string sceneName)
    {
        FindObjectOfType<AudioSource>().Stop();
        SceneManager.LoadScene(sceneName);
    }

    public void LoadLevel(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
