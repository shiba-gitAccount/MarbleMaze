using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Material Dark;
    public Material Glow;
    GameObject gate;

    void Start()
    {
        this.gate = GameObject.Find(gameObject.name + "Gate");
    }

    void OnTriggerEnter(Collider other) 
    {
        this.gate.GetComponent<GateController>().Down();
        GetComponent<Renderer>().material = Glow;
    }

    void OnTriggerExit(Collider other)
    {
        this.gate.GetComponent<GateController>().Up();
        GetComponent<Renderer>().material = Dark;
    }
    
}
