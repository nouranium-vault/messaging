using UnityEngine;
using UnityEngine.Events;

namespace Nouranium
{
    public class MessageWithData<T> : ScriptableObject
    {
        private int messageId = -1;
        public T value;

        public void OnEnable()
        {
            messageId = -1;
        }

        public void StartListening(UnityAction<T> action)
        {
            if (messageId < 0)
                messageId = Server.CreateEvent<T>();

            Server.AddListener(messageId, action);
        }

        public void StopListening(UnityAction<T> action)
        {
            Server.RemoveListener(messageId, action);
        }


        public void Send(T value)
        {
            if (messageId < 0)
                return;

            Server.Send(messageId, value);
        }
        
    #if ODIN_INSPECTOR || ODIN_INSPECTOR_3
        [Sirenix.OdinInspector.Button]
        public void Send(){
            Send(value);
        }
    #endif
    }
}