using AlmenaraGames;
using Unity.Collections;
using UnityEngine;

public class DogAnimation : CharacterAnimBase
{
	public DogAnimator dogAnimator;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private GameObject loveEmote;

	[ReadOnly]
	public OnlineDog onlineDog;

	private DogNPC IHGHFIBLFFG;

	private Vector3 EJACBOOECHP;

	private Vector3 AADMIOHCEEB;

	private int AAMNCMMDJLM;

	private float KAGACBFLOCM;

	private float FADGAEJNDOA = 5f;

	private MultiAudioSource EINDLGPJLCP;

	private float FAHMDMLHPPO;

	private int IMCFMGGOCHP;

	private int JIFFOKNLHHD;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			if (FCGBJEIIMBC == value)
			{
				return;
			}
			base.FCGBJEIIMBC = value;
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
			if (OnlineManager.IsMasterClient() && (Object)(object)onlineDog != (Object)null)
			{
				onlineDog.SendDirection(value);
			}
		}
	}

	public void MOFOAMNGHCM(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(true);
			EINDLGPJLCP = null;
		}
		FOLLIMBJNMK("'", AODONKKHPBP: false, CDPAMNIPPEC: true);
		OCGKMIIPJJF("Back", AODONKKHPBP: true, CDPAMNIPPEC: false);
		DJAPIEALHAB("Run", AODONKKHPBP: false, CDPAMNIPPEC: false);
		JKGGHCHHCFG("target fps", AODONKKHPBP: true, CDPAMNIPPEC: false);
		FAPMGINDKEE("NeedsRecipe", AODONKKHPBP: false, CDPAMNIPPEC: true);
		MNOLHIHHNCE("questNameFarming", AODONKKHPBP: false, CDPAMNIPPEC: true);
		FAPMGINDKEE("Sleep", AODONKKHPBP: false, CDPAMNIPPEC: false);
		AJIMCICANFO("Items/item_name_1056", AODONKKHPBP: true, CDPAMNIPPEC: false);
		MNOLHIHHNCE("Disabled", AODONKKHPBP: false, CDPAMNIPPEC: true);
		JKGGHCHHCFG("Dog", AODONKKHPBP: true, CDPAMNIPPEC: false);
		IHGHFIBLFFG.dirt.SetActive(true);
		IHGHFIBLFFG.snow.SetActive(false);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.FCOPKMDLAMD();
		}
		JIFFOKNLHHD = 1;
		IMCFMGGOCHP = 1;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.BPPPNHHBGON();
		}
	}

	private void OLOJBLCILHE()
	{
		if (!GetBool("ReceiveGetUniqueCropHarvestableOnClient"))
		{
			BCLKDEFPIEM();
			SetBool("[MinePuzzleManager] Ordered puzzle queue for level {0}: [{1}]", EGFGNGJGBOP: false);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = false;
				DogNPC.instance.currentDogHole.JKNLPPOBAEB();
			}
			FAHMDMLHPPO = Time.time + 1286f;
			MPONLOIFIMI(Sound.DIHCEGINELM().dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.ChangeState(DogState.IdleNearPlayer);
		}
	}

	private void JEHIMHBBAOM()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1809f)
		{
			if (FCGBJEIIMBC != Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC))
			{
				if (AAMNCMMDJLM > 0)
				{
					FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
					AAMNCMMDJLM = 0;
				}
				else
				{
					AAMNCMMDJLM++;
				}
			}
			else
			{
				AAMNCMMDJLM = 0;
			}
			if (!LHGMJFGOHFD())
			{
				FOLLIMBJNMK("Trying to get an invalid Other player with playerNum: ", AODONKKHPBP: false, CDPAMNIPPEC: true);
				IHHBOLPDMCJ(AODONKKHPBP: false);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
				{
					onlineDog.LBBCANANBGI("KentaProgress", AODONKKHPBP: false);
				}
			}
			if (!MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed == onlineDog.dogNpc.runSpeed)
			{
				OCGKMIIPJJF("IdleCamp", AODONKKHPBP: true, CDPAMNIPPEC: false);
				MHEOAHLBGHC = false;
			}
			else if (MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed != onlineDog.dogNpc.runSpeed)
			{
				LEFHICGPEPH("path not found", AODONKKHPBP: true, CDPAMNIPPEC: true);
				MHEOAHLBGHC = false;
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			DJAPIEALHAB("ActionBar2", AODONKKHPBP: false, CDPAMNIPPEC: false);
			base.CNKHDCIKHCO = true;
			AJIMCICANFO("Invalid player num", AODONKKHPBP: true, CDPAMNIPPEC: true);
			MHEOAHLBGHC = true;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
			{
				onlineDog.SendSetBool("ReceiveSitDown", AODONKKHPBP: false);
			}
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void CGELCJDBGNK(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			BBNCEDICPAM();
			break;
		case DogNPC.DogInteractionType.Friendly:
			HNAHEIGNJAJ();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Sleep:
			BHLMKLBFPKN();
			break;
		case DogNPC.DogInteractionType.Dig:
			ICBJPLEJPFH();
			break;
		case DogNPC.DogInteractionType.Drink:
			KNHIBCINPOP();
			break;
		case DogNPC.DogInteractionType.Eat:
			IADJDFINFMF();
			break;
		case DogNPC.DogInteractionType.Toy:
			BOBFNBLEKDJ();
			break;
		case DogNPC.DogInteractionType.Smell:
			PHGMKECMGKH();
			break;
		case DogNPC.DogInteractionType.Scratch:
			MCNIFLFDJII();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.AALIPKFGHBJ(NCMDEGABGCH);
		}
	}

	private void IADJDFINFMF()
	{
		if (!JEJPKGILEDB("Items/item_name_1146"))
		{
			SetBool("Items/item_description_1056", EGFGNGJGBOP: true, HALNIEBONKH: true);
			FAHMDMLHPPO = Time.time + 1613f;
		}
	}

	private void FLIBHKOFOOG()
	{
		if (!GetBool("Cannot load old character saved"))
		{
			MHEKKPODAFD();
			CGEADHOLHCH("No room mode has been selected", EGFGNGJGBOP: true, HALNIEBONKH: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = false;
				DogNPC.instance.currentDogHole.PBNHJHDMNAP();
			}
			FAHMDMLHPPO = Time.time + 103f;
			MPONLOIFIMI(Sound.OKAPNFPFPFP().dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.IHMEOKNMHIJ(DogState.FollowPlayer);
		}
	}

	public void GPMPDEAFAOB(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.None:
			LENFJBDHAJG();
			break;
		case DogNPC.DogInteractionType.Bark:
			MOPHCIODLOF();
			break;
		case DogNPC.DogInteractionType.Friendly:
			BBNCEDICPAM();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			GNHMABDFPHM();
			break;
		case DogNPC.DogInteractionType.Sleep:
			FLIBHKOFOOG();
			break;
		case DogNPC.DogInteractionType.Dig:
			JIPIGHKCNIL();
			break;
		case DogNPC.DogInteractionType.Drink:
			KHDPPAHBMAE();
			break;
		case DogNPC.DogInteractionType.Eat:
			BOBFNBLEKDJ();
			break;
		case DogNPC.DogInteractionType.Toy:
			DDMHMOJONLG();
			break;
		case DogNPC.DogInteractionType.Smell:
			MCNIFLFDJII();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.AALIPKFGHBJ(NCMDEGABGCH);
		}
	}

	public void KGDOODIBDBD()
	{
		loveEmote.SetActive(false);
	}

	private void KNHIBCINPOP()
	{
		if (!GetBool("ReceivePlaceablesInsideBar"))
		{
			SetBool("Room missing required items", EGFGNGJGBOP: true, HALNIEBONKH: true);
			FAHMDMLHPPO = Time.time + 1833f;
			INPGIONKHFB(Sound.BNBMNOMFFBE().dogDrinking);
		}
	}

	private void JIPIGHKCNIL()
	{
		if (!JEJPKGILEDB("itemRyeSeeds"))
		{
			SetBool("itemPilsner", EGFGNGJGBOP: true);
			FAHMDMLHPPO = Time.time + 231f;
			EBIDAMBGALD(Sound.ABDJJBFNLBJ().dogDrinking);
		}
	}

	private void IOPCKCNDBGP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 776f)
		{
			if (FCGBJEIIMBC != Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC))
			{
				if (AAMNCMMDJLM > 1)
				{
					NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
					AAMNCMMDJLM = 0;
				}
				else
				{
					AAMNCMMDJLM++;
				}
			}
			else
			{
				AAMNCMMDJLM = 0;
			}
			if (!LHGMJFGOHFD())
			{
				OCGKMIIPJJF("Player/Bark/Tutorial/T138", AODONKKHPBP: false, CDPAMNIPPEC: true);
				base.CNKHDCIKHCO = false;
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
				{
					onlineDog.LBBCANANBGI(": ", AODONKKHPBP: false);
				}
			}
			if (!MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed == onlineDog.dogNpc.runSpeed)
			{
				AJIMCICANFO("ScrollDown", AODONKKHPBP: true, CDPAMNIPPEC: false);
				MHEOAHLBGHC = true;
			}
			else if (MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed != onlineDog.dogNpc.runSpeed)
			{
				LEFHICGPEPH("ReceiveSetBool", AODONKKHPBP: false, CDPAMNIPPEC: false);
				MHEOAHLBGHC = true;
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			NLACAJGHGJL("Items/item_name_1176", AODONKKHPBP: true, CDPAMNIPPEC: false);
			IHHBOLPDMCJ(AODONKKHPBP: false);
			NLACAJGHGJL("Direction", AODONKKHPBP: false, CDPAMNIPPEC: false);
			MHEOAHLBGHC = true;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
			{
				onlineDog.JDDODODGDKL("Brook Recipe active", AODONKKHPBP: false);
			}
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GEBOOAAJNCK()
	{
		if (!JEJPKGILEDB("add item "))
		{
			SetBool("Items/item_description_676", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	private void MNOLHIHHNCE(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP, HALNIEBONKH: true);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.JDDODODGDKL(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void HOCMIKKKFLO()
	{
		if (!GetBool(" "))
		{
			GFFBKFNAFMI();
			CGEADHOLHCH("Reputation increased by ", EGFGNGJGBOP: false);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = false;
				DogNPC.instance.currentDogHole.EPIHGBKOPPH();
			}
			FAHMDMLHPPO = Time.time + 929f;
			EHIGJADHFGA(Sound.GGFJGHHHEJC.dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.JINJODIENIN(DogState.IdleNearPlayer);
		}
	}

	private void GHIIJGGKIEE(string GEGDHHIDEEF, bool CDPAMNIPPEC)
	{
		SetTrigger(GEGDHHIDEEF, HALNIEBONKH: true);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.IBIGIDLLOLP(GEGDHHIDEEF);
		}
	}

	private void KPCNGOJOBID()
	{
		if (!JEJPKGILEDB(" aging rank ("))
		{
			CGEADHOLHCH(" not found in OnlineEventsManager.", EGFGNGJGBOP: false, HALNIEBONKH: true);
			FAHMDMLHPPO += 777f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (GetBool("Dialogue System/Conversation/FailHaggle/Entry/1/Dialogue Text"))
			{
				SetBool("Selected", EGFGNGJGBOP: false);
				CGEADHOLHCH("itemChocolateWort", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1087f, FAHMDMLHPPO + 910f);
			}
			else if (GetBool("ReceiveFollow"))
			{
				CGEADHOLHCH("New FadeCamera added for player ", EGFGNGJGBOP: false);
				CGEADHOLHCH("Items/item_description_644", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 680f, FAHMDMLHPPO + 1642f);
			}
			else
			{
				CGEADHOLHCH("Current user name: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 45f, FAHMDMLHPPO + 296f);
			}
		}
	}

	private void GNIKJJBOAAO()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!JEJPKGILEDB("<sprite name=white_arrow_right> "))
			{
				CGEADHOLHCH("Random", EGFGNGJGBOP: false);
				CGEADHOLHCH("Bird", EGFGNGJGBOP: true);
				SetBool("ReceivePoolReset", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(622f, 714f);
			}
			else
			{
				SetBool("Items/item_description_644", EGFGNGJGBOP: true, HALNIEBONKH: true);
				CGEADHOLHCH("tutorialPopUp23", EGFGNGJGBOP: true);
				SetBool("Dialogue System/Conversation/CalmRowdyCustomer/Entry/1/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(1478f, 765f);
			}
		}
	}

	private void GEMDKNJEHOM()
	{
		if (!JEJPKGILEDB("0"))
		{
			CGEADHOLHCH("UIInteract", EGFGNGJGBOP: true);
			FAHMDMLHPPO = Time.time + Random.Range(1675f, 286f);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if ((Object)(object)IHGHFIBLFFG.playerFollowing != (Object)null)
			{
				IHGHFIBLFFG.CHFKPKDBIJL(DogState.FollowPlayer);
			}
			else
			{
				IHGHFIBLFFG.CHFKPKDBIJL((DogState)8);
			}
		}
	}

	private void Awake()
	{
		if ((Object)(object)onlineDog != (Object)null)
		{
			IHGHFIBLFFG = onlineDog.dogNpc;
		}
	}

	private void CGLPHNBBDKG()
	{
		if (!JEJPKGILEDB("SalonDelTrono/PuddingTalk"))
		{
			CGEADHOLHCH("LE_11", EGFGNGJGBOP: true, HALNIEBONKH: true);
			FAHMDMLHPPO = Time.time + 12f;
		}
	}

	public void LoveEmote()
	{
		loveEmote.SetActive(true);
	}

	private void KHDPPAHBMAE()
	{
		if (!JEJPKGILEDB("LE_21"))
		{
			SetBool("Items/item_name_1182", EGFGNGJGBOP: false, HALNIEBONKH: true);
			FAHMDMLHPPO = Time.time + 565f;
		}
	}

	private void MICCBGJENDA()
	{
		if (!GetBool("InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item "))
		{
			CAADCIHPACF();
			SetBool("Items/item_name_660", EGFGNGJGBOP: true, HALNIEBONKH: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = false;
				DogNPC.instance.currentDogHole.JMINJOBEKAH();
			}
			FAHMDMLHPPO = Time.time + 247f;
			MPONLOIFIMI(Sound.MAIDHAPANEB().dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
	}

	private void BCLKDEFPIEM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.LPGPJPPLHKG() == Season.Autumn && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(false);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(true);
		}
	}

	private void EHIGJADHFGA(AudioObject JPNIMEGNOCB)
	{
		if (JPNIMEGNOCB.loop)
		{
			if ((Object)(object)EINDLGPJLCP != (Object)null)
			{
				EINDLGPJLCP.Stop(true);
			}
			EINDLGPJLCP = MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
	}

	private void JKGGHCHHCFG(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP, HALNIEBONKH: true);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendSetBool(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	public void DogAnimations(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Friendly:
			HFJCALFKGJH();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Sleep:
			IDIGHPCFPDP();
			break;
		case DogNPC.DogInteractionType.Dig:
			DAPNLBKGDMH();
			break;
		case DogNPC.DogInteractionType.Drink:
			IGPPMFLEDPK();
			break;
		case DogNPC.DogInteractionType.Eat:
			NLFCNDDCGKC();
			break;
		case DogNPC.DogInteractionType.Toy:
			ICPICDHIHFN();
			break;
		case DogNPC.DogInteractionType.Smell:
			PHGMKECMGKH();
			break;
		case DogNPC.DogInteractionType.Scratch:
			MCNIFLFDJII();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.SendReproduceInteraction(NCMDEGABGCH);
		}
	}

	private void IJKHIPPEBDJ()
	{
		if (!JEJPKGILEDB("Open"))
		{
			JLJBAFOHFJK();
			CGEADHOLHCH("[MinePuzzleManager] Setting destructible objects for current puzzle. Count: {0} Current Puzzle = null? {1}", EGFGNGJGBOP: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = true;
				DogNPC.instance.currentDogHole.KONIKDLNBDH();
			}
			FAHMDMLHPPO = Time.time + 1789f;
			EHIGJADHFGA(Sound.OKAPNFPFPFP().dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.JINJODIENIN(DogState.IdleNearPlayer);
		}
	}

	private void IGPPMFLEDPK()
	{
		if (!GetBool("Drink"))
		{
			SetBool("Drink", EGFGNGJGBOP: true);
			FAHMDMLHPPO = Time.time + 2f;
			MPONLOIFIMI(Sound.GGFJGHHHEJC.dogDrinking);
		}
	}

	private void GOHHACBDFDO()
	{
		if (!GetBool("City/Kujaku/Bark/Buy"))
		{
			LNHFFJCAGNM();
			CGEADHOLHCH("City/Amos/Bark/Bye", EGFGNGJGBOP: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = false;
				DogNPC.instance.currentDogHole.DCMGFLOIPGL();
			}
			FAHMDMLHPPO = Time.time + 906f;
			EHIGJADHFGA(Sound.GGFJGHHHEJC.dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
	}

	private void FOLLIMBJNMK(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP, HALNIEBONKH: true);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendSetBool(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void ICBJPLEJPFH()
	{
		if (!GetBool("start ninja"))
		{
			JLJBAFOHFJK();
			SetBool("ops", EGFGNGJGBOP: true, HALNIEBONKH: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = true;
				DogNPC.instance.currentDogHole.FMFFIHMFLEP();
			}
			FAHMDMLHPPO = Time.time + 48f;
			OKHKJBOMFIN(Sound.GGFJGHHHEJC.dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.ChangeState(DogState.FollowPlayer);
		}
	}

	private void ICPICDHIHFN()
	{
		if (!GetBool("Toy"))
		{
			SetBool("Toy", EGFGNGJGBOP: true);
			FAHMDMLHPPO = Time.time + Random.Range(10f, 15f);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if ((Object)(object)IHGHFIBLFFG.playerFollowing != (Object)null)
			{
				IHGHFIBLFFG.ChangeState(DogState.FollowPlayer);
			}
			else
			{
				IHGHFIBLFFG.ChangeState(DogState.Idle);
			}
		}
	}

	private void JMGDLKJGMDL()
	{
		if (!JEJPKGILEDB("secret_token"))
		{
			LNHFFJCAGNM();
			SetBool("HarvestableDuringThreeMonths", EGFGNGJGBOP: false);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = false;
				DogNPC.instance.currentDogHole.HGGNJKIAOFI();
			}
			FAHMDMLHPPO = Time.time + 976f;
			EHIGJADHFGA(Sound.DIHCEGINELM().dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.CHFKPKDBIJL(DogState.FollowPlayer);
		}
	}

	private void CAADCIHPACF()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.LPGPJPPLHKG() == Season.Autumn && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(false);
		}
	}

	public void OINOLBJDIKF()
	{
		loveEmote.SetActive(false);
	}

	public void BCLAMKGEKIO(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(true);
			EINDLGPJLCP = null;
		}
		BPHJGBBIHLD("Could not find item with id: ", AODONKKHPBP: false, CDPAMNIPPEC: true);
		BPHJGBBIHLD("Dialogue System/Conversation/EnterTavernDrink/Entry/8/Dialogue Text", AODONKKHPBP: true, CDPAMNIPPEC: true);
		MNOLHIHHNCE("UISelectGamepad", AODONKKHPBP: true, CDPAMNIPPEC: true);
		DJAPIEALHAB("IdleCamp", AODONKKHPBP: false, CDPAMNIPPEC: false);
		DJAPIEALHAB("hForHours", AODONKKHPBP: true, CDPAMNIPPEC: true);
		NLACAJGHGJL("Dialogue System/Conversation/UnhappyRentRoom/Entry/2/Dialogue Text", AODONKKHPBP: false, CDPAMNIPPEC: true);
		FAPMGINDKEE("NewClothing", AODONKKHPBP: true, CDPAMNIPPEC: true);
		FOLLIMBJNMK("Direction", AODONKKHPBP: true, CDPAMNIPPEC: false);
		FAPMGINDKEE("ReceiveAdoptionRequest", AODONKKHPBP: false, CDPAMNIPPEC: false);
		MNOLHIHHNCE("positions count is 0", AODONKKHPBP: true, CDPAMNIPPEC: true);
		IHGHFIBLFFG.dirt.SetActive(false);
		IHGHFIBLFFG.snow.SetActive(true);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.EKELDLDEKML();
		}
		JIFFOKNLHHD = 1;
		IMCFMGGOCHP = 0;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.KCJCBKABIJK();
		}
	}

	public bool KNLNNOGPDGB()
	{
		return JEJPKGILEDB("SurpriseJump");
	}

	public void PPOICOJBOCI(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(true);
			EINDLGPJLCP = null;
		}
		AJIMCICANFO("Win", AODONKKHPBP: true, CDPAMNIPPEC: true);
		BPHJGBBIHLD("LE_15", AODONKKHPBP: true, CDPAMNIPPEC: false);
		MNOLHIHHNCE("itemIronIngot", AODONKKHPBP: true, CDPAMNIPPEC: false);
		NLACAJGHGJL("NULL", AODONKKHPBP: false, CDPAMNIPPEC: false);
		AJIMCICANFO("Player2", AODONKKHPBP: true, CDPAMNIPPEC: true);
		LEFHICGPEPH("Error ", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Player/Bark/Error/NotAllPlayersHere", AODONKKHPBP: true, CDPAMNIPPEC: true);
		AJIMCICANFO("F1", AODONKKHPBP: false, CDPAMNIPPEC: true);
		OCGKMIIPJJF(" ", AODONKKHPBP: false, CDPAMNIPPEC: true);
		OCGKMIIPJJF("InteractPlaceableIfIsPossibleMaster", AODONKKHPBP: false, CDPAMNIPPEC: true);
		IHGHFIBLFFG.dirt.SetActive(true);
		IHGHFIBLFFG.snow.SetActive(true);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.BIGIBDEHIMI();
		}
		JIFFOKNLHHD = 1;
		IMCFMGGOCHP = 1;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.APGAMHEPMOJ();
		}
	}

	public bool PHLPJBCEODO()
	{
		return JEJPKGILEDB("Cannot receive interact ");
	}

	public void NJEMNCKPLPN(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Friendly:
			HNAHEIGNJAJ();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			LENFJBDHAJG();
			break;
		case DogNPC.DogInteractionType.Sleep:
			GEBOOAAJNCK();
			break;
		case DogNPC.DogInteractionType.Dig:
			GOHHACBDFDO();
			break;
		case DogNPC.DogInteractionType.Drink:
			JIPIGHKCNIL();
			break;
		case DogNPC.DogInteractionType.Eat:
			NHCOGJAHIAA();
			break;
		case DogNPC.DogInteractionType.Toy:
			GEMDKNJEHOM();
			break;
		case DogNPC.DogInteractionType.Smell:
			GCBMJEIFNED();
			break;
		case DogNPC.DogInteractionType.Scratch:
			HCMLANJLCBN();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.SendReproduceInteraction(NCMDEGABGCH);
		}
	}

	private void MALJABEHPFO()
	{
		if (!GetBool("Room "))
		{
			CGEADHOLHCH("", EGFGNGJGBOP: false, HALNIEBONKH: true);
			FAHMDMLHPPO += 800f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (GetBool("\n"))
			{
				CGEADHOLHCH("", EGFGNGJGBOP: true);
				SetBool("questDescPorridge", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1036f, FAHMDMLHPPO + 233f);
			}
			else if (GetBool("FishCaughtRPC"))
			{
				SetBool("MineState", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("Get Components ", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1997f, FAHMDMLHPPO + 1873f);
			}
			else
			{
				CGEADHOLHCH("QuestInfoButton", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1135f, FAHMDMLHPPO + 223f);
			}
		}
	}

	public bool PMJAACAJDJG()
	{
		return JEJPKGILEDB("City/Petra/Bark/Stand");
	}

	private void HNAHEIGNJAJ()
	{
		if (!GetBool("NormalLeftExterior"))
		{
			SetBool("Shifty Customer", EGFGNGJGBOP: false, HALNIEBONKH: true);
			FAHMDMLHPPO += 1861f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (JEJPKGILEDB("LE_10"))
			{
				SetBool("Items/item_name_647", EGFGNGJGBOP: false);
				CGEADHOLHCH("LE_18", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 956f, FAHMDMLHPPO + 960f);
			}
			else if (GetBool("UISelectGamepad"))
			{
				SetBool("ReceiveDialogueStart", EGFGNGJGBOP: false, HALNIEBONKH: true);
				SetBool("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1093f, FAHMDMLHPPO + 507f);
			}
			else
			{
				CGEADHOLHCH("itemPumpkinSeeds", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1339f, FAHMDMLHPPO + 1420f);
			}
		}
	}

	public void KOJAPAMICLJ()
	{
		loveEmote.SetActive(false);
	}

	private void HPJBLOPJIMI()
	{
		if ((Object)(object)onlineDog != (Object)null)
		{
			IHGHFIBLFFG = onlineDog.dogNpc;
		}
	}

	private void FACNDBBKEKL()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!JEJPKGILEDB("Attack/MainEvent 6"))
			{
				SetBool("Disabled", EGFGNGJGBOP: true, HALNIEBONKH: true);
				CGEADHOLHCH(" already exists for ", EGFGNGJGBOP: true);
				SetBool("PreviousItem", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(221f, 679f);
			}
			else
			{
				SetBool("GroundCliffs", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("itemLager", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("Items/item_name_1055", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(406f, 954f);
			}
		}
	}

	private void DMGENAOPNIG(string GEGDHHIDEEF, bool CDPAMNIPPEC)
	{
		SetTrigger(GEGDHHIDEEF);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendSetTrigger(GEGDHHIDEEF);
		}
	}

	private void DOPHHIMCEEE()
	{
		if (!GetBool("No empty bucket"))
		{
			CGEADHOLHCH("Dialogue System/Conversation/Crowly_Standar/Entry/44/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
			FAHMDMLHPPO = Time.time + 645f;
		}
	}

	private void FAPMGINDKEE(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			SetBool(GEGDHHIDEEF, AODONKKHPBP, HALNIEBONKH: true);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.LBBCANANBGI(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void HFJCALFKGJH()
	{
		if (!GetBool("Sit"))
		{
			SetBool("Sit", EGFGNGJGBOP: true);
			FAHMDMLHPPO += 2f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (GetBool("Tail"))
			{
				SetBool("Tail", EGFGNGJGBOP: false);
				SetBool("Happy", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 2f, FAHMDMLHPPO + 5f);
			}
			else if (GetBool("Happy"))
			{
				SetBool("Tail", EGFGNGJGBOP: true);
				SetBool("Happy", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 2f, FAHMDMLHPPO + 5f);
			}
			else
			{
				SetBool("Happy", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 2f, FAHMDMLHPPO + 5f);
			}
		}
	}

	private void BOBFNBLEKDJ()
	{
		if (!GetBool("MineState"))
		{
			SetBool("FerroProgress", EGFGNGJGBOP: true);
			FAHMDMLHPPO = Time.time + Random.Range(185f, 1220f);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if ((Object)(object)IHGHFIBLFFG.playerFollowing != (Object)null)
			{
				IHGHFIBLFFG.ChangeState(DogState.FollowPlayer);
			}
			else
			{
				IHGHFIBLFFG.GNCLBACINCA((DogState)8);
			}
		}
	}

	private void NLACAJGHGJL(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.JDDODODGDKL(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void MOPHCIODLOF()
	{
		if (!JEJPKGILEDB(" tried to do seat found being in state "))
		{
			CGEADHOLHCH("Received PlaceableMsg of another type not BirdMessage to ", EGFGNGJGBOP: false, HALNIEBONKH: true);
			FAHMDMLHPPO += 1127f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (GetBool("HenHouseTutorialDone"))
			{
				CGEADHOLHCH("F2", EGFGNGJGBOP: false, HALNIEBONKH: true);
				SetBool("ReceiveBanquetCustomerState", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 493f, FAHMDMLHPPO + 1638f);
			}
			else if (GetBool("<b><color=#FDEA5C>Info                              </color></b>\n>   Shows all the codes.\n<b><color=#FDEA5C>Increase XP                       </color></b>\n>   Increases the XP.\n<b><color=#FDEA5C>World Time ##                     </color></b>\n>   Changes the world time multiplier (needs a number).\n<b><color=#FDEA5C>Time ##                           </color></b>\n>   Modifies the game's time scale.\n<b><color=#FDEA5C>Change Season                     </color></b>\n>   Changes the season.\n<b><color=#FDEA5C>Grow all plants                   </color></b>\n>   It makes all plants grow.\n<b><color=#FDEA5C>STEAM Status                      </color></b>\n>   Steam login status.\n<b><color=#FDEA5C>Add all resolutions               </color></b>\n>   It adds all screen resolutions in order to test it.\n<b><color=#FDEA5C>Increase money ##                 </color></b>\n>   Increases gold (needs a number).\n<b><color=#FDEA5C>Increase reputation ###           </color></b>\n>   Increases the reputation (needs a number).\n<b><color=#FDEA5C>Decrease reputation               </color></b>\n>   Decreases the reputation.\n<b><color=#FDEA5C>Show Popup ###                    </color></b>\n>   Shows a tutorial popup.\n<b><color=#FDEA5C>Road                              </color></b>\n>   Teleports the player outside the tavern.\n<b><color=#FDEA5C>River                             </color></b>\n>   Teleports the player to the river.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the campament.\n<b><color=#FDEA5C>Unlock recipe #                   </color></b>\n>   Unlock a recipe (needs a number)\n<b><color=#FDEA5C>Unlock all recipes                </color></b>\n>   Unlock all recipes\n<b><color=#FDEA5C>Add quest #                       </color></b>\n>   Add specific quest to active quest (needs a number).\n<b><color=#FDEA5C>Add materials #                   </color></b>\n>   Add materials.\n<b><color=#FDEA5C>Complete quest #                  </color></b>\n>   Complete specific active quest (needs a number).\n<b><color=#FDEA5C>Hour #                            </color></b>\n>   Specify the hour you want to be.\n<b><color=#FDEA5C>Night                             </color></b>\n>   Set the hour to 19:00h automatically.\n<b><color=#FDEA5C>Bed                               </color></b>\n>   Teleports the player to the bedroom.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the Camp.\n<b><color=#FDEA5C>Generate forest                   </color></b>\n>   Generate new herbs and trees.\n<b><color=#FDEA5C>Tilled Earth                      </color></b>\n>   Convert all terrain to tilled earth.\n<b><color=#FDEA5C>Seeds                             </color></b>\n>   Give all seeds.\n<b><color=#FDEA5C>Talents                           </color></b>\n>   Unlocks all talents.\n<b><color=#FDEA5C>Dirty Info                        </color></b>\n>   Floor Dirt information.\n<b><color=#FDEA5C>Check Keybinds                    </color></b>\n>   Check the modified keybinds.\n<b><color=#FDEA5C>Debug service                     </color></b>\n>   Debug service of customers.\n<b><color=#FDEA5C>On player sleep                   </color></b>\n>   On player sleep function.\n<b><color=#FDEA5C>Fog                               </color></b>\n>   Enable and disable fog.\n<b><color=#FDEA5C>Controllers                       </color></b>\n>   Show controllers connected.\n<b><color=#FDEA5C>Connect                           </color></b>\n>   Connect to debug Photon room.\n<b><color=#FDEA5C>Disconnect                        </color></b>\n>   Disconnect form debug Photon room.\n<b><color=#FDEA5C>snow, rain, rain cloudy, rain stormy, sunny, sunny clouds, stormy clouds, cloudy, windy</color></b>\n>   Shows weather.\n<b><color=#FDEA5C>stop weather                      </color></b>\n>   Removes all current weather effects.\n<b><color=#FDEA5C>fill fish collection              </color></b>\n>   Add records for all not found fish in collection.\n<b><color=#FDEA5C>fish collection clues             </color></b>\n>   Adds clues for all not found fish in collection.\n<b><color=#FDEA5C>recipe fragments #                </color></b>\n>   Adds # recipe fragments for recipe exchange\n<b><color=#FDEA5C>ShowUI                            </color></b>\n>   Show Gameplay UI\n<b><color=#FDEA5C>HideUI                            </color></b>\n>   Hide Gameplay UI\n<b><color=#FDEA5C>Intro                             </color></b>\n>   Triggers the scroll intro\n<b><color=#FDEA5C>Tutorial                          </color></b>\n>   Triggers the new tutorial\n<b><color=#FDEA5C>Target fps ###                    </color></b>\n>   Sets a frame rate limit.\n<b><color=#FDEA5C>Tutorial phase ###                </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>onlinecode #####                  </color></b>\n>   Sets the private room code for online play as if received from a steam invite.\n<b><color=#FDEA5C>Force intro                       </color></b>\n>   Triggers the intro when starts a new game in the editor.\n<b><color=#FDEA5C>Dog #BreedID# #RelationshipLVL#   </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>banquetevent                      </color></b>\n>   Starts Banquet Event. If is already active stops the event.\n"))
			{
				SetBool("SignIn failed for reason ", EGFGNGJGBOP: true);
				CGEADHOLHCH("Player", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 993f, FAHMDMLHPPO + 1845f);
			}
			else
			{
				CGEADHOLHCH("popUpBuilding2B", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 188f, FAHMDMLHPPO + 1140f);
			}
		}
	}

	public void DGIGKJJFKGM(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(true);
			EINDLGPJLCP = null;
		}
		BPHJGBBIHLD("Received RPC SetInteger {0} with value {1} on {2}. Setting animator parameter.", AODONKKHPBP: false, CDPAMNIPPEC: false);
		AJIMCICANFO("CookiesNeeded", AODONKKHPBP: true, CDPAMNIPPEC: true);
		NLACAJGHGJL("No prefab found for mineral: ", AODONKKHPBP: true, CDPAMNIPPEC: true);
		DJAPIEALHAB("Festín del Juramento/ComensalesBarks", AODONKKHPBP: false, CDPAMNIPPEC: true);
		AJIMCICANFO("Scene ", AODONKKHPBP: true, CDPAMNIPPEC: false);
		OCGKMIIPJJF(":<color=#3a0603> +", AODONKKHPBP: true, CDPAMNIPPEC: true);
		FAPMGINDKEE(")", AODONKKHPBP: true, CDPAMNIPPEC: false);
		NLACAJGHGJL("Get Components ", AODONKKHPBP: true, CDPAMNIPPEC: false);
		DJAPIEALHAB("Focused", AODONKKHPBP: false, CDPAMNIPPEC: true);
		FOLLIMBJNMK("ChristmasPostcard", AODONKKHPBP: false, CDPAMNIPPEC: false);
		IHGHFIBLFFG.dirt.SetActive(false);
		IHGHFIBLFFG.snow.SetActive(true);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.NNOEMCCLFGD();
		}
		JIFFOKNLHHD = 0;
		IMCFMGGOCHP = 0;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.BPPPNHHBGON();
		}
	}

	public void LNDKIEJFIIJ(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.None:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Bark:
			HNAHEIGNJAJ();
			break;
		case DogNPC.DogInteractionType.Friendly:
			LENFJBDHAJG();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			NALAAOKHEFD();
			break;
		case DogNPC.DogInteractionType.Sleep:
			DAPNLBKGDMH();
			break;
		case DogNPC.DogInteractionType.Dig:
			KNHIBCINPOP();
			break;
		case DogNPC.DogInteractionType.Drink:
			NLFCNDDCGKC();
			break;
		case DogNPC.DogInteractionType.Eat:
			GEMDKNJEHOM();
			break;
		case DogNPC.DogInteractionType.Toy:
			OAFFGJOOOLA();
			break;
		case DogNPC.DogInteractionType.Smell:
			HCMLANJLCBN();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.COEOOHGKCFB(NCMDEGABGCH);
		}
	}

	private void BAMOMIFONDD()
	{
		if (!JEJPKGILEDB("Crowly_RaraAvis"))
		{
			CGEADHOLHCH("Items/item_name_1085", EGFGNGJGBOP: true);
			FAHMDMLHPPO += 560f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (JEJPKGILEDB("BLOCKS NUMBER: {0} Puzzle Needit: {1}"))
			{
				SetBool("Player2", EGFGNGJGBOP: true);
				SetBool("Moving", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 408f, FAHMDMLHPPO + 1191f);
			}
			else if (JEJPKGILEDB("Player"))
			{
				SetBool("Load Player 2 appearance", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("DecorationTile_23", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1619f, FAHMDMLHPPO + 1122f);
			}
			else
			{
				SetBool("cameraZoom2", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 394f, FAHMDMLHPPO + 486f);
			}
		}
	}

	private void NLFCNDDCGKC()
	{
		if (!GetBool("Eat"))
		{
			SetBool("Eat", EGFGNGJGBOP: true);
			FAHMDMLHPPO = Time.time + 2f;
		}
	}

	private void BPHJGBBIHLD(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (GetBool(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.JDDODODGDKL(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void OCGKMIIPJJF(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (GetBool(GEGDHHIDEEF) != AODONKKHPBP)
		{
			SetBool(GEGDHHIDEEF, AODONKKHPBP);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendSetBool(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void GFFBKFNAFMI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.PJMGHIMKFJL() == (Season)6 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(false);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(false);
		}
	}

	private void LENFJBDHAJG()
	{
		if (JIFFOKNLHHD == 0)
		{
			JIFFOKNLHHD = Random.Range(8, 1);
			IMCFMGGOCHP = 0;
			FAHMDMLHPPO = Time.time;
		}
		if (Time.time >= FAHMDMLHPPO)
		{
			FAHMDMLHPPO = Time.time + Random.Range(1751f, 355f);
			IMPPDNHJDLN("Clear", CDPAMNIPPEC: false);
			IMCFMGGOCHP++;
			MPONLOIFIMI(Sound.OKAPNFPFPFP().dogBark);
			if (IMCFMGGOCHP >= JIFFOKNLHHD)
			{
				JIFFOKNLHHD = (JIFFOKNLHHD = Random.Range(7, 6));
				FAHMDMLHPPO = Time.time + Random.Range(1684f, 658f);
			}
		}
	}

	private void GGJIELNHDMC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.LPGPJPPLHKG() == (Season)6 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(true);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
	}

	private void LEFHICGPEPH(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendSetBool(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void GCBMJEIFNED()
	{
		if (!GetBool("SegmentListScrollView"))
		{
			SetBool(" x ", EGFGNGJGBOP: true);
		}
	}

	public void NJMKFHGPBEG(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			BBNCEDICPAM();
			break;
		case DogNPC.DogInteractionType.Friendly:
			MBEDHMPMIMH();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			BBNCEDICPAM();
			break;
		case DogNPC.DogInteractionType.Sleep:
			NALAAOKHEFD();
			break;
		case DogNPC.DogInteractionType.Dig:
			IJKHIPPEBDJ();
			break;
		case DogNPC.DogInteractionType.Drink:
			IGPPMFLEDPK();
			break;
		case DogNPC.DogInteractionType.Eat:
			NHCOGJAHIAA();
			break;
		case DogNPC.DogInteractionType.Toy:
			BOBFNBLEKDJ();
			break;
		case DogNPC.DogInteractionType.Smell:
			DDMHMOJONLG();
			break;
		case DogNPC.DogInteractionType.Scratch:
			GNIKJJBOAAO();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.SendReproduceInteraction(NCMDEGABGCH);
		}
	}

	private void PNEAAPODDJH()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!GetBool("talent_name_109"))
			{
				SetBool("CookiesNeeded", EGFGNGJGBOP: true);
				SetBool("Animator is null or has been destroyed.", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("current Theme playing", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(68f, 1856f);
			}
			else
			{
				SetBool("quarry", EGFGNGJGBOP: true);
				CGEADHOLHCH("TucanEgg", EGFGNGJGBOP: true);
				SetBool("KyrohPreparingFood: Other player has advantage, going to WaitingToServe.", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Time.time + Random.Range(1525f, 1266f);
			}
		}
	}

	public void ExitInteraction(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(false);
			EINDLGPJLCP = null;
		}
		OCGKMIIPJJF("Sit", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Tail", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Happy", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Sleep", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Dig", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Drink", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Eat", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Toy", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Smell", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Scratch", AODONKKHPBP: false, CDPAMNIPPEC: false);
		IHGHFIBLFFG.dirt.SetActive(false);
		IHGHFIBLFFG.snow.SetActive(false);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.MarkInteracted();
		}
		JIFFOKNLHHD = 0;
		IMCFMGGOCHP = 0;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendExitInteraction();
		}
	}

	private void MBEDHMPMIMH()
	{
		if (!GetBool("OpenTalents"))
		{
			CGEADHOLHCH("ReceiveLoadSlots", EGFGNGJGBOP: false);
			FAHMDMLHPPO += 975f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (JEJPKGILEDB("Use"))
			{
				CGEADHOLHCH("UIAddRemove", EGFGNGJGBOP: false, HALNIEBONKH: true);
				CGEADHOLHCH("rain", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 831f, FAHMDMLHPPO + 1391f);
			}
			else if (GetBool("Dialogue System/Conversation/Gass_Quest/Entry/44/Dialogue Text"))
			{
				CGEADHOLHCH("mForMins", EGFGNGJGBOP: false);
				SetBool("FishCuttingEvent/Talk2", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1934f, FAHMDMLHPPO + 48f);
			}
			else
			{
				SetBool("Items/item_name_1053", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1546f, FAHMDMLHPPO + 629f);
			}
		}
	}

	private void DPHILMNKFIA()
	{
		if (JIFFOKNLHHD == 0)
		{
			JIFFOKNLHHD = Random.Range(3, 5);
			IMCFMGGOCHP = 0;
			FAHMDMLHPPO = Time.time;
		}
		if (Time.time >= FAHMDMLHPPO)
		{
			FAHMDMLHPPO = Time.time + Random.Range(0.3f, 0.7f);
			NOIJLGNPBEG("Bark", CDPAMNIPPEC: true);
			IMCFMGGOCHP++;
			MPONLOIFIMI(Sound.GGFJGHHHEJC.dogBark);
			if (IMCFMGGOCHP >= JIFFOKNLHHD)
			{
				JIFFOKNLHHD = (JIFFOKNLHHD = Random.Range(3, 5));
				FAHMDMLHPPO = Time.time + Random.Range(1f, 2f);
			}
		}
	}

	private void EPAIJJMCAOJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.NHKAHEEGEGF() == Season.Spring && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(false);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(false);
		}
	}

	public void GDCFJNFPMGE(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(true);
			EINDLGPJLCP = null;
		}
		JKGGHCHHCFG("SalonDelTrono/RibellaTalk", AODONKKHPBP: false, CDPAMNIPPEC: false);
		FOLLIMBJNMK("No path to psai soundtrack file set!", AODONKKHPBP: true, CDPAMNIPPEC: false);
		OCGKMIIPJJF("...Failed", AODONKKHPBP: true, CDPAMNIPPEC: false);
		LEFHICGPEPH("<color=#B50000>", AODONKKHPBP: false, CDPAMNIPPEC: true);
		FOLLIMBJNMK("ReceiveUpdateFoodStats", AODONKKHPBP: true, CDPAMNIPPEC: false);
		AJIMCICANFO("Dog", AODONKKHPBP: true, CDPAMNIPPEC: false);
		AJIMCICANFO("DecorationTile_4", AODONKKHPBP: true, CDPAMNIPPEC: false);
		FAPMGINDKEE("LearnMettle", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Items/item_name_1061", AODONKKHPBP: false, CDPAMNIPPEC: false);
		AJIMCICANFO("Items/item_description_1049", AODONKKHPBP: true, CDPAMNIPPEC: false);
		IHGHFIBLFFG.dirt.SetActive(false);
		IHGHFIBLFFG.snow.SetActive(false);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.MOLNIAEDFAA();
		}
		JIFFOKNLHHD = 0;
		IMCFMGGOCHP = 1;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.IBGFJMLEIGI();
		}
	}

	private void DJAPIEALHAB(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (GetBool(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.JDDODODGDKL(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void OINIJMHKJJJ()
	{
		if (JIFFOKNLHHD == 0)
		{
			JIFFOKNLHHD = Random.Range(2, 4);
			IMCFMGGOCHP = 0;
			FAHMDMLHPPO = Time.time;
		}
		if (Time.time >= FAHMDMLHPPO)
		{
			FAHMDMLHPPO = Time.time + Random.Range(1993f, 343f);
			DMGENAOPNIG("Trying to create room...", CDPAMNIPPEC: false);
			IMCFMGGOCHP += 0;
			EBIDAMBGALD(Sound.DIHCEGINELM().dogBark);
			if (IMCFMGGOCHP >= JIFFOKNLHHD)
			{
				JIFFOKNLHHD = (JIFFOKNLHHD = Random.Range(2, 1));
				FAHMDMLHPPO = Time.time + Random.Range(620f, 158f);
			}
		}
	}

	private void MIKNFPCDLML()
	{
		if ((Object)(object)onlineDog != (Object)null)
		{
			IHGHFIBLFFG = onlineDog.dogNpc;
		}
	}

	public bool IALCNPJMONC()
	{
		return GetBool(" - ");
	}

	public bool HOCOPLNENJJ()
	{
		return JEJPKGILEDB(" bedAssigned: ");
	}

	public void CKEDDNGKMMK(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			BBNCEDICPAM();
			break;
		case DogNPC.DogInteractionType.Friendly:
			KPCNGOJOBID();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			OINIJMHKJJJ();
			break;
		case DogNPC.DogInteractionType.Sleep:
			KCAJCOBIJEH();
			break;
		case DogNPC.DogInteractionType.Dig:
			IJKHIPPEBDJ();
			break;
		case DogNPC.DogInteractionType.Drink:
			JIPIGHKCNIL();
			break;
		case DogNPC.DogInteractionType.Eat:
			DOPHHIMCEEE();
			break;
		case DogNPC.DogInteractionType.Toy:
			ICPICDHIHFN();
			break;
		case DogNPC.DogInteractionType.Smell:
			JFBIMMGIJIP();
			break;
		case DogNPC.DogInteractionType.Scratch:
			HCMLANJLCBN();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.SendReproduceInteraction(NCMDEGABGCH);
		}
	}

	private void JLJBAFOHFJK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EECEKHKAAIH == Season.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(true);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(false);
		}
	}

	private void NHCOGJAHIAA()
	{
		if (!JEJPKGILEDB("Items/item_description_695"))
		{
			CGEADHOLHCH("LE_21", EGFGNGJGBOP: false);
			FAHMDMLHPPO = Time.time + 1882f;
		}
	}

	public void GIPAJJKDEJK(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(true);
			EINDLGPJLCP = null;
		}
		BPHJGBBIHLD("Smell", AODONKKHPBP: false, CDPAMNIPPEC: false);
		LEFHICGPEPH("/", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("ReceiveDogPosition", AODONKKHPBP: false, CDPAMNIPPEC: true);
		MNOLHIHHNCE("tutorialPopUp80", AODONKKHPBP: false, CDPAMNIPPEC: false);
		DJAPIEALHAB("Error_MaxZones", AODONKKHPBP: true, CDPAMNIPPEC: false);
		BPHJGBBIHLD("\n", AODONKKHPBP: false, CDPAMNIPPEC: false);
		MNOLHIHHNCE("City/Amos/Bark/Buy", AODONKKHPBP: true, CDPAMNIPPEC: false);
		MNOLHIHHNCE("Not enough experience!", AODONKKHPBP: true, CDPAMNIPPEC: true);
		OCGKMIIPJJF("Random", AODONKKHPBP: false, CDPAMNIPPEC: false);
		NLACAJGHGJL("Dialogue System/Conversation/NeutralInTavern/Entry/15/Dialogue Text", AODONKKHPBP: true, CDPAMNIPPEC: false);
		IHGHFIBLFFG.dirt.SetActive(true);
		IHGHFIBLFFG.snow.SetActive(true);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.PGGFIBLDPBP();
		}
		JIFFOKNLHHD = 0;
		IMCFMGGOCHP = 0;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendExitInteraction();
		}
	}

	public void BJGOFPBMCME(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(false);
			EINDLGPJLCP = null;
		}
		AJIMCICANFO("Mai", AODONKKHPBP: true, CDPAMNIPPEC: true);
		DJAPIEALHAB("Up", AODONKKHPBP: false, CDPAMNIPPEC: true);
		OCGKMIIPJJF("Moving", AODONKKHPBP: false, CDPAMNIPPEC: false);
		DJAPIEALHAB("Tutorial/T107/Dialogue1", AODONKKHPBP: false, CDPAMNIPPEC: false);
		FOLLIMBJNMK("Exit build mode", AODONKKHPBP: false, CDPAMNIPPEC: true);
		AJIMCICANFO("UIPreviousCategory", AODONKKHPBP: true, CDPAMNIPPEC: true);
		LEFHICGPEPH("OnLobbyEnter \nLobby: {0}", AODONKKHPBP: true, CDPAMNIPPEC: false);
		LEFHICGPEPH("Dialogue System/Conversation/TavernFilthy/Entry/3/Dialogue Text", AODONKKHPBP: true, CDPAMNIPPEC: true);
		LEFHICGPEPH("Dig", AODONKKHPBP: true, CDPAMNIPPEC: true);
		OCGKMIIPJJF("BirdCatInteraction", AODONKKHPBP: false, CDPAMNIPPEC: true);
		IHGHFIBLFFG.dirt.SetActive(true);
		IHGHFIBLFFG.snow.SetActive(true);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.PGGFIBLDPBP();
		}
		JIFFOKNLHHD = 0;
		IMCFMGGOCHP = 1;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.LOIKFNGGBGN();
		}
	}

	private void FBJCDCOBFLD()
	{
		if (!GetBool(")"))
		{
			CGEADHOLHCH("Open", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	private void GNHMABDFPHM()
	{
		if (!JEJPKGILEDB(""))
		{
			CGEADHOLHCH("Room Upgraded ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	public bool DogIsDigging()
	{
		return GetBool("Dig");
	}

	private void CFCNOKLGBAE()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!GetBool("AcceptRoomSecondFloor"))
			{
				CGEADHOLHCH("NO SE HA PODIDO GENERAR EL PUZZLE - ERROR!!", EGFGNGJGBOP: false, HALNIEBONKH: true);
				CGEADHOLHCH(" door: ", EGFGNGJGBOP: false);
				CGEADHOLHCH(" (", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(52f, 1709f);
			}
			else
			{
				SetBool("Interact", EGFGNGJGBOP: true);
				SetBool("<br/>Processor Frequency: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("</color>", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Time.time + Random.Range(975f, 780f);
			}
		}
	}

	private void MFGANCCJFJK()
	{
		if ((Object)(object)onlineDog != (Object)null)
		{
			IHGHFIBLFFG = onlineDog.dogNpc;
		}
	}

	private void KCAJCOBIJEH()
	{
		if (!JEJPKGILEDB("[Awning] OnTriggerSet called. Hash: {0} | OpenHash: {1} | CloseHash: {2}"))
		{
			SetBool("Letter without ID: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	public void ACEPKGEJHDO(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.None:
			OINIJMHKJJJ();
			break;
		case DogNPC.DogInteractionType.Bark:
			HNAHEIGNJAJ();
			break;
		case DogNPC.DogInteractionType.Friendly:
			BBNCEDICPAM();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			GNHMABDFPHM();
			break;
		case DogNPC.DogInteractionType.Sleep:
			MICCBGJENDA();
			break;
		case DogNPC.DogInteractionType.Dig:
			IGPPMFLEDPK();
			break;
		case DogNPC.DogInteractionType.Drink:
			CGLPHNBBDKG();
			break;
		case DogNPC.DogInteractionType.Eat:
			BOBFNBLEKDJ();
			break;
		case DogNPC.DogInteractionType.Toy:
			DDMHMOJONLG();
			break;
		case DogNPC.DogInteractionType.Smell:
			CFCNOKLGBAE();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.COEOOHGKCFB(NCMDEGABGCH);
		}
	}

	private void DPOHEFNJFKK()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1083f)
		{
			if (FCGBJEIIMBC != Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC))
			{
				if (AAMNCMMDJLM > 0)
				{
					FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
					AAMNCMMDJLM = 1;
				}
				else
				{
					AAMNCMMDJLM += 0;
				}
			}
			else
			{
				AAMNCMMDJLM = 1;
			}
			if (!base.CNKHDCIKHCO)
			{
				NLACAJGHGJL("Items/item_name_1076", AODONKKHPBP: true, CDPAMNIPPEC: true);
				base.CNKHDCIKHCO = true;
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
				{
					onlineDog.LBBCANANBGI(":</color> ", AODONKKHPBP: true);
				}
			}
			if (!MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed == onlineDog.dogNpc.runSpeed)
			{
				BPHJGBBIHLD("Turkey", AODONKKHPBP: false, CDPAMNIPPEC: true);
				MHEOAHLBGHC = false;
			}
			else if (MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed != onlineDog.dogNpc.runSpeed)
			{
				JKGGHCHHCFG("Cancel", AODONKKHPBP: false, CDPAMNIPPEC: true);
				MHEOAHLBGHC = true;
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			FOLLIMBJNMK("%>", AODONKKHPBP: false, CDPAMNIPPEC: true);
			base.CNKHDCIKHCO = false;
			LEFHICGPEPH("/Localisation.txt", AODONKKHPBP: false, CDPAMNIPPEC: true);
			MHEOAHLBGHC = true;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
			{
				onlineDog.LBBCANANBGI("OnGameRichPresenceJoinRequested \nFriend ID: ", AODONKKHPBP: false);
			}
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PHGMKECMGKH()
	{
		if (!GetBool("Smell"))
		{
			SetBool("Smell", EGFGNGJGBOP: true);
		}
	}

	private void DDMHMOJONLG()
	{
		if (!GetBool(" de la pieza "))
		{
			CGEADHOLHCH("LE_10", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private void KOPPOHEGMHL()
	{
		if (!GetBool("Value null of key: "))
		{
			JLJBAFOHFJK();
			SetBool("ReceiveNinjaSoundPreparation", EGFGNGJGBOP: false, HALNIEBONKH: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = true;
				DogNPC.instance.currentDogHole.BMIFCKGEFAI();
			}
			FAHMDMLHPPO = Time.time + 580f;
			EBIDAMBGALD(Sound.BNBMNOMFFBE().dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.CHFKPKDBIJL(DogState.FollowPlayer);
		}
	}

	private void BHLMKLBFPKN()
	{
		if (!GetBool("dForDays"))
		{
			SetBool("Blocking collider not atttached to ", EGFGNGJGBOP: false);
		}
	}

	public void JOECEIFKHAJ(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(false);
			EINDLGPJLCP = null;
		}
		FAPMGINDKEE("Dialogue System/Conversation/BirdNegativeComments/Entry/14/Dialogue Text", AODONKKHPBP: true, CDPAMNIPPEC: true);
		OCGKMIIPJJF("popUpBuilding7", AODONKKHPBP: true, CDPAMNIPPEC: false);
		NLACAJGHGJL("Items/item_name_616", AODONKKHPBP: false, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Skin", AODONKKHPBP: false, CDPAMNIPPEC: true);
		MNOLHIHHNCE("Open", AODONKKHPBP: false, CDPAMNIPPEC: true);
		OCGKMIIPJJF("Moving", AODONKKHPBP: true, CDPAMNIPPEC: false);
		NLACAJGHGJL("Player/Bark/ShovelHole", AODONKKHPBP: true, CDPAMNIPPEC: true);
		FOLLIMBJNMK("Cat", AODONKKHPBP: false, CDPAMNIPPEC: false);
		MNOLHIHHNCE("Disabled", AODONKKHPBP: true, CDPAMNIPPEC: true);
		FOLLIMBJNMK("00", AODONKKHPBP: false, CDPAMNIPPEC: true);
		IHGHFIBLFFG.dirt.SetActive(false);
		IHGHFIBLFFG.snow.SetActive(true);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.GMLEEEOKJJJ();
		}
		JIFFOKNLHHD = 1;
		IMCFMGGOCHP = 1;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.IBGFJMLEIGI();
		}
	}

	private void KIOEIFOPMEL()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!JEJPKGILEDB(")"))
			{
				SetBool("Scratch", EGFGNGJGBOP: false);
				SetBool("ActionBar7", EGFGNGJGBOP: false);
				CGEADHOLHCH("Items/item_description_649", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Time.time + Random.Range(1427f, 608f);
			}
			else
			{
				CGEADHOLHCH("Exit", EGFGNGJGBOP: false);
				SetBool("AceT_Quest", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("MothersRecipe/MainEvent", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Time.time + Random.Range(787f, 1751f);
			}
		}
	}

	private void MPONLOIFIMI(AudioObject JPNIMEGNOCB)
	{
		if (JPNIMEGNOCB.loop)
		{
			if ((Object)(object)EINDLGPJLCP != (Object)null)
			{
				EINDLGPJLCP.Stop(false);
			}
			EINDLGPJLCP = MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
	}

	private void MCNIFLFDJII()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!GetBool("Scratch"))
			{
				SetBool("Tail", EGFGNGJGBOP: false);
				SetBool("Sit", EGFGNGJGBOP: false);
				SetBool("Scratch", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Time.time + Random.Range(2f, 4f);
			}
			else
			{
				SetBool("Scratch", EGFGNGJGBOP: false);
				SetBool("Sit", EGFGNGJGBOP: true);
				SetBool("Tail", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Time.time + Random.Range(6f, 10f);
			}
		}
	}

	private void GIGJPJMLDMB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EEGJBDCBKFD() == (Season)8 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(false);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(false);
		}
	}

	private void IDIGHPCFPDP()
	{
		if (!GetBool("Sleep"))
		{
			SetBool("Sleep", EGFGNGJGBOP: true);
		}
	}

	private void EBIDAMBGALD(AudioObject JPNIMEGNOCB)
	{
		if (JPNIMEGNOCB.loop)
		{
			if ((Object)(object)EINDLGPJLCP != (Object)null)
			{
				EINDLGPJLCP.Stop(true);
			}
			EINDLGPJLCP = MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
	}

	private void OKHKJBOMFIN(AudioObject JPNIMEGNOCB)
	{
		if (JPNIMEGNOCB.loop)
		{
			if ((Object)(object)EINDLGPJLCP != (Object)null)
			{
				EINDLGPJLCP.Stop(true);
			}
			EINDLGPJLCP = MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
	}

	private void JFBIMMGIJIP()
	{
		if (!JEJPKGILEDB(" "))
		{
			CGEADHOLHCH("Intro11", EGFGNGJGBOP: false);
		}
	}

	public void HKNGJGGLLJD()
	{
		loveEmote.SetActive(false);
	}

	private void OOBDKJHKPEP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1271f)
		{
			if (FCGBJEIIMBC != Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC))
			{
				if (AAMNCMMDJLM > 1)
				{
					FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
					AAMNCMMDJLM = 1;
				}
				else
				{
					AAMNCMMDJLM += 0;
				}
			}
			else
			{
				AAMNCMMDJLM = 0;
			}
			if (!LHGMJFGOHFD())
			{
				FOLLIMBJNMK("UISelectGamepad", AODONKKHPBP: false, CDPAMNIPPEC: true);
				IHHBOLPDMCJ(AODONKKHPBP: false);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
				{
					onlineDog.SendSetBool("UI", AODONKKHPBP: true);
				}
			}
			if (!MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed == onlineDog.dogNpc.runSpeed)
			{
				OCGKMIIPJJF(" / ", AODONKKHPBP: false, CDPAMNIPPEC: false);
				MHEOAHLBGHC = true;
			}
			else if (MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed != onlineDog.dogNpc.runSpeed)
			{
				MNOLHIHHNCE("EnterTavernDrink", AODONKKHPBP: true, CDPAMNIPPEC: true);
				MHEOAHLBGHC = false;
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			LEFHICGPEPH("Connecting...", AODONKKHPBP: true, CDPAMNIPPEC: false);
			base.CNKHDCIKHCO = false;
			OCGKMIIPJJF("ThemeText", AODONKKHPBP: true, CDPAMNIPPEC: false);
			MHEOAHLBGHC = true;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
			{
				onlineDog.SendSetBool("Cannot place mine block piece at ", AODONKKHPBP: false);
			}
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MHEKKPODAFD()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.PJMGHIMKFJL() == (Season)5 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
	}

	private void DAPNLBKGDMH()
	{
		if (!GetBool("Dig"))
		{
			JLJBAFOHFJK();
			SetBool("Dig", EGFGNGJGBOP: true);
			if ((Object)(object)DogNPC.instance.currentDogHole != (Object)null)
			{
				DogNPC.instance.currentDogHole.holeChecked = true;
				DogNPC.instance.currentDogHole.ShowHole();
			}
			FAHMDMLHPPO = Time.time + 2f;
			MPONLOIFIMI(Sound.GGFJGHHHEJC.dogDigging);
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			DogNPC.instance.ChangeState(DogState.FollowPlayer);
		}
	}

	public void IODEEPJHFGG(bool CDPAMNIPPEC)
	{
		if ((Object)(object)EINDLGPJLCP != (Object)null)
		{
			EINDLGPJLCP.Stop(false);
			EINDLGPJLCP = null;
		}
		JKGGHCHHCFG(" : 00", AODONKKHPBP: true, CDPAMNIPPEC: false);
		DJAPIEALHAB("GetHotWater", AODONKKHPBP: false, CDPAMNIPPEC: true);
		OCGKMIIPJJF("itemPumpkinSeeds", AODONKKHPBP: true, CDPAMNIPPEC: true);
		LEFHICGPEPH("PlayerJoined_F", AODONKKHPBP: true, CDPAMNIPPEC: true);
		FAPMGINDKEE("UIBack", AODONKKHPBP: true, CDPAMNIPPEC: false);
		OCGKMIIPJJF("Fireplace not attached on OnlineFireplace of placeable ", AODONKKHPBP: true, CDPAMNIPPEC: false);
		FAPMGINDKEE("Dialogue System/Conversation/Gass_Introduce/Entry/21/Dialogue Text", AODONKKHPBP: true, CDPAMNIPPEC: true);
		JKGGHCHHCFG("Waiting for mine to load for client ", AODONKKHPBP: true, CDPAMNIPPEC: true);
		MNOLHIHHNCE("ButtonHold", AODONKKHPBP: true, CDPAMNIPPEC: true);
		MNOLHIHHNCE("Trying to create room...", AODONKKHPBP: true, CDPAMNIPPEC: false);
		IHGHFIBLFFG.dirt.SetActive(true);
		IHGHFIBLFFG.snow.SetActive(false);
		if ((Object)(object)IHGHFIBLFFG.dogInteractable != (Object)null)
		{
			IHGHFIBLFFG.dogInteractable.EJNEPNMEIML();
		}
		JIFFOKNLHHD = 0;
		IMCFMGGOCHP = 0;
		IHGHFIBLFFG.dogInteractable = null;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.KCJCBKABIJK();
		}
	}

	private void NALAAOKHEFD()
	{
		if (!JEJPKGILEDB("Fish didn't have a proper bed assigned value {0}"))
		{
			SetBool("NotFocused", EGFGNGJGBOP: false);
		}
	}

	private void INPGIONKHFB(AudioObject JPNIMEGNOCB)
	{
		if (JPNIMEGNOCB.loop)
		{
			if ((Object)(object)EINDLGPJLCP != (Object)null)
			{
				EINDLGPJLCP.Stop(true);
			}
			EINDLGPJLCP = MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(JPNIMEGNOCB, ((Component)this).transform);
		}
	}

	private void CNIEENEADAE()
	{
		if (!GetBool("Invalid playerNum"))
		{
			CGEADHOLHCH("SetBoolRPC", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private void IMPPDNHJDLN(string GEGDHHIDEEF, bool CDPAMNIPPEC)
	{
		SetTrigger(GEGDHHIDEEF);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendSetTrigger(GEGDHHIDEEF);
		}
	}

	private void BDDGJCNEHIB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EEGJBDCBKFD() == Season.Spring && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(false);
			IHGHFIBLFFG.snow.SetActive(false);
		}
	}

	private void FixedUpdate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 0f)
		{
			if (FCGBJEIIMBC != Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC))
			{
				if (AAMNCMMDJLM > 0)
				{
					FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
					AAMNCMMDJLM = 0;
				}
				else
				{
					AAMNCMMDJLM++;
				}
			}
			else
			{
				AAMNCMMDJLM = 0;
			}
			if (!base.CNKHDCIKHCO)
			{
				OCGKMIIPJJF("Moving", AODONKKHPBP: true, CDPAMNIPPEC: true);
				base.CNKHDCIKHCO = true;
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
				{
					onlineDog.SendSetBool("Moving", AODONKKHPBP: true);
				}
			}
			if (!MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed == onlineDog.dogNpc.runSpeed)
			{
				OCGKMIIPJJF("Running", AODONKKHPBP: true, CDPAMNIPPEC: true);
				MHEOAHLBGHC = true;
			}
			else if (MHEOAHLBGHC && (Object)(object)onlineDog != (Object)null && onlineDog.dogNpc.walkTo.currentSpeed != onlineDog.dogNpc.runSpeed)
			{
				OCGKMIIPJJF("Running", AODONKKHPBP: false, CDPAMNIPPEC: true);
				MHEOAHLBGHC = false;
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			OCGKMIIPJJF("Moving", AODONKKHPBP: true, CDPAMNIPPEC: true);
			base.CNKHDCIKHCO = false;
			OCGKMIIPJJF("Running", AODONKKHPBP: false, CDPAMNIPPEC: true);
			MHEOAHLBGHC = false;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineDog != (Object)null)
			{
				onlineDog.SendSetBool("Moving", AODONKKHPBP: false);
			}
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DADPOICMNPI()
	{
		if ((Object)(object)onlineDog != (Object)null)
		{
			IHGHFIBLFFG = onlineDog.dogNpc;
		}
	}

	private void KMBEOPAHKGB()
	{
		if ((Object)(object)onlineDog != (Object)null)
		{
			IHGHFIBLFFG = onlineDog.dogNpc;
		}
	}

	private void NOIJLGNPBEG(string GEGDHHIDEEF, bool CDPAMNIPPEC)
	{
		SetTrigger(GEGDHHIDEEF);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendSetTrigger(GEGDHHIDEEF);
		}
	}

	private void ACFLMEKFKAF()
	{
		if (!JEJPKGILEDB("Inventory full"))
		{
			CGEADHOLHCH("Attack/MainEvent 9", EGFGNGJGBOP: true, HALNIEBONKH: true);
			FAHMDMLHPPO += 1619f;
		}
		else if (Time.time >= FAHMDMLHPPO)
		{
			if (JEJPKGILEDB("qualityWater2"))
			{
				CGEADHOLHCH("Dialogue System/Conversation/Crowly_Standar/Entry/25/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
				CGEADHOLHCH("KickedCustomers", EGFGNGJGBOP: false);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 795f, FAHMDMLHPPO + 980f);
			}
			else if (GetBool("HotBath/Bark"))
			{
				SetBool("RoadBlockedEvent: Bob goes to farm", EGFGNGJGBOP: true, HALNIEBONKH: true);
				SetBool("Items/item_name_728", EGFGNGJGBOP: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 865f, FAHMDMLHPPO + 500f);
			}
			else
			{
				CGEADHOLHCH("/unlock: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Random.Range(FAHMDMLHPPO + 1330f, FAHMDMLHPPO + 1644f);
			}
		}
	}

	public void ENKCLFIOHOJ()
	{
		loveEmote.SetActive(false);
	}

	private void BBNCEDICPAM()
	{
		if (JIFFOKNLHHD == 0)
		{
			JIFFOKNLHHD = Random.Range(5, 6);
			IMCFMGGOCHP = 0;
			FAHMDMLHPPO = Time.time;
		}
		if (Time.time >= FAHMDMLHPPO)
		{
			FAHMDMLHPPO = Time.time + Random.Range(1781f, 379f);
			DMGENAOPNIG("ReceiveDestroyStatue", CDPAMNIPPEC: false);
			IMCFMGGOCHP++;
			EBIDAMBGALD(Sound.MAIDHAPANEB().dogBark);
			if (IMCFMGGOCHP >= JIFFOKNLHHD)
			{
				JIFFOKNLHHD = (JIFFOKNLHHD = Random.Range(4, 2));
				FAHMDMLHPPO = Time.time + Random.Range(680f, 1007f);
			}
		}
	}

	public void DIPPNHLOEMJ(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			LENFJBDHAJG();
			break;
		case DogNPC.DogInteractionType.Friendly:
			BAMOMIFONDD();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			LENFJBDHAJG();
			break;
		case DogNPC.DogInteractionType.Sleep:
			GEBOOAAJNCK();
			break;
		case DogNPC.DogInteractionType.Dig:
			HOCMIKKKFLO();
			break;
		case DogNPC.DogInteractionType.Drink:
			JIPIGHKCNIL();
			break;
		case DogNPC.DogInteractionType.Eat:
			KHDPPAHBMAE();
			break;
		case DogNPC.DogInteractionType.Toy:
			ICPICDHIHFN();
			break;
		case DogNPC.DogInteractionType.Smell:
			PHGMKECMGKH();
			break;
		case DogNPC.DogInteractionType.Scratch:
			CFCNOKLGBAE();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.AALIPKFGHBJ(NCMDEGABGCH);
		}
	}

	private void LNHFFJCAGNM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EEGJBDCBKFD() == (Season)5 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
		else
		{
			IHGHFIBLFFG.dirt.SetActive(true);
			IHGHFIBLFFG.snow.SetActive(true);
		}
	}

	private void AJIMCICANFO(string GEGDHHIDEEF, bool AODONKKHPBP, bool CDPAMNIPPEC)
	{
		if (JEJPKGILEDB(GEGDHHIDEEF) != AODONKKHPBP)
		{
			CGEADHOLHCH(GEGDHHIDEEF, AODONKKHPBP, HALNIEBONKH: true);
			if ((Object)(object)onlineDog != (Object)null && CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.LBBCANANBGI(GEGDHHIDEEF, AODONKKHPBP);
			}
		}
	}

	private void OAFFGJOOOLA()
	{
		if (!GetBool("Items/item_description_722"))
		{
			SetBool("No name", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private void HCMLANJLCBN()
	{
		if (Time.time >= FAHMDMLHPPO)
		{
			if (!JEJPKGILEDB(" decoFloorId: "))
			{
				CGEADHOLHCH("HenHouseTutorialDone", EGFGNGJGBOP: false, HALNIEBONKH: true);
				CGEADHOLHCH("\\[WaiterGender=[^\\]]*\\]", EGFGNGJGBOP: true, HALNIEBONKH: true);
				CGEADHOLHCH("Items/item_name_609", EGFGNGJGBOP: true, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(234f, 855f);
			}
			else
			{
				CGEADHOLHCH("Player", EGFGNGJGBOP: false, HALNIEBONKH: true);
				CGEADHOLHCH("\n", EGFGNGJGBOP: true);
				CGEADHOLHCH("flashLights", EGFGNGJGBOP: false, HALNIEBONKH: true);
				FAHMDMLHPPO = Time.time + Random.Range(199f, 133f);
			}
		}
	}

	public void PFHBCKEMNHF(DogNPC.DogInteractionType NCMDEGABGCH, bool CDPAMNIPPEC = true)
	{
		switch (NCMDEGABGCH)
		{
		case DogNPC.DogInteractionType.Bark:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Friendly:
			ACFLMEKFKAF();
			break;
		case DogNPC.DogInteractionType.Aggressive:
			DPHILMNKFIA();
			break;
		case DogNPC.DogInteractionType.Sleep:
			GNHMABDFPHM();
			break;
		case DogNPC.DogInteractionType.Dig:
			ICBJPLEJPFH();
			break;
		case DogNPC.DogInteractionType.Drink:
			JIPIGHKCNIL();
			break;
		case DogNPC.DogInteractionType.Eat:
			IADJDFINFMF();
			break;
		case DogNPC.DogInteractionType.Toy:
			ICPICDHIHFN();
			break;
		case DogNPC.DogInteractionType.Smell:
			BJDHKJFPACE();
			break;
		case DogNPC.DogInteractionType.Scratch:
			PNEAAPODDJH();
			break;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineDog.SendReproduceInteraction(NCMDEGABGCH);
		}
	}

	private void BJDHKJFPACE()
	{
		if (!GetBool("k"))
		{
			CGEADHOLHCH("Theme: ", EGFGNGJGBOP: true);
		}
	}
}
