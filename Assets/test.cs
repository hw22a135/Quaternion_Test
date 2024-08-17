using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Quaternion q;
    public Quaternion r;
    public float t;
    void Start()
    {
        float deg = 60 / 180 * Mathf.PI;
        q = Quaternion.AngleAxis(0.3f, Vector3.up);
        r = Quaternion.AngleAxis(30.0f, new Vector3(1, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * 0.01f;
        if (t > 1)
        {
            t = 0;
        }
        transform.rotation *= q;
    }
}
