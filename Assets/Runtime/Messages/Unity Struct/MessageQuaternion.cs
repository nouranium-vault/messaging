using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewQuaternionMessage", menuName = MenuNames.NOURANIUM_MESSAGING_UNITY_STRUCT + "Quaternion Message")]
    public class MessageQuaternion : MessageWithData<Quaternion>
    { }
}