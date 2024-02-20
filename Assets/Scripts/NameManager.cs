using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameManager : MonoBehaviour
{
    public TextMeshProUGUI CurrentPlayerName;

    void Start()
    {
        CurrentPlayerName.text = $"Name: {DataManager.Instance.PlayerName}";
    }
}
