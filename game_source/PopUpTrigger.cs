using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
	public string message;

	public bool selfTrigger = true;

	private TutorialPopUp FKHFBMFJKDM;

	private string HCAKKFEHANO(int JIIGOACEIKL)
	{
		return message;
	}

	public void OBJHCAMMDEN(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.NPDPMGEMCOJ(JIIGOACEIKL);
		TutorialManager.GGFJGHHHEJC.GGHMMAOGOFH(FKHFBMFJKDM);
	}

	private void EIHHJKFDCCC(Collider2D LGGCFCHOOMB)
	{
		if (selfTrigger)
		{
			if (((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveMoneyText"))
			{
				ShowPopUp(1);
			}
			else if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Open"))
			{
				PADOAKMGDJE(1);
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, BHAIMJJNNKA, null, null, AIOOLCMJBKE: true);
	}

	private void HBMDEHPHAPF()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, LGDCPKCGKMB, null);
	}

	public void DJCCNPOCHAO(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.EJOFDDPEGKC(JIIGOACEIKL);
		TutorialManager.GGFJGHHHEJC.GGHMMAOGOFH(FKHFBMFJKDM, MDNOOMBIFNN: false, BLKLCBCGHCN: true);
	}

	private void OLDDEAJMHNI()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, KOEMEGPLHEJ, null);
	}

	private string PJNMALKLGAM(int JIIGOACEIKL)
	{
		return message;
	}

	private void NHIJMGLJEHB(Collider2D LGGCFCHOOMB)
	{
		if (selfTrigger)
		{
			if (((Component)LGGCFCHOOMB).gameObject.CompareTag(" locked due to reputation level required is "))
			{
				FEKCGEIDABO(1);
			}
			else if (((Component)LGGCFCHOOMB).gameObject.CompareTag("SetNPCDirection"))
			{
				DJCCNPOCHAO(3);
			}
		}
	}

	private void DCKKIDMJKJM()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, HCAKKFEHANO, null, null, AIOOLCMJBKE: true);
	}

	private void CEIIFHIBIFI()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, NJFOIADNELD, null);
	}

	private string KOEMEGPLHEJ(int JIIGOACEIKL)
	{
		return message;
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (selfTrigger)
		{
			if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Player"))
			{
				ShowPopUp(1);
			}
			else if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Player2"))
			{
				ShowPopUp(2);
			}
		}
	}

	private void IDPJLIBONPF(Collider2D LGGCFCHOOMB)
	{
		if (selfTrigger)
		{
			if (((Component)LGGCFCHOOMB).gameObject.CompareTag("["))
			{
				NJDOPBFJMFM(1);
			}
			else if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Trying to add a player that's already on the list."))
			{
				NJDOPBFJMFM(4);
			}
		}
	}

	private string NJFOIADNELD(int JIIGOACEIKL)
	{
		return message;
	}

	private string PKOLNLEMFAI(int JIIGOACEIKL)
	{
		return message;
	}

	private string BHAIMJJNNKA(int JIIGOACEIKL)
	{
		return message;
	}

	private string LGDCPKCGKMB(int JIIGOACEIKL)
	{
		return message;
	}

	public void OJOGDDIHMNL(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.FHJPNCNNJNH(JIIGOACEIKL);
		TutorialManager.GGFJGHHHEJC.ShowPopUp(FKHFBMFJKDM, MDNOOMBIFNN: false, BLKLCBCGHCN: true);
	}

	private void JPOLFKMLHNH()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, PKOLNLEMFAI, null, null, AIOOLCMJBKE: true);
	}

	public void ShowPopUp(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.KKNDBMCIEBL = JIIGOACEIKL;
		TutorialManager.GGFJGHHHEJC.ShowPopUp(FKHFBMFJKDM, MDNOOMBIFNN: false, BLKLCBCGHCN: true);
	}

	public void AEBKHLILFNJ(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.KKNDBMCIEBL = JIIGOACEIKL;
		TutorialManager.GGFJGHHHEJC.AEBKHLILFNJ(FKHFBMFJKDM);
	}

	public void NJDOPBFJMFM(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.ANKHJNGOALF(JIIGOACEIKL);
		TutorialManager.GGFJGHHHEJC.AEBKHLILFNJ(FKHFBMFJKDM, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
	}

	private void KPFLAOALALM(Collider2D LGGCFCHOOMB)
	{
		if (selfTrigger)
		{
			if (((Component)LGGCFCHOOMB).gameObject.CompareTag("BathhouseTeleport"))
			{
				OJOGDDIHMNL(1);
			}
			else if (((Component)LGGCFCHOOMB).gameObject.CompareTag("quest_description_22"))
			{
				PADOAKMGDJE(2);
			}
		}
	}

	private void Start()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, HCAKKFEHANO, null);
	}

	public void PADOAKMGDJE(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.NPDPMGEMCOJ(JIIGOACEIKL);
		TutorialManager.GGFJGHHHEJC.ShowPopUp(FKHFBMFJKDM);
	}

	public void FEKCGEIDABO(int JIIGOACEIKL)
	{
		FKHFBMFJKDM.EJOFDDPEGKC(JIIGOACEIKL);
		TutorialManager.GGFJGHHHEJC.MKMBMGCKLCL(FKHFBMFJKDM, MDNOOMBIFNN: false);
	}

	private void KACEOJDPLKB()
	{
		FKHFBMFJKDM = new TutorialPopUp(-1, PJNMALKLGAM, null, null, AIOOLCMJBKE: true);
	}
}
