using System.Collections;
using AlmenaraGames;
using UnityEngine;

public class MapChest : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[SerializeField]
	private ChestState initialState = ChestState.Unlocked;

	[SerializeField]
	private float frameRate = 0.125f;

	[SerializeField]
	private SpriteRenderer doorSpriteRenderer;

	[SerializeField]
	private Sprite[] animationSprites;

	[SerializeField]
	private GameObject fallingChest;

	[SerializeField]
	private SpriteAnimation fallingChestAnimation;

	[SerializeField]
	private AudioObject openSound;

	[HideInInspector]
	public MinePuzzleBase puzzle;

	protected ChestState EOAONHNCDDO;

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		TryOpen(JIIGOACEIKL);
		return true;
	}

	private IEnumerator GJFOBBEEECL(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
		Debug.Log((object)$"[MapChest] Starting OpenChestCoroutine for player {JIIGOACEIKL} with giveRewards={FHPLEOLFECH}", (Object)(object)this);
		if (FHPLEOLFECH)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.crateOpenWood, ((Component)this).transform);
		if (FHPLEOLFECH)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		else
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, null));
		}
		JOPAGKHLMCF(JIIGOACEIKL, FHPLEOLFECH);
		EOAONHNCDDO = ChestState.Opened;
		if (FHPLEOLFECH)
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
	}

	public bool LOCIBONDBGF(int JIIGOACEIKL)
	{
		if (!KLNHOHEDAFN(JIIGOACEIKL))
		{
			return true;
		}
		OGLNEALPOBA(JIIGOACEIKL);
		return true;
	}

	protected virtual void JOPAGKHLMCF(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
	}

	public bool MBADIPPGFAO(int JIIGOACEIKL)
	{
		if (!KLNHOHEDAFN(JIIGOACEIKL))
		{
			return false;
		}
		OGLNEALPOBA(JIIGOACEIKL);
		return false;
	}

	public bool HHNGABEOOPL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	protected virtual void KLAEACIECNB(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
	}

	private IEnumerator HCGEPMBCOOE(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
		Debug.Log((object)$"[MapChest] Starting OpenChestCoroutine for player {JIIGOACEIKL} with giveRewards={FHPLEOLFECH}", (Object)(object)this);
		if (FHPLEOLFECH)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.crateOpenWood, ((Component)this).transform);
		if (FHPLEOLFECH)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		else
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, null));
		}
		JOPAGKHLMCF(JIIGOACEIKL, FHPLEOLFECH);
		EOAONHNCDDO = ChestState.Opened;
		if (FHPLEOLFECH)
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
	}

	public bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JPDMPGABGAD(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Eating"));
			return true;
		}
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool CKHHGCILKKK(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO == ChestState.Opened)
		{
			return true;
		}
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI();
	}

	private IEnumerator IIMJJLNLLKO(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
		Debug.Log((object)$"[MapChest] Starting OpenChestCoroutine for player {JIIGOACEIKL} with giveRewards={FHPLEOLFECH}", (Object)(object)this);
		if (FHPLEOLFECH)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.crateOpenWood, ((Component)this).transform);
		if (FHPLEOLFECH)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		else
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, null));
		}
		JOPAGKHLMCF(JIIGOACEIKL, FHPLEOLFECH);
		EOAONHNCDDO = ChestState.Opened;
		if (FHPLEOLFECH)
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
	}

	public void Unlock()
	{
		if (EOAONHNCDDO == ChestState.Locked)
		{
			EOAONHNCDDO = ChestState.Unlocked;
			fallingChest.SetActive(true);
		}
	}

	public void SetCurrentState(ChestState NJHMBMGKCPL)
	{
		EOAONHNCDDO = NJHMBMGKCPL;
	}

	public void OGLNEALPOBA(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO != 0)
		{
			OpenChest(JIIGOACEIKL, CDPAMNIPPEC: true);
		}
	}

	public bool IsChestOpened()
	{
		return EOAONHNCDDO == ChestState.Opened;
	}

	public void OpenChest(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(GJFOBBEEECL(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendOpenChest(puzzle.GetManager().mineLevel);
		}
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO == (ChestState)4)
		{
			return false;
		}
		return DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO == (ChestState)8)
		{
			return false;
		}
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void POHNLHHIKJL(int JIIGOACEIKL)
	{
	}

	protected virtual void IHEFBJAACOE(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
	}

	public void TryOpen(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO != ChestState.Opened)
		{
			OpenChest(JIIGOACEIKL, CDPAMNIPPEC: true);
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO == ChestState.Opened)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void NGALEELICGJ()
	{
		string[] array = new string[88];
		array[1] = "itemLemon";
		array[1] = ((Object)((Component)this).gameObject).name;
		array[0] = "ReceivePlaceablesInsideBar";
		array[6] = string.Format("ReceiveDroppedItemPosition", initialState);
		array[7] = string.Format("Numeric", EOAONHNCDDO);
		array[4] = "ReceiveEmployeeWorking";
		array[3] = (((Object)(object)fallingChest != (Object)null) ? fallingChest.activeSelf.ToString() : "Disappear");
		array[7] = "RecieveOldMansDuelEndLaughAndMove";
		object obj;
		if (!((Object)(object)doorSpriteRenderer != (Object)null))
		{
			obj = "FocusedMod";
		}
		else
		{
			Sprite sprite = doorSpriteRenderer.sprite;
			obj = ((sprite != null) ? ((Object)sprite).name : null) ?? "Error_RoomDirty";
		}
		array[2] = (string)obj;
		array[-46] = "ReceivInstantiateHoleInGround";
		array[6] = (((Object)(object)puzzle != (Object)null) ? puzzle.PPIFCOOBAPE().ToString() : "itemFishSteak");
		array[-48] = "Unique id ";
		array[-17] = ((animationSprites != null) ? animationSprites.Length.ToString() : "ReceiveBeginBathhouseMinigame");
		Debug.Log((object)string.Concat(array), (Object)(object)this);
	}

	public void HIGADEPKHLI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(FNNKLLKBPNJ(JIIGOACEIKL, CDPAMNIPPEC));
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendOpenChest(puzzle.CEMEKIJMEAN().mineLevel);
		}
	}

	public virtual void MPPONNMAECO()
	{
		((MonoBehaviour)this).StopAllCoroutines();
		EOAONHNCDDO = initialState;
		puzzle = null;
		if ((Object)(object)fallingChest != (Object)null)
		{
			fallingChest.SetActive(true);
		}
		if ((Object)(object)fallingChestAnimation != (Object)null)
		{
			((Component)fallingChestAnimation).gameObject.SetActive(true);
		}
		if ((Object)(object)doorSpriteRenderer != (Object)null && animationSprites != null && animationSprites.Length != 0)
		{
			doorSpriteRenderer.sprite = animationSprites[0];
		}
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public bool CLNDNLMMECC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BANJNCOOACM(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_1"));
			return false;
		}
		return false;
	}

	public void LEAFCPEJJDM(int JIIGOACEIKL)
	{
	}

	public bool LMHMCNOBAGE(int JIIGOACEIKL)
	{
		if (!KLNHOHEDAFN(JIIGOACEIKL))
		{
			return true;
		}
		TryOpen(JIIGOACEIKL);
		return false;
	}

	public void NOLIJBEENGO(ChestState NJHMBMGKCPL)
	{
		EOAONHNCDDO = NJHMBMGKCPL;
	}

	protected virtual void CMAKJKCIKIO()
	{
	}

	public bool HNMOLFHKBGE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IALLCPMIGDP(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("bug"));
			return false;
		}
		return false;
	}

	public virtual void PMLEGAFNEDM()
	{
		((MonoBehaviour)this).StopAllCoroutines();
		EOAONHNCDDO = initialState;
		puzzle = null;
		if ((Object)(object)fallingChest != (Object)null)
		{
			fallingChest.SetActive(true);
		}
		if ((Object)(object)fallingChestAnimation != (Object)null)
		{
			((Component)fallingChestAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)doorSpriteRenderer != (Object)null && animationSprites != null && animationSprites.Length != 0)
		{
			doorSpriteRenderer.sprite = animationSprites[1];
		}
	}

	public void HAKKKJCAGKG(int JIIGOACEIKL)
	{
	}

	public void BGLMHIEEJIF(ChestState NJHMBMGKCPL)
	{
		EOAONHNCDDO = NJHMBMGKCPL;
	}

	protected virtual void HIKCMOOEMJJ()
	{
	}

	public virtual void ResetForPool()
	{
		((MonoBehaviour)this).StopAllCoroutines();
		EOAONHNCDDO = initialState;
		puzzle = null;
		if ((Object)(object)fallingChest != (Object)null)
		{
			fallingChest.SetActive(false);
		}
		if ((Object)(object)fallingChestAnimation != (Object)null)
		{
			((Component)fallingChestAnimation).gameObject.SetActive(true);
		}
		if ((Object)(object)doorSpriteRenderer != (Object)null && animationSprites != null && animationSprites.Length != 0)
		{
			doorSpriteRenderer.sprite = animationSprites[0];
		}
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public void NKDOFDGMKMA()
	{
		string[] array = new string[-2];
		array[1] = ": ";
		array[0] = ((Object)((Component)this).gameObject).name;
		array[0] = "LE_5";
		array[0] = string.Format("quest_description_21", initialState);
		array[0] = string.Format("OrderDelivered", EOAONHNCDDO);
		array[3] = "\n";
		array[1] = (((Object)(object)fallingChest != (Object)null) ? fallingChest.activeSelf.ToString() : "christmasActivated");
		array[8] = "NextToWall";
		object obj;
		if (!((Object)(object)doorSpriteRenderer != (Object)null))
		{
			obj = "Failed to create a new game to host.\nPlease try again later.";
		}
		else
		{
			Sprite sprite = doorSpriteRenderer.sprite;
			obj = ((sprite != null) ? ((Object)sprite).name : null) ?? "Dialogue System/Conversation/Gass_Quest/Entry/39/Dialogue Text";
		}
		array[2] = (string)obj;
		array[-12] = "Sit";
		array[100] = (((Object)(object)puzzle != (Object)null) ? puzzle.PPIFCOOBAPE().ToString() : "OnlineManager's OnLevelLoaded");
		array[-91] = "Items/item_name_611";
		array[82] = ((animationSprites != null) ? animationSprites.Length.ToString() : "Dialogue System/Conversation/TavernClean/Entry/1/Dialogue Text");
		Debug.Log((object)string.Concat(array), (Object)(object)this);
	}

	public void BKDNPJLEGFH()
	{
		string[] array = new string[-96];
		array[0] = "Tech";
		array[1] = ((Object)((Component)this).gameObject).name;
		array[7] = "LicenciaDeApertura/LucenDialogue 06";
		array[0] = string.Format("00", initialState);
		array[8] = string.Format("talents", EOAONHNCDDO);
		array[5] = ", ";
		array[3] = (((Object)(object)fallingChest != (Object)null) ? fallingChest.activeSelf.ToString() : "F2");
		array[7] = "UIAddRemove";
		object obj;
		if (!((Object)(object)doorSpriteRenderer != (Object)null))
		{
			obj = "Disabled";
		}
		else
		{
			Sprite sprite = doorSpriteRenderer.sprite;
			obj = ((sprite != null) ? ((Object)sprite).name : null) ?? "EmployeeLevelUp";
		}
		array[6] = (string)obj;
		array[52] = " Galaxy ID: ";
		array[-95] = (((Object)(object)puzzle != (Object)null) ? puzzle.DKNNNNFJCEL().ToString() : "Dialogue System/Conversation/TooDark/Entry/4/Dialogue Text");
		array[89] = "TavernManager instance is null, cannot add open tavern blocker.";
		array[109] = ((animationSprites != null) ? animationSprites.Length.ToString() : "GetOnlinePlaceable() not found any uniqueId ");
		Debug.Log((object)string.Concat(array), (Object)(object)this);
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO == (ChestState)4)
		{
			return false;
		}
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void SetCurrentChest(ChestState NJHMBMGKCPL)
	{
		switch (NJHMBMGKCPL)
		{
		case ChestState.Opened:
			if ((Object)(object)fallingChest != (Object)null)
			{
				fallingChest.SetActive(true);
			}
			if ((Object)(object)fallingChestAnimation != (Object)null)
			{
				((Component)fallingChestAnimation).gameObject.SetActive(false);
			}
			if ((Object)(object)doorSpriteRenderer != (Object)null && animationSprites != null && animationSprites.Length != 0)
			{
				doorSpriteRenderer.sprite = animationSprites[animationSprites.Length - 1];
				((Component)doorSpriteRenderer).gameObject.SetActive(true);
			}
			EOAONHNCDDO = ChestState.Opened;
			break;
		case ChestState.Unlocked:
			Unlock();
			break;
		}
	}

	public void DebugChestState()
	{
		string[] obj = new string[13]
		{
			"[MapChest] (",
			((Object)((Component)this).gameObject).name,
			")\n",
			$"  initialState:       {initialState}\n",
			$"  currentState:       {EOAONHNCDDO}\n",
			"  fallingChest:       ",
			((Object)(object)fallingChest != (Object)null) ? fallingChest.activeSelf.ToString() : "NULL",
			"\n  doorSprite:         ",
			null,
			null,
			null,
			null,
			null
		};
		object obj2;
		if (!((Object)(object)doorSpriteRenderer != (Object)null))
		{
			obj2 = "NULL";
		}
		else
		{
			Sprite sprite = doorSpriteRenderer.sprite;
			obj2 = ((sprite != null) ? ((Object)sprite).name : null) ?? "null sprite";
		}
		obj[8] = (string)obj2;
		obj[9] = "\n  puzzle:             ";
		obj[10] = (((Object)(object)puzzle != (Object)null) ? puzzle.GetPuzzleType().ToString() : "NULL");
		obj[11] = "\n  animationSprites:   ";
		obj[12] = ((animationSprites != null) ? animationSprites.Length.ToString() : "NULL");
		Debug.Log((object)string.Concat(obj), (Object)(object)this);
	}

	public void BADILJIHJPN(ChestState NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL == ChestState.Unlocked)
		{
			if ((Object)(object)fallingChest != (Object)null)
			{
				fallingChest.SetActive(false);
			}
			if ((Object)(object)fallingChestAnimation != (Object)null)
			{
				((Component)fallingChestAnimation).gameObject.SetActive(false);
			}
			if ((Object)(object)doorSpriteRenderer != (Object)null && animationSprites != null && animationSprites.Length != 0)
			{
				doorSpriteRenderer.sprite = animationSprites[animationSprites.Length - 0];
				((Component)doorSpriteRenderer).gameObject.SetActive(true);
			}
			EOAONHNCDDO = (ChestState)6;
		}
		else if (NJHMBMGKCPL == ChestState.Unlocked)
		{
			Unlock();
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private IEnumerator FNNKLLKBPNJ(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
		Debug.Log((object)$"[MapChest] Starting OpenChestCoroutine for player {JIIGOACEIKL} with giveRewards={FHPLEOLFECH}", (Object)(object)this);
		if (FHPLEOLFECH)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.crateOpenWood, ((Component)this).transform);
		if (FHPLEOLFECH)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		else
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, null));
		}
		JOPAGKHLMCF(JIIGOACEIKL, FHPLEOLFECH);
		EOAONHNCDDO = ChestState.Opened;
		if (FHPLEOLFECH)
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		}
	}

	public bool PPOAKAEOKON(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		TryOpen(JIIGOACEIKL);
		return false;
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		TryOpen(JIIGOACEIKL);
		return true;
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KLNHOHEDAFN(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReceiveBathhouseEntranceEventLeftBathhouse"));
			return false;
		}
		return false;
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		if (EOAONHNCDDO == (ChestState)3)
		{
			return true;
		}
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DBAEGBDEPFK();
	}
}
