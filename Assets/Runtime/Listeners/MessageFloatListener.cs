using UnityEngine;
using UnityEngine.Events;

namespace Nouranium
{
    [System.Serializable]

    public class MessageFloatListener : IListener
    {
        [SerializeField] private MessageFloat message;
        public UnityEvent<float> onListen;

        public void Init()
        {
            message.StartListening(OnListen);
        }

        private void OnListen(float value)
        {
            onListen.Invoke(value);
        }
    }
}
