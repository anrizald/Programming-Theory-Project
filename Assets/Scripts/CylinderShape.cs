using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderShape : Shape
{
    public override void Jump()
    {
        m_Selected.GetComponent<Rigidbody>().AddForce(Vector3.right * 5.0f, ForceMode.Impulse);
    }
}
