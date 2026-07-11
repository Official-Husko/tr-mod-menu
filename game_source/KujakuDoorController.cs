using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KujakuDoorController : MonoBehaviour
{
	public Collider2D travelZoneCollider;

	public GameObject doorGameObject;

	public GameObject lightOpen;

	public GameObject lightClose;

	public Animator doorAnimator;

	private bool LKOJBFMGMAE;

	private float DAIOJCIBHFM;

	private void MFIBFFDBNGI()
	{
		JKGGJMNBGBP();
	}

	private void KACEOJDPLKB()
	{
		MPHFDPCKCDP();
	}

	private void IGKPEBGHPGD()
	{
		OKGLDAMCEGP();
	}

	private void HFFFFAJFIPB()
	{
		JEJKCHFDKAF();
	}

	private void MPHFDPCKCDP()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)(-110)))
		{
			HJNFMHOHHGB();
		}
		else if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)93))
		{
			FJPAIKAFOKD();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1663f;
			if (WorldTime.EDIPJBOOEHD > (float)(-76 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NOAOJJLNHJJ.day == Day.Wed)
			{
				Result variable = DialogueLua.GetVariable("talent_name_116");
				if (((Result)(ref variable)).asInt != 0)
				{
					OFGKFMJKBON();
					return;
				}
			}
			NJGFJFEGBNF();
		}
	}

	private void JPHFCJIBBMI()
	{
		MAPNGMLNHJH();
	}

	private void OFGKFMJKBON()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Give"))
		{
			doorAnimator.SetBool("/Player.log", false);
		}
	}

	private void APPABLHBILM()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool(""))
		{
			doorAnimator.SetBool("", false);
		}
	}

	private void HJNFMHOHHGB()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Year"))
		{
			doorAnimator.SetBool("Items/item_name_697", true);
		}
	}

	private void Start()
	{
		IIIGGIDIGFI();
	}

	private void EOBPEGDPFPN()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("BanquetEvent not activated"))
		{
			doorAnimator.SetBool("", true);
		}
	}

	private void BDJKNKIOPIJ()
	{
		NPPFBPFKGMC();
	}

	private void OBKCMFKJKID()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Chair"))
		{
			doorAnimator.SetBool("Game", true);
		}
	}

	private void EAGNOMBNDFP()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)73))
		{
			JMCKBMBKLEH();
		}
		else if (EventsManager.NJBACCBIHID((EventsManager.EventType)81))
		{
			OIDHGKCAAGG();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 8f;
			if (WorldTime.BBBGEBIPHPI() > (float)(83 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NOAOJJLNHJJ.day == Day.Sun)
			{
				Result variable = DialogueLua.GetVariable("LearnPrecision");
				if (((Result)(ref variable)).asInt != 0)
				{
					EOBPEGDPFPN();
					return;
				}
			}
			APPABLHBILM();
		}
	}

	private void GEFGPDLCOBO()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Invalid playerNum"))
		{
			doorAnimator.SetBool("Could not get value of statistic ", true);
		}
	}

	private void OIDHGKCAAGG()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("\n"))
		{
			doorAnimator.SetBool("SendRoomRequest", false);
		}
	}

	private void ELKLOLHBEMC()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-91)))
		{
			FJPAIKAFOKD();
		}
		else if (EventsManager.NKMELJPGOBB((EventsManager.EventType)30))
		{
			LHEFGNHAEKC();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 792f;
			if (WorldTime.DHPFCKNGHLO() > (float)(82 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.HGIBNMBJMOC().day == Day.Thurs)
			{
				Result variable = DialogueLua.GetVariable("Crowly_Standar");
				if (((Result)(ref variable)).asInt != 0)
				{
					FJPAIKAFOKD();
					return;
				}
			}
			NJGFJFEGBNF();
		}
	}

	private void CMLLBIDFNEB()
	{
		AGNKAAIKAON();
	}

	private void KBLHFOPHEOJ()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("'. "))
		{
			doorAnimator.SetBool(" ", true);
		}
	}

	private void AAPOIEBGAEB()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("-"))
		{
			doorAnimator.SetBool("Sit", false);
		}
	}

	private void NPPFBPFKGMC()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-79)))
		{
			HJNFMHOHHGB();
		}
		else if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-3)))
		{
			ELCNPCHAEHF();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 630f;
			if (WorldTime.EDIPJBOOEHD > (float)(-92 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.HGIBNMBJMOC().day == Day.Thurs)
			{
				Result variable = DialogueLua.GetVariable("trashCollected");
				if (((Result)(ref variable)).asInt != 0)
				{
					AAPOIEBGAEB();
					return;
				}
			}
			NFIKFBPACPC();
		}
	}

	private void HKKDEKIFPPJ()
	{
		MPHFDPCKCDP();
	}

	private void IIIGGIDIGFI()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.Precision))
		{
			ECMGCJGPKNO();
		}
		else if (EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			ECMGCJGPKNO();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 60f;
			if (WorldTime.EDIPJBOOEHD > (float)(22 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NOAOJJLNHJJ.day == Day.Sun)
			{
				Result variable = DialogueLua.GetVariable("LE_14");
				if (((Result)(ref variable)).asInt != 0)
				{
					ECMGCJGPKNO();
					return;
				}
			}
			MGBINPIKAEK();
		}
	}

	private void JMCKBMBKLEH()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Can't find seat. Reason: lastOrders"))
		{
			doorAnimator.SetBool("vibrationP2", false);
		}
	}

	private void MEAFJDDNAJB()
	{
		OKGLDAMCEGP();
	}

	private void CFHOODNCOLK()
	{
		IIIGGIDIGFI();
	}

	private void MGBINPIKAEK()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Close"))
		{
			doorAnimator.SetBool("Close", true);
		}
	}

	private void NDNBDEHFFJF()
	{
		MAPNGMLNHJH();
	}

	private void IMGJAMNGPPB()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("setDefaultSettings"))
		{
			doorAnimator.SetBool("Items/item_description_665", true);
		}
	}

	private void OKGLDAMCEGP()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (EventsManager.FFELMGLBAMH((EventsManager.EventType)(-68)))
		{
			OIDHGKCAAGG();
		}
		else if (EventsManager.IKCEIJMLNOP((EventsManager.EventType)(-103)))
		{
			FGLENLFIBAI();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1201f;
			if (WorldTime.EDIPJBOOEHD > (float)(-84 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.HGIBNMBJMOC().day == (Day)7)
			{
				Result variable = DialogueLua.GetVariable("FerroProgress");
				if (((Result)(ref variable)).asInt != 0)
				{
					FGLENLFIBAI();
					return;
				}
			}
			GOFMALMMJDE();
		}
	}

	private void ECMGCJGPKNO()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Close"))
		{
			doorAnimator.SetBool("Close", false);
		}
	}

	private void CFIIEJDJFPB()
	{
		EAGNOMBNDFP();
	}

	private void APDFEPNNPMJ()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Received RPC SetTrigger {0} on {1}. Setting animator parameter."))
		{
			doorAnimator.SetBool("Eyes", true);
		}
	}

	private void IFAPPHLJDMG()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (EventsManager.IsActive((EventsManager.EventType)100))
		{
			OIDHGKCAAGG();
		}
		else if (EventsManager.CJMECHEOFOF((EventsManager.EventType)(-98)))
		{
			AAPOIEBGAEB();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1293f;
			if (WorldTime.DHPFCKNGHLO() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.HGIBNMBJMOC().day == (Day)7)
			{
				Result variable = DialogueLua.GetVariable("RecieveActivateEvent");
				if (((Result)(ref variable)).asInt != 0)
				{
					GEFGPDLCOBO();
					return;
				}
			}
			NJGFJFEGBNF();
		}
	}

	private void NLGJCNGLFBC()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("UseHold"))
		{
			doorAnimator.SetBool("tutorialPopUp124", true);
		}
	}

	private void CJKOAADNCEH()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-84)))
		{
			FJPAIKAFOKD();
		}
		else if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)132))
		{
			FJPAIKAFOKD();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 334f;
			if (WorldTime.NJECJAHEOIA() > (float)(96 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NOAOJJLNHJJ.day == (Day)7)
			{
				Result variable = DialogueLua.GetVariable("ErrorUnknownChatCommand");
				if (((Result)(ref variable)).asInt != 0)
				{
					GNLHMDFHMII();
					return;
				}
			}
			NLGJCNGLFBC();
		}
	}

	private void PAMLGGBJCPA()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool(" - <b><color=#0BC800>"))
		{
			doorAnimator.SetBool("Sprint time", false);
		}
	}

	private void GOJFGHKOFMF()
	{
		AGNKAAIKAON();
	}

	private void OAKGHDAABPM()
	{
		MAPNGMLNHJH();
	}

	private void ILJKCAMMGON()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Player2"))
		{
			doorAnimator.SetBool("Dialogue System/Conversation/Gass_Introduce/Entry/24/Dialogue Text", true);
		}
	}

	private void Update()
	{
		IIIGGIDIGFI();
	}

	private void EEKOJEKPIMP()
	{
		EAGNOMBNDFP();
	}

	private void HPIMHEMJMAA()
	{
		GGMCKDKEFFK();
	}

	private void PGJJBPALEGM()
	{
		CJKOAADNCEH();
	}

	private void AGNKAAIKAON()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-63)))
		{
			LHEFGNHAEKC();
		}
		else if (EventsManager.GIJNJBNBMJK((EventsManager.EventType)(-58)))
		{
			AAPOIEBGAEB();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1138f;
			if (WorldTime.GBCKNDKCFFF() > (float)(-103 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.CJOHMLNMJLK().day == Day.Thurs)
			{
				Result variable = DialogueLua.GetVariable("trashCollected");
				if (((Result)(ref variable)).asInt != 0)
				{
					INAFDPLGOCN();
					return;
				}
			}
			GOFMALMMJDE();
		}
	}

	private void FNOEEKDPFIB()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Current crafting:"))
		{
			doorAnimator.SetBool("UINextCategory", false);
		}
	}

	private void MCLAJGDIIBK()
	{
		MAPNGMLNHJH();
	}

	private void FGLENLFIBAI()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Chat end edit"))
		{
			doorAnimator.SetBool("tablesCleaned", false);
		}
	}

	private void GOFMALMMJDE()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("UIBack"))
		{
			doorAnimator.SetBool("Items/item_name_591", false);
		}
	}

	private void LLCCNNLKENE()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.BBMAEAFHEFK((EventsManager.EventType)(-52)))
		{
			ILJKCAMMGON();
		}
		else if (EventsManager.GIJNJBNBMJK((EventsManager.EventType)(-73)))
		{
			OPMFBEJBJAE();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 152f;
			if (WorldTime.DHPFCKNGHLO() > (float)(-61 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.HGIBNMBJMOC().day == Day.Sat)
			{
				Result variable = DialogueLua.GetVariable("KyrohScene");
				if (((Result)(ref variable)).asInt != 0)
				{
					IMGJAMNGPPB();
					return;
				}
			}
			NFIKFBPACPC();
		}
	}

	private void FOHCEDHJOEF()
	{
		CJKOAADNCEH();
	}

	private void DKNMGFDFLKL()
	{
		MAPNGMLNHJH();
	}

	private void NJGFJFEGBNF()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool(" from actor "))
		{
			doorAnimator.SetBool("All bubbles in use!", false);
		}
	}

	private void GNLHMDFHMII()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Use"))
		{
			doorAnimator.SetBool("MopDown", false);
		}
	}

	private void GJMLHECPGBP()
	{
		MAPNGMLNHJH();
	}

	private void KHEMDIMKCBF()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Dialogue System/Conversation/Gass_Quest/Entry/27/Dialogue Text"))
		{
			doorAnimator.SetBool("InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ", false);
		}
	}

	private void MAPNGMLNHJH()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.CJMECHEOFOF((EventsManager.EventType)(-62)))
		{
			JDBPHGPKGJH();
		}
		else if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)30))
		{
			OOHCPDGAPBE();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 104f;
			if (WorldTime.NJECJAHEOIA() > (float)(-120 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.CJOHMLNMJLK().day == Day.Tue)
			{
				Result variable = DialogueLua.GetVariable("Too late to open");
				if (((Result)(ref variable)).asInt != 0)
				{
					GNLHMDFHMII();
					return;
				}
			}
			GCNAPIBILLG();
		}
	}

	private void ONOAGANPECB()
	{
		MPHFDPCKCDP();
	}

	private void ELCNPCHAEHF()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("LE_10"))
		{
			doorAnimator.SetBool("itemParsleySeeds", false);
		}
	}

	private void OOHCPDGAPBE()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Items/item_name_1088"))
		{
			doorAnimator.SetBool(" ", true);
		}
	}

	private void JDBPHGPKGJH()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Close Multiple Choice"))
		{
			doorAnimator.SetBool("City/Amos/Introduce", true);
		}
	}

	private void BGFCHEIOKOG()
	{
		ELKLOLHBEMC();
	}

	private void HIPNEFOEJPL()
	{
		IIIGGIDIGFI();
	}

	private void KJOJLHCDFPP()
	{
		JKGGJMNBGBP();
	}

	private void FIBLMHAKCCI()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Shield"))
		{
			doorAnimator.SetBool("Connect a gamepad to play with player 2", false);
		}
	}

	private void HGJGMEPJOMC()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Style"))
		{
			doorAnimator.SetBool("Could not find item with id: ", false);
		}
	}

	private void HOFKJPBBLGP()
	{
		JEJKCHFDKAF();
	}

	private void HBMDEHPHAPF()
	{
		NPPFBPFKGMC();
	}

	private void INAFDPLGOCN()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Enter"))
		{
			doorAnimator.SetBool("Items/item_description_694", false);
		}
	}

	private void JKGGJMNBGBP()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (EventsManager.IsActive((EventsManager.EventType)(-100)))
		{
			AAPOIEBGAEB();
		}
		else if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-82)))
		{
			ELCNPCHAEHF();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1242f;
			if (WorldTime.GBCKNDKCFFF() > (float)(-104 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NOAOJJLNHJJ.day == Day.Sun)
			{
				Result variable = DialogueLua.GetVariable("StartObserverDialogue ");
				if (((Result)(ref variable)).asInt != 0)
				{
					JDBPHGPKGJH();
					return;
				}
			}
			KBLHFOPHEOJ();
		}
	}

	private void LHEFGNHAEKC()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("qualityWater"))
		{
			doorAnimator.SetBool("All:", false);
		}
	}

	private void NCIBKMLIIAJ()
	{
		ELKLOLHBEMC();
	}

	private void POFDOILPANH()
	{
		ELKLOLHBEMC();
	}

	private void OPMFBEJBJAE()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("NotFocused"))
		{
			doorAnimator.SetBool("Could not find Quest with id: ", true);
		}
	}

	private void JEJKCHFDKAF()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (EventsManager.NKMELJPGOBB(EventsManager.EventType.GoToHotSpring))
		{
			FGLENLFIBAI();
		}
		else if (EventsManager.IsActive((EventsManager.EventType)(-63)))
		{
			GEFGPDLCOBO();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1126f;
			if (WorldTime.EDIPJBOOEHD > (float)(50 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.CJOHMLNMJLK().day == Day.Sat)
			{
				Result variable = DialogueLua.GetVariable("HorizontalMove");
				if (((Result)(ref variable)).asInt != 0)
				{
					GNLHMDFHMII();
					return;
				}
			}
			KHEMDIMKCBF();
		}
	}

	private void NNBIAIMPNGL()
	{
		OKGLDAMCEGP();
	}

	private void PFLBPMIEKGF()
	{
		NPPFBPFKGMC();
	}

	private void GGMCKDKEFFK()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)(-114)))
		{
			OFGKFMJKBON();
		}
		else if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)(-19)))
		{
			OPMFBEJBJAE();
		}
		else
		{
			if (!(Time.time > DAIOJCIBHFM))
			{
				return;
			}
			DAIOJCIBHFM = Time.time + 1270f;
			if (WorldTime.BNKLACHEGOP() > (float)(58 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.HGIBNMBJMOC().day == Day.Fri)
			{
				Result variable = DialogueLua.GetVariable(",");
				if (((Result)(ref variable)).asInt != 0)
				{
					GEFGPDLCOBO();
					return;
				}
			}
			KHEMDIMKCBF();
		}
	}

	private void MCMKNBIBDFF()
	{
		GGMCKDKEFFK();
	}

	private void FJPAIKAFOKD()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Player2"))
		{
			doorAnimator.SetBool("The pool ", false);
		}
	}

	private void MGMLDHPOLGK()
	{
		OKGLDAMCEGP();
	}

	private void EBNENBFLEKB()
	{
		JKGGJMNBGBP();
	}

	private void NFIKFBPACPC()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("F4"))
		{
			doorAnimator.SetBool("Right Shift", false);
		}
	}

	private void GCNAPIBILLG()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Run"))
		{
			doorAnimator.SetBool("Items/item_description_1190", false);
		}
	}
}
