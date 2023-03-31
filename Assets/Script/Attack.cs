using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator playerAnimator;
    private GameObject GO;
    private GantiScene Change;

    private void Awake()
    {
        GO = GameObject.Find("ChangeScene");
        Change = GO.GetComponent<GantiScene>();
    }

    public void PlayerAttack()
    {
        playerAnimator.SetTrigger("isAttack");
        Invoke(nameof(ChangeAfterAttack), 4.5f);
    }

    private void ChangeAfterAttack()
    {
        Change.ChangeMyScene("Ending");
    }
}
