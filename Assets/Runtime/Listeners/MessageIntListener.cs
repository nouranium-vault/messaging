using System;
using System.Collections;
using System.Collections.Generic;
using Nouranium;
using UnityEngine;
using UnityEngine.Events;

public class MessageIntListener : MonoBehaviour
{
    [SerializeField] private MessageInt message;
    public UnityEvent<int> onListen;

    private void Awake()
    {
        message.StartListening(OnListen);
    }

    private void OnListen(int value)
    {
        onListen.Invoke(value);
    }
}
