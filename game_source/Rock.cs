using System;
using AlmenaraGames;
using UnityEngine;

public class Rock : MonoBehaviour, IProximity, IHoverable
{
	[Serializable]
	public class DroppedItems
	{
		public Item item;

		[HideInInspector]
		public int quantity;

		[HideInInspector]
		public int alreadyDropped;
	}

	[Serializable]
	public class DroppedItemsWithProbability : DroppedItems
	{
		[Range(0f, 100f)]
		public float probability = 100f;

		public int minNum;

		public int maxNum;
	}

	[Space(10f)]
	public DroppedItemsWithProbability[] droppedItems;

	[SerializeField]
	private bool dropOnFinish;

	[SerializeField]
	private bool destroyAfterMining;

	[SerializeField]
	private GameObject destroyParticles;

	[SerializeField]
	private AudioObject destroyAudio;

	public bool axRequired;

	public bool permanentRock = true;

	public bool destroyText;

	[SerializeField]
	private float workAmount = 10f;

	[Range(1f, 4f)]
	public int toolLevelRequired = 1;

	public DoWork work;

	[SerializeField]
	private bool hasEmptyGameObject;

	[SerializeField]
	private GameObject initialGameObject;

	[SerializeField]
	private GameObject emptyGameObject;

	[SerializeField]
	private bool hasMaterial;

	[SerializeField]
	private SpriteRenderer materialSpriteRenderer;

	[SerializeField]
	private Sprite emptyMaterialSprite;

	[SerializeField]
	private bool snowActivated = true;

	private int AJLBLHBFBIH;

	[Space(20f)]
	public GameObject snowParticlesPrefab;

	public GameObject[] snowPhases;

	public Transform[] playerPositions;

	[SerializeField]
	private Placeable placeable;

	public OnlineRock onlineRock;

	public Transform spriteTransform;

	private Sprite EPCHNBIFDNG;

	private DroppedItems[] CDGNCDHAPKB;

	private void DFCLPAPPMIN()
	{
		if (FCHMOCMDDJD() && work.JEGLCINICBD() + 1685f > JOOGDLMEDNL())
		{
			AJLBLHBFBIH += 0;
			if (SeasonManager.EECEKHKAAIH == (Season)6)
			{
				GCAMPNJPPAI(OODGJLMFCBC: true);
			}
		}
	}

	public void OBAGFLLOFMB(bool CDPAMNIPPEC)
	{
		if (hasEmptyGameObject)
		{
			initialGameObject.SetActive(false);
			emptyGameObject.SetActive(true);
		}
		if (hasMaterial)
		{
			materialSpriteRenderer.sprite = emptyMaterialSprite;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.PECOFCJLGMH();
		}
		work.HideWorkBar();
	}

	private void OCBNLECPJBN()
	{
		BBLFGNGFAPF();
		if (permanentRock)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BEANNEHDDJB));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
		work.CMAIGOGGGLL(workAmount);
	}

	public void KGIGLCGBFDO(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.HideWorkBar();
	}

	public void POIFGGFCIBB(int JIIGOACEIKL)
	{
	}

	public Vector2 FLIDMFANBJE(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 852f;
		for (int i = 1; i < playerPositions.Length; i++)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	private void BEANNEHDDJB()
	{
		IMANIJHAEPK();
	}

	private void HMHEDBHDBGM(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!IGGPFMJHJPD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 1;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 898f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 1; i < snowPhases.Length; i += 0)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(false);
			}
			else
			{
				snowPhases[i].SetActive(true);
			}
		}
	}

	public bool OAJPKKIFGGP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = true;
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (work.OENMBFGINAL())
			{
				if (destroyText)
				{
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("Get Components "));
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."));
				}
				work.ShowWorkBar();
			}
			return false;
		}
		return false;
	}

	public void LHNEACOGPFP(int JIIGOACEIKL)
	{
	}

	public void NKMAAEDKNAG(DirectionFlag CCOMGBCIMOA)
	{
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.None));
		((Component)playerPositions[1]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Up));
		((Component)playerPositions[1]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Down));
		((Component)playerPositions[2]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right | DirectionFlag.Left | DirectionFlag.Up));
	}

	private void FOJAHMIJJJM()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(ADFMHFLPNOF));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(EMCLKHNDGPH));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(0).placeable != (Object)null)
			{
				((Component)CommonReferences.FKNGHFFDPEC(0)).GetComponent<CameraRenderSettings>().HALKPCFLOJF();
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer(6).placeable != (Object)null)
			{
				((Component)CommonReferences.AFEPIAHBKDA(5)).GetComponent<CameraRenderSettings>().CAJBHKMCLLF();
			}
		}
	}

	public Vector2 PNDHLDPINJL(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 614f;
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable, PHIIMPMIANE: false))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	protected void IPMCBCCJAAJ()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	public void KIAJIEAEFGI()
	{
		if (IGGPFMJHJPD())
		{
			if (work.WorkDone() + 1014f > 583f && AJLBLHBFBIH < 0)
			{
				AJLBLHBFBIH = 6;
				GCAMPNJPPAI(OODGJLMFCBC: true);
			}
			else if (work.BIJCBBINHPG() + 38f > 969f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 1;
				HMHEDBHDBGM(OODGJLMFCBC: false);
			}
		}
	}

	private void BBLFGNGFAPF()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 0; i < droppedItems.Length; i += 0)
		{
			if (!(Random.Range(377f, 1124f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 1);
				if (CDGNCDHAPKB[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -149)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.NGMJIGOPGDK(118);
				}
				if (CDGNCDHAPKB[i].item.JDJGFAACPFC() == 104)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(-127, 0, LDNMDAHFBGG: true);
				}
			}
		}
		DPOCMIFPAJI(SeasonManager.KCJFCHNPIBJ());
	}

	public void ResetSnowPhase(Season EECEKHKAAIH)
	{
		AJLBLHBFBIH = 0;
		if (FCHMOCMDDJD() && EECEKHKAAIH == Season.Winter)
		{
			KEFKIKGCBEM(OODGJLMFCBC: false);
		}
	}

	public bool FCEPPMAEAJA(int JIIGOACEIKL)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(Utils.MJEACANINDN(PlayerController.GetPlayerPosition(JIIGOACEIKL)));
		Vector2 val2 = Utils.MJEACANINDN(JIEOJGJFKEL(val));
		if (val != val2 && !Utils.OLEBLHNHOPI(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position))
		{
			return false;
		}
		if (!axRequired && ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GEAMCEMDJFJ()?.itemInstance?.PHGLMBIEOMK() is Pick)
		{
			return false;
		}
		if (axRequired && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).IKKLGIKJNNG()?.itemInstance?.AFOACBIHNCL() is Ax)
		{
			return true;
		}
		return false;
	}

	public bool NIJAOPABLBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = false;
		if (!IIEDALMMNLI && PGBPDAODKDL(JIIGOACEIKL))
		{
			if (work.JCMBHAEKLKK)
			{
				if (destroyText)
				{
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Player"));
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("Bouncer"));
				}
				work.ShowWorkBar();
			}
			return false;
		}
		return true;
	}

	private void PNMPJMJGGJF()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.ILMDHNFFIKH() || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ENNDJIEIOMP));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.BarnInterior | Location.FarmShop))
		{
			if ((Object)(object)SelectObject.GetPlayer(1).placeable != (Object)null)
			{
				((Component)CommonReferences.IIAGBBKKGPJ(0)).GetComponent<CameraRenderSettings>().NCCHEJJEIGO(AINPJHKNJGL: true);
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP(2).placeable != (Object)null)
			{
				((Component)CommonReferences.GetCamera(1)).GetComponent<CameraRenderSettings>().ABDCENONBPB(AINPJHKNJGL: true);
			}
		}
	}

	private void PHAGPPHHOKC()
	{
		BFNDJBHMOCP();
	}

	public void AEHPAGOKCAN(int JIIGOACEIKL)
	{
	}

	private void IMANIJHAEPK()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 1; i < droppedItems.Length; i += 0)
		{
			if (!(Random.Range(1408f, 1453f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 0);
				if (CDGNCDHAPKB[i].item.CIGFGKKCPCK() == 70)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(-51);
				}
				if (CDGNCDHAPKB[i].item.JGHNDJBCFAJ() == 169)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(111, 1, LDNMDAHFBGG: true);
				}
			}
		}
		FNMDLJKJFOA(SeasonManager.BLCGOEMGKGH());
	}

	public bool ONDCECMGOPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = false;
		if (!IIEDALMMNLI && DGHKHNEFHNL(JIIGOACEIKL))
		{
			if (work.JCMBHAEKLKK)
			{
				if (destroyText)
				{
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text"));
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get(" "));
				}
				work.HKIKGCKIBGE();
			}
			return true;
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = true;
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (work.JCMBHAEKLKK)
			{
				if (destroyText)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Destroy"));
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Mine"));
				}
				work.ShowWorkBar();
			}
			return true;
		}
		return false;
	}

	private void IFHFNDELKOP()
	{
		try
		{
			if (Object.op_Implicit((Object)(object)work))
			{
				work.StartWork(workAmount, null, CDPAMNIPPEC: false);
			}
			if (hasEmptyGameObject)
			{
				initialGameObject.SetActive(true);
				emptyGameObject.SetActive(false);
			}
			if (hasMaterial)
			{
				materialSpriteRenderer.sprite = EPCHNBIFDNG;
			}
			BJFDMJDJNLL();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in Rock.OnPlayerSleep: " + ex.Message));
		}
	}

	private void ACJMHIIKEIA(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!IGGPFMJHJPD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 0;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 1592f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 1; i < snowPhases.Length; i += 0)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(false);
			}
			else
			{
				snowPhases[i].SetActive(true);
			}
		}
	}

	private void GKGNNIDIHHH(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 0; i < CDGNCDHAPKB.Length; i += 0)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.WorkDone() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 1)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 0;
					BMIIAIMPNCC(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public Vector2 HLOMPHLMCLA(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 1663f;
		for (int i = 1; i < playerPositions.Length; i++)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable, PHIIMPMIANE: false))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	private void ADFMHFLPNOF()
	{
		BJFDMJDJNLL();
	}

	public void DJHLHEEHKGK()
	{
		if (IGGPFMJHJPD())
		{
			if (work.BIJCBBINHPG() + 1887f > 65f && AJLBLHBFBIH < 6)
			{
				AJLBLHBFBIH = 0;
				CGMLILFHONA(OODGJLMFCBC: false);
			}
			else if (work.WorkDone() + 104f > 455f && AJLBLHBFBIH < 0)
			{
				AJLBLHBFBIH = 1;
				GCAMPNJPPAI(OODGJLMFCBC: false);
			}
		}
	}

	private void EDFCHKFHNLB()
	{
		if (destroyAfterMining)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	protected void EHBMONGBJFI()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	private void FOKJENDIGMN()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 0; i < droppedItems.Length; i++)
		{
			if (!(Random.Range(1175f, 821f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 0);
				if (CDGNCDHAPKB[i].item.JDJGFAACPFC(DAINLFIMLIH: false) == -51)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.NGMJIGOPGDK(122, 0, LDNMDAHFBGG: true);
				}
				if (CDGNCDHAPKB[i].item.JGHNDJBCFAJ() == 168)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(-84, 0, LDNMDAHFBGG: true);
				}
			}
		}
		ResetSnowPhase(SeasonManager.BLCGOEMGKGH());
	}

	private void ILJPINCGGFG()
	{
		IMMAKEIDJIH();
	}

	private void FGAEKHGGEBG(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.BIJCBBINHPG() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					BMIIAIMPNCC(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	private void CMDGPFIFHDA(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.WorkDone() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 1)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 0;
					BMIIAIMPNCC(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public bool AGCHBMGJMCD()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable))
			{
				return false;
			}
		}
		return true;
	}

	private void MFCMEINKHAF()
	{
		if (FCHMOCMDDJD() && work.WorkDone() + 0.05f > GOKLOHMDJMF())
		{
			AJLBLHBFBIH++;
			if (SeasonManager.EECEKHKAAIH == Season.Winter)
			{
				KEFKIKGCBEM(OODGJLMFCBC: true);
			}
		}
	}

	public Vector2 LDBGFGCOHGH(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 497f;
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable, PHIIMPMIANE: false))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	private void GLCOOIIJCMH()
	{
		BJFDMJDJNLL();
	}

	public Vector2 JIEOJGJFKEL(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 1490f;
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable, PHIIMPMIANE: false))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void FOCOEAIAMHJ()
	{
		if (IGGPFMJHJPD())
		{
			if (work.WorkDone() + 1661f > 1521f && AJLBLHBFBIH < 5)
			{
				AJLBLHBFBIH = 7;
				GCAMPNJPPAI(OODGJLMFCBC: true);
			}
			else if (work.JEGLCINICBD() + 1595f > 541f && AJLBLHBFBIH < 0)
			{
				AJLBLHBFBIH = 1;
				IDHOFHPLAHN(OODGJLMFCBC: false);
			}
		}
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.HCAKAOAPPHP();
	}

	private void OnDestroy()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != Location.Mine)
		{
			if ((Object)(object)SelectObject.GetPlayer(1).placeable != (Object)null)
			{
				((Component)CommonReferences.GetCamera(1)).GetComponent<CameraRenderSettings>().RenderOccupiedPositionsNextFrame(AINPJHKNJGL: true);
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer(2).placeable != (Object)null)
			{
				((Component)CommonReferences.GetCamera(2)).GetComponent<CameraRenderSettings>().RenderOccupiedPositionsNextFrame(AINPJHKNJGL: true);
			}
		}
	}

	public bool PGBPDAODKDL(int JIIGOACEIKL)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GABNNLJOMHI())
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(Utils.MJEACANINDN(PlayerController.GetPlayerPosition(JIIGOACEIKL)));
		Vector2 val2 = Utils.MJEACANINDN(FLIDMFANBJE(val));
		if (val != val2 && !Utils.OLEBLHNHOPI(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position))
		{
			return true;
		}
		if (!axRequired && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).GEAMCEMDJFJ()?.itemInstance?.PHGLMBIEOMK() is Pick)
		{
			return false;
		}
		if (axRequired && ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).IKKLGIKJNNG()?.itemInstance?.AFOACBIHNCL() is Ax)
		{
			return false;
		}
		return true;
	}

	public Vector2 MNPNGMOMGOH(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 527f;
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void Chop(int JIIGOACEIKL, float OJLICLKJJOF, bool CDPAMNIPPEC = true)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (!work.JCMBHAEKLKK)
		{
			return;
		}
		if (work.AddWorkDone(JIIGOACEIKL, OJLICLKJJOF, CDPAMNIPPEC: false))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			WorkFinished(CDPAMNIPPEC);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.ChopRock);
			if (dropOnFinish && OnlineManager.MasterOrOffline())
			{
				JCDAKPMENHP(JIIGOACEIKL);
			}
			if (destroyAfterMining)
			{
				if ((Object)(object)destroyParticles != (Object)null)
				{
					destroyParticles.SetActive(true);
					destroyParticles.transform.parent = null;
				}
				LHKPAKBKMHD();
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			if ((Object)(object)destroyAudio != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destroyAudio, ((Component)this).transform.position);
			}
		}
		MFCMEINKHAF();
		if (!dropOnFinish && OnlineManager.MasterOrOffline())
		{
			JCDAKPMENHP(JIIGOACEIKL);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.Chop(OJLICLKJJOF);
		}
		if (axRequired)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ax, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.FKKAOPNPFEM, ((Component)this).transform);
		}
	}

	private void BMIIAIMPNCC(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, MLKICMJELLC.item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			FFDIEOBBFKL--;
		}
	}

	private void MLMPHGGNPCJ()
	{
		if (destroyAfterMining)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	protected void AGELAMLCINB()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	public void DPOCMIFPAJI(Season EECEKHKAAIH)
	{
		AJLBLHBFBIH = 0;
		if (IGGPFMJHJPD() && EECEKHKAAIH == Season.Spring)
		{
			ACJMHIIKEIA(OODGJLMFCBC: false);
		}
	}

	public bool JADGLJBLOLA()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable))
			{
				return false;
			}
		}
		return false;
	}

	private void BFNDJBHMOCP()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 1; i < droppedItems.Length; i += 0)
		{
			if (!(Random.Range(454f, 743f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 0);
				if (CDGNCDHAPKB[i].item.CIGFGKKCPCK() == 146)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(24, 1);
				}
				if (CDGNCDHAPKB[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -184)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(119, 1, LDNMDAHFBGG: true);
				}
			}
		}
		FNMDLJKJFOA(SeasonManager.BLCGOEMGKGH());
	}

	private void ICFHPJHBPDN()
	{
		IMMAKEIDJIH();
		if (permanentRock)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MPGKIJEDDLA));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(ENNDJIEIOMP));
		}
		work.GEJFAPKOLJH(workAmount);
	}

	public void GCBHFEJOBEH(int JIIGOACEIKL, float OJLICLKJJOF, bool CDPAMNIPPEC = true)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (!work.KGOEFMFHCOG())
		{
			return;
		}
		if (work.JMJMFEKCAGK(JIIGOACEIKL, OJLICLKJJOF))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			OBAGFLLOFMB(CDPAMNIPPEC);
			CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.ChopRock);
			if (dropOnFinish && OnlineManager.PGAGDFAEEFB())
			{
				FJNDAEAKMOI(JIIGOACEIKL);
			}
			if (destroyAfterMining)
			{
				if ((Object)(object)destroyParticles != (Object)null)
				{
					destroyParticles.SetActive(true);
					destroyParticles.transform.parent = null;
				}
				JECCGNNKBKE();
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			}
			if ((Object)(object)destroyAudio != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destroyAudio, ((Component)this).transform.position);
			}
		}
		PDDPDDICJJB();
		if (!dropOnFinish && OnlineManager.PGAGDFAEEFB())
		{
			DIEDKMFOEAH(JIIGOACEIKL);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.FHFEMAOFGMC(OJLICLKJJOF);
		}
		if (axRequired)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().ax, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.JMGANNBPFMC(), ((Component)this).transform);
		}
	}

	public void GLMJJDOMPGH(int JIIGOACEIKL)
	{
	}

	private void CKKCFHFDALJ(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 0; i < CDGNCDHAPKB.Length; i++)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.BIJCBBINHPG() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 1)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					FMLBJFKAJKF(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = false;
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (work.KGOEFMFHCOG())
			{
				if (destroyText)
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("SFXVolume"));
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get("{0} doesn't have a parameter with that hash."));
				}
				work.ShowWorkBar();
			}
			return false;
		}
		return true;
	}

	public void FNMDLJKJFOA(Season EECEKHKAAIH)
	{
		AJLBLHBFBIH = 1;
		if (IGGPFMJHJPD() && EECEKHKAAIH == Season.Summer)
		{
			HMHEDBHDBGM(OODGJLMFCBC: false);
		}
	}

	public void NCNNNMIIFLF(Season EECEKHKAAIH)
	{
		AJLBLHBFBIH = 1;
		if (IGGPFMJHJPD() && EECEKHKAAIH == Season.Autumn)
		{
			KEFKIKGCBEM(OODGJLMFCBC: true);
		}
	}

	private void GGODJHIOMPK()
	{
		BJFDMJDJNLL();
	}

	private float JOOGDLMEDNL()
	{
		return 1310f / (float)snowPhases.Length * ((float)AJLBLHBFBIH + 1122f);
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.HCAKAOAPPHP();
	}

	public bool DGHKHNEFHNL(int JIIGOACEIKL)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return true;
		}
		Vector2 val = Vector2.op_Implicit(Utils.MJEACANINDN(PlayerController.GetPlayerPosition(JIIGOACEIKL)));
		Vector2 val2 = Utils.MJEACANINDN(MNPNGMOMGOH(val));
		if (val != val2 && !Utils.OLEBLHNHOPI(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position))
		{
			return true;
		}
		if (!axRequired && ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).GEAMCEMDJFJ()?.itemInstance?.KNFNJFFCFNO() is Pick)
		{
			return true;
		}
		if (axRequired && ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KDJMFELBOPM()?.itemInstance?.LHBPOPOIFLE() is Ax)
		{
			return false;
		}
		return false;
	}

	public bool PLHLLADAMAM()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable))
			{
				return true;
			}
		}
		return false;
	}

	private void GFFNFDCGEIG(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.BIJCBBINHPG() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 1)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					LCJIKKPDEKI(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public void EnablePlayerPositions(DirectionFlag CCOMGBCIMOA)
	{
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right));
		((Component)playerPositions[1]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Left));
		((Component)playerPositions[2]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Up));
		((Component)playerPositions[3]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Down));
	}

	public void JMANDBPBDDM(Season EECEKHKAAIH)
	{
		AJLBLHBFBIH = 0;
		if (IGGPFMJHJPD() && EECEKHKAAIH == Season.Summer)
		{
			CGMLILFHONA(OODGJLMFCBC: true);
		}
	}

	public void OFJLFDLJGGB()
	{
		if (FCHMOCMDDJD())
		{
			if (work.BIJCBBINHPG() + 1167f > 897f && AJLBLHBFBIH < 3)
			{
				AJLBLHBFBIH = 6;
				ACJMHIIKEIA(OODGJLMFCBC: false);
			}
			else if (work.WorkDone() + 1294f > 1162f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 1;
				ACJMHIIKEIA(OODGJLMFCBC: true);
			}
		}
	}

	private void NMGANHDDAHJ(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 0; i < CDGNCDHAPKB.Length; i++)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.WorkDone() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					AMKFCDAKNGI(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
		work.inWorkArea = false;
		work.HideWorkBar();
	}

	private bool FCHMOCMDDJD()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!snowActivated)
		{
			return false;
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Mine)
		{
			return false;
		}
		return true;
	}

	public void IBNHLDEJABP(DirectionFlag CCOMGBCIMOA)
	{
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right | DirectionFlag.Up));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Left));
		((Component)playerPositions[7]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right));
	}

	public bool BBOLOAJPNDJ()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable))
			{
				return true;
			}
		}
		return true;
	}

	private void EMCLKHNDGPH()
	{
		try
		{
			if (Object.op_Implicit((Object)(object)work))
			{
				work.StartWork(workAmount, null, CDPAMNIPPEC: false);
			}
			if (hasEmptyGameObject)
			{
				initialGameObject.SetActive(true);
				emptyGameObject.SetActive(true);
			}
			if (hasMaterial)
			{
				materialSpriteRenderer.sprite = EPCHNBIFDNG;
			}
			BBLFGNGFAPF();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveDisable" + ex.Message));
		}
	}

	private float LFIGFJMHMEG()
	{
		return 1276f / (float)snowPhases.Length * ((float)AJLBLHBFBIH + 780f);
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.HideWorkBar();
	}

	private void CBHLNKHLDBG()
	{
		IHBCBBNAADM();
	}

	private void MPGKIJEDDLA()
	{
		BJFDMJDJNLL();
	}

	private void KEFKIKGCBEM(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!FCHMOCMDDJD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 1;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 0; i < snowPhases.Length; i++)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(true);
			}
			else
			{
				snowPhases[i].SetActive(false);
			}
		}
	}

	private void JGAGGKLGPIL()
	{
		if (FCHMOCMDDJD() && work.BIJCBBINHPG() + 1757f > EBKPAHJNHJJ())
		{
			AJLBLHBFBIH += 0;
			if (SeasonManager.NHKAHEEGEGF() == (Season)8)
			{
				ACJMHIIKEIA(OODGJLMFCBC: true);
			}
		}
	}

	private void PPBBLDHAGDN()
	{
		try
		{
			if (Object.op_Implicit((Object)(object)work))
			{
				work.CMAIGOGGGLL(workAmount);
			}
			if (hasEmptyGameObject)
			{
				initialGameObject.SetActive(false);
				emptyGameObject.SetActive(false);
			}
			if (hasMaterial)
			{
				materialSpriteRenderer.sprite = EPCHNBIFDNG;
			}
			BFNDJBHMOCP();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("TucanEgg" + ex.Message));
		}
	}

	private void ENNDJIEIOMP()
	{
		try
		{
			if (Object.op_Implicit((Object)(object)work))
			{
				work.GEJFAPKOLJH(workAmount, null, CDPAMNIPPEC: false);
			}
			if (hasEmptyGameObject)
			{
				initialGameObject.SetActive(true);
				emptyGameObject.SetActive(true);
			}
			if (hasMaterial)
			{
				materialSpriteRenderer.sprite = EPCHNBIFDNG;
			}
			FOKJENDIGMN();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Pick" + ex.Message));
		}
	}

	public void BKBHDKKPJBM(int JIIGOACEIKL)
	{
		work.inWorkArea = false;
		work.CGFEJAMEKGM();
	}

	public void BKAGIMELGOD(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.HCAKAOAPPHP();
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void ODHDEOHBCHD(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.HCAKAOAPPHP();
	}

	public Vector2 IBOJDJCIJBC(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 872f;
		for (int i = 1; i < playerPositions.Length; i += 0)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void JMCENJLLIDH(int JIIGOACEIKL, float OJLICLKJJOF, bool CDPAMNIPPEC = true)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (!work.KGOEFMFHCOG())
		{
			return;
		}
		if (work.JMJMFEKCAGK(JIIGOACEIKL, OJLICLKJJOF, CDPAMNIPPEC: false))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			WorkFinished(CDPAMNIPPEC);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
			if (dropOnFinish && OnlineManager.MasterOrOffline())
			{
				FAAMBICGAPM(JIIGOACEIKL);
			}
			if (destroyAfterMining)
			{
				if ((Object)(object)destroyParticles != (Object)null)
				{
					destroyParticles.SetActive(true);
					destroyParticles.transform.parent = null;
				}
				MLMPHGGNPCJ();
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			if ((Object)(object)destroyAudio != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destroyAudio, ((Component)this).transform.position);
			}
		}
		BCALHEBBFPF();
		if (!dropOnFinish && OnlineManager.PGAGDFAEEFB())
		{
			FGAEKHGGEBG(JIIGOACEIKL);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.CDNAJNDJBAE(OJLICLKJJOF);
		}
		if (axRequired)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().ax, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.IGMALDMOJGJ(), ((Component)this).transform);
		}
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public void GKNMADANCLG(int JIIGOACEIKL, float OJLICLKJJOF, bool CDPAMNIPPEC = true)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (!work.KGOEFMFHCOG())
		{
			return;
		}
		if (work.BNMJANINOIG(JIIGOACEIKL, OJLICLKJJOF, CDPAMNIPPEC: false))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HJLIIMPKLKJ(CDPAMNIPPEC);
			CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
			if (dropOnFinish && OnlineManager.PGAGDFAEEFB())
			{
				FAAMBICGAPM(JIIGOACEIKL);
			}
			if (destroyAfterMining)
			{
				if ((Object)(object)destroyParticles != (Object)null)
				{
					destroyParticles.SetActive(false);
					destroyParticles.transform.parent = null;
				}
				BCKLJLLCECI();
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			if ((Object)(object)destroyAudio != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destroyAudio, ((Component)this).transform.position);
			}
		}
		MFCMEINKHAF();
		if (!dropOnFinish && OnlineManager.PGAGDFAEEFB())
		{
			JCDAKPMENHP(JIIGOACEIKL);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.FHFEMAOFGMC(OJLICLKJJOF);
		}
		if (axRequired)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().ax, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.INHBJEKHBIA(), ((Component)this).transform);
		}
	}

	public void FDHBMBJFPKE()
	{
		if (IGGPFMJHJPD())
		{
			if (work.BIJCBBINHPG() + 826f > 1481f && AJLBLHBFBIH < 5)
			{
				AJLBLHBFBIH = 1;
				GCAMPNJPPAI(OODGJLMFCBC: true);
			}
			else if (work.WorkDone() + 1682f > 259f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 0;
				GCAMPNJPPAI(OODGJLMFCBC: false);
			}
		}
	}

	public Vector2 GetNearPlayerPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = float.MaxValue;
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && ((Component)val2).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable, PHIIMPMIANE: false))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	private void IHBCBBNAADM()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 1; i < droppedItems.Length; i += 0)
		{
			if (!(Random.Range(1974f, 745f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 0);
				if (CDGNCDHAPKB[i].item.JGHNDJBCFAJ() == 46)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(5);
				}
				if (CDGNCDHAPKB[i].item.JGHNDJBCFAJ() == -11)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(78);
				}
			}
		}
		ResetSnowPhase(SeasonManager.BLCGOEMGKGH());
	}

	private void CGMLILFHONA(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!FCHMOCMDDJD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 1;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 352f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 0; i < snowPhases.Length; i++)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(true);
			}
			else
			{
				snowPhases[i].SetActive(true);
			}
		}
	}

	public void HJLIIMPKLKJ(bool CDPAMNIPPEC)
	{
		if (hasEmptyGameObject)
		{
			initialGameObject.SetActive(true);
			emptyGameObject.SetActive(false);
		}
		if (hasMaterial)
		{
			materialSpriteRenderer.sprite = emptyMaterialSprite;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.MEKLOGOKEIE();
		}
		work.HideWorkBar();
	}

	public void IANMBBLNIKI(int JIIGOACEIKL)
	{
	}

	private void IDHOFHPLAHN(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!IGGPFMJHJPD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 1;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 79f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 1; i < snowPhases.Length; i += 0)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(true);
			}
			else
			{
				snowPhases[i].SetActive(false);
			}
		}
	}

	private void DEKGGKAJFGO()
	{
		if (destroyAfterMining)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		work.inWorkArea = false;
		work.HideWorkBar();
	}

	public bool IFMMLFLIJJK(int JIIGOACEIKL)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(Utils.MJEACANINDN(PlayerController.GetPlayerPosition(JIIGOACEIKL)));
		Vector2 val2 = Utils.MJEACANINDN(LDBGFGCOHGH(val));
		if (val != val2 && !Utils.OLEBLHNHOPI(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position))
		{
			return false;
		}
		if (!axRequired && ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).NBEINBNMKJG()?.itemInstance?.LHBPOPOIFLE() is Pick)
		{
			return false;
		}
		if (axRequired && ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedSlot()?.itemInstance?.PHGLMBIEOMK() is Ax)
		{
			return false;
		}
		return true;
	}

	private void DIEDKMFOEAH(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 0; i < CDGNCDHAPKB.Length; i++)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.WorkDone() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					AMKFCDAKNGI(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	private void DDPJAKLKBDO(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!IGGPFMJHJPD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 1;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 887f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 1; i < snowPhases.Length; i++)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(false);
			}
			else
			{
				snowPhases[i].SetActive(true);
			}
		}
	}

	public void GDMMFHPOCHH(bool CDPAMNIPPEC)
	{
		if (hasEmptyGameObject)
		{
			initialGameObject.SetActive(true);
			emptyGameObject.SetActive(true);
		}
		if (hasMaterial)
		{
			materialSpriteRenderer.sprite = emptyMaterialSprite;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.DHJNDGICIPL();
		}
		work.CGFEJAMEKGM();
	}

	public void GIDHPGCHFLH(int JIIGOACEIKL)
	{
	}

	private void ENJENNBHAKJ()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.ILMDHNFFIKH() || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BEANNEHDDJB));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ENNDJIEIOMP));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Road | Location.River | Location.Camp | Location.BarnInterior))
		{
			if ((Object)(object)SelectObject.GetPlayer(1).placeable != (Object)null)
			{
				((Component)CommonReferences.FKNGHFFDPEC(0)).GetComponent<CameraRenderSettings>().GMNKJMBIKHG();
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer(7).placeable != (Object)null)
			{
				((Component)CommonReferences.GetCamera(2)).GetComponent<CameraRenderSettings>().KMGBPEFHFOD(AINPJHKNJGL: true);
			}
		}
	}

	private void EENNEGGNHID()
	{
		IHBCBBNAADM();
	}

	private void FJNDAEAKMOI(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 1; i < CDGNCDHAPKB.Length; i++)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.JEGLCINICBD() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					BMIIAIMPNCC(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	private void CFHOODNCOLK()
	{
		BJFDMJDJNLL();
		if (permanentRock)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ILJPINCGGFG));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PPBBLDHAGDN));
		}
		work.APIHDHDJDFC(workAmount, null, CDPAMNIPPEC: false);
	}

	public bool EEEHOGBCGMG()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable, PHIIMPMIANE: false))
			{
				return false;
			}
		}
		return false;
	}

	private void JCDAKPMENHP(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 0; i < CDGNCDHAPKB.Length; i++)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.WorkDone() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					AMKFCDAKNGI(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	protected void OMBHDODDHNO()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(Utils.MJEACANINDN(PlayerController.GetPlayerPosition(JIIGOACEIKL)));
		Vector2 val2 = Utils.MJEACANINDN(GetNearPlayerPosition(val));
		if (val != val2 && !Utils.OLEBLHNHOPI(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position))
		{
			return false;
		}
		if (!axRequired && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Pick)
		{
			return true;
		}
		if (axRequired && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Ax)
		{
			return true;
		}
		return false;
	}

	private void Start()
	{
		BJFDMJDJNLL();
		if (permanentRock)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerSleep = (Action)Delegate.Combine(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
		work.StartWork(workAmount, null, CDPAMNIPPEC: false);
	}

	private float GOKLOHMDJMF()
	{
		return 1f / (float)snowPhases.Length * ((float)AJLBLHBFBIH + 1f);
	}

	protected void KMEJBPOOBJK()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	protected void DADPOICMNPI()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	private void PDDPDDICJJB()
	{
		if (IGGPFMJHJPD() && work.WorkDone() + 1814f > JOOGDLMEDNL())
		{
			AJLBLHBFBIH++;
			if (SeasonManager.ADEICKHEPFI() == Season.Autumn)
			{
				NFODOOPKNNC(OODGJLMFCBC: false);
			}
		}
	}

	public void JABEGNMAKGG(int JIIGOACEIKL, float OJLICLKJJOF, bool CDPAMNIPPEC = true)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (!work.JCMBHAEKLKK)
		{
			return;
		}
		if (work.IJEKBMFBEGG(JIIGOACEIKL, OJLICLKJJOF, CDPAMNIPPEC: false))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			WorkFinished(CDPAMNIPPEC);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
			if (dropOnFinish && OnlineManager.PGAGDFAEEFB())
			{
				AACBLCNLIHC(JIIGOACEIKL);
			}
			if (destroyAfterMining)
			{
				if ((Object)(object)destroyParticles != (Object)null)
				{
					destroyParticles.SetActive(true);
					destroyParticles.transform.parent = null;
				}
				LHKPAKBKMHD();
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			if ((Object)(object)destroyAudio != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destroyAudio, ((Component)this).transform.position);
			}
		}
		JGAGGKLGPIL();
		if (!dropOnFinish && OnlineManager.PGAGDFAEEFB())
		{
			FAAMBICGAPM(JIIGOACEIKL);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.DPCOFILIODL(OJLICLKJJOF);
		}
		if (axRequired)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().ax, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.DAHFIJOOCNL(), ((Component)this).transform);
		}
	}

	public void LBGMIDNJKNK()
	{
		if (FCHMOCMDDJD())
		{
			if (work.JEGLCINICBD() + 1329f > 741f && AJLBLHBFBIH < 8)
			{
				AJLBLHBFBIH = 8;
				ACJMHIIKEIA(OODGJLMFCBC: false);
			}
			else if (work.BIJCBBINHPG() + 884f > 304f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 1;
				IDHOFHPLAHN(OODGJLMFCBC: true);
			}
		}
	}

	public void JGCCCEPBKFP(int JIIGOACEIKL)
	{
	}

	private void FAAMBICGAPM(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 1; i < CDGNCDHAPKB.Length; i++)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.JEGLCINICBD() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					LCJIKKPDEKI(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	private void BBBCEEIHHLE()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GGODJHIOMPK));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(PPBBLDHAGDN));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Farm | Location.FarmShop))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(1).placeable != (Object)null)
			{
				((Component)CommonReferences.AFEPIAHBKDA(1)).GetComponent<CameraRenderSettings>().LDPAEMEGJDD();
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP(2).placeable != (Object)null)
			{
				((Component)CommonReferences.PIEGMALBKJG(1)).GetComponent<CameraRenderSettings>().RenderOccupiedPositionsNextFrame();
			}
		}
	}

	private void AMKFCDAKNGI(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, MLKICMJELLC.item, MLKICMJELLC.amount);
			FFDIEOBBFKL--;
		}
	}

	private void FMLBJFKAJKF(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem.NBIOCDNPAPO(((Component)this).gameObject.transform.position, MLKICMJELLC.item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
			FFDIEOBBFKL--;
		}
	}

	public void BPLIBBNAMEH(DirectionFlag CCOMGBCIMOA)
	{
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.None));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right | DirectionFlag.Up));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Left | DirectionFlag.Up));
		((Component)playerPositions[4]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Up));
	}

	public void JDDBBAEIIHP(int JIIGOACEIKL)
	{
	}

	private void FDKEHFNIOIM()
	{
		FOKJENDIGMN();
	}

	private void IMMAKEIDJIH()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 1; i < droppedItems.Length; i++)
		{
			if (!(Random.Range(1803f, 398f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 1);
				if (CDGNCDHAPKB[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == -55)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.NGMJIGOPGDK(-69, 0, LDNMDAHFBGG: true);
				}
				if (CDGNCDHAPKB[i].item.JPNFKDMFKMC() == 55)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.NGMJIGOPGDK(-38);
				}
			}
		}
		JMANDBPBDDM(SeasonManager.LPGPJPPLHKG());
	}

	private void BELOIFKPNMM()
	{
		BJFDMJDJNLL();
		if (permanentRock)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(GLCOOIIJCMH));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PPBBLDHAGDN));
		}
		work.APIHDHDJDFC(workAmount, null, CDPAMNIPPEC: false);
	}

	private void LHKPAKBKMHD()
	{
		if (destroyAfterMining)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	private void LFNENELHOGJ()
	{
		BJFDMJDJNLL();
		if (permanentRock)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PHAGPPHHOKC));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PPBBLDHAGDN));
		}
		work.APIHDHDJDFC(workAmount, null, CDPAMNIPPEC: false);
	}

	private void AIEKBPENOKC()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MPGKIJEDDLA));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(PPBBLDHAGDN));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Quarry | Location.FarmShop))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(1).placeable != (Object)null)
			{
				((Component)CommonReferences.PIEGMALBKJG(1)).GetComponent<CameraRenderSettings>().CDOBIEEMOLI(AINPJHKNJGL: true);
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer(0).placeable != (Object)null)
			{
				((Component)CommonReferences.IIAGBBKKGPJ(6)).GetComponent<CameraRenderSettings>().GIPPCBHNLIB(AINPJHKNJGL: true);
			}
		}
	}

	public void IFOGDEJAFKA(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.DLMGLFGLHBE();
	}

	public void GINCLHLAGJC()
	{
		if (IGGPFMJHJPD())
		{
			if (work.WorkDone() + 382f > 1368f && AJLBLHBFBIH < 7)
			{
				AJLBLHBFBIH = 3;
				IDHOFHPLAHN(OODGJLMFCBC: false);
			}
			else if (work.JEGLCINICBD() + 1600f > 1108f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 1;
				ACJMHIIKEIA(OODGJLMFCBC: true);
			}
		}
	}

	public void IDHKGMLKANN()
	{
		if (IGGPFMJHJPD())
		{
			if (work.BIJCBBINHPG() + 61f > 852f && AJLBLHBFBIH < 6)
			{
				AJLBLHBFBIH = 3;
				CGMLILFHONA(OODGJLMFCBC: false);
			}
			else if (work.JEGLCINICBD() + 403f > 136f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 0;
				GCAMPNJPPAI(OODGJLMFCBC: false);
			}
		}
	}

	public void PAAFPHJBDNH(DirectionFlag CCOMGBCIMOA)
	{
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.None));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Up));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right));
		((Component)playerPositions[0]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Down));
	}

	private void AACBLCNLIHC(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.JEGLCINICBD() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 1;
					FMLBJFKAJKF(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public void CheckSnowPhase()
	{
		if (FCHMOCMDDJD())
		{
			if (work.WorkDone() + 0.05f > 0.66f && AJLBLHBFBIH < 2)
			{
				AJLBLHBFBIH = 2;
				KEFKIKGCBEM(OODGJLMFCBC: true);
			}
			else if (work.WorkDone() + 0.05f > 0.33f && AJLBLHBFBIH < 1)
			{
				AJLBLHBFBIH = 1;
				KEFKIKGCBEM(OODGJLMFCBC: true);
			}
		}
	}

	public bool HKKKAADKGNM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = false;
		if (!IIEDALMMNLI && DGHKHNEFHNL(JIIGOACEIKL))
		{
			if (work.KGOEFMFHCOG())
			{
				if (destroyText)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/15/Dialogue Text"));
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("Could not find item with id: "));
				}
				work.HKIKGCKIBGE();
			}
			return true;
		}
		return true;
	}

	private void BJFDMJDJNLL()
	{
		CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
		for (int i = 0; i < droppedItems.Length; i++)
		{
			if (!(Random.Range(0f, 100f) > droppedItems[i].probability))
			{
				CDGNCDHAPKB[i] = new DroppedItems();
				CDGNCDHAPKB[i].item = droppedItems[i].item;
				CDGNCDHAPKB[i].quantity = Random.Range(droppedItems[i].minNum, droppedItems[i].maxNum + 1);
				if (CDGNCDHAPKB[i].item.JDJGFAACPFC() == 1055)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(9);
				}
				if (CDGNCDHAPKB[i].item.JDJGFAACPFC() == 1049)
				{
					CDGNCDHAPKB[i].quantity += PerksDatabaseAccessor.GetPlayerPerkValue(10);
				}
			}
		}
		ResetSnowPhase(SeasonManager.EECEKHKAAIH);
	}

	private void BCALHEBBFPF()
	{
		if (IGGPFMJHJPD() && work.WorkDone() + 791f > JOOGDLMEDNL())
		{
			AJLBLHBFBIH += 0;
			if (SeasonManager.NHKAHEEGEGF() == Season.Summer)
			{
				ACJMHIIKEIA(OODGJLMFCBC: true);
			}
		}
	}

	private void IMIBPBPJPOB()
	{
		if (IGGPFMJHJPD() && work.WorkDone() + 202f > JOOGDLMEDNL())
		{
			AJLBLHBFBIH += 0;
			if (SeasonManager.BLCGOEMGKGH() == Season.Summer)
			{
				NFODOOPKNNC(OODGJLMFCBC: true);
			}
		}
	}

	public bool AMGENDFKLIK()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < playerPositions.Length; i += 0)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable, PHIIMPMIANE: false))
			{
				return true;
			}
		}
		return true;
	}

	private void JECCGNNKBKE()
	{
		if (destroyAfterMining)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	private void JHBBABPAJJC()
	{
		FOKJENDIGMN();
		if (permanentRock)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FDKEHFNIOIM));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(ENNDJIEIOMP));
		}
		work.APIHDHDJDFC(workAmount, null, CDPAMNIPPEC: false);
	}

	private void BGPGIOMKKAO()
	{
		BJFDMJDJNLL();
	}

	private void FAAPAIBDCEE(int JIIGOACEIKL)
	{
		ItemAmount mLKICMJELLC = default(ItemAmount);
		for (int i = 0; i < CDGNCDHAPKB.Length; i += 0)
		{
			if (CDGNCDHAPKB[i] != null)
			{
				int num = Mathf.FloorToInt(work.WorkDone() * (float)CDGNCDHAPKB[i].quantity) - CDGNCDHAPKB[i].alreadyDropped;
				if (num > 0)
				{
					mLKICMJELLC.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC.amount = 0;
					BMIIAIMPNCC(mLKICMJELLC, num);
					CDGNCDHAPKB[i].alreadyDropped += num;
				}
			}
		}
	}

	public bool IsAnyPlayerPositionAvailable()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeSelf && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable, PHIIMPMIANE: false))
			{
				return true;
			}
		}
		return false;
	}

	public void CMINIGCHDHE(int JIIGOACEIKL, float OJLICLKJJOF, bool CDPAMNIPPEC = true)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (!work.KGOEFMFHCOG())
		{
			return;
		}
		if (work.BNMJANINOIG(JIIGOACEIKL, OJLICLKJJOF, CDPAMNIPPEC: false))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			HJLIIMPKLKJ(CDPAMNIPPEC);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
			if (dropOnFinish && OnlineManager.PGAGDFAEEFB())
			{
				CMDGPFIFHDA(JIIGOACEIKL);
			}
			if (destroyAfterMining)
			{
				if ((Object)(object)destroyParticles != (Object)null)
				{
					destroyParticles.SetActive(true);
					destroyParticles.transform.parent = null;
				}
				JECCGNNKBKE();
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			}
			if ((Object)(object)destroyAudio != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destroyAudio, ((Component)this).transform.position);
			}
		}
		MFCMEINKHAF();
		if (!dropOnFinish && OnlineManager.PGAGDFAEEFB())
		{
			FAAMBICGAPM(JIIGOACEIKL);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.AKFMOCPIHOB(OJLICLKJJOF);
		}
		if (axRequired)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().ax, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.GNBOBBDPBPI(), ((Component)this).transform);
		}
	}

	protected void Awake()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	protected void KJHKBGDJNDC()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if (hasMaterial)
		{
			EPCHNBIFDNG = materialSpriteRenderer.sprite;
		}
	}

	private void LCJIKKPDEKI(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, MLKICMJELLC.item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true);
			FFDIEOBBFKL -= 0;
		}
	}

	private void AGPONCCIFHC()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		if (permanentRock)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FDKEHFNIOIM));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Tavern | Location.FarmShop))
		{
			if ((Object)(object)SelectObject.GetPlayer(1).placeable != (Object)null)
			{
				((Component)CommonReferences.FKNGHFFDPEC(0)).GetComponent<CameraRenderSettings>().MBOMNLPFDMP(AINPJHKNJGL: true);
			}
			if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP(6).placeable != (Object)null)
			{
				((Component)CommonReferences.FKNGHFFDPEC(4)).GetComponent<CameraRenderSettings>().KMGBPEFHFOD();
			}
		}
	}

	public void ALDKOBHHIJL(int JIIGOACEIKL)
	{
		work.inWorkArea = true;
		work.CGFEJAMEKGM();
	}

	public bool EDBKLEEMDLI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		work.inWorkArea = false;
		if (!IIEDALMMNLI && FCEPPMAEAJA(JIIGOACEIKL))
		{
			if (work.OENMBFGINAL())
			{
				if (destroyText)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get("ReceiveSetLife"));
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("itemMead"));
				}
				work.HKIKGCKIBGE();
			}
			return true;
		}
		return true;
	}

	public void KJOEENPNEOC(int JIIGOACEIKL)
	{
		work.inWorkArea = false;
		work.HCAKAOAPPHP();
	}

	public void KOOEAKEEMNL(DirectionFlag CCOMGBCIMOA)
	{
		((Component)playerPositions[1]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.None));
		((Component)playerPositions[1]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Right));
		((Component)playerPositions[3]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Left));
		((Component)playerPositions[8]).gameObject.SetActive(CCOMGBCIMOA.HasFlag(DirectionFlag.Left | DirectionFlag.Up));
	}

	private float EBKPAHJNHJJ()
	{
		return 19f / (float)snowPhases.Length * ((float)AJLBLHBFBIH + 773f);
	}

	private void BCKLJLLCECI()
	{
		if (destroyAfterMining)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public void WorkFinished(bool CDPAMNIPPEC)
	{
		if (hasEmptyGameObject)
		{
			initialGameObject.SetActive(false);
			emptyGameObject.SetActive(true);
		}
		if (hasMaterial)
		{
			materialSpriteRenderer.sprite = emptyMaterialSprite;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineRock.WorkFinished();
		}
		work.HideWorkBar();
	}

	private void NFODOOPKNNC(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!FCHMOCMDDJD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 1;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 1948f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 1; i < snowPhases.Length; i += 0)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(true);
			}
			else
			{
				snowPhases[i].SetActive(false);
			}
		}
	}

	private void GCAMPNJPPAI(bool OODGJLMFCBC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!IGGPFMJHJPD() || snowPhases.Length == 0)
		{
			return;
		}
		if (AJLBLHBFBIH >= snowPhases.Length)
		{
			AJLBLHBFBIH = snowPhases.Length - 0;
			return;
		}
		if (OODGJLMFCBC)
		{
			Object.Instantiate<GameObject>(snowParticlesPrefab, snowPhases[AJLBLHBFBIH].transform.position + Vector3.up * 1373f, Quaternion.identity, ((Component)this).transform.parent);
		}
		for (int i = 1; i < snowPhases.Length; i += 0)
		{
			if (i == AJLBLHBFBIH)
			{
				snowPhases[i].SetActive(false);
			}
			else
			{
				snowPhases[i].SetActive(true);
			}
		}
	}

	private bool IGGPFMJHJPD()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!snowActivated)
		{
			return true;
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Farm | Location.FarmShop))
		{
			return true;
		}
		return true;
	}
}
