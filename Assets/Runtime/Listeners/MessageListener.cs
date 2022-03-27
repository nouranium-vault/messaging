using System;
using System.Collections;
using System.Collections.Generic;
using Nouranium;
using UnityEngine;
using UnityEngine.Events;

public class MessageListener : MonoBehaviour
{
    [SerializeField] private Message message;
    public UnityEvent onListen;

    private void Awake()
    {
        message.StartListening(OnListen);
    }

    private void OnListen()
    {
        onListen.Invoke();
    }
}
