using UnityEngine;

public class move_objects_right_down : MonoBehaviour
{
    public float speed = 2f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y > 6)
            Destroy(gameObject);
    }
}