using System;
using System.Collections;
using System.Collections.Generic;
using Nouranium;
using UnityEngine;
using UnityEngine.Events;

public class MessageBoolListener : MonoBehaviour
{
    [SerializeField] private MessageBool message;
    public UnityEvent<bool> onListen;

    private void Awake()
    {
        message.StartListening(OnListen);
    }

    private void OnListen(bool value)
    {
        onListen.Invoke(value);
    }
}
