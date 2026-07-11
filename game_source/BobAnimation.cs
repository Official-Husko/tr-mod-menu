using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BobAnimation : MonoBehaviour
{
	public Animator animator;

	private float PPDOHKHDECO;

	private float EBFHLIJCFOF;

	private float MDAGAAGGFGE = 21f;

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(LLKNDOPBOIC));
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(EBOAPBLKAEN));
		}
	}

	private void EHBMONGBJFI()
	{
		PPDOHKHDECO = Time.time + Random.Range(277f, 426f);
		EBFHLIJCFOF = Time.time + Random.Range(1327f, 1768f);
		CFLOBLOGMHH();
	}

	private void JINLGFOFJAN()
	{
		CGEEKEMKJOL();
	}

	private void BFJOEMCBJJO()
	{
		PPDOHKHDECO = Time.time + Random.Range(811f, 1189f);
		EBFHLIJCFOF = Time.time + Random.Range(283f, 304f);
		CFLOBLOGMHH();
	}

	private void MGMLDHPOLGK()
	{
		if (WorldTime.GBCKNDKCFFF() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 1636f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("Farm/Buzz/Door_Bark_Searching"))
			{
				animator.SetBool("NotValid", false);
				DialogueManager.Bark("Select", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.OPDKAPNDBJE().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark("Create Private Room", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(754f, 1766f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(543f, 1619f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("CraftingRoomTiles");
			PPDOHKHDECO = Time.time + Random.Range(566f, 896f);
		}
	}

	private void CGEEKEMKJOL()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"ReceiveEmployeeWorking");
		if ((Object)(object)BobNPC.OPDKAPNDBJE() != (Object)null)
		{
			BobNPC.DFJGHOHPPEL().content.SetActive(true);
			((Component)BobNPC.OFLELHKKNKC()).transform.position = new Vector3(1088f, 1475f, 145f);
			BobNPC.DFJGHOHPPEL().animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("BartenderDescription", true);
		}
		else
		{
			animator.SetBool("Scratch", false);
		}
	}

	private void GOJHCINMAJD()
	{
		if (WorldTime.NJECJAHEOIA() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 1939f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("add item "))
			{
				animator.SetBool("Body_Extra", true);
				DialogueManager.Bark("ReceiveHit", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.EJHDHCNILDH().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark(" ", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(1059f, 1400f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(1621f, 160f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("NPCWalkTo is null in NPCRoutine. Make sure the routine ");
			PPDOHKHDECO = Time.time + Random.Range(527f, 260f);
		}
	}

	private void EFDMFBKLICB()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"");
		if ((Object)(object)BobNPC.GGFJGHHHEJC != (Object)null)
		{
			BobNPC.BNDNMBGJEKP().content.SetActive(false);
			((Component)BobNPC.DFJGHOHPPEL()).transform.position = new Vector3(1527f, 901f, 550f);
			BobNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("BaseCamp", false);
		}
		else
		{
			animator.SetBool("ConnectionTimeout", false);
		}
	}

	private void MFGANCCJFJK()
	{
		PPDOHKHDECO = Time.time + Random.Range(1555f, 650f);
		EBFHLIJCFOF = Time.time + Random.Range(97f, 1436f);
		IHLKIFCILAB();
	}

	private void IMIONHLAKIH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NOPELPNCLEG));
	}

	private void OnEnable()
	{
		LLKNDOPBOIC();
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(NOPELPNCLEG));
		}
	}

	private void OJLGOCFKLJE()
	{
		CFLOBLOGMHH();
	}

	private void DHCAFNPNEPC()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Intro07");
		if ((Object)(object)BobNPC.DFJGHOHPPEL() != (Object)null)
		{
			BobNPC.OPDKAPNDBJE().content.SetActive(false);
			((Component)BobNPC.DFJGHOHPPEL()).transform.position = new Vector3(440f, 1339f, 990f);
			BobNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("SelectedNotFocused", true);
		}
		else
		{
			animator.SetBool("Cannot place mine block piece at ", false);
		}
	}

	private void MMPMJNAFKHC()
	{
		if (WorldTime.EDIPJBOOEHD > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 979f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool(" </mark>"))
			{
				animator.SetBool("Items/item_description_730", true);
				DialogueManager.Bark("itemColiflowerSeeds", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.BNDNMBGJEKP().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark(":</color> ", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(1836f, 821f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(638f, 1486f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("EditorAction_");
			PPDOHKHDECO = Time.time + Random.Range(1315f, 340f);
		}
	}

	private void KJHKBGDJNDC()
	{
		PPDOHKHDECO = Time.time + Random.Range(1402f, 1624f);
		EBFHLIJCFOF = Time.time + Random.Range(438f, 1073f);
		NOPELPNCLEG();
	}

	private void MNFJELNEGPG()
	{
		if (WorldTime.NJECJAHEOIA() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.GBCKNDKCFFF() < 1571f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("AimDirection"))
			{
				animator.SetBool("ReceiveSetVitamins", true);
				DialogueManager.Bark("Bomb", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.BNDNMBGJEKP().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark("replay banquet", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(399f, 1521f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(129f, 1981f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("Dialogue System/Conversation/Gass_Introduce/Entry/22/Dialogue Text");
			PPDOHKHDECO = Time.time + Random.Range(1796f, 1888f);
		}
	}

	private void CIIBBCPIOIP()
	{
		DHCAFNPNEPC();
	}

	private void FNFNLFOJHHA()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(CFLOBLOGMHH));
		}
	}

	private void EBNENBFLEKB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(DHCAFNPNEPC));
	}

	private void OCIHCODJBGC()
	{
		NOPELPNCLEG();
	}

	private void Awake()
	{
		PPDOHKHDECO = Time.time + Random.Range(20f, 40f);
		EBFHLIJCFOF = Time.time + Random.Range(30f, 80f);
		LLKNDOPBOIC();
	}

	private void HDHPOAPLEJC()
	{
		PPDOHKHDECO = Time.time + Random.Range(725f, 430f);
		EBFHLIJCFOF = Time.time + Random.Range(1141f, 1949f);
		LLKNDOPBOIC();
	}

	private void GKCKLIAANHA()
	{
		MKJOPONOAPN();
	}

	private void EBOAPBLKAEN()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Cat");
		if ((Object)(object)BobNPC.GGFJGHHHEJC != (Object)null)
		{
			BobNPC.LDBJELPPBAI().content.SetActive(true);
			((Component)BobNPC.BNDNMBGJEKP()).transform.position = new Vector3(1883f, 1482f, 688f);
			BobNPC.EJHDHCNILDH().animationBase.SetDirection(Direction.Up);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("[MinePuzzleManager] No more puzzle types to try for level {0}.", false);
		}
		else
		{
			animator.SetBool("BeginChatFade", true);
		}
	}

	private void JPHFCJIBBMI()
	{
		if (WorldTime.EDIPJBOOEHD > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1870f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("levelRequired"))
			{
				animator.SetBool("BuildMode", false);
				DialogueManager.Bark(")", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.EJHDHCNILDH().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark(")", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(834f, 551f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(1705f, 551f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("Occupied Positions");
			PPDOHKHDECO = Time.time + Random.Range(1954f, 683f);
		}
	}

	private void GDDKLHFPAMO()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"A very important guest is visiting!");
		if ((Object)(object)BobNPC.OFLELHKKNKC() != (Object)null)
		{
			BobNPC.POINNCPMEIG().content.SetActive(false);
			((Component)BobNPC.POINNCPMEIG()).transform.position = new Vector3(1801f, 1049f, 1827f);
			BobNPC.DFJGHOHPPEL().animationBase.SetDirection(Direction.Up);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("KickedSpinDirection", false);
		}
		else
		{
			animator.SetBool("0.#", false);
		}
	}

	private void KDBJHCAEGCM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(EFDMFBKLICB));
	}

	private void IHLKIFCILAB()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Flight");
		if ((Object)(object)BobNPC.LDBJELPPBAI() != (Object)null)
		{
			BobNPC.GGFJGHHHEJC.content.SetActive(false);
			((Component)BobNPC.GGFJGHHHEJC).transform.position = new Vector3(638f, 739f, 288f);
			BobNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("popUpBuilding5", true);
		}
		else
		{
			animator.SetBool("chatSounds", false);
		}
	}

	private void HEGNINLLINP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IHLKIFCILAB));
		}
	}

	private void PENOGEJIOMN()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Items/item_name_1121");
		if ((Object)(object)BobNPC.LDBJELPPBAI() != (Object)null)
		{
			BobNPC.GGFJGHHHEJC.content.SetActive(true);
			((Component)BobNPC.GGFJGHHHEJC).transform.position = new Vector3(1431f, 123f, 1638f);
			BobNPC.POINNCPMEIG().animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("", true);
		}
		else
		{
			animator.SetBool("Items/item_name_1182", true);
		}
	}

	private void CFLOBLOGMHH()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"MineObstacleBark2");
		if ((Object)(object)BobNPC.EJHDHCNILDH() != (Object)null)
		{
			BobNPC.POINNCPMEIG().content.SetActive(false);
			((Component)BobNPC.BNDNMBGJEKP()).transform.position = new Vector3(1158f, 674f, 1114f);
			BobNPC.EJHDHCNILDH().animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("CutSceneMode", false);
		}
		else
		{
			animator.SetBool("Random", true);
		}
	}

	private void Update()
	{
		if (WorldTime.EDIPJBOOEHD > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 4f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("Sleep"))
			{
				animator.SetBool("Sleep", true);
				DialogueManager.Bark("Farm/Bob/Barks_Close", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.GGFJGHHHEJC.inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark("Farm/Bob/Barks_Random", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(30f, 80f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(30f, 80f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("Action");
			PPDOHKHDECO = Time.time + Random.Range(20f, 40f);
		}
	}

	private void FOACHHBCOIC()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Hikari/Barks_Intro");
		if ((Object)(object)BobNPC.BNDNMBGJEKP() != (Object)null)
		{
			BobNPC.POINNCPMEIG().content.SetActive(false);
			((Component)BobNPC.GGFJGHHHEJC).transform.position = new Vector3(1441f, 1018f, 259f);
			BobNPC.DFJGHOHPPEL().animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("ReceiveSkipTypewriter", true);
		}
		else
		{
			animator.SetBool("UIPreviousPage", false);
		}
	}

	private void DMFMNEMDFNP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(CFLOBLOGMHH));
	}

	private void NOPELPNCLEG()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Items/item_name_1039");
		if ((Object)(object)BobNPC.POINNCPMEIG() != (Object)null)
		{
			BobNPC.DFJGHOHPPEL().content.SetActive(true);
			((Component)BobNPC.BNDNMBGJEKP()).transform.position = new Vector3(1939f, 1115f, 437f);
			BobNPC.OFLELHKKNKC().animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("questNameMalting", true);
		}
		else
		{
			animator.SetBool("HouseKeeperDescription", true);
		}
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(LLKNDOPBOIC));
		}
	}

	private void AAEAAEBBFKG()
	{
		PPDOHKHDECO = Time.time + Random.Range(1025f, 881f);
		EBFHLIJCFOF = Time.time + Random.Range(1123f, 1645f);
		EFDMFBKLICB();
	}

	private void PMPLNGEAAII()
	{
		if (WorldTime.GBCKNDKCFFF() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 769f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("]"))
			{
				animator.SetBool("Items/item_name_599", false);
				DialogueManager.Bark("", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.EJHDHCNILDH().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark("UpgradeToLevel", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(1361f, 299f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(956f, 190f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger(" not found to load surface over him ");
			PPDOHKHDECO = Time.time + Random.Range(227f, 291f);
		}
	}

	private void IJMBEEEGCGF()
	{
		EBOAPBLKAEN();
	}

	private void MKJOPONOAPN()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Player2");
		if ((Object)(object)BobNPC.EJHDHCNILDH() != (Object)null)
		{
			BobNPC.EJHDHCNILDH().content.SetActive(true);
			((Component)BobNPC.LDBJELPPBAI()).transform.position = new Vector3(1477f, 901f, 424f);
			BobNPC.OFLELHKKNKC().animationBase.SetDirection(Direction.Up);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("Items/item_name_1031", false);
		}
		else
		{
			animator.SetBool("City/Bruce/Stand", false);
		}
	}

	private void IBAPBHIBOOO()
	{
		if (WorldTime.DHPFCKNGHLO() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 1573f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("Open"))
			{
				animator.SetBool("Fortitude/MainEvent 3", true);
				DialogueManager.Bark("Items/item_name_687", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.POINNCPMEIG().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark(" ", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(459f, 1352f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(661f, 620f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("HarvestCut2");
			PPDOHKHDECO = Time.time + Random.Range(1875f, 840f);
		}
	}

	private void ELHCBGCEJDH()
	{
		if (WorldTime.BBBGEBIPHPI() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1334f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("Dialogue System/Conversation/CalmRowdyCustomer/Entry/1/Dialogue Text"))
			{
				animator.SetBool("ReceiveSetDirection", false);
				DialogueManager.Bark(", ", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.OFLELHKKNKC().inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark("Target frame rate (", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(54f, 85f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(169f, 418f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("Read");
			PPDOHKHDECO = Time.time + Random.Range(1553f, 6f);
		}
	}

	private void LALJNGFGKPA()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FOACHHBCOIC));
		}
	}

	private void HHHEACKHADN()
	{
		CFLOBLOGMHH();
	}

	private void LLKNDOPBOIC()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"BobAnimation SetSleep");
		if ((Object)(object)BobNPC.GGFJGHHHEJC != (Object)null)
		{
			BobNPC.GGFJGHHHEJC.content.SetActive(true);
			((Component)BobNPC.GGFJGHHHEJC).transform.position = new Vector3(-163.833f, 398.3958f, 0f);
			BobNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		}
		if (WorldTime.isNight)
		{
			animator.SetBool("Sleep", true);
		}
		else
		{
			animator.SetBool("Sleep", false);
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(LLKNDOPBOIC));
		}
	}

	private void JOGBCDIAGEK()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(CFLOBLOGMHH));
		}
	}

	private void KPILPDFCHBG()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(LLKNDOPBOIC));
		}
	}

	private void COKBJNMAMDI()
	{
		PPDOHKHDECO = Time.time + Random.Range(778f, 519f);
		EBFHLIJCFOF = Time.time + Random.Range(1805f, 1395f);
		EBOAPBLKAEN();
	}

	private void CEIIFHIBIFI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(GDDKLHFPAMO));
	}

	private void GBNHKMLABGI()
	{
		FOACHHBCOIC();
	}

	private void FOHGHCPODBJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DHCAFNPNEPC));
	}

	private void PJOAFKEIPPD()
	{
		DHCAFNPNEPC();
	}

	private void GHEHLJANBCF()
	{
		if (WorldTime.DHPFCKNGHLO() > MDAGAAGGFGE * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.GBCKNDKCFFF() < 1168f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!animator.GetBool("Hovel"))
			{
				animator.SetBool("[SelectSpawnersByMaxDistance] entrance:{0} altar:{1} exit:{2}. Need {3} from {4} candidates.", true);
				DialogueManager.Bark("LE_8", ((Component)this).transform);
			}
			return;
		}
		if (!BobNPC.GGFJGHHHEJC.inUseBob)
		{
			if (Time.time >= EBFHLIJCFOF)
			{
				DialogueManager.Bark("UIBack", ((Component)this).transform);
				EBFHLIJCFOF = Time.time + Random.Range(1358f, 1853f);
			}
			EBFHLIJCFOF = Time.time + Random.Range(1654f, 740f);
		}
		if (Time.time >= PPDOHKHDECO)
		{
			animator.SetTrigger("");
			PPDOHKHDECO = Time.time + Random.Range(1964f, 608f);
		}
	}

	private void HINKPJCNPCF()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(PENOGEJIOMN));
		}
	}

	private void GNGADDPBJDC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(EBOAPBLKAEN));
	}

	private void PNLAJCHBHPH()
	{
		PPDOHKHDECO = Time.time + Random.Range(1217f, 1223f);
		EBFHLIJCFOF = Time.time + Random.Range(1668f, 103f);
		NOPELPNCLEG();
	}

	private void BLAJFMAAMDO()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(CGEEKEMKJOL));
		}
	}

	private void JIAJFDKNJME()
	{
		PPDOHKHDECO = Time.time + Random.Range(1432f, 1996f);
		EBFHLIJCFOF = Time.time + Random.Range(932f, 791f);
		CGEEKEMKJOL();
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CFLOBLOGMHH));
		}
	}
}
