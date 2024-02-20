using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shape : MonoBehaviour, IPointerClickHandler
{
    protected Rigidbody rb;
    protected MeshRenderer m_MeshRenderer;
    private Material[] materials;
    [SerializeField] private Material m_Material;
    public static GameObject m_Selected { get; private set; } = null;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_MeshRenderer = GetComponent<MeshRenderer>();
        materials = m_MeshRenderer.materials;
        materials[0] = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ChangeMaterials();

        m_Selected = this.gameObject;
    }

    public virtual void Jump()
    {
        if (m_Selected != null)
            m_Selected.GetComponent<Rigidbody>().AddForce(Vector3.up * 5.0f, ForceMode.Impulse);
    }

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