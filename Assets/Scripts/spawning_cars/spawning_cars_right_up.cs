using UnityEngine;
using System.Collections;

public class spawning_cars_right_up : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = { 1.99f, 2.08f, 2.16f };    

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
                new Vector3(positions[Random.Range(0, 3)], 6f, 0),
                Quaternion.Euler(new Vector3(270, 0, 0))
            );
            yield return new WaitForSeconds(Random.Range(5f, 10f));           
        }
    }
}