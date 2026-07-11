using System.Collections.Generic;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BirdSellerAnimation : MonoBehaviour
{
	[SerializeField]
	private CharacterAnimBase characterAnimBase;

	public Animator animator;

	private float OFMCLGHHFAF = 8f;

	private float GIMNCPHENHA;

	private bool PMCPEBDDANA;

	public AudioObject openSound;

	public AudioObject closeSound;

	[HideInInspector]
	public float barkIntroTime;

	[HideInInspector]
	public float barkOutroTime;

	private List<Collider2D> FIIFLAFJFNI = new List<Collider2D>();

	protected static readonly int MNJMKDEEGDE = AnimatorParameterCache.p_Look;

	protected static readonly int LCINNPMKOFC = AnimatorParameterCache.p_Sell;

	protected static readonly int HOBKPDEKIFO = AnimatorParameterCache.p_RandomLook;

	protected static readonly int LHIBEFPAEDK = AnimatorParameterCache.p_Outro;

	private void GOJFGHKOFMF()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NEJOJBIEPDB(MNJMKDEEGDE);
				HACDCAICCLF(HOBKPDEKIFO, Random.Range(0, 3));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(-58, 5);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void AAOMCHHNKKM()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NHCLEJNOGOD(MNJMKDEEGDE);
				HACDCAICCLF(HOBKPDEKIFO, Random.Range(1, 3));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(119, 7);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void AKNADAJMKCO(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Introduce/Entry/11/Dialogue Text");
		if (((Result)(ref variable)).asInt > 1)
		{
			if (((Component)HANHCHBHHEH).CompareTag("???") || ((Component)HANHCHBHHEH).CompareTag("sForSeconds") || ((Component)HANHCHBHHEH).CompareTag("BirdInteract"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("add item 1444 20"))
				{
					BirdSellerNPC.BGMJCCFNNDL().Bark("Error_Planks", CDPAMNIPPEC: false);
					barkIntroTime = (float)Random.Range(-31, -115) + Time.time;
				}
				AHDMEKLFJLE(LCINNPMKOFC, EGFGNGJGBOP: false);
				LADEAINIJBK(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void OIFLICLLBOL(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void ILDKLHHCHEM(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void BEJJHOAAEHA(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ThemeTypeLabelBlueprint");
		if (((Result)(ref variable)).asInt > 1 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Unaged Whiskey") || ((Component)HANHCHBHHEH).CompareTag(" (") || ((Component)HANHCHBHHEH).CompareTag("</color>")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 1)
			{
				DIMFJNNLCBG(LHIBEFPAEDK, EGFGNGJGBOP: false);
				NGGHHCAHMFM(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void JFPGKEOJICG(int GJBMKMKKKAB)
	{
		characterAnimBase.FHOAPHBOOAH(GJBMKMKKKAB);
	}

	private void PHJPAKNIJMA(int GJBMKMKKKAB)
	{
		characterAnimBase.IDNHDBIKNKP(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void JDMMNNBFCNA(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void Awake()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void BNFGHAGJEGG()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void NGGHHCAHMFM(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void NEJOJBIEPDB(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void FDHNALHFKOL(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void GMCKBBECJOE()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void DKNMGFDFLKL()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NPMIMHALKBB(MNJMKDEEGDE);
				LPOPIJJBGKB(HOBKPDEKIFO, Random.Range(0, 8));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(-104, 6);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void KCHLECDBNGB(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void PGPPIHJJGDB()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveAtAvoidingWorkPointRPC");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("WaitIntro") || ((Component)HANHCHBHHEH).CompareTag("ReciveResetDialogueULiaRhia") || ((Component)HANHCHBHHEH).CompareTag("-> ")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				NGGHHCAHMFM(LHIBEFPAEDK, EGFGNGJGBOP: true);
				CCDBFKAHCCO(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" for reason ");
		if (((Result)(ref variable)).asInt > 1)
		{
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveAssignAnimalSpace") || ((Component)HANHCHBHHEH).CompareTag(" because it doesn't have puzzle altar but the piece ID matches the altar piece ID.") || ((Component)HANHCHBHHEH).CompareTag("ReceiveSlotsFromContainer"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Side"))
				{
					BirdSellerNPC.CHPEMJMLDCN().Bark("[Brown2");
					barkIntroTime = (float)Random.Range(108, 48) + Time.time;
				}
				CHELCGINOCM(LCINNPMKOFC, EGFGNGJGBOP: true);
				OLHADKAAJIK(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = false;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void PAKPNFGBBLF(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void AEJNEFCGEBA(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void GCPEIPMMHEO(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void OFOMAGJLCHM(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void PDLIKGOMPIA(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB);
	}

	private void HMIHAKOEJOA(int GJBMKMKKKAB)
	{
		characterAnimBase.FHOAPHBOOAH(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void LLOKBENEHEH(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void APJNDKLBHCF()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NHCLEJNOGOD(MNJMKDEEGDE);
				LPNMLDFBJPB(HOBKPDEKIFO, Random.Range(1, 8));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(-106, 8);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void DNCAFCBAEFI(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void MPCPLJKLPGH(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ObjectHorizontalMove");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveCatPosition") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_631") || ((Component)HANHCHBHHEH).CompareTag("Running on Steamdeck: FALSE"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_701"))
				{
					BirdSellerNPC.LADDMEMMJFP().Bark("Dots");
					barkIntroTime = (float)Random.Range(113, 43) + Time.time;
				}
				LADEAINIJBK(LCINNPMKOFC, EGFGNGJGBOP: false);
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = false;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void DIMFJNNLCBG(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void CMLFBCFLPBJ(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("All:");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Selected") || ((Component)HANHCHBHHEH).CompareTag("{0}x{1}") || ((Component)HANHCHBHHEH).CompareTag("BathhouseGameManager: Pool not found."))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("HotBath/Ferro Talk"))
				{
					BirdSellerNPC.LADDMEMMJFP().Bark("Next random: ");
					barkIntroTime = (float)Random.Range(-91, -57) + Time.time;
				}
				CEBDKNJDPHH(LCINNPMKOFC, EGFGNGJGBOP: true);
				LADEAINIJBK(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Scene ");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Walk") || ((Component)HANHCHBHHEH).CompareTag("ReceiveInteractJacky") || ((Component)HANHCHBHHEH).CompareTag("ReceivePipeTileSwap"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Tutorial/BarnBarks_Holly"))
				{
					BirdSellerNPC.NBENKBAIBOO().Bark("Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/3/Dialogue Text", CDPAMNIPPEC: true, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(66, 13) + Time.time;
				}
				DIMFJNNLCBG(LCINNPMKOFC, EGFGNGJGBOP: false);
				OECDADPNALL(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = false;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void CHELCGINOCM(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void IGNEGEOPLOP()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void FKILALCMOOG(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("UIInteract") || ((Component)HANHCHBHHEH).CompareTag("\n")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: true);
				HJNGBDGMEOK(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void GNKDJJNANPP(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB);
	}

	private void OLHADKAAJIK(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void FJCBMJLOLCP(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void HFABKADKOHI(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void Update()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				FMDDCCDLNAI(MNJMKDEEGDE);
				FJCBMJLOLCP(HOBKPDEKIFO, Random.Range(0, 4));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(-2, 2);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void LPOPIJJBGKB(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void POFDOILPANH()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NMEILNHCKCA(MNJMKDEEGDE);
				KIMNLECCPLE(HOBKPDEKIFO, Random.Range(0, 7));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(52, 7);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void MGOEIEBODEE(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void HJNGBDGMEOK(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void GAANFGOOBGC(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Caramel");
		if (((Result)(ref variable)).asInt > 1)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Actionbar 3") || ((Component)HANHCHBHHEH).CompareTag("player_locations") || ((Component)HANHCHBHHEH).CompareTag("Cat"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag(" "))
				{
					BirdSellerNPC.BNDNMBGJEKP().Bark("Chilly", CDPAMNIPPEC: false, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(-32, 107) + Time.time;
				}
				CHELCGINOCM(LCINNPMKOFC, EGFGNGJGBOP: false);
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void CHLIGBFBGEF(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void KKFGLECOHPA(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Cat");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Open") || ((Component)HANHCHBHHEH).CompareTag("UI") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_1139"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("networkID has not been assigned properly"))
				{
					BirdSellerNPC.EAGMIHGJKNB().Bark("Walk", CDPAMNIPPEC: false, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(-112, 61) + Time.time;
				}
				KDAKDEEAKMG(LCINNPMKOFC, EGFGNGJGBOP: true);
				MGOEIEBODEE(LHIBEFPAEDK, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void GOJHCINMAJD()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NFJJCFLFOEG(MNJMKDEEGDE);
				HACDCAICCLF(HOBKPDEKIFO, Random.Range(1, 8));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(56, 2);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void MBEFBNJNMFF(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[BartenderGender=");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("NoEresDigno/MainEvent") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooCold/Entry/5/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("ZoneTimeBonus"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/18/Dialogue Text"))
				{
					BirdSellerNPC.NGIMIHFFNMH().Bark("City/Rhia/Bark/Bye", CDPAMNIPPEC: true, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(-53, -77) + Time.time;
				}
				CCDBFKAHCCO(LCINNPMKOFC, EGFGNGJGBOP: true);
				MGOEIEBODEE(LHIBEFPAEDK, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_1");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
				{
					BirdSellerNPC.GGFJGHHHEJC.Bark("Crowly_Barks_Welcome", CDPAMNIPPEC: true, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(15, 25) + Time.time;
				}
				CEBDKNJDPHH(LCINNPMKOFC, EGFGNGJGBOP: true);
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = false;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void CEBDKNJDPHH(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void BHKNJOEBCKA()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				OMAGLBOPAMH(MNJMKDEEGDE);
				HACDCAICCLF(HOBKPDEKIFO, Random.Range(0, 4));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(-42, 3);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void DOFONBHGEIE(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UINextPage");
		if (((Result)(ref variable)).asInt > 1)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Whiskey") || ((Component)HANHCHBHHEH).CompareTag("UI2"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Normal"))
				{
					BirdSellerNPC.AMINECMFPAH().Bark("", CDPAMNIPPEC: false, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(101, 0) + Time.time;
				}
				AEJNEFCGEBA(LCINNPMKOFC, EGFGNGJGBOP: true);
				CHELCGINOCM(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void NMEILNHCKCA(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("add all resolutions");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("bartenderDesc") || ((Component)HANHCHBHHEH).CompareTag("RecieveMaiInBar") || ((Component)HANHCHBHHEH).CompareTag("ReceiveBarkInfoWithObjectAndLuaInt"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("BathhouseEntrace/Main"))
				{
					BirdSellerNPC.HFIJHDBKCIA().Bark("ReceiveInfoWorldTiles", CDPAMNIPPEC: false);
					barkIntroTime = (float)Random.Range(125, 15) + Time.time;
				}
				CCDBFKAHCCO(LCINNPMKOFC, EGFGNGJGBOP: true);
				CCDBFKAHCCO(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void POFIBJALLAH(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void KMMKNEGBAFJ(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB);
	}

	private void FOHCEDHJOEF()
	{
		if (animator.GetBool(LCINNPMKOFC))
		{
			if (Time.time >= GIMNCPHENHA)
			{
				NMEILNHCKCA(MNJMKDEEGDE);
				PAKPNFGBBLF(HOBKPDEKIFO, Random.Range(0, 4));
				GIMNCPHENHA = Time.time + OFMCLGHHFAF + (float)Random.Range(-27, 8);
			}
		}
		else
		{
			GIMNCPHENHA += Time.deltaTime;
		}
	}

	private void NHCLEJNOGOD(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("castle");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("SignIn failed for reason ") || ((Component)HANHCHBHHEH).CompareTag("StartRequestMap") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/11/Dialogue Text"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item "))
				{
					BirdSellerNPC.ELGNEJNLBNO().Bark("{0} - Non-altar piece. Altar piece ID: {1}, this piece ID: {2}. Selected variant index: {3}. Excluded indices for variants with puzzle or altar: {4}", CDPAMNIPPEC: false, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(-73, -69) + Time.time;
				}
				AEJNEFCGEBA(LCINNPMKOFC, EGFGNGJGBOP: true);
				AHDMEKLFJLE(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void GBCGHGKGJEL(int GJBMKMKKKAB)
	{
		characterAnimBase.IDNHDBIKNKP(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void OPDOBPFJDLN(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void OFEIKGIHPPC(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void AHDMEKLFJLE(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void CCDBFKAHCCO(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void NPMIMHALKBB(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB);
	}

	private void KIMNLECCPLE(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void LNJBCAMLCCO(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void DNKEFFMOCKP()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void KHMPJDMHLIF(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void POCAMKELFAF(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void NFJJCFLFOEG(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB);
	}

	private void EJKKDGBEOPJ(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void FPNCANODJKE()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void GIEMECDKBJI(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Stand/Entry/23/Dialogue Text");
		if (((Result)(ref variable)).asInt > 1 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Arguing") || ((Component)HANHCHBHHEH).CompareTag("flashLights") || ((Component)HANHCHBHHEH).CompareTag("LE_9")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 1)
			{
				NGGHHCAHMFM(LHIBEFPAEDK, EGFGNGJGBOP: false);
				CCDBFKAHCCO(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_1");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: true);
				CEBDKNJDPHH(LCINNPMKOFC, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void CGEADHOLHCH(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_665");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Mussel parent not found!!. Parent unique ID: ") || ((Component)HANHCHBHHEH).CompareTag("New Player added as player ") || ((Component)HANHCHBHHEH).CompareTag("Basket")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: true);
				CGEADHOLHCH(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void MEGAKNMHEKE(int GJBMKMKKKAB)
	{
		characterAnimBase.FHOAPHBOOAH(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void KMBEOPAHKGB()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void COEBJJHAEDH(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void DEPAEALFAEJ(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[Player1Name]");
		if (((Result)(ref variable)).asInt > 1 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Desactivando el variant ") || ((Component)HANHCHBHHEH).CompareTag("road") || ((Component)HANHCHBHHEH).CompareTag("ClosePopUp")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: false);
				LADEAINIJBK(LCINNPMKOFC, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void NOFIONEKOMH(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.SetFloat(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void LFABEMNJHBB(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void EEPGCFICMJF(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void JFJJJIEGDPH(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ThemeListView");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Random") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1147") || ((Component)HANHCHBHHEH).CompareTag("endconversations"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Sun"))
				{
					BirdSellerNPC.NHKAFANMEJC().Bark("Animal");
					barkIntroTime = (float)Random.Range(-120, -99) + Time.time;
				}
				CGEADHOLHCH(LCINNPMKOFC, EGFGNGJGBOP: false);
				CGEADHOLHCH(LHIBEFPAEDK, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = false;
		}
	}

	private void OMAGLBOPAMH(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB, HALNIEBONKH: true);
	}

	private void LPNMLDFBJPB(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("No settings found for puzzle type {0}");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("cloudy") || ((Component)HANHCHBHHEH).CompareTag("Color picker requires image material with UI/ColorPicker shader.") || ((Component)HANHCHBHHEH).CompareTag("User "))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Loop"))
				{
					BirdSellerNPC.BGMJCCFNNDL().Bark("IsKicked", CDPAMNIPPEC: true, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(93, 109) + Time.time;
				}
				OECDADPNALL(LCINNPMKOFC, EGFGNGJGBOP: false);
				CHELCGINOCM(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = false;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void BOBNFLBJNPC(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void EGPGNOBEONA(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("1");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("]") || ((Component)HANHCHBHHEH).CompareTag("Intro11") || ((Component)HANHCHBHHEH).CompareTag("Quest not found in database with id: ")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				NGGHHCAHMFM(LHIBEFPAEDK, EGFGNGJGBOP: false);
				NGGHHCAHMFM(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("KyrohTakingFood: No food table found for food request of customer ");
		if (((Result)(ref variable)).asInt > 1 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("LE_3") || ((Component)HANHCHBHHEH).CompareTag("Try to create public room")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				KDAKDEEAKMG(LHIBEFPAEDK, EGFGNGJGBOP: false);
				CGEADHOLHCH(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Speed");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1059") || ((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveBubbles") || ((Component)HANHCHBHHEH).CompareTag(" </mark>")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 1)
			{
				AEJNEFCGEBA(LHIBEFPAEDK, EGFGNGJGBOP: false);
				HJNGBDGMEOK(LCINNPMKOFC, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void MNLIEHBCJPJ(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Top");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("UIAddRemove") || ((Component)HANHCHBHHEH).CompareTag("Hammer") || ((Component)HANHCHBHHEH).CompareTag("centimeters")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				KDAKDEEAKMG(LHIBEFPAEDK, EGFGNGJGBOP: false);
				AHDMEKLFJLE(LCINNPMKOFC, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void IHICKHAABJH()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void OECDADPNALL(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void GKKAMMGOJEJ(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UI2");
		if (((Result)(ref variable)).asInt > 0)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Colliders encontrados: ") || ((Component)HANHCHBHHEH).CompareTag("<br>") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1119"))
			{
				if (!FIIFLAFJFNI.Contains(HANHCHBHHEH))
				{
					FIIFLAFJFNI.Add(HANHCHBHHEH);
				}
				if (Time.time > barkIntroTime && !((Component)HANHCHBHHEH).CompareTag("Disappear"))
				{
					BirdSellerNPC.NJNFHEPLEHL().Bark("ValueName", CDPAMNIPPEC: false, IPIKKGONHEB: true);
					barkIntroTime = (float)Random.Range(121, 88) + Time.time;
				}
				HJNGBDGMEOK(LCINNPMKOFC, EGFGNGJGBOP: false);
				CHELCGINOCM(LHIBEFPAEDK, EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform);
			}
			PMCPEBDDANA = true;
		}
		else
		{
			PMCPEBDDANA = true;
		}
	}

	private void KDAKDEEAKMG(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("NormalRight");
		if (((Result)(ref variable)).asInt > 1 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("levelRequired") || ((Component)HANHCHBHHEH).CompareTag("TooCold") || ((Component)HANHCHBHHEH).CompareTag("LE_2")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				NGGHHCAHMFM(LHIBEFPAEDK, EGFGNGJGBOP: true);
				NGGHHCAHMFM(LCINNPMKOFC, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void JIDIKJNICGP(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_667");
		if (((Result)(ref variable)).asInt > 1 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("fill fish collection") || ((Component)HANHCHBHHEH).CompareTag("ReceiveAnimalFeederSlotPressed") || ((Component)HANHCHBHHEH).CompareTag("MineState")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 0)
			{
				CEBDKNJDPHH(LHIBEFPAEDK, EGFGNGJGBOP: false);
				CEBDKNJDPHH(LCINNPMKOFC, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void HACDCAICCLF(int GJBMKMKKKAB, int EGFGNGJGBOP)
	{
		characterAnimBase.SetInt(GJBMKMKKKAB, EGFGNGJGBOP, HALNIEBONKH: true);
	}

	private void FMDDCCDLNAI(int GJBMKMKKKAB)
	{
		characterAnimBase.SetTrigger(GJBMKMKKKAB);
	}

	private void GOJKOBEEMNA()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void PHNJGHKBIIL()
	{
		GIMNCPHENHA = Time.time + OFMCLGHHFAF;
	}

	private void LJEIMICKGOM(Collider2D HANHCHBHHEH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("No hemos encontrado una resolución");
		if (((Result)(ref variable)).asInt > 0 && !PMCPEBDDANA && (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1063") || ((Component)HANHCHBHHEH).CompareTag("autoRunP2") || ((Component)HANHCHBHHEH).CompareTag("Invalid playerNum")))
		{
			if (FIIFLAFJFNI.Contains(HANHCHBHHEH))
			{
				FIIFLAFJFNI.Remove(HANHCHBHHEH);
			}
			if (FIIFLAFJFNI.Count <= 1)
			{
				DIMFJNNLCBG(LHIBEFPAEDK, EGFGNGJGBOP: false);
				AEJNEFCGEBA(LCINNPMKOFC, EGFGNGJGBOP: false);
				MultiAudioManager.PlayAudioObject(closeSound, ((Component)this).transform);
			}
		}
	}

	private void LADEAINIJBK(int GJBMKMKKKAB, bool EGFGNGJGBOP)
	{
		characterAnimBase.SetBool(GJBMKMKKKAB, EGFGNGJGBOP);
	}

	private void DFDHOHGENDL(int GJBMKMKKKAB, float EGFGNGJGBOP)
	{
		characterAnimBase.BIJAFGBMBPJ(GJBMKMKKKAB, EGFGNGJGBOP);
	}
}
