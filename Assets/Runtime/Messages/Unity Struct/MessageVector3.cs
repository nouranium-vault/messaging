using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewVector3Message", menuName = MenuNames.NOURANIUM_MESSAGING_UNITY_STRUCT + "Vector3 Message")]
    public class MessageVector3 : MessageWithData<Vector3>
    { }
}