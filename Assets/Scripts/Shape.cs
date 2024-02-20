using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shape : MonoBehaviour, IPointerClickHandler
{
    protected Rigidbody rb;
    protected MeshRenderer m_MeshRenderer;
    private Material[] materials;
    [SerializeField] private Material m_Material;
    public static GameObject m_Selected { get; private set; } = null;
    private static Shape s_LastSelected;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_MeshRenderer = GetComponent<MeshRenderer>();
        materials = m_MeshRenderer.materials;
        materials[0] = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (m_Selected == this.gameObject)
        {
            DeSelect();
        }
        else
        {
            Select();
        }
    }

    private void Select()
    {
        if (s_LastSelected != null)
        {
            s_LastSelected.DeSelect();
        }

        m_Selected = this.gameObject;
        s_LastSelected = this;

        ChangeMaterials();
    }
    private void DeSelect()
    {
        m_Selected = null;

        materials[0] = null;
        m_MeshRenderer.materials = materials;
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