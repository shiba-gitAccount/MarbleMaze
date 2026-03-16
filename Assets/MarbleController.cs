using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("GameScene_0");
        }
    }
}
