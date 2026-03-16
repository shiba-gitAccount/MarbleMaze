using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleController : MonoBehaviour
{
    float fallThreshold = -5f;

    void RestartScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            RestartScene();
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("ゴールしました");
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log(nextSceneIndex);
        SceneManager.LoadScene(nextSceneIndex);
    }
}
