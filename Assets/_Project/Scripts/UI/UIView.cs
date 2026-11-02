using Core;
using UnityEngine;

namespace UI
{
    public class UIView : BaseMonobehaviour
    {
        [field: SerializeField] public Transform WindowsParent { get; private set; }
        [field: SerializeField] public GameplayUi GameplayUi { get; private set; }
    }
}
