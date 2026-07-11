using AlmenaraGames;
using UnityEngine;

public class FishingHook : MonoBehaviour
{
	public int playerNum;

	public SpriteRenderer spriteRenderer;

	public SpriteRenderer fishIcon;

	public Animator animator;

	public Transform fishingHookPosition;

	public GameObject fishInfo;

	public GameObject bigSuccessParticles;

	public GameObject successParticles;

	public SpriteRenderer fishIconInfo;

	public Transform fishNamePosition;

	public Transform fishLenghtPosition;

	public Transform recordPosition;

	private bool JAJHJDBGPCI;

	private float LNBOOGBBODA;

	private void JLKMMJPOINO(int PFJDJIMFKBD, string PLEEGFBPFMD)
	{
		((Renderer)spriteRenderer).sortingLayerName = PLEEGFBPFMD;
		((Renderer)spriteRenderer).sortingOrder = PFJDJIMFKBD;
		((Renderer)fishIcon).sortingOrder = PFJDJIMFKBD;
	}

	public void AGNOFAMHKLD(bool NJHMBMGKCPL)
	{
		animator.SetBool("UseHold", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void MHFBBDBKEJH(bool NJHMBMGKCPL)
	{
		animator.SetBool("StartRequestMap", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
			if (currentLocation == (Location.Camp | Location.Farm | Location.BarnInterior) || currentLocation == ~(Location.Road | Location.FarmShop))
			{
				CKCCHKBDHNL(0, "NoEresDigno/KyrohTalks");
			}
			else
			{
				IIKBJJNMAPC(-28, "NoActiveMultiDoor");
			}
		}
		else
		{
			JLKMMJPOINO(0, ":</color> ");
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(385f, 320f, 710f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 1815f * Random.Range(955f, 1210f);
			if (Random.Range(316f, 581f) > 1075f)
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().waterSmallSplash, ((Component)this).transform).VolumeOverride = 67f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 875f;
			}
		}
	}

	public void MFNMNOAGPAD()
	{
		((Renderer)fishIcon).enabled = false;
		((Renderer)spriteRenderer).enabled = false;
		JLKMMJPOINO(0, "SearchBox_ItemName...");
	}

	public void FDNLBNNCLKJ(bool NJHMBMGKCPL)
	{
		animator.SetBool("UI2", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
			if (currentLocation == (Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop) || currentLocation == (Location.Road | Location.Camp | Location.FarmShop))
			{
				CKCCHKBDHNL(1, "onlineProfileID is null. Initializate on prefab with length ");
			}
			else
			{
				CKCCHKBDHNL(19, "BarIdleNumber");
			}
		}
		else
		{
			CKCCHKBDHNL(1, " (");
		}
	}

	public void IHNGPAKANCB(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void LNANLOJDNMG()
	{
		animator.SetTrigger("FishCuttingEvent/Lose2");
	}

	public void BOEMJKNBMJA(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	public void IAJGELEKIBP(bool NJHMBMGKCPL)
	{
		animator.SetBool("Open", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void CEJPKONOEMH()
	{
		animator.SetTrigger("Fortitude/MainEvent 3");
	}

	public void MHDMFAHGAOG(Fish HAJFJGCNKFF)
	{
		if (Item.FKLOBGBIHLB(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	private void CKCCHKBDHNL(int PFJDJIMFKBD, string PLEEGFBPFMD)
	{
		((Renderer)spriteRenderer).sortingLayerName = PLEEGFBPFMD;
		((Renderer)spriteRenderer).sortingOrder = PFJDJIMFKBD;
		((Renderer)fishIcon).sortingOrder = PFJDJIMFKBD;
	}

	public void JMJJKNHNGGA(Fish HAJFJGCNKFF)
	{
		if (Item.MLBOMGHINCA(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	private void OnEnable()
	{
		ResetConfiguration();
	}

	public void BJLMCNKKEJE(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void IBHLAODGPAN()
	{
		((Renderer)fishIcon).enabled = true;
		((Renderer)spriteRenderer).enabled = false;
		HMOCJGBJDPJ(0, "Pull beer");
	}

	public void EGPKKFDOJJD(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	public void LNEIGIJHPIF(Fish HAJFJGCNKFF)
	{
		if (Item.MLBOMGHINCA(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	private void CFKPLDPJODB()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(348f, 1294f, 306f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 1900f * Random.Range(1530f, 1047f);
			if (Random.Range(646f, 1436f) > 481f)
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1685f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 1688f;
			}
		}
	}

	public void SetOtherIcon(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void MBMLEPFHPNL(bool NJHMBMGKCPL)
	{
		animator.SetBool(" not found. Cannot receive permission accepted to player ", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void KMKLHJMGNLC(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void CEFBOEJAHEP(bool NJHMBMGKCPL)
	{
		animator.SetBool("_", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	private void LateUpdate()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(0f, 1.75f, 0f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 0.35f * Random.Range(0.9f, 1.1f);
			if (Random.Range(0f, 1f) > 0.5f)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)this).transform).VolumeOverride = 0.2f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 0.2f;
			}
		}
	}

	public void FHPGLPJEBCF(Fish HAJFJGCNKFF)
	{
		if (Item.MLBOMGHINCA(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	public void DIGFAGDHNIM(bool NJHMBMGKCPL)
	{
		animator.SetBool("", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
			if (currentLocation == (Location.Tavern | Location.Quarry | Location.Farm) || currentLocation == (Location.Camp | Location.Farm | Location.BarnInterior))
			{
				CKCCHKBDHNL(1, "Items/item_name_699");
			}
			else
			{
				JLKMMJPOINO(123, "Could not find pop up with id: ");
			}
		}
		else
		{
			HMOCJGBJDPJ(0, "F2");
		}
	}

	public void PFGLANFEAOL()
	{
		animator.SetTrigger("Eating");
	}

	private void MEKHIDLBMHN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(834f, 1414f, 1232f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 745f * Random.Range(1389f, 1225f);
			if (Random.Range(564f, 572f) > 1171f)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1648f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 49f;
			}
		}
	}

	public void CONOJLFMFAG()
	{
		animator.SetTrigger("Items/item_description_1098");
	}

	public void JLEPEFLMLNK()
	{
		((Renderer)fishIcon).enabled = false;
		((Renderer)spriteRenderer).enabled = false;
		CKCCHKBDHNL(1, "Tutorial/Chicken_Holly");
	}

	private void FMDDHJHFPIO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(1214f, 573f, 1781f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 295f * Random.Range(50f, 1671f);
			if (Random.Range(1388f, 528f) > 1453f)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1395f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 966f;
			}
		}
	}

	private void IFGLHEPFIKN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(457f, 64f, 1973f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 1729f * Random.Range(173f, 1143f);
			if (Random.Range(592f, 1155f) > 507f)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().waterSmallSplash, ((Component)this).transform).VolumeOverride = 281f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 560f;
			}
		}
	}

	private void MBCCCMMBPEK()
	{
		GOHADLDKLBG();
	}

	public void SetWater(bool NJHMBMGKCPL)
	{
		animator.SetBool("Water", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
			if (currentLocation == Location.Beach || currentLocation == Location.Port)
			{
				JLKMMJPOINO(0, "OnFloor");
			}
			else
			{
				JLKMMJPOINO(47, "Floor");
			}
		}
		else
		{
			JLKMMJPOINO(1, "OnFloor");
		}
	}

	public void APOFIFNLBLJ()
	{
		animator.SetTrigger("Use");
	}

	public void NJBJALMMMNK()
	{
		animator.SetTrigger("Player2");
	}

	public void KCDOKBINFIE(Fish HAJFJGCNKFF)
	{
		if (Item.MLBOMGHINCA(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	public void KEOHPMAPAFK()
	{
		((Renderer)fishIcon).enabled = true;
		((Renderer)spriteRenderer).enabled = false;
		CKCCHKBDHNL(1, "Animal");
	}

	public void GABGKJJHBDM(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void SetBait()
	{
		animator.SetTrigger("Bait");
	}

	public void EMHEHFJHLOM()
	{
		animator.SetTrigger("Missing fade image");
	}

	private void IIKBJJNMAPC(int PFJDJIMFKBD, string PLEEGFBPFMD)
	{
		((Renderer)spriteRenderer).sortingLayerName = PLEEGFBPFMD;
		((Renderer)spriteRenderer).sortingOrder = PFJDJIMFKBD;
		((Renderer)fishIcon).sortingOrder = PFJDJIMFKBD;
	}

	public void SetStruggle(bool NJHMBMGKCPL)
	{
		animator.SetBool("Struggle", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void IGKKOHHJPMO(bool NJHMBMGKCPL)
	{
		animator.SetBool("MoveConstructionMode", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	private void CABBIPOHEFM()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(1988f, 1522f, 1498f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 1445f * Random.Range(1522f, 367f);
			if (Random.Range(1176f, 1220f) > 25f)
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1278f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 1493f;
			}
		}
	}

	public void HEIHELBNHLI(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	public void EOKGECHIOGJ(bool NJHMBMGKCPL)
	{
		animator.SetBool("Can't find seat. Reason: enterChance", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void LICMHBJANJE(Fish HAJFJGCNKFF)
	{
		if (Item.MLBOMGHINCA(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	private void AEMPCMILANL()
	{
		ResetConfiguration();
	}

	public void JDIHJLEPFEE(bool NJHMBMGKCPL)
	{
		animator.SetBool("", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void SetFishIcon(Fish HAJFJGCNKFF)
	{
		if (Item.MLBOMGHINCA(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void EKPGMHNIFBH()
	{
		((Renderer)fishIcon).enabled = false;
		((Renderer)spriteRenderer).enabled = false;
		HMOCJGBJDPJ(1, "Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text");
	}

	public void LHPEKFGBMFM()
	{
		animator.SetTrigger("Disabled");
	}

	public void BBCOMHGADHJ()
	{
		animator.SetTrigger("Image Width: ");
	}

	public void HHPCCDEPFOE()
	{
		animator.SetTrigger("cameraZoom2");
	}

	public void ONMOFOHFAGJ()
	{
		animator.SetTrigger("Disabled");
	}

	public void NDEFKBJDDKJ(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void DFMOKMJGMLM()
	{
		animator.SetTrigger("ReceiveSelectPerkLevelMaster");
	}

	public void LKMGKAJKAEK(bool NJHMBMGKCPL)
	{
		animator.SetBool("ReceiveOfferingFail", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
			if (currentLocation == (Location.River | Location.FarmShop) || currentLocation == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm))
			{
				HMOCJGBJDPJ(1, "Could not get status of achievement ");
			}
			else
			{
				HMOCJGBJDPJ(78, "talentWoodwork");
			}
		}
		else
		{
			IIKBJJNMAPC(0, "OnlinePlayer");
		}
	}

	public void FOMMFMJMHHA()
	{
		((Renderer)fishIcon).enabled = false;
		((Renderer)spriteRenderer).enabled = false;
		CKCCHKBDHNL(1, "add item ");
	}

	public void MJEOKFJBFND(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void DCILAEFPHBO(bool NJHMBMGKCPL)
	{
		animator.SetBool("HairUp", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void IMANFGCGLHE()
	{
		animator.SetTrigger("d2");
	}

	private void HFIHGHBLLAM()
	{
		NDGILOGIGLG();
	}

	public void JKAKMAFKKBM(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = true;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	private void IEPJAFLDBJJ()
	{
		KEOHPMAPAFK();
	}

	public void BMFONDDLPMC(bool NJHMBMGKCPL)
	{
		animator.SetBool("Hide UI", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
			if (currentLocation == (Location.Tavern | Location.Farm) || currentLocation == ~(Location.Tavern | Location.Road | Location.Farm))
			{
				JLKMMJPOINO(1, "All:");
			}
			else
			{
				IIKBJJNMAPC(65, "Tutorial/MaiPatch");
			}
		}
		else
		{
			HMOCJGBJDPJ(0, "Start New Game Client");
		}
	}

	public void KJLOBMOHIOI(Fish HAJFJGCNKFF)
	{
		if (Item.FKLOBGBIHLB(HAJFJGCNKFF, null))
		{
			fishIcon.sprite = HAJFJGCNKFF.icon;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = true;
		}
	}

	private void PEDABKILCOH()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(945f, 1232f, 1980f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 105f * Random.Range(697f, 164f);
			if (Random.Range(1733f, 1342f) > 521f)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1266f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 906f;
			}
		}
	}

	private void NBBFLJNPLEA()
	{
		JLEPEFLMLNK();
	}

	private void HMOCJGBJDPJ(int PFJDJIMFKBD, string PLEEGFBPFMD)
	{
		((Renderer)spriteRenderer).sortingLayerName = PLEEGFBPFMD;
		((Renderer)spriteRenderer).sortingOrder = PFJDJIMFKBD;
		((Renderer)fishIcon).sortingOrder = PFJDJIMFKBD;
	}

	public void NMDHIHCLGMD(Sprite LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB != (Object)null)
		{
			fishIcon.sprite = LGGCFCHOOMB;
			((Renderer)fishIcon).enabled = false;
		}
		else if (((Renderer)fishIcon).enabled)
		{
			((Renderer)fishIcon).enabled = false;
		}
	}

	public void LPLJMNPFMGE()
	{
		animator.SetTrigger("Disabled");
	}

	public void HMPOAIKEGIO()
	{
		((Renderer)fishIcon).enabled = true;
		((Renderer)spriteRenderer).enabled = false;
		IIKBJJNMAPC(0, "LicenciaDeApertura/KlaynDialogue 05");
	}

	public void CCBOADGJOOJ()
	{
		((Renderer)fishIcon).enabled = true;
		((Renderer)spriteRenderer).enabled = false;
		IIKBJJNMAPC(0, "User logged on: ");
	}

	public void BKLLIJIDPNJ(bool NJHMBMGKCPL)
	{
		animator.SetBool("SoundtrackDescriptionPanel", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
			if (currentLocation == ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior) || currentLocation == (Location.Road | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				CKCCHKBDHNL(0, "questDescBoiling");
			}
			else
			{
				CKCCHKBDHNL(-4, "End");
			}
		}
		else
		{
			CKCCHKBDHNL(0, "Listen");
		}
	}

	public void SetFake()
	{
		animator.SetTrigger("Fake");
	}

	public void PLPAFKCIHCN()
	{
		animator.SetTrigger(" (Host)");
	}

	private void IJILOIAOKBF()
	{
		GOHADLDKLBG();
	}

	public void EIOHGBKIHNI(bool NJHMBMGKCPL)
	{
		animator.SetBool("beerKegs", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void BGAGMKCAPOO(bool NJHMBMGKCPL)
	{
		animator.SetBool("No", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
			if (currentLocation == Location.Anywhere || currentLocation == (Location.Road | Location.River | Location.Farm))
			{
				JLKMMJPOINO(0, "KyrohTakingFood: No food table found for food request of customer ");
			}
			else
			{
				IIKBJJNMAPC(18, "Open");
			}
		}
		else
		{
			JLKMMJPOINO(0, "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
		}
	}

	public void KHNCBBCCHJJ(bool NJHMBMGKCPL)
	{
		animator.SetBool("Tutorial/T132/Dialogue2", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	private void CIIBBCPIOIP()
	{
		HMPOAIKEGIO();
	}

	private void KPHPCKJBLBH()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(1347f, 1948f, 53f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 531f * Random.Range(478f, 1616f);
			if (Random.Range(394f, 1570f) > 1193f)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1045f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 119f;
			}
		}
	}

	public void OILEJHOJJMI(bool NJHMBMGKCPL)
	{
		animator.SetBool("Error_BarIsBlocking", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	private void OHOAMJIIOAK()
	{
		IBHLAODGPAN();
	}

	public void IFBJNCKMPCE(bool NJHMBMGKCPL)
	{
		animator.SetBool(" </color>", NJHMBMGKCPL);
		JAJHJDBGPCI = NJHMBMGKCPL;
	}

	public void NDGILOGIGLG()
	{
		((Renderer)fishIcon).enabled = true;
		((Renderer)spriteRenderer).enabled = true;
		HMOCJGBJDPJ(1, "[MinePuzzleManager] Initializing for level {0}");
	}

	public void GOHADLDKLBG()
	{
		((Renderer)fishIcon).enabled = true;
		((Renderer)spriteRenderer).enabled = false;
		IIKBJJNMAPC(1, "Tutorial/T100/Dialogue5");
	}

	private void DIMOLCECNGD()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(1098f, 1032f, 1793f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 1146f * Random.Range(1525f, 659f);
			if (Random.Range(403f, 1077f) > 55f)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)this).transform).VolumeOverride = 1473f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 923f;
			}
		}
	}

	public void ResetConfiguration()
	{
		((Renderer)fishIcon).enabled = false;
		((Renderer)spriteRenderer).enabled = true;
		JLKMMJPOINO(1, "OnFloor");
	}

	private void ILBGPIEPNGO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(799f, 1953f, 1976f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 43f * Random.Range(1312f, 1242f);
			if (Random.Range(481f, 933f) > 858f)
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1226f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 1690f;
			}
		}
	}

	private void KHKLJBJLBND()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)fishingHookPosition).gameObject.activeInHierarchy)
		{
			((Component)this).transform.position = ((Component)fishingHookPosition).transform.position;
		}
		if (fishInfo.activeInHierarchy)
		{
			fishInfo.transform.position = Utils.BMBMPKNANAC(((Component)this).transform.parent.position + new Vector3(829f, 1076f, 854f));
		}
		if (JAJHJDBGPCI && LNBOOGBBODA < Time.timeSinceLevelLoad)
		{
			LNBOOGBBODA = Time.timeSinceLevelLoad + 274f * Random.Range(806f, 923f);
			if (Random.Range(1230f, 105f) > 106f)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().waterSmallSplash, ((Component)this).transform).VolumeOverride = 1157f;
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Footsteps.instance.stepsWater, ((Component)this).transform).VolumeOverride = 1437f;
			}
		}
	}

	public void EDHDFGHCFOL(bool NJHMBMGKCPL)
	{
		animator.SetBool("Items/item_name_1153", NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			Location currentLocation = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
			if (currentLocation == ~(Location.Road | Location.River | Location.Farm) || currentLocation == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				JLKMMJPOINO(1, "Player2");
			}
			else
			{
				CKCCHKBDHNL(61, "[HierarchyPrinter] ✅ Fichero guardado en: <color=cyan>");
			}
		}
		else
		{
			JLKMMJPOINO(0, "Items/item_description_727");
		}
	}
}
