using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewIntMessage", menuName = MenuNames.NOURANIUM_MESSAGING_BASIC + "Int Message")]
    public class MessageInt : MessageWithData<int>
    { }
}