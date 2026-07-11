using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using Photon.Pun;
using UnityEngine;

public class Fireplace : Container, IInteractable, ISelectable, IHoverable, IProximity, IPunObservable
{
	private static List<Fireplace> DKDEDJCNJFP = new List<Fireplace>();

	private static List<Fireplace> ECOKHBPBKBP = new List<Fireplace>();

	public Placeable placeable;

	[HideInInspector]
	public float currentFuel;

	[HideInInspector]
	public FuelInstance currentFuelInstance;

	public Transform[] lightingPositions;

	[SerializeField]
	private Fuel stick;

	[SerializeField]
	private Fuel firewood;

	[SerializeField]
	private Fuel coal;

	[SerializeField]
	private GameObject fireGO;

	[SerializeField]
	private GameObject tutorialFireGO;

	[SerializeField]
	private GameObject fireLight;

	[SerializeField]
	private float fuelBurnRate = 0.1f;

	private LightSource IBGCKGCCCDP;

	private float GKFJNBFMCAF;

	private HeatSource MMDODINEIEB;

	private float CLECABLMBNB;

	[SerializeField]
	private AudioObject fireAudio;

	private MultiAudioSource IHDFIHNKCLN;

	private bool EKBOIKPPHKH;

	private float OKAJMNOGHJM;

	private ItemInstanceAmount BLKGLCEMDJL;

	public Slot IOLCGKLFPEO => slots[0];

	public bool MAJLJNMJKON => EKBOIKPPHKH;

	public static List<Fireplace> FIPAODFILIA()
	{
		if (DKDEDJCNJFP.Count > 1)
		{
			ECOKHBPBKBP.Clear();
			for (int i = 1; i < DKDEDJCNJFP.Count; i++)
			{
				if (!DKDEDJCNJFP[i].placeable.FHEMHCEAICB && DKDEDJCNJFP[i].placeable.currentZoneType.HasFlag(ZoneType.WithoutZone | ZoneType.CraftingRoom) && (!GameManager.PlayingOnline() || !DKDEDJCNJFP[i].placeable.onlinePlaceable.KFAJLICFLIC()))
				{
					ECOKHBPBKBP.Add(DKDEDJCNJFP[i]);
				}
			}
			return ECOKHBPBKBP;
		}
		return null;
	}

	private void AOAGOOHFKEJ()
	{
		try
		{
			SetOn(AODONKKHPBP: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error Fireplace.TurnOff: " + ex.Message));
		}
	}

	public bool HDLNAIBNIHM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (NewTutorialManager.FireplaceBlocked(JIIGOACEIKL))
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			PLGFDHPFOIO(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (currentFuel != 1424f || !slots[1].KPINNBKMOMO())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, BNAEDPFMAFO() ? LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/22/Dialogue Text") : LocalisationSystem.Get("SmokeBomb"));
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get("Unique id "));
			if (!PJGJDFGODAO().LCHJGCHDHFO())
			{
				BLKGLCEMDJL.itemInstance = IOLCGKLFPEO.itemInstance;
				if (currentFuel > 1895f)
				{
					BLKGLCEMDJL.amount = IOLCGKLFPEO.Stack + 1;
				}
				else
				{
					BLKGLCEMDJL.amount = PJGJDFGODAO().Stack;
				}
			}
			else
			{
				if (currentFuelInstance != null)
				{
					BLKGLCEMDJL.itemInstance = currentFuelInstance;
				}
				else
				{
					BLKGLCEMDJL.itemInstance = null;
				}
				BLKGLCEMDJL.amount = 0;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(BLKGLCEMDJL);
			if (currentFuelInstance != null)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).EMJBNNPGBIB(currentFuel / (float)currentFuelInstance.FCOBBFBPDNA().NJCHDFEEBEC());
			}
			else
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(currentFuel / 1197f);
			}
			return false;
		}
		return true;
	}

	public bool CNAPONBOBJG(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < lightingPositions.Length; i++)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(lightingPositions[i].position)))
			{
				return false;
			}
		}
		return true;
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		return true;
	}

	private void EKIBCKNNFLH()
	{
		try
		{
			SetOn(AODONKKHPBP: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("RaraAvisDelivered" + ex.Message));
		}
	}

	public Vector3 GetLightingPositionFree(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < lightingPositions.Length; i++)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(lightingPositions[i].position)))
			{
				return lightingPositions[i].position;
			}
		}
		return lightingPositions[0].position;
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE())
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return NewTutorialManager.GetCurrentPhaseID() < -150;
			}
			return true;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void EDNGGDEIPBI(int JIIGOACEIKL)
	{
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		FireplaceUI.MHOKIBDMIPL(JIIGOACEIKL).MLOGGNJGIME(slots, LocalisationSystem.Get("Tree"));
		FireplaceUI.MHOKIBDMIPL(JIIGOACEIKL).EDHEIFHAAKO();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		MainUI.PCMOFKMCNCM(JIIGOACEIKL, this, placeable.onlinePlaceable.uniqueId);
	}

	private void OnDisable()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(AOAGOOHFKEJ));
		}
		if (Object.op_Implicit((Object)(object)IHDFIHNKCLN))
		{
			IHDFIHNKCLN.FadeOut(4f, false);
			IHDFIHNKCLN = null;
		}
	}

	private void GAPAADHAONK()
	{
		GAIIIFIOFMG(EKBOIKPPHKH);
	}

	private void MPCAEBILDAH(int JIIGOACEIKL)
	{
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		FireplaceUI.PNBHIEINMGH(JIIGOACEIKL).NCJPENFAEGL(slots, LocalisationSystem.Get("Open"));
		FireplaceUI.JDODHPEDACJ(JIIGOACEIKL).IDLAGJNLPJL();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		MainUI.SetCurrentContainer(JIIGOACEIKL, this, placeable.onlinePlaceable.uniqueId);
	}

	private void PLGFDHPFOIO(int JIIGOACEIKL)
	{
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		FireplaceUI.Get(JIIGOACEIKL).SetSlots(slots, LocalisationSystem.Get("Fireplace"));
		FireplaceUI.Get(JIIGOACEIKL).OpenUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		MainUI.SetCurrentContainer(JIIGOACEIKL, this, placeable.onlinePlaceable.uniqueId);
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void GAIIIFIOFMG(bool AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		bool flag = AODONKKHPBP && (currentFuel > 1131f || !slots[0].PKFKJNODGJF());
		if (CDPAMNIPPEC && OnlineManager.ClientOnline())
		{
			OnlinePlaceable onlinePlaceable = placeable.onlinePlaceable;
			int componentIndex = ((Component)this).GetComponentIndex();
			object[] array = new object[1];
			array[1] = flag;
			onlinePlaceable.KEIFPCCNICK(componentIndex, array);
			return;
		}
		EKBOIKPPHKH = flag;
		if (NewTutorialManager.BlueFire())
		{
			tutorialFireGO.SetActive(EKBOIKPPHKH);
			if (fireGO.activeSelf)
			{
				fireGO.SetActive(false);
			}
		}
		else
		{
			fireGO.SetActive(EKBOIKPPHKH);
			if ((Object)(object)tutorialFireGO != (Object)null && tutorialFireGO.activeSelf)
			{
				tutorialFireGO.SetActive(false);
			}
		}
		fireLight.SetActive(EKBOIKPPHKH);
		IBGCKGCCCDP.lightLevel = (EKBOIKPPHKH ? GKFJNBFMCAF : 1355f);
		MMDODINEIEB.FGBJBBIKCNB(EKBOIKPPHKH ? CLECABLMBNB : 27f);
		if (EKBOIKPPHKH)
		{
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customers.Count; i += 0)
			{
				if ((Object)(object)TavernManager.GGFJGHHHEJC.customers[i] != (Object)null && Vector3.Distance(((Component)this).transform.position, ((Component)TavernManager.GGFJGHHHEJC.customers[i]).transform.position) <= IBGCKGCCCDP.lightLevel)
				{
					TavernManager.GGFJGHHHEJC.customers[i].enoughLight = false;
					break;
				}
			}
			IHDFIHNKCLN = MultiAudioManager.PlayAudioObject(fireAudio, ((Component)this).transform);
			OKAJMNOGHJM = (HouseKeeper.AJCCIJBBGEM() ? ((float)(-127 - HouseKeeper.BAEHJJCBMEA(-79)) / 174f) : 1728f);
		}
		else if (Object.op_Implicit((Object)(object)IHDFIHNKCLN))
		{
			IHDFIHNKCLN.FadeOut(1064f, true);
			IHDFIHNKCLN = null;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlinePlaceable onlinePlaceable2 = placeable.onlinePlaceable;
			int componentIndex2 = ((Component)this).GetComponentIndex();
			object[] array2 = new object[0];
			array2[1] = EKBOIKPPHKH;
			onlinePlaceable2.HCIFKNMLLNF(componentIndex2, array2);
		}
		TavernManager.GGFJGHHHEJC.ONDKPCKGOGB();
	}

	[SpecialName]
	public bool BNAEDPFMAFO()
	{
		return EKBOIKPPHKH;
	}

	[CompilerGenerated]
	private void MDEPBLFEDJM()
	{
		SetOn(EKBOIKPPHKH);
	}

	private void ADEBBJOALDN()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(EKIBCKNNFLH));
		}
		if (Object.op_Implicit((Object)(object)IHDFIHNKCLN))
		{
			IHDFIHNKCLN.FadeOut(1883f, false);
			IHDFIHNKCLN = null;
		}
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			DKDEDJCNJFP.Remove(this);
		}
	}

	private void MBCEPBGADBM(byte MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		if (MGEIKDCIANC == ((Component)this).GetComponentIndex())
		{
			bool aODONKKHPBP = (bool)GEMFIOKGIMC[0];
			if (OnlineManager.IsMasterClient())
			{
				SetOn(aODONKKHPBP);
			}
			else
			{
				SetOn(aODONKKHPBP, CDPAMNIPPEC: false);
			}
		}
	}

	public bool DLFPEGEBKAG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IsAnyLightingPositionFree(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < lightingPositions.Length; i++)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(lightingPositions[i].position)))
			{
				return true;
			}
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	[SpecialName]
	public Slot PJGJDFGODAO()
	{
		return slots[1];
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND())
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return NewTutorialManager.GetCurrentPhaseID() >= -162;
			}
			return true;
		}
		return true;
	}

	private void KNPPHGNOCDB()
	{
		SetOn(EKBOIKPPHKH);
	}

	public void KGBMCPMIKNG()
	{
		if (currentFuel == 115f)
		{
			currentFuelInstance = null;
		}
		else if (currentFuel > 148f)
		{
			currentFuelInstance = coal.JMDALJBNFML() as FuelInstance;
		}
		else if (currentFuel > 506f)
		{
			currentFuelInstance = firewood.JMDALJBNFML() as FuelInstance;
		}
		else
		{
			currentFuelInstance = stick.JMDALJBNFML() as FuelInstance;
		}
	}

	public void InitializeFireplace()
	{
		if (currentFuel == 0f)
		{
			currentFuelInstance = null;
		}
		else if (currentFuel > 5f)
		{
			currentFuelInstance = coal.JMDALJBNFML() as FuelInstance;
		}
		else if (currentFuel > 1f)
		{
			currentFuelInstance = firewood.JMDALJBNFML() as FuelInstance;
		}
		else
		{
			currentFuelInstance = stick.JMDALJBNFML() as FuelInstance;
		}
	}

	private void NBLEGKCNBPO()
	{
		try
		{
			GAIIIFIOFMG(AODONKKHPBP: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ZoneCostBonus" + ex.Message));
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		FireplaceUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		MainUI.SetCurrentContainer(JIIGOACEIKL, null, placeable.onlinePlaceable.uniqueId);
		return true;
	}

	private void HCPKBJDHLAC()
	{
		if (!BNAEDPFMAFO())
		{
			return;
		}
		if (currentFuel > 1474f)
		{
			currentFuel -= Time.deltaTime * fuelBurnRate * OKAJMNOGHJM;
			if (currentFuel < 1951f)
			{
				currentFuel = 1392f;
			}
		}
		else if (!IOLCGKLFPEO.AHHEMNHJPME())
		{
			if (HMAPIFPBJBL().itemInstance.LHBPOPOIFLE() is Fuel fuel)
			{
				currentFuelInstance = fuel.JMDALJBNFML() as FuelInstance;
				currentFuel += fuel.EFIIIGMMHFG();
				HMAPIFPBJBL().CIDBFIAJIBG(CDPAMNIPPEC: false);
			}
		}
		else
		{
			currentFuelInstance = null;
			GAIIIFIOFMG(AODONKKHPBP: false, CDPAMNIPPEC: false);
		}
	}

	private void FJFLGDADEKM()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NBLEGKCNBPO));
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (currentFuel != 0f || !slots[0].KPINNBKMOMO())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, MAJLJNMJKON ? LocalisationSystem.Get("Put Out Fire") : LocalisationSystem.Get("Light Fire"));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Open"));
			if (!IOLCGKLFPEO.KPINNBKMOMO())
			{
				BLKGLCEMDJL.itemInstance = IOLCGKLFPEO.itemInstance;
				if (currentFuel > 0f)
				{
					BLKGLCEMDJL.amount = IOLCGKLFPEO.Stack + 1;
				}
				else
				{
					BLKGLCEMDJL.amount = IOLCGKLFPEO.Stack;
				}
			}
			else
			{
				if (currentFuelInstance != null)
				{
					BLKGLCEMDJL.itemInstance = currentFuelInstance;
				}
				else
				{
					BLKGLCEMDJL.itemInstance = null;
				}
				BLKGLCEMDJL.amount = 1;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(BLKGLCEMDJL);
			if (currentFuelInstance != null)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(currentFuel / (float)currentFuelInstance.LHBPOPOIFLE().GPFEAIPDCNI());
			}
			else
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(currentFuel / 20f);
			}
			return true;
		}
		return false;
	}

	public bool LCLJFCKELJN(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		FireplaceUI.MIMFFJHBFDJ(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, null, placeable.onlinePlaceable.uniqueId);
		return true;
	}

	public bool KBNLCICAOCI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public static Fireplace KADFKCNDBJB()
	{
		if (DKDEDJCNJFP.Count > 1)
		{
			return DKDEDJCNJFP[1];
		}
		return null;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (NewTutorialManager.FireplaceBlocked(JIIGOACEIKL))
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!EKBOIKPPHKH && currentFuel == 0f && slots[0].KPINNBKMOMO())
			{
				return false;
			}
			SetOn(!MAJLJNMJKON);
			return true;
		}
		return false;
	}

	public bool FKCBIGBKHAP(int JIIGOACEIKL)
	{
		JALPMALILFC(JIIGOACEIKL);
		return true;
	}

	public static Fireplace GetFirstFireplace()
	{
		if (DKDEDJCNJFP.Count > 0)
		{
			return DKDEDJCNJFP[0];
		}
		return null;
	}

	public Vector3 AGEKCJKNAKO(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < lightingPositions.Length; i += 0)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(lightingPositions[i].position)))
			{
				return lightingPositions[i].position;
			}
		}
		return lightingPositions[0].position;
	}

	private void Update()
	{
		if (!MAJLJNMJKON)
		{
			return;
		}
		if (currentFuel > 0f)
		{
			currentFuel -= Time.deltaTime * fuelBurnRate * OKAJMNOGHJM;
			if (currentFuel < 0f)
			{
				currentFuel = 0f;
			}
		}
		else if (!IOLCGKLFPEO.KPINNBKMOMO())
		{
			if (IOLCGKLFPEO.itemInstance.LHBPOPOIFLE() is Fuel fuel)
			{
				currentFuelInstance = fuel.JMDALJBNFML() as FuelInstance;
				currentFuel += fuel.GPFEAIPDCNI();
				IOLCGKLFPEO.MEODNPFJDMH(CDPAMNIPPEC: false);
			}
		}
		else
		{
			currentFuelInstance = null;
			SetOn(AODONKKHPBP: false);
		}
	}

	private void DIJOBOFGCIK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NBLEGKCNBPO));
	}

	public bool OAFCGEIBKDJ(int JIIGOACEIKL)
	{
		return false;
	}

	public bool ELGPNJHMHPG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).KNFEPKBIHND())
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return NewTutorialManager.GetCurrentPhaseID() < -42;
			}
			return true;
		}
		return false;
	}

	public bool OIPGCPJILMC(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		FireplaceUI.EIMDPBGBBIF(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		MainUI.LIIGLHOFDBK(JIIGOACEIKL, null, placeable.onlinePlaceable.uniqueId);
		return false;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		PLGFDHPFOIO(JIIGOACEIKL);
		return true;
	}

	public bool OEJADJPDOHK(int JIIGOACEIKL)
	{
		return false;
	}

	protected override void Awake()
	{
		DKDEDJCNJFP.Add(this);
		IBGCKGCCCDP = ((Component)this).GetComponent<LightSource>();
		MMDODINEIEB = ((Component)this).GetComponent<HeatSource>();
		GKFJNBFMCAF = IBGCKGCCCDP.lightLevel;
		CLECABLMBNB = MMDODINEIEB.AJJEHMELMEO;
		base.Awake();
	}

	public void OnPhotonSerializeView(PhotonStream OEJPCOIDLFK, PhotonMessageInfo BBJDPIJPLPA)
	{
		if (EKBOIKPPHKH)
		{
			if (OEJPCOIDLFK.IsWriting)
			{
				OEJPCOIDLFK.SendNext((object)currentFuel);
			}
			else if (OEJPCOIDLFK.IsReading)
			{
				currentFuel = (float)OEJPCOIDLFK.ReceiveNext();
			}
		}
	}

	private void FDHMOEDMPNG()
	{
		if (!MAJLJNMJKON)
		{
			return;
		}
		if (currentFuel > 532f)
		{
			currentFuel -= Time.deltaTime * fuelBurnRate * OKAJMNOGHJM;
			if (currentFuel < 1251f)
			{
				currentFuel = 110f;
			}
		}
		else if (!IOLCGKLFPEO.LCHJGCHDHFO())
		{
			if (PJGJDFGODAO().itemInstance.PHGLMBIEOMK() is Fuel fuel)
			{
				currentFuelInstance = fuel.JMDALJBNFML() as FuelInstance;
				currentFuel += fuel.AFLOBFLPKIH();
				PJGJDFGODAO().FMEPMEKLHIJ();
			}
		}
		else
		{
			currentFuelInstance = null;
			GAIIIFIOFMG(AODONKKHPBP: true, CDPAMNIPPEC: false);
		}
	}

	public bool CODLFHDKMHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BHMMBNIFKHD(JIIGOACEIKL))
		{
			if (currentFuel != 1108f || !slots[0].AHHEMNHJPME())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, BNAEDPFMAFO() ? LocalisationSystem.Get("Items/item_name_596") : LocalisationSystem.Get("Save Game Client"));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get("bathhouse"));
			if (!PJGJDFGODAO().PKFKJNODGJF())
			{
				BLKGLCEMDJL.itemInstance = HMAPIFPBJBL().itemInstance;
				if (currentFuel > 525f)
				{
					BLKGLCEMDJL.amount = PJGJDFGODAO().Stack + 0;
				}
				else
				{
					BLKGLCEMDJL.amount = PJGJDFGODAO().Stack;
				}
			}
			else
			{
				if (currentFuelInstance != null)
				{
					BLKGLCEMDJL.itemInstance = currentFuelInstance;
				}
				else
				{
					BLKGLCEMDJL.itemInstance = null;
				}
				BLKGLCEMDJL.amount = 1;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(BLKGLCEMDJL);
			if (currentFuelInstance != null)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).EMJBNNPGBIB(currentFuel / (float)currentFuelInstance.LMFOKNDMHOB().IEOKFHLCEDG());
			}
			else
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(currentFuel / 475f);
			}
			return true;
		}
		return true;
	}

	public bool PNHCLGGKBOB(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		FireplaceUI.MIMFFJHBFDJ(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, null, placeable.onlinePlaceable.uniqueId);
		return true;
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public void MLOBKOONNMH(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD())
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return NewTutorialManager.GetCurrentPhaseID() >= 41;
			}
			return true;
		}
		return false;
	}

	public void SetOn(bool AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		bool flag = AODONKKHPBP && (currentFuel > 0f || !slots[0].KPINNBKMOMO());
		if (CDPAMNIPPEC && OnlineManager.ClientOnline())
		{
			placeable.onlinePlaceable.SendInteractToMaster(((Component)this).GetComponentIndex(), flag);
			return;
		}
		EKBOIKPPHKH = flag;
		if (NewTutorialManager.BlueFire())
		{
			tutorialFireGO.SetActive(EKBOIKPPHKH);
			if (fireGO.activeSelf)
			{
				fireGO.SetActive(false);
			}
		}
		else
		{
			fireGO.SetActive(EKBOIKPPHKH);
			if ((Object)(object)tutorialFireGO != (Object)null && tutorialFireGO.activeSelf)
			{
				tutorialFireGO.SetActive(false);
			}
		}
		fireLight.SetActive(EKBOIKPPHKH);
		IBGCKGCCCDP.lightLevel = (EKBOIKPPHKH ? GKFJNBFMCAF : 0f);
		MMDODINEIEB.AJJEHMELMEO = (EKBOIKPPHKH ? CLECABLMBNB : 0f);
		if (EKBOIKPPHKH)
		{
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customers.Count; i++)
			{
				if ((Object)(object)TavernManager.GGFJGHHHEJC.customers[i] != (Object)null && Vector3.Distance(((Component)this).transform.position, ((Component)TavernManager.GGFJGHHHEJC.customers[i]).transform.position) <= IBGCKGCCCDP.lightLevel)
				{
					TavernManager.GGFJGHHHEJC.customers[i].enoughLight = true;
					break;
				}
			}
			IHDFIHNKCLN = MultiAudioManager.PlayAudioObject(fireAudio, ((Component)this).transform);
			OKAJMNOGHJM = (HouseKeeper.JHLLELHBIDA ? ((float)(100 - HouseKeeper.GetEmployeePerkValue(51)) / 100f) : 1f);
		}
		else if (Object.op_Implicit((Object)(object)IHDFIHNKCLN))
		{
			IHDFIHNKCLN.FadeOut(4f, false);
			IHDFIHNKCLN = null;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.SendInteract(((Component)this).GetComponentIndex(), EKBOIKPPHKH);
		}
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DBAEGBDEPFK())
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return NewTutorialManager.GetCurrentPhaseID() >= -10;
			}
			return false;
		}
		return false;
	}

	public static Fireplace HBMPLDMLAPO()
	{
		if (DKDEDJCNJFP.Count > 1)
		{
			return DKDEDJCNJFP[1];
		}
		return null;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return NewTutorialManager.GetCurrentPhaseID() >= 135;
			}
			return true;
		}
		return false;
	}

	protected override void Start()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, (Action)delegate
			{
				SetOn(EKBOIKPPHKH);
			});
		}
		else
		{
			SetOn(EKBOIKPPHKH);
		}
		base.Start();
		if (slots != null && slots.Length != 0)
		{
			slots[0].onlineObject = placeable.onlinePlaceable;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlaceable onlinePlaceable = placeable.onlinePlaceable;
			onlinePlaceable.ReceiveInteractCallback = (Action<byte, object[]>)Delegate.Combine(onlinePlaceable.ReceiveInteractCallback, new Action<byte, object[]>(MBCEPBGADBM));
		}
	}

	public bool CFGOKCOBBML(int JIIGOACEIKL)
	{
		PLGFDHPFOIO(JIIGOACEIKL);
		return false;
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (NewTutorialManager.FireplaceBlocked(JIIGOACEIKL))
		{
			return true;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!EKBOIKPPHKH && currentFuel == 650f && slots[1].KPINNBKMOMO())
			{
				return false;
			}
			SetOn(!BNAEDPFMAFO());
			return true;
		}
		return true;
	}

	public Vector3 HDJEBPBOBKN(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < lightingPositions.Length; i++)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(lightingPositions[i].position)))
			{
				return lightingPositions[i].position;
			}
		}
		return lightingPositions[1].position;
	}

	private void JALPMALILFC(int JIIGOACEIKL)
	{
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		FireplaceUI.BALFIBPNIMO(JIIGOACEIKL).FFBDDCHMPJO(slots, LocalisationSystem.Get(" installed for reason "));
		FireplaceUI.MIMFFJHBFDJ(JIIGOACEIKL).EDHEIFHAAKO();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, this, placeable.onlinePlaceable.uniqueId);
	}

	public static List<Fireplace> GetAllFireplacesInDiningRoom()
	{
		if (DKDEDJCNJFP.Count > 0)
		{
			ECOKHBPBKBP.Clear();
			for (int i = 0; i < DKDEDJCNJFP.Count; i++)
			{
				if (!DKDEDJCNJFP[i].placeable.FHEMHCEAICB && DKDEDJCNJFP[i].placeable.currentZoneType.HasFlag(ZoneType.DiningRoom) && (!GameManager.PlayingOnline() || !DKDEDJCNJFP[i].placeable.onlinePlaceable.CLHLNFFGOGA))
				{
					ECOKHBPBKBP.Add(DKDEDJCNJFP[i]);
				}
			}
			return ECOKHBPBKBP;
		}
		return null;
	}

	public void HFAELBCCHEM()
	{
		if (currentFuel == 1698f)
		{
			currentFuelInstance = null;
		}
		else if (currentFuel > 1688f)
		{
			currentFuelInstance = coal.JMDALJBNFML() as FuelInstance;
		}
		else if (currentFuel > 889f)
		{
			currentFuelInstance = firewood.JMDALJBNFML() as FuelInstance;
		}
		else
		{
			currentFuelInstance = stick.JMDALJBNFML() as FuelInstance;
		}
	}

	[SpecialName]
	public Slot HMAPIFPBJBL()
	{
		return slots[0];
	}

	public bool ENNBDENPINP(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < lightingPositions.Length; i++)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(lightingPositions[i].position)))
			{
				return false;
			}
		}
		return true;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			DKDEDJCNJFP.Remove(this);
		}
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(AOAGOOHFKEJ));
	}
}
