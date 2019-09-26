using UnityEngine;
using UnityEngine.UI;

public class clamp_score : MonoBehaviour
{
    public Text name_label;
        
    void Update()
    {
        Vector3 name_position = Camera.main.WorldToScreenPoint(this.transform.position);
        name_label.transform.position = name_position;
    }
}