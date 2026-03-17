using UnityEngine;

public class GateController : MonoBehaviour
{
    float speed = 0f;
    float delta = 0.2f;
    Collider[] childColliders;

    void ColliderChange(bool tf)
    {
        foreach(Collider col in this.childColliders)
        {
            col.enabled = tf;
        }
    }

    public void Down()
    {
        ColliderChange(false);
        this.speed = -0.05f;
        transform.Translate(0, -0.1f, 0);
    }

    public void Up()
    {
        ColliderChange(false);
        this.speed = 0.05f;
        transform.Translate(0, 0.1f, 0);
    }

    void Update()
    {
        if (this.delta * this.speed  > 0.01f)
        {
            this.speed = 0f;
            ColliderChange(true);
        }
        transform.Translate(0, this.speed, 0);
        this.delta += this.speed;
    }

    void Start()
    {
        childColliders = GetComponentsInChildren<Collider>();
    }
}
