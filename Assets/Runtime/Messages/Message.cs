using UnityEngine;
using UnityEngine.Events;
#if Sirenix
using Sirenix.OdinInspector;
#endif

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewMessage", menuName = MenuNames.NOURANIUM_MESSAGING + "Plain Message", order = 220)]
    public class Message : ScriptableObject
    {
        private int messageId = -1;

        public void OnEnable()
        {
            messageId = -1;
        }

        public void StartListening(UnityAction action)
        {
            if (messageId < 0)
                messageId = Server.CreateEvent();

            Server.AddListener(messageId, action);
        }

        public void StopListening(UnityAction action)
        {
            Server.RemoveListener(messageId, action);
        }

    #if Sirenix
        [Button]
        public void Send()
        {
            if (messageId < 0)
                return;

            Server.Send(messageId);
        }
    #endif
    }
}