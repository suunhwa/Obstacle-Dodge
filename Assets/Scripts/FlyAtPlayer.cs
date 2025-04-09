using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1.0f;
    Vector3 playerPos;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPos = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * speed);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
