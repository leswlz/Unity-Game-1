using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed = 2.5f;
    public Text game_over_text;      
    Rigidbody p_rigidbody;
    
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 direction = new Vector3(horizontal, 0, 0);
        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            game_over_text.text = "Game Over";

            p_rigidbody = GetComponent<Rigidbody>();
            p_rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.None;
            p_rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;

            speed = 0.2f;

            Time.timeScale = 0.6f;
            transform.Translate(Vector3.back * 3f * Time.deltaTime * Time.timeScale);           
        }
    }
}