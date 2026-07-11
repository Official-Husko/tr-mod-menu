using UnityEngine;

public class ChangePlayerColor : StateMachineBehaviour
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		if ((Object)(object)MainUI.openedWindow != (Object)null)
		{
			ONDMDLMHMHK.SetInteger("PlayerNum", MainUI.openedWindow.JIIGOACEIKL);
		}
		else
		{
			ONDMDLMHMHK.SetInteger("PlayerNum", (((Component)ONDMDLMHMHK).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		}
	}
}
