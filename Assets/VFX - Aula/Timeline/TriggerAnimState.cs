using UnityEngine;

public class TriggerAnimState : MonoBehaviour
{
    [SerializeField] private Animator unityChanAnimator;
    [SerializeField] private int currentAnim = 0;

    public void AutoIncrementCombo()
    {
        currentAnim++;
        if(currentAnim > 3) currentAnim = 0;
        unityChanAnimator.SetInteger("Seq", currentAnim);
    }
}
