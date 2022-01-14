using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Nouranium
{
    public static class Server
    {
        private static List<UnityEventBase> listeners;

        public static int CreateEvent<T>()
        {
            if (listeners == null)
                listeners = new List<UnityEventBase>();

            listeners.Add(new UnityEvent<T>());

            return listeners.Count - 1;
        }

        public static int CreateEvent()
        {
            if (listeners == null)
                listeners = new List<UnityEventBase>();

            listeners.Add(new UnityEvent());

            return listeners.Count - 1;
        }

        public static bool AddListener<T>(int messageId, UnityAction<T> action)
        {
            if (!IsEventInBounds(messageId))
                return false;

            if (!(listeners[messageId] is UnityEvent<T>))
            {
                Debug.LogError($"You are trying to add listener of type " +
                    $"'{action.GetType().GetGenericArguments()[0].Name}' to an event of type " +
                    $"'{listeners[messageId].GetType().GetGenericArguments()[0].Name}.'");
                return false;
            }

            ((UnityEvent<T>)listeners[messageId]).AddListener(action);

            return true;
        }

        public static bool AddListener(int messageId, UnityAction action)
        {
            if (!IsEventInBounds(messageId))
                return false;

            if (!(listeners[messageId] is UnityEvent))
            {
                Debug.LogError($"You are trying to add listener with no data to an event of type " +
                    $"'{listeners[messageId].GetType().GetGenericArguments()[0].Name}.'");
                return false;
            }

            ((UnityEvent)listeners[messageId]).AddListener(action);

            return true;
        }

        public static bool RemoveListener<T>(int messageId, UnityAction<T> action)
        {
            if (!IsEventInBounds(messageId))
                return false;

            if (!(listeners[messageId] is UnityEvent<T>))
            {
                Debug.LogError($"You are trying to remove listener of type " +
                    $"'{action.GetType().GetGenericArguments()[0].Name}' from an event of type " +
                    $"'{listeners[messageId].GetType().GetGenericArguments()[0].Name}.'");
                return false;
            }

            ((UnityEvent<T>)listeners[messageId]).RemoveListener(action);

            return true;
        }

        public static bool RemoveListener(int messageId, UnityAction action)
        {
            if (!IsEventInBounds(messageId))
                return false;

            if (!(listeners[messageId] is UnityEvent))
            {
                Debug.LogError($"You are trying to remove listener with no data from an event of type " +
                    $"'{listeners[messageId].GetType().GetGenericArguments()[0].Name}.'");
                return false;
            }

            ((UnityEvent)listeners[messageId]).RemoveListener(action);

            return true;
        }

        public static bool Send<T>(int messageId, T value)
        {
            if (!IsEventInBounds(messageId))
                return false;

            if (!(listeners[messageId] is UnityEvent<T>))
            {
                Debug.LogError($"You are trying to trigger an event of type " +
                    $"'{listeners[messageId].GetType().GetGenericArguments()[0].Name}' " +
                    $"with value of type '{value.GetType().Name}'.");
                return false;
            }

            ((UnityEvent<T>)listeners[messageId]).Invoke(value);

            return true;
        }

        public static bool Send(int messageId)
        {
            if (!IsEventInBounds(messageId))
                return false;

            if (!(listeners[messageId] is UnityEvent))
            {
                Debug.LogError($"You are trying to trigger an event of type " +
                    $"'{listeners[messageId].GetType().GetGenericArguments()[0].Name}' " +
                    $"with no data.");
                return false;
            }

            ((UnityEvent)listeners[messageId]).Invoke();

            return true;
        }

        private static bool IsEventInBounds(int messageId)
        {
            bool result = messageId >= 0 && messageId < listeners.Count;

            if (result)
                return true;
            else
            {
                Debug.LogError($"Couldn't find the event with ID of '{messageId}'. Did you forget to create the event?");
                return false;
            }
        }
    }
}