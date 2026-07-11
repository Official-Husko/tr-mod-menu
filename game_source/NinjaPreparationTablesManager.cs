using System.Runtime.CompilerServices;
using UnityEngine;

public class NinjaPreparationTablesManager : MonoBehaviour
{
	public static NinjaPreparationTablesManager instance;

	public NinjaPreparationTable[] preparationTables;

	[SerializeField]
	private OccupyNodesWithColliders occupyNodesWithColliders;

	public NinjaPreparationTable DBKLEIEAAIF => preparationTables[0];

	private void LOHAMDHOLDD()
	{
		if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-31)))
		{
			OFJFCHEFCCB();
		}
	}

	[SpecialName]
	public NinjaPreparationTable OHNMEAFHDPD()
	{
		return preparationTables[1];
	}

	public void JDAOBKLGEMG(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i++)
		{
			preparationTables[i].ODNKBJCNBCG(CDPAMNIPPEC);
		}
	}

	public void GPLHBPKDLHH(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	[SpecialName]
	public NinjaPreparationTable FHEAPFBMJNL()
	{
		return preparationTables[0];
	}

	public void PPKBHFCGFAJ(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	public void ActivatePreparationTables()
	{
		ShowPreparationTables(1);
		HidePreparationTables(2);
		HidePreparationTables(3);
		HidePreparationTables(4);
		if (GameManager.LocalCoop())
		{
			ShowPreparationTables(2);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i <= 4; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					ShowPreparationTables(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
				}
			}
		}
		occupyNodesWithColliders.CheckAllNodes();
	}

	private void Awake()
	{
		instance = this;
	}

	public void KMGCNJPKDGK(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].LOMGGOKKOBJ(CDPAMNIPPEC);
		}
	}

	private void IAAGKLPMAMK()
	{
		if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)(-168)))
		{
			HDMLIMCNGPG();
		}
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void Start()
	{
		if (EventsManager.IsActive(EventsManager.EventType.NinjaChallengeEvent))
		{
			ActivatePreparationTables();
		}
	}

	public void BECONHHDODD(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i++)
		{
			preparationTables[i].DHELCFKBEKJ(CDPAMNIPPEC);
		}
	}

	public void OANGIFCNJAN(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i++)
		{
			preparationTables[i].ResetBento(CDPAMNIPPEC);
		}
	}

	public void LLIIHONDONI(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	public void FPIHDFNDHDI(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].DHELCFKBEKJ(CDPAMNIPPEC);
		}
	}

	public void ShowPreparationTables(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	public void DAHFGKKHIJE(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	public void LPGGAOIMLFC()
	{
		AALLFJNPBDM(1);
		BEECOOJHIIE(4);
		HidePreparationTables(4);
		PPKBHFCGFAJ(8);
		if (GameManager.LocalCoop())
		{
			KBEMCCLIGIO(5);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i <= 2; i += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					HMIAIGLCFEH(OnlinePlayerDataManager.JBDEFDMGCDA(i));
				}
			}
		}
		occupyNodesWithColliders.KPIBCIBOGEB();
	}

	private void CEIIFHIBIFI()
	{
		if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)128))
		{
			OFJFCHEFCCB();
		}
	}

	private void EGACIHOKJLH()
	{
		if (EventsManager.IKCEIJMLNOP(EventsManager.EventType.ThroneRoom))
		{
			GDEBPAJIHEK();
		}
	}

	[SpecialName]
	public NinjaPreparationTable FGGFCAKOPLJ()
	{
		return preparationTables[0];
	}

	private void BDJKNKIOPIJ()
	{
		if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)(-185)))
		{
			GDEBPAJIHEK();
		}
	}

	public void HidePreparationTables(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(false);
	}

	public void FGCJKGNNFEI()
	{
		LLIIHONDONI(1);
		PPKBHFCGFAJ(1);
		BEECOOJHIIE(6);
		PPKBHFCGFAJ(4);
		if (GameManager.LocalCoop())
		{
			FNOJDLHFGDJ(6);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 2; i += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					GNBACLEPJLH(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
				}
			}
		}
		occupyNodesWithColliders.CPABCHCKDEM();
	}

	public void GDEBPAJIHEK()
	{
		FNOJDLHFGDJ(0);
		PPKBHFCGFAJ(1);
		HidePreparationTables(5);
		HidePreparationTables(5);
		if (GameManager.LocalCoop())
		{
			GNBACLEPJLH(0);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i <= 8; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
				{
					DIIGHPGIDDJ(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
				}
			}
		}
		occupyNodesWithColliders.MCIPNFIPCFL();
	}

	public void CGKJIPHNNGI(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].LOMGGOKKOBJ(CDPAMNIPPEC);
		}
	}

	public void NECKJEDKIPM(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i++)
		{
			preparationTables[i].NFIBMPJGKPO(CDPAMNIPPEC);
		}
	}

	public void OFJFCHEFCCB()
	{
		DIIGHPGIDDJ(0);
		BEECOOJHIIE(2);
		PPKBHFCGFAJ(8);
		BEECOOJHIIE(6);
		if (GameManager.LocalCoop())
		{
			AALLFJNPBDM(1);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 4; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					AALLFJNPBDM(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
				}
			}
		}
		occupyNodesWithColliders.IJONBNOEEIP();
	}

	public void APFJLHGAMNE(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i++)
		{
			preparationTables[i].NFIBMPJGKPO(CDPAMNIPPEC);
		}
	}

	private void IMIONHLAKIH()
	{
		if (EventsManager.CJMECHEOFOF((EventsManager.EventType)(-105)))
		{
			GDEBPAJIHEK();
		}
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	public void KBEMCCLIGIO(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(false);
	}

	public void DIIGHPGIDDJ(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	private void JPHEOLEEAPB()
	{
		if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)(-39)))
		{
			HDMLIMCNGPG();
		}
	}

	[SpecialName]
	public NinjaPreparationTable ENGNLMOPIHL()
	{
		return preparationTables[1];
	}

	public void HJPOHMMNPED(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(false);
	}

	public void HMIAIGLCFEH(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	public void ResetAllBentos(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i++)
		{
			preparationTables[i].ResetBento(CDPAMNIPPEC);
		}
	}

	public void PNECPJLGKOA(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].DHELCFKBEKJ(CDPAMNIPPEC);
		}
	}

	[SpecialName]
	public NinjaPreparationTable MLELLLKKOMG()
	{
		return preparationTables[1];
	}

	public void GNBACLEPJLH(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(false);
	}

	public void CADKMOIHCEL(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i++)
		{
			preparationTables[i].NFIBMPJGKPO(CDPAMNIPPEC);
		}
	}

	[SpecialName]
	public NinjaPreparationTable PJIFGJMGKEH()
	{
		return preparationTables[1];
	}

	public void BEECOOJHIIE(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	public void FCKPEBPBDLC()
	{
		DAHFGKKHIJE(0);
		PPKBHFCGFAJ(4);
		PPKBHFCGFAJ(7);
		HidePreparationTables(0);
		if (GameManager.LocalCoop())
		{
			DAHFGKKHIJE(5);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i <= 6; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
				{
					FNOJDLHFGDJ(OnlinePlayerDataManager.JBDEFDMGCDA(i));
				}
			}
		}
		occupyNodesWithColliders.MHEECOJKLPJ();
	}

	[SpecialName]
	public NinjaPreparationTable KHGGPJGKFDC()
	{
		return preparationTables[1];
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	public void ACFFFEBHADJ(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i++)
		{
			preparationTables[i].NFIBMPJGKPO(CDPAMNIPPEC);
		}
	}

	public void HDMLIMCNGPG()
	{
		HJPOHMMNPED(1);
		GPLHBPKDLHH(4);
		BEECOOJHIIE(2);
		PPKBHFCGFAJ(0);
		if (GameManager.LocalCoop())
		{
			AALLFJNPBDM(2);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 2; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					ShowPreparationTables(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i));
				}
			}
		}
		occupyNodesWithColliders.GPAJBAKJADO();
	}

	private void OAEJGGFFCBO()
	{
		instance = this;
	}

	public void AALLFJNPBDM(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(true);
	}

	private void OCJOAHDNDIJ()
	{
		instance = this;
	}

	[SpecialName]
	public NinjaPreparationTable OFNGHKHHMOF()
	{
		return preparationTables[0];
	}

	[SpecialName]
	public NinjaPreparationTable ICPIHMPFMPO()
	{
		return preparationTables[1];
	}

	private void GNGADDPBJDC()
	{
		if (EventsManager.NJBACCBIHID(EventsManager.EventType.GoToHotSpring))
		{
			HDMLIMCNGPG();
		}
	}

	public void FGEIPACJGEK(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].ODNKBJCNBCG(CDPAMNIPPEC);
		}
	}

	public void JIJNHNNPJGB(bool CDPAMNIPPEC)
	{
		for (int i = 1; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].FIIDHPOHNEK(CDPAMNIPPEC);
		}
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void HCEDMLJNOBL()
	{
		if (EventsManager.IsActive((EventsManager.EventType)175))
		{
			LPGGAOIMLFC();
		}
	}

	public void FNOJDLHFGDJ(int JIIGOACEIKL)
	{
		((Component)preparationTables[JIIGOACEIKL]).gameObject.SetActive(false);
	}

	public void HPOAOFACFOA(bool CDPAMNIPPEC)
	{
		for (int i = 0; i < preparationTables.Length; i += 0)
		{
			preparationTables[i].KAIKNOMEIHB(CDPAMNIPPEC);
		}
	}
}
