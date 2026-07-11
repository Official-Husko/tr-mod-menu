using System;
using System.Collections;
using AlmenaraGames;
using UnityEngine;

public class CatNPC : NPC, IInteractable, IHoverable, IProximity, ISelectable
{
	public Action OnCatSitBed = delegate
	{
	};

	public CatAnimator catAnimator;

	public Collider2D catCollider;

	public CatAnimation catAnimation;

	[HideInInspector]
	public CatBed catBed;

	[HideInInspector]
	public PetBowl catBowl;

	[HideInInspector]
	public Placeable currentInvocationCircle;

	public Emoter emoter;

	public SpriteRenderer spriteRenderer;

	public CatRelationship relationshipSystem;

	public Item bedItem;

	public Item invocationCircleItem;

	public CatStateBase currentCatState;

	public GameObject loveEmote;

	private Animator LGBCINBOICO;

	private float MLGHPPLDGEG;

	private float GIFAMPKOLDE;

	private float MINDFECCHFB;

	private float JKIPCDPFKGI;

	private float IHBDOKMJDPI;

	[HideInInspector]
	public int startEatingHour = 13;

	[HideInInspector]
	public int stopEatingHour = 14;

	private float MPKMAFALLLO;

	public bool teleToBed;

	private float AMFAJFLCOND;

	[HideInInspector]
	public int walkingAgainCount;

	private float LHGHCPEAABC;

	private Coroutine BGJHDHJHDOE;

	private Coroutine BPGICDKIDEE;

	public OnlineCat onlineCat;

	private Vector3 AADMIOHCEEB;

	public GameDate birthday;

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Pet(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private IEnumerator NEAKIEFOIOG(CatStateBase NJHMBMGKCPL)
	{
		yield return null;
		while (!CanWalk())
		{
			yield return null;
		}
		StartWalking();
		NJHMBMGKCPL.DKFOJDHBGEJ();
	}

	public void GFILCKLGFFH()
	{
		BPGICDKIDEE = ((MonoBehaviour)this).StartCoroutine(ActivateColliderCoroutine(1260f));
		BGJHDHJHDOE = null;
		((Component)this).transform.parent = null;
		spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator GGNGMFBEGJE(CatStateBase NJHMBMGKCPL)
	{
		yield return null;
		while (!CanWalk())
		{
			yield return null;
		}
		StartWalking();
		NJHMBMGKCPL.DKFOJDHBGEJ();
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		PCJAEMFLGOC(JIIGOACEIKL);
		return true;
	}

	public void ELBGELBHAOG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		Placeable[] array = Utils.AGMADMGPHMP<Placeable>(Vector2.op_Implicit(((Component)this).transform.position), 432f, 3);
		bool flag = true;
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].FHEMHCEAICB && (Object)(object)array[i].itemSpace != (Object)null && !array[i].itemSpace.manageNodesCost)
			{
				flag = true;
				break;
			}
		}
		if (flag && !WorldGrid.EJCEAEPNJCA(((Component)this).transform.position))
		{
			flag = false;
		}
		if (!flag)
		{
			((Component)this).transform.position = Utils.MNOPMFHOKNI();
		}
	}

	public bool HFDLDMIKADB()
	{
		if (catAnimator.safeMovement)
		{
			return false;
		}
		return true;
	}

	public bool IKAIGCMENPF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Pet(JIIGOACEIKL, CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	public void NOAIKDADPBD(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void OnCollisionEnter2D(Collision2D HANHCHBHHEH)
	{
		if (!OnlineManager.ClientOnline() && HANHCHBHHEH.gameObject.tag != "Wall")
		{
			AMFAJFLCOND = Time.time + 4f;
		}
	}

	private void ADJHOLOIGJE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(TeleToBed));
			}
			if ((Object)(object)SaveUI.instance != (Object)null)
			{
				SaveUI instance2 = SaveUI.instance;
				instance2.OnLoadFadeOutStart = (Action)Delegate.Remove(instance2.OnLoadFadeOutStart, new Action(TeleToBed));
			}
			if ((Object)(object)RoomUpgrader.MAAAKALBBEE() != (Object)null)
			{
				RoomUpgrader instance3 = RoomUpgrader.GGFJGHHHEJC;
				instance3.OnRoomColliderGenerated = (Action)Delegate.Remove(instance3.OnRoomColliderGenerated, new Action(MIFJIAEDOCF));
			}
			if ((Object)(object)SaveUI.instance != (Object)null)
			{
				SaveUI instance4 = SaveUI.instance;
				instance4.OnLoadFadeOut = (Action)Delegate.Remove(instance4.OnLoadFadeOut, new Action(TeleToBed));
			}
			if (Object.op_Implicit((Object)(object)((Component)this).transform))
			{
				MonoBehaviourUtils.KPFPPFNNPID(((Component)this).transform, null);
			}
		}
	}

	public void WalkAround()
	{
		LGBCINBOICO.SetTrigger("Walk");
	}

	private void KGLHOEDHMGN()
	{
		IHBDOKMJDPI = Time.fixedTime + (float)Random.Range(180, 360);
	}

	private void CKIJOGKPDDD()
	{
		GIFAMPKOLDE = Time.fixedTime + (float)Random.Range(-146, -135);
	}

	public void MIFJIAEDOCF()
	{
		try
		{
			if (!OnlineManager.HHDBMDMFEMP())
			{
				IDKPLKLPFEN();
				OLOJLKOLOIG();
				teleToBed = false;
				catAnimation.SetTrigger("ReceiveSkipKlaynChallenge");
				LGBCINBOICO.SetTrigger(".gz");
				if (OnlineManager.IsMasterClient())
				{
					onlineCat.SendSetTrigger("Rotate");
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("CannotToggleUI InputsEnabled " + ex.Message));
		}
	}

	public void CancelWaitToWalk(CatStateBase NJHMBMGKCPL)
	{
		if (BPGICDKIDEE != null)
		{
			((MonoBehaviour)this).StopCoroutine(BPGICDKIDEE);
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		if (CatUI.Get(JIIGOACEIKL).IsOpen())
		{
			CatUI.Get(JIIGOACEIKL).CloseUI();
		}
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineCat);
		}
		return true;
	}

	public void HeadToBed(Placeable HJLNPMKIJCI)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)HJLNPMKIJCI != (Object)null)
		{
			((Behaviour)catCollider).enabled = false;
			catBed = ((Component)HJLNPMKIJCI).GetComponent<CatBed>();
			if ((Object)(object)catBed == (Object)null || catBed.setChild)
			{
				((Component)this).transform.SetParent(((Component)HJLNPMKIJCI).transform);
			}
			((Component)this).transform.position = catBed.sitLocation.transform.position;
			if (catBed.tower)
			{
				spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (OnlineManager.IsMasterClient())
			{
				onlineCat.SendHeadToBed(HJLNPMKIJCI);
			}
		}
		else
		{
			Debug.LogError((object)"Cat bed is null!");
		}
	}

	public void MinusRelationship(int FFDIEOBBFKL, bool CDPAMNIPPEC)
	{
		emoter.StartEmote(Emote.Minus, NAILNAHFJFD: true);
		relationshipSystem.SetRelationship(relationshipSystem.relationshipLevel - FFDIEOBBFKL);
		if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.catAngry, ((Component)this).transform);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineCat.SendMinusRelationship(FFDIEOBBFKL);
		}
	}

	public bool GGNLGAMLOKK(int JIIGOACEIKL)
	{
		if (CatUI.HICGKNJMGOE(JIIGOACEIKL).HDEPMJIDJEM())
		{
			CatUI.AANKLOIDPOA(JIIGOACEIKL).CloseUI();
		}
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineCat);
		}
		return false;
	}

	public void EBGEOAOFHGD()
	{
		LGBCINBOICO.SetTrigger("Style");
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void LGDKFCALLKA(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		Pet(JIIGOACEIKL, !relationshipSystem.DailyPetDone());
		return true;
	}

	public bool JAELLHFFLKO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Pet(JIIGOACEIKL, CDPAMNIPPEC: false);
			return false;
		}
		return true;
	}

	private void PNNNMOLAJOP()
	{
		JKIPCDPFKGI = Time.fixedTime + (float)Random.Range(180, 360);
	}

	public void WaitToWalk(CatStateBase NJHMBMGKCPL)
	{
		if (!OnlineManager.ClientOnline())
		{
			CancelWaitToWalk(NJHMBMGKCPL);
			if (BGJHDHJHDOE == null)
			{
				BGJHDHJHDOE = ((MonoBehaviour)this).StartCoroutine(NEAKIEFOIOG(NJHMBMGKCPL));
			}
		}
	}

	private void IDKPLKLPFEN()
	{
		MLGHPPLDGEG = Time.fixedTime + (float)Random.Range(180, 360);
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(TeleToBed));
			}
			if ((Object)(object)SaveUI.instance != (Object)null)
			{
				SaveUI instance2 = SaveUI.instance;
				instance2.OnLoadFadeOutStart = (Action)Delegate.Remove(instance2.OnLoadFadeOutStart, new Action(TeleToBed));
			}
			if ((Object)(object)RoomUpgrader.GGFJGHHHEJC != (Object)null)
			{
				RoomUpgrader instance3 = RoomUpgrader.GGFJGHHHEJC;
				instance3.OnRoomColliderGenerated = (Action)Delegate.Remove(instance3.OnRoomColliderGenerated, new Action(TeleToBed));
			}
			if ((Object)(object)SaveUI.instance != (Object)null)
			{
				SaveUI instance4 = SaveUI.instance;
				instance4.OnLoadFadeOut = (Action)Delegate.Remove(instance4.OnLoadFadeOut, new Action(TeleToBed));
			}
			if (Object.op_Implicit((Object)(object)((Component)this).transform))
			{
				MonoBehaviourUtils.SetParentNextFrame(((Component)this).transform, null);
			}
		}
	}

	public void PBIIABMONHB()
	{
		MinusRelationship(0, CDPAMNIPPEC: true);
		((Behaviour)catCollider).enabled = true;
		catAnimation.EMKEMHODJEB(NJHMBMGKCPL: true, CDPAMNIPPEC: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			WalkAround();
		}
		((Component)this).transform.parent = null;
		if (OnlineManager.IsMasterClient())
		{
			onlineCat.SendWakeUpCat();
		}
	}

	private void OnCollisionStay2D(Collision2D LGGCFCHOOMB)
	{
		if (!OnlineManager.ClientOnline() && Time.time > AMFAJFLCOND && LGGCFCHOOMB.gameObject.tag != "Wall" && Time.time > MPKMAFALLLO && !(currentCatState is HeadToPetBowl))
		{
			WalkAround();
			MPKMAFALLLO = Time.time + 1f;
		}
	}

	public bool MGECKEIHEGA(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineCat.uniqueId);
				return true;
			}
			PCJAEMFLGOC(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public bool LDNAOJDHOIP(int JIIGOACEIKL)
	{
		CPFAOCENBFL(JIIGOACEIKL);
		return true;
	}

	private void KFDGLCJGMPK()
	{
		MINDFECCHFB = Time.fixedTime + (float)Random.Range(-162, -172);
	}

	public bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Pet(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return true;
	}

	public void WakeUp()
	{
		MinusRelationship(0, CDPAMNIPPEC: false);
		((Behaviour)catCollider).enabled = false;
		catAnimation.Sleep(NJHMBMGKCPL: false, CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			WalkAround();
		}
		((Component)this).transform.parent = null;
		if (OnlineManager.IsMasterClient())
		{
			onlineCat.SendWakeUpCat();
		}
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(PetBowl.UnfillOnPlayerAwakeCatBowl));
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineCat.uniqueId);
				return false;
			}
			PCJAEMFLGOC(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public IEnumerator ActivateColliderCoroutine(float LGLDPMAABLA)
	{
		yield return (object)new WaitForSeconds(LGLDPMAABLA);
		((Behaviour)catCollider).enabled = true;
		BPGICDKIDEE = null;
	}

	private void OKDGOFDHOEA()
	{
		LGBCINBOICO.SetTrigger("HeadToBed");
	}

	private void OnEnable()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(TeleToBed));
		}
		if (Object.op_Implicit((Object)(object)SaveUI.instance))
		{
			SaveUI instance2 = SaveUI.instance;
			instance2.OnLoadFadeOutStart = (Action)Delegate.Combine(instance2.OnLoadFadeOutStart, new Action(TeleToBed));
		}
		if (Object.op_Implicit((Object)(object)RoomUpgrader.GGFJGHHHEJC))
		{
			RoomUpgrader instance3 = RoomUpgrader.GGFJGHHHEJC;
			instance3.OnRoomColliderGenerated = (Action)Delegate.Combine(instance3.OnRoomColliderGenerated, new Action(TeleToBed));
		}
	}

	public void PIOEMOGEOIN()
	{
		LGBCINBOICO.SetTrigger("Dialogue System/Conversation/Crowly_Introduce/Entry/25/Dialogue Text");
	}

	protected override void Awake()
	{
		base.Awake();
		LGBCINBOICO = ((Component)this).GetComponent<Animator>();
		if ((Object)(object)relationshipSystem == (Object)null)
		{
			relationshipSystem = ((Component)this).GetComponent<CatRelationship>();
		}
		if ((Object)(object)catAnimation == (Object)null)
		{
			catAnimation = ((Component)this).GetComponent<CatAnimation>();
		}
		if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC != (Object)null)
		{
			Object.Destroy((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC);
		}
		SpawnCat.GGFJGHHHEJC.catNPC = this;
		IDKPLKLPFEN();
		OLOJLKOLOIG();
		AOIFJBBFOFB();
		PNNNMOLAJOP();
		KGLHOEDHMGN();
	}

	public void APCIIKMPNJK()
	{
		MinusRelationship(0, CDPAMNIPPEC: true);
		((Behaviour)catCollider).enabled = false;
		catAnimation.OANKBAMLGLP(NJHMBMGKCPL: false, CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			WalkAround();
		}
		((Component)this).transform.parent = null;
		if (OnlineManager.IsMasterClient())
		{
			onlineCat.BCNFHPJGHLP();
		}
	}

	public bool KNPOMBCGKEL(int JIIGOACEIKL)
	{
		PCJAEMFLGOC(JIIGOACEIKL);
		return true;
	}

	public void CDICGBJOBAP(CatStateBase NJHMBMGKCPL)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			CancelWaitToWalk(NJHMBMGKCPL);
			if (BGJHDHJHDOE == null)
			{
				BGJHDHJHDOE = ((MonoBehaviour)this).StartCoroutine(GGNGMFBEGJE(NJHMBMGKCPL));
			}
		}
	}

	private void OLOJLKOLOIG()
	{
		GIFAMPKOLDE = Time.fixedTime + (float)Random.Range(180, 360);
	}

	public void MKACAJJJIIK()
	{
		try
		{
			if (!OnlineManager.ClientOnline())
			{
				NKEMHKJECIG();
				OLOJLKOLOIG();
				teleToBed = false;
				catAnimation.SetTrigger("Pausing network sync until the world is loaded...", HALNIEBONKH: true);
				LGBCINBOICO.SetTrigger("Cheddar");
				if (OnlineManager.IsMasterClient())
				{
					onlineCat.JMIIPHHBNJI("Rotate");
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Button index hasn't been set up properly." + ex.Message));
		}
	}

	private void MFMMHDPGCBO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(PetBowl.PDBGDMEAKHI));
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void NKEMHKJECIG()
	{
		MLGHPPLDGEG = Time.fixedTime + (float)Random.Range(152, 86);
	}

	public bool CanWalk()
	{
		if (catAnimator.safeMovement)
		{
			return true;
		}
		return false;
	}

	public void TeleportCat()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		Placeable[] array = Utils.AGMADMGPHMP<Placeable>(Vector2.op_Implicit(((Component)this).transform.position), 0.14f);
		bool flag = true;
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].FHEMHCEAICB && (Object)(object)array[i].itemSpace != (Object)null && !array[i].itemSpace.manageNodesCost)
			{
				flag = false;
				break;
			}
		}
		if (flag && !WorldGrid.EJCEAEPNJCA(((Component)this).transform.position))
		{
			flag = false;
		}
		if (!flag)
		{
			((Component)this).transform.position = Utils.MNOPMFHOKNI();
		}
	}

	private void ELJCHNKIALC()
	{
		GIFAMPKOLDE = Time.fixedTime + (float)Random.Range(-31, -49);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Pet"));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Information"));
			return true;
		}
		return false;
	}

	private void AOIFJBBFOFB()
	{
		MINDFECCHFB = Time.fixedTime + (float)Random.Range(180, 360);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && Time.time > LHGHCPEAABC)
		{
			return !(currentCatState is HeadToPetBowl);
		}
		return false;
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(PetBowl.UnfillOnPlayerAwakeCatBowl));
	}

	private void PCJAEMFLGOC(int JIIGOACEIKL)
	{
		SelectObject.GetPlayer(JIIGOACEIKL).SelectGameObject((MonoBehaviour)(object)this);
		CatUI.Get(JIIGOACEIKL).OpenUI();
	}

	public void Pet(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		LHGHCPEAABC = Time.time + 5f;
		relationshipSystem.Pet();
		loveEmote.SetActive(true);
		CommonReferences.GGFJGHHHEJC.OnPetCat();
		MultiAudioManager.PlayAudioObject(((Object)(object)catBed == (Object)null) ? Sound.GGFJGHHHEJC.catMeow : Sound.GGFJGHHHEJC.catPurr, ((Component)this).transform);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineCat.SendPet();
		}
	}

	private void CPFAOCENBFL(int JIIGOACEIKL)
	{
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SelectGameObject((MonoBehaviour)(object)this);
		CatUI.PNCKAKBBKJL(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void Spawn()
	{
		LGBCINBOICO.SetTrigger("Spawn");
	}

	public void FixedUpdate()
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() && Object.op_Implicit((Object)(object)currentCatState))
		{
			if (Time.fixedTime > MLGHPPLDGEG && !(currentCatState is HeadToPetBowl) && !(currentCatState is CatStateBirdInteract))
			{
				if (currentCatState is CatWalkAroundState)
				{
					LGBCINBOICO.SetTrigger("HeadToBed");
				}
				IDKPLKLPFEN();
			}
			else if (Time.fixedTime > GIFAMPKOLDE)
			{
				if (currentCatState is CatWalkAroundState && PetBowl.IsThereACatBowlToEatOrDrink())
				{
					LGBCINBOICO.SetTrigger("Eat");
				}
				OLOJLKOLOIG();
			}
			else if (Time.fixedTime > MINDFECCHFB)
			{
				if (currentCatState is CatWalkAroundState)
				{
					LGBCINBOICO.SetTrigger("Bird");
				}
				AOIFJBBFOFB();
			}
			else if (Time.fixedTime > JKIPCDPFKGI)
			{
				if (currentCatState is CatWalkAroundState)
				{
					LGBCINBOICO.SetTrigger("Tower");
				}
				PNNNMOLAJOP();
			}
			else if (Time.fixedTime > IHBDOKMJDPI)
			{
				if (PetToy.IsAnyToyInDistance(Vector2.op_Implicit(((Component)this).transform.position), 5f))
				{
					if (currentCatState is CatWalkAroundState)
					{
						LGBCINBOICO.SetTrigger("Toy");
					}
					KGLHOEDHMGN();
				}
				else
				{
					IHBDOKMJDPI = Time.fixedTime + 5f;
				}
			}
			else
			{
				currentCatState.GFBLAEEOPAO();
			}
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineCat) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			onlineCat.UpdateCatPosition();
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	public void BOJBEDMEIAJ()
	{
		MinusRelationship(1, CDPAMNIPPEC: true);
		((Behaviour)catCollider).enabled = true;
		catAnimation.LMKCBFEDPFM(NJHMBMGKCPL: false, CDPAMNIPPEC: true);
		if (OnlineManager.MasterOrOffline())
		{
			WalkAround();
		}
		((Component)this).transform.parent = null;
		if (OnlineManager.IsMasterClient())
		{
			onlineCat.ELIDHMJNJCH();
		}
	}

	public void TeleToBed()
	{
		try
		{
			if (!OnlineManager.ClientOnline())
			{
				IDKPLKLPFEN();
				OLOJLKOLOIG();
				teleToBed = true;
				catAnimation.SetTrigger("Starting");
				LGBCINBOICO.SetTrigger("HeadToBed");
				if (OnlineManager.IsMasterClient())
				{
					onlineCat.SendSetTrigger("Starting");
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in CatNPC.TeleToBed: " + ex.Message));
		}
	}

	public void StartWalking()
	{
		BPGICDKIDEE = ((MonoBehaviour)this).StartCoroutine(ActivateColliderCoroutine(2f));
		BGJHDHJHDOE = null;
		((Component)this).transform.parent = null;
		spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
	}

	public void KKJDAOHHIIJ()
	{
		MinusRelationship(0, CDPAMNIPPEC: true);
		((Behaviour)catCollider).enabled = false;
		catAnimation.IABJLEEGKMN(NJHMBMGKCPL: true, CDPAMNIPPEC: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			WalkAround();
		}
		((Component)this).transform.parent = null;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineCat.BCNFHPJGHLP();
		}
	}

	public void HANCCGBDPNF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		Placeable[] array = Utils.AGMADMGPHMP<Placeable>(Vector2.op_Implicit(((Component)this).transform.position), 1690f, 113);
		bool flag = false;
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!array[i].FHEMHCEAICB && (Object)(object)array[i].itemSpace != (Object)null && !array[i].itemSpace.manageNodesCost)
			{
				flag = true;
				break;
			}
		}
		if (flag && !WorldGrid.EJCEAEPNJCA(((Component)this).transform.position))
		{
			flag = true;
		}
		if (!flag)
		{
			((Component)this).transform.position = Utils.MNOPMFHOKNI();
		}
	}

	public void AOGFHJCDKNO()
	{
		MinusRelationship(1, CDPAMNIPPEC: true);
		((Behaviour)catCollider).enabled = true;
		catAnimation.LMKCBFEDPFM(NJHMBMGKCPL: true, CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			EBGEOAOFHGD();
		}
		((Component)this).transform.parent = null;
		if (OnlineManager.IsMasterClient())
		{
			onlineCat.SendWakeUpCat();
		}
	}
}
