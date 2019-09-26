using UnityEngine;
using System.Collections;

public class spawning_cars_right_down : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = { 0.69f, 0.78f, 0.87f };

    void Start()
    {
        StartCoroutine(spawn());        
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate
                (cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, 3)], -6f, 0),
                Quaternion.Euler(new Vector3(270, 0, 0))
            );
            yield return new WaitForSeconds(Random.Range(4f, 7f));
        }
    }
}