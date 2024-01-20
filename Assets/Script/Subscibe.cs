using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Subscibe : MonoBehaviour
{
    public TextMeshProUGUI subscriberText;
    public Button subscribeButton;

    private int subscribers = 0;

    void Start()
    {
        subscribeButton.onClick.AddListener(ClickSubscribe);
    }

    void ClickSubscribe()
    {
        subscribers++;
        UpdateSubscriberText();
    }

    void UpdateSubscriberText()
    {
        subscriberText.text = subscribers + "  Subscibers ";
    }
}