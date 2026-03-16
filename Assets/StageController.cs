using UnityEngine;

public class StageController : MonoBehaviour
{
    private Rigidbody rb;
    Quaternion targetRotation = Quaternion.identity;
    float returnSpeed = 5.0f;

    float sensitivity = 1500.0f;
    Vector2 rotate;
    Vector2 startPos;

    float FastAsin(float delta)
    {
        float radians = delta + (delta * delta * delta * 0.16666667f);
        return radians * Mathf.Rad2Deg;
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector2 currentPos = Input.mousePosition;
            this.rotate = currentPos - startPos;
            float xAngle = FastAsin(this.rotate.y / this.sensitivity) ;
            float zAngle = FastAsin(-this.rotate.x / this.sensitivity) ;
            this.targetRotation = Quaternion.Euler(xAngle, 0, zAngle);
            
        }
        else
        {
            this.targetRotation = Quaternion.Slerp(rb.rotation, Quaternion.identity, Time.deltaTime * returnSpeed);
        }
        rb.MoveRotation(this.targetRotation);

    }
}
