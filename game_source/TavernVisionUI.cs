using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TavernVisionUI : MonoBehaviour
{
	private static TavernVisionUI IADEMLIIDPC;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private RectTransform content1;

	[SerializeField]
	private RectTransform content2;

	private bool LKOJBFMGMAE;

	private bool FHIDNCIFDLD;

	public static TavernVisionUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
			}
			return IADEMLIIDPC;
		}
	}

	private void CPDJNLCGEKO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.EAOOLEFMIKE())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = true;
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.MAIDHAPANEB().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 359f);
	}

	private void Start()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void PJOPLCIIFKO()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.IPBEEBLCHHA(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(AAMPLHFNKKD));
	}

	private void KACEOJDPLKB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(GDHMBGMDKIE));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(PHOKFNPDHLG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void AGMLGNDDINL()
	{
		TavernVisionManager.GetPlayer(2).IKNOJDMCFOK = false;
		if (TavernVisionManager.GetPlayer(1).IKNOJDMCFOK)
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(false);
		((Component)content2).gameObject.SetActive(false);
	}

	private void LHIFBLELKNA(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 6), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 6), (float)DEIHFLFENJI);
	}

	private void JDHHJKBOJML()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void BFJOEMCBJJO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void LOHAMDHOLDD()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(GDHMBGMDKIE));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}

	[SpecialName]
	public static TavernVisionUI KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void PHOKFNPDHLG()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.GBBEJMADEJC(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(DFABKCDHIFN));
	}

	private void OMHJIHBDOLP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.GGFJGHHHEJC.IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1356f);
	}

	private void AJNIGNJENBD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = false;
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.DIHCEGINELM().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowClose), HOMFPAFAOGD: false, null, null, 475f);
	}

	private void BGDGLGBLNDI()
	{
		TavernVisionManager player = TavernVisionManager.GetPlayer(1);
		player.OnVisionActivate = (Action<int, bool>)Delegate.Combine(player.OnVisionActivate, new Action<int, bool>(SetOpen));
	}

	private void DCKKIDMJKJM()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(FJKACAOAFBE));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GHCBONGCKEG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(ANMKBHKHABF));
	}

	[SpecialName]
	public static TavernVisionUI JCMKNNOEONP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void KDFEFGDGBEP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			LKOJBFMGMAE = false;
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			FHIDNCIFDLD = true;
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.GGFJGHHHEJC.LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1606f);
	}

	public void OHFCIKGJIIB(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 0 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 3 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				ADPNBDFHKLB(JIIGOACEIKL);
			}
			else
			{
				OMANIFJIOEB(JIIGOACEIKL);
			}
		}
	}

	private void OnDestroy()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	public void ILKOHOFKGOG(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 1 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 2 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				HPLFLOKOGGB(JIIGOACEIKL);
			}
			else
			{
				JJGCNAPMLBA(JIIGOACEIKL);
			}
		}
	}

	private void LGGCIFACOHF()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.JOFDIPFMIHF(1);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(DOBNNJBNABM));
	}

	[SpecialName]
	public static TavernVisionUI MIGKKKELOJO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void KILOFKAGFBC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			LKOJBFMGMAE = false;
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	private void PGEGODAEBLC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void EBNENBFLEKB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(LGGCIFACOHF));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(MMIHAKBBLOL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}

	private void HGHMEFIMFKD()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.DAEEJGKLOCF(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(OHFCIKGJIIB));
	}

	[SpecialName]
	public static TavernVisionUI PDECKLKPKCG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void KIGBMAHCMAE(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 1 - 7), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 4 - 1), (float)DEIHFLFENJI);
	}

	public void AAMPLHFNKKD(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 0 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 7 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				ADPNBDFHKLB(JIIGOACEIKL);
			}
			else
			{
				IEIIHONBOGI(JIIGOACEIKL);
			}
		}
	}

	private void EFEJCAHCIFJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = false;
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = true;
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.BNBMNOMFFBE().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: true, null, null, 1027f);
	}

	private void PGJJBPALEGM()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(HGHMEFIMFKD));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(KDFJOPIJKND));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void HINGECEDJAP()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void CNFKOMPBEOC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			LKOJBFMGMAE = false;
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = true;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.BNBMNOMFFBE().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowClose), HOMFPAFAOGD: false, null, null, 378f);
	}

	private void OGEJKOIOKAN()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void OAEJGGFFCBO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void HADCIGKNFKK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TavernVisionManager player = TavernVisionManager.GetPlayer(2);
		player.OnVisionActivate = (Action<int, bool>)Delegate.Combine(player.OnVisionActivate, new Action<int, bool>(SetOpen));
		((Component)content).gameObject.SetActive(false);
		if (TavernVisionManager.GetPlayer(1).IKNOJDMCFOK)
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 2 - 6), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 2 - 6), (float)Screen.height);
	}

	private void HPLFLOKOGGB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			LKOJBFMGMAE = true;
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = true;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	private void GPBFKKHJLHN()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.IPBEEBLCHHA(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(ILKOHOFKGOG));
	}

	private void JJGCNAPMLBA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.EAOOLEFMIKE())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = true;
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.ABDJJBFNLBJ().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: false, null, null, 1437f);
	}

	public void DOBNNJBNABM(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 0 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 7 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				OMHJIHBDOLP(JIIGOACEIKL);
			}
			else
			{
				EFEJCAHCIFJ(JIIGOACEIKL);
			}
		}
	}

	private void GJALMMAPDAD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.NBFLEJHLGNB())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.DIHCEGINELM().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1866f);
	}

	private void GCKOBACAAID()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.LJCKMLJJLKA(1);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(SetOpen));
	}

	private void OMANIFJIOEB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.ABDJJBFNLBJ().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: false, null, null, 194f);
	}

	private void NLPOBLFPDGL(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 1 - 0), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 3), (float)DEIHFLFENJI);
	}

	private void DCMLJNBJNEG()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TavernVisionManager player = TavernVisionManager.GetPlayer(2);
		player.OnVisionActivate = (Action<int, bool>)Delegate.Combine(player.OnVisionActivate, new Action<int, bool>(AAMPLHFNKKD));
		((Component)content).gameObject.SetActive(false);
		if (TavernVisionManager.DAEEJGKLOCF(1).GBELBKHAJGG())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 5 - 2), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 1 - 5), (float)Screen.height);
	}

	private void FEDNNNEHFKM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TavernVisionManager tavernVisionManager = TavernVisionManager.KBJLDHILLKH(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(OHFCIKGJIIB));
		((Component)content).gameObject.SetActive(false);
		if (TavernVisionManager.LJCKMLJJLKA(0).ALHHOHLOLBO())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 3 - 0), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 5 - 1), (float)Screen.height);
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void COKBJNMAMDI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static TavernVisionUI EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void HMOMBAFIJAI()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(GCKOBACAAID));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(GHCBONGCKEG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(ANMKBHKHABF));
	}

	private void MMIHAKBBLOL()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TavernVisionManager tavernVisionManager = TavernVisionManager.BCIIIGAFBMB(2);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(OBNKPKKGAML));
		((Component)content).gameObject.SetActive(true);
		if (TavernVisionManager.DAEEJGKLOCF(0).NJNLDBFONEA())
		{
			((Component)content1).gameObject.SetActive(false);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 3 - 5), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 5 - 5), (float)Screen.height);
	}

	private void GECHJIGBPEN()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static TavernVisionUI NGIMIHFFNMH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void GHCBONGCKEG()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TavernVisionManager tavernVisionManager = TavernVisionManager.HNFFIIOOJLN(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(ILKOHOFKGOG));
		((Component)content).gameObject.SetActive(true);
		if (TavernVisionManager.LJCKMLJJLKA(0).LKBKNFBAOCP())
		{
			((Component)content1).gameObject.SetActive(false);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 7 - 0), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 8 - 2), (float)Screen.height);
	}

	private void ILCBKEIEOAN()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(HGHMEFIMFKD));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KDFJOPIJKND));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}

	private void ADPNBDFHKLB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			LKOJBFMGMAE = true;
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.ABDJJBFNLBJ().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowOpen), HOMFPAFAOGD: false, null, null, 639f);
	}

	private void HCAOEKOEAGJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.EAOOLEFMIKE())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.ABDJJBFNLBJ().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowClose), HOMFPAFAOGD: false, null, null, 1262f);
	}

	public void OBNKPKKGAML(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 1 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 7 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				OMHJIHBDOLP(JIIGOACEIKL);
			}
			else
			{
				HCAOEKOEAGJ(JIIGOACEIKL);
			}
		}
	}

	private void GJMLHECPGBP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(KIGBMAHCMAE));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(PHOKFNPDHLG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(MMIHAKBBLOL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}

	private void ANMKBHKHABF()
	{
		TavernVisionManager.KBJLDHILLKH(1).FJDHDFCIDPA(AODONKKHPBP: false);
		if (TavernVisionManager.BPDFMAEOGGC(0).KHJOICBMIKN())
		{
			((Component)content).gameObject.SetActive(false);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(true);
	}

	private void FCOHKDOHJEA()
	{
		TavernVisionManager.HNFFIIOOJLN(7).NIIOPJDKCEI(AODONKKHPBP: true);
		if (TavernVisionManager.GBBEJMADEJC(1).GBELBKHAJGG())
		{
			((Component)content).gameObject.SetActive(false);
		}
		((Component)content1).gameObject.SetActive(false);
		((Component)content2).gameObject.SetActive(false);
	}

	private void GDHMBGMDKIE(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 4), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 1 - 0), (float)DEIHFLFENJI);
	}

	private void EGHOIJHBDBP()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(GCKOBACAAID));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KDFJOPIJKND));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(ANMKBHKHABF));
	}

	private void BNIKICAEIND()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(NLPOBLFPDGL));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(DCMLJNBJNEG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}

	[SpecialName]
	public static TavernVisionUI NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void MGGJJHFIFOM()
	{
		TavernVisionManager.BPDFMAEOGGC(2).GNCLKGFGHMO(AODONKKHPBP: false);
		if (TavernVisionManager.JOFDIPFMIHF(0).LKAALEEMINC())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(false);
		((Component)content2).gameObject.SetActive(true);
	}

	private void LIIOKGONMFO()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.CPOONCIFDIC(0);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(AAMPLHFNKKD));
	}

	private void KDFJOPIJKND()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TavernVisionManager tavernVisionManager = TavernVisionManager.HNFFIIOOJLN(4);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(SetOpen));
		((Component)content).gameObject.SetActive(true);
		if (TavernVisionManager.CMDGPJEIIJI(1).NJNLDBFONEA())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 4 - 5), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 1 - 2), (float)Screen.height);
	}

	private void FLFBLIOOLMA()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(LGGCIFACOHF));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(DCMLJNBJNEG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}

	public void DFABKCDHIFN(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 0 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 6 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				HPLFLOKOGGB(JIIGOACEIKL);
			}
			else
			{
				CNFKOMPBEOC(JIIGOACEIKL);
			}
		}
	}

	private void LNPDALMANFB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void HEEADKHHIDG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			LKOJBFMGMAE = true;
			if (GameManager.NBFLEJHLGNB())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.OKAPNFPFPFP().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowClose), HOMFPAFAOGD: true, null, null, 199f);
	}

	private void NADLJJKPFEL()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.IFGBDFBGAED(1);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(DOBNNJBNABM));
	}

	[SpecialName]
	public static TavernVisionUI JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernVisionUI>();
		}
		return IADEMLIIDPC;
	}

	private void IEIIHONBOGI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			LKOJBFMGMAE = true;
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			FHIDNCIFDLD = false;
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.ABDJJBFNLBJ().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowClose), HOMFPAFAOGD: true, null, null, 1607f);
	}

	public void SetOpen(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if ((JIIGOACEIKL != 1 || LKOJBFMGMAE != NKFPJPCFBJI) && (JIIGOACEIKL != 2 || FHIDNCIFDLD != NKFPJPCFBJI))
		{
			if (NKFPJPCFBJI)
			{
				HPLFLOKOGGB(JIIGOACEIKL);
			}
			else
			{
				KILOFKAGFBC(JIIGOACEIKL);
			}
		}
	}

	private void MFMMHDPGCBO()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(KIGBMAHCMAE));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(GPBFKKHJLHN));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(FCOHKDOHJEA));
	}

	private void FJKACAOAFBE()
	{
		TavernVisionManager tavernVisionManager = TavernVisionManager.DAEEJGKLOCF(1);
		tavernVisionManager.OnVisionActivate = (Action<int, bool>)Delegate.Combine(tavernVisionManager.OnVisionActivate, new Action<int, bool>(OBNKPKKGAML));
	}

	private void LJLKBKEADGI()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(GDHMBGMDKIE));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(GCKOBACAAID));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GHCBONGCKEG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void CLNBMOPMNOF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void NOILIOLOOBJ()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(PJOPLCIIFKO));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(MMIHAKBBLOL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(MGGJJHFIFOM));
	}
}
