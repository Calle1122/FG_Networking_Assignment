using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using UnityEngine;

public class NameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] Name name;
    
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = name.playerName.Value.Value;
    }
}
