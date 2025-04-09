using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach(GameObject p in projectiles)
            {
                p.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
