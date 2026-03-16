using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagController : MonoBehaviour
{
    void Start()
    {
        Collider[] childColliders = GetComponentsInChildren<Collider>();
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("ゴールしました");
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log(nextSceneIndex);
        SceneManager.LoadScene(nextSceneIndex);
    }
}
