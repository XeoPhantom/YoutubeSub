using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public TextMeshProUGUI subscriberText;
    public float autoClickRate = 1.0f; // Nombre d'abonnés ajoutés par seconde

    private int subscribers = 0;

    void Start()
    {
        InvokeRepeating("AutoClick", 0f, 1f / autoClickRate);
    }

    void AutoClick()
    {
        subscribers++;
        UpdateSubscriberText();
    }

    void UpdateSubscriberText()
    {
        subscriberText.text = subscribers + "  Subscibers ";
    }
}