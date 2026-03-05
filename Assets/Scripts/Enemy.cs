using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 direction;

    void Start()
    {
        direction = Random.insideUnitSphere;
        direction.y = 0;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
