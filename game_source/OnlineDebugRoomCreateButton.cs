using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OnlineDebugRoomCreateButton : MonoBehaviour
{
	public static Action RoomDeselected = delegate
	{
	};

	[SerializeField]
	private Image image;

	[SerializeField]
	private TMP_Text TMPtext;

	private Color LHJGDDEPLAD = Color.green;

	private Color PLDCIMMLDDF = Color.white;

	private Color NDAPEEJCNNJ = Color.yellow;

	private Color NLABLFFLKDA = Color.red;

	private void AKLDNCKAIFA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OAGFKCDLGOB("Create Private Room", PLDCIMMLDDF);
	}

	private void IIPDDONEOFG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OMFICCKKDNA(")", PLDCIMMLDDF);
	}

	private void NMKGOAJLMDG()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void KFKPNLDIEMB()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != 0 && OnlineManager.LICCAGGNELA != 0)
		{
			Debug.LogError((object)"ReceiveServeCustomerOrder");
			return;
		}
		OnlineManager.SetRoomMode(RoomMode.CreatePublicRoom, CHPMIAFLJKD: true);
		JMIHMOEBBAN("Listen", NDAPEEJCNNJ);
	}

	private void OAGFKCDLGOB(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		((Graphic)image).color = LDENFDNIKPI;
	}

	private void PJJHEEIMNBP(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PNPPCHACBIC("", PLDCIMMLDDF);
	}

	private void GONDLJKGLGO()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void KPILPDFCHBG()
	{
		if (Debug.isDebugBuild)
		{
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Remove(OnlineManager.OnRoomCreateFailed, new Action<string>(PJJHEEIMNBP));
		}
	}

	private void JCMPLNGCJEN(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KFBEGEBEFGH("AdjustingGraphicsQuality", PLDCIMMLDDF);
	}

	private void HBMDEHPHAPF()
	{
		if (Debug.isDebugBuild)
		{
			ABHKCEOMAEC();
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Combine(OnlineManager.OnRoomCreateFailed, new Action<string>(PJJHEEIMNBP));
		}
	}

	private void MFGANCCJFJK()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void FHOCCEBKHJI()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void EJIAOGPOLAP(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PNPPCHACBIC("ItemInstance is not valid.", PLDCIMMLDDF);
	}

	private void Start()
	{
		if (Debug.isDebugBuild)
		{
			AKLDNCKAIFA();
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Combine(OnlineManager.OnRoomCreateFailed, new Action<string>(HMKIMEAFMLC));
		}
	}

	private void PNPPCHACBIC(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		((Graphic)image).color = LDENFDNIKPI;
	}

	public void IPMFHNDCMJI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.ConnectedToMaster && OnlineManager.LICCAGGNELA != NetworkState.JoinOrCreateRoom)
		{
			Debug.LogError((object)"LE_11");
			return;
		}
		OnlineManager.SetRoomMode(RoomMode.JoinPrivateRoom);
		PNPPCHACBIC("cloudy", NDAPEEJCNNJ);
	}

	private void GJMLHECPGBP()
	{
		if (Debug.isDebugBuild)
		{
			AKLDNCKAIFA();
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Combine(OnlineManager.OnRoomCreateFailed, new Action<string>(HDFLEPAABNF));
		}
	}

	private void CKAIBFPDHOP(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		JMIHMOEBBAN("Interact", PLDCIMMLDDF);
	}

	private void HDFLEPAABNF(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PNPPCHACBIC("ClosePopUp", PLDCIMMLDDF);
	}

	private void INPKNMLEEKP(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PNPPCHACBIC("UIAddRemove", PLDCIMMLDDF);
	}

	private void AKJBHNPNGBI(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PNPPCHACBIC(" ", PLDCIMMLDDF);
	}

	private void BNAAAMJAPHD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OAGFKCDLGOB("pirate", PLDCIMMLDDF);
	}

	private void OMFICCKKDNA(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		((Graphic)image).color = LDENFDNIKPI;
	}

	private void DJHIDPGJFIN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KFBEGEBEFGH("Prices", PLDCIMMLDDF);
	}

	public void CPCGCOKFMMH()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.ConnectedToMaster && OnlineManager.LICCAGGNELA != NetworkState.WaitingForFileSelect)
		{
			Debug.LogError((object)"");
			return;
		}
		OnlineManager.SetRoomMode(RoomMode.None, CHPMIAFLJKD: true);
		KFBEGEBEFGH("Content", NDAPEEJCNNJ);
	}

	private void OEAAPIBLALL()
	{
		if (Debug.isDebugBuild)
		{
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Remove(OnlineManager.OnRoomCreateFailed, new Action<string>(AKJBHNPNGBI));
		}
	}

	public void KCIDELFPKDG()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.WaitingForRoomSelect && OnlineManager.LICCAGGNELA != NetworkState.ConnectingToLobby)
		{
			Debug.LogError((object)"Items/item_name_625");
			return;
		}
		OnlineManager.SetRoomMode((RoomMode)6);
		OMFICCKKDNA("<color=#A87700>", NDAPEEJCNNJ);
	}

	private void KCJANHKLKFC(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KFBEGEBEFGH("A very important guest is visiting!", PLDCIMMLDDF);
	}

	public void ButtonPressed()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.WaitingForRoomSelect && OnlineManager.LICCAGGNELA != NetworkState.WaitingForFileSelect)
		{
			Debug.LogError((object)"Can't select unless we're connected.");
			return;
		}
		OnlineManager.SetRoomMode(RoomMode.CreatePrivateRoom);
		OAGFKCDLGOB("Trying to create room...", NDAPEEJCNNJ);
	}

	private void Awake()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void EOGHJNGJFID()
	{
		if (Debug.isDebugBuild)
		{
			AKLDNCKAIFA();
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Combine(OnlineManager.OnRoomCreateFailed, new Action<string>(INPKNMLEEKP));
		}
	}

	private void EIDJLHFAMIB()
	{
		if (Debug.isDebugBuild)
		{
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Remove(OnlineManager.OnRoomCreateFailed, new Action<string>(OEAKAIHLKJC));
		}
	}

	public void GIEGCODIGDF()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.ConnectingToLobby && OnlineManager.LICCAGGNELA != NetworkState.ConnectingToMaster)
		{
			Debug.LogError((object)"LE_10");
			return;
		}
		OnlineManager.SetRoomMode(RoomMode.None);
		KFBEGEBEFGH("Christmas/Ace/Intro", NDAPEEJCNNJ);
	}

	private void OMBHDODDHNO()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void HPJBLOPJIMI()
	{
		if (!Debug.isDebugBuild)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void NCECJCELOBH(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OMFICCKKDNA("Crouch", PLDCIMMLDDF);
	}

	private void CFHOODNCOLK()
	{
		if (Debug.isDebugBuild)
		{
			ABHKCEOMAEC();
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Combine(OnlineManager.OnRoomCreateFailed, new Action<string>(HMKIMEAFMLC));
		}
	}

	private void OEAKAIHLKJC(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KFBEGEBEFGH("BathhouseEntrace/Main 2", PLDCIMMLDDF);
	}

	private void JMIHMOEBBAN(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		((Graphic)image).color = LDENFDNIKPI;
	}

	private void JMAKAAEMDDE(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OAGFKCDLGOB("k", PLDCIMMLDDF);
	}

	private void EJNIGJBDAJL(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OMFICCKKDNA("Quarry", PLDCIMMLDDF);
	}

	private void KFBEGEBEFGH(string HKOOGEKDEGK, Color LDENFDNIKPI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TMPtext.text = HKOOGEKDEGK;
		((Graphic)image).color = LDENFDNIKPI;
	}

	private void HCEDMLJNOBL()
	{
		if (Debug.isDebugBuild)
		{
			DJHIDPGJFIN();
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Combine(OnlineManager.OnRoomCreateFailed, new Action<string>(EJIAOGPOLAP));
		}
	}

	private void CNGGCFNFPLD(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PNPPCHACBIC("Player/Bark/Tutorial/T137", PLDCIMMLDDF);
	}

	private void OnDestroy()
	{
		if (Debug.isDebugBuild)
		{
			OnlineManager.OnRoomCreateFailed = (Action<string>)Delegate.Remove(OnlineManager.OnRoomCreateFailed, new Action<string>(HMKIMEAFMLC));
		}
	}

	private void ABHKCEOMAEC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		JMIHMOEBBAN("Sending mine loaded for client ", PLDCIMMLDDF);
	}

	private void HMKIMEAFMLC(string DCHFMNKMCJA)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OAGFKCDLGOB("Create Private Room", PLDCIMMLDDF);
	}
}
