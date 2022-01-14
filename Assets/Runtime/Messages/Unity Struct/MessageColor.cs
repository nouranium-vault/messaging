using UnityEngine;

namespace Nouranium
{
    [CreateAssetMenu(fileName = "NewColorMessage", menuName = MenuNames.NOURANIUM_MESSAGING_UNITY_STRUCT + "Color Message")]
    public class MessageColor : MessageWithData<Color>
    { }
}