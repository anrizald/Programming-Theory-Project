using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : Shape
{
    public override void Jump()
    {
        rb.AddForce(Vector3.up * 20.0f, ForceMode.Impulse);
    }
}