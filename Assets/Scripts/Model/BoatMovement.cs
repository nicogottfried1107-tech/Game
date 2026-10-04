using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;
    public float speed = 2f;

    private Transform target;

    void Start()
    {
        target = rightPoint;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == rightPoint)
                target = leftPoint;
            else
                target = rightPoint;
        }
    }
}
