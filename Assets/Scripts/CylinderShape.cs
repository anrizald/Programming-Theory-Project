using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderShape : Shape
{
    public override void Jump()
    {
        rb.AddForce(Vector3.right * 20.0f, ForceMode.Impulse);
    }
}
