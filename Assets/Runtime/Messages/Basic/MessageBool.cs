using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewBoolMessage", menuName = MenuNames.NOURANIUM_MESSAGING_BASIC + "Bool Message")]
    public class MessageBool : MessageWithData<bool>
    { }
}