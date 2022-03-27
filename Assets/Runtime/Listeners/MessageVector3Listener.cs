using System;
using System.Collections;
using System.Collections.Generic;
using Nouranium;
using UnityEngine;
using UnityEngine.Events;

public class MessageVector3Listener : MonoBehaviour
{
    [SerializeField] private MessageVector3 message;
    public UnityEvent<Vector3> onListen;

    private void Awake()
    {
        message.StartListening(OnListen);
    }

    private void OnListen(Vector3 value)
    {
        onListen.Invoke(value);
    }
}
