using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControler : MonoBehaviour
{
    public Transform NinjaTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = NinjaTransform.position.x+8;
        var y = transform.position.y;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
