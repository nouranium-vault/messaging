using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nouranium;
public class ListenerManager : MonoBehaviour
{
    [SerializeReference]
    public List<IListener> listeners = new List<IListener>();
    
    private void Awake() {
        foreach (var listener in listeners)
        {
            listener.Init();
        }
    }
}
