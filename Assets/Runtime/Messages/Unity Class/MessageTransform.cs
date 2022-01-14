using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewTransformMessage", menuName = MenuNames.NOURANIUM_MESSAGING_UNITY_CLASS + "Transform Message")]
    public class MessageTransform : MessageWithData<Transform>
    { }
}