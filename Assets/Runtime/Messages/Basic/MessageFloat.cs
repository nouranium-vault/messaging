using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewFloatMessage", menuName = MenuNames.NOURANIUM_MESSAGING_BASIC + "Float Message")]
    public class MessageFloat : MessageWithData<float>
    { }
}