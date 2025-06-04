using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float speed = 1.0f;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
