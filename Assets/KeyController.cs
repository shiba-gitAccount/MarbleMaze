using UnityEngine;

public class KeyController : MonoBehaviour
{
    float rotateSpeed = 5f;
    float verticalSpeed = 0.005f;
    float updown = 0.1f;
    float delta = 0f;

    public void GetKey() {
        this. rotateSpeed = 20f;
        this.verticalSpeed = 0.02f;
        this.updown = 0.4f;
    }

    void Update()
    {
        if (this.delta > this.updown || this.delta < - this.updown)
        {
            this.verticalSpeed *= -1f;
        }
        transform.Translate(0, this.verticalSpeed, 0);
        this.delta += this.verticalSpeed;
        transform.Rotate(0, rotateSpeed, 0);

        if (this.delta > 0.4f) {
            Destroy(gameObject);
        }
    }
}
