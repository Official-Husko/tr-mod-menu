using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class MayaNPC : DialogueNPCBase
{
	private static MayaNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "MayaMinigames";

	public static MayaNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void NIKCFNPEDCC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Duplicate key found: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static MayaNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void GHNBBCELNJO()
	{
		ChallengesUI.BPBMLNJGGII(KGPJPILAHDE().EHHOHCPHAAO).OpenUI();
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	[SpecialName]
	public static MayaNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	public void NKAKLLLLFPH()
	{
		ChallengesUI.OHPNDOJNCBK(MAIDHAPANEB().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void OCMHCNKLEKB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("itemBitterHopsSeeds");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static MayaNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		noPortrait = true;
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "Castle/Escribas/Intro";
		}
		else
		{
			dialogue.conversation = "Castle/Escribas/Stand";
		}
	}

	public void BPMGNHDMGFP()
	{
		ChallengesUI.OHPNDOJNCBK(KGPJPILAHDE().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void HFFFFAJFIPB()
	{
		SelectDialogueUI();
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public static MayaNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	private void JPOLFKMLHNH()
	{
		SelectDialogueUI();
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void JBIGADEMJND()
	{
		ChallengesUI.OHPNDOJNCBK(MAIDHAPANEB().EHHOHCPHAAO).OpenUI();
	}

	public void FHJABMLPALJ()
	{
		ChallengesUI.JHOHGMODKGM(MAIDHAPANEB().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void IFAHANGPJIL()
	{
		ChallengesUI.BPBMLNJGGII(OAPOJCODNCO().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void DEADBAIMHME()
	{
		ChallengesUI.JHOHGMODKGM(OAPOJCODNCO().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	private void CAIJLMJBMLA()
	{
		SelectDialogueUI(1);
	}

	private void KACEOJDPLKB()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static MayaNPC AJIGOHGPFPP()
	{
		return IADEMLIIDPC;
	}

	public void JECGJNDCMCG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Parent tech not learnt");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static MayaNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	private void IDPHKHGHJGN()
	{
		SelectDialogueUI();
	}

	public void IAFBFHALBJH(string emotion)
	{
		BGMJCCFNNDL().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static MayaNPC MPFJOKOJIOO()
	{
		return IADEMLIIDPC;
	}

	private void OLDDEAJMHNI()
	{
		SelectDialogueUI();
	}

	public void KIBIHBFJOJH(string emotion)
	{
		KGPJPILAHDE().emotionsController.StartEmotion(emotion);
	}

	public void CBABIIDFBHG()
	{
		ChallengesUI.BPBMLNJGGII(BGMJCCFNNDL().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void OpenChallengeUI()
	{
		ChallengesUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}
}
