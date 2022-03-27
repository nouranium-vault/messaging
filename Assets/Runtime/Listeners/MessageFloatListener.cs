using System;
using System.Collections;
using System.Collections.Generic;
using Nouranium;
using UnityEngine;
using UnityEngine.Events;

public class MessageFloatListener : MonoBehaviour
{
    [SerializeField] private MessageFloat message;
    public UnityEvent<float> onListen;

    private void Awake()
    {
        message.StartListening(OnListen);
    }

    private void OnListen(float value)
    {
        onListen.Invoke(value);
    }
}
