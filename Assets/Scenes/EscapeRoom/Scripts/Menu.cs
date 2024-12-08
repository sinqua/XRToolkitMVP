using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu: MonoBehaviour
{
    [field: SerializeField]
    public Button ResumeButton { get; private set; }

    [field: SerializeField]
    public Button RestartButton { get; private set; }

    [field: SerializeField]
    public TextMeshProUGUI SolvedText { get; private set; }

}