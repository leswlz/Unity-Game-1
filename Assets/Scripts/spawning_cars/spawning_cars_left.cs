using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawning_cars_left : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = { -2.13f, -2.03f, -1.93f, -0.83f, -0.71f, -0.65f };
    public Text score;
    public int i_score; 

    void Start()
    {
        StartCoroutine(spawn());
        i_score = 1;
        Score();
    }

    IEnumerator spawn()
    {
        while(true)
        {
            Instantiate
                (cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, 6)], 6f, 0),
                Quaternion.Euler(new Vector3(90, 180, 0))
            );
            yield return new WaitForSeconds(Random.Range(0.2f, 2f));

            i_score = i_score + 1;
            Score();           
        }
    }

    void Score()
    {
        score.text = "score: " + i_score.ToString();
    }
}