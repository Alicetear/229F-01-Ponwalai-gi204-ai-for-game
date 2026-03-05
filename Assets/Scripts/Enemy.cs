using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public float range = 10f;
    public Vector3 startPosition;
    public Vector3 randomPosition;

    void Start()
    {
        startPosition = transform.position;
        SetRandomPosition();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, randomPosition, speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, randomPosition) < 0.5f)
        {
            SetRandomPosition();
        }
    }

    void SetRandomPosition()
    {
        float randomX = Random.Range(-range, range);
        float randomZ = Random.Range(-range, range);

        randomPosition = startPosition + new Vector3(randomX, 0, randomZ);
    }
}
