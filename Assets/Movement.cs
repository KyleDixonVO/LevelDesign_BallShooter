using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float degreesPerSecond = 15.0f;
    public float amplitude = 10.0f;
    public float frequency = 1.0f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = posOffset;
        tempPos.y += (Mathf.Sin(Time.fixedTime * Mathf.PI * frequency)) * amplitude;
        transform.position = tempPos;
    }
}
