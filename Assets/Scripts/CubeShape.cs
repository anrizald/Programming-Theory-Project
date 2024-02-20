using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : Shape
{
    public override void Jump()
    {
        m_Selected.GetComponent<Rigidbody>().AddForce(Vector3.up * 20.0f, ForceMode.Impulse);
    }
}
