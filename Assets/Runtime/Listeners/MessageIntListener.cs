using UnityEngine;
using UnityEngine.Events;

namespace Nouranium
{
    [System.Serializable]
    public class MessageIntListener : IListener
    {
        [SerializeField] private MessageInt message;
        public UnityEvent<int> onListen;

        public void Init()
        {
            message.StartListening(OnListen);
        }

        private void OnListen(int value)
        {
            onListen.Invoke(value);
        }
    }
}
