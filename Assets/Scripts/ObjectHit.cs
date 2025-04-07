using Unity.Cinemachine;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            //GetComponent<Renderer>().material.color = new Color32(0xFF, 0x6B, 0x6B, 0xFF); // #FF6B6B
            GetComponent<MeshRenderer>().material.color = new Color32(0xF8, 0x70, 0x70, 0xFF); // #F87070
            gameObject.tag = "Hit";
        }

    }
}
