using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reveal : MonoBehaviour
{
    [SerializeField] Material Mat;
    [SerializeField] Light LightSource;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Mat.SetVector("MyLightPosition", LightSource.transform.position);
        Mat.SetVector("MyLightDirection", -LightSource.transform.forward);
        Mat.SetFloat("MyLightAngle", LightSource.spotAngle);
    }
}
