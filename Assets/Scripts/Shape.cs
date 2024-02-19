using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shape : MonoBehaviour, IPointerClickHandler
{
    protected Rigidbody rb;
    protected MeshRenderer m_MeshRenderer;
    // private GameObject m_Selected;
    private Material[] materials;
    [SerializeField] private Material m_Material;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_MeshRenderer = GetComponent<MeshRenderer>();
        materials = m_MeshRenderer.materials;
        materials[0] = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Jump();
        ChangeMaterials();
    }

    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * 5.0f, ForceMode.Impulse);
    }

    // public virtual void SelectShape()
    // {
    //     m_Selected = gameObject;
    // }

    public virtual void ChangeMaterials()
    {
        if (materials[0] != null)
        {
            materials[0] = null;
            m_MeshRenderer.materials = materials;
        }
        else
        {
            materials[0] = m_Material;
            m_MeshRenderer.materials = materials;
        }
    }
}
