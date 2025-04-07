using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer mr;
    Rigidbody rb;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>(); 
        rb = GetComponent<Rigidbody>();

        mr.enabled = false;
        rb.useGravity = false;
    }
    void Update()
    {
        if(Time.time > timeToWait)
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
