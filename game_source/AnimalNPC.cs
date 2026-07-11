using System;
using System.Collections;
using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public abstract class AnimalNPC : NPC, ISelectable, IProximity, IHoverable, IInteractable
{
	public int level;

	public bool hasFood;

	public bool hasWater;

	public bool hasWalked;

	public bool isSick;

	public int vitaminsRemainingDays;

	public float productionProgress;

	public bool sleeping;

	public bool cannotEntryBarn;

	public Animator behaviour;

	public AnimalType type;

	public AnimalStateBase currentAnimalState;

	public int walkingAgainCount;

	public Coroutine waitToWalkCoroutine;

	public int maxLevel = 10;

	public GameObject deathFx;

	public GameObject hitFx;

	public Placeable placeable;

	public Item animalFeedItem;

	public Emoter emoter;

	public AnimalSpace animalSpace;

	public FarmBuilding currentBuilding;

	[SerializeField]
	private DoWork work;

	private float HOAANMDGJEP;

	public bool eventAnimal;

	public float lastDamageTime;

	[SerializeField]
	private float timerHasWalked;

	[HideInInspector]
	public int lives = 3;

	[HideInInspector]
	public GameObject obj;

	[HideInInspector]
	public bool animalLoaded;

	public Collider2D hitCollider;

	public bool updateMaterialAtStart = true;

	[HideInInspector]
	public AudioObject sfx;

	[HideInInspector]
	public AudioObject sfxHit;

	[HideInInspector]
	public Vector3 hitPosition;

	public OnlineAnimal onlineAnimal;

	private Vector3 AADMIOHCEEB;

	public Animator sleepEmote;

	public bool dontAwake;

	private Coroutine NDHIIDPCGKG;

	public AnimalAnimation FFHHEGALBKO => animationBase as AnimalAnimation;

	public Animal CMOBLFMDNKF => placeable.itemSetup.item as Animal;

	public AnimalInstance NBMNBKEJHPM => placeable.itemSetup.DNLMCHDOMOK as AnimalInstance;

	public void TryEntryBarnAgain(int LGLDPMAABLA)
	{
		((MonoBehaviour)this).StartCoroutine(ADFEHFHGFBG(LGLDPMAABLA));
	}

	public void IncreaseProductionProgress(float AODONKKHPBP, bool CDPAMNIPPEC)
	{
		productionProgress += AODONKKHPBP;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineAnimal.SendIncreaseProduction(AODONKKHPBP);
		}
	}

	public void Hit(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			Hit(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			Hit(((Component)PlayerController.GetPlayer(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	public void PlayAnimalSound()
	{
		switch (type)
		{
		case AnimalType.Pig:
			sfx = Sound.GGFJGHHHEJC.pig;
			sfxHit = Sound.GGFJGHHHEJC.pigHit;
			break;
		case AnimalType.Sheep:
			sfx = Sound.GGFJGHHHEJC.sheep;
			sfxHit = Sound.GGFJGHHHEJC.sheepHit;
			break;
		case AnimalType.Cow:
			sfx = Sound.GGFJGHHHEJC.cow;
			sfxHit = Sound.GGFJGHHHEJC.cowHit;
			break;
		case AnimalType.Chicken:
			sfx = Sound.GGFJGHHHEJC.chicken;
			sfxHit = Sound.GGFJGHHHEJC.chickenHit;
			break;
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	private void FNFDDCPKOLI()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		lastDamageTime = Time.time;
		hitFx.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			if ((Object)(object)hitCollider != (Object)null)
			{
				((Behaviour)hitCollider).enabled = true;
			}
			rb.isKinematic = false;
			rb.WakeUp();
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 250f));
		}
		hitFx.SetActive(true);
		FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(sfxHit, ((Component)this).transform);
		if (sleeping)
		{
			Sleep(AODONKKHPBP: false);
			((MonoBehaviour)this).StartCoroutine(MEAHLELOBOG());
			sleeping = true;
		}
		else if (OnlineManager.MasterOrOffline())
		{
			WalkAround();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MEAHLELOBOG());
		}
		if (OnlineManager.MasterOrOffline())
		{
			((MonoBehaviour)this).StartCoroutine(EEMJIBHLJLK());
		}
	}

	public void Sick(bool CDPAMNIPPEC)
	{
		isSick = true;
		emoter.StartEmote(Emote.Sick);
		if (CDPAMNIPPEC)
		{
			if ((Object)(object)animalSpace != (Object)null)
			{
				animalSpace.PutAnimalToSleep();
			}
			if (OnlineManager.PlayingOnline())
			{
				onlineAnimal.SendSick();
			}
		}
	}

	public void SetVitamins(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		vitaminsRemainingDays = MGNOBNCMDJG;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineAnimal.SendSetVitamins(MGNOBNCMDJG);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return lives > 0;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void SetLife(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineAnimal.SendSetLife(MGNOBNCMDJG);
		}
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void WalkAroundWithRandomDelay()
	{
		if (NDHIIDPCGKG == null)
		{
			NDHIIDPCGKG = ((MonoBehaviour)this).StartCoroutine(EIJOLIHMALF());
		}
	}

	public void AwakeAnimal()
	{
		Sleep(AODONKKHPBP: false);
	}

	private void DKMAAGAOKPC()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > lastDamageTime + 40f)
		{
			lives = 3;
			if (isSick)
			{
				Sleep(AODONKKHPBP: true);
			}
		}
		if (!sleeping && (Object)(object)animalSpace != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.BarnInterior && IsTimeToSleep() && !Barn.instance.IsOpen())
		{
			Barn.instance.AssignAnimalsPathRegion(AHJOOLKOBIL: true);
			animalSpace.PutAnimalToSleepIfPosible();
		}
	}

	public static bool IsTimeToSleep()
	{
		if (!(WorldTime.EDIPJBOOEHD > (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			return WorldTime.EDIPJBOOEHD < 4f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR;
		}
		return true;
	}

	public void OnThisPlaceableSelected(int JIIGOACEIKL, bool JOOIABPPAML, bool GFNHAMCPEAK)
	{
		FFHHEGALBKO.SetBool("Selected", EGFGNGJGBOP: true);
	}

	public void ReduceLife(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool Select(int JIIGOACEIKL)
	{
		FarmAnimalUI.Get(JIIGOACEIKL).animalNPC = this;
		FarmAnimalUI.Get(JIIGOACEIKL).OpenUI();
		return true;
	}

	public int GetLives()
	{
		return lives;
	}

	public virtual bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (CanGiveVitamins(JIIGOACEIKL))
			{
				GiveVitamins(JIIGOACEIKL);
				return true;
			}
			if (CanGiveCure(JIIGOACEIKL))
			{
				Cure(JIIGOACEIKL, CDPAMNIPPEC: true);
				return true;
			}
		}
		return false;
	}

	private void Update()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if (!hasWalked && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Road)
		{
			if (sleeping)
			{
				timerHasWalked = 0f;
			}
			else
			{
				timerHasWalked += Time.deltaTime;
				if (timerHasWalked > 60f)
				{
					hasWalked = true;
					timerHasWalked = 0f;
					if (OnlineManager.PlayingOnline())
					{
						onlineAnimal.SendWalk();
					}
				}
			}
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineAnimal) && AADMIOHCEEB != ((Component)this).transform.position && !placeable.FHEMHCEAICB && !onlineAnimal.CLHLNFFGOGA)
		{
			if (Vector3.Distance(AADMIOHCEEB, ((Component)this).transform.position) > 3f)
			{
				onlineAnimal.SendTeleportAnimal();
			}
			else
			{
				onlineAnimal.UpdateAnimalPosition();
			}
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			if (CanGiveVitamins(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Give"), ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().IABAKHPEOAF()));
			}
			if (CanGiveCure(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Give"), ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().IABAKHPEOAF()));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Information"));
			return true;
		}
		return false;
	}

	private IEnumerator MEAHLELOBOG()
	{
		yield return CommonReferences.wait05;
		FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	public bool CanSick()
	{
		if (!isSick)
		{
			return vitaminsRemainingDays == 0;
		}
		return false;
	}

	public bool CanGiveCure(int JIIGOACEIKL)
	{
		if (Item.NGIIPJDAMGP(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null))
		{
			return false;
		}
		if (isSick)
		{
			return ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().JDJGFAACPFC() == 1235;
		}
		return false;
	}

	public void Cure(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!CDPAMNIPPEC || ActionBarInventory.GetPlayer(JIIGOACEIKL).RemoveItem(ItemDatabaseAccessor.GetItem(1235)) != null)
		{
			isSick = false;
			emoter.SickEnd();
			sleepEmote.SetBool("Sleep", true);
			dontAwake = true;
			if (CDPAMNIPPEC)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			if (CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial && CDPAMNIPPEC)
			{
				HollyNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Tutorial/Barn_Holly");
				CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
				dontAwake = false;
				AwakeAnimal();
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				onlineAnimal.SendCure();
			}
		}
	}

	protected override void Awake()
	{
		base.Awake();
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(OnThisPlaceableSelected));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(OnThisPlaceableDeselected));
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		return true;
	}

	private IEnumerator EIJOLIHMALF()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(0, 4));
		NDHIIDPCGKG = null;
		WalkAround();
	}

	public void WalkAround()
	{
		if (!dontAwake && OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger("Walk");
		}
	}

	private IEnumerator ADFEHFHGFBG(int LGLDPMAABLA)
	{
		yield return (object)new WaitForSeconds((float)LGLDPMAABLA);
		cannotEntryBarn = false;
		walkingAgainCount = 0;
		WalkAround();
	}

	private void Start()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		PlayAnimalSound();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
		if (updateMaterialAtStart && placeable.itemSetup.DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			if (type == AnimalType.Sheep)
			{
				FFHHEGALBKO.animalAnimator.SetAnimalSkin(eCMCBNFLHCI, OBDGKOCOLIN: true);
			}
			else
			{
				FFHHEGALBKO.animalAnimator.SetAnimalSkin(eCMCBNFLHCI);
			}
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void RandomSkin()
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		placeable.itemSetup.DNLMCHDOMOK = placeable.itemSetup.DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML();
		FFHHEGALBKO.animalAnimator.SetAnimalSkin(placeable.itemSetup.DNLMCHDOMOK as AnimalInstance);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public virtual bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	protected override void OnDestroy()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(DKMAAGAOKPC));
		if (!GameManager.leavingTheGame && !((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && PathNodesManager.IsValid())
		{
			base.OnDestroy();
			if (Object.op_Implicit((Object)(object)animalSpace))
			{
				animalSpace.DeassignAnimal(CDPAMNIPPEC: false);
			}
		}
	}

	public bool CanGiveVitamins(int JIIGOACEIKL)
	{
		if (Item.NGIIPJDAMGP(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null))
		{
			return false;
		}
		if (!isSick)
		{
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().JDJGFAACPFC() != 1233)
			{
				return ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().JDJGFAACPFC() == 1234;
			}
			return true;
		}
		return false;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void SetProductionProgress(float AODONKKHPBP, bool CDPAMNIPPEC)
	{
		productionProgress = AODONKKHPBP;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineAnimal.SendSetProduction(AODONKKHPBP);
		}
	}

	private IEnumerator MPLLAIDMHBI()
	{
		while (work.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > HOAANMDGJEP)
			{
				work.Stop();
			}
			yield return null;
		}
	}

	protected void NGACEOEMGPG(int JIIGOACEIKL)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(CMOBLFMDNKF.productionItem.item.JMDALJBNFML(), HMPDLIPFBGD: true))
		{
			productionProgress = 0f;
			if (OnlineManager.PlayingOnline())
			{
				onlineAnimal.SendSetProduction(0f);
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Inventory full", JIIGOACEIKL);
		}
	}

	public void OnThisPlaceableDeselected(int JIIGOACEIKL)
	{
		FFHHEGALBKO.SetBool("Selected", EGFGNGJGBOP: false);
	}

	public int GetNumTasksDone()
	{
		int num = 0;
		if (hasFood)
		{
			num++;
		}
		if (hasWater)
		{
			num++;
		}
		if (type != 0 && hasWalked)
		{
			num++;
		}
		return num;
	}

	protected virtual void FixedUpdate()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if ((Object)(object)obj != (Object)null)
		{
			obj.transform.position = ((Component)this).transform.position;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (((Behaviour)placeable).enabled && ((Object)(object)currentAnimalState == (Object)null || placeable.FHEMHCEAICB || onlineAnimal.CLHLNFFGOGA))
			{
				((Behaviour)animationBase).enabled = false;
			}
			else if (Object.op_Implicit((Object)(object)currentAnimalState) && !placeable.FHEMHCEAICB)
			{
				currentAnimalState.PPMIHMFFCEC();
			}
		}
		else if (Object.op_Implicit((Object)(object)currentAnimalState) && !placeable.FHEMHCEAICB)
		{
			currentAnimalState.PPMIHMFFCEC();
		}
		else if (((Behaviour)placeable).enabled && placeable.FHEMHCEAICB)
		{
			((Behaviour)animationBase).enabled = false;
		}
	}

	private void BNDMNNKHLMB()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		List<ItemAmount> list = CMOBLFMDNKF.LPCKMEJAODN(level);
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i].amount;
			if (list[i].item is Food { ingredientType: IngredientType.Meat } && Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
			{
				num++;
			}
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, list[i].item, num);
		}
	}

	public void WasteVitamin()
	{
		SetVitamins(Mathf.Max(0, vitaminsRemainingDays - 1), CDPAMNIPPEC: true);
	}

	public void GiveVitamins(int JIIGOACEIKL)
	{
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).RemoveItem(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem()) != null)
		{
			SetVitamins(Mathf.Max(vitaminsRemainingDays, (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().JDJGFAACPFC() == 1233) ? 4 : 7), CDPAMNIPPEC: true);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		}
	}

	protected bool DPGJOMBFDHC(int JIIGOACEIKL)
	{
		if (productionProgress < 1f)
		{
			return true;
		}
		if (!work.JCMBHAEKLKK)
		{
			work.StartWork(50f);
			HOAANMDGJEP = Time.time + 0.1f;
			((MonoBehaviour)this).StartCoroutine(MPLLAIDMHBI());
		}
		else if (work.JCMBHAEKLKK)
		{
			if (work.AddWorkDone(JIIGOACEIKL, 100f * Time.deltaTime))
			{
				return true;
			}
			HOAANMDGJEP = Time.time + 0.1f;
		}
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return true;
	}

	private IEnumerator EEMJIBHLJLK()
	{
		yield return CommonReferences.wait03;
		rb.velocity = Vector2.op_Implicit(Vector3.zero);
		rb.Sleep();
		yield return null;
		rb.isKinematic = true;
		rb.Sleep();
		if ((Object)(object)hitCollider != (Object)null)
		{
			((Behaviour)hitCollider).enabled = false;
		}
	}

	public void IncrementLevel()
	{
		lives = 3;
		int num = -1;
		if (hasFood)
		{
			ItemInstance itemInstance = null;
			if (currentBuilding is HenHouse henHouse)
			{
				itemInstance = henHouse.foodFeeder.GetNextFoodFromContainer();
			}
			else if ((Object)(object)animalSpace != (Object)null)
			{
				itemInstance = animalSpace.foodFeeder.GetNextFoodFromContainer();
			}
			if (itemInstance != null)
			{
				num = ((!Item.NGIIPJDAMGP(itemInstance.LHBPOPOIFLE(), animalFeedItem)) ? (num + 1) : (num + 2));
			}
		}
		num += (hasWater ? 1 : 0);
		if (type != 0)
		{
			num += (hasWalked ? 1 : 0);
		}
		if (level != Mathf.Max(0, Mathf.Min(level + num, maxLevel)))
		{
			level = Mathf.Max(0, Mathf.Min(level + num, maxLevel));
			if (OnlineManager.IsMasterClient())
			{
				onlineAnimal.SendLevel(level);
			}
		}
		hasFood = false;
		hasWater = false;
		hasWalked = false;
		timerHasWalked = 0f;
		if (OnlineManager.PlayingOnline())
		{
			onlineAnimal.SendWalk();
		}
	}

	public void Hit(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || placeable.PHOCAFJDCDK)
		{
			return;
		}
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			ReduceLife(1);
			if (lives > 0)
			{
				FNFDDCPKOLI();
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineAnimal.SendHitToOthers(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineAnimal.SendHit(DDBOKLAGCDL);
		}
	}

	public void Sleep(bool AODONKKHPBP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.BarnInterior && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.Road)
		{
			return;
		}
		sleeping = AODONKKHPBP;
		behaviour.SetBool("Sleep", AODONKKHPBP);
		if (!isSick)
		{
			sleepEmote.SetBool("Sleep", AODONKKHPBP);
			if (OnlineManager.IsMasterClient())
			{
				onlineAnimal.SendEnableSleepEmote(AODONKKHPBP);
			}
		}
		if (!AODONKKHPBP)
		{
			WalkAround();
		}
	}

	private IEnumerator JHNIMJDFBPE()
	{
		if (OnlineManager.MasterOrOffline() && (Object)(object)hitCollider != (Object)null)
		{
			((Behaviour)hitCollider).enabled = true;
		}
		if (Application.isEditor)
		{
			Debug.Log((object)(((Object)((Component)this).gameObject).name + " dying!"));
		}
		hitFx.SetActive(false);
		hitFx.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			rb.isKinematic = false;
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 250f));
		}
		FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: true);
		PlayAnimalSound();
		MultiAudioManager.PlayAudioObject(sfxHit, ((Component)this).transform);
		behaviour.SetTrigger("Walk");
		yield return CommonReferences.wait04;
		obj = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position + new Vector3(0f, 1.5f, 0f), ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		if (OnlineManager.MasterOrOffline())
		{
			BNDMNNKHLMB();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public virtual bool IncrementProduction()
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (CMOBLFMDNKF.productionLimitedToOnce)
			{
				IncreaseProductionProgress(Mathf.Clamp01(CMOBLFMDNKF.productionItem.CKALIPBHDFB(GetNumTasksDone())), CDPAMNIPPEC: true);
				if (productionProgress >= 1f)
				{
					return true;
				}
			}
			else
			{
				if (productionProgress + CMOBLFMDNKF.productionItem.CKALIPBHDFB(GetNumTasksDone()) >= 1f)
				{
					IncreaseProductionProgress(CMOBLFMDNKF.productionItem.CKALIPBHDFB(GetNumTasksDone()) - 1f, CDPAMNIPPEC: true);
					return true;
				}
				IncreaseProductionProgress(CMOBLFMDNKF.productionItem.CKALIPBHDFB(GetNumTasksDone()), CDPAMNIPPEC: true);
			}
		}
		return false;
	}

	private void OnEnable()
	{
		if (Object.op_Implicit((Object)(object)work))
		{
			work.BGIJPOMIIMB += NGACEOEMGPG;
		}
		WalkAround();
	}

	protected void DKOMFLMOIJJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI && productionProgress >= 1f && !isSick)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("MilkAction"));
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(CMOBLFMDNKF.productionItem.item.JMDALJBNFML(), 1));
		}
	}
}
