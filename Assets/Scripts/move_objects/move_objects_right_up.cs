using UnityEngine;

public class move_objects_right_up : MonoBehaviour
{
    public float speed = 2f;
           
    void FixedUpdate()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (transform.position.y < -6)        
            Destroy(gameObject);                             
    }
}