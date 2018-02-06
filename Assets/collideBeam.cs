using UnityEngine;
using System.Collections;

public class collideBeam : MonoBehaviour
{

    public Color colorStart = Color.red;
    public Color colorEnd = Color.green;
    public float duration = 1.0F;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("COLLIDE!!!");
        
    }
}