using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewVector4Message", menuName = MenuNames.NOURANIUM_MESSAGING_UNITY_STRUCT + "Vector4 Message")]
    public class MessageVector4 : MessageWithData<Vector4>
    { }
}