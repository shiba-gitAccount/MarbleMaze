using UnityEngine;

public class MoveWallController : MonoBehaviour
{
    float speed = 0.01f;
    float swing = 0.5f;
    float delta = 0f;

    public void SpeedUp()
    {
        this.speed *= 3f;
    }

    void Update()
    {
        if (this.delta > this.swing || this.delta < - this.swing)
        {
            this.speed *= -1f;
        }
        transform.Translate(0, 0, this.speed);
        this.delta += this.speed;
    }
}
