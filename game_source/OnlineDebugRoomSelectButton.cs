using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OnlineDebugRoomSelectButton : MonoBehaviour
{
	public static Action RoomDeselected = delegate
	{
	};

	[SerializeField]
	private Image image;

	[SerializeField]
	private TMP_Text TMPtext;

	private Button HLIPBBONOAH;

	private Color LHJGDDEPLAD = Color.green;

	private Color PLDCIMMLDDF = Color.white;

	private Color NDAPEEJCNNJ = Color.yellow;

	private Color NLABLFFLKDA = Color.red;

	public int roomIndex = -1;

	private string JJDHDJPMFJE = "";

	private void HFAHDKLODEJ(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void CFABBMEKIFF()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("Precision/DrinkEvent6", roomIndex, OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format("ReceivePlaceCharges", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.SelectRoom(-1);
			Debug.Log((object)string.Format("Items/item_name_692", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
			{
				CMHFLEHJFIK(string.Format("FindSeat Corroutine", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 7), LHJGDDEPLAD);
			}
			else
			{
				KICAGFIKMMP("descWardrobe", LHJGDDEPLAD);
			}
		}
	}

	private void DOHLOJOIHFO()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(FIFPHHMPCMG));
			BLHOGIKHDLM();
		}
	}

	private void BMEGJEPHLCL(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void OHMMHONIGGE()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"ReceiveIntroNinjaChallengeEventMoveZuzzu", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			DAGPFNECMOI(string.Format("</color>", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 6), NDAPEEJCNNJ);
		}
		else
		{
			EMKDAJGIEED("Wall", PLDCIMMLDDF);
		}
	}

	private void LJLKBKEADGI()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(MEIBNDFJGFB));
			GBLKMOFNJKM();
		}
	}

	public void PNPBFOHFFKN()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.JoinOrCreateRoom && OnlineManager.LICCAGGNELA != 0)
		{
			Debug.LogError((object)"");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.SelectRoomByName(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
		{
			DAGPFNECMOI(string.Format(" (", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 6), LHJGDDEPLAD);
		}
		else
		{
			CNDLHKEPIHK("[Player2Name]", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().LFOMNDEDJLI();
	}

	private void KLMDKEPDLDC()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"[WaiterGender=", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			DHOCPJLJFFK(string.Format(" OnCharacterAppearanceChanged", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 6), NDAPEEJCNNJ);
		}
		else
		{
			CMHFLEHJFIK("KyrohPreparingFood: Other player has advantage, going to WaitingToServe.", PLDCIMMLDDF);
		}
	}

	private void CNDLHKEPIHK(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void Awake()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	public void NNPGPJEFFCG()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.SettingUpInviteCode && OnlineManager.LICCAGGNELA != NetworkState.ConnectingToMaster)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_Standar/Entry/20/Dialogue Text");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.SelectRoomByName(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			CMHFLEHJFIK(string.Format("- ", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 2), LHJGDDEPLAD);
		}
		else
		{
			OAGFKCDLGOB("LE_10", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().PFLCAMPHJLL();
	}

	private void ICFHPJHBPDN()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(JOGJBJHJMBI));
			GBLKMOFNJKM();
		}
	}

	private void BFJOEMCBJJO()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	public void ButtonPressed()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.WaitingForRoomSelect && OnlineManager.LICCAGGNELA != NetworkState.WaitingForFileSelect)
		{
			Debug.LogError((object)"Can't select unless we're connected.");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.SelectRoomByName(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			OAGFKCDLGOB($"{JJDHDJPMFJE}\nPlayers: {OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount}/{4}", LHJGDDEPLAD);
		}
		else
		{
			OAGFKCDLGOB("Create Public Room", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().ButtonStart();
	}

	private void BGODNKBOFAG()
	{
		PGCGPBCJOLF();
	}

	private void FILPILBECGM(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void CJOJOLCBIOH()
	{
		DJHIDPGJFIN();
	}

	private void EFJFJJDGGGI()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void PKFMLJGJKCP()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(LMPGAPIICFN));
		}
	}

	private void EBGJCNDLCEO(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void EGGKFLCPFMN()
	{
		KCHPFJLKEAF();
	}

	private void NMFLCKFGMKM(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void LMPGAPIICFN()
	{
		BLHOGIKHDLM();
	}

	private void OHKIOLCEMLM()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(CDEBEKFOBGG));
		}
	}

	private void LDLBMMMLEDJ()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void DIBBPCIPPNC()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Disconnected", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.KKDHENOLCEE().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			BPIICJDPBBL(string.Format("Level", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 8), NDAPEEJCNNJ);
		}
		else
		{
			FJDKHOGEACP("Year", PLDCIMMLDDF);
		}
	}

	private void GBFPCABGAII()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(BGODNKBOFAG));
			AKLDNCKAIFA();
		}
	}

	private void MJPPKMPJBGJ()
	{
		GBLKMOFNJKM();
	}

	private void HCCJBKKGCLJ()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void HKKDEKIFPPJ()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(PNHDDOKJEFE));
			MHIGDJAJMEJ();
		}
	}

	private void FJDKHOGEACP(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void BDGCFCPFKKE()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(DODLMFPDHLK));
			MPCDJGCOJLE();
		}
	}

	private void IBMDFNKKPJF()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void DCLAALFHEHG()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("levelRequired", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format("ReceiveBarkInfo", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("TooDark", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
			{
				DHOCPJLJFFK(string.Format("BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent.", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 8), LHJGDDEPLAD);
			}
			else
			{
				BMEGJEPHLCL("Dialogue System/Conversation/Crowly_Introduce/Entry/12/Dialogue Text", LHJGDDEPLAD);
			}
		}
	}

	private void CLGBFOIBANN()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void NPMLFHDHJBE()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(AAMKCFGIBAO));
			CCCHJGNCJNM();
		}
	}

	private void OnDestroy()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(MEIBNDFJGFB));
		}
	}

	private void KJPECNGCOKK()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void FBHHPNJGNJG()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void CEHKCBKBPGH()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("Reputation", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.FLJONLAPBFD)
		{
			Debug.Log((object)string.Format("itemMaltedBarley", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("ZuzzuProgress", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
			{
				HFAHDKLODEJ(string.Format("", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 3), LHJGDDEPLAD);
			}
			else
			{
				EMKDAJGIEED("Unique crop not found! Unique ID: ", LHJGDDEPLAD);
			}
		}
	}

	private void LADLGPKMPBP()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(EGGKFLCPFMN));
		}
	}

	private void DKHCENIGLGP()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			DHOCPJLJFFK(string.Format("cinemachine empty", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 4), NDAPEEJCNNJ);
		}
		else
		{
			OAGFKCDLGOB("Moving", PLDCIMMLDDF);
		}
	}

	public void LGGGONANENF()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.ConnectedToLobby && OnlineManager.LICCAGGNELA != NetworkState.WaitingForFileSelect)
		{
			Debug.LogError((object)"LE_9");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.GKENIBKCBBG(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JNAHBGDOMKO(string.Format("Hit", JJDHDJPMFJE, OnlineManager.INHKLMPJLJM()[roomIndex].PlayerCount, 5), LHJGDDEPLAD);
		}
		else
		{
			NINALAIJBOP("Tavern must be closed", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().LFOMNDEDJLI();
	}

	private void MEIBNDFJGFB()
	{
		AKLDNCKAIFA();
	}

	private void LDMFCMLEKMG()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"ReceiveBeginFishCuttingMinigame", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.KKDHENOLCEE().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			GMDNLHPOFDF(string.Format("", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 3), NDAPEEJCNNJ);
		}
		else
		{
			EMKDAJGIEED("CharacterChanged", PLDCIMMLDDF);
		}
	}

	private void CDEBEKFOBGG()
	{
		LDMFCMLEKMG();
	}

	private void GBLKMOFNJKM()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"TimeLeft", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			EBGJCNDLCEO(string.Format("Items/item_description_661", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 8), NDAPEEJCNNJ);
		}
		else
		{
			OAGFKCDLGOB("]", PLDCIMMLDDF);
		}
	}

	private void JOGJBJHJMBI()
	{
		DOFPPNINAPK();
	}

	private void ACNFFDGDAHF()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)" ", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			GMDNLHPOFDF(string.Format("Forward", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 2), NDAPEEJCNNJ);
		}
		else
		{
			NMFLCKFGMKM("Quit to desktop?", PLDCIMMLDDF);
		}
	}

	private void LANGHIOBJIH()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(GIOBBOKEPNJ));
			ACNFFDGDAHF();
		}
	}

	private void GHDBHNMOBMN()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(LMPGAPIICFN));
		}
	}

	private void KHCJDKHONPK()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void DNGAGGAIDKI(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void KBNMLJNBBMP()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void CCCHJGNCJNM()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"questNameCraftingRoom", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			FJDKHOGEACP(string.Format("Player", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 0), NDAPEEJCNNJ);
		}
		else
		{
			BPIICJDPBBL("Sprinting is now FASTER.", PLDCIMMLDDF);
		}
	}

	private void GMDNLHPOFDF(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	public void NAHPFFEFHIL()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != 0 && OnlineManager.LICCAGGNELA != NetworkState.ConnectingToLobby)
		{
			Debug.LogError((object)"Locked");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.SelectRoomByName(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			FILPILBECGM(string.Format("New Save", JJDHDJPMFJE, OnlineManager.INHKLMPJLJM()[roomIndex].PlayerCount, 0), LHJGDDEPLAD);
		}
		else
		{
			DNGAGGAIDKI("Object with itemID ", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().PFLCAMPHJLL();
	}

	private void FBIJCKJLKGM()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("Parent tech not learnt", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format("LE_14", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.SelectRoom(-1);
			Debug.Log((object)string.Format(",", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
			{
				EGJOLPKENMK(string.Format("\n<color=#822F00>", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 1), LHJGDDEPLAD);
			}
			else
			{
				BPIICJDPBBL("talentPale", LHJGDDEPLAD);
			}
		}
	}

	private void MHIGDJAJMEJ()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Items/item_name_698", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			DAGPFNECMOI(string.Format("MainProgress", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 7), NDAPEEJCNNJ);
		}
		else
		{
			DAGPFNECMOI("ObjectHorizontalMove", PLDCIMMLDDF);
		}
	}

	private void JMGEPFGKPJE()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"ReceiveAddRentedRoomSaleAndAddPrice", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			JNAHBGDOMKO(string.Format("ReceiveAdoptionSignal", JJDHDJPMFJE, OnlineManager.INHKLMPJLJM()[roomIndex].PlayerCount, 0), NDAPEEJCNNJ);
		}
		else
		{
			NMFLCKFGMKM("/", PLDCIMMLDDF);
		}
	}

	private void KICAGFIKMMP(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void PNHDDOKJEFE()
	{
		KLMDKEPDLDC();
	}

	public void IGHAINAKALE()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.JoinOrCreateRoom && OnlineManager.LICCAGGNELA != NetworkState.ConnectingToMaster)
		{
			Debug.LogError((object)"Player");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.GKENIBKCBBG(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.KKDHENOLCEE().Count)
		{
			DHOCPJLJFFK(string.Format("Initializing GalaxyPeer instance...", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 6), LHJGDDEPLAD);
		}
		else
		{
			OAGFKCDLGOB("Steam Initialized: False", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().LFOMNDEDJLI();
	}

	private void KLMNLEDKEOE()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void GHBPAHMBAHO()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Down Arrow", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			DNGAGGAIDKI(string.Format("\n", JJDHDJPMFJE, OnlineManager.INHKLMPJLJM()[roomIndex].PlayerCount, 5), NDAPEEJCNNJ);
		}
		else
		{
			EMKDAJGIEED("ReceiveFishCuttingEventThrowScene", PLDCIMMLDDF);
		}
	}

	private void EACIGGOOKGD()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(JOGJBJHJMBI));
			DKHCENIGLGP();
		}
	}

	private void DODLMFPDHLK()
	{
		ACNFFDGDAHF();
	}

	private void NCDBCDJKPLA()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(DODLMFPDHLK));
		}
	}

	private void AAMKCFGIBAO()
	{
		PGCGPBCJOLF();
	}

	private void ALEAOANPHIO()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void HOHEIHPCKGI()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("Workbench", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.FLJONLAPBFD)
		{
			Debug.Log((object)string.Format("resolution", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("NO SOUNDTRACK LOADED\n\n Troubleshooting:\n\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in your Project window onto the PsaiPlayerUi component.\n\nPlease see the log output window for more information.", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
			{
				FILPILBECGM(string.Format("Intro17", JJDHDJPMFJE, OnlineManager.INHKLMPJLJM()[roomIndex].PlayerCount, 6), LHJGDDEPLAD);
			}
			else
			{
				DNGAGGAIDKI("Next double result: ", LHJGDDEPLAD);
			}
		}
	}

	private void FPDPAJHNGHK()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(MEIBNDFJGFB));
			JMGEPFGKPJE();
		}
	}

	private void FIFPHHMPCMG()
	{
		DKHCENIGLGP();
	}

	private void DOFPPNINAPK()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"RaraAvisDelivered", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.KKDHENOLCEE().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			NMFLCKFGMKM(string.Format("RentingRooms", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 7), NDAPEEJCNNJ);
		}
		else
		{
			NMFLCKFGMKM("Dog", PLDCIMMLDDF);
		}
	}

	private void DAGPFNECMOI(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void HFPDNCBLNDE()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void OAGFKCDLGOB(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void COKIIEBCCME()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format(" : 00", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.FLJONLAPBFD)
		{
			Debug.Log((object)string.Format("ReceivePlayerDisconnected", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("Dialogue System/Conversation/BirdNegativeComments/Entry/5/Dialogue Text", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.KKDHENOLCEE().Count)
			{
				DNGAGGAIDKI(string.Format("HollyAnimalShop", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 5), LHJGDDEPLAD);
			}
			else
			{
				EMKDAJGIEED("Player", LHJGDDEPLAD);
			}
		}
	}

	private void DHOCPJLJFFK(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void MFGANCCJFJK()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void Start()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(MEIBNDFJGFB));
			AKLDNCKAIFA();
		}
	}

	private void MPCDJGCOJLE()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"{0} doesn't have a parameter with that hash.", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			BPIICJDPBBL(string.Format("Exit build mode", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 1), NDAPEEJCNNJ);
		}
		else
		{
			FJDKHOGEACP("Items/item_description_1118", PLDCIMMLDDF);
		}
	}

	private void KJOJLHCDFPP()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(GIOBBOKEPNJ));
			ACNFFDGDAHF();
		}
	}

	private void EMKDAJGIEED(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void JAOGJFOGOIO()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"{0} doesn't have a parameter with that hash.", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			KICAGFIKMMP(string.Format("Normal", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 6), NDAPEEJCNNJ);
		}
		else
		{
			NINALAIJBOP("GetKicked", PLDCIMMLDDF);
		}
	}

	private void JNAHBGDOMKO(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void BKENPIGHGGB()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("itemBellPepperSeeds", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format("Food", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.SelectRoom(-1);
			Debug.Log((object)string.Format("</color> to inventory?", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
			{
				CMHFLEHJFIK(string.Format(" SceneLoaded: ", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 2), LHJGDDEPLAD);
			}
			else
			{
				EGJOLPKENMK("questNameBoiling", LHJGDDEPLAD);
			}
		}
	}

	private void PGCGPBCJOLF()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Player/Bark/Tutorial/AgingBarrelBlock", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			EBGJCNDLCEO(string.Format("itemCactus", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 3), NDAPEEJCNNJ);
		}
		else
		{
			OAGFKCDLGOB("ClosePopUp", PLDCIMMLDDF);
		}
	}

	private void KCHPFJLKEAF()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Giving Quest 35", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			BMEGJEPHLCL(string.Format("Right Trigger", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 2), NDAPEEJCNNJ);
		}
		else
		{
			EMKDAJGIEED("ReceiveShopInfoLoad", PLDCIMMLDDF);
		}
	}

	private void CNCOPCBELEA()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("UI2", roomIndex, OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.FLJONLAPBFD)
		{
			Debug.Log((object)string.Format(") recipes locked", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("cleanVerb", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
			{
				KICAGFIKMMP(string.Format("weedsCut", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 8), LHJGDDEPLAD);
			}
			else
			{
				FILPILBECGM("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/6/Dialogue Text", LHJGDDEPLAD);
			}
		}
	}

	private void EGJOLPKENMK(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void MOHDLOLDPFO()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format(": ", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.FLJONLAPBFD)
		{
			Debug.Log((object)string.Format("</color>", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("/ExtraSettings.sd", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
			{
				EMKDAJGIEED(string.Format("", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 2), LHJGDDEPLAD);
			}
			else
			{
				DHOCPJLJFFK("Player2", LHJGDDEPLAD);
			}
		}
	}

	private void BLHOGIKHDLM()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Price sell", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.KKDHENOLCEE().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			EGJOLPKENMK(string.Format("ActionExecutedRPC", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 1), NDAPEEJCNNJ);
		}
		else
		{
			DNGAGGAIDKI(" - ", PLDCIMMLDDF);
		}
	}

	private void KJHKBGDJNDC()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void BPIICJDPBBL(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void IGNEGEOPLOP()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void JNKLKLDGPIK()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("Player2_Bark_2PlayersChest", roomIndex, OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format("Items/item_name_1084", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.SelectRoom(-1);
			Debug.Log((object)string.Format(" not found. Cannot add to surface", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
			{
				CMHFLEHJFIK(string.Format("CheckUniqueBarItems ", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 1), LHJGDDEPLAD);
			}
			else
			{
				OAGFKCDLGOB("Was master: {0}", LHJGDDEPLAD);
			}
		}
	}

	private void CMHFLEHJFIK(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	private void DJHIDPGJFIN()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Letter without ID: ", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			CNDLHKEPIHK(string.Format("SetBoolRPC", JJDHDJPMFJE, OnlineManager.INHKLMPJLJM()[roomIndex].PlayerCount, 4), NDAPEEJCNNJ);
		}
		else
		{
			EGJOLPKENMK("Checking current game language", PLDCIMMLDDF);
		}
	}

	private void BOIGOJGNNAK()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(CDEBEKFOBGG));
			MPCDJGCOJLE();
		}
	}

	private void BJBPHIFNKIF()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(LMPGAPIICFN));
			GBLKMOFNJKM();
		}
	}

	private void ALMMOEPCIMA()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)" (", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			CMHFLEHJFIK(string.Format("Modifiers", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 5), NDAPEEJCNNJ);
		}
		else
		{
			GMDNLHPOFDF("MeadAbbreviation", PLDCIMMLDDF);
		}
	}

	private void GIOBBOKEPNJ()
	{
		OHMMHONIGGE();
	}

	private void DONGKOKMGMM()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(GIOBBOKEPNJ));
		}
	}

	private void HBEBKMNGLBJ()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Remove(RoomDeselected, new Action(DODLMFPDHLK));
		}
	}

	private void PFBADOEOKMF()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format("OnlinePlayer", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format("ClosePopUp", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.SelectRoom(-1);
			Debug.Log((object)string.Format("RyeAleAbbreviation", OnlineManager.FLJONLAPBFD), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
			{
				GMDNLHPOFDF(string.Format("/ExtraSettings.sd", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 2), LHJGDDEPLAD);
			}
			else
			{
				OAGFKCDLGOB("Keg not full", LHJGDDEPLAD);
			}
		}
	}

	private void BNFGHAGJEGG()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		HLIPBBONOAH = ((Component)this).GetComponent<Button>();
	}

	private void NINALAIJBOP(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		if ((Object)(object)image != (Object)null)
		{
			((Graphic)image).color = LDENFDNIKPI;
		}
	}

	public void FPFEPMHABKG()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.ConnectingToLobby && OnlineManager.LICCAGGNELA != NetworkState.JoinOrCreateRoom)
		{
			Debug.LogError((object)"");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.GKENIBKCBBG(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.GPCLIMKHNMJ().Count)
		{
			FILPILBECGM(string.Format("Hikari/Introduce", JJDHDJPMFJE, OnlineManager.GPCLIMKHNMJ()[roomIndex].PlayerCount, 3), LHJGDDEPLAD);
		}
		else
		{
			BMEGJEPHLCL("Check to enable", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().ButtonStart();
	}

	public void CINLGMBNDGG()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.ConnectingToLobby && OnlineManager.LICCAGGNELA != NetworkState.ConnectingToLobby)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/20/Dialogue Text");
			return;
		}
		RoomDeselected?.Invoke();
		OnlineManager.AOEJHJAFPJN(JJDHDJPMFJE);
		if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			OAGFKCDLGOB(string.Format("LE_12", JJDHDJPMFJE, OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount, 2), LHJGDDEPLAD);
		}
		else
		{
			NMFLCKFGMKM("Disabled", LHJGDDEPLAD);
		}
		TitleScreen.GetInstance().LFOMNDEDJLI();
	}

	private void IEFMDMPAHHK()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)string.Format(" (", roomIndex, OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.GGJPONBKEIA())
		{
			Debug.Log((object)string.Format(" ", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.PLBHEDLADJN(-1);
			Debug.Log((object)string.Format("Items/item_name_1176", OnlineManager.GGJPONBKEIA()), (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.INHKLMPJLJM().Count)
			{
				FJDKHOGEACP(string.Format("ReceiveMoneyText", JJDHDJPMFJE, OnlineManager.KKDHENOLCEE()[roomIndex].PlayerCount, 8), LHJGDDEPLAD);
			}
			else
			{
				CMHFLEHJFIK("ReceiveLoadMine", LHJGDDEPLAD);
			}
		}
	}

	private void AKLDNCKAIFA()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (roomIndex == -1)
		{
			Debug.LogError((object)"Button index hasn't been set up properly.", (Object)(object)((Component)this).gameObject);
		}
		else if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
		{
			JJDHDJPMFJE = ((Object)((Component)this).gameObject).name;
			OAGFKCDLGOB($"{JJDHDJPMFJE}\nPlayers: {OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount}/{4}", NDAPEEJCNNJ);
		}
		else
		{
			OAGFKCDLGOB("Create Public Room", PLDCIMMLDDF);
		}
	}

	private void PJCLNGBHKBK()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)$"Room Index: {roomIndex}, Selected Room: {OnlineManager.FLJONLAPBFD}", (Object)(object)((Component)this).gameObject);
		if (roomIndex == OnlineManager.FLJONLAPBFD)
		{
			Debug.Log((object)$"Selected Room: {OnlineManager.FLJONLAPBFD}", (Object)(object)((Component)this).gameObject);
			RoomDeselected?.Invoke();
			OnlineManager.SelectRoom(-1);
			Debug.Log((object)$"Selected Room Reset to: {OnlineManager.FLJONLAPBFD}", (Object)(object)((Component)this).gameObject);
			if (roomIndex < OnlineManager.NOACKKJLLJI.Count)
			{
				OAGFKCDLGOB($"{JJDHDJPMFJE}\nPlayers: {OnlineManager.NOACKKJLLJI[roomIndex].PlayerCount}/{4}", LHJGDDEPLAD);
			}
			else
			{
				OAGFKCDLGOB("Create Public Room", LHJGDDEPLAD);
			}
		}
	}

	private void CFIIEJDJFPB()
	{
		if (Debug.isDebugBuild)
		{
			RoomDeselected = (Action)Delegate.Combine(RoomDeselected, new Action(BGODNKBOFAG));
			JMGEPFGKPJE();
		}
	}
}
