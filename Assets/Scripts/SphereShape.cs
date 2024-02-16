using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class SphereShape : Shape
{

    public override void Jump()
    {
        rb.AddForce(0.0f, 10.0f, 0.0f, ForceMode.Impulse);
    }
}
