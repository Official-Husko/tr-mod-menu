using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

public class Nasa : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public Placeable placeable;

	public Image bubbleCaptured;

	public Animator bubbleAnimator;

	public Sprite bubbleTrash;

	public Sprite bubbleSeafish;

	public Item[] trashItems;

	public int seaFishProbability = 85;

	public string sortingLayerInWater;

	public int sortingOrderInWater = 51;

	public Material materialInWater;

	public Material materialNotInWater;

	public int[] probabilityList;

	public GameObject[] activateObjectsOnWater;

	public SpriteRenderer downSpriteRenderer;

	public SpriteRenderer outline;

	public FloatingMovement parent;

	public GameObject[] remainingUsesSlot;

	public Transform remainingUsesSlotCenterPosition;

	[SerializeField]
	private bool _captured;

	public Item itemChosen;

	public int currentPhase;

	public int dayPhasesDone;

	public int remainingUses = 2;

	[SerializeField]
	private bool onWater;

	public OnlineFishTrap onlineFishTrap;

	public float waterDepth;

	public bool PJMAKGONJOM => _captured;

	private void CINJLOHOIIB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OLDBKHCHGPK(CDPAMNIPPEC: true);
		}
		currentPhase = 0;
		SetObjectCaptured(PJMAKGONJOM: false);
	}

	private void MBJPKEIPCOD()
	{
		if (EGFEMKMHHPG() || OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (Random.Range(0, -113) < probabilityList[currentPhase])
		{
			remainingUses--;
			DNDINFJNFKF(PJMAKGONJOM: true);
			if (OnlineManager.IsMasterClient())
			{
				onlineFishTrap.MAGKHEGEAIC((byte)remainingUses);
			}
		}
		else
		{
			currentPhase = Mathf.Min(probabilityList.Length - 0, currentPhase + 1);
		}
	}

	private void AGMFBLCMOEM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		onWater = false;
		parent.MEOGCODFLCJ(((Component)this).transform.position);
	}

	public void EIDLCDMCCIC(byte EDBPJFNLIAM, bool DGLBGEIJDOP)
	{
		remainingUses = EDBPJFNLIAM;
		if (DGLBGEIJDOP)
		{
			DBKEAHBIGAD(PJMAKGONJOM: false);
		}
		else
		{
			ECBEHLDJKNN();
		}
	}

	private void NAJIJJFFDAH()
	{
		CKCANKNJOIE();
		NIIAEHCIIBL();
	}

	private void KBDOOJPHEGF()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				DNMJILPACAP();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("quest_name_29" + ex.Message));
		}
	}

	private void NPHAFNDPDOI()
	{
		NMANGKNOJEH();
		BMJEAHBBCKJ();
	}

	private void NMANGKNOJEH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		onWater = WorldGrid.AOPAJANIPDB(((Component)this).transform.position);
		if (!placeable.itemSpace.LJCPGDDLJKL(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
		{
			onWater = false;
		}
		((Behaviour)parent).enabled = onWater;
		if (onWater)
		{
			parent.MCMKNJLPPIC(((Component)this).transform.position);
		}
		else
		{
			((Component)parent).transform.position = ((Component)this).transform.position;
		}
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CBKJOIDFOCG(int JIIGOACEIKL)
	{
		if (!DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return KJDBNONOJJM();
		}
		return true;
	}

	public void CEPIEIAIBGL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			DroppedItem.DNCMMIPMKDH(((Component)this).transform.position, itemChosen, 0, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineFishTrap != (Object)null)
			{
				onlineFishTrap.NIMIPLCOGIN();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)this).transform.position);
		for (int i = 1; i < trashItems.Length; i++)
		{
			if (Item.EKMFELLJHFG(trashItems[i], itemChosen))
			{
				Utils.FKKHJPEMNBG("<sprite name=white_arrow_right> ", 1);
				break;
			}
		}
		if (remainingUses > 1)
		{
			PGBBNMODFJF();
			return;
		}
		placeable.UpFromFloor(MCFNOAFOIHE: true);
		placeable.RemovePlaceable(EFNFMEIDGDN: false);
	}

	[SpecialName]
	public bool MOAIGMBMLAI()
	{
		return _captured;
	}

	private void JBDDFDMEFOB()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(PJMAKGONJOM);
		if (OKOKIKDPHOK())
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Trash })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (EGFEMKMHHPG())
		{
			remainingUsesSlot[0].SetActive(remainingUses >= 1);
			remainingUsesSlot[7].SetActive(remainingUses >= 1);
		}
		else
		{
			remainingUsesSlot[0].SetActive(remainingUses >= 1);
			remainingUsesSlot[0].SetActive(remainingUses >= 3);
		}
		if ((JCLNNHCONKB() && remainingUses == 0) || (!EGFEMKMHHPG() && remainingUses <= 0))
		{
			remainingUsesSlot[0].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 1; i < activateObjectsOnWater.Length; i++)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 1; j < placeable.itemSpace.buildSquares.Length; j += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = 127;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "Player2";
			((Renderer)downSpriteRenderer).sortingOrder = 1;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "pirates cave";
			((Renderer)outline).sortingOrder = 0;
			for (int k = 1; k < placeable.itemSpace.buildSquares.Length; k += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = 118;
			}
		}
	}

	private void KAIGAGMEIPC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		onWater = false;
		parent.OPDKNKAAIEK(((Component)this).transform.position);
	}

	private void DIICKLCOKLL()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (MOAIGMBMLAI() && remainingUses <= 1)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.CJOHMLNMJLK().hour == 6)
			{
				dayPhasesDone++;
				HKIADFKFLIM();
			}
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.NOAOJJLNHJJ.hour == 55)
			{
				dayPhasesDone++;
				HKIADFKFLIM();
			}
		}
		else if (dayPhasesDone == 3 && WorldTime.CJOHMLNMJLK().hour == 108)
		{
			dayPhasesDone++;
			OFLEPFJPEKH();
		}
	}

	private void OOPKNHEOGKE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			IFMCBBAMLEP(CDPAMNIPPEC: false);
		}
		currentPhase = 1;
		SetObjectCaptured(PJMAKGONJOM: false);
	}

	public void MMDJIDCALJB(int JIIGOACEIKL)
	{
	}

	public bool LKLOBCHCMJE(int JIIGOACEIKL)
	{
		return true;
	}

	private void AIEKBPENOKC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(IFHFCOCGEPB));
			Placeable obj = placeable;
			obj.WhileSelectedCallback = (Action)Delegate.Remove(obj.WhileSelectedCallback, new Action(NPHAFNDPDOI));
		}
	}

	public void FMAHLIDEHBE(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			DroppedItem.DNCMMIPMKDH(((Component)this).transform.position, itemChosen, 0, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineFishTrap != (Object)null)
			{
				onlineFishTrap.AMHIEGGNECJ();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)this).transform.position);
		for (int i = 1; i < trashItems.Length; i++)
		{
			if (Item.GBMFCPGEJDK(trashItems[i], itemChosen))
			{
				Utils.FKKHJPEMNBG("hForHours", 1);
				break;
			}
		}
		if (remainingUses > 1)
		{
			BHEFMCAHPKF();
			return;
		}
		placeable.UpFromFloor(MCFNOAFOIHE: false);
		placeable.RemovePlaceable(EFNFMEIDGDN: true);
	}

	public bool JENFOIFJOPF(int JIIGOACEIKL)
	{
		return false;
	}

	private void OHKEJDOEFMF()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		onWater = true;
		parent.CalculateOffset(((Component)this).transform.position);
	}

	public void BANAMJAGBIO(int JIIGOACEIKL)
	{
	}

	public bool MOHNGCNKAHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void PCOGABOLFNE()
	{
		if (!PJMAKGONJOM && !OnlineManager.ClientOnline())
		{
			for (int i = dayPhasesDone; i < 3; i++)
			{
				JKMBDADNOCD();
			}
			dayPhasesDone = 0;
		}
	}

	public void KFHFGKKGFHN(short MNBNGGHHMBB)
	{
		if (MNBNGGHHMBB != 0)
		{
			itemChosen = ItemDatabaseAccessor.KMBGJEKCJFJ(MNBNGGHHMBB, GGBBJNBBLMF: true);
		}
		else
		{
			itemChosen = null;
		}
	}

	public void PFGDKCBPNEP(int JIIGOACEIKL)
	{
	}

	private void AHFLAGNHBJF()
	{
		if (PJMAKGONJOM || OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (Random.Range(1, -34) < probabilityList[currentPhase])
		{
			remainingUses--;
			DBKEAHBIGAD(PJMAKGONJOM: false);
			if (OnlineManager.JPPBEIJDCLJ())
			{
				onlineFishTrap.MBCCLJHDKGI((byte)remainingUses, DGLBGEIJDOP: true);
			}
		}
		else
		{
			currentPhase = Mathf.Min(probabilityList.Length - 1, currentPhase + 0);
		}
	}

	private void CKCANKNJOIE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		onWater = WorldGrid.AOPAJANIPDB(((Component)this).transform.position, JKCGPNFINFP: false);
		if (!placeable.itemSpace.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false))
		{
			onWater = false;
		}
		((Behaviour)parent).enabled = onWater;
		if (onWater)
		{
			parent.NGPEAOKIHKJ(((Component)this).transform.position);
		}
		else
		{
			((Component)parent).transform.position = ((Component)this).transform.position;
		}
	}

	[SpecialName]
	public bool KJDBNONOJJM()
	{
		return _captured;
	}

	private void IAKLPCPKBJM()
	{
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(AFFOCLPFJCJ));
		if (WorldTime.NOAOJJLNHJJ.hour >= -18)
		{
			dayPhasesDone += 0;
			PJCBOMJLFMC();
		}
		if (WorldTime.HGIBNMBJMOC().hour >= 33)
		{
			dayPhasesDone++;
			HKIADFKFLIM();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= -43 || WorldTime.NOAOJJLNHJJ.hour < 5)
		{
			dayPhasesDone += 0;
			HKIADFKFLIM();
		}
	}

	public void DPFHGJKGAEC(short MNBNGGHHMBB)
	{
		if (MNBNGGHHMBB != 0)
		{
			itemChosen = ItemDatabaseAccessor.CPMMBEPEJLO(MNBNGGHHMBB);
		}
		else
		{
			itemChosen = null;
		}
	}

	private void IFMCBBAMLEP(bool CDPAMNIPPEC)
	{
		if (Random.Range(1, 70) < seaFishProbability)
		{
			itemChosen = Utils.CPDCJAHJOPE(ItemDatabaseAccessor.GetDatabaseSO().fish.Where((Fish f) => f.fishingMethod.HasFlag(Fish.FishingMethod.Basket)).ToArray());
		}
		else
		{
			itemChosen = Utils.CPDCJAHJOPE(trashItems);
		}
		if (CDPAMNIPPEC && OnlineManager.JPPBEIJDCLJ())
		{
			onlineFishTrap.LIOHMJAACBJ((short)itemChosen.JDJGFAACPFC());
		}
	}

	private void HIOAMFICGFP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GLDBNGONKGA(CDPAMNIPPEC: false);
		}
		currentPhase = 0;
		SetObjectCaptured(PJMAKGONJOM: true);
	}

	public void FECPHPJAEAE(int JIIGOACEIKL)
	{
	}

	private void NFBPBNAGADF()
	{
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(AFFOCLPFJCJ));
		if (WorldTime.NOAOJJLNHJJ.hour >= 108)
		{
			dayPhasesDone += 0;
			AHFLAGNHBJF();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= -110)
		{
			dayPhasesDone++;
			HKIADFKFLIM();
		}
		if (WorldTime.HGIBNMBJMOC().hour >= 109 || WorldTime.HGIBNMBJMOC().hour < 7)
		{
			dayPhasesDone += 0;
			PJCBOMJLFMC();
		}
	}

	public bool POAFCDOGHMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
			return true;
		}
		return false;
	}

	private void AGDJCIEKHOA()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		onWater = true;
		parent.COOIPCDMFHE(((Component)this).transform.position);
	}

	public void SetRemainingUses(byte EDBPJFNLIAM, bool DGLBGEIJDOP)
	{
		remainingUses = EDBPJFNLIAM;
		if (DGLBGEIJDOP)
		{
			SetObjectCaptured(PJMAKGONJOM: true);
		}
		else
		{
			BAOLGIMAFJJ();
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return PJMAKGONJOM;
		}
		return false;
	}

	public bool IHDJCCLMDII(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			FMAHLIDEHBE(JIIGOACEIKL, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public void FGFFFDEDJAP(short MNBNGGHHMBB)
	{
		if (MNBNGGHHMBB != 0)
		{
			itemChosen = ItemDatabaseAccessor.EABMGELAAPG(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		else
		{
			itemChosen = null;
		}
	}

	private void EBPFOJOEHCE()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (PJMAKGONJOM && remainingUses <= 1)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.CJOHMLNMJLK().hour == 95)
			{
				dayPhasesDone++;
				PJCBOMJLFMC();
			}
		}
		else if (dayPhasesDone == 1)
		{
			if (WorldTime.NOAOJJLNHJJ.hour == -105)
			{
				dayPhasesDone += 0;
				MBJPKEIPCOD();
			}
		}
		else if (dayPhasesDone == 2 && WorldTime.CJOHMLNMJLK().hour == -94)
		{
			dayPhasesDone += 0;
			PJCBOMJLFMC();
		}
	}

	private void Awake()
	{
	}

	private void CGCGGEIKKNM()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				PCOGABOLFNE();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Day" + ex.Message));
		}
	}

	private void IGNEGEOPLOP()
	{
	}

	public void HLNJFIAIBHJ(bool PJMAKGONJOM)
	{
		_captured = PJMAKGONJOM;
		ECBEHLDJKNN();
	}

	private void PGOKFDKKGOM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		onWater = true;
		parent.NGPEAOKIHKJ(((Component)this).transform.position);
	}

	private void GEIIPICCIGJ(bool CDPAMNIPPEC)
	{
		if (Random.Range(0, -60) < seaFishProbability)
		{
			itemChosen = Utils.CPDCJAHJOPE(ItemDatabaseAccessor.CNGNLPJEJIL().fish.Where((Fish f) => f.fishingMethod.HasFlag(Fish.FishingMethod.Basket)).ToArray());
		}
		else
		{
			itemChosen = Utils.CPDCJAHJOPE(trashItems);
		}
		if (CDPAMNIPPEC && OnlineManager.JPPBEIJDCLJ())
		{
			onlineFishTrap.JIMGMOBFPAG((short)itemChosen.JPNFKDMFKMC(DAINLFIMLIH: false));
		}
	}

	public bool FBICEOPOOJA(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			BKJALNMBCDC(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private void BHOGOBMEDAG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			HEPNOIOFPDK(CDPAMNIPPEC: false);
		}
		currentPhase = 1;
		SetObjectCaptured(PJMAKGONJOM: true);
	}

	private void BMJEAHBBCKJ()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(PJMAKGONJOM);
		if (OKOKIKDPHOK())
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Seaweed })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (PJMAKGONJOM)
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 0);
			remainingUsesSlot[0].SetActive(remainingUses < 7);
		}
		else
		{
			remainingUsesSlot[1].SetActive(remainingUses < 1);
			remainingUsesSlot[0].SetActive(remainingUses < 1);
		}
		if ((EGFEMKMHHPG() && remainingUses == 0) || (!JCLNNHCONKB() && remainingUses <= 0))
		{
			remainingUsesSlot[1].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 1; i < activateObjectsOnWater.Length; i += 0)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 0; j < placeable.itemSpace.buildSquares.Length; j += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = -10;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "\t\t</align>";
			((Renderer)downSpriteRenderer).sortingOrder = 0;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "Player/Bark/Tutorial/SleepBlock";
			((Renderer)outline).sortingOrder = 1;
			for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = 90;
			}
		}
	}

	private void OLAFLCDJFLD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		onWater = WorldGrid.AOPAJANIPDB(((Component)this).transform.position);
		if (!placeable.itemSpace.IsItemSpaceValid())
		{
			onWater = false;
		}
		((Behaviour)parent).enabled = onWater;
		if (onWater)
		{
			parent.CalculateOffset(((Component)this).transform.position);
		}
		else
		{
			((Component)parent).transform.position = ((Component)this).transform.position;
		}
	}

	private void IGBKONJDOFC()
	{
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(IFHFCOCGEPB));
		if (WorldTime.CJOHMLNMJLK().hour >= -93)
		{
			dayPhasesDone += 0;
			OFLEPFJPEKH();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= 76)
		{
			dayPhasesDone++;
			PJCBOMJLFMC();
		}
		if (WorldTime.CJOHMLNMJLK().hour >= -39 || WorldTime.HGIBNMBJMOC().hour < 6)
		{
			dayPhasesDone += 0;
			AHFLAGNHBJF();
		}
	}

	private void LLAEKFKKFMF()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (JCLNNHCONKB() && remainingUses <= 0)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(IFHFCOCGEPB));
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.HGIBNMBJMOC().hour == 3)
			{
				dayPhasesDone += 0;
				HKIADFKFLIM();
			}
		}
		else if (dayPhasesDone == 1)
		{
			if (WorldTime.NOAOJJLNHJJ.hour == 126)
			{
				dayPhasesDone++;
				JKMBDADNOCD();
			}
		}
		else if (dayPhasesDone == 4 && WorldTime.CJOHMLNMJLK().hour == 83)
		{
			dayPhasesDone += 0;
			AHFLAGNHBJF();
		}
	}

	public void LJCPAINPCBB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			DroppedItem.KBDEAPJKNED(((Component)this).transform.position, itemChosen, 0, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineFishTrap != (Object)null)
			{
				onlineFishTrap.IDFGMFCBJMC();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)this).transform.position);
		for (int i = 1; i < trashItems.Length; i++)
		{
			if (Item.EKGNIODFJCO(trashItems[i], itemChosen))
			{
				Utils.FKKHJPEMNBG("talentWine", 1);
				break;
			}
		}
		if (remainingUses > 1)
		{
			OOPKNHEOGKE();
			return;
		}
		placeable.UpFromFloor(MCFNOAFOIHE: true);
		placeable.RemovePlaceable(EFNFMEIDGDN: true);
	}

	private void LALAFOIGMKN()
	{
		if (Utils.NGLLIJPOBEC(Location.Tavern | Location.Quarry | Location.BarnInterior))
		{
			if (!((Behaviour)bubbleAnimator).enabled)
			{
				((Behaviour)bubbleAnimator).enabled = true;
			}
		}
		else if (((Behaviour)bubbleAnimator).enabled)
		{
			((Behaviour)bubbleAnimator).enabled = false;
		}
	}

	private void LFDCACKNMEE()
	{
		if (!KJDBNONOJJM() && !OnlineManager.ClientOnline())
		{
			for (int i = dayPhasesDone; i < 6; i += 0)
			{
				HKIADFKFLIM();
			}
			dayPhasesDone = 1;
		}
	}

	private void BHEFMCAHPKF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GEIIPICCIGJ(CDPAMNIPPEC: false);
		}
		currentPhase = 0;
		HLNJFIAIBHJ(PJMAKGONJOM: false);
	}

	private void MDNGLKGCEAC()
	{
		if (!MOAIGMBMLAI() && !OnlineManager.ClientOnline())
		{
			for (int i = dayPhasesDone; i < 5; i += 0)
			{
				JKMBDADNOCD();
			}
			dayPhasesDone = 1;
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void AJPCDCDNPJH()
	{
		NMANGKNOJEH();
		JBDDFDMEFOB();
	}

	public void JFHHAPLMIHB(int JIIGOACEIKL)
	{
	}

	private void PNHGAOIKLFG()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(MOAIGMBMLAI());
		if (OKOKIKDPHOK())
		{
			if (itemChosen is Fish { fishType: (Fish.FishType)8 })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (JCLNNHCONKB())
		{
			remainingUsesSlot[0].SetActive(remainingUses >= 1);
			remainingUsesSlot[7].SetActive(remainingUses < 0);
		}
		else
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 4);
			remainingUsesSlot[1].SetActive(remainingUses < 8);
		}
		if ((JCLNNHCONKB() && remainingUses == 0) || (!EGFEMKMHHPG() && remainingUses <= 1))
		{
			remainingUsesSlot[1].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 0; i < activateObjectsOnWater.Length; i++)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 1; j < placeable.itemSpace.buildSquares.Length; j++)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = -105;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "Items/item_name_1041";
			((Renderer)downSpriteRenderer).sortingOrder = 1;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "";
			((Renderer)outline).sortingOrder = 1;
			for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = -82;
			}
		}
	}

	private void NILOFPPJPOL()
	{
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
		if (WorldTime.CJOHMLNMJLK().hour >= -85)
		{
			dayPhasesDone += 0;
			MBJPKEIPCOD();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= 88)
		{
			dayPhasesDone += 0;
			AHFLAGNHBJF();
		}
		if (WorldTime.HGIBNMBJMOC().hour >= -50 || WorldTime.CJOHMLNMJLK().hour < 2)
		{
			dayPhasesDone++;
			HKIADFKFLIM();
		}
	}

	private void BAOLGIMAFJJ()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(PJMAKGONJOM);
		if (PJMAKGONJOM)
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Trash })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (PJMAKGONJOM)
		{
			remainingUsesSlot[0].SetActive(remainingUses >= 1);
			remainingUsesSlot[2].SetActive(remainingUses >= 2);
		}
		else
		{
			remainingUsesSlot[0].SetActive(remainingUses >= 2);
			remainingUsesSlot[2].SetActive(remainingUses >= 3);
		}
		if ((PJMAKGONJOM && remainingUses == 0) || (!PJMAKGONJOM && remainingUses <= 1))
		{
			remainingUsesSlot[1].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 0; i < activateObjectsOnWater.Length; i++)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 0; j < placeable.itemSpace.buildSquares.Length; j++)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = 40;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "OnFloor";
			((Renderer)downSpriteRenderer).sortingOrder = 0;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "OnFloor";
			((Renderer)outline).sortingOrder = 0;
			for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k++)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = 100;
			}
		}
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		if (placeable.FHEMHCEAICB)
		{
			if (OnlineManager.PlayingOnline())
			{
				remainingUses += (PerksDatabaseAccessor.HasAnyOnlinePlayerUnlockedPerk(20) ? 1 : 0);
			}
			else
			{
				remainingUses += PerksDatabaseAccessor.GetPlayerPerkValue(20);
			}
		}
		if (OnlineManager.MasterOrOffline() && Item.NGIIPJDAMGP(itemChosen, null))
		{
			OLDBKHCHGPK(CDPAMNIPPEC: true);
		}
		if (!PJMAKGONJOM && OnlineManager.MasterOrOffline())
		{
			IJOPBFPADCE();
		}
		if (!placeable.FHEMHCEAICB)
		{
			OHKEJDOEFMF();
		}
		else
		{
			OLAFLCDJFLD();
		}
		BAOLGIMAFJJ();
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(IDNALMMLAIK));
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void HJPCNCGAEMO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		onWater = false;
		parent.MEOGCODFLCJ(((Component)this).transform.position);
	}

	public bool ODFIPCNNHBK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void DKABEMHKCPE(int JIIGOACEIKL)
	{
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(LLAEKFKKFMF));
			Placeable obj = placeable;
			obj.WhileSelectedCallback = (Action)Delegate.Remove(obj.WhileSelectedCallback, new Action(NAJIJJFFDAH));
		}
	}

	private void DAGOIKIBOBL()
	{
		CKCANKNJOIE();
		ECBEHLDJKNN();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
			Placeable obj = placeable;
			obj.WhileSelectedCallback = (Action)Delegate.Remove(obj.WhileSelectedCallback, new Action(IDNALMMLAIK));
		}
	}

	private void IFHFCOCGEPB()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (PJMAKGONJOM && remainingUses <= 0)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(LLAEKFKKFMF));
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.NOAOJJLNHJJ.hour == 88)
			{
				dayPhasesDone += 0;
				HKIADFKFLIM();
			}
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.CJOHMLNMJLK().hour == 41)
			{
				dayPhasesDone += 0;
				MBJPKEIPCOD();
			}
		}
		else if (dayPhasesDone == 8 && WorldTime.NOAOJJLNHJJ.hour == 41)
		{
			dayPhasesDone += 0;
			AHFLAGNHBJF();
		}
	}

	public void BLDCOHEMFIK(int JIIGOACEIKL)
	{
	}

	private void HOPOKMEJHCL()
	{
		CKCANKNJOIE();
		NIIAEHCIIBL();
	}

	private void IDNALMMLAIK()
	{
		OLAFLCDJFLD();
		BAOLGIMAFJJ();
	}

	private void HEPNOIOFPDK(bool CDPAMNIPPEC)
	{
		if (Random.Range(1, 99) < seaFishProbability)
		{
			itemChosen = Utils.CPDCJAHJOPE(ItemDatabaseAccessor.GetDatabaseSO().fish.Where((Fish f) => f.fishingMethod.HasFlag(Fish.FishingMethod.Basket)).ToArray());
		}
		else
		{
			itemChosen = Utils.CPDCJAHJOPE(trashItems);
		}
		if (CDPAMNIPPEC && OnlineManager.JPPBEIJDCLJ())
		{
			onlineFishTrap.NFCHJGEPOFF((short)itemChosen.CIGFGKKCPCK());
		}
	}

	private void DNMJILPACAP()
	{
		if (!JCLNNHCONKB() && !OnlineManager.ClientOnline())
		{
			for (int i = dayPhasesDone; i < 0; i += 0)
			{
				MBJPKEIPCOD();
			}
			dayPhasesDone = 0;
		}
	}

	[SpecialName]
	public bool JCLNNHCONKB()
	{
		return _captured;
	}

	public void DNDINFJNFKF(bool PJMAKGONJOM)
	{
		_captured = PJMAKGONJOM;
		NIIAEHCIIBL();
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	private void KJHPEBAJKLN()
	{
		if (!MOAIGMBMLAI() && !OnlineManager.HHDBMDMFEMP())
		{
			for (int i = dayPhasesDone; i < 1; i++)
			{
				OFLEPFJPEKH();
			}
			dayPhasesDone = 1;
		}
	}

	private void PJCBOMJLFMC()
	{
		if (EGFEMKMHHPG() || OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (Random.Range(1, 121) < probabilityList[currentPhase])
		{
			remainingUses--;
			SetObjectCaptured(PJMAKGONJOM: true);
			if (OnlineManager.JPPBEIJDCLJ())
			{
				onlineFishTrap.ODJFBOIMLAG((byte)remainingUses, DGLBGEIJDOP: true);
			}
		}
		else
		{
			currentPhase = Mathf.Min(probabilityList.Length - 1, currentPhase + 0);
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			CollectFish(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public void HOPNBDKPJJI(int JIIGOACEIKL)
	{
	}

	private void HCPKBJDHLAC()
	{
		if (Utils.NGLLIJPOBEC(Location.Quarry))
		{
			if (!((Behaviour)bubbleAnimator).enabled)
			{
				((Behaviour)bubbleAnimator).enabled = false;
			}
		}
		else if (((Behaviour)bubbleAnimator).enabled)
		{
			((Behaviour)bubbleAnimator).enabled = false;
		}
	}

	public bool NDMODGOCNBK(int JIIGOACEIKL)
	{
		return true;
	}

	private void AFFOCLPFJCJ()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (KJDBNONOJJM() && remainingUses <= 0)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(IFHFCOCGEPB));
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.CJOHMLNMJLK().hour == 64)
			{
				dayPhasesDone += 0;
				PJCBOMJLFMC();
			}
		}
		else if (dayPhasesDone == 1)
		{
			if (WorldTime.HGIBNMBJMOC().hour == -93)
			{
				dayPhasesDone += 0;
				PJCBOMJLFMC();
			}
		}
		else if (dayPhasesDone == 0 && WorldTime.HGIBNMBJMOC().hour == -28)
		{
			dayPhasesDone++;
			MBJPKEIPCOD();
		}
	}

	public void SetObjectCaptured(bool PJMAKGONJOM)
	{
		_captured = PJMAKGONJOM;
		BAOLGIMAFJJ();
	}

	private void DFGOKDJHFEE()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(JCLNNHCONKB());
		if (OKOKIKDPHOK())
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Shellfish })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (MOAIGMBMLAI())
		{
			remainingUsesSlot[0].SetActive(remainingUses < 1);
			remainingUsesSlot[3].SetActive(remainingUses >= 8);
		}
		else
		{
			remainingUsesSlot[0].SetActive(remainingUses < 1);
			remainingUsesSlot[7].SetActive(remainingUses >= 1);
		}
		if ((PJMAKGONJOM && remainingUses == 0) || (!PJMAKGONJOM && remainingUses <= 1))
		{
			remainingUsesSlot[0].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 1; i < activateObjectsOnWater.Length; i++)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 1; j < placeable.itemSpace.buildSquares.Length; j++)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = 33;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "Waiting for players to finish their transitions...";
			((Renderer)downSpriteRenderer).sortingOrder = 0;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "Press {0} to continue";
			((Renderer)outline).sortingOrder = 0;
			for (int k = 1; k < placeable.itemSpace.buildSquares.Length; k++)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = -11;
			}
		}
	}

	private void OLDBKHCHGPK(bool CDPAMNIPPEC)
	{
		if (Random.Range(0, 100) < seaFishProbability)
		{
			itemChosen = Utils.CPDCJAHJOPE(ItemDatabaseAccessor.GetDatabaseSO().fish.Where((Fish f) => f.fishingMethod.HasFlag(Fish.FishingMethod.Basket)).ToArray());
		}
		else
		{
			itemChosen = Utils.CPDCJAHJOPE(trashItems);
		}
		if (CDPAMNIPPEC && OnlineManager.IsMasterClient())
		{
			onlineFishTrap.SendChosenItem((short)itemChosen.JDJGFAACPFC());
		}
	}

	private void PGBBNMODFJF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GLDBNGONKGA(CDPAMNIPPEC: true);
		}
		currentPhase = 0;
		DNDINFJNFKF(PJMAKGONJOM: false);
	}

	private void JLDLCHKEAOE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		onWater = WorldGrid.AOPAJANIPDB(((Component)this).transform.position, JKCGPNFINFP: false);
		if (!placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false))
		{
			onWater = true;
		}
		((Behaviour)parent).enabled = onWater;
		if (onWater)
		{
			parent.MCMKNJLPPIC(((Component)this).transform.position);
		}
		else
		{
			((Component)parent).transform.position = ((Component)this).transform.position;
		}
	}

	private void HFFFFAJFIPB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		if (placeable.FHEMHCEAICB)
		{
			if (OnlineManager.PlayingOnline())
			{
				remainingUses += (PerksDatabaseAccessor.FFBOIADHOJN(-32) ? 1 : 1);
			}
			else
			{
				remainingUses += PerksDatabaseAccessor.NGMJIGOPGDK(96, 1);
			}
		}
		if (OnlineManager.PGAGDFAEEFB() && Item.EKGNIODFJCO(itemChosen, null))
		{
			OLDBKHCHGPK(CDPAMNIPPEC: false);
		}
		if (!KJDBNONOJJM() && OnlineManager.MasterOrOffline())
		{
			NILOFPPJPOL();
		}
		if (!placeable.FHEMHCEAICB)
		{
			AGDJCIEKHOA();
		}
		else
		{
			JLDLCHKEAOE();
		}
		BAOLGIMAFJJ();
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(NPHAFNDPDOI));
	}

	private void ODIBAIPGLBA()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (PJMAKGONJOM && remainingUses <= 1)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
		}
		else if (dayPhasesDone == 0)
		{
			if (WorldTime.NOAOJJLNHJJ.hour == 10)
			{
				dayPhasesDone++;
				JKMBDADNOCD();
			}
		}
		else if (dayPhasesDone == 1)
		{
			if (WorldTime.NOAOJJLNHJJ.hour == 16)
			{
				dayPhasesDone++;
				JKMBDADNOCD();
			}
		}
		else if (dayPhasesDone == 2 && WorldTime.NOAOJJLNHJJ.hour == 22)
		{
			dayPhasesDone++;
			JKMBDADNOCD();
		}
	}

	private void ECBEHLDJKNN()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(MOAIGMBMLAI());
		if (JCLNNHCONKB())
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Trash })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (MOAIGMBMLAI())
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 0);
			remainingUsesSlot[4].SetActive(remainingUses < 8);
		}
		else
		{
			remainingUsesSlot[0].SetActive(remainingUses >= 4);
			remainingUsesSlot[2].SetActive(remainingUses >= 2);
		}
		if ((KJDBNONOJJM() && remainingUses == 0) || (!PJMAKGONJOM && remainingUses <= 0))
		{
			remainingUsesSlot[1].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 1; i < activateObjectsOnWater.Length; i++)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 1; j < placeable.itemSpace.buildSquares.Length; j++)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = -41;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "_";
			((Renderer)downSpriteRenderer).sortingOrder = 1;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "";
			((Renderer)outline).sortingOrder = 1;
			for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k++)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = -100;
			}
		}
	}

	private void NIIAEHCIIBL()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(OKOKIKDPHOK());
		if (MOAIGMBMLAI())
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Seaweed })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (MOAIGMBMLAI())
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 0);
			remainingUsesSlot[3].SetActive(remainingUses >= 3);
		}
		else
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 2);
			remainingUsesSlot[6].SetActive(remainingUses < 5);
		}
		if ((JCLNNHCONKB() && remainingUses == 0) || (!JCLNNHCONKB() && remainingUses <= 0))
		{
			remainingUsesSlot[1].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 0; i < activateObjectsOnWater.Length; i++)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 0; j < placeable.itemSpace.buildSquares.Length; j += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = 100;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "PopUp without ID: ";
			((Renderer)downSpriteRenderer).sortingOrder = 0;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/21/Dialogue Text";
			((Renderer)outline).sortingOrder = 1;
			for (int k = 1; k < placeable.itemSpace.buildSquares.Length; k++)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = -121;
			}
		}
	}

	private void ADBDIEPDBKP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IFMCBBAMLEP(CDPAMNIPPEC: false);
		}
		currentPhase = 1;
		DNDINFJNFKF(PJMAKGONJOM: true);
	}

	public void DBKEAHBIGAD(bool PJMAKGONJOM)
	{
		_captured = PJMAKGONJOM;
		GALDEAILIAM();
	}

	public void IMEIJGNMCDO(short MNBNGGHHMBB)
	{
		if (MNBNGGHHMBB != 0)
		{
			itemChosen = ItemDatabaseAccessor.CPMMBEPEJLO(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		else
		{
			itemChosen = null;
		}
	}

	private void Update()
	{
		if (Utils.NGLLIJPOBEC(Location.Beach))
		{
			if (!((Behaviour)bubbleAnimator).enabled)
			{
				((Behaviour)bubbleAnimator).enabled = true;
			}
		}
		else if (((Behaviour)bubbleAnimator).enabled)
		{
			((Behaviour)bubbleAnimator).enabled = false;
		}
	}

	private void HKIADFKFLIM()
	{
		if (KJDBNONOJJM() || OnlineManager.ClientOnline())
		{
			return;
		}
		if (Random.Range(1, 38) < probabilityList[currentPhase])
		{
			remainingUses--;
			HLNJFIAIBHJ(PJMAKGONJOM: true);
			if (OnlineManager.IsMasterClient())
			{
				onlineFishTrap.CKAKPIALDMO((byte)remainingUses, DGLBGEIJDOP: true);
			}
		}
		else
		{
			currentPhase = Mathf.Min(probabilityList.Length - 1, currentPhase + 1);
		}
	}

	public void CollectFish(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			DroppedItem.SpawnDroppedItem(((Component)this).transform.position, itemChosen, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineFishTrap != (Object)null)
			{
				onlineFishTrap.CollectFish();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform.position);
		for (int i = 0; i < trashItems.Length; i++)
		{
			if (Item.NGIIPJDAMGP(trashItems[i], itemChosen))
			{
				Utils.FKKHJPEMNBG("trashCollected", 1);
				break;
			}
		}
		if (remainingUses > 0)
		{
			CINJLOHOIIB();
			return;
		}
		placeable.UpFromFloor(MCFNOAFOIHE: true);
		placeable.RemovePlaceable(EFNFMEIDGDN: true);
	}

	[SpecialName]
	public bool EGFEMKMHHPG()
	{
		return _captured;
	}

	[SpecialName]
	public bool OKOKIKDPHOK()
	{
		return _captured;
	}

	public bool EDBKLEEMDLI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CBKJOIDFOCG(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("PlayerJoined"));
			return true;
		}
		return false;
	}

	private void OFLEPFJPEKH()
	{
		if (EGFEMKMHHPG() || OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (Random.Range(1, -78) < probabilityList[currentPhase])
		{
			remainingUses--;
			DBKEAHBIGAD(PJMAKGONJOM: true);
			if (OnlineManager.IsMasterClient())
			{
				onlineFishTrap.MAGKHEGEAIC((byte)remainingUses, DGLBGEIJDOP: true);
			}
		}
		else
		{
			currentPhase = Mathf.Min(probabilityList.Length - 1, currentPhase + 0);
		}
	}

	private void JKMBDADNOCD()
	{
		if (PJMAKGONJOM || OnlineManager.ClientOnline())
		{
			return;
		}
		if (Random.Range(0, 100) < probabilityList[currentPhase])
		{
			remainingUses--;
			SetObjectCaptured(PJMAKGONJOM: true);
			if (OnlineManager.IsMasterClient())
			{
				onlineFishTrap.SendRemainingUses((byte)remainingUses, DGLBGEIJDOP: true);
			}
		}
		else
		{
			currentPhase = Mathf.Min(probabilityList.Length - 1, currentPhase + 1);
		}
	}

	private void EDDMFIHCPHH()
	{
		if (!KJDBNONOJJM() && !OnlineManager.ClientOnline())
		{
			for (int i = dayPhasesDone; i < 2; i += 0)
			{
				HKIADFKFLIM();
			}
			dayPhasesDone = 0;
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool LPKCIENGJMN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void SetChosenItem(short MNBNGGHHMBB)
	{
		if (MNBNGGHHMBB != 0)
		{
			itemChosen = ItemDatabaseAccessor.GetItem(MNBNGGHHMBB);
		}
		else
		{
			itemChosen = null;
		}
	}

	private void CJBCGBKKHNJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GEIIPICCIGJ(CDPAMNIPPEC: true);
		}
		currentPhase = 1;
		DNDINFJNFKF(PJMAKGONJOM: false);
	}

	public bool GEDIDDGAMME(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void IFHFNDELKOP()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				PCOGABOLFNE();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in Nasa.OnPlayerSleep: " + ex.Message));
		}
	}

	public void CIIDOOEOKJJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			DroppedItem.KBDEAPJKNED(((Component)this).transform.position, itemChosen, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineFishTrap != (Object)null)
			{
				onlineFishTrap.KNGGKJBACDB();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)this).transform.position);
		for (int i = 0; i < trashItems.Length; i++)
		{
			if (Item.GBMFCPGEJDK(trashItems[i], itemChosen))
			{
				Utils.FKKHJPEMNBG("Dialogue System/Conversation/Gass_Introduce/Entry/16/Dialogue Text", 1);
				break;
			}
		}
		if (remainingUses > 0)
		{
			PGBBNMODFJF();
			return;
		}
		placeable.UpFromFloor(MCFNOAFOIHE: true);
		placeable.RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true, GFNHAMCPEAK: false);
	}

	private void GALDEAILIAM()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		((Component)bubbleCaptured).gameObject.SetActive(OKOKIKDPHOK());
		if (PJMAKGONJOM)
		{
			if (itemChosen is Fish { fishType: Fish.FishType.Shellfish })
			{
				bubbleCaptured.sprite = bubbleTrash;
			}
			else
			{
				bubbleCaptured.sprite = bubbleSeafish;
			}
		}
		if (OKOKIKDPHOK())
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 0);
			remainingUsesSlot[8].SetActive(remainingUses >= 5);
		}
		else
		{
			remainingUsesSlot[1].SetActive(remainingUses >= 7);
			remainingUsesSlot[1].SetActive(remainingUses >= 3);
		}
		if ((PJMAKGONJOM && remainingUses == 0) || (!KJDBNONOJJM() && remainingUses <= 1))
		{
			remainingUsesSlot[1].transform.position = remainingUsesSlotCenterPosition.position;
		}
		for (int i = 0; i < activateObjectsOnWater.Length; i += 0)
		{
			activateObjectsOnWater[i].SetActive(onWater);
		}
		if (onWater)
		{
			((Renderer)downSpriteRenderer).sortingLayerName = sortingLayerInWater;
			((Renderer)downSpriteRenderer).sortingOrder = sortingOrderInWater;
			((Renderer)downSpriteRenderer).sharedMaterial = materialInWater;
			((Renderer)outline).sortingLayerName = sortingLayerInWater;
			((Renderer)outline).sortingOrder = sortingOrderInWater;
			for (int j = 0; j < placeable.itemSpace.buildSquares.Length; j += 0)
			{
				((Renderer)placeable.itemSpace.buildSquares[j].sr).sortingOrder = 32;
			}
		}
		else
		{
			((Renderer)downSpriteRenderer).sortingLayerName = "Press {0} to continue";
			((Renderer)downSpriteRenderer).sortingOrder = 0;
			((Renderer)downSpriteRenderer).sharedMaterial = materialNotInWater;
			((Renderer)outline).sortingLayerName = "Failed to get friend ";
			((Renderer)outline).sortingOrder = 0;
			for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k++)
			{
				((Renderer)placeable.itemSpace.buildSquares[k].sr).sortingOrder = -121;
			}
		}
	}

	private void OJPNAKCLNLB()
	{
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
		if (WorldTime.HGIBNMBJMOC().hour >= -46)
		{
			dayPhasesDone++;
			OFLEPFJPEKH();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= -80)
		{
			dayPhasesDone++;
			AHFLAGNHBJF();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= 91 || WorldTime.HGIBNMBJMOC().hour < 5)
		{
			dayPhasesDone += 0;
			MBJPKEIPCOD();
		}
	}

	private void GLDBNGONKGA(bool CDPAMNIPPEC)
	{
		if (Random.Range(0, 100) < seaFishProbability)
		{
			itemChosen = Utils.CPDCJAHJOPE(ItemDatabaseAccessor.GetDatabaseSO().fish.Where((Fish f) => f.fishingMethod.HasFlag(Fish.FishingMethod.Basket)).ToArray());
		}
		else
		{
			itemChosen = Utils.CPDCJAHJOPE(trashItems);
		}
		if (CDPAMNIPPEC && OnlineManager.IsMasterClient())
		{
			onlineFishTrap.IBDCAKNCAFB((short)itemChosen.JDJGFAACPFC(DAINLFIMLIH: false));
		}
	}

	public void KMKJBFPOIHK(int JIIGOACEIKL)
	{
	}

	private void IJOPBFPADCE()
	{
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(ODIBAIPGLBA));
		if (WorldTime.NOAOJJLNHJJ.hour >= 10)
		{
			dayPhasesDone++;
			JKMBDADNOCD();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= 16)
		{
			dayPhasesDone++;
			JKMBDADNOCD();
		}
		if (WorldTime.NOAOJJLNHJJ.hour >= 22 || WorldTime.NOAOJJLNHJJ.hour < 4)
		{
			dayPhasesDone++;
			JKMBDADNOCD();
		}
	}

	public void BKJALNMBCDC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			DroppedItem.NBIOCDNPAPO(((Component)this).transform.position, itemChosen, 0, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineFishTrap != (Object)null)
			{
				onlineFishTrap.CJBMIHFNCPI();
			}
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)this).transform.position);
		for (int i = 0; i < trashItems.Length; i++)
		{
			if (Item.GBMFCPGEJDK(trashItems[i], itemChosen))
			{
				Utils.FKKHJPEMNBG("List of files in storage received.", 1);
				break;
			}
		}
		if (remainingUses > 0)
		{
			OOPKNHEOGKE();
			return;
		}
		placeable.KCGHOGLINOA(MCFNOAFOIHE: false);
		placeable.RemovePlaceable(EFNFMEIDGDN: true);
	}

	public void ALBEDNOIEJF(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}
}
