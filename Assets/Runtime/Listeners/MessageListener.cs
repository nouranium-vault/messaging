using UnityEngine;
using UnityEngine.Events;

namespace Nouranium
{
    [System.Serializable]
    public class MessageListener : IListener
    {
        [SerializeField] private Message message;
        public UnityEvent onListen;

        public void Init()
        {
            message.StartListening(OnListen);
        }

        private void OnListen()
        {
            onListen.Invoke();
        }
    }
}