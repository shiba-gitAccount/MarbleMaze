using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleController : MonoBehaviour
{
    Rigidbody rb;
    float fallThreshold = -5f;
    float dashForce = 200.0f;
    GameObject key;
    bool getkey = false;
    GameObject flag;
    int currentSceneIndex;
    GameObject[] moveWalls;


    void Start()
    {
        this.currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        this.rb = GetComponent<Rigidbody>();
        this.key = GameObject.Find("Key");
        this.flag = GameObject.Find("Flag");
        if (this.currentSceneIndex == 1)
        {
            this.moveWalls = GameObject.FindGameObjectsWithTag("MoveWall");
        }
    }

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadScene(currentSceneIndex);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flag" && this.getkey)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else if (other.gameObject.tag == "Dash")
        {
            rb.AddForce(-other.transform.right * dashForce);
        }
        else if (other.gameObject.tag == "Key" && !this.getkey)
        {
            this.getkey = true;
            this.key.GetComponent<KeyController>().GetKey();
            this.flag.GetComponent<FlagController>().ColorChange();
            if (this.currentSceneIndex == 1)
            {
                foreach (GameObject moveWall in this.moveWalls)
                {
                    moveWall.GetComponent<MoveWallController>().SpeedUp();
                }
            }
        }
    }
}
