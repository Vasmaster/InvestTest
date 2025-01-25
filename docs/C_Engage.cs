using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Engage : MonoBehaviour
{
    public float minScale = 1.0f;  // Minimum scale size
    public float maxScale = 1.2f;  // Maximum scale size
    public float speed = 2.0f;     // Speed of scaling

    private Vector3 initialScale;
    private float timer;

    void Start()
    {
        initialScale = transform.localScale;
        timer = Random.Range(0f, Mathf.PI * 2);  // Randomize start phase for natural look
    }

    void Update()
    {
        // Sinusoidal breathing effect
        float scaleFactor = Mathf.Lerp(minScale, maxScale, (Mathf.Sin(timer * speed) + 1.0f) / 2.0f);
        transform.localScale = initialScale * scaleFactor;

        // Increment timer to animate over time
        timer += Time.deltaTime;
    }
}