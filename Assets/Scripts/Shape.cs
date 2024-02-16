using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shape : MonoBehaviour, IPointerClickHandler
{
    protected Rigidbody rb;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Jump();
    }

    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * 5.0f, ForceMode.Impulse);

    }
}
