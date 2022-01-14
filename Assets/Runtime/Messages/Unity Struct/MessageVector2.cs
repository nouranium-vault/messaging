using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewVector2Message", menuName = MenuNames.NOURANIUM_MESSAGING_UNITY_STRUCT + "Vector2 Message")]
    public class MessageVector2 : MessageWithData<Vector2>
    { }
}