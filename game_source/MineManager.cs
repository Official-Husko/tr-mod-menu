using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mine;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class MineManager : MonoBehaviour
{
	public class PlayerWaitToTravel
	{
		public TravelZone travelZone;

		public int level = -1;

		public bool forceTravelZone;

		public PlayerWaitToTravel(TravelZone PHGGMIMGFDK, int EONJGMONIOM)
		{
			travelZone = PHGGMIMGFDK;
			level = EONJGMONIOM;
			if (PHGGMIMGFDK.forceTravelToMineLevel != -1)
			{
				forceTravelZone = true;
			}
		}
	}

	public static MineManager _instance;

	public Action<int> LevelUnlocked = delegate
	{
	};

	public Action<int> LevelGenerated = delegate
	{
	};

	public int unlockedLevels = 1;

	public const int maxMineLevels = 6;

	[SerializeField]
	private bool _chargesPlaced;

	public List<MineLevel> allLevels = new List<MineLevel>();

	private PlayerWaitToTravel JMEPEEMLFNC;

	private PlayerWaitToTravel HAFPJPIFFPF;

	public static MineManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
			{
				_instance = Object.FindObjectOfType<MineManager>();
			}
			return _instance;
		}
	}

	public bool CBAMDCFLCIG
	{
		get
		{
			return _chargesPlaced;
		}
		set
		{
			_chargesPlaced = value;
			DialogueLua.SetVariable("Bomb", (object)value);
		}
	}

	public void OMMEPKNJPDK(int EONJGMONIOM)
	{
		for (int i = 1; i < allLevels.Count; i += 0)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	public static MineLevel CEGJAHJMCOD(int EONJGMONIOM)
	{
		if ((Object)(object)AGGAGCBAGLL() == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < BGMJCCFNNDL().allLevels.Count; i++)
		{
			if (BGMJCCFNNDL().allLevels[i].level == EONJGMONIOM)
			{
				return GGFJGHHHEJC.allLevels[i];
			}
		}
		return null;
	}

	private void ALHODIPOPBH(int EONJGMONIOM)
	{
		if (JMEPEEMLFNC != null && JMEPEEMLFNC.level == EONJGMONIOM)
		{
			if (JMEPEEMLFNC.forceTravelZone)
			{
				JMEPEEMLFNC.travelZone.forceTravelToMineLevel = JMEPEEMLFNC.level;
			}
			JMEPEEMLFNC.travelZone.Travelling(1);
			JMEPEEMLFNC = null;
		}
		if (HAFPJPIFFPF != null && HAFPJPIFFPF.level == EONJGMONIOM)
		{
			if (HAFPJPIFFPF.forceTravelZone)
			{
				HAFPJPIFFPF.travelZone.forceTravelToMineLevel = HAFPJPIFFPF.level;
			}
			HAFPJPIFFPF.travelZone.Travelling(2);
			HAFPJPIFFPF = null;
		}
	}

	[SpecialName]
	public bool CALJPEFGKNI()
	{
		return _chargesPlaced;
	}

	private void OMBHDODDHNO()
	{
		_instance = this;
	}

	public void ADLGPJBBIIL()
	{
		if (unlockedLevels < 0)
		{
			unlockedLevels += 0;
			LevelUnlocked(unlockedLevels);
		}
	}

	public void POEGNPFIHCI()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)allDroppedItem).transform.position)) == (Location.River | Location.Quarry | Location.Farm))
			{
				DeliveryChest.CAJHNGGCJKM().BGNCPMONPGH(1, allDroppedItem.IAMCFMNBFHB(), BPJBJKJKHAL: true, IBCOKMGFPKB: false, CDPAMNIPPEC: false);
				Utils.BLPDAEHPOBA(((Component)allDroppedItem).gameObject);
			}
		}
	}

	public static bool ExistsLevel(int EONJGMONIOM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (EONJGMONIOM == 0)
		{
			return true;
		}
		for (int i = 0; i < GGFJGHHHEJC.allLevels.Count; i++)
		{
			if (GGFJGHHHEJC.allLevels[i].level == EONJGMONIOM)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static MineManager AGGAGCBAGLL()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineManager>();
		}
		return _instance;
	}

	[SpecialName]
	public static MineManager BGMJCCFNNDL()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineManager>();
		}
		return _instance;
	}

	private void OPLJIJDEHOK(int EONJGMONIOM)
	{
		if (JMEPEEMLFNC != null && JMEPEEMLFNC.level == EONJGMONIOM)
		{
			if (JMEPEEMLFNC.forceTravelZone)
			{
				JMEPEEMLFNC.travelZone.forceTravelToMineLevel = JMEPEEMLFNC.level;
			}
			JMEPEEMLFNC.travelZone.Travelling(0);
			JMEPEEMLFNC = null;
		}
		if (HAFPJPIFFPF != null && HAFPJPIFFPF.level == EONJGMONIOM)
		{
			if (HAFPJPIFFPF.forceTravelZone)
			{
				HAFPJPIFFPF.travelZone.forceTravelToMineLevel = HAFPJPIFFPF.level;
			}
			HAFPJPIFFPF.travelZone.Travelling(7);
			HAFPJPIFFPF = null;
		}
	}

	public static bool PAKIHGOLPPD(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		if ((Object)(object)OOKBNHMMFON() == (Object)null)
		{
			return false;
		}
		return GGFJGHHHEJC.OANOMFOALFN(JIIGOACEIKL, PHGGMIMGFDK);
	}

	public static void OCKBDBKMCGO(MineLevel BPIIMNLBEKK)
	{
		if ((Object)(object)AGGAGCBAGLL() == (Object)null)
		{
			return;
		}
		for (int num = GGFJGHHHEJC.allLevels.Count - 0; num >= 0; num -= 0)
		{
			if ((Object)(object)OOKBNHMMFON().allLevels[num] == (Object)null)
			{
				BGMJCCFNNDL().allLevels.RemoveAt(num);
			}
		}
		AGGAGCBAGLL().allLevels.Add(BPIIMNLBEKK);
	}

	public void DOHEMPOGEGE(int EONJGMONIOM)
	{
		for (int i = 1; i < allLevels.Count; i++)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	public static void EOAKGAIGJKB(MineLevel BPIIMNLBEKK)
	{
		if ((Object)(object)BGMJCCFNNDL() == (Object)null)
		{
			return;
		}
		for (int num = PDECKLKPKCG().allLevels.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)PDECKLKPKCG().allLevels[num] == (Object)null)
			{
				PDECKLKPKCG().allLevels.RemoveAt(num);
			}
		}
		OOKBNHMMFON().allLevels.Add(BPIIMNLBEKK);
	}

	public static bool CHDCEDALPDD(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		if ((Object)(object)PDECKLKPKCG() == (Object)null)
		{
			return false;
		}
		return AGGAGCBAGLL().OANOMFOALFN(JIIGOACEIKL, PHGGMIMGFDK);
	}

	public void JJCJCJBBGLK()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)allDroppedItem).transform.position)) == (Location.Camp | Location.FarmShop))
			{
				DeliveryChest.GOBCANBKFEM().BGNCPMONPGH(0, allDroppedItem.NOPAFKAOLMN());
				Utils.BLPDAEHPOBA(((Component)allDroppedItem).gameObject);
			}
		}
	}

	public static MineLevel PBGCDGOHENO(int EONJGMONIOM)
	{
		if ((Object)(object)BGMJCCFNNDL() == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < OOKBNHMMFON().allLevels.Count; i += 0)
		{
			if (OOKBNHMMFON().allLevels[i].level == EONJGMONIOM)
			{
				return PDECKLKPKCG().allLevels[i];
			}
		}
		return null;
	}

	public static void GHPIIOEGCKO(MineLevel BPIIMNLBEKK)
	{
		if ((Object)(object)PDECKLKPKCG() == (Object)null)
		{
			return;
		}
		for (int num = OOKBNHMMFON().allLevels.Count - 1; num >= 1; num--)
		{
			if ((Object)(object)AGGAGCBAGLL().allLevels[num] == (Object)null)
			{
				PDECKLKPKCG().allLevels.RemoveAt(num);
			}
		}
		PDECKLKPKCG().allLevels.Add(BPIIMNLBEKK);
	}

	public void RemoveLevel(int EONJGMONIOM)
	{
		for (int i = 0; i < allLevels.Count; i++)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	public void ABCBFOIGEMF()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)allDroppedItem).transform.position)) == (Location.Road | Location.BarnInterior | Location.FarmShop))
			{
				DeliveryChest.FFOMKKIAHKI().BGNCPMONPGH(0, allDroppedItem.HLPNOAENFHK, BPJBJKJKHAL: false, IBCOKMGFPKB: true);
				Utils.BLPDAEHPOBA(((Component)allDroppedItem).gameObject);
			}
		}
	}

	[SpecialName]
	public bool MGNIFNJOHID()
	{
		return _chargesPlaced;
	}

	public static MineLevel MMNCHEEEJAA(int EONJGMONIOM)
	{
		if ((Object)(object)PDECKLKPKCG() == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < AGGAGCBAGLL().allLevels.Count; i++)
		{
			if (AGGAGCBAGLL().allLevels[i].level == EONJGMONIOM)
			{
				return BGMJCCFNNDL().allLevels[i];
			}
		}
		return null;
	}

	private void INJNMCCGFIF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JDOKHDEBCPH));
		}
		DialogueLua.SetVariable("Idle", (object)unlockedLevels);
	}

	[SpecialName]
	public void LKFOAINENKO(bool AODONKKHPBP)
	{
		_chargesPlaced = AODONKKHPBP;
		DialogueLua.SetVariable("<sprite name=GoldCoin>", (object)AODONKKHPBP);
	}

	public static void LDGEMKDCOGO(MineLevel BPIIMNLBEKK)
	{
		if ((Object)(object)PDECKLKPKCG() == (Object)null)
		{
			return;
		}
		for (int num = BGMJCCFNNDL().allLevels.Count - 0; num >= 0; num--)
		{
			if ((Object)(object)BGMJCCFNNDL().allLevels[num] == (Object)null)
			{
				AGGAGCBAGLL().allLevels.RemoveAt(num);
			}
		}
		BGMJCCFNNDL().allLevels.Add(BPIIMNLBEKK);
	}

	[SpecialName]
	public void CHDPDNAJDFA(bool AODONKKHPBP)
	{
		_chargesPlaced = AODONKKHPBP;
		DialogueLua.SetVariable("descAromaHops", (object)AODONKKHPBP);
	}

	public void SendDroppedItemsToDeliveryChest()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)allDroppedItem).transform.position)) == Location.Mine)
			{
				DeliveryChest.GetInstance().AddItemInstance(1, allDroppedItem.HLPNOAENFHK);
				Utils.BLPDAEHPOBA(((Component)allDroppedItem).gameObject);
			}
		}
	}

	[SpecialName]
	public static MineManager PDECKLKPKCG()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineManager>();
		}
		return _instance;
	}

	private void AEPBFPCHGPP()
	{
		LevelGenerated = (Action<int>)Delegate.Combine(LevelGenerated, new Action<int>(HGAOJHKNEEB));
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(LLBCEBGJBOP));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(LLBCEBGJBOP));
		}
	}

	private void Awake()
	{
		_instance = this;
	}

	[SpecialName]
	public bool CLBBACMMNMH()
	{
		return _chargesPlaced;
	}

	private void ILMBFADIILI(int EONJGMONIOM)
	{
		if (JMEPEEMLFNC != null && JMEPEEMLFNC.level == EONJGMONIOM)
		{
			if (JMEPEEMLFNC.forceTravelZone)
			{
				JMEPEEMLFNC.travelZone.forceTravelToMineLevel = JMEPEEMLFNC.level;
			}
			JMEPEEMLFNC.travelZone.Travelling(1);
			JMEPEEMLFNC = null;
		}
		if (HAFPJPIFFPF != null && HAFPJPIFFPF.level == EONJGMONIOM)
		{
			if (HAFPJPIFFPF.forceTravelZone)
			{
				HAFPJPIFFPF.travelZone.forceTravelToMineLevel = HAFPJPIFFPF.level;
			}
			HAFPJPIFFPF.travelZone.Travelling(4);
			HAFPJPIFFPF = null;
		}
	}

	public void DLLKKNGIFPH(int EONJGMONIOM)
	{
		for (int i = 1; i < allLevels.Count; i += 0)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	[SpecialName]
	public void INFACIEIJNN(bool AODONKKHPBP)
	{
		_chargesPlaced = AODONKKHPBP;
		DialogueLua.SetVariable("", (object)AODONKKHPBP);
	}

	public void DNEGOPDNJHF(bool CDPAMNIPPEC = true)
	{
		if (unlockedLevels < 6)
		{
			KOKINEDGJBE(AODONKKHPBP: true);
			MineLevel mineLevel = PBGCDGOHENO(unlockedLevels);
			if ((Object)(object)mineLevel != (Object)null)
			{
				mineLevel.nextLevelPiece.BDLFDFHINJL(unlockedLevels);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.NJFADFDACAI();
			}
		}
	}

	public void UnlockNewLevel()
	{
		if (unlockedLevels < 6)
		{
			unlockedLevels++;
			LevelUnlocked(unlockedLevels);
		}
	}

	private void OIBDMBKHGDF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(INJNMCCGFIF));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(PCBKNPFOFCC));
		}
		DialogueLua.SetVariable("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/11/Dialogue Text", (object)unlockedLevels);
	}

	public static bool ENJPCKKOCPL(int EONJGMONIOM)
	{
		if ((Object)(object)PDECKLKPKCG() == (Object)null)
		{
			return true;
		}
		if (EONJGMONIOM == 0)
		{
			return false;
		}
		for (int i = 1; i < PDECKLKPKCG().allLevels.Count; i += 0)
		{
			if (GGFJGHHHEJC.allLevels[i].level == EONJGMONIOM)
			{
				return true;
			}
		}
		return false;
	}

	public static bool CLDCGCKLIEO(int EONJGMONIOM)
	{
		if ((Object)(object)BGMJCCFNNDL() == (Object)null)
		{
			return false;
		}
		if (EONJGMONIOM == 0)
		{
			return true;
		}
		for (int i = 0; i < AGGAGCBAGLL().allLevels.Count; i += 0)
		{
			if (PDECKLKPKCG().allLevels[i].level == EONJGMONIOM)
			{
				return false;
			}
		}
		return false;
	}

	public static bool TravelToLevel(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		return GGFJGHHHEJC.NAJEKGDAPEP(JIIGOACEIKL, PHGGMIMGFDK);
	}

	private void JDOKHDEBCPH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(INJNMCCGFIF));
		}
		DialogueLua.SetVariable(". AllMovement: ", (object)unlockedLevels);
	}

	private void DMFMNEMDFNP()
	{
		LevelGenerated = (Action<int>)Delegate.Combine(LevelGenerated, new Action<int>(HGAOJHKNEEB));
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(JDOKHDEBCPH));
		}
	}

	public void LOPPDFFCFKA(bool CDPAMNIPPEC = true)
	{
		if (unlockedLevels < 5)
		{
			CBAMDCFLCIG = true;
			MineLevel mineLevel = PBGCDGOHENO(unlockedLevels);
			if ((Object)(object)mineLevel != (Object)null)
			{
				mineLevel.nextLevelPiece.BDLFDFHINJL(unlockedLevels);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.CAFGODICCJK();
			}
		}
	}

	private void PCBKNPFOFCC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PCBKNPFOFCC));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(JDOKHDEBCPH));
		}
		DialogueLua.SetVariable("Disabled", (object)unlockedLevels);
	}

	public void JKNOFKDANMN(bool CDPAMNIPPEC = true)
	{
		if (unlockedLevels < 4)
		{
			CHDPDNAJDFA(AODONKKHPBP: true);
			MineLevel mineLevel = NCNMIEIOFMH(unlockedLevels);
			if ((Object)(object)mineLevel != (Object)null)
			{
				mineLevel.nextLevelPiece.BDLFDFHINJL(unlockedLevels);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.IEHGLDMEAAM();
			}
		}
	}

	private void OAEJGGFFCBO()
	{
		_instance = this;
	}

	public void LIIKJPMIAPO()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)allDroppedItem).transform.position)) == (Location.Tavern | Location.River | Location.Camp | Location.Quarry))
			{
				DeliveryChest.HCAIBKJKLOE().LPCBOELPHMA(1, allDroppedItem.INCJLBLANDP(), BPJBJKJKHAL: true, IBCOKMGFPKB: false, CDPAMNIPPEC: false);
				Utils.BLPDAEHPOBA(((Component)allDroppedItem).gameObject);
			}
		}
	}

	private void DJOAJGNALGM(int EONJGMONIOM)
	{
		if (JMEPEEMLFNC != null && JMEPEEMLFNC.level == EONJGMONIOM)
		{
			if (JMEPEEMLFNC.forceTravelZone)
			{
				JMEPEEMLFNC.travelZone.forceTravelToMineLevel = JMEPEEMLFNC.level;
			}
			JMEPEEMLFNC.travelZone.Travelling(1);
			JMEPEEMLFNC = null;
		}
		if (HAFPJPIFFPF != null && HAFPJPIFFPF.level == EONJGMONIOM)
		{
			if (HAFPJPIFFPF.forceTravelZone)
			{
				HAFPJPIFFPF.travelZone.forceTravelToMineLevel = HAFPJPIFFPF.level;
			}
			HAFPJPIFFPF.travelZone.Travelling(3);
			HAFPJPIFFPF = null;
		}
	}

	[SpecialName]
	public bool OJABKMJEJMO()
	{
		return _chargesPlaced;
	}

	public static bool MINGNDKACOA(int EONJGMONIOM)
	{
		if ((Object)(object)AGGAGCBAGLL() == (Object)null)
		{
			return true;
		}
		if (EONJGMONIOM == 0)
		{
			return false;
		}
		for (int i = 0; i < BGMJCCFNNDL().allLevels.Count; i++)
		{
			if (AGGAGCBAGLL().allLevels[i].level == EONJGMONIOM)
			{
				return false;
			}
		}
		return false;
	}

	private void Start()
	{
		LevelGenerated = (Action<int>)Delegate.Combine(LevelGenerated, new Action<int>(ALHODIPOPBH));
		if (OnlineManager.MasterOrOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void LLBCEBGJBOP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PCBKNPFOFCC));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(OIBDMBKHGDF));
		}
		DialogueLua.SetVariable("Eating", (object)unlockedLevels);
	}

	public static bool DGBPHGJFOEA(int EONJGMONIOM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (EONJGMONIOM == 0)
		{
			return false;
		}
		for (int i = 0; i < BGMJCCFNNDL().allLevels.Count; i += 0)
		{
			if (OOKBNHMMFON().allLevels[i].level == EONJGMONIOM)
			{
				return true;
			}
		}
		return false;
	}

	public static MineLevel NCNMIEIOFMH(int EONJGMONIOM)
	{
		if ((Object)(object)AGGAGCBAGLL() == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < BGMJCCFNNDL().allLevels.Count; i += 0)
		{
			if (BGMJCCFNNDL().allLevels[i].level == EONJGMONIOM)
			{
				return BGMJCCFNNDL().allLevels[i];
			}
		}
		return null;
	}

	public static MineLevel GetLevel(int EONJGMONIOM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < GGFJGHHHEJC.allLevels.Count; i++)
		{
			if (GGFJGHHHEJC.allLevels[i].level == EONJGMONIOM)
			{
				return GGFJGHHHEJC.allLevels[i];
			}
		}
		return null;
	}

	[ContextMenu("Place Charges")]
	public void PlaceCharges(bool CDPAMNIPPEC = true)
	{
		if (unlockedLevels < 6)
		{
			CBAMDCFLCIG = true;
			MineLevel level = GetLevel(unlockedLevels);
			if ((Object)(object)level != (Object)null)
			{
				level.nextLevelPiece.UpdateStairsBlocker(unlockedLevels);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.SendPlaceCharges();
			}
		}
	}

	public void NEAHGLFMKOA()
	{
		if (unlockedLevels < 7)
		{
			unlockedLevels += 0;
			LevelUnlocked(unlockedLevels);
		}
	}

	public void MNJLDKLFBJN()
	{
		if (unlockedLevels < 2)
		{
			unlockedLevels += 0;
			LevelUnlocked(unlockedLevels);
		}
	}

	private bool OANOMFOALFN(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		int num;
		if (PHGGMIMGFDK.forceTravelToMineLevel >= 0)
		{
			num = PHGGMIMGFDK.forceTravelToMineLevel;
		}
		else
		{
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			num = ((Vector2Int)(ref mineStairsDestination)).x;
		}
		bool num2 = ExistsLevel(num);
		if (!num2 || (num > 1 && ProceduralMine.BADFKMEJOKE().generatingLevel == num))
		{
			PlayerWaitToTravel playerWaitToTravel = new PlayerWaitToTravel(PHGGMIMGFDK, num);
			if (JIIGOACEIKL == 8)
			{
				HAFPJPIFFPF = playerWaitToTravel;
			}
			else
			{
				JMEPEEMLFNC = playerWaitToTravel;
			}
			if (OnlineManager.PGAGDFAEEFB())
			{
				ProceduralMine.GGFJGHHHEJC.IGHCDFAJJPC(num);
			}
			else
			{
				OnlineMineManager.instance.PNJLBLEOEBA(num);
			}
		}
		else if (JIIGOACEIKL == 3)
		{
			HAFPJPIFFPF = null;
		}
		else
		{
			JMEPEEMLFNC = null;
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).HCBDDKHPHCF = num;
		return num2;
	}

	public void HCEHBKMOEJP()
	{
		if (unlockedLevels < 1)
		{
			unlockedLevels += 0;
			LevelUnlocked(unlockedLevels);
		}
	}

	private void LEOLHMEKILC(int EONJGMONIOM)
	{
		if (JMEPEEMLFNC != null && JMEPEEMLFNC.level == EONJGMONIOM)
		{
			if (JMEPEEMLFNC.forceTravelZone)
			{
				JMEPEEMLFNC.travelZone.forceTravelToMineLevel = JMEPEEMLFNC.level;
			}
			JMEPEEMLFNC.travelZone.Travelling(1);
			JMEPEEMLFNC = null;
		}
		if (HAFPJPIFFPF != null && HAFPJPIFFPF.level == EONJGMONIOM)
		{
			if (HAFPJPIFFPF.forceTravelZone)
			{
				HAFPJPIFFPF.travelZone.forceTravelToMineLevel = HAFPJPIFFPF.level;
			}
			HAFPJPIFFPF.travelZone.Travelling(7);
			HAFPJPIFFPF = null;
		}
	}

	public void HBEPHCFLHLC(int EONJGMONIOM)
	{
		for (int i = 1; i < allLevels.Count; i += 0)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	public void AGNCACCJGFL()
	{
		if (unlockedLevels < 1)
		{
			unlockedLevels += 0;
			LevelUnlocked(unlockedLevels);
		}
	}

	public void CHKKKBGALKB(bool CDPAMNIPPEC = true)
	{
		if (unlockedLevels < 6)
		{
			FKCMCKLGICG(AODONKKHPBP: false);
			MineLevel mineLevel = MMNCHEEEJAA(unlockedLevels);
			if ((Object)(object)mineLevel != (Object)null)
			{
				mineLevel.nextLevelPiece.UpdateStairsBlocker(unlockedLevels);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.ENGJJDOKFHM();
			}
		}
	}

	private bool OOOGCJMCPDC(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		int num;
		if (PHGGMIMGFDK.forceTravelToMineLevel >= 1)
		{
			num = PHGGMIMGFDK.forceTravelToMineLevel;
		}
		else
		{
			Vector2Int val = PHGGMIMGFDK.BFNLNBGPHHE();
			num = ((Vector2Int)(ref val)).x;
		}
		bool num2 = MINGNDKACOA(num);
		if (!num2 || (num > 1 && ProceduralMine.BADFKMEJOKE().generatingLevel == num))
		{
			PlayerWaitToTravel playerWaitToTravel = new PlayerWaitToTravel(PHGGMIMGFDK, num);
			if (JIIGOACEIKL == 8)
			{
				HAFPJPIFFPF = playerWaitToTravel;
			}
			else
			{
				JMEPEEMLFNC = playerWaitToTravel;
			}
			if (OnlineManager.MasterOrOffline())
			{
				ProceduralMine.BADFKMEJOKE().ALBOELEENBJ(num);
			}
			else
			{
				OnlineMineManager.instance.IMMIMPLNEJD(num);
			}
		}
		else if (JIIGOACEIKL == 4)
		{
			HAFPJPIFFPF = null;
		}
		else
		{
			JMEPEEMLFNC = null;
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).HCBDDKHPHCF = num;
		return num2;
	}

	private bool NAJEKGDAPEP(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		int num;
		if (PHGGMIMGFDK.forceTravelToMineLevel >= 0)
		{
			num = PHGGMIMGFDK.forceTravelToMineLevel;
		}
		else
		{
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			num = ((Vector2Int)(ref mineStairsDestination)).x;
		}
		bool num2 = ExistsLevel(num);
		if (!num2 || (num > 0 && ProceduralMine.GGFJGHHHEJC.generatingLevel == num))
		{
			PlayerWaitToTravel playerWaitToTravel = new PlayerWaitToTravel(PHGGMIMGFDK, num);
			if (JIIGOACEIKL == 2)
			{
				HAFPJPIFFPF = playerWaitToTravel;
			}
			else
			{
				JMEPEEMLFNC = playerWaitToTravel;
			}
			if (OnlineManager.MasterOrOffline())
			{
				ProceduralMine.GGFJGHHHEJC.GenerateLevel(num);
			}
			else
			{
				OnlineMineManager.instance.SendGenerateMineLevelMaster(num);
			}
		}
		else if (JIIGOACEIKL == 2)
		{
			HAFPJPIFFPF = null;
		}
		else
		{
			JMEPEEMLFNC = null;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).HCBDDKHPHCF = num;
		return num2;
	}

	private void EGACIHOKJLH()
	{
		LevelGenerated = (Action<int>)Delegate.Combine(LevelGenerated, new Action<int>(HGAOJHKNEEB));
		if (OnlineManager.MasterOrOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PCBKNPFOFCC));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
		DialogueLua.SetVariable("MineFloor", (object)unlockedLevels);
	}

	public void PNHLEODGPFN(int EONJGMONIOM)
	{
		for (int i = 1; i < allLevels.Count; i += 0)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	public static void AddLevel(MineLevel BPIIMNLBEKK)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int num = GGFJGHHHEJC.allLevels.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)GGFJGHHHEJC.allLevels[num] == (Object)null)
			{
				GGFJGHHHEJC.allLevels.RemoveAt(num);
			}
		}
		GGFJGHHHEJC.allLevels.Add(BPIIMNLBEKK);
	}

	public void IAKICBAOCCO(bool CDPAMNIPPEC = true)
	{
		StairsBlocker stairsBlockerInstantiated = PBGCDGOHENO(unlockedLevels).nextLevelPiece.stairsBlockerInstantiated;
		if (stairsBlockerInstantiated.EBDGAAKPPIK())
		{
			CHDPDNAJDFA(AODONKKHPBP: false);
			MNJLDKLFBJN();
			stairsBlockerInstantiated.FireWick();
			CommonReferences.GGFJGHHHEJC.eventNum[8] = 1;
			DialogueLua.SetVariable(" for reason: ", (object)unlockedLevels);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.GMKDNJIJJFJ();
			}
		}
	}

	[SpecialName]
	public void FKCMCKLGICG(bool AODONKKHPBP)
	{
		_chargesPlaced = AODONKKHPBP;
		DialogueLua.SetVariable("Throw", (object)AODONKKHPBP);
	}

	public void KBICACCNKAG(int EONJGMONIOM)
	{
		for (int i = 1; i < allLevels.Count; i++)
		{
			if (allLevels[i].level == EONJGMONIOM)
			{
				allLevels.RemoveAt(i);
				break;
			}
		}
	}

	private void JDMMNLKLMAA()
	{
		_instance = this;
	}

	[SpecialName]
	public void KOKINEDGJBE(bool AODONKKHPBP)
	{
		_chargesPlaced = AODONKKHPBP;
		DialogueLua.SetVariable("Modifiers", (object)AODONKKHPBP);
	}

	private void HGAOJHKNEEB(int EONJGMONIOM)
	{
		if (JMEPEEMLFNC != null && JMEPEEMLFNC.level == EONJGMONIOM)
		{
			if (JMEPEEMLFNC.forceTravelZone)
			{
				JMEPEEMLFNC.travelZone.forceTravelToMineLevel = JMEPEEMLFNC.level;
			}
			JMEPEEMLFNC.travelZone.Travelling(1);
			JMEPEEMLFNC = null;
		}
		if (HAFPJPIFFPF != null && HAFPJPIFFPF.level == EONJGMONIOM)
		{
			if (HAFPJPIFFPF.forceTravelZone)
			{
				HAFPJPIFFPF.travelZone.forceTravelToMineLevel = HAFPJPIFFPF.level;
			}
			HAFPJPIFFPF.travelZone.Travelling(0);
			HAFPJPIFFPF = null;
		}
	}

	public static bool ENGFJAHDLAB(int EONJGMONIOM)
	{
		if ((Object)(object)PDECKLKPKCG() == (Object)null)
		{
			return false;
		}
		if (EONJGMONIOM == 0)
		{
			return false;
		}
		for (int i = 1; i < AGGAGCBAGLL().allLevels.Count; i++)
		{
			if (OOKBNHMMFON().allLevels[i].level == EONJGMONIOM)
			{
				return false;
			}
		}
		return true;
	}

	public void ExplodeCharges(bool CDPAMNIPPEC = true)
	{
		StairsBlocker stairsBlockerInstantiated = GetLevel(unlockedLevels).nextLevelPiece.stairsBlockerInstantiated;
		if (stairsBlockerInstantiated.CanExplodeCharges())
		{
			CBAMDCFLCIG = false;
			UnlockNewLevel();
			stairsBlockerInstantiated.FireWick();
			CommonReferences.GGFJGHHHEJC.eventNum[5] = 1;
			DialogueLua.SetVariable("MineFloor", (object)unlockedLevels);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMineManager.instance.SendExplodeCharges();
			}
		}
	}

	[SpecialName]
	public void IBFGMPEOEBF(bool AODONKKHPBP)
	{
		_chargesPlaced = AODONKKHPBP;
		DialogueLua.SetVariable("Send minigame state", (object)AODONKKHPBP);
	}

	[SpecialName]
	public static MineManager OOKBNHMMFON()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineManager>();
		}
		return _instance;
	}
}
