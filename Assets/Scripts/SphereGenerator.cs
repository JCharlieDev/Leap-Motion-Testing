using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public void CreateFallingSphere()
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go.transform.position = new Vector3(0, 10, 0);
        go.AddComponent<Rigidbody>();

        print("Sphere is being generated");
    }
}
