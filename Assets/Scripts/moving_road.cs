using UnityEngine;

public class moving_road : MonoBehaviour
{
    public float speed = 2f;
    public GameObject road;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -7.8665f)
        {
            Instantiate(road, new Vector3(0f, 12f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }            
    }
}