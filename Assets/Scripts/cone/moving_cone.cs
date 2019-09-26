using UnityEngine;

public class moving_cone : MonoBehaviour
{
    public float speed = 2f;
    public GameObject cone;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (transform.position.y < -7.8665f)
        {
            Instantiate(cone, new Vector3(0f, 12f, 0f), Quaternion.Euler(new Vector3(-90, 0, 0)));
            Destroy(gameObject);
        }
    }
}