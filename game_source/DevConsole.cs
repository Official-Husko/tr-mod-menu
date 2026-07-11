using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using PixelCrushers.DialogueSystem;
using Sirenix.Utilities;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DevConsole : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LFFGMLCLCHP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DevConsole _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public LFFGMLCLCHP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			DevConsole devConsole = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				devConsole.AIAGEJIAGPF();
				goto IL_0051;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0051;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00a1;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00d3;
			case 4:
				{
					_003C_003E1__state = -1;
					devConsole.StartBathhouse();
					return false;
				}
				IL_0051:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				for (int i = 1; i < 5; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
					{
						PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
					}
				}
				goto IL_00a1;
				IL_00d3:
				if ((Object)(object)BathhouseGameManager.instance == (Object)null)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 4;
				return true;
				IL_00a1:
				if (GameManager.LocalCoop() && FadeCamera.GetPlayer(2).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				BlackFade.Show();
				goto IL_00d3;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class DNJADCEDGAG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DevConsole _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public DNJADCEDGAG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			DevConsole devConsole = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				devConsole.scroll.value = 0f;
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class PDFEEINGPGI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public PDFEEINGPGI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				OnlineMinigameManager.RequestKujakuHouseTeleport();
				_003Ci_003E5__2 = 1;
				goto IL_0081;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0047;
			case 2:
				{
					_003C_003E1__state = -1;
					FishCuttingGameManager.Begin();
					return false;
				}
				IL_0081:
				if (_003Ci_003E5__2 > 4)
				{
					_003C_003E2__current = CommonReferences.wait3;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0047;
				IL_0047:
				if ((Object)(object)PlayerController.GetPlayer(_003Ci_003E5__2) != (Object)null && PlayerController.GetPlayer(_003Ci_003E5__2).LEOIMFNKFGA != Location.KujakuHouse)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003Ci_003E5__2++;
				goto IL_0081;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class BDPOMPHAIPG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public BDPOMPHAIPG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				OnlineMinigameManager.RequestPirateShipTeleport();
				_003Ci_003E5__2 = 1;
				goto IL_0081;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0047;
			case 2:
				{
					_003C_003E1__state = -1;
					PiratesGameManager.Begin();
					return false;
				}
				IL_0081:
				if (_003Ci_003E5__2 > 4)
				{
					_003C_003E2__current = CommonReferences.wait3;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0047;
				IL_0047:
				if ((Object)(object)PlayerController.GetPlayer(_003Ci_003E5__2) != (Object)null && PlayerController.GetPlayer(_003Ci_003E5__2).LEOIMFNKFGA != Location.PirateShip)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003Ci_003E5__2++;
				goto IL_0081;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static DevConsole instance;

	public InputField inputfield;

	public Scrollbar scroll;

	public TextMeshProUGUI consoleText;

	public GameObject consolePanel;

	public CameraTarget player1CameraTarget;

	public GameObject spawnPoints;

	public bool cheatsEnabled;

	public bool opened;

	public bool forceIntro;

	private bool NDHFKNDPNOO;

	[SerializeField]
	private Vector2 beachTravellingStart;

	[SerializeField]
	private Vector2 beachTravellingEnd;

	[SerializeField]
	private Vector2 castleTravellingStart;

	[SerializeField]
	private Vector2 castleTravellingEnd;

	[SerializeField]
	private Vector2 castleInteriorTravellingStart;

	[SerializeField]
	private Vector2 castleInteriorTravellingEnd;

	[SerializeField]
	private Vector2 cityTravellingStart;

	[SerializeField]
	private Vector2 cityTravellingEnd;

	[SerializeField]
	private Vector2 bathTravellingStart;

	[SerializeField]
	private Vector2 bathTravellingEnd;

	public bool onPlayerSleepFromDevConsole;

	private bool PDEEHBIMGOJ(string EOKBKAKDMGH)
	{
		Save.instance.SaveGame(isNewFile: true);
		return false;
	}

	private bool HNDHIPIILJB()
	{
		((MonoBehaviour)this).StartCoroutine(Bed.Sleep(1));
		return true;
	}

	private bool OCJHJJFJAPN()
	{
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			if ((Object)(object)NinjaChallenge.instance != (Object)null)
			{
				NinjaChallenge.instance.MEPGKMGJADJ();
			}
		}
		else
		{
			NinjaChallenge.StartChallengeEvent();
		}
		return false;
	}

	public bool AddMaterials(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1036).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, result, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
			bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1045).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, result, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
			bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1050).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, result, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
			bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1052).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, result, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public bool ReplayFish()
	{
		FishCuttingGameManager.BeginReplay();
		return true;
	}

	private bool HCKNEEPJNCB()
	{
		INBCACPBEKL("add item " + 1828 + " " + 1);
		INBCACPBEKL("add item " + 1829 + " " + 1);
		INBCACPBEKL("add item " + 1830 + " " + 1);
		INBCACPBEKL("add item " + 1831 + " " + 1);
		INBCACPBEKL("add item " + 1832 + " " + 1);
		INBCACPBEKL("add item " + 1833 + " " + 1);
		INBCACPBEKL("add item " + 1834 + " " + 1);
		INBCACPBEKL("add item " + 1835 + " " + 1);
		INBCACPBEKL("add item " + 1836 + " " + 1);
		INBCACPBEKL("add item " + 1837 + " " + 1);
		INBCACPBEKL("add item " + 1838 + " " + 1);
		INBCACPBEKL("add item " + 1839 + " " + 1);
		INBCACPBEKL("add item " + 1840 + " " + 1);
		INBCACPBEKL("add item " + 1841 + " " + 1);
		INBCACPBEKL("add item " + 1842 + " " + 1);
		return true;
	}

	private bool BIBOLJEFAED()
	{
		TravelZonesManager.OACNNJCLEDE().DAOACOMANPN(Location.Road | Location.River | Location.Farm, Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm).StartTravelZone(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.DGCNCEDIFOF().DAOACOMANPN(Location.Road | Location.River | Location.Quarry, ~(Location.Tavern | Location.Road | Location.BarnInterior)).StartTravelZone(8);
		}
		return false;
	}

	private bool DGJEBGHMGHB()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.QuarryCave, Location.InnkeepersCave).StartTravelZone(1);
		return true;
	}

	private bool FJAFBGFINNH()
	{
		if (Object.op_Implicit((Object)(object)player1CameraTarget))
		{
			player1CameraTarget.travellingTime -= 1f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Travelling time decreased to " + player1CameraTarget.travellingTime;
		}
		return true;
	}

	private bool ALDODOHNLIF()
	{
		CommonReferences.GGFJGHHHEJC.customerInfo.showService = !CommonReferences.GGFJGHHHEJC.customerInfo.showService;
		if (CommonReferences.GGFJGHHHEJC.customerInfo.showService)
		{
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Service Debug: True";
		}
		else
		{
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Service Debug: False";
		}
		return true;
	}

	private bool IPFNPMLKHPI()
	{
		if (Object.op_Implicit((Object)(object)player1CameraTarget))
		{
			player1CameraTarget.travellingTime -= 314f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "tutorialPopUp77" + player1CameraTarget.travellingTime;
		}
		return false;
	}

	private bool IDMECGKHGMK(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			for (int i = 0; i < TutorialPopUps.autoSetUp.Count; i++)
			{
				if (TutorialPopUps.autoSetUp[i].DCFNIMCMFEM == result)
				{
					TutorialManager.GGFJGHHHEJC.ShowPopUp(TutorialPopUps.autoSetUp[i], MDNOOMBIFNN: true, BLKLCBCGHCN: true);
					TextMeshProUGUI obj = consoleText;
					((TMP_Text)obj).text = ((TMP_Text)obj).text + "Showing popup " + result;
					return true;
				}
			}
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Popup missing.";
			return true;
		}
		TextMeshProUGUI obj3 = consoleText;
		((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "A number is needed.";
		return true;
	}

	private bool FPFKFDKKLNG()
	{
		return Cheat(inputfield.text.ToLower());
	}

	private bool BFDOOAIAMME()
	{
		TravelZonesManager.DCAEBALADIM().NKEBECDKDOO(Location.Tavern | Location.River | Location.Camp | Location.Quarry, Location.Road | Location.River | Location.BarnInterior | Location.FarmShop).StartTravelZone(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.OACNNJCLEDE().IMKJEBFOBKK(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior, Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior).KACGDPCMGPL(3);
		}
		return false;
	}

	private bool OAIKONKMDGK()
	{
		OnlineManager.Disconnect();
		return true;
	}

	private bool BIMHIKKACJD()
	{
		TravelZonesManager.GGFJGHHHEJC.JKPNCIFMAOO(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop, ~(Location.Tavern | Location.Road | Location.Farm)).StartTravelZone(0);
		return true;
	}

	private IEnumerator MHBNFKHNIFJ()
	{
		return new PDFEEINGPGI(1);
	}

	public void GKBAKLEIAFN()
	{
		if (opened)
		{
			GMFNJMBIENA();
		}
		else if (cheatsEnabled)
		{
			DOECECEBNNB();
		}
	}

	private bool NANGPPPHAEA()
	{
		Intro.instance.StartIntro();
		return true;
	}

	private bool FNNNOKGMHHM()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Farm, Location.FarmShop).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Farm, Location.FarmShop).StartTravelZone(2);
		}
		return true;
	}

	private bool BLMHPKBIDFI()
	{
		INBCACPBEKL("add item 1440");
		INBCACPBEKL("add item 1444 20");
		INBCACPBEKL("add item 1445 20");
		INBCACPBEKL("add item 1446 20");
		INBCACPBEKL("add item 1447 20");
		INBCACPBEKL("add item 1448 20");
		FishingController.Get(1).baitSelected = Fish.BaitType.Meat;
		return true;
	}

	private bool JJIBLEFKCNB()
	{
		TravelZonesManager.LKOABOAADCD().OFIPCMMKFLP(Location.Tavern | Location.Road, ~(Location.Camp | Location.FarmShop)).KACGDPCMGPL(1);
		return true;
	}

	private bool IFJFLECIFII(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Walk", "Create Private Room");
		int result = 7;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			if (Application.targetFrameRate != result)
			{
				QualitySettings.vSyncCount = 1;
				Application.targetFrameRate = result;
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Path Request Triggered!" + result + "Dialogue System/Conversation/OutHereRowdyCustomer/Entry/1/Dialogue Text";
			return true;
		}
		return true;
	}

	private bool HMINCAELJNO()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River, Location.Camp).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River, Location.Camp).StartTravelZone(2);
		}
		return true;
	}

	private bool KGABMHNDMAA()
	{
		CommonReferences.MNFMOEKMJKN().customerInfo.showService = !CommonReferences.MNFMOEKMJKN().customerInfo.showService;
		if (CommonReferences.GGFJGHHHEJC.customerInfo.showService)
		{
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "tutorialPopUp80";
		}
		else
		{
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ReceiveCollectItemsMaster";
		}
		return true;
	}

	private bool HOFMPKCPJBH()
	{
		INBCACPBEKL("add item " + 1031 + " " + 99);
		INBCACPBEKL("add item " + 1036 + " " + 99);
		INBCACPBEKL("add item " + 1043 + " " + 99);
		INBCACPBEKL("add item " + 1045 + " " + 99);
		INBCACPBEKL("add item " + 1049 + " " + 99);
		INBCACPBEKL("add item " + 1050 + " " + 99);
		INBCACPBEKL("add item " + 1051 + " " + 99);
		INBCACPBEKL("add item " + 1055 + " " + 99);
		return true;
	}

	private bool FMOALABPHNF()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River, Location.Farm).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River, Location.Farm).StartTravelZone(2);
		}
		return true;
	}

	private bool JEAHJILAIAP(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			Time.timeScale = result;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "New time scale: " + result;
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "A number is needed.";
		return true;
	}

	private bool LEOALPEOOKH(int JFNMCNCHMEO, int HFDILBELIKE)
	{
		Item item = ItemDatabaseAccessor.KMBGJEKCJFJ(JFNMCNCHMEO);
		if (Item.MLBOMGHINCA(item, null))
		{
			ItemInstance itemInstance = item.JMDALJBNFML();
			if (HFDILBELIKE > 1)
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(itemInstance, HFDILBELIKE, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "ReceiveItemsFromOtherPlayer" + item.LJIFOHFEFCH(OAFPBCPDOKH: true) + "========================================================================================";
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Error Fireplace.TurnOff: " + JFNMCNCHMEO + " : 00";
		return false;
	}

	private bool JGNBGECEINP(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "complete quest ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		int result = 9999;
		if (array.Length != 0 && int.TryParse(array[0], out result))
		{
			QuestManager.GGFJGHHHEJC.GetActiveQuest(QuestDatabaseAccessor.GetQuest(result))?.JGNBGECEINP(1);
		}
		else
		{
			foreach (ActiveQuest item in new List<ActiveQuest>(QuestManager.GGFJGHHHEJC.MADOFDHLKKN))
			{
				if (item != null && item.quest.id != 0)
				{
					item.JGNBGECEINP(1);
				}
			}
		}
		return true;
	}

	private bool LBBNAJJGGJI()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(2);
		}
		return true;
	}

	private bool MMCILHNMDEG()
	{
		TravelZonesManager.OMFKNGDCJFN().ECFDFECLDFK(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior, Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm).StartTravelZone(1);
		return false;
	}

	private bool ENMMPPBGHAA()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)spawnPoints))
		{
			Utils.BLPDAEHPOBA(spawnPoints);
		}
		return PPAMAJMMLLM(new Vector2(1387f, 90f), new Vector2(1583f, 373f));
	}

	private bool FAOINCNMKPL(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			TavernReputation.AddReputationPoints(result + result * TavernReputation.GetMilestone());
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Reputation increased by " + (result + result * TavernReputation.GetMilestone());
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "A number is needed.";
		return true;
	}

	private bool BDIPKPLEGKM(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Items/item_description_1176", "Disconnected Corroutine");
		string[] array = Regex.Split(EOKBKAKDMGH, "<sprite name=NewRecordFish>   ");
		if (array.Length != 0 && int.TryParse(array[1], out var result))
		{
			if (array.Length > 0 && int.TryParse(array[1], out var result2))
			{
				return LEOALPEOOKH(result, result2);
			}
			return INBCACPBEKL(result, 1);
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "/ExtraSettings.sd";
		return true;
	}

	private bool LBFKOCFDCBC()
	{
		foreach (KeyValuePair<string, int> item in KeybindUI.OLHBLKIAFOM().keybindsSave.keybindSave)
		{
			TextMeshProUGUI val = consoleText;
			string[] array = new string[6];
			array[1] = ((TMP_Text)val).text;
			array[1] = "Sleep";
			array[5] = item.Key;
			array[1] = "Item Age ";
			array[8] = item.Value.ToString();
			array[2] = "Additions";
			((TMP_Text)val).text = string.Concat(array);
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "itemBeetrootSeeds";
		return false;
	}

	private bool FJPNLDPGJHO()
	{
		TravelZonesManager.GFMBEDCANNI().JKPNCIFMAOO(Location.Camp | Location.Farm | Location.FarmShop, Location.Tavern | Location.River | Location.BarnInterior | Location.FarmShop).StartTravelZone(1);
		return true;
	}

	private bool BANOOOCLAFB()
	{
		forceIntro = true;
		return true;
	}

	private IEnumerator LHKDBAPJAGC(EventsManager.EventType AKADPCABHIB)
	{
		yield return CommonReferences.wait2;
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Activated " + AKADPCABHIB;
		EventsManager.GetGameEvent(AKADPCABHIB).ActivateEvent();
	}

	private void OKHLEMPJONN()
	{
		((Component)inputfield).gameObject.SetActive(false);
		consolePanel.gameObject.SetActive(false);
		instance = this;
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private bool BFLGFHDBICG()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(523f, 510f), new Vector2(221f, 1101f));
	}

	private bool PPAMAJMMLLM(Vector2 NOLFMLNLJJG, Vector2 FNELKJFCHHH)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player1CameraTarget))
		{
			((Component)GameplayUI.GGFJGHHHEJC).gameObject.SetActive(false);
			player1CameraTarget.startPosition = NOLFMLNLJJG;
			player1CameraTarget.endPosition = FNELKJFCHHH;
			player1CameraTarget.StartTravelling();
			GMFNJMBIENA();
		}
		return true;
	}

	private bool CBDMHEPOMJD(string EOKBKAKDMGH)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "HotBath/Main 2", "Player");
		string[] array = Regex.Split(EOKBKAKDMGH, "ReceiveThrowFish");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			if (array.Length > 0 && int.TryParse(array[1], out var result2))
			{
				DogNPC.OIBHOMBGDJB(result2, result, "Player2", WorldTime.HGIBNMBJMOC(), Vector2.op_Implicit(new Vector3(1115f, 1796f, 1961f)), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
			}
			else
			{
				DogNPC.OIBHOMBGDJB(1, result, "Distillery", WorldTime.NOAOJJLNHJJ, Vector2.op_Implicit(new Vector3(1507f, 1863f, 222f)), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
			}
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "meatDishes";
		return false;
	}

	public bool StartPirates()
	{
		if (OnlineMinigameManager.GetMinigameState() == OnlineMinigameManager.PlayerState.Default)
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InTransition);
		}
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Castle)
		{
			((MonoBehaviour)this).StartCoroutine(IHKGGDBLFBH());
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsClient())
			{
				OnlineMinigameManager.RequestBeginPirateMinigame();
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(DAJNKCCKGHD());
			}
		}
		else
		{
			PiratesGameManager.Begin();
		}
		return true;
	}

	private bool KHDAGHPKDGK()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.Blacksmith).StartTravelZone(1);
		return true;
	}

	private bool GFKGKOBEAGD()
	{
		NewTutorialManager.instance.StartTutorial();
		return true;
	}

	private bool KJDDNEIMAAB()
	{
		Item[] items = ItemDatabaseAccessor.GetDatabaseSO().items;
		foreach (Item item in items)
		{
			if (item is SproutSeed && item.shop != 0)
			{
				INBCACPBEKL("add item " + item.JDJGFAACPFC() + " " + 50);
			}
		}
		return true;
	}

	private bool IBMPDALDGFL(string EOKBKAKDMGH)
	{
		if (SeasonManager.KCJFCHNPIBJ() == Season.Spring)
		{
			SeasonManager.instance.EBJINCHPBJB(Season.Spring);
		}
		else if (SeasonManager.NHKAHEEGEGF() == Season.Spring)
		{
			SeasonManager.instance.NMMLELDCBBJ(Season.Autumn);
		}
		else if (SeasonManager.LPGPJPPLHKG() == (Season)5)
		{
			SeasonManager.instance.ChangeSeason((Season)7);
		}
		else if (SeasonManager.PJMGHIMKFJL() == (Season)5)
		{
			SeasonManager.instance.AJFAKNHLGNB(Season.Spring);
		}
		return true;
	}

	private bool NOODKHHGKPI()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(-425f, 417f), new Vector2(-425f, 419.5f));
	}

	public bool MJGGDIPDHHM(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "No", "Farm/Event/SwordVioletArthur");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			StaffManager.IncreaseLevelToAllWorkers(result);
			return false;
		}
		return false;
	}

	private bool LBDMGGMGLPI()
	{
		TravelZonesManager.CFHEJAGKIII().NKEBECDKDOO(~(Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior), Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior).KACGDPCMGPL(1);
		return false;
	}

	private bool AGFFLMOHMBC()
	{
		TravelZonesManager.EKDNJDJHONF().GetTravelZone(~(Location.Tavern | Location.Road | Location.BarnInterior), ~(Location.Tavern | Location.Farm | Location.BarnInterior)).KACGDPCMGPL(0);
		return false;
	}

	private bool EOOABCEHOKG()
	{
		if (!BanquetEvent.HCOPJPMDEKP)
		{
			BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH: true);
			BanquetEvent.instance.ActivateEvent();
		}
		else
		{
			BanquetEvent.DeactivateBanquetEvent();
		}
		return true;
	}

	private bool NNBDLCLPKEE(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			Money.AddPrice(new Price(0, 0, result));
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Money increased (" + result + " gold)...";
			return true;
		}
		return false;
	}

	private bool IIDFGNLMGDG(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "day ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
			currentGameDate.week = result / 7;
			currentGameDate.day = (Day)(result % 7);
			WorldTime.NOAOJJLNHJJ = currentGameDate;
			WorldTime.CalcCurrentDayTimeSec();
			return true;
		}
		return false;
	}

	private bool DFEBFLGHCOJ(string EOKBKAKDMGH)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "CalmRowdyCustomer", "tutorialPopUp112");
		string[] array = Regex.Split(EOKBKAKDMGH, "ChatInviteCode");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			if (array.Length > 0 && int.TryParse(array[1], out var result2))
			{
				DogNPC.HPDCPDOCKPC(result2, result, "PreviousItem", WorldTime.NOAOJJLNHJJ, Vector2.op_Implicit(new Vector3(1350f, 1827f, 37f)));
			}
			else
			{
				DogNPC.InstantiateDog(1, result, "Tutorial/T100/Dialogue2", WorldTime.HGIBNMBJMOC(), Vector2.op_Implicit(new Vector3(916f, 759f, 1283f)), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
			}
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + " sent to delivery chest. Over Cellar Door";
		return false;
	}

	private IEnumerator LKFLGCAFKDJ(GameObject HGNKFFMDOOL)
	{
		yield return null;
		EventSystem.current.SetSelectedGameObject((GameObject)null);
		yield return null;
		EventSystem.current.SetSelectedGameObject(HGNKFFMDOOL);
	}

	private bool CHAFFHCGMNJ()
	{
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			if ((Object)(object)NinjaChallenge.instance != (Object)null)
			{
				NinjaChallenge.instance.FinishChallengeWhenEventIsLost();
			}
		}
		else
		{
			NinjaChallenge.StartChallengeEvent();
		}
		return true;
	}

	public bool FFFEIEKLAJA()
	{
		BathhouseGameManager.LLOEOBKFMFI();
		return false;
	}

	private void CMLLBIDFNEB()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		cheatsEnabled = false;
		string text = "Pirates/Brook/Intro";
		if (SteamManager.BNBMMDGMKLM)
		{
			SteamApps.GetCurrentBetaName(ref text, -1);
		}
		if (SteamManager.BNBMMDGMKLM && (Debug.isDebugBuild || text == "Player/Bark/Fishing/NoBait" || SteamUser.GetSteamID().m_SteamID == 946L || SteamUser.GetSteamID().m_SteamID == 18446744073709549699uL || SteamUser.GetSteamID().m_SteamID == 1772L || SteamUser.GetSteamID().m_SteamID == 600L || SteamUser.GetSteamID().m_SteamID == 278L || SteamUser.GetSteamID().m_SteamID == 18446744073709550882uL || SteamUser.GetSteamID().m_SteamID == 340L || SteamUser.GetSteamID().m_SteamID == 33L || SteamUser.GetSteamID().m_SteamID == 18446744073709549618uL || SteamUser.GetSteamID().m_SteamID == 621L || SteamUser.GetSteamID().m_SteamID == 1320L || SteamUser.GetSteamID().m_SteamID == 674L))
		{
			cheatsEnabled = true;
		}
		else if (Application.isEditor || Debug.isDebugBuild)
		{
			cheatsEnabled = true;
		}
		if (cheatsEnabled)
		{
			PlayerInputs.JJAAKKIIMDP();
		}
	}

	private bool NHCKDLCOAMO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)spawnPoints))
		{
			Utils.BLPDAEHPOBA(spawnPoints);
		}
		return PPAMAJMMLLM(new Vector2(301f, 1538f), new Vector2(403f, 503f));
	}

	private bool FLJFPPDNBMO(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "unlock recipe ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		int result = 9999;
		if (array.Length != 0 && int.TryParse(array[0], out result))
		{
			Recipe recipe = RecipeDatabaseAccessor.GetRecipe(result);
			if (Object.op_Implicit((Object)(object)recipe))
			{
				RecipesManager.UnlockRecipe(recipe);
				return true;
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "\nRecipe not found.\n";
		}
		return false;
	}

	private bool DDCAAGGBNKM()
	{
		TravelZonesManager.DCAEBALADIM().KCJMDAPPJLB(~(Location.River | Location.Farm | Location.FarmShop), Location.River | Location.FarmShop).StartTravelZone(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.EKDNJDJHONF().NKEBECDKDOO(~(Location.Tavern | Location.River | Location.FarmShop), Location.River | Location.Camp | Location.Quarry | Location.BarnInterior).StartTravelZone(2);
		}
		return false;
	}

	private bool KNHGAFKNOLC()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Quarry).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Quarry).StartTravelZone(2);
		}
		return true;
	}

	private bool LCHBOGAHPCO(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "psai [{0}]: firing synchronized One-Shot Trigger: {1}", "Dialogue System/Conversation/TooHot/Entry/2/Dialogue Text").Trim();
		int result = 0;
		int.TryParse(EOKBKAKDMGH, out result);
		if (result < 0)
		{
			result = 1;
		}
		StuckRecoverySystem.instance.NLMCDGOPNGE(result);
		return false;
	}

	private bool LCJMAJHGCOO(string EOKBKAKDMGH)
	{
		if (SeasonManager.NHKAHEEGEGF() == Season.Spring)
		{
			SeasonManager.instance.AJFAKNHLGNB(Season.Spring);
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Spring)
		{
			SeasonManager.instance.NMMLELDCBBJ(Season.Summer);
		}
		else if (SeasonManager.LPGPJPPLHKG() == (Season)5)
		{
			SeasonManager.instance.OGKNMEMHHEK(Season.Spring);
		}
		else if (SeasonManager.PJMGHIMKFJL() == (Season)4)
		{
			SeasonManager.instance.AJFAKNHLGNB(Season.Summer);
		}
		return false;
	}

	private bool ALJIOAGGDIC(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			NewTutorialManager.instance.currentPhase = result - 1;
			NewTutorialManager.instance.NextPhase();
			NewTutorialManager.instance.ActivateTutorial(DAEMAAOLHMG: true, ICEGNJDJMLE: false);
			return true;
		}
		return false;
	}

	public bool StartFish()
	{
		if (OnlineMinigameManager.GetMinigameState() == OnlineMinigameManager.PlayerState.Default)
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InTransition);
		}
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA != Location.KujakuHouse)
		{
			((MonoBehaviour)this).StartCoroutine(IEGEJCEJGIL());
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsClient())
			{
				OnlineMinigameManager.RequestBeginFishCuttingMinigame();
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(DHDPIMMAGJK());
			}
		}
		else
		{
			FishCuttingGameManager.Begin();
		}
		return true;
	}

	private bool ADDDJEJKECB()
	{
		CommonReferences.MNFMOEKMJKN().customerInfo.showService = !CommonReferences.GGFJGHHHEJC.customerInfo.showService;
		if (CommonReferences.GGFJGHHHEJC.customerInfo.showService)
		{
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + " recipeFragments) (versionOfCityAndTutorial)";
		}
		else
		{
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Festín del Juramento/JudgeDialogue 02";
		}
		return true;
	}

	private bool IFMLPAIAMDI(string EOKBKAKDMGH)
	{
		if (SeasonManager.EECEKHKAAIH == Season.Spring)
		{
			SeasonManager.instance.ChangeSeason(Season.Summer);
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Summer)
		{
			SeasonManager.instance.ChangeSeason(Season.Autumn);
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Autumn)
		{
			SeasonManager.instance.ChangeSeason(Season.Winter);
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			SeasonManager.instance.ChangeSeason(Season.Spring);
		}
		return true;
	}

	private bool MINIPFHJCIP()
	{
		GeneratorsManager.instance.GenerateNewForestMapWithCoroutine(LCIDLBLPKHB: true);
		return true;
	}

	private bool LAAIHNGHMJL(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			if (Application.targetFrameRate != result)
			{
				QualitySettings.vSyncCount = 0;
				Application.targetFrameRate = result;
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Target frame rate (" + result + ")...";
			return true;
		}
		return false;
	}

	private bool GAONHALIEAI(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "add letter ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			LettersManager.instance.AddNewReceivedLetter(result);
			return true;
		}
		return false;
	}

	public bool NOPIMELDCOO(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "City/Woody/Bark/Stand" + inputfield.text + "Eat";
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(EOKBKAKDMGH);
		if (num <= 198)
		{
			if (num <= 4294967136u)
			{
				if (num <= 68)
				{
					if (num <= 4294967129u)
					{
						if (num <= 47)
						{
							if (num != 4294967113u)
							{
								if (num != 145)
								{
									if (num == 169 && EOKBKAKDMGH == " at ")
									{
										goto IL_0f46;
									}
								}
								else if (EOKBKAKDMGH == "psai [{0}]: firing synchronized One-Shot Trigger: {1}")
								{
									return ENFEIPEBFFI();
								}
							}
							else if (EOKBKAKDMGH == "Could not find item with id: ")
							{
								return CKPCHMPHDFI();
							}
						}
						else
						{
							switch (num)
							{
							case 139u:
								if (!(EOKBKAKDMGH == "PlaceableOnSpecificSurfaces"))
								{
									break;
								}
								return MPHMCCKAAMB();
							case 11u:
								if (!(EOKBKAKDMGH == "F2"))
								{
									break;
								}
								return INKOAKJDEMG();
							case 158u:
								if (!(EOKBKAKDMGH == "Dialogue System/Conversation/TooHot/Entry/2/Dialogue Text"))
								{
									break;
								}
								return NANGPPPHAEA();
							}
						}
					}
					else if (num <= 4294967225u)
					{
						if (num != 4294967183u)
						{
							switch (num)
							{
							case 195u:
								if (!(EOKBKAKDMGH == "MainProgress"))
								{
									break;
								}
								return ADNFEBOAGAD();
							case 182u:
								if (!(EOKBKAKDMGH == "Perks/playerPerk_description_"))
								{
									break;
								}
								return CIHMCFAJMNM();
							}
						}
						else if (EOKBKAKDMGH == "Tutorial/T100/Dialogue2")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 4294967289u:
							if (!(EOKBKAKDMGH == "We're in the same region."))
							{
								break;
							}
							MineManager.AGGAGCBAGLL().CHKKKBGALKB(CDPAMNIPPEC: false);
							return true;
						case 4u:
							if (!(EOKBKAKDMGH == " ("))
							{
								break;
							}
							return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
						case 4294967171u:
							if (!(EOKBKAKDMGH == "weedsCut"))
							{
								break;
							}
							return GFKGKOBEAGD();
						}
					}
				}
				else if (num <= 4)
				{
					if (num <= 61)
					{
						if (num != 4294967193u)
						{
							switch (num)
							{
							case 7u:
								if (!(EOKBKAKDMGH == "Player/Bark/Tutorial/SleepBlock"))
								{
									break;
								}
								return ANOOPFGHNCJ();
							case 4294967154u:
								if (!(EOKBKAKDMGH == "Pick Level Low"))
								{
									break;
								}
								return OLBMOPFDOIH();
							}
						}
						else if (EOKBKAKDMGH == "UIInteract")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 4294967148u:
							if (!(EOKBKAKDMGH == "hForHours"))
							{
								break;
							}
							return MOLEJPANHAE();
						case 4294967229u:
							if (!(EOKBKAKDMGH == "Close"))
							{
								break;
							}
							return ABBLKDMCNEI();
						case 4294967192u:
							if (!(EOKBKAKDMGH == "Moving"))
							{
								break;
							}
							return PNNEFEALMMC();
						}
					}
				}
				else if (num <= 18)
				{
					switch (num)
					{
					case 199u:
						if (!(EOKBKAKDMGH == "quest_name_"))
						{
							break;
						}
						return AAIPJMFLDEJ();
					case 167u:
						if (!(EOKBKAKDMGH == "No se encuentra el valor "))
						{
							break;
						}
						return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
					case 84u:
						if (!(EOKBKAKDMGH == "Facial Hair"))
						{
							break;
						}
						return OAIKONKMDGK();
					}
				}
				else if (num != 4294967289u)
				{
					switch (num)
					{
					case 4294967226u:
						if (!(EOKBKAKDMGH == "\n<color=#822F00>"))
						{
							break;
						}
						return KJDDNEIMAAB();
					case 90u:
						if (!(EOKBKAKDMGH == "ReceiveHoeActionMaster"))
						{
							break;
						}
						return CHAMHIDHEJI();
					}
				}
				else if (EOKBKAKDMGH == "Clean")
				{
					goto IL_0f4d;
				}
			}
			else if (num <= 4294967288u)
			{
				if (num <= 174)
				{
					if (num <= 4294967289u)
					{
						switch (num)
						{
						case 159u:
							if (!(EOKBKAKDMGH == "Player2"))
							{
								break;
							}
							return PBGMKMONPJP();
						case 4294967207u:
							if (!(EOKBKAKDMGH == "Stop"))
							{
								break;
							}
							return JEMOACOJLPC();
						case 150u:
							if (!(EOKBKAKDMGH == " for reason: "))
							{
								break;
							}
							return FHGODJOCMPA();
						}
					}
					else if (num != 4294967269u)
					{
						if (num != 90)
						{
							if (num == 57 && EOKBKAKDMGH == "buildingObjective_36_0")
							{
								return CNNMDFJPMNK();
							}
						}
						else if (EOKBKAKDMGH == "Dialogue System/Conversation/Gass_Barks_Bye/Entry/2/Dialogue Text")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "ReceiveStartCrowlyEvent")
					{
						return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
					}
				}
				else if (num <= 4294967231u)
				{
					if (num != 4294967156u)
					{
						switch (num)
						{
						case 4294967279u:
							if (!(EOKBKAKDMGH == "Invalid year: "))
							{
								break;
							}
							return FFNMMACFBKP(MJHBHDAEDLF: false);
						case 4294967178u:
							if (!(EOKBKAKDMGH == ""))
							{
								break;
							}
							return StartPirates();
						}
					}
					else if (EOKBKAKDMGH == "[Player1Name]")
					{
						goto IL_109c;
					}
				}
				else
				{
					switch (num)
					{
					case 9u:
						if (!(EOKBKAKDMGH == "ReceiveTavernHeat"))
						{
							break;
						}
						return OABLIHKPNCF();
					case 4294967140u:
						if (!(EOKBKAKDMGH == "Intro17"))
						{
							break;
						}
						return FFFEIEKLAJA();
					case 88u:
						if (!(EOKBKAKDMGH == "UISelectGamepad"))
						{
							break;
						}
						return NBCJFHNAMGE();
					}
				}
			}
			else if (num <= 139)
			{
				switch (num)
				{
				case 0u:
				case 1u:
				case 2u:
				case 3u:
				case 4u:
				case 5u:
				case 6u:
				case 7u:
				case 8u:
				case 9u:
				case 10u:
				case 11u:
				case 12u:
				case 13u:
				case 14u:
				case 15u:
				case 16u:
				case 17u:
				case 18u:
				case 19u:
				case 20u:
				case 21u:
				case 22u:
				case 23u:
				case 24u:
				case 25u:
				case 26u:
				case 27u:
					switch (num)
					{
					case 4294967231u:
						if (!(EOKBKAKDMGH == "]"))
						{
							break;
						}
						return CEAOEFMLJKK();
					case 4294967157u:
						if (!(EOKBKAKDMGH == "Player"))
						{
							break;
						}
						return HHDCLALCAIE();
					case 28u:
						if (!(EOKBKAKDMGH == ")"))
						{
							break;
						}
						return PGDGLIHMBMK();
					}
					break;
				case 36u:
					if (!(EOKBKAKDMGH == "tutorialPopUp29"))
					{
						break;
					}
					return CDFBICNOECM();
				case 4294967132u:
					if (!(EOKBKAKDMGH == "Sit"))
					{
						break;
					}
					return CCABKLMNLHO();
				case 4294967134u:
					if (!(EOKBKAKDMGH == "Trying to add player but player list is full."))
					{
						break;
					}
					return ReplayFish();
				}
			}
			else if (num <= 4294967192u)
			{
				switch (num)
				{
				case 4294967293u:
					if (!(EOKBKAKDMGH == "BarIdleNumber"))
					{
						break;
					}
					return GEHNAGGBPEM();
				case 127u:
					if (!(EOKBKAKDMGH == ""))
					{
						break;
					}
					return CPFBOGBPPMN();
				case 42u:
					if (!(EOKBKAKDMGH == "ReceiveRemoveZone"))
					{
						break;
					}
					return NKEFONDMLPH();
				}
			}
			else if (num <= 4294967227u)
			{
				switch (num)
				{
				case 4294967152u:
					if (!(EOKBKAKDMGH == " transform.position is NaN"))
					{
						break;
					}
					return LIHFLBCDGJE();
				case 89u:
					if (!(EOKBKAKDMGH == " not found in OnlineEventsManager. Cannot start observe dialogue"))
					{
						break;
					}
					return BDCPHJICALJ();
				}
			}
			else if (num != 4294967114u)
			{
				if (num == 163 && EOKBKAKDMGH == "LE_18")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "Stay")
			{
				return HNDHIPIILJB();
			}
		}
		else if (num <= 4294967122u)
		{
			if (num <= 62)
			{
				if (num <= 115)
				{
					if (num <= 22)
					{
						if (num != 4294967286u)
						{
							if (num != 4294967233u)
							{
								if (num == 4294967125u && EOKBKAKDMGH == "Turn On")
								{
									return NPAFILPDOAL();
								}
							}
							else if (EOKBKAKDMGH == "Items/item_description_645")
							{
								goto IL_109c;
							}
						}
						else if (EOKBKAKDMGH == "Intensity: ")
						{
							return OCEMEODOKLH();
						}
					}
					else
					{
						switch (num)
						{
						case 152u:
							if (!(EOKBKAKDMGH == "itemWater"))
							{
								break;
							}
							return ICGIKKIENDP();
						case 4294967249u:
							if (!(EOKBKAKDMGH == "Buy"))
							{
								break;
							}
							return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
						case 4294967246u:
							if (!(EOKBKAKDMGH == "Return"))
							{
								break;
							}
							return StartBathhouse();
						}
					}
				}
				else
				{
					switch (num)
					{
					case 4294967225u:
					case 4294967226u:
					case 4294967227u:
					case 4294967228u:
					case 4294967229u:
					case 4294967230u:
					case 4294967231u:
					case 4294967232u:
					case 4294967233u:
					case 4294967234u:
					case 4294967235u:
					case 4294967236u:
					case 4294967237u:
					case 4294967238u:
					case 4294967239u:
					case 4294967240u:
					case 4294967241u:
					case 4294967242u:
					case 4294967243u:
					case 4294967244u:
					case 4294967245u:
					case 4294967246u:
					case 4294967247u:
					case 4294967248u:
					case 4294967249u:
					case 4294967250u:
					case 4294967251u:
					case 4294967252u:
					case 4294967253u:
					case 4294967254u:
					case 4294967255u:
					case 4294967256u:
					case 4294967257u:
					case 4294967258u:
					case 4294967259u:
					case 4294967260u:
					case 4294967261u:
					case 4294967262u:
					case 4294967263u:
					case 4294967264u:
					case 4294967265u:
					case 4294967266u:
					case 4294967267u:
					case 4294967268u:
					case 4294967269u:
					case 4294967270u:
					case 4294967271u:
					case 4294967272u:
					case 4294967273u:
					case 4294967274u:
					case 4294967275u:
					case 4294967276u:
					case 4294967277u:
					case 4294967278u:
					case 4294967279u:
					case 4294967280u:
					case 4294967281u:
					case 4294967282u:
					case 4294967283u:
					case 4294967284u:
					case 4294967285u:
					case 4294967286u:
					case 4294967287u:
					case 4294967288u:
					case 4294967289u:
					case 4294967290u:
					case 4294967291u:
					case 4294967292u:
					case 4294967293u:
					case 4294967294u:
					case uint.MaxValue:
						switch (num)
						{
						case 4294967116u:
							if (!(EOKBKAKDMGH == "BeginChatFade"))
							{
								break;
							}
							return CDCCALONMGD();
						case 4294967214u:
							if (!(EOKBKAKDMGH == "Bartender"))
							{
								break;
							}
							return LBBNAJJGGJI();
						case 4294967165u:
							if (!(EOKBKAKDMGH == "================== PLACE PIECE ({0}-{1}/{2}) ======================="))
							{
								break;
							}
							return OIMMOOFKFFE();
						}
						break;
					case 136u:
						if (!(EOKBKAKDMGH == "Attack/MainEvent 2"))
						{
							break;
						}
						return MINIPFHJCIP();
					case 4294967117u:
						if (!(EOKBKAKDMGH == "Current user name: "))
						{
							break;
						}
						return IAHPEAFAFCK();
					case 4294967167u:
						if (!(EOKBKAKDMGH == "Comfort"))
						{
							break;
						}
						return PDGCMHBCNBJ();
					}
				}
			}
			else if (num <= 93)
			{
				if (num <= 168)
				{
					switch (num)
					{
					case 4294967109u:
						if (!(EOKBKAKDMGH == "cloudy"))
						{
							break;
						}
						return GGFDGGHCPND();
					case 4294967102u:
						if (!(EOKBKAKDMGH == "MineState"))
						{
							break;
						}
						return FJAFBGFINNH();
					case 34u:
						if (!(EOKBKAKDMGH == "BecomeNuisance"))
						{
							break;
						}
						return FJPNLDPGJHO();
					}
				}
				else if (num != 4294967177u)
				{
					if (num != 4294967111u)
					{
						if (num == 4294967293u && EOKBKAKDMGH == "ReceiveFillFountain")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "questNameMalting")
					{
						return HMINCAELJNO();
					}
				}
				else if (EOKBKAKDMGH == "Could not find recipe with id: ")
				{
					return IFLKPHCBLBO();
				}
			}
			else if (num <= 194)
			{
				if (num != 4294967281u)
				{
					if (num != 4294967176u)
					{
						if (num == 186 && EOKBKAKDMGH == "stuck recovery")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "Player")
					{
						return BLMHPKBIDFI();
					}
				}
				else if (EOKBKAKDMGH == "Unlocked at Tavern Reputation {0}")
				{
					return FCCJDHKEFBM();
				}
			}
			else
			{
				switch (num)
				{
				case 4294967251u:
					if (!(EOKBKAKDMGH == "mForMins"))
					{
						break;
					}
					MineManager.GGFJGHHHEJC.PlaceCharges();
					return false;
				case 7u:
					if (!(EOKBKAKDMGH == "Dialogue System/Actor/"))
					{
						break;
					}
					return NOODKHHGKPI();
				case 34u:
					if (!(EOKBKAKDMGH == "Items/item_description_1186"))
					{
						break;
					}
					return FNNNOKGMHHM();
				}
			}
		}
		else if (num <= 4294967241u)
		{
			if (num <= 4294967127u)
			{
				if (num <= 4294967139u)
				{
					if (num != 150)
					{
						if (num != 187)
						{
							if (num == 89 && EOKBKAKDMGH == "Items/item_description_618")
							{
								return LFONIBMMHOB();
							}
						}
						else if (EOKBKAKDMGH == "Missing fade image for coop mode")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "RochelleProgress")
					{
						return JEFLILOPHOL();
					}
				}
				else
				{
					switch (num)
					{
					case 58u:
						if (!(EOKBKAKDMGH == "Throw"))
						{
							break;
						}
						return JMGBBKPLBJM();
					case 4294967196u:
						if (!(EOKBKAKDMGH == "Private Example Method"))
						{
							break;
						}
						return BFDOOAIAMME();
					case 4294967151u:
						if (!(EOKBKAKDMGH == "itemMint"))
						{
							break;
						}
						return CMONDIHNPBI();
					}
				}
			}
			else if (num <= 138)
			{
				if (num != 31)
				{
					switch (num)
					{
					case 4294967108u:
						if (!(EOKBKAKDMGH == "Ingredient null!"))
						{
							break;
						}
						return AIAGEJIAGPF();
					case 64u:
						if (!(EOKBKAKDMGH == "\n"))
						{
							break;
						}
						return DDCAAGGBNKM();
					}
				}
				else if (EOKBKAKDMGH == "Player")
				{
					goto IL_0f46;
				}
			}
			else if (num != 16)
			{
				if (num != 40)
				{
					if (num == 41 && EOKBKAKDMGH == "Player/Bark/Tutorial/T100")
					{
						goto IL_109c;
					}
				}
				else if (EOKBKAKDMGH == "/BarkMai")
				{
					return MCDCDBIGMMM("LE_10");
				}
			}
			else if (EOKBKAKDMGH == "Player")
			{
				return CKOGCLKNANJ();
			}
		}
		else if (num <= 7)
		{
			switch (num)
			{
			case 4294967288u:
			case 4294967289u:
			case 4294967290u:
			case 4294967291u:
			case 4294967292u:
			case 4294967293u:
			case 4294967294u:
			case uint.MaxValue:
				switch (num)
				{
				case 110u:
					if (!(EOKBKAKDMGH == "Festín del Juramento/PresentacionMaestros 01"))
					{
						break;
					}
					return LNCFOBHEABH();
				case 4294967204u:
					if (!(EOKBKAKDMGH == "ReceiveInstantiateCat"))
					{
						break;
					}
					return KDJKLGEHJAC();
				case 39u:
					if (!(EOKBKAKDMGH == "ReceiveBeginPirateMinigame"))
					{
						break;
					}
					return FFNMMACFBKP(MJHBHDAEDLF: true);
				}
				break;
			case 4294967173u:
				if (!(EOKBKAKDMGH == "Items/item_description_598"))
				{
					break;
				}
				return KJAKKKEOEBG();
			case 4294967101u:
				if (!(EOKBKAKDMGH == "Food"))
				{
					break;
				}
				return AIAGEJIAGPF();
			case 94u:
				if (!(EOKBKAKDMGH == "<color=#BF0000>"))
				{
					break;
				}
				return JDALGGKAGDG();
			}
		}
		else if (num <= 76)
		{
			if (num != 4294967277u)
			{
				if (num != 86)
				{
					if (num == 4294967280u && EOKBKAKDMGH == ".")
					{
						goto IL_0f4d;
					}
				}
				else if (EOKBKAKDMGH == "Floor_3")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "Total: ")
			{
				return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
			}
		}
		else if (num <= 4294967212u)
		{
			switch (num)
			{
			case 147u:
				if (!(EOKBKAKDMGH == "Generating new trends "))
				{
					break;
				}
				return FMOALABPHNF();
			case 4294967162u:
				if (!(EOKBKAKDMGH == "ReceiveOfferingItemCleared"))
				{
					break;
				}
				return NMDHHEAKPPA();
			}
		}
		else if (num != 182)
		{
			if (num == 111 && EOKBKAKDMGH == "HalloweenEvent")
			{
				goto IL_109c;
			}
		}
		else if (EOKBKAKDMGH == "HandUp")
		{
			return ENMMPPBGHAA();
		}
		if (EOKBKAKDMGH.Contains("</b>\n"))
		{
			return NNBDLCLPKEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Gass_Introduce/Entry/9/Dialogue Text"))
		{
			return MHIBNKHCDLI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ValueSuitabilities"))
		{
			return PLOKNFMFBMI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" not loaded with the new crops tree system at "))
		{
			return PMKNKFIKCPG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return JMHEKECCFCN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("BarkActor"))
		{
			return MCDCDBIGMMM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("SelectPermissionAccepted"))
		{
			return LCJMAJHGCOO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ClosePopUp"))
		{
			return JABEGCPGOPB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ActionBar3"))
		{
			return CMEEFLDCGHO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Run"))
		{
			return CFBHCOJJIPK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(":</color> "))
		{
			return LDABLGMHDPC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Grass"))
		{
			return LDPFLLOGAND(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ToggleGroup/ToggleBasic"))
		{
			return HJHBPPAOGKN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Tile_{0}_{1}"))
		{
			return NDHJHDIKEKK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Printing PRC history. {0} entries."))
		{
			return INBCACPBEKL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("\n"))
		{
			return DFEBFLGHCOJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("\\[WaiterGender=[^\\]]*\\]"))
		{
			ItemInstance.showIdsNum = ItemInstance.showIdsNum;
		}
		if (EOKBKAKDMGH.Contains("Hurt"))
		{
			RandomOrderQuestsManager.HLMGBEGEAPC().GenerateAvailableOrders();
			return true;
		}
		if (EOKBKAKDMGH.Contains("Hanghover"))
		{
			return JGNBGECEINP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("BrookProgress"))
		{
			return BAALKNEHBBM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("popUpBuilding20"))
		{
			return FLJFPPDNBMO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Gass_CoctelQuest"))
		{
			return EFAKLBHENPJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("RequestNPCPositionAndParent"))
		{
			return BEFACDCJPNK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("levelRequired"))
		{
			return JIFOEPHOGEO();
		}
		if (EOKBKAKDMGH.Contains("Focused"))
		{
			return JDFBLMEHPMP();
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_724"))
		{
			return HCKNEEPJNCB();
		}
		if (EOKBKAKDMGH.Contains("Player/Bark/Tutorial/CrafterBlock"))
		{
			return PFDIGPJCPBJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("MineState"))
		{
			return LONHAHGNIOF(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Signing user in..."))
		{
			Utils.disableHalloweenEvent = !Utils.disableHalloweenEvent;
			return false;
		}
		if (EOKBKAKDMGH.Contains("UIInteract"))
		{
			return EDEKHLKKODG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("setDefaultSettings"))
		{
			return IncreaseWorkersLevel(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Creando TXT. Tiempo: "))
		{
			PlayerInputs.DEGBDMMDIIL(0).debugControllers = !PlayerInputs.GetPlayer(1).debugControllers;
			return true;
		}
		if (EOKBKAKDMGH.Contains("NextItem"))
		{
			Weather.ShowWeather(Weather.WeatherType.None);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_678") && !EOKBKAKDMGH.Contains("FishCuttingEvent/Talk2") && !EOKBKAKDMGH.Contains("Tutorial/T117/Dialogue2"))
		{
			Weather.ShowWeather(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Wind);
			return false;
		}
		if (EOKBKAKDMGH.Contains("ObjectHorizontalMove"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Wind | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.PrecipitationCloudy);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Already learnt!"))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Snow | Weather.WeatherType.Wind | Weather.WeatherType.SunnyClouds | Weather.WeatherType.PrecipitationCloudy));
			return true;
		}
		if (EOKBKAKDMGH.Contains("\n") && !EOKBKAKDMGH.Contains("Was master: {0}"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Wind);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Walk Around cannot entry barn "))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Cloudy | Weather.WeatherType.StormClouds);
			return true;
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Wind | Weather.WeatherType.Sunny | Weather.WeatherType.StormClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Castle/Escribas/Stand") && !EOKBKAKDMGH.Contains("Run"))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Rain | Weather.WeatherType.Wind | Weather.WeatherType.Cloudy | Weather.WeatherType.StormClouds));
			return false;
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Gass_Quest/Entry/43/Dialogue Text"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Snow | Weather.WeatherType.Wind);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Granting loot to player "))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Snow);
			return true;
		}
		if (EOKBKAKDMGH.Contains("ReciveLoadCrowlyEventToMaster"))
		{
			List<Fish> list = ItemDatabaseAccessor.JMFNGGEFDEB();
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.JOFHBLKMFEG(list[i], ((Vector2Int)(ref list[i].lenght)).x);
				}
			}
			return true;
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_1115"))
		{
			List<Fish> list2 = ItemDatabaseAccessor.HDELDELJCHH();
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.FBHFGECMPOI(list2[j]);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("[Player2Name]"))
		{
			return AAAIGKPGBOP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("SAVE_DATA: fireplace saving error: "))
		{
			return ALJIOAGGDIC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("- "))
		{
			return LPMNFCKOILP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_727"))
		{
			return GAONHALIEAI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("RewardEntry weights sum {0}, expected 100"))
		{
			return INIDNJOJJPD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("[Action"))
		{
			return LCHBOGAHPCO(EOKBKAKDMGH);
		}
		return false;
		IL_109c:
		return GHPIMLBHMPP();
		IL_0f46:
		return EOOABCEHOKG();
		IL_108e:
		return JCHKJAEPBNK();
		IL_0f4d:
		return JEHJCFHEHBL();
		IL_0efb:
		return AFKKMBIDEBB();
	}

	public bool PFDIGPJCPBJ(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "City/Carpenters/Oak/Chisel", "Move <color=#A51919>");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.KMBGJEKCJFJ(-182, GGBBJNBBLMF: true).JMDALJBNFML();
			BuildingInventory.EGJFDPIEHEC().MGOIJIAGOHL(1, bGLFLHDNOKJ, result, OJKJLIPNHOI: true, CDPAMNIPPEC: false);
			bGLFLHDNOKJ = ItemDatabaseAccessor.INJBNHPGCIJ(-112, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.OLIKHNAFLNG().FGOJPJIFKLG(0, bGLFLHDNOKJ, result, OJKJLIPNHOI: true);
			bGLFLHDNOKJ = ItemDatabaseAccessor.INJBNHPGCIJ(144, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.FFOMKKIAHKI().AddItemInstances(1, bGLFLHDNOKJ, result);
			bGLFLHDNOKJ = ItemDatabaseAccessor.AFOACBIHNCL(-97, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.GOJHIEFPHDK().FOKLCJHEIFO(1, bGLFLHDNOKJ, result, OJKJLIPNHOI: true);
			return true;
		}
		return true;
	}

	public bool GOBCDDFNOJO(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "...Failed" + inputfield.text + "Close";
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(EOKBKAKDMGH);
		if (num <= 154)
		{
			if (num <= 187)
			{
				if (num <= 85)
				{
					if (num <= 113)
					{
						if (num <= 102)
						{
							if (num != 15)
							{
								if (num != 78)
								{
									if (num == 4294967264u && EOKBKAKDMGH == "HoldToAddWater")
									{
										goto IL_0f46;
									}
								}
								else if (EOKBKAKDMGH == "Error not founding final ingredients to ")
								{
									return MIOFOMCEKJI();
								}
							}
							else if (EOKBKAKDMGH == "Tutorial/Chicken_Holly")
							{
								return CALBAJOBLDO();
							}
						}
						else
						{
							switch (num)
							{
							case 138u:
								if (!(EOKBKAKDMGH == "DialogueEndRPC"))
								{
									break;
								}
								return MPHMCCKAAMB();
							case 59u:
								if (!(EOKBKAKDMGH == ""))
								{
									break;
								}
								return INKOAKJDEMG();
							case 56u:
								if (!(EOKBKAKDMGH == " NOT SHOWING IN TOOLTIP"))
								{
									break;
								}
								return NANGPPPHAEA();
							}
						}
					}
					else if (num <= 99)
					{
						if (num != 4294967244u)
						{
							switch (num)
							{
							case 2u:
								if (!(EOKBKAKDMGH == "questDescMalting"))
								{
									break;
								}
								return ADNFEBOAGAD();
							case 120u:
								if (!(EOKBKAKDMGH == "Error in Rock.OnPlayerSleep: "))
								{
									break;
								}
								return LBDMGGMGLPI();
							}
						}
						else if (EOKBKAKDMGH == "Perks/perk_name_")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 115u:
							if (!(EOKBKAKDMGH == "HarvestCut2"))
							{
								break;
							}
							MineManager.AGGAGCBAGLL().LOPPDFFCFKA();
							return false;
						case 4294967108u:
							if (!(EOKBKAKDMGH == "meatDishes"))
							{
								break;
							}
							return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
						case 194u:
							if (!(EOKBKAKDMGH == " not found when loading RockMessage."))
							{
								break;
							}
							return GFKGKOBEAGD();
						}
					}
				}
				else if (num <= 35)
				{
					if (num <= 88)
					{
						if (num != 94)
						{
							switch (num)
							{
							case 60u:
								if (!(EOKBKAKDMGH == "UI2"))
								{
									break;
								}
								return ANOOPFGHNCJ();
							case 4294967232u:
								if (!(EOKBKAKDMGH == ": "))
								{
									break;
								}
								return OLBMOPFDOIH();
							}
						}
						else if (EOKBKAKDMGH == "halloweenActivated")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 4294967292u:
							if (!(EOKBKAKDMGH == "GuestConnecting"))
							{
								break;
							}
							return MOLEJPANHAE();
						case 4294967232u:
							if (!(EOKBKAKDMGH == "(empty)"))
							{
								break;
							}
							return ABBLKDMCNEI();
						case 4294967154u:
							if (!(EOKBKAKDMGH == "Player"))
							{
								break;
							}
							return BFLGFHDBICG();
						}
					}
				}
				else if (num <= 31)
				{
					switch (num)
					{
					case 72u:
						if (!(EOKBKAKDMGH == "Menu Mode"))
						{
							break;
						}
						return AAIPJMFLDEJ();
					case 4294967263u:
						if (!(EOKBKAKDMGH == "No MinePuzzleBase found for type {0} when trying to get required elements count"))
						{
							break;
						}
						return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
					case 4294967222u:
						if (!(EOKBKAKDMGH == "F2"))
						{
							break;
						}
						return OAIKONKMDGK();
					}
				}
				else if (num != 4294967209u)
				{
					switch (num)
					{
					case 4294967163u:
						if (!(EOKBKAKDMGH == ""))
						{
							break;
						}
						return KJDDNEIMAAB();
					case 58u:
						if (!(EOKBKAKDMGH == "No room mode has been selected"))
						{
							break;
						}
						return GAFKLBJCBFI();
					}
				}
				else if (EOKBKAKDMGH == "_")
				{
					goto IL_0f4d;
				}
			}
			else if (num <= 197)
			{
				if (num <= 96)
				{
					if (num <= 4294967240u)
					{
						switch (num)
						{
						case 167u:
							if (!(EOKBKAKDMGH == "Items/item_name_671"))
							{
								break;
							}
							return DJGIEDHNKFN();
						case 193u:
							if (!(EOKBKAKDMGH == "ERROR: The object "))
							{
								break;
							}
							return JEMOACOJLPC();
						case 132u:
							if (!(EOKBKAKDMGH == "Near"))
							{
								break;
							}
							return AJDCAIMMGHJ();
						}
					}
					else if (num != 17)
					{
						if (num != 90)
						{
							if (num == 105 && EOKBKAKDMGH == "Dialogue System/Conversation/Gass_Quest/Entry/36/Dialogue Text")
							{
								return CNNMDFJPMNK();
							}
						}
						else if (EOKBKAKDMGH == "Starting")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "Current Orders")
					{
						return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
					}
				}
				else if (num <= 4294967117u)
				{
					if (num != 4294967217u)
					{
						switch (num)
						{
						case 4294967183u:
							if (!(EOKBKAKDMGH == "Required Items"))
							{
								break;
							}
							return FFNMMACFBKP(MJHBHDAEDLF: false);
						case 4294967230u:
							if (!(EOKBKAKDMGH == "NPCWalkTo Path length: "))
							{
								break;
							}
							return StartPirates();
						}
					}
					else if (EOKBKAKDMGH == "Disabled")
					{
						goto IL_109c;
					}
				}
				else
				{
					switch (num)
					{
					case 4294967117u:
						if (!(EOKBKAKDMGH == "Player"))
						{
							break;
						}
						return JEHAECAPNNC();
					case 4294967223u:
						if (!(EOKBKAKDMGH == "ops"))
						{
							break;
						}
						return GEJILGMNLFJ();
					case 145u:
						if (!(EOKBKAKDMGH == "[RestoreNonAltarVariant] - VariantObjects: {0} - ({1}-{2}/{3}) "))
						{
							break;
						}
						return NBCJFHNAMGE();
					}
				}
			}
			else if (num <= 4294967174u)
			{
				if (num <= 57)
				{
					switch (num)
					{
					case 27u:
						if (!(EOKBKAKDMGH == "Style"))
						{
							break;
						}
						return ADBEGCMDAKF();
					case 4294967122u:
						if (!(EOKBKAKDMGH == "UIPreviousCategory"))
						{
							break;
						}
						return ALDODOHNLIF();
					case 4294967289u:
						if (!(EOKBKAKDMGH == "Move <color=#0B7400>"))
						{
							break;
						}
						return PGDGLIHMBMK();
					}
				}
				else
				{
					switch (num)
					{
					case 22u:
						if (!(EOKBKAKDMGH == " "))
						{
							break;
						}
						return CDFBICNOECM();
					case 19u:
						if (!(EOKBKAKDMGH == ". Tavern level:"))
						{
							break;
						}
						return CCABKLMNLHO();
					case 4294967102u:
						if (!(EOKBKAKDMGH == "Angry"))
						{
							break;
						}
						return ReplayFish();
					}
				}
			}
			else if (num <= 4294967199u)
			{
				switch (num)
				{
				case 60u:
					if (!(EOKBKAKDMGH == "AnimatorObjectStateRequest"))
					{
						break;
					}
					return AANHKLFJBHP();
				case 4294967209u:
					if (!(EOKBKAKDMGH == "ReceiveEnableInputByProximty"))
					{
						break;
					}
					return CPFBOGBPPMN();
				case 195u:
					if (!(EOKBKAKDMGH == "Player"))
					{
						break;
					}
					return HMNNDPAFKFB();
				}
			}
			else if (num <= 160)
			{
				switch (num)
				{
				case 11u:
					if (!(EOKBKAKDMGH == "Round "))
					{
						break;
					}
					return LIHFLBCDGJE();
				case 4294967234u:
					if (!(EOKBKAKDMGH == "City/PetShop/Nessy/Barks"))
					{
						break;
					}
					return BDCPHJICALJ();
				}
			}
			else if (num != 4294967224u)
			{
				if (num == 4294967112u && EOKBKAKDMGH == "Eat")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "Player")
			{
				return HNDHIPIILJB();
			}
		}
		else if (num <= 4294967137u)
		{
			if (num <= 24)
			{
				if (num <= 4294967206u)
				{
					if (num <= 4294967242u)
					{
						if (num != 4294967113u)
						{
							if (num != 4294967146u)
							{
								if (num == 137 && EOKBKAKDMGH == "Invalid NPC photonID: {0} for NPCRoutine.")
								{
									return CPNHFBKGOCB();
								}
							}
							else if (EOKBKAKDMGH == "Cat")
							{
								goto IL_109c;
							}
						}
						else if (EOKBKAKDMGH == "ToggleHideInfoSection")
						{
							return OCEMEODOKLH();
						}
					}
					else
					{
						switch (num)
						{
						case 4294967224u:
							if (!(EOKBKAKDMGH == "Puente_EA/Talk 2"))
							{
								break;
							}
							return KADGOIHAGDP();
						case 4294967147u:
							if (!(EOKBKAKDMGH == "- "))
							{
								break;
							}
							return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
						case 177u:
							if (!(EOKBKAKDMGH == "position"))
							{
								break;
							}
							return StartBathhouse();
						}
					}
				}
				else if (num <= 144)
				{
					switch (num)
					{
					case 4294967188u:
						if (!(EOKBKAKDMGH == "Cat"))
						{
							break;
						}
						return MINIPFHJCIP();
					case 4294967227u:
						if (!(EOKBKAKDMGH == "Perks/perk_name_"))
						{
							break;
						}
						return JFNILOGIOIH();
					case 199u:
						if (!(EOKBKAKDMGH == "itemPaleAle"))
						{
							break;
						}
						return ReplayPirates();
					}
				}
				else
				{
					switch (num)
					{
					case 4294967198u:
						if (!(EOKBKAKDMGH == "unlock recipe "))
						{
							break;
						}
						return CDCCALONMGD();
					case 110u:
						if (!(EOKBKAKDMGH == "DecorationTile_10"))
						{
							break;
						}
						return LBBNAJJGGJI();
					case 140u:
						if (!(EOKBKAKDMGH == "LE_8"))
						{
							break;
						}
						return StartFish();
					}
				}
			}
			else if (num <= 4294967172u)
			{
				if (num <= 4294967258u)
				{
					switch (num)
					{
					case 4294967114u:
						if (!(EOKBKAKDMGH == "Received "))
						{
							break;
						}
						return IBKNPIBHAFG();
					case 4294967259u:
						if (!(EOKBKAKDMGH == "repUnlockMagic"))
						{
							break;
						}
						return IPFNPMLKHPI();
					case 46u:
						if (!(EOKBKAKDMGH == "[MinePuzzleManager] Puzzle resuelto."))
						{
							break;
						}
						return FJPNLDPGJHO();
					}
				}
				else if (num != 122)
				{
					if (num != 4294967286u)
					{
						if (num == 4294967252u && EOKBKAKDMGH == "Error in RentedRoom.OnPlayerSleep: ")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "Dialogue System/Conversation/TableDirty/Entry/3/Dialogue Text")
					{
						return JLDEDNNMBAJ();
					}
				}
				else if (EOKBKAKDMGH == "P1Cam")
				{
					return IFLKPHCBLBO();
				}
			}
			else if (num <= 4294967293u)
			{
				if (num != 4294967257u)
				{
					if (num != 75)
					{
						if (num == 4294967104u && EOKBKAKDMGH == "add item ")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "Two numbers are needed. 'add item ID COUNT'")
					{
						return BLMHPKBIDFI();
					}
				}
				else if (EOKBKAKDMGH == "Flight")
				{
					return FCCJDHKEFBM();
				}
			}
			else
			{
				switch (num)
				{
				case 4294967163u:
					if (!(EOKBKAKDMGH == "Creando TXT. Tiempo: "))
					{
						break;
					}
					MineManager.OOKBNHMMFON().LOPPDFFCFKA();
					return true;
				case 111u:
					if (!(EOKBKAKDMGH == "Distilling"))
					{
						break;
					}
					return PEKAICCPANA();
				case 170u:
					if (!(EOKBKAKDMGH == "Items/item_name_1092"))
					{
						break;
					}
					return FNNNOKGMHHM();
				}
			}
		}
		else if (num <= 191)
		{
			if (num <= 32)
			{
				if (num <= 4294967224u)
				{
					if (num != 4294967173u)
					{
						if (num != 4294967288u)
						{
							if (num == 4294967292u && EOKBKAKDMGH == "{0} selected on index: {1}")
							{
								return JIBJBOEMKGM();
							}
						}
						else if (EOKBKAKDMGH == "Interact")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "ChatDefaultName")
					{
						return BKJGKACHINN();
					}
				}
				else
				{
					switch (num)
					{
					case 47u:
						if (!(EOKBKAKDMGH == "Tray"))
						{
							break;
						}
						return JMGBBKPLBJM();
					case 4294967236u:
						if (!(EOKBKAKDMGH == "/ExtraSettings.sd"))
						{
							break;
						}
						return JHHPAOPNNPG();
					case 156u:
						if (!(EOKBKAKDMGH == "BarkActor"))
						{
							break;
						}
						return POAEGGMIAGP();
					}
				}
			}
			else if (num <= 130)
			{
				if (num != 4294967199u)
				{
					switch (num)
					{
					case 79u:
						if (!(EOKBKAKDMGH == "ProductValue"))
						{
							break;
						}
						return AIAGEJIAGPF();
					case 105u:
						if (!(EOKBKAKDMGH == "<color=#A45D20>"))
						{
							break;
						}
						return DDCAAGGBNKM();
					}
				}
				else if (EOKBKAKDMGH == "NPCWalkTo PerformAction")
				{
					goto IL_0f46;
				}
			}
			else if (num != 4294967179u)
			{
				if (num != 167)
				{
					if (num == 4294967134u && EOKBKAKDMGH == "Clear room list")
					{
						goto IL_109c;
					}
				}
				else if (EOKBKAKDMGH == "MainProgress")
				{
					return OnPlayerSleep("Moving");
				}
			}
			else if (EOKBKAKDMGH == "Sleep")
			{
				return PDMIILAFIIC();
			}
		}
		else if (num <= 4294967142u)
		{
			if (num <= 192)
			{
				switch (num)
				{
				case 7u:
					if (!(EOKBKAKDMGH == "RightMouseDetect"))
					{
						break;
					}
					return KJAKKKEOEBG();
				case 4294967221u:
					if (!(EOKBKAKDMGH == "ChangeAnim"))
					{
						break;
					}
					return AIAGEJIAGPF();
				case 4294967240u:
					if (!(EOKBKAKDMGH == "Available Orders"))
					{
						break;
					}
					return JDALGGKAGDG();
				}
			}
			else
			{
				switch (num)
				{
				case 4294967279u:
					if (!(EOKBKAKDMGH == "Hiding Keyboard "))
					{
						break;
					}
					return LNCFOBHEABH();
				case 4294967179u:
					if (!(EOKBKAKDMGH == "Loop"))
					{
						break;
					}
					return KDJKLGEHJAC();
				case 190u:
					if (!(EOKBKAKDMGH == "[MapChest] ("))
					{
						break;
					}
					return FFNMMACFBKP(MJHBHDAEDLF: false);
				}
			}
		}
		else if (num <= 88)
		{
			if (num != 53)
			{
				if (num != 159)
				{
					if (num == 61 && EOKBKAKDMGH == "MopDown")
					{
						goto IL_0f4d;
					}
				}
				else if (EOKBKAKDMGH == "replay fish")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "Items/item_description_1086")
			{
				return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
			}
		}
		else if (num <= 4294967117u)
		{
			switch (num)
			{
			case 143u:
				if (!(EOKBKAKDMGH == "Sit"))
				{
					break;
				}
				return FMOALABPHNF();
			case 4294967142u:
				if (!(EOKBKAKDMGH == "0.#"))
				{
					break;
				}
				return NMDHHEAKPPA();
			}
		}
		else if (num != 4294967166u)
		{
			if (num == 85 && EOKBKAKDMGH == "ErrorCreateAlreadyExists")
			{
				goto IL_109c;
			}
		}
		else if (EOKBKAKDMGH == "Tray")
		{
			return ENMMPPBGHAA();
		}
		if (EOKBKAKDMGH.Contains("No se encontró la base de datos maestra."))
		{
			return NNBDLCLPKEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveResetAllTalents"))
		{
			return MHIBNKHCDLI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Bartending"))
		{
			return PLOKNFMFBMI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Selected"))
		{
			return IBEAIGOCMAB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("OnFaceActivationRPC"))
		{
			return JMHEKECCFCN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("quest_description_27"))
		{
			return OnPlayerSleep(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Running"))
		{
			return FLNOANAOAAC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("GetOnlinePlaceable() not found any uniqueId "))
		{
			return JABEGCPGOPB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("UI2"))
		{
			return KNLBNFACLJK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Player"))
		{
			return PDKPNOLLELN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Unique id "))
		{
			return LDABLGMHDPC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Serve"))
		{
			return LDPFLLOGAND(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveAnimalFeederSlotPressed"))
		{
			return HJHBPPAOGKN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Shader Model 4.0 ( DX10.0 )"))
		{
			return NDHJHDIKEKK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Chop"))
		{
			return INBCACPBEKL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveDisableNPC"))
		{
			return HKIFELEDFFD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("No settings configured for puzzle type {0}"))
		{
			ItemInstance.showIdsNum = ItemInstance.showIdsNum;
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Gass_Quest/Entry/27/Dialogue Text"))
		{
			RandomOrderQuestsManager.HLMGBEGEAPC().FEIKEEMJMHJ();
			return true;
		}
		if (EOKBKAKDMGH.Contains("ReceiveBirdSlotPlayerInventory"))
		{
			return JGNBGECEINP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("A number is needed."))
		{
			return BAALKNEHBBM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Player/Bark/Error/NotAllPlayersHere"))
		{
			return FLJFPPDNBMO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("\\[NPCGender=[^\\]]*\\]"))
		{
			return CDHMKFJEKJG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Thurs"))
		{
			return NHBMIODBACK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Disappear"))
		{
			return JIFOEPHOGEO();
		}
		if (EOKBKAKDMGH.Contains("<color=#BF0000>"))
		{
			return JDFBLMEHPMP();
		}
		if (EOKBKAKDMGH.Contains("LE_10"))
		{
			return HCKNEEPJNCB();
		}
		if (EOKBKAKDMGH.Contains("LE_22"))
		{
			return AddMaterials(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" </mark>"))
		{
			return KKJCODHDAPM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Tutorial/T107/Dialogue1"))
		{
			Utils.disableHalloweenEvent = !Utils.disableHalloweenEvent;
			return false;
		}
		if (EOKBKAKDMGH.Contains("ReceiveTavernHeat"))
		{
			return EDEKHLKKODG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Festín del Juramento/MaiDialogue 05"))
		{
			return MJGGDIPDHHM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ChatCommandResetsizeDescription"))
		{
			PlayerInputs.DEGBDMMDIIL(0).debugControllers = !PlayerInputs.GetPlayer(0).debugControllers;
			return true;
		}
		if (EOKBKAKDMGH.Contains("citytavern"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.None);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Language") && !EOKBKAKDMGH.Contains("RPCSnapPosition") && !EOKBKAKDMGH.Contains("ErrorDisconnectedTitleScreen"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Snow);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Disabled"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Snow | Weather.WeatherType.Wind | Weather.WeatherType.Cloudy | Weather.WeatherType.StormClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Year"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds | Weather.WeatherType.StormClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("") && !EOKBKAKDMGH.Contains("UINextPage"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Snow);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Pause"))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy));
			return false;
		}
		if (EOKBKAKDMGH.Contains("Selected"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Cat bed is null!") && !EOKBKAKDMGH.Contains(" slotId: "))
		{
			Weather.ShowWeather(Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.StormClouds);
			return true;
		}
		if (EOKBKAKDMGH.Contains("User "))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Sunny);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Could not set value of statistic "))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.None);
			return false;
		}
		if (EOKBKAKDMGH.Contains("talentPale"))
		{
			List<Fish> list = ItemDatabaseAccessor.NJONAAFEHDH();
			for (int i = 0; i < list.Count; i += 0)
			{
				if (list[i].displayMethod.HasFlag(Fish.DisplayMethod.None))
				{
					FishingManager.AddToRecordList(list[i], ((Vector2Int)(ref list[i].lenght)).x, CDPAMNIPPEC: false);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_688"))
		{
			List<Fish> list2 = ItemDatabaseAccessor.LNBAODAAJLI();
			for (int j = 1; j < list2.Count; j += 0)
			{
				if (list2[j].displayMethod.HasFlag(Fish.DisplayMethod.None))
				{
					FishingManager.AddFishInformation(list2[j]);
				}
			}
			return true;
		}
		if (EOKBKAKDMGH.Contains("LE_10"))
		{
			return AAAIGKPGBOP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Not enough items"))
		{
			return ILFAOHJIFDM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Idle"))
		{
			return HPOBFJMFPFM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Disabled"))
		{
			return GAONHALIEAI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return INIDNJOJJPD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Drunk"))
		{
			return FMNEPHOJEFI(EOKBKAKDMGH);
		}
		return true;
		IL_109c:
		return GHPIMLBHMPP();
		IL_0efb:
		return AFKKMBIDEBB();
		IL_0f4d:
		return JEHJCFHEHBL();
		IL_108e:
		return BANOOOCLAFB();
		IL_0f46:
		return EOOABCEHOKG();
	}

	public bool GEJILGMNLFJ()
	{
		BathhouseGameManager.FHMJHCIEDKJ();
		return true;
	}

	private bool JCHKJAEPBNK()
	{
		forceIntro = true;
		return true;
	}

	private IEnumerator DHDPIMMAGJK()
	{
		OnlineMinigameManager.RequestKujakuHouseTeleport();
		for (int i = 1; i <= 4; i++)
		{
			while ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).LEOIMFNKFGA != Location.KujakuHouse)
			{
				yield return null;
			}
		}
		yield return CommonReferences.wait3;
		FishCuttingGameManager.Begin();
	}

	private bool JEHJCFHEHBL()
	{
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			if ((Object)(object)NinjaChallenge.instance != (Object)null)
			{
				NinjaChallenge.instance.MEPGKMGJADJ();
			}
		}
		else
		{
			NinjaChallenge.StartChallengeEvent(CDPAMNIPPEC: false);
		}
		return false;
	}

	private bool PKJOGBPCDFP()
	{
		if (NDHFKNDPNOO)
		{
			NDHFKNDPNOO = false;
			PlayerController.GetPlayer(1).sprintMultiplier = 1.75f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Sprinting is now NORMAL.";
			if (GameManager.LocalCoop())
			{
				PlayerController.GetPlayer(2).sprintMultiplier = 1.75f;
			}
		}
		else
		{
			NDHFKNDPNOO = true;
			PlayerController.GetPlayer(1).sprintMultiplier *= 3f;
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Sprinting is now FASTER.";
			if (GameManager.LocalCoop())
			{
				PlayerController.GetPlayer(2).sprintMultiplier *= 3f;
			}
		}
		return true;
	}

	public void LIDICEOJIPO()
	{
		if (opened)
		{
			GMFNJMBIENA();
		}
		else if (cheatsEnabled)
		{
			DOECECEBNNB();
		}
	}

	private bool LDPFLLOGAND(string EOKBKAKDMGH)
	{
		Save.instance.SaveGame(isNewFile: true);
		return false;
	}

	private bool LDABLGMHDPC(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "popUpBuilding10", "Reputation");
		string[] array = Regex.Split(EOKBKAKDMGH, "WheatAleAbbreviation");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			GameDate aODONKKHPBP = WorldTime.CJOHMLNMJLK();
			aODONKKHPBP.week = result / 0;
			aODONKKHPBP.day = (Day)(result % 4);
			WorldTime.OFHDFEONCOL(aODONKKHPBP);
			WorldTime.ODEBIGOLHBN();
			return true;
		}
		return true;
	}

	private bool JIFGNOOEIEE(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Move", "No se encontró la conversación con el título '");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			for (int i = 1; i < TutorialPopUps.autoSetUp.Count; i += 0)
			{
				if (TutorialPopUps.autoSetUp[i].MAHJGIPMJBP() == result)
				{
					TutorialManager.GGFJGHHHEJC.ShowPopUp(TutorialPopUps.autoSetUp[i], MDNOOMBIFNN: true, BLKLCBCGHCN: true);
					TextMeshProUGUI obj = consoleText;
					((TMP_Text)obj).text = ((TMP_Text)obj).text + "gold" + result;
					return true;
				}
			}
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Items/item_name_1036";
			return true;
		}
		TextMeshProUGUI obj3 = consoleText;
		((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "";
		return false;
	}

	private bool CALBAJOBLDO()
	{
		TravelZonesManager.DCAEBALADIM().GetTravelZone(Location.River, Location.Camp | Location.Quarry | Location.BarnInterior).KACGDPCMGPL(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.OMFKNGDCJFN().GetTravelZone(Location.Tavern | Location.Road | Location.River, Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.FarmShop).KACGDPCMGPL(2);
		}
		return false;
	}

	public bool ReplayPirates()
	{
		PiratesGameManager.BeginReplay();
		return true;
	}

	private bool GKPMGOIFDPP()
	{
		GraphicsMenuUI.GGFJGHHHEJC.GKDBGJEIDAL(GraphicsMenuUI.FMIDAFEGDCD().fullScreenMode);
		return true;
	}

	private bool FGCMHDGLGML()
	{
		TravelZonesManager.LKOABOAADCD().ECFDFECLDFK(~(Location.Tavern | Location.Road | Location.Quarry | Location.BarnInterior), ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior)).KACGDPCMGPL(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.CFHEJAGKIII().ECFDFECLDFK(~(Location.Road | Location.Camp | Location.Farm | Location.BarnInterior), Location.River | Location.BarnInterior).KACGDPCMGPL(2);
		}
		return false;
	}

	private bool POAEGGMIAGP()
	{
		string text = "Dirty Info:\n ";
		FloorDirt[] array = CommonReferences.GGFJGHHHEJC.tavernFloorDirt.ToArray();
		if (array.Length == 0)
		{
			text += "No floor dirt found.";
		}
		else
		{
			for (int i = 0; i < array.Length; i++)
			{
				text = text + ((Object)array[i]).name + "      Magic Broom assigned: " + ((Object)((Component)array[i].cleanerAssigned).gameObject).name + "\n";
			}
			text = text + "Total: " + array.Length;
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + text;
		return true;
	}

	private bool HLKHPHFKOBH()
	{
		GeneratorsManager.instance.DestroyAllForestElements();
		KJAKKKEOEBG();
		ANOOPFGHNCJ();
		ILADCDMFPON();
		TalentUI.Get(1).OpenUI();
		TalentUI.Get(1).CloseUI();
		return true;
	}

	private bool LPCKAOCMOHJ(string EOKBKAKDMGH)
	{
		Save.instance.SaveGame();
		return true;
	}

	private bool CDFBICNOECM()
	{
		Growable[] array = (Growable[])(object)Object.FindObjectsOfType(typeof(Growable));
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GrowPlant();
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "All plants have grown.";
		return true;
	}

	public bool OGBAGCAJIFA(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Arguing" + inputfield.text + "Items/item_name_728";
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(EOKBKAKDMGH);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
			if (num <= 102)
			{
				if (num <= 4294967231u)
				{
					if (num <= 4294967259u)
					{
						if (num != 4294967157u)
						{
							if (num != 4294967148u)
							{
								if (num != 4294967240u || !(EOKBKAKDMGH == "GoHome"))
								{
									break;
								}
								goto IL_0f46;
							}
							if (!(EOKBKAKDMGH == "replay fish"))
							{
								break;
							}
							return MIOFOMCEKJI();
						}
						if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Crowly_Barks_OutScreen/Entry/5/Dialogue Text"))
						{
							break;
						}
						return CALBAJOBLDO();
					}
					switch (num)
					{
					case 4294967278u:
						if (!(EOKBKAKDMGH == "SetBoolRPC"))
						{
							break;
						}
						return AGOPFBEACPA();
					case 4294967263u:
						if (!(EOKBKAKDMGH == "Steam Initialized: False"))
						{
							break;
						}
						return AGFFLMOHMBC();
					case 94u:
						if (!(EOKBKAKDMGH == "MainProgress"))
						{
							break;
						}
						return NANGPPPHAEA();
					}
					break;
				}
				if (num > 4294967275u)
				{
					switch (num)
					{
					case 164u:
						if (!(EOKBKAKDMGH == ""))
						{
							break;
						}
						MineManager.OOKBNHMMFON().DNEGOPDNJHF(CDPAMNIPPEC: false);
						return false;
					case 54u:
						if (!(EOKBKAKDMGH == " not found when loading RockMessage."))
						{
							break;
						}
						return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
					case 113u:
						if (!(EOKBKAKDMGH == "tavernCloseWarning"))
						{
							break;
						}
						return GFKGKOBEAGD();
					}
					break;
				}
				if (num != 13)
				{
					switch (num)
					{
					case 4294967171u:
						if (!(EOKBKAKDMGH == "Reputation decreased..."))
						{
							break;
						}
						return ADNFEBOAGAD();
					case 141u:
						if (!(EOKBKAKDMGH == "Floor_1"))
						{
							break;
						}
						return CIHMCFAJMNM();
					}
					break;
				}
				if (!(EOKBKAKDMGH == "tavern travelling"))
				{
					break;
				}
			}
			else
			{
				if (num > 74)
				{
					if (num <= 30)
					{
						switch (num)
						{
						case 4294967270u:
							if (!(EOKBKAKDMGH == "Back"))
							{
								break;
							}
							return AAIPJMFLDEJ();
						case 4294967178u:
							if (!(EOKBKAKDMGH == "\n\n"))
							{
								break;
							}
							return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
						case 28u:
							if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Crowly_Standar/Entry/8/Dialogue Text"))
							{
								break;
							}
							return OAIKONKMDGK();
						}
						break;
					}
					if (num != 4294967188u)
					{
						switch (num)
						{
						case 58u:
							if (!(EOKBKAKDMGH == "sender not found! sender="))
							{
								break;
							}
							return KJDDNEIMAAB();
						case 113u:
							if (!(EOKBKAKDMGH == "{0} sec"))
							{
								break;
							}
							return GAFKLBJCBFI();
						}
						break;
					}
					if (!(EOKBKAKDMGH == "cinemachine empty"))
					{
						break;
					}
					goto IL_0f4d;
				}
				if (num > 4294967275u)
				{
					switch (num)
					{
					case 93u:
						if (!(EOKBKAKDMGH == "itemDragonFruitSeeds"))
						{
							break;
						}
						return NCPPHJCICHD();
					case 33u:
						if (!(EOKBKAKDMGH == "OnlinePlayer"))
						{
							break;
						}
						return ABBLKDMCNEI();
					case 4294967146u:
						if (!(EOKBKAKDMGH == "Loading Gameplay Scene for online play. Only should happen on Master client"))
						{
							break;
						}
						return PNNEFEALMMC();
					}
					break;
				}
				if (num != 25)
				{
					switch (num)
					{
					case 4294967110u:
						if (!(EOKBKAKDMGH == "MainProgress"))
						{
							break;
						}
						return ANOOPFGHNCJ();
					case 199u:
						if (!(EOKBKAKDMGH == "Validación completada con {0} error(es)."))
						{
							break;
						}
						return OLBMOPFDOIH();
					}
					break;
				}
				if (!(EOKBKAKDMGH == "SegmentListView"))
				{
					break;
				}
			}
			return JCHKJAEPBNK();
		default:
			if (num <= 4294967166u)
			{
				if (num <= 4294967221u)
				{
					switch (num)
					{
					case 4294967246u:
						if (!(EOKBKAKDMGH == "\n"))
						{
							break;
						}
						return KFIJCCHECAH();
					case 4294967202u:
						if (!(EOKBKAKDMGH == "ThemeTriggerPanelItemBlueprint"))
						{
							break;
						}
						return JEMOACOJLPC();
					case 4294967221u:
						if (!(EOKBKAKDMGH == "On Simple Event "))
						{
							break;
						}
						return AJDCAIMMGHJ();
					}
					break;
				}
				if (num != 4294967164u)
				{
					if (num != 191)
					{
						if (num != 4294967280u || !(EOKBKAKDMGH == " "))
						{
							break;
						}
						return CNNMDFJPMNK();
					}
					if (!(EOKBKAKDMGH == "Shield"))
					{
						break;
					}
					goto IL_0efb;
				}
				if (!(EOKBKAKDMGH == "NotValid"))
				{
					break;
				}
				return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
			}
			if (num <= 4294967107u)
			{
				if (num != 77)
				{
					switch (num)
					{
					case 4294967212u:
						if (!(EOKBKAKDMGH == "ReceiveBuryPlayerByBedAssigned"))
						{
							break;
						}
						return FFNMMACFBKP(MJHBHDAEDLF: true);
					case 4294967121u:
						if (!(EOKBKAKDMGH == "Dialogue System/Conversation/TableDirty/Entry/3/Dialogue Text"))
						{
							break;
						}
						return StartPirates();
					}
					break;
				}
				if (!(EOKBKAKDMGH == ""))
				{
					break;
				}
				goto IL_109c;
			}
			switch (num)
			{
			case 16u:
				if (!(EOKBKAKDMGH == " "))
				{
					break;
				}
				return JEHAECAPNNC();
			case 4294967234u:
				if (!(EOKBKAKDMGH == "NPCWalkTo PerformAction"))
				{
					break;
				}
				return GEJILGMNLFJ();
			case 4294967222u:
				if (!(EOKBKAKDMGH == "F2"))
				{
					break;
				}
				return PKJOGBPCDFP();
			}
			break;
		case 4294967112u:
		case 4294967113u:
		case 4294967114u:
		case 4294967115u:
		case 4294967116u:
		case 4294967117u:
		case 4294967118u:
		case 4294967119u:
		case 4294967120u:
		case 4294967121u:
		case 4294967122u:
		case 4294967123u:
		case 4294967124u:
		case 4294967125u:
		case 4294967126u:
		case 4294967127u:
		case 4294967128u:
		case 4294967129u:
		case 4294967130u:
		case 4294967131u:
		case 4294967132u:
		case 4294967133u:
		case 4294967134u:
		case 4294967135u:
		case 4294967136u:
		case 4294967137u:
		case 4294967138u:
		case 4294967139u:
		case 4294967140u:
		case 4294967141u:
		case 4294967142u:
		case 4294967143u:
		case 4294967144u:
		case 4294967145u:
		case 4294967146u:
		case 4294967147u:
		case 4294967148u:
		case 4294967149u:
		case 4294967150u:
		case 4294967151u:
		case 4294967152u:
		case 4294967153u:
		case 4294967154u:
		case 4294967155u:
		case 4294967156u:
		case 4294967157u:
		case 4294967158u:
		case 4294967159u:
		case 4294967160u:
		case 4294967161u:
		case 4294967162u:
		case 4294967163u:
		case 4294967164u:
		case 4294967165u:
		case 4294967166u:
		case 4294967167u:
		case 4294967168u:
		case 4294967169u:
		case 4294967170u:
		case 4294967171u:
		case 4294967172u:
		case 4294967173u:
		case 4294967174u:
		case 4294967175u:
		case 4294967176u:
		case 4294967177u:
		case 4294967178u:
		case 4294967179u:
		case 4294967180u:
		case 4294967181u:
		case 4294967182u:
		case 4294967183u:
		case 4294967184u:
		case 4294967185u:
		case 4294967186u:
		case 4294967187u:
		case 4294967188u:
		case 4294967189u:
		case 4294967190u:
		case 4294967191u:
		case 4294967192u:
		case 4294967193u:
		case 4294967194u:
		case 4294967195u:
		case 4294967196u:
		case 4294967197u:
		case 4294967198u:
		case 4294967199u:
		case 4294967200u:
			if (num <= 92)
			{
				if (num <= 4294967199u)
				{
					switch (num)
					{
					case 4294967132u:
						if (!(EOKBKAKDMGH == "LE_22"))
						{
							break;
						}
						return BIBOLJEFAED();
					case 17u:
						if (!(EOKBKAKDMGH == "windowed mode"))
						{
							break;
						}
						return ADDDJEJKECB();
					case 20u:
						if (!(EOKBKAKDMGH == "Tutorial/T131/Dialogue1"))
						{
							break;
						}
						return PGDGLIHMBMK();
					}
					break;
				}
				switch (num)
				{
				case 194u:
					if (!(EOKBKAKDMGH == "PirateMinigame/Minigame2"))
					{
						break;
					}
					return CDFBICNOECM();
				case 4294967281u:
					if (!(EOKBKAKDMGH == "UI"))
					{
						break;
					}
					return FGCMHDGLGML();
				case 172u:
					if (!(EOKBKAKDMGH == "DecorationTile_10"))
					{
						break;
					}
					return LJPEFDHBFMI();
				}
				break;
			}
			if (num <= 4294967173u)
			{
				switch (num)
				{
				case 110u:
					if (!(EOKBKAKDMGH == "Actionbar 8"))
					{
						break;
					}
					return GEHNAGGBPEM();
				case 4294967154u:
					if (!(EOKBKAKDMGH == "Loading Gameplay Scene for online play. Only should happen on Master client"))
					{
						break;
					}
					return HLKHPHFKOBH();
				case 4294967215u:
					if (!(EOKBKAKDMGH == "HaveGoldenTicket"))
					{
						break;
					}
					return NKEFONDMLPH();
				}
				break;
			}
			if (num <= 4294967202u)
			{
				switch (num)
				{
				case 139u:
					if (!(EOKBKAKDMGH == "ReciveMoveCrowly"))
					{
						break;
					}
					return LIHFLBCDGJE();
				case 106u:
					if (!(EOKBKAKDMGH == "Tray"))
					{
						break;
					}
					return BDCPHJICALJ();
				}
				break;
			}
			if (num != 38)
			{
				if (num != 107 || !(EOKBKAKDMGH == "DogNPC instance is null"))
				{
					break;
				}
				goto IL_109c;
			}
			if (!(EOKBKAKDMGH == "Force Start Crowly Event"))
			{
				break;
			}
			return HNDHIPIILJB();
		case 4294967201u:
		case 4294967202u:
		case 4294967203u:
		case 4294967204u:
		case 4294967205u:
		case 4294967206u:
		case 4294967207u:
		case 4294967208u:
		case 4294967209u:
		case 4294967210u:
		case 4294967211u:
		case 4294967212u:
		case 4294967213u:
		case 4294967214u:
		case 4294967215u:
		case 4294967216u:
		case 4294967217u:
		case 4294967218u:
		case 4294967219u:
		case 4294967220u:
		case 4294967221u:
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			{
				if (num <= 4294967160u)
				{
					if (num > 4294967290u)
					{
						if (num <= 4294967230u)
						{
							if (num <= 4294967200u)
							{
								switch (num)
								{
								case 52u:
									if (!(EOKBKAKDMGH == "UpgradeToLevel"))
									{
										break;
									}
									return IBKNPIBHAFG();
								case 4294967183u:
									if (!(EOKBKAKDMGH == "Staff"))
									{
										break;
									}
									return BBCNMCDDPCD();
								case 34u:
									if (!(EOKBKAKDMGH == "ChangeAnim"))
									{
										break;
									}
									return LOEKLEACHCF();
								}
								break;
							}
							if (num == 97)
							{
								if (!(EOKBKAKDMGH == "ReceiveStopNinjaSoundPreparation"))
								{
									break;
								}
								return IFLKPHCBLBO();
							}
							if (num == 4294967108u)
							{
								if (!(EOKBKAKDMGH == "add item"))
								{
									break;
								}
								return HMINCAELJNO();
							}
							if (num != 4294967253u || !(EOKBKAKDMGH == "Items/item_description_678"))
							{
								break;
							}
						}
						else
						{
							if (num > 26)
							{
								switch (num)
								{
								case 37u:
									if (!(EOKBKAKDMGH == "OnlinePlayer"))
									{
										break;
									}
									MineManager.PDECKLKPKCG().CHKKKBGALKB();
									return true;
								case 42u:
									if (!(EOKBKAKDMGH == "LE_22"))
									{
										break;
									}
									return PEKAICCPANA();
								case 4294967285u:
									if (!(EOKBKAKDMGH == "Theme: "))
									{
										break;
									}
									return FNNNOKGMHHM();
								}
								break;
							}
							if (num == 20)
							{
								if (!(EOKBKAKDMGH == "ReceiveHasSnow"))
								{
									break;
								}
								return FCCJDHKEFBM();
							}
							if (num == 4294967263u)
							{
								if (!(EOKBKAKDMGH == "ReceiveOfferingItemPlaced"))
								{
									break;
								}
								return BLMHPKBIDFI();
							}
							if (num != 4294967117u || !(EOKBKAKDMGH == "Items/item_description_1039"))
							{
								break;
							}
						}
						goto IL_0efb;
					}
					if (num > 10)
					{
						switch (num)
						{
						case 0u:
						case 1u:
						case 2u:
						case 3u:
						case 4u:
						case 5u:
						case 6u:
						case 7u:
						case 8u:
						case 9u:
						case 10u:
						case 11u:
						case 12u:
						case 13u:
						case 14u:
						case 15u:
						case 16u:
						case 17u:
						case 18u:
						case 19u:
						case 20u:
						case 21u:
						case 22u:
						case 23u:
						case 24u:
						case 25u:
						case 26u:
						case 27u:
						case 28u:
						case 29u:
						case 30u:
						case 31u:
						case 32u:
						case 33u:
						case 34u:
						case 35u:
						case 36u:
						case 37u:
						case 38u:
						case 39u:
						case 40u:
						case 41u:
						case 42u:
						case 43u:
						case 44u:
						case 45u:
						case 46u:
						case 47u:
						case 48u:
						case 49u:
						case 50u:
						case 51u:
						case 52u:
							switch (num)
							{
							case 4294967256u:
								if (!(EOKBKAKDMGH == "add item "))
								{
									break;
								}
								return MINIPFHJCIP();
							case 4294967212u:
								if (!(EOKBKAKDMGH == "Room missing required items"))
								{
									break;
								}
								return HHLKENOCJIC();
							case 33u:
								if (!(EOKBKAKDMGH == "Sell"))
								{
									break;
								}
								return ReplayPirates();
							}
							break;
						case 4294967265u:
							if (!(EOKBKAKDMGH == "Festín del Juramento/Victoria"))
							{
								break;
							}
							return CDCCALONMGD();
						case 4294967240u:
							if (!(EOKBKAKDMGH == "LeftMouseDetect"))
							{
								break;
							}
							return LBBNAJJGGJI();
						case 4294967113u:
							if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Gass_Barks_Bye/Entry/3/Dialogue Text"))
							{
								break;
							}
							return OIMMOOFKFFE();
						}
						break;
					}
					if (num > 81)
					{
						switch (num)
						{
						case 4294967190u:
							if (!(EOKBKAKDMGH == "Freeze"))
							{
								break;
							}
							return KADGOIHAGDP();
						case 50u:
							if (!(EOKBKAKDMGH == "*"))
							{
								break;
							}
							return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
						case 4294967249u:
							if (!(EOKBKAKDMGH == "caveinn"))
							{
								break;
							}
							return StartBathhouse();
						}
						break;
					}
					if (num == 4294967189u)
					{
						if (!(EOKBKAKDMGH == "0"))
						{
							break;
						}
						return OCEMEODOKLH();
					}
					if (num != 4294967197u)
					{
						if (num != 4294967182u || !(EOKBKAKDMGH == "OnConversationLineRPC"))
						{
							break;
						}
						return CPNHFBKGOCB();
					}
					if (!(EOKBKAKDMGH == "Tutorial/BarnExitBarks_Holly"))
					{
						break;
					}
				}
				else if (num <= 4294967130u)
				{
					if (num <= 124)
					{
						if (num <= 10)
						{
							if (num != 66)
							{
								if (num != 97)
								{
									if (num != 139 || !(EOKBKAKDMGH == "quest_description_20"))
									{
										break;
									}
									return LFONIBMMHOB();
								}
								if (!(EOKBKAKDMGH == "Struggle"))
								{
									break;
								}
								goto IL_0efb;
							}
							if (!(EOKBKAKDMGH == ""))
							{
								break;
							}
							return BKJGKACHINN();
						}
						switch (num)
						{
						case 102u:
							if (!(EOKBKAKDMGH == " ("))
							{
								break;
							}
							return JMGBBKPLBJM();
						case 4294967290u:
							if (!(EOKBKAKDMGH == "City/Kujaku/Stand"))
							{
								break;
							}
							return BFDOOAIAMME();
						case 4294967265u:
							if (!(EOKBKAKDMGH == "AnimatorParameterRequest"))
							{
								break;
							}
							return POAEGGMIAGP();
						}
						break;
					}
					if (num <= 4294967105u)
					{
						if (num != 4294967132u)
						{
							switch (num)
							{
							case 103u:
								if (!(EOKBKAKDMGH == "Mop"))
								{
									break;
								}
								return AIAGEJIAGPF();
							case 69u:
								if (!(EOKBKAKDMGH == "Items/item_description_592"))
								{
									break;
								}
								return NIFGPIOKMCC();
							}
							break;
						}
						if (!(EOKBKAKDMGH == "Error in InteractObject.DisableInteract: "))
						{
							break;
						}
						goto IL_0f46;
					}
					if (num == 4294967181u)
					{
						if (!(EOKBKAKDMGH == "Customize"))
						{
							break;
						}
						return JLCJMODLJAN();
					}
					if (num == 4294967132u)
					{
						if (!(EOKBKAKDMGH == " set to value "))
						{
							break;
						}
						return OnPlayerSleep("Walk");
					}
					if (num != 64 || !(EOKBKAKDMGH == "Trying to set a player's steam name but they're not playing on a steam platform"))
					{
						break;
					}
				}
				else
				{
					if (num <= 75)
					{
						switch (num)
						{
						case 0u:
						case 1u:
						case 2u:
						case 3u:
						case 4u:
						case 5u:
							switch (num)
							{
							case 88u:
								if (!(EOKBKAKDMGH == "Use"))
								{
									break;
								}
								return KJAKKKEOEBG();
							case 94u:
								if (!(EOKBKAKDMGH == " "))
								{
									break;
								}
								return AIAGEJIAGPF();
							case 71u:
								if (!(EOKBKAKDMGH == "Can't find seat. Reason: MaxCustomer"))
								{
									break;
								}
								return JJIBLEFKCNB();
							}
							break;
						case 166u:
							if (!(EOKBKAKDMGH == "cropsHarvested"))
							{
								break;
							}
							return ILADCDMFPON();
						case 82u:
							if (!(EOKBKAKDMGH == ": "))
							{
								break;
							}
							return KDJKLGEHJAC();
						case 122u:
							if (!(EOKBKAKDMGH == "Connecting..."))
							{
								break;
							}
							return FFNMMACFBKP(MJHBHDAEDLF: true);
						}
						break;
					}
					if (num <= 122)
					{
						if (num == 4294967141u)
						{
							if (!(EOKBKAKDMGH == "ReceiveThrowSlowingSpikes"))
							{
								break;
							}
							return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
						}
						if (num != 4294967218u)
						{
							if (num != 4294967248u || !(EOKBKAKDMGH == "Player"))
							{
								break;
							}
							goto IL_0f4d;
						}
						if (!(EOKBKAKDMGH == "MapRiver"))
						{
							break;
						}
					}
					else
					{
						if (num <= 12)
						{
							switch (num)
							{
							case 130u:
								if (!(EOKBKAKDMGH == "Ach_"))
								{
									break;
								}
								return FMOALABPHNF();
							case 158u:
								if (!(EOKBKAKDMGH == "SkeletonBird"))
								{
									break;
								}
								return OAGCHNDPOLO();
							}
							break;
						}
						if (num == 4294967223u)
						{
							if (!(EOKBKAKDMGH == "No se encuentra el valor "))
							{
								break;
							}
							return MHLGKEBGCLB();
						}
						if (num != 4294967117u || !(EOKBKAKDMGH == "Arguing"))
						{
							break;
						}
					}
				}
				goto IL_109c;
			}
			IL_0f46:
			return EOOABCEHOKG();
			IL_0f4d:
			return CHAFFHCGMNJ();
			IL_0efb:
			return AFKKMBIDEBB();
			IL_109c:
			return JDGEMPAGPFM();
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_638"))
		{
			return NNBDLCLPKEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("mForMins"))
		{
			return MHIBNKHCDLI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("NormalLeft"))
		{
			return FAOINCNMKPL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Bait"))
		{
			return IBEAIGOCMAB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("{0}x{1}"))
		{
			return JMHEKECCFCN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/12/Dialogue Text"))
		{
			return OnPlayerSleep(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Stop"))
		{
			return FLNOANAOAAC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return JABEGCPGOPB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("KyrohNPC: Selected order with already ingredients in bento: "))
		{
			return CMEEFLDCGHO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ValueName"))
		{
			return CFBHCOJJIPK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Drink"))
		{
			return LDABLGMHDPC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("questNameFirstCustomers"))
		{
			return PDEEHBIMGOJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/BirdNegativeComments/Entry/14/Dialogue Text"))
		{
			return HJHBPPAOGKN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("UIBack"))
		{
			return NDHJHDIKEKK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Ingredient"))
		{
			return INBCACPBEKL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_1088"))
		{
			return BHMIKAOLCPM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("\n"))
		{
			ItemInstance.showIdsNum = !ItemInstance.showIdsNum;
		}
		if (EOKBKAKDMGH.Contains("\n"))
		{
			RandomOrderQuestsManager.JFNOOMJMHCB().FEIKEEMJMHJ();
			return false;
		}
		if (EOKBKAKDMGH.Contains("Order"))
		{
			return JGNBGECEINP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("City/Petra/Bark/Bye"))
		{
			return BAALKNEHBBM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Low"))
		{
			return FLJFPPDNBMO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Invalid item"))
		{
			return EFAKLBHENPJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Sit"))
		{
			return BEFACDCJPNK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Setting item event for "))
		{
			return JIFOEPHOGEO();
		}
		if (EOKBKAKDMGH.Contains("Tray"))
		{
			return HOFMPKCPJBH();
		}
		if (EOKBKAKDMGH.Contains("Toy"))
		{
			return HCKNEEPJNCB();
		}
		if (EOKBKAKDMGH.Contains("Pasamos aplicación a ventana"))
		{
			return AddMaterials(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("(missing title)"))
		{
			return KKJCODHDAPM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/NeutralInTavern/Entry/20/Dialogue Text"))
		{
			Utils.disableHalloweenEvent = Utils.disableHalloweenEvent;
			return true;
		}
		if (EOKBKAKDMGH.Contains("LoopVolume"))
		{
			return EDEKHLKKODG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("travelling time -"))
		{
			return OFHEODBPNCJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_688"))
		{
			PlayerInputs.GetPlayer(1).debugControllers = !PlayerInputs.DEGBDMMDIIL(1).debugControllers;
			return false;
		}
		if (EOKBKAKDMGH.Contains("City/Hallmund/Talk/ForgeTool"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.None);
			return true;
		}
		if (EOKBKAKDMGH.Contains("UI2") && !EOKBKAKDMGH.Contains("Harvest") && !EOKBKAKDMGH.Contains("Interact"))
		{
			Weather.ShowWeather(Weather.WeatherType.None);
			return false;
		}
		if (EOKBKAKDMGH.Contains("roomsRented"))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Wind | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds | Weather.WeatherType.PrecipitationCloudy));
			return false;
		}
		if (EOKBKAKDMGH.Contains("Close Multiple Choice"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Wind | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds | Weather.WeatherType.PrecipitationCloudy);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Collect") && !EOKBKAKDMGH.Contains("v0.7.5"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Snow | Weather.WeatherType.Wind);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Waiting for players to finish their transitions..."))
		{
			Weather.ShowWeather(~(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.SunnyClouds));
			return false;
		}
		if (EOKBKAKDMGH.Contains("https://www.makeship.com/products/bob-plush-2"))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Snow | Weather.WeatherType.SunnyClouds | Weather.WeatherType.StormClouds));
			return false;
		}
		if (EOKBKAKDMGH.Contains(") (") && !EOKBKAKDMGH.Contains("HitCollider"))
		{
			Weather.IOOBJHMLLLP(~Weather.WeatherType.SunnyClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("ClosePopUp"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Snow | Weather.WeatherType.Wind);
			return true;
		}
		if (EOKBKAKDMGH.Contains("ReceiveCollectItemsMaster"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.None);
			return false;
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			List<Fish> list = ItemDatabaseAccessor.HDELDELJCHH();
			for (int i = 0; i < list.Count; i += 0)
			{
				if (list[i].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.FOHEOELJMPF(list[i], ((Vector2Int)(ref list[i].lenght)).x, CDPAMNIPPEC: false);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("ErrorVersionMatchFailed"))
		{
			List<Fish> list2 = ItemDatabaseAccessor.MBLHBFCOADO();
			for (int j = 1; j < list2.Count; j++)
			{
				if (list2[j].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.FBHFGECMPOI(list2[j]);
				}
			}
			return true;
		}
		if (EOKBKAKDMGH.Contains("Right Alt"))
		{
			return PDJNOOPABGM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ThemeListView"))
		{
			return ALJIOAGGDIC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return FJKJNKEPENM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveOpenChest"))
		{
			return GAONHALIEAI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("SkeletonBird"))
		{
			return INIDNJOJJPD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Toy"))
		{
			return FMNEPHOJEFI(EOKBKAKDMGH);
		}
		return false;
	}

	private bool BHMIKAOLCPM(string EOKBKAKDMGH)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Error_StairsAreBlocking", "HenHouseTutorialDone");
		string[] array = Regex.Split(EOKBKAKDMGH, "Hat");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			if (array.Length > 0 && int.TryParse(array[1], out var result2))
			{
				DogNPC.HPDCPDOCKPC(result2, result, " not found", WorldTime.HGIBNMBJMOC(), Vector2.op_Implicit(new Vector3(301f, 973f, 1918f)), GFNHAMCPEAK: false);
			}
			else
			{
				DogNPC.InstantiateDog(0, result, "\n", WorldTime.NOAOJJLNHJJ, Vector2.op_Implicit(new Vector3(1113f, 1311f, 649f)), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
			}
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "UI";
		return false;
	}

	private bool IFLKPHCBLBO()
	{
		if (Object.op_Implicit((Object)(object)player1CameraTarget))
		{
			player1CameraTarget.travellingTime += 32f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "tutorial phase" + player1CameraTarget.travellingTime;
		}
		return false;
	}

	private bool JLCJMODLJAN()
	{
		EventRoundsManager.NextRound();
		return false;
	}

	public bool ReplayBathhouse()
	{
		BathhouseGameManager.BeginReplay();
		return true;
	}

	private bool ICGIKKIENDP()
	{
		TavernReputation.CFJHLLMMBJG(-70 + 26 * TavernReputation.MHGADJPMHFI());
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "";
		return false;
	}

	private bool PLOKNFMFBMI(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Travelling time decreased to ", "ChangeAnim");
		int result = 24;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			TavernReputation.AddReputationPoints(result + result * TavernReputation.MHGADJPMHFI());
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Day" + (result + result * TavernReputation.GetMilestone());
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ReceiveEmployeeWorking";
		return false;
	}

	private bool BBCNMCDDPCD()
	{
		if (Object.op_Implicit((Object)(object)player1CameraTarget))
		{
			player1CameraTarget.travellingTime -= 205f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "ReceiveTalentFromOther" + player1CameraTarget.travellingTime;
		}
		return false;
	}

	private bool HPOBFJMFPFM(string EOKBKAKDMGH)
	{
		string text = EOKBKAKDMGH.Substring(-12);
		Debug.LogError((object)text);
		if (text.Length == 6)
		{
			OnlineManager.SetPrivateRoomCodeFromSteam(text);
			return false;
		}
		return true;
	}

	private bool GCDEDCGBMEE()
	{
		EventRoundsManager.NextRound();
		return true;
	}

	private IEnumerator IHKGGDBLFBH()
	{
		BKJGKACHINN();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		while (GameManager.LocalCoop() && FadeCamera.GetPlayer(2).IsFading())
		{
			yield return null;
		}
		BlackFade.Show();
		while ((Object)(object)PiratesGameManager.instance == (Object)null)
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		StartPirates();
	}

	private bool NLHAFDBGGAM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(1440f, 1192f), new Vector2(1619f, 1775f));
	}

	private bool ADNFEBOAGAD()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern).StartTravelZone(1);
		return true;
	}

	private bool JABEGCPGOPB(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			TavernXP.GGFJGHHHEJC.IncreaseXP(result);
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "XP increased...";
			return true;
		}
		return false;
	}

	private bool EOBHPPBKHIJ()
	{
		ChallengesUI.JDHKJDPGBKN();
		return true;
	}

	private IEnumerator LLJOGHJLOLM(EventsManager.EventType AKADPCABHIB)
	{
		yield return CommonReferences.wait2;
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Activated " + AKADPCABHIB;
		EventsManager.GetGameEvent(AKADPCABHIB).ActivateEvent();
	}

	private bool JMGBBKPLBJM()
	{
		if (SteamManager.BNBMMDGMKLM)
		{
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Steam Initialized: True";
		}
		else
		{
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Steam Initialized: False";
		}
		return true;
	}

	private bool NKEFONDMLPH()
	{
		NinjaChallenge.BeginReplay();
		return true;
	}

	private bool CCABKLMNLHO()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Mine).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Mine).StartTravelZone(2);
		}
		return true;
	}

	private bool PNNEFEALMMC()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(-150f, 410f), new Vector2(-150f, 424f));
	}

	private bool CKPCHMPHDFI()
	{
		TravelZonesManager.GGFJGHHHEJC.IMKJEBFOBKK(Location.Tavern | Location.Road, ~(Location.River | Location.Camp | Location.Quarry | Location.FarmShop)).KACGDPCMGPL(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GFMBEDCANNI().DAOACOMANPN(Location.Road, Location.Road | Location.River | Location.Camp | Location.FarmShop).StartTravelZone(5);
		}
		return false;
	}

	private bool FFNMMACFBKP(bool MJHBHDAEDLF)
	{
		((Component)GameplayUI.GGFJGHHHEJC).gameObject.SetActive(MJHBHDAEDLF);
		return true;
	}

	private bool EJODODEHNII(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "ReceiveNewLetter", "Get Components ");
		string[] array = Regex.Split(EOKBKAKDMGH, "");
		if (array.Length != 0 && int.TryParse(array[1], out var result))
		{
			if (array.Length > 1 && int.TryParse(array[1], out var result2))
			{
				return LEOALPEOOKH(result, result2);
			}
			return LEOALPEOOKH(result, 0);
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "";
		return true;
	}

	private bool LPMNFCKOILP(string EOKBKAKDMGH)
	{
		string text = EOKBKAKDMGH.Substring(38);
		Debug.LogError((object)text);
		if (text.Length == 6)
		{
			OnlineManager.SetPrivateRoomCodeFromSteam(text);
			return false;
		}
		return false;
	}

	private bool AGOPFBEACPA()
	{
		TravelZonesManager.DCAEBALADIM().IMKJEBFOBKK(Location.Camp, Location.Road | Location.Camp | Location.BarnInterior).StartTravelZone(0);
		return true;
	}

	private bool PDJNOOPABGM(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Tutorial/T127/Dialogue2", "ReceiveChristmasTreeMessage");
		int result = -76;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			if (Application.targetFrameRate != result)
			{
				QualitySettings.vSyncCount = 0;
				Application.targetFrameRate = result;
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Next Reward" + result + "KickedCustomers";
			return true;
		}
		return false;
	}

	private IEnumerator DAJNKCCKGHD()
	{
		OnlineMinigameManager.RequestPirateShipTeleport();
		for (int i = 1; i <= 4; i++)
		{
			while ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).LEOIMFNKFGA != Location.PirateShip)
			{
				yield return null;
			}
		}
		yield return CommonReferences.wait3;
		PiratesGameManager.Begin();
	}

	private bool CEAOEFMLJKK()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.Port).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.Port).StartTravelZone(2);
		}
		return true;
	}

	private bool OABLIHKPNCF()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(1836f, 1f), new Vector2(421f, 620f));
	}

	private void Start()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		cheatsEnabled = false;
		string text = "";
		if (SteamManager.BNBMMDGMKLM)
		{
			SteamApps.GetCurrentBetaName(ref text, 50);
		}
		if (SteamManager.BNBMMDGMKLM && (Debug.isDebugBuild || text == "privatetest" || SteamUser.GetSteamID().m_SteamID == 76561197970003806L || SteamUser.GetSteamID().m_SteamID == 76561198107342776L || SteamUser.GetSteamID().m_SteamID == 76561198825746141L || SteamUser.GetSteamID().m_SteamID == 76561198064694376L || SteamUser.GetSteamID().m_SteamID == 76561198093046418L || SteamUser.GetSteamID().m_SteamID == 76561198022238634L || SteamUser.GetSteamID().m_SteamID == 76561197995812261L || SteamUser.GetSteamID().m_SteamID == 76561198786146870L || SteamUser.GetSteamID().m_SteamID == 76561198119260449L || SteamUser.GetSteamID().m_SteamID == 76561198072441031L || SteamUser.GetSteamID().m_SteamID == 76561198051417088L || SteamUser.GetSteamID().m_SteamID == 76561198010520720L))
		{
			cheatsEnabled = true;
		}
		else if (Application.isEditor || Debug.isDebugBuild)
		{
			cheatsEnabled = true;
		}
		if (cheatsEnabled)
		{
			PlayerInputs.EnableCheats();
		}
	}

	public bool GGBPIPNHCNC(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "[OfferingStatuePuzzle] Initialized. Required items: " + inputfield.text + "talent_name_113";
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(EOKBKAKDMGH);
		if (num <= 4294967179u)
		{
			if (num <= 147)
			{
				if (num <= 4294967211u)
				{
					if (num <= 4294967124u)
					{
						if (num <= 27)
						{
							if (num != 173)
							{
								if (num != 4294967192u)
								{
									if (num == 8 && EOKBKAKDMGH == "Items/item_name_732")
									{
										goto IL_0f46;
									}
								}
								else if (EOKBKAKDMGH == "Remove")
								{
									return ENFEIPEBFFI();
								}
							}
							else if (EOKBKAKDMGH == "Cannot place mine block piece at ")
							{
								return CCLNLPDBJKC();
							}
						}
						else
						{
							switch (num)
							{
							case 48u:
								if (!(EOKBKAKDMGH == "Throw"))
								{
									break;
								}
								return MPHMCCKAAMB();
							case 4294967231u:
								if (!(EOKBKAKDMGH == "MainProgress"))
								{
									break;
								}
								return AGFFLMOHMBC();
							case 68u:
								if (!(EOKBKAKDMGH == " "))
								{
									break;
								}
								return NANGPPPHAEA();
							}
						}
					}
					else if (num <= 4294967251u)
					{
						if (num != 158)
						{
							switch (num)
							{
							case uint.MaxValue:
								if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/12/Dialogue Text"))
								{
									break;
								}
								return ADNFEBOAGAD();
							case 9u:
								if (!(EOKBKAKDMGH == "Tutorial/T134/Dialogue1"))
								{
									break;
								}
								return GNILDAFLNBC();
							}
						}
						else if (EOKBKAKDMGH == " for ")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 171u:
							if (!(EOKBKAKDMGH == " needs more instances!"))
							{
								break;
							}
							MineManager.AGGAGCBAGLL().DNEGOPDNJHF(CDPAMNIPPEC: false);
							return true;
						case 180u:
							if (!(EOKBKAKDMGH == "ChatInviteCode"))
							{
								break;
							}
							return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
						case 4294967168u:
							if (!(EOKBKAKDMGH == "popUpBuilding4"))
							{
								break;
							}
							return GFKGKOBEAGD();
						}
					}
				}
				else if (num <= 4294967104u)
				{
					if (num <= 111)
					{
						if (num != 4)
						{
							switch (num)
							{
							case 159u:
								if (!(EOKBKAKDMGH == "itemMushroom"))
								{
									break;
								}
								return ANOOPFGHNCJ();
							case 111u:
								if (!(EOKBKAKDMGH == "recipeRequired"))
								{
									break;
								}
								return OLBMOPFDOIH();
							}
						}
						else if (EOKBKAKDMGH == "Dialogue System/Conversation/BirdPositiveComments/Entry/14/Dialogue Text")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 0u:
							if (!(EOKBKAKDMGH == "Unaged Rum"))
							{
								break;
							}
							return GKPMGOIFDPP();
						case 4294967113u:
							if (!(EOKBKAKDMGH == "Recovering zone at "))
							{
								break;
							}
							return ABBLKDMCNEI();
						case 36u:
							if (!(EOKBKAKDMGH == "SwitchFood"))
							{
								break;
							}
							return BFLGFHDBICG();
						}
					}
				}
				else if (num <= 4294967178u)
				{
					switch (num)
					{
					case 1u:
						if (!(EOKBKAKDMGH == "Use"))
						{
							break;
						}
						return AAIPJMFLDEJ();
					case 4294967176u:
						if (!(EOKBKAKDMGH == "SetAnimatorObjectTriggerRPC"))
						{
							break;
						}
						return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
					case 110u:
						if (!(EOKBKAKDMGH == "Waiting for other players"))
						{
							break;
						}
						return OAIKONKMDGK();
					}
				}
				else if (num != 4294967198u)
				{
					switch (num)
					{
					case 4294967163u:
						if (!(EOKBKAKDMGH == " original price: "))
						{
							break;
						}
						return KJDDNEIMAAB();
					case 73u:
						if (!(EOKBKAKDMGH == "Cancel Crafting"))
						{
							break;
						}
						return GAFKLBJCBFI();
					}
				}
				else if (EOKBKAKDMGH == "Player/Bark/Tutorial/T138")
				{
					goto IL_0f4d;
				}
			}
			else if (num <= 45)
			{
				if (num <= 192)
				{
					if (num <= 1)
					{
						switch (num)
						{
						case 183u:
							if (!(EOKBKAKDMGH == "Error_RoomZone"))
							{
								break;
							}
							return DJGIEDHNKFN();
						case 4294967287u:
							if (!(EOKBKAKDMGH == "/"))
							{
								break;
							}
							return JEMOACOJLPC();
						case 56u:
							if (!(EOKBKAKDMGH == "Turn Off"))
							{
								break;
							}
							return AJDCAIMMGHJ();
						}
					}
					else if (num != 4294967206u)
					{
						if (num != 71)
						{
							if (num == 4294967241u && EOKBKAKDMGH == "Not enough ingredients")
							{
								return CNNMDFJPMNK();
							}
						}
						else if (EOKBKAKDMGH == "[Action")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "Interact")
					{
						return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
					}
				}
				else if (num <= 4294967136u)
				{
					if (num != 4294967202u)
					{
						switch (num)
						{
						case 31u:
							if (!(EOKBKAKDMGH == "ReceiveRentedRoomMessage"))
							{
								break;
							}
							return FFNMMACFBKP(MJHBHDAEDLF: true);
						case 13u:
							if (!(EOKBKAKDMGH == " ("))
							{
								break;
							}
							return StartPirates();
						}
					}
					else if (EOKBKAKDMGH == "EditorConfiguration not assigned in CommonReferences")
					{
						goto IL_109c;
					}
				}
				else
				{
					switch (num)
					{
					case 168u:
						if (!(EOKBKAKDMGH == "Items/item_name_1181"))
						{
							break;
						}
						return JEHAECAPNNC();
					case 4294967150u:
						if (!(EOKBKAKDMGH == "Fire Loop NULL!!"))
						{
							break;
						}
						return ReplayBathhouse();
					case 4294967282u:
						if (!(EOKBKAKDMGH == "Cat"))
						{
							break;
						}
						return PKJOGBPCDFP();
					}
				}
			}
			else if (num <= 4294967228u)
			{
				switch (num)
				{
				case 0u:
				case 1u:
				case 2u:
				case 3u:
				case 4u:
				case 5u:
				case 6u:
				case 7u:
				case 8u:
				case 9u:
				case 10u:
				case 11u:
				case 12u:
				case 13u:
				case 14u:
				case 15u:
				case 16u:
				case 17u:
				case 18u:
				case 19u:
				case 20u:
				case 21u:
				case 22u:
					if (num != 4294967281u)
					{
						switch (num)
						{
						case 4294967281u:
							if (!(EOKBKAKDMGH == "ELEMENT IDENTIFIER NOT FOUND for action "))
							{
								break;
							}
							return ADBEGCMDAKF();
						case 78u:
							if (!(EOKBKAKDMGH == "Tutorial/T101/Dialogue1"))
							{
								break;
							}
							return HHDCLALCAIE();
						}
					}
					else if (EOKBKAKDMGH == "Cancel")
					{
						return PGDGLIHMBMK();
					}
					break;
				case 4294967202u:
					if (!(EOKBKAKDMGH == "<color=#"))
					{
						break;
					}
					return CDFBICNOECM();
				case 157u:
					if (!(EOKBKAKDMGH == ""))
					{
						break;
					}
					return FGCMHDGLGML();
				case 4294967127u:
					if (!(EOKBKAKDMGH == "Items/item_name_641"))
					{
						break;
					}
					return LJPEFDHBFMI();
				}
			}
			else if (num <= 4294967177u)
			{
				switch (num)
				{
				case 59u:
					if (!(EOKBKAKDMGH == "Left Stick Up"))
					{
						break;
					}
					return AANHKLFJBHP();
				case 4294967162u:
					if (!(EOKBKAKDMGH == "HarvestableDuringTwoMonths"))
					{
						break;
					}
					return CPFBOGBPPMN();
				case 4294967138u:
					if (!(EOKBKAKDMGH == "/Reports/"))
					{
						break;
					}
					return HMNNDPAFKFB();
				}
			}
			else if (num <= 146)
			{
				switch (num)
				{
				case 122u:
					if (!(EOKBKAKDMGH == "No valid position found around the position {0} after {1} attempts. Returning player's position."))
					{
						break;
					}
					return KNHGAFKNOLC();
				case 56u:
					if (!(EOKBKAKDMGH == "OnlinePlayer"))
					{
						break;
					}
					return BDCPHJICALJ();
				}
			}
			else if (num != 4294967289u)
			{
				if (num == 194 && EOKBKAKDMGH == "ReceiveEndIntroMasters")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "sprout seeds")
			{
				return HNDHIPIILJB();
			}
		}
		else if (num <= 16)
		{
			if (num <= 134)
			{
				if (num <= 4294967116u)
				{
					if (num <= 69)
					{
						if (num != 28)
						{
							if (num != 4294967231u)
							{
								if (num == 148 && EOKBKAKDMGH == "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text")
								{
									return NPAFILPDOAL();
								}
							}
							else if (EOKBKAKDMGH == "Player")
							{
								goto IL_109c;
							}
						}
						else if (EOKBKAKDMGH == "Open")
						{
							return OCEMEODOKLH();
						}
					}
					else
					{
						switch (num)
						{
						case 4294967192u:
							if (!(EOKBKAKDMGH == "MainProgress"))
							{
								break;
							}
							return JBDMEDHKLEN();
						case 4294967282u:
							if (!(EOKBKAKDMGH == "</color>"))
							{
								break;
							}
							return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
						case 4294967233u:
							if (!(EOKBKAKDMGH == ""))
							{
								break;
							}
							return StartBathhouse();
						}
					}
				}
				else
				{
					switch (num)
					{
					case 0u:
					case 1u:
					case 2u:
					case 3u:
					case 4u:
					case 5u:
					case 6u:
					case 7u:
					case 8u:
					case 9u:
					case 10u:
					case 11u:
					case 12u:
					case 13u:
					case 14u:
					case 15u:
					case 16u:
					case 17u:
					case 18u:
					case 19u:
					case 20u:
					case 21u:
					case 22u:
					case 23u:
					case 24u:
					case 25u:
					case 26u:
					case 27u:
					case 28u:
					case 29u:
					case 30u:
					case 31u:
					case 32u:
					case 33u:
					case 34u:
					case 35u:
					case 36u:
					case 37u:
					case 38u:
					case 39u:
					case 40u:
					case 41u:
					case 42u:
					case 43u:
					case 44u:
					case 45u:
					case 46u:
					case 47u:
					case 48u:
					case 49u:
					case 50u:
					case 51u:
					case 52u:
					case 53u:
					case 54u:
					case 55u:
					case 56u:
					case 57u:
					case 58u:
					case 59u:
					case 60u:
					case 61u:
					case 62u:
					case 63u:
					case 64u:
					case 65u:
					case 66u:
					case 67u:
					case 68u:
					case 69u:
					case 70u:
					case 71u:
					case 72u:
					case 73u:
					case 74u:
					case 75u:
						switch (num)
						{
						case uint.MaxValue:
							if (!(EOKBKAKDMGH == "BirdNegativeComments"))
							{
								break;
							}
							return MINIPFHJCIP();
						case 4294967217u:
							if (!(EOKBKAKDMGH == "City/Kujaku/Bark/Buy"))
							{
								break;
							}
							return IAHPEAFAFCK();
						case 110u:
							if (!(EOKBKAKDMGH == "player_locations"))
							{
								break;
							}
							return PDGCMHBCNBJ();
						}
						break;
					case 4294967225u:
						if (!(EOKBKAKDMGH == "Hire"))
						{
							break;
						}
						return CDCCALONMGD();
					case 4294967109u:
						if (!(EOKBKAKDMGH == ""))
						{
							break;
						}
						return LBBNAJJGGJI();
					case 4294967256u:
						if (!(EOKBKAKDMGH == "Reputation"))
						{
							break;
						}
						return StartFish();
					}
				}
			}
			else if (num <= 4294967190u)
			{
				if (num <= 4294967152u)
				{
					switch (num)
					{
					case 4294967122u:
						if (!(EOKBKAKDMGH == "ReceiveFishCuttingEventReturnToHouse"))
						{
							break;
						}
						return IBKNPIBHAFG();
					case 177u:
						if (!(EOKBKAKDMGH == "Items/item_description_1082"))
						{
							break;
						}
						return BBCNMCDDPCD();
					case 27u:
						if (!(EOKBKAKDMGH == "Dialogue System/Conversation/TavernClean/Entry/8/Dialogue Text"))
						{
							break;
						}
						return LOEKLEACHCF();
					}
				}
				else if (num != 107)
				{
					if (num != 4294967288u)
					{
						if (num == 4294967234u && EOKBKAKDMGH == "[MinePuzzleManager] Puzzle resuelto.")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "== START PLACE PIECES ==")
					{
						return JLDEDNNMBAJ();
					}
				}
				else if (EOKBKAKDMGH == "ReceiveTavernAction")
				{
					return IFLKPHCBLBO();
				}
			}
			else if (num <= 55)
			{
				if (num != 4294967144u)
				{
					if (num != 4294967174u)
					{
						if (num == 4294967126u && EOKBKAKDMGH == "Dialogue System/Conversation/EnterTavernDrink/Entry/2/Dialogue Text")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "UI2")
					{
						return BLMHPKBIDFI();
					}
				}
				else if (EOKBKAKDMGH == "OnlinePlaceable with unique ID ")
				{
					return FCCJDHKEFBM();
				}
			}
			else
			{
				switch (num)
				{
				case 150u:
					if (!(EOKBKAKDMGH == "UI2"))
					{
						break;
					}
					MineManager.OOKBNHMMFON().PlaceCharges(CDPAMNIPPEC: false);
					return true;
				case 4294967215u:
					if (!(EOKBKAKDMGH == "SinglePlayer"))
					{
						break;
					}
					return PEKAICCPANA();
				case 4294967139u:
					if (!(EOKBKAKDMGH == "Player2"))
					{
						break;
					}
					return FNNNOKGMHHM();
				}
			}
		}
		else if (num <= 164)
		{
			if (num <= 199)
			{
				if (num <= 4294967115u)
				{
					if (num != 52)
					{
						if (num != 4294967117u)
						{
							if (num == 198 && EOKBKAKDMGH == "Items/item_name_1115")
							{
								return JIBJBOEMKGM();
							}
						}
						else if (EOKBKAKDMGH == "Plant")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == " : ")
					{
						return JEFLILOPHOL();
					}
				}
				else
				{
					switch (num)
					{
					case 4294967203u:
						if (!(EOKBKAKDMGH == "networkID has not been assigned properly"))
						{
							break;
						}
						return JMGBBKPLBJM();
					case 4294967132u:
						if (!(EOKBKAKDMGH == "[MinePuzzleManager] Adding {0} puzzle spawners from piece {1} (maxPuzzleSpawners: {2})"))
						{
							break;
						}
						return JHHPAOPNNPG();
					case 140u:
						if (!(EOKBKAKDMGH == "Disabled"))
						{
							break;
						}
						return POAEGGMIAGP();
					}
				}
			}
			else if (num <= 4294967153u)
			{
				if (num != 4294967203u)
				{
					switch (num)
					{
					case 103u:
						if (!(EOKBKAKDMGH == "OnlineSceneLoad"))
						{
							break;
						}
						return AIAGEJIAGPF();
					case 176u:
						if (!(EOKBKAKDMGH == "Invite region: "))
						{
							break;
						}
						return NIFGPIOKMCC();
					}
				}
				else if (EOKBKAKDMGH == "LE_22")
				{
					goto IL_0f46;
				}
			}
			else if (num != 4294967230u)
			{
				if (num != 4294967261u)
				{
					if (num == 4294967131u && EOKBKAKDMGH == "")
					{
						goto IL_109c;
					}
				}
				else if (EOKBKAKDMGH == "00")
				{
					return MCDCDBIGMMM("Thurs");
				}
			}
			else if (EOKBKAKDMGH == "Items/item_description_1122")
			{
				return PDMIILAFIIC();
			}
		}
		else if (num <= 130)
		{
			switch (num)
			{
			case 4294967277u:
			case 4294967278u:
			case 4294967279u:
			case 4294967280u:
			case 4294967281u:
			case 4294967282u:
			case 4294967283u:
			case 4294967284u:
			case 4294967285u:
			case 4294967286u:
			case 4294967287u:
			case 4294967288u:
			case 4294967289u:
			case 4294967290u:
			case 4294967291u:
			case 4294967292u:
			case 4294967293u:
			case 4294967294u:
			case uint.MaxValue:
				switch (num)
				{
				case 4294967233u:
					if (!(EOKBKAKDMGH == "Items/item_name_699"))
					{
						break;
					}
					return LNCFOBHEABH();
				case 4294967135u:
					if (!(EOKBKAKDMGH == "Scene with location: {0} has not been added. Adding to scene manager."))
					{
						break;
					}
					return KDJKLGEHJAC();
				case 4294967223u:
					if (!(EOKBKAKDMGH == ""))
					{
						break;
					}
					return FFNMMACFBKP(MJHBHDAEDLF: false);
				}
				break;
			case 56u:
				if (!(EOKBKAKDMGH == "itemMelonSeeds"))
				{
					break;
				}
				return KJAKKKEOEBG();
			case 187u:
				if (!(EOKBKAKDMGH == "cameraZoom"))
				{
					break;
				}
				return AIAGEJIAGPF();
			case 4294967266u:
				if (!(EOKBKAKDMGH == "intensity:"))
				{
					break;
				}
				return JJIBLEFKCNB();
			}
		}
		else if (num <= 46)
		{
			if (num != 135)
			{
				if (num != 4294967239u)
				{
					if (num == 4294967274u && EOKBKAKDMGH == "ReceiveNewEmployees")
					{
						goto IL_0f4d;
					}
				}
				else if (EOKBKAKDMGH == "FishCaughtRPC")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "ActionBar6")
			{
				return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
			}
		}
		else if (num <= 4294967234u)
		{
			switch (num)
			{
			case 4294967245u:
				if (!(EOKBKAKDMGH == "Sick"))
				{
					break;
				}
				return FMOALABPHNF();
			case 144u:
				if (!(EOKBKAKDMGH == "Dog"))
				{
					break;
				}
				return MMCILHNMDEG();
			}
		}
		else if (num != 88)
		{
			if (num == 107 && EOKBKAKDMGH == "")
			{
				goto IL_109c;
			}
		}
		else if (EOKBKAKDMGH == "\n  doorSprite:         ")
		{
			return ENMMPPBGHAA();
		}
		if (EOKBKAKDMGH.Contains("Customer Pool instance NULL!"))
		{
			return NNBDLCLPKEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Running"))
		{
			return MHIBNKHCDLI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("questDescCraftPorridge"))
		{
			return GLODNBCOMNI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/29/Dialogue Text"))
		{
			return IBEAIGOCMAB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("<sprite name="))
		{
			return PPFBJDAJBPK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("room_name"))
		{
			return MCDCDBIGMMM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("itemSageSeeds"))
		{
			return IFMLPAIAMDI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return JABEGCPGOPB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" "))
		{
			return KNLBNFACLJK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("sForSeconds"))
		{
			return PDKPNOLLELN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("talent_name_117"))
		{
			return IIDFGNLMGDG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("<sprite name=\"woodPlanksIcon\"><color=#8E1818>"))
		{
			return PDEEHBIMGOJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_1097"))
		{
			return HJHBPPAOGKN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("[MinePuzzleManager] Puzzle resuelto."))
		{
			return NDHJHDIKEKK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("，"))
		{
			return INBCACPBEKL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/BirdPositiveComments/Entry/10/Dialogue Text"))
		{
			return HKIFELEDFFD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" in client, waiting for master to spawn the item"))
		{
			ItemInstance.showIdsNum = !ItemInstance.showIdsNum;
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_638"))
		{
			RandomOrderQuestsManager.JFNOOMJMHCB().FEIKEEMJMHJ();
			return false;
		}
		if (EOKBKAKDMGH.Contains("Walk"))
		{
			return JGNBGECEINP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveDialogueEnd"))
		{
			return BAALKNEHBBM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/BirdPositiveComments/Entry/8/Dialogue Text"))
		{
			return FLJFPPDNBMO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveNinjaSoundPreparation"))
		{
			return EFAKLBHENPJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(")"))
		{
			return DEMLNCALCHB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Disabled"))
		{
			return JIFOEPHOGEO();
		}
		if (EOKBKAKDMGH.Contains("TooCold"))
		{
			return JDFBLMEHPMP();
		}
		if (EOKBKAKDMGH.Contains("ReceiveEnableInputByProximty"))
		{
			return HCKNEEPJNCB();
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return PFDIGPJCPBJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("KujakuShopEvent: Conversation started, isActor = "))
		{
			return LONHAHGNIOF(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" not found."))
		{
			Utils.disableHalloweenEvent = Utils.disableHalloweenEvent;
			return false;
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			return PFFMBKBEGJH(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("levelRequired"))
		{
			return IncreaseWorkersLevel(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("RinProgress"))
		{
			PlayerInputs.DEGBDMMDIIL(0).debugControllers = !PlayerInputs.GetPlayer(0).debugControllers;
			return false;
		}
		if (EOKBKAKDMGH.Contains("psai [{0}]: firing synchronized One-Shot Trigger: {1}"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Snow);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Disabled") && !EOKBKAKDMGH.Contains("Trying to get an invalid Other player with playerNum: ") && !EOKBKAKDMGH.Contains("This game is playing on a different region. Would you like to change regions to {0}?"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Snow);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_1077"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Rain | Weather.WeatherType.Wind);
			return true;
		}
		if (EOKBKAKDMGH.Contains(""))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Sunny | Weather.WeatherType.SunnyClouds);
			return true;
		}
		if (EOKBKAKDMGH.Contains(" ") && !EOKBKAKDMGH.Contains("Kyroh doesnt has drinks in tray"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Rain);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Near"))
		{
			Weather.NGAHKOODEBL(~(Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.StormClouds));
			return false;
		}
		if (EOKBKAKDMGH.Contains("NoEresDigno/KyrohTalks"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Running on Steamdeck: TRUE") && !EOKBKAKDMGH.Contains(" (Online Remote Clone)"))
		{
			Weather.ShowWeather(Weather.WeatherType.Rain | Weather.WeatherType.Wind | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds | Weather.WeatherType.StormClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("HarvestableDuringThreeMonths"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Snow | Weather.WeatherType.Rain);
			return false;
		}
		if (EOKBKAKDMGH.Contains("/ExtraSettings.sd"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.None);
			return true;
		}
		if (EOKBKAKDMGH.Contains("The mine piece "))
		{
			List<Fish> list = ItemDatabaseAccessor.ADCLABHMMAP();
			for (int i = 0; i < list.Count; i += 0)
			{
				if (list[i].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.FOHEOELJMPF(list[i], ((Vector2Int)(ref list[i].lenght)).x, CDPAMNIPPEC: false);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("Generate All Routes"))
		{
			List<Fish> list2 = ItemDatabaseAccessor.ADCLABHMMAP();
			for (int j = 0; j < list2.Count; j += 0)
			{
				if (list2[j].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.AddFishInformation(list2[j]);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("SetUpOptions"))
		{
			return PDJNOOPABGM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("/"))
		{
			return LCOBGLILEIG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("buildingObjective_2_0"))
		{
			return HPOBFJMFPFM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("LE_15"))
		{
			return GAONHALIEAI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("End of Dictionary."))
		{
			return INIDNJOJJPD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveLastOrder"))
		{
			return FMNEPHOJEFI(EOKBKAKDMGH);
		}
		return true;
		IL_0f46:
		return EOOABCEHOKG();
		IL_108e:
		return JCHKJAEPBNK();
		IL_0f4d:
		return CHAFFHCGMNJ();
		IL_0efb:
		return AFKKMBIDEBB();
		IL_109c:
		return GHPIMLBHMPP();
	}

	private bool CMEEFLDCGHO(string EOKBKAKDMGH)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		currentGameDate.hour = 19;
		WorldTime.NOAOJJLNHJJ = currentGameDate;
		WorldTime.CalcCurrentDayTimeSec();
		WorldTime.OnDevConsoleHourChanged?.Invoke();
		return true;
	}

	private bool FHGODJOCMPA()
	{
		BanquetEvent.BeginReplay();
		return true;
	}

	private bool KOGAFKKIBGC(string EOKBKAKDMGH)
	{
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Interact" + PlayerInputs.DEGBDMMDIIL(0).CFICAAJGBOF;
		return false;
	}

	private bool JEFLILOPHOL()
	{
		TravelZonesManager.LKOABOAADCD().ECFDFECLDFK(~(Location.River | Location.Camp | Location.Quarry | Location.BarnInterior), Location.Tavern | Location.BarnInterior | Location.FarmShop).KACGDPCMGPL(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.OLHBLKIAFOM().GetTravelZone(~(Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.BarnInterior), Location.Tavern | Location.River | Location.Farm).StartTravelZone(7);
		}
		return true;
	}

	private bool FEAFKEGLBIB(string EOKBKAKDMGH)
	{
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Current map: " + PlayerInputs.GetPlayer(1).CFICAAJGBOF;
		return true;
	}

	public bool IJCFIKFDGPG(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "</color>", "quest_name_");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			StaffManager.DFNHLIJHJIB(result);
			return true;
		}
		return false;
	}

	private bool PDKPNOLLELN(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, " (", "");
		string[] array = Regex.Split(EOKBKAKDMGH, "buildingObjective_9_0");
		if (array.Length != 0 && int.TryParse(array[1], out var result))
		{
			GameDate aODONKKHPBP = WorldTime.CJOHMLNMJLK();
			aODONKKHPBP.hour = result;
			WorldTime.OFHDFEONCOL(aODONKKHPBP);
			WorldTime.KDBEIJKCAKO();
			WorldTime.OnDevConsoleHourChanged?.Invoke();
			return false;
		}
		return false;
	}

	private bool JDFBLMEHPMP()
	{
		BDIPKPLEGKM("ChatDefaultName" + 180 + "Not enough money" + 105);
		BDIPKPLEGKM("Wake Up" + -18 + "itemMildWort" + -36);
		EJODODEHNII("City/Carpenters/Oak/Bark/Smoke" + -37 + "Quit to desktop?" + -114);
		BDIPKPLEGKM("Tutorial/T102/Dialogue1" + 154 + "Ingredient" + -15);
		EJODODEHNII("ReceivePhaseMessage" + 63 + "popUpBuilding14" + 63);
		INBCACPBEKL("Unsaved progress will be lost." + -68 + "Load Player 2 appearance" + -39);
		FFHEJCPLMCD("BuildConfirmation" + 52 + "Dialogue System/Conversation/BirdPositiveComments/Entry/12/Dialogue Text" + -104);
		FFHEJCPLMCD("Exit build mode" + 44 + "Steam Initialized: False" + 18);
		return true;
	}

	private IEnumerator NFCKNFHGINM()
	{
		return new LFFGMLCLCHP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IEGEJCEJGIL()
	{
		NPAFILPDOAL();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		while (GameManager.LocalCoop() && FadeCamera.GetPlayer(2).IsFading())
		{
			yield return null;
		}
		BlackFade.Show();
		while ((Object)(object)FishCuttingGameManager.instance == (Object)null)
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).SetDirection(Direction.Down);
		StartFish();
	}

	private bool LIHFLBCDGJE()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern | Location.River, ~(Location.Road | Location.Camp | Location.Quarry)).KACGDPCMGPL(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.EKDNJDJHONF().ECFDFECLDFK(Location.None, ~(Location.Road | Location.River | Location.Camp)).StartTravelZone(2);
		}
		return true;
	}

	private bool CMONDIHNPBI()
	{
		string text = "FinalTestEvent SetEventCoroutine";
		FloorDirt[] array = CommonReferences.MNFMOEKMJKN().tavernFloorDirt.ToArray();
		if (array.Length == 0)
		{
			text += "Message is too long to send.";
		}
		else
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				string[] array2 = new string[7];
				array2[0] = text;
				array2[1] = ((Object)array[i]).name;
				array2[2] = "cameraZoom2";
				array2[4] = ((Object)((Component)array[i].cleanerAssigned).gameObject).name;
				array2[8] = "Weapon";
				text = string.Concat(array2);
			}
			text = text + "      Magic Broom assigned: " + array.Length;
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + text;
		return false;
	}

	private bool EFAKLBHENPJ(string EOKBKAKDMGH)
	{
		Recipe[] array = RecipeDatabaseAccessor.BNPGHCFNAMA();
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].unlock != 0)
			{
				RecipesManager.UnlockRecipe(array[i], IBHGAMNNOHI: true, OEBNHGNJEJL: true);
			}
		}
		return true;
	}

	private bool PBGMKMONPJP()
	{
		GraphicsMenuUI.JFNOOMJMHCB().NextResolution();
		return true;
	}

	private bool EDEKHLKKODG(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "mine level ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		int result = 9999;
		if (array.Length != 0 && int.TryParse(array[0], out result))
		{
			((MonoBehaviour)this).StartCoroutine(HAANLBAMBBA(result));
			return true;
		}
		return false;
	}

	private bool HKIFELEDFFD(string EOKBKAKDMGH)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "dog ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			if (array.Length > 1 && int.TryParse(array[1], out var result2))
			{
				DogNPC.InstantiateDog(result2, result, "Argos", WorldTime.NOAOJJLNHJJ, Vector2.op_Implicit(new Vector3(10.5f, -14f, 0f)));
			}
			else
			{
				DogNPC.InstantiateDog(0, result, "Argos", WorldTime.NOAOJJLNHJJ, Vector2.op_Implicit(new Vector3(10.5f, -14f, 0f)));
			}
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Two numbers are needed. 'add item ID COUNT'";
		return true;
	}

	private bool CHAMHIDHEJI()
	{
		TravelZonesManager.GGFJGHHHEJC.ECFDFECLDFK(Location.Tavern | Location.River, Location.Road | Location.BarnInterior | Location.FarmShop).KACGDPCMGPL(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.BGMJCCFNNDL().KCJMDAPPJLB(Location.Road | Location.River, ~(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop)).KACGDPCMGPL(8);
		}
		return true;
	}

	private bool NMDHHEAKPPA()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.VampireHouse).StartTravelZone(1);
		return true;
	}

	private bool AIAGEJIAGPF()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.BathhouseInterior).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.BathhouseInterior).StartTravelZone(2);
		}
		return true;
	}

	private bool OLBMOPFDOIH()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road).StartTravelZone(1);
		return true;
	}

	private bool GHPIMLBHMPP()
	{
		DialogueManager.EmitSubtitleError();
		return true;
	}

	private bool AANHKLFJBHP()
	{
		foreach (KeyValuePair<string, int> item in KeybindUI.OLHBLKIAFOM().keybindsSave.keybindSave)
		{
			TextMeshProUGUI val = consoleText;
			string[] array = new string[5];
			array[0] = ((TMP_Text)val).text;
			array[1] = "Club";
			array[0] = item.Key;
			array[8] = "Wood";
			array[0] = item.Value.ToString();
			array[2] = "</color><br>";
			((TMP_Text)val).text = string.Concat(array);
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Attack/MainEvent 12";
		return true;
	}

	private IEnumerator IGNCIGCFIJP()
	{
		AIAGEJIAGPF();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
		while (GameManager.LocalCoop() && FadeCamera.GetPlayer(2).IsFading())
		{
			yield return null;
		}
		BlackFade.Show();
		while ((Object)(object)BathhouseGameManager.instance == (Object)null)
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		StartBathhouse();
	}

	private bool KFIJCCHECAH()
	{
		GraphicsMenuUI.FMIDAFEGDCD().NextResolution();
		return false;
	}

	public bool OFHEODBPNCJ(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "itemPilsner", " (versionOfCropsAndRecipes)");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			StaffManager.LBJGAFPJMLD(result);
			return true;
		}
		return true;
	}

	private bool LFONIBMMHOB()
	{
		ChallengesUI.DebugOpen();
		return true;
	}

	private bool BHJAHKJCBJF(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Player 2 Join Buton Clicked, num players: ", "On Simple Event ");
		int result = 78;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			RecipesManager.recipeFragments += result;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Decline" + result + "Disabled";
			return false;
		}
		return true;
	}

	public bool OnPlayerSleep(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (!int.TryParse(EOKBKAKDMGH, out result))
		{
			result = 1;
		}
		for (int i = 0; i < result; i++)
		{
			onPlayerSleepFromDevConsole = true;
			CommonReferences.GGFJGHHHEJC.OnPlayerSleep();
			CommonReferences.GGFJGHHHEJC.OnPlayerSleepForestGeneration();
			Bed.SetGameDate(Bed.GetNextGameDate());
			CommonReferences.GGFJGHHHEJC.OnPlayerAwake();
			onPlayerSleepFromDevConsole = false;
		}
		return true;
	}

	private bool PFFMBKBEGJH(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "DecorationTile_5", "perHour");
		string[] array = Regex.Split(EOKBKAKDMGH, "GameEvent of type ");
		int result = 37;
		if (array.Length != 0 && int.TryParse(array[0], out result))
		{
			((MonoBehaviour)this).StartCoroutine(HAANLBAMBBA(result));
			return false;
		}
		return false;
	}

	public void OpenCloseConsole()
	{
		if (opened)
		{
			GMFNJMBIENA();
		}
		else if (cheatsEnabled)
		{
			DOECECEBNNB();
		}
	}

	private bool PGNOLMJEJPD()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River | Location.FarmShop, ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry)).StartTravelZone(1);
		return false;
	}

	private bool KADGOIHAGDP()
	{
		TavernReputation.AddReputationPoints(-100 + -200 * TavernReputation.GetMilestone());
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Reputation decreased...";
		return true;
	}

	private bool CPNHFBKGOCB()
	{
		TravelZonesManager.GFMBEDCANNI().KCJMDAPPJLB(Location.Road | Location.River | Location.BarnInterior | Location.FarmShop, Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop).StartTravelZone(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.CFHEJAGKIII().KCJMDAPPJLB(~(Location.Road | Location.River | Location.Quarry), ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.FarmShop)).KACGDPCMGPL(4);
		}
		return true;
	}

	private bool HHDCLALCAIE()
	{
		CommonReferences.MNFMOEKMJKN().customerInfo.showService = !CommonReferences.GGFJGHHHEJC.customerInfo.showService;
		if (CommonReferences.MNFMOEKMJKN().customerInfo.showService)
		{
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "UIHorizontal";
		}
		else
		{
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ReceiveStartObserverDialogue";
		}
		return false;
	}

	private bool GGFDGGHCPND()
	{
		FogManager[] array = Object.FindObjectsOfType<FogManager>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].DMBFKFLDDLH = !array[i].DMBFKFLDDLH;
		}
		return true;
	}

	private bool FLNOANAOAAC(string EOKBKAKDMGH)
	{
		if (SeasonManager.ADEICKHEPFI() == Season.Spring)
		{
			SeasonManager.instance.NMMLELDCBBJ(Season.Spring);
		}
		else if (SeasonManager.NHKAHEEGEGF() == Season.Spring)
		{
			SeasonManager.instance.ChangeSeason(Season.Autumn);
		}
		else if (SeasonManager.LPGPJPPLHKG() == (Season)5)
		{
			SeasonManager.instance.AJFAKNHLGNB((Season)5);
		}
		else if (SeasonManager.PJMGHIMKFJL() == Season.Autumn)
		{
			SeasonManager.instance.OGKNMEMHHEK(Season.Spring);
		}
		return false;
	}

	private bool CKOGCLKNANJ()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
		return false;
	}

	private bool JDALGGKAGDG()
	{
		TravelZonesManager.OACNNJCLEDE().ECFDFECLDFK(~(Location.Camp | Location.Quarry), ~(Location.Road | Location.River)).StartTravelZone(1);
		return false;
	}

	private bool DEMLNCALCHB(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, " ", "Nose");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			for (int i = 1; i < TutorialPopUps.autoSetUp.Count; i++)
			{
				if (TutorialPopUps.autoSetUp[i].BCGHONOECAG() == result)
				{
					TutorialManager.GGFJGHHHEJC.AEBKHLILFNJ(TutorialPopUps.autoSetUp[i], MDNOOMBIFNN: false);
					TextMeshProUGUI obj = consoleText;
					((TMP_Text)obj).text = ((TMP_Text)obj).text + "buildingObjective_36_0" + result;
					return false;
				}
			}
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ReceiveGetUniqueCropHarvestable";
			return true;
		}
		TextMeshProUGUI obj3 = consoleText;
		((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "ZuzzuProgress";
		return false;
	}

	private bool FMNEPHOJEFI(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "stuck recovery", "").Trim();
		int result = 1;
		int.TryParse(EOKBKAKDMGH, out result);
		if (result < 1)
		{
			result = 1;
		}
		StuckRecoverySystem.instance.RecoverPlayer(result);
		return true;
	}

	public bool LJPEFDHBFMI()
	{
		FishCuttingGameManager.PBCDECMNCGB();
		return true;
	}

	private bool KDJKLGEHJAC()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Farm, Location.Beach).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Farm, Location.Beach).StartTravelZone(2);
		}
		return true;
	}

	private bool BOHBOEKIEJL(string EOKBKAKDMGH)
	{
		string text = EOKBKAKDMGH.Substring(-128);
		Debug.LogError((object)text);
		if (text.Length == 4)
		{
			OnlineManager.SetPrivateRoomCodeFromSteam(text);
			return false;
		}
		return true;
	}

	private bool JLDEDNNMBAJ()
	{
		TravelZonesManager.BGMJCCFNNDL().JKPNCIFMAOO(Location.River, Location.Road).KACGDPCMGPL(0);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GFMBEDCANNI().JKPNCIFMAOO(Location.Road | Location.River, Location.Tavern | Location.River).StartTravelZone(3);
		}
		return true;
	}

	private void GMFNJMBIENA()
	{
		((Component)inputfield).gameObject.SetActive(false);
		consolePanel.gameObject.SetActive(false);
		opened = false;
	}

	private bool JFNILOGIOIH()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CityTavern).StartTravelZone(1);
		return true;
	}

	public bool IncreaseWorkersLevel(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			StaffManager.IncreaseLevelToAllWorkers(result);
			return true;
		}
		return false;
	}

	private bool BKJGKACHINN()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateCave, Location.PirateShip).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateCave, Location.PirateShip).StartTravelZone(2);
		}
		return true;
	}

	private bool DJGIEDHNKFN()
	{
		GraphicsMenuUI.GGFJGHHHEJC.NextResolution();
		return true;
	}

	private bool MHIBNKHCDLI(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			RecipesManager.recipeFragments += result;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Recipe fragments added (" + result + ")...";
			return true;
		}
		return false;
	}

	private IEnumerator BIEOCPCDIBP()
	{
		return new DNJADCEDGAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool NPAFILPDOAL()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Port, Location.KujakuHouse).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Port, Location.KujakuHouse).StartTravelZone(2);
		}
		return true;
	}

	private bool ADBEGCMDAKF()
	{
		TravelZonesManager.CFHEJAGKIII().KCJMDAPPJLB(~(Location.Tavern | Location.Quarry), ~(Location.Quarry | Location.Farm | Location.FarmShop)).KACGDPCMGPL(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.DGCNCEDIFOF().GetTravelZone(Location.Road | Location.FarmShop, ~(Location.Tavern | Location.River | Location.Camp)).StartTravelZone(2);
		}
		return true;
	}

	private bool PDMIILAFIIC()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
		return false;
	}

	private bool HHLKENOCJIC()
	{
		TravelZonesManager.GFMBEDCANNI().IMKJEBFOBKK(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm), ~(Location.Tavern | Location.BarnInterior | Location.FarmShop)).StartTravelZone(1);
		return false;
	}

	private bool PPFBJDAJBPK(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, " : ", "Hop");
		int result = 4;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			Time.timeScale = result;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "IdleCamp" + result;
			return false;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "";
		return true;
	}

	private bool ILADCDMFPON()
	{
		return true;
	}

	public void IDJOFDEBMAK()
	{
		if (opened)
		{
			GMFNJMBIENA();
		}
		else if (cheatsEnabled)
		{
			DOECECEBNNB();
		}
	}

	private bool CDCCALONMGD()
	{
		TravelZonesManager.GFMBEDCANNI().ECFDFECLDFK(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.FarmShop, Location.Road | Location.River | Location.Farm | Location.FarmShop).StartTravelZone(0);
		return false;
	}

	private bool HMNNDPAFKFB()
	{
		NinjaChallenge.BeginReplay();
		return false;
	}

	private bool LNCFOBHEABH()
	{
		return true;
	}

	private bool NBCJFHNAMGE()
	{
		if (NDHFKNDPNOO)
		{
			NDHFKNDPNOO = false;
			PlayerController.OPHDCMJLLEC(1).sprintMultiplier = 569f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "ReciveDisableCustomers";
			if (GameManager.LocalCoop())
			{
				PlayerController.OPHDCMJLLEC(5).sprintMultiplier = 781f;
			}
		}
		else
		{
			NDHFKNDPNOO = true;
			PlayerController.GetPlayer(1).sprintMultiplier *= 473f;
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Items/item_name_599";
			if (GameManager.LocalCoop())
			{
				PlayerController.OPHDCMJLLEC(1).sprintMultiplier *= 88f;
			}
		}
		return false;
	}

	private void BGPGIOMKKAO()
	{
		if (Application.isEditor && !LinqExtensions.IsNullOrEmpty<string>((IList<string>)CommonReferences.GetEditorConfiguration().initialMessageDevConsole))
		{
			for (int i = 0; i < CommonReferences.GetEditorConfiguration().initialMessageDevConsole.Length; i++)
			{
				Cheat(CommonReferences.GetEditorConfiguration().initialMessageDevConsole[i]);
			}
			MainUI.ShowErrorText(1, "Initial DevConsole message: " + CommonReferences.GetEditorConfiguration().initialMessageDevConsole);
		}
	}

	private bool MHLGKEBGCLB()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)spawnPoints))
		{
			Utils.BLPDAEHPOBA(spawnPoints);
		}
		return PPAMAJMMLLM(new Vector2(10f, -15f), new Vector2(10f, -12f));
	}

	private bool FCCJDHKEFBM()
	{
		OnlineManager.Connect();
		return true;
	}

	private bool KKJCODHDAPM(string EOKBKAKDMGH)
	{
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "MineObstacleBark" + PlayerInputs.GetPlayer(0).AAGNDCEODFO();
		return false;
	}

	private bool INKOAKJDEMG()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.ChristmasCave).StartTravelZone(1);
		return true;
	}

	private IEnumerator PBFKNNOAMDI()
	{
		yield return null;
		yield return null;
		scroll.value = 0f;
	}

	private bool JHHPAOPNNPG()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Bathhouse).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Bathhouse).StartTravelZone(2);
		}
		return true;
	}

	private IEnumerator KNLFADCAEIN()
	{
		OnlineMinigameManager.RequestBathhouseTeleport();
		for (int i = 1; i <= 4; i++)
		{
			while ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).LEOIMFNKFGA != Location.BathhouseInterior)
			{
				yield return null;
			}
		}
		yield return CommonReferences.wait3;
		BathhouseGameManager.Begin();
	}

	private void DOECECEBNNB()
	{
		((Component)inputfield).gameObject.SetActive(true);
		consolePanel.gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(AHLMLBCBHBP(((Component)inputfield).gameObject));
		opened = true;
	}

	public bool OIMMOOFKFFE()
	{
		if (OnlineMinigameManager.GetMinigameState() == OnlineMinigameManager.PlayerState.Default)
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		if (PlayerController.GetPlayer(0).LEOIMFNKFGA != ~(Location.Tavern | Location.River | Location.Farm | Location.FarmShop))
		{
			((MonoBehaviour)this).StartCoroutine(IEGEJCEJGIL());
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PLCDANOCLJK())
			{
				OnlineMinigameManager.LFECKPMECAF();
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(MHBNFKHNIFJ());
			}
		}
		else
		{
			FishCuttingGameManager.Begin(KPCHOCLAAIM: false, IPDJFMMIKEK: true);
		}
		return true;
	}

	private bool INBCACPBEKL(int JFNMCNCHMEO, int HFDILBELIKE)
	{
		Item item = ItemDatabaseAccessor.GetItem(JFNMCNCHMEO);
		if (Item.MLBOMGHINCA(item, null))
		{
			ItemInstance itemInstance = item.JMDALJBNFML();
			if (HFDILBELIKE > 1)
			{
				PlayerInventory.GetPlayer(1).AddItems(itemInstance, HFDILBELIKE, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.GetPlayer(1).AddItem(itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Item " + item.IABAKHPEOAF() + " added";
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Item with ID=" + JFNMCNCHMEO + " not found";
		return false;
	}

	public bool MCDCDBIGMMM(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Player", "in");
		int result = -122;
		if (!int.TryParse(EOKBKAKDMGH, out result))
		{
			result = 0;
		}
		for (int i = 0; i < result; i++)
		{
			onPlayerSleepFromDevConsole = true;
			CommonReferences.GGFJGHHHEJC.OnPlayerSleep();
			CommonReferences.MNFMOEKMJKN().OnPlayerSleepForestGeneration();
			Bed.HHFPMHACPJE(Bed.MLBFKPKHPML());
			CommonReferences.GGFJGHHHEJC.OnPlayerAwake();
			onPlayerSleepFromDevConsole = true;
		}
		return true;
	}

	private bool JIBJBOEMKGM()
	{
		ChallengesUI.BMNIHBHJFKK();
		return true;
	}

	private bool INBCACPBEKL(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "add item ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			if (array.Length > 1 && int.TryParse(array[1], out var result2))
			{
				return INBCACPBEKL(result, result2);
			}
			return INBCACPBEKL(result, 1);
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Two numbers are needed. 'add item ID COUNT'";
		return true;
	}

	private bool PGDGLIHMBMK()
	{
		((Component)this).gameObject.AddComponent<ImportantGuestEvent>().SpawnImportantGuest();
		return true;
	}

	private IEnumerator AHLMLBCBHBP(GameObject HGNKFFMDOOL)
	{
		yield return null;
		EventSystem.current.SetSelectedGameObject((GameObject)null);
		yield return null;
		EventSystem.current.SetSelectedGameObject(HGNKFFMDOOL);
	}

	private bool MIOFOMCEKJI()
	{
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "<b><color=#FDEA5C>Info                              </color></b>\n>   Shows all the codes.\n<b><color=#FDEA5C>Increase XP                       </color></b>\n>   Increases the XP.\n<b><color=#FDEA5C>World Time ##                     </color></b>\n>   Changes the world time multiplier (needs a number).\n<b><color=#FDEA5C>Time ##                           </color></b>\n>   Modifies the game's time scale.\n<b><color=#FDEA5C>Change Season                     </color></b>\n>   Changes the season.\n<b><color=#FDEA5C>Grow all plants                   </color></b>\n>   It makes all plants grow.\n<b><color=#FDEA5C>STEAM Status                      </color></b>\n>   Steam login status.\n<b><color=#FDEA5C>Add all resolutions               </color></b>\n>   It adds all screen resolutions in order to test it.\n<b><color=#FDEA5C>Increase money ##                 </color></b>\n>   Increases gold (needs a number).\n<b><color=#FDEA5C>Increase reputation ###           </color></b>\n>   Increases the reputation (needs a number).\n<b><color=#FDEA5C>Decrease reputation               </color></b>\n>   Decreases the reputation.\n<b><color=#FDEA5C>Show Popup ###                    </color></b>\n>   Shows a tutorial popup.\n<b><color=#FDEA5C>Road                              </color></b>\n>   Teleports the player outside the tavern.\n<b><color=#FDEA5C>River                             </color></b>\n>   Teleports the player to the river.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the campament.\n<b><color=#FDEA5C>Unlock recipe #                   </color></b>\n>   Unlock a recipe (needs a number)\n<b><color=#FDEA5C>Unlock all recipes                </color></b>\n>   Unlock all recipes\n<b><color=#FDEA5C>Add quest #                       </color></b>\n>   Add specific quest to active quest (needs a number).\n<b><color=#FDEA5C>Add materials #                   </color></b>\n>   Add materials.\n<b><color=#FDEA5C>Complete quest #                  </color></b>\n>   Complete specific active quest (needs a number).\n<b><color=#FDEA5C>Hour #                            </color></b>\n>   Specify the hour you want to be.\n<b><color=#FDEA5C>Night                             </color></b>\n>   Set the hour to 19:00h automatically.\n<b><color=#FDEA5C>Bed                               </color></b>\n>   Teleports the player to the bedroom.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the Camp.\n<b><color=#FDEA5C>Generate forest                   </color></b>\n>   Generate new herbs and trees.\n<b><color=#FDEA5C>Tilled Earth                      </color></b>\n>   Convert all terrain to tilled earth.\n<b><color=#FDEA5C>Seeds                             </color></b>\n>   Give all seeds.\n<b><color=#FDEA5C>Talents                           </color></b>\n>   Unlocks all talents.\n<b><color=#FDEA5C>Dirty Info                        </color></b>\n>   Floor Dirt information.\n<b><color=#FDEA5C>Check Keybinds                    </color></b>\n>   Check the modified keybinds.\n<b><color=#FDEA5C>Debug service                     </color></b>\n>   Debug service of customers.\n<b><color=#FDEA5C>On player sleep                   </color></b>\n>   On player sleep function.\n<b><color=#FDEA5C>Fog                               </color></b>\n>   Enable and disable fog.\n<b><color=#FDEA5C>Controllers                       </color></b>\n>   Show controllers connected.\n<b><color=#FDEA5C>Connect                           </color></b>\n>   Connect to debug Photon room.\n<b><color=#FDEA5C>Disconnect                        </color></b>\n>   Disconnect form debug Photon room.\n<b><color=#FDEA5C>snow, rain, rain cloudy, rain stormy, sunny, sunny clouds, stormy clouds, cloudy, windy</color></b>\n>   Shows weather.\n<b><color=#FDEA5C>stop weather                      </color></b>\n>   Removes all current weather effects.\n<b><color=#FDEA5C>fill fish collection              </color></b>\n>   Add records for all not found fish in collection.\n<b><color=#FDEA5C>fish collection clues             </color></b>\n>   Adds clues for all not found fish in collection.\n<b><color=#FDEA5C>recipe fragments #                </color></b>\n>   Adds # recipe fragments for recipe exchange\n<b><color=#FDEA5C>ShowUI                            </color></b>\n>   Show Gameplay UI\n<b><color=#FDEA5C>HideUI                            </color></b>\n>   Hide Gameplay UI\n<b><color=#FDEA5C>Intro                             </color></b>\n>   Triggers the scroll intro\n<b><color=#FDEA5C>Tutorial                          </color></b>\n>   Triggers the new tutorial\n<b><color=#FDEA5C>Target fps ###                    </color></b>\n>   Sets a frame rate limit.\n<b><color=#FDEA5C>Tutorial phase ###                </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>onlinecode #####                  </color></b>\n>   Sets the private room code for online play as if received from a steam invite.\n<b><color=#FDEA5C>Force intro                       </color></b>\n>   Triggers the intro when starts a new game in the editor.\n<b><color=#FDEA5C>Dog #BreedID# #RelationshipLVL#   </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>banquetevent                      </color></b>\n>   Starts Banquet Event. If is already active stops the event.\n";
		return true;
	}

	private bool OCEMEODOKLH()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CastleGarden).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CastleGarden).StartTravelZone(2);
		}
		return true;
	}

	private bool IBEAIGOCMAB(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "[^0-9]", "");
		int result = 9999;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			WorldTime.SetMultiplierDevConsole(result);
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "New world time multiplier: " + result;
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "A number is needed.";
		return true;
	}

	private bool NCPPHJCICHD()
	{
		GraphicsMenuUI.EFPJLFMBPLL().MBKOPLEJHIB(GraphicsMenuUI.HEKFJEKFMNO().fullScreenMode);
		return true;
	}

	private bool INIDNJOJJPD(string EOKBKAKDMGH)
	{
		string text = EOKBKAKDMGH.Substring(5);
		if (text.Length > 0)
		{
			OnlineChat.SystemMessage(text);
			return true;
		}
		return false;
	}

	private bool JDGEMPAGPFM()
	{
		DialogueManager.EmitSubtitleError();
		return false;
	}

	private bool CIHMCFAJMNM()
	{
		TravelZonesManager.EKDNJDJHONF().JKPNCIFMAOO(Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.FarmShop, Location.River | Location.FarmShop).StartTravelZone(0);
		return false;
	}

	private bool MPHMCCKAAMB()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.RoomsMultiplayer).StartTravelZone(1);
		return true;
	}

	private bool AAIPJMFLDEJ()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.River).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.River).StartTravelZone(2);
		}
		return true;
	}

	private bool HJHBPPAOGKN(string EOKBKAKDMGH)
	{
		SaveUI.instance.AutoSave();
		return true;
	}

	private IEnumerator HAANLBAMBBA(int JFNMCNCHMEO)
	{
		if ((Object)(object)Utils.JGEPCPFJANP(Location.Mine) == (Object)null)
		{
			CCABKLMNLHO();
			while ((Object)(object)Utils.JGEPCPFJANP(Location.Mine) == (Object)null)
			{
				yield return null;
			}
			yield return CommonReferences.wait4;
		}
		TravelZonesManager.GGFJGHHHEJC.allMineStairs[new Vector2Int(0, 0)].forceTravelToMineLevel = JFNMCNCHMEO;
		TravelZonesManager.GGFJGHHHEJC.allMineStairs[new Vector2Int(0, 0)].StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.allMineStairs[new Vector2Int(0, 0)].forceTravelToMineLevel = JFNMCNCHMEO;
			TravelZonesManager.GGFJGHHHEJC.allMineStairs[new Vector2Int(0, 0)].StartTravelZone(2);
		}
	}

	private bool PHGHFLHBJDM()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
		return true;
	}

	private bool NDHJHDIKEKK(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "activate event ", "");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			((MonoBehaviour)this).StartCoroutine(LHKDBAPJAGC((EventsManager.EventType)result));
			return true;
		}
		if (Enum.TryParse<EventsManager.EventType>(EOKBKAKDMGH, ignoreCase: true, out var result2))
		{
			((MonoBehaviour)this).StartCoroutine(LHKDBAPJAGC(result2));
			return true;
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Event type: " + EOKBKAKDMGH + " not found";
		return false;
	}

	private bool CFBHCOJJIPK(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "hour ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		if (array.Length != 0 && int.TryParse(array[0], out var result))
		{
			GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
			currentGameDate.hour = result;
			WorldTime.NOAOJJLNHJJ = currentGameDate;
			WorldTime.CalcCurrentDayTimeSec();
			WorldTime.OnDevConsoleHourChanged?.Invoke();
			return true;
		}
		return false;
	}

	private bool FFHEJCPLMCD(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, " ", "RingBell");
		string[] array = Regex.Split(EOKBKAKDMGH, "Jump");
		if (array.Length != 0 && int.TryParse(array[1], out var result))
		{
			if (array.Length > 0 && int.TryParse(array[1], out var result2))
			{
				return LEOALPEOOKH(result, result2);
			}
			return INBCACPBEKL(result, 1);
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Disabled";
		return false;
	}

	private bool AAAIGKPGBOP(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Mon", "");
		int result = -81;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			if (Application.targetFrameRate != result)
			{
				QualitySettings.vSyncCount = 1;
				Application.targetFrameRate = result;
			}
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "House keeper OnFailStart cleaning table " + result + "Pirates/Brook/Stand";
			return false;
		}
		return false;
	}

	private bool ILFAOHJIFDM(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Day", " - ");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			NewTutorialManager.instance.currentPhase = result - 0;
			NewTutorialManager.instance.NextPhase();
			NewTutorialManager.instance.ActivateTutorial(DAEMAAOLHMG: false, ICEGNJDJMLE: false);
			return true;
		}
		return false;
	}

	private bool ANOOPFGHNCJ()
	{
		Item[] items = ItemDatabaseAccessor.GetDatabaseSO().items;
		foreach (Item item in items)
		{
			if (item is Seed && item.shop != 0)
			{
				INBCACPBEKL("add item " + item.JDJGFAACPFC() + " " + 50);
			}
		}
		return true;
	}

	private bool CCLNLPDBJKC()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.City).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.City).StartTravelZone(2);
		}
		return true;
	}

	private bool LCOBGLILEIG(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Wide screen ratio", ".gz");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			NewTutorialManager.instance.currentPhase = result - 0;
			NewTutorialManager.instance.OEJFPGJPFNI();
			NewTutorialManager.instance.ActivateTutorial(DAEMAAOLHMG: false, ICEGNJDJMLE: false);
			return true;
		}
		return true;
	}

	private bool JBDMEDHKLEN()
	{
		TavernReputation.AddReputationPoints(-128 + 166 * TavernReputation.GetMilestone());
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "\n<color=#822F00>";
		return false;
	}

	private bool AFKKMBIDEBB()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Beach, Location.PirateCave).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Beach, Location.PirateCave).StartTravelZone(2);
		}
		return true;
	}

	private bool PEKAICCPANA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(1317f, 1740f), new Vector2(332f, 383f));
	}

	private bool MOLEJPANHAE()
	{
		GraphicsMenuUI.GGFJGHHHEJC.SetFullScreen(!GraphicsMenuUI.GGFJGHHHEJC.fullScreenMode);
		return true;
	}

	private bool NHBMIODBACK(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "MopRight", "\n");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			for (int i = 1; i < TutorialPopUps.autoSetUp.Count; i++)
			{
				if (TutorialPopUps.autoSetUp[i].DCFNIMCMFEM == result)
				{
					TutorialManager.GGFJGHHHEJC.ShowPopUp(TutorialPopUps.autoSetUp[i]);
					TextMeshProUGUI obj = consoleText;
					((TMP_Text)obj).text = ((TMP_Text)obj).text + "Cannot place mine block piece at " + result;
					return true;
				}
			}
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + " : ";
			return false;
		}
		TextMeshProUGUI obj3 = consoleText;
		((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "ValueName";
		return true;
	}

	private bool ENFEIPEBFFI()
	{
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Gameplay";
		return true;
	}

	private void EFCNKPEPELL()
	{
		((Component)inputfield).gameObject.SetActive(true);
		consolePanel.gameObject.SetActive(false);
		instance = this;
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private bool LONHAHGNIOF(string EOKBKAKDMGH)
	{
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Desactivado: " + PlayerInputs.GetPlayer(0).AAGNDCEODFO();
		return true;
	}

	private bool GLODNBCOMNI(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "Deselect item", "ReceiveActorPosition");
		int result = 154;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			TavernReputation.CFJHLLMMBJG(result + result * TavernReputation.GetMilestone());
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "BarnTutorialDone" + (result + result * TavernReputation.MHGADJPMHFI());
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "BottomFarm";
		return false;
	}

	private void Awake()
	{
		((Component)inputfield).gameObject.SetActive(false);
		consolePanel.gameObject.SetActive(false);
		instance = this;
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private bool IAHPEAFAFCK()
	{
		TravelZonesManager.LKOABOAADCD().KCJMDAPPJLB(~(Location.Tavern | Location.Quarry | Location.BarnInterior), Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop).StartTravelZone(1);
		return false;
	}

	private bool NIFGPIOKMCC()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.PetShop).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.PetShop).StartTravelZone(2);
		}
		return true;
	}

	private bool KJAKKKEOEBG()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<Vector3, WorldTile> item in new Dictionary<Vector3, WorldTile>(GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM))
		{
			if (item.Value.location == Location.Road && item.Value.farmable && item.Value.canPlaceObjects && item.Value.herbs == null && item.Value.placeables == null && !WorldGrid.LLCOKBFJJLJ(item.Key))
			{
				WorldGrid.MMOHADHAAGD(item.Key, GroundType.TilledEarth, Location.Road).transform.position = WorldGrid.LOJBKLKMINM(item.Key);
			}
		}
		return true;
	}

	private bool CNNMDFJPMNK()
	{
		GraphicsMenuUI.GGFJGHHHEJC.AddAllResolutions();
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "All screen resolutions added...";
		return true;
	}

	private bool OLDHMDMHDOD()
	{
		if (Object.op_Implicit((Object)(object)player1CameraTarget))
		{
			player1CameraTarget.travellingTime += 1f;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Travelling time increased to " + player1CameraTarget.travellingTime;
		}
		return true;
	}

	private bool FJKJNKEPENM(string EOKBKAKDMGH)
	{
		string text = EOKBKAKDMGH.Substring(11);
		Debug.LogError((object)text);
		if (text.Length == 5)
		{
			OnlineManager.SetPrivateRoomCodeFromSteam(text);
			return true;
		}
		return false;
	}

	private bool JEHAECAPNNC()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(-488f, 93f), new Vector2(-488f, 100.5f));
	}

	private bool BEFACDCJPNK(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "distillingRepUnlock", "MineFloor");
		if (int.TryParse(EOKBKAKDMGH, out var result))
		{
			for (int i = 0; i < TutorialPopUps.autoSetUp.Count; i += 0)
			{
				if (TutorialPopUps.autoSetUp[i].MAHJGIPMJBP() == result)
				{
					TutorialManager.GGFJGHHHEJC.AEBKHLILFNJ(TutorialPopUps.autoSetUp[i], MDNOOMBIFNN: false, BLKLCBCGHCN: true);
					TextMeshProUGUI obj = consoleText;
					((TMP_Text)obj).text = ((TMP_Text)obj).text + "" + result;
					return true;
				}
			}
			TextMeshProUGUI obj2 = consoleText;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Wall";
			return true;
		}
		TextMeshProUGUI obj3 = consoleText;
		((TMP_Text)obj3).text = ((TMP_Text)obj3).text + " ";
		return true;
	}

	private bool CDHMKFJEKJG(string EOKBKAKDMGH)
	{
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		for (int i = 0; i < allRecipes.Length; i++)
		{
			if (allRecipes[i].unlock != 0)
			{
				RecipesManager.UnlockRecipe(allRecipes[i]);
			}
		}
		return true;
	}

	private bool GAFKLBJCBFI()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River, Location.Forest).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.River, Location.Forest).StartTravelZone(2);
		}
		return true;
	}

	public bool ABPOOFIPKDJ(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "City/Rhia/Bark/Stand" + inputfield.text + "tutorial phase";
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(EOKBKAKDMGH);
		switch (num)
		{
		default:
			if (num <= 4294967224u)
			{
				if (num <= 175)
				{
					if (num <= 184)
					{
						if (num <= 4294967142u)
						{
							if (num != 4294967214u)
							{
								if (num != 4294967233u)
								{
									if (num != 64 || !(EOKBKAKDMGH == "TimeLeft"))
									{
										break;
									}
									goto IL_0f46;
								}
								if (!(EOKBKAKDMGH == "Segment Intensity:"))
								{
									break;
								}
								return ENFEIPEBFFI();
							}
							if (!(EOKBKAKDMGH == "ReceiveOrderRequestNinjaCustomer"))
							{
								break;
							}
							return CALBAJOBLDO();
						}
						switch (num)
						{
						case 66u:
							if (!(EOKBKAKDMGH == "Player2"))
							{
								break;
							}
							return MPHMCCKAAMB();
						case 4294967238u:
							if (!(EOKBKAKDMGH == "add item "))
							{
								break;
							}
							return INKOAKJDEMG();
						case 4294967267u:
							if (!(EOKBKAKDMGH == "No bucket of water"))
							{
								break;
							}
							return NANGPPPHAEA();
						}
						break;
					}
					if (num > 4294967244u)
					{
						switch (num)
						{
						case 36u:
							if (!(EOKBKAKDMGH == "HotBath/Bark"))
							{
								break;
							}
							MineManager.BGMJCCFNNDL().CHKKKBGALKB(CDPAMNIPPEC: false);
							return false;
						case 71u:
							if (!(EOKBKAKDMGH == "Lose"))
							{
								break;
							}
							return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
						case 29u:
							if (!(EOKBKAKDMGH == "The mine piece "))
							{
								break;
							}
							return GFKGKOBEAGD();
						}
						break;
					}
					if (num != 104)
					{
						switch (num)
						{
						case 4294967156u:
							if (!(EOKBKAKDMGH == " of "))
							{
								break;
							}
							return ADNFEBOAGAD();
						case 4294967277u:
							if (!(EOKBKAKDMGH == "itemBeetroot"))
							{
								break;
							}
							return KFIPNONCLBK();
						}
						break;
					}
					if (!(EOKBKAKDMGH == "Interaction was initiated, but the object is not in range. Only possible in online."))
					{
						break;
					}
				}
				else
				{
					if (num > 4294967224u)
					{
						if (num <= 4294967243u)
						{
							switch (num)
							{
							case 4294967257u:
								if (!(EOKBKAKDMGH == "F2"))
								{
									break;
								}
								return AAIPJMFLDEJ();
							case 94u:
								if (!(EOKBKAKDMGH == "Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/1/Dialogue Text"))
								{
									break;
								}
								return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
							case 113u:
								if (!(EOKBKAKDMGH == "Fortitude/MainEvent 1"))
								{
									break;
								}
								return OAIKONKMDGK();
							}
							break;
						}
						if (num != 4294967202u)
						{
							switch (num)
							{
							case 4294967272u:
								if (!(EOKBKAKDMGH == "Angry"))
								{
									break;
								}
								return KJDDNEIMAAB();
							case 4294967163u:
								if (!(EOKBKAKDMGH == " not found"))
								{
									break;
								}
								return GAFKLBJCBFI();
							}
							break;
						}
						if (!(EOKBKAKDMGH == "Level"))
						{
							break;
						}
						goto IL_0f4d;
					}
					if (num > 4294967150u)
					{
						switch (num)
						{
						case 4294967271u:
							if (!(EOKBKAKDMGH == "MainProgress"))
							{
								break;
							}
							return GKPMGOIFDPP();
						case 173u:
							if (!(EOKBKAKDMGH == " "))
							{
								break;
							}
							return ABBLKDMCNEI();
						case 4294967139u:
							if (!(EOKBKAKDMGH == "Farm/Event/SwordVioletArthur"))
							{
								break;
							}
							return NLHAFDBGGAM();
						}
						break;
					}
					if (num != 4294967191u)
					{
						switch (num)
						{
						case 107u:
							if (!(EOKBKAKDMGH == "Farm/Buzz/Introduce"))
							{
								break;
							}
							return ANOOPFGHNCJ();
						case 157u:
							if (!(EOKBKAKDMGH == "itemPaleWort"))
							{
								break;
							}
							return OLBMOPFDOIH();
						}
						break;
					}
					if (!(EOKBKAKDMGH == "Player"))
					{
						break;
					}
				}
				return BANOOOCLAFB();
			}
			if (num <= 4294967264u)
			{
				if (num <= 4294967193u)
				{
					if (num <= 85)
					{
						switch (num)
						{
						case 157u:
							if (!(EOKBKAKDMGH == "BLOCKS NUMBER: {0} Puzzle Needit: {1}"))
							{
								break;
							}
							return PBGMKMONPJP();
						case 4294967261u:
							if (!(EOKBKAKDMGH == "NinjaChallengeEvent/Lose"))
							{
								break;
							}
							return JEMOACOJLPC();
						case 4294967106u:
							if (!(EOKBKAKDMGH == "FinalTest/MainEvent 2"))
							{
								break;
							}
							return FHGODJOCMPA();
						}
						break;
					}
					if (num != 4294967127u)
					{
						if (num != 17)
						{
							if (num != 4294967165u || !(EOKBKAKDMGH == "Waiting"))
							{
								break;
							}
							return CNNMDFJPMNK();
						}
						if (!(EOKBKAKDMGH == "Online StartTravelZone"))
						{
							break;
						}
						goto IL_0efb;
					}
					if (!(EOKBKAKDMGH == "LE_20"))
					{
						break;
					}
					return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
				}
				if (num > 146)
				{
					switch (num)
					{
					case 4294967221u:
						if (!(EOKBKAKDMGH == "CatSize"))
						{
							break;
						}
						return JEHAECAPNNC();
					case 187u:
						if (!(EOKBKAKDMGH == "Integer {0} changed to {1} on {2}'s animator. Sending RPC."))
						{
							break;
						}
						return FFFEIEKLAJA();
					case 4294967283u:
						if (!(EOKBKAKDMGH == "UI2"))
						{
							break;
						}
						return PKJOGBPCDFP();
					}
					break;
				}
				if (num != 42)
				{
					switch (num)
					{
					case 37u:
						if (!(EOKBKAKDMGH == "<color=#713112>"))
						{
							break;
						}
						return FFNMMACFBKP(MJHBHDAEDLF: true);
					case 192u:
						if (!(EOKBKAKDMGH == ""))
						{
							break;
						}
						return StartPirates();
					}
					break;
				}
				if (!(EOKBKAKDMGH == "LE_10"))
				{
					break;
				}
			}
			else
			{
				if (num <= 4294967222u)
				{
					if (num <= 57)
					{
						switch (num)
						{
						case 166u:
							if (!(EOKBKAKDMGH == "Dismiss"))
							{
								break;
							}
							return BIBOLJEFAED();
						case 4294967233u:
							if (!(EOKBKAKDMGH == "Final recipe fragments: "))
							{
								break;
							}
							return ALDODOHNLIF();
						case 23u:
							if (!(EOKBKAKDMGH == "ordersDelivered"))
							{
								break;
							}
							return PGDGLIHMBMK();
						}
						break;
					}
					switch (num)
					{
					case 8u:
						if (!(EOKBKAKDMGH == "Temporary Ingredient"))
						{
							break;
						}
						return CDFBICNOECM();
					case 190u:
						if (!(EOKBKAKDMGH == "No bed assigned to player num: {0}"))
						{
							break;
						}
						return FGCMHDGLGML();
					case 4294967163u:
						if (!(EOKBKAKDMGH == "MainProgress"))
						{
							break;
						}
						return LJPEFDHBFMI();
					}
					break;
				}
				if (num <= 8)
				{
					switch (num)
					{
					case 145u:
						if (!(EOKBKAKDMGH == "Path is blocked"))
						{
							break;
						}
						return LBFKOCFDCBC();
					case 157u:
						if (!(EOKBKAKDMGH == " final price: "))
						{
							break;
						}
						return HLKHPHFKOBH();
					case 4294967227u:
						if (!(EOKBKAKDMGH == "Fill"))
						{
							break;
						}
						return HMNNDPAFKFB();
					}
					break;
				}
				if (num <= 4294967183u)
				{
					switch (num)
					{
					case 98u:
						if (!(EOKBKAKDMGH == "Pause"))
						{
							break;
						}
						return KNHGAFKNOLC();
					case 88u:
						if (!(EOKBKAKDMGH == " </color>"))
						{
							break;
						}
						return BDCPHJICALJ();
					}
					break;
				}
				if (num == 4294967219u)
				{
					if (!(EOKBKAKDMGH == "Invalid year: "))
					{
						break;
					}
					return HNDHIPIILJB();
				}
				if (num != 156 || !(EOKBKAKDMGH == "Disabled"))
				{
					break;
				}
			}
			goto IL_109c;
		case 4294967221u:
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
			if (num <= 68)
			{
				if (num <= 119)
				{
					if (num <= 61)
					{
						if (num != 1)
						{
							if (num != 169)
							{
								if (num != 125 || !(EOKBKAKDMGH == "The mine piece "))
								{
									break;
								}
								return NPAFILPDOAL();
							}
							if (!(EOKBKAKDMGH == "CreatePrewarmNPCs in "))
							{
								break;
							}
							goto IL_109c;
						}
						if (!(EOKBKAKDMGH == "City/Carpenters/Oak/Bark/Chisel"))
						{
							break;
						}
						return OCEMEODOKLH();
					}
					switch (num)
					{
					case 4294967113u:
						if (!(EOKBKAKDMGH == "Received RPC SetAnimatorStateRPC with hash: {0} on {1}, but the state was not found."))
						{
							break;
						}
						return ICGIKKIENDP();
					case 158u:
						if (!(EOKBKAKDMGH == "Right"))
						{
							break;
						}
						return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
					case 4294967148u:
						if (!(EOKBKAKDMGH == "_"))
						{
							break;
						}
						return StartBathhouse();
					}
					break;
				}
				switch (num)
				{
				case 4294967227u:
				case 4294967228u:
				case 4294967229u:
				case 4294967230u:
				case 4294967231u:
				case 4294967232u:
				case 4294967233u:
				case 4294967234u:
				case 4294967235u:
				case 4294967236u:
				case 4294967237u:
				case 4294967238u:
				case 4294967239u:
				case 4294967240u:
				case 4294967241u:
				case 4294967242u:
				case 4294967243u:
				case 4294967244u:
				case 4294967245u:
				case 4294967246u:
				case 4294967247u:
				case 4294967248u:
				case 4294967249u:
				case 4294967250u:
				case 4294967251u:
				case 4294967252u:
				case 4294967253u:
				case 4294967254u:
				case 4294967255u:
				case 4294967256u:
				case 4294967257u:
				case 4294967258u:
				case 4294967259u:
				case 4294967260u:
				case 4294967261u:
				case 4294967262u:
				case 4294967263u:
				case 4294967264u:
				case 4294967265u:
				case 4294967266u:
				case 4294967267u:
				case 4294967268u:
				case 4294967269u:
				case 4294967270u:
				case 4294967271u:
				case 4294967272u:
				case 4294967273u:
				case 4294967274u:
				case 4294967275u:
				case 4294967276u:
				case 4294967277u:
				case 4294967278u:
				case 4294967279u:
				case 4294967280u:
				case 4294967281u:
				case 4294967282u:
				case 4294967283u:
				case 4294967284u:
				case 4294967285u:
				case 4294967286u:
				case 4294967287u:
				case 4294967288u:
				case 4294967289u:
				case 4294967290u:
				case 4294967291u:
				case 4294967292u:
				case 4294967293u:
				case 4294967294u:
				case uint.MaxValue:
					switch (num)
					{
					case 94u:
						if (!(EOKBKAKDMGH == "Player2"))
						{
							break;
						}
						return KHDAGHPKDGK();
					case 4294967276u:
						if (!(EOKBKAKDMGH == "LE_6"))
						{
							break;
						}
						return LBBNAJJGGJI();
					case 4294967220u:
						if (!(EOKBKAKDMGH == "add item "))
						{
							break;
						}
						return OIMMOOFKFFE();
					}
					break;
				case 4294967120u:
					if (!(EOKBKAKDMGH == "Stop"))
					{
						break;
					}
					return MINIPFHJCIP();
				case 148u:
					if (!(EOKBKAKDMGH == "/"))
					{
						break;
					}
					return IAHPEAFAFCK();
				case 4294967219u:
					if (!(EOKBKAKDMGH == " cannot be placed."))
					{
						break;
					}
					return ReplayPirates();
				}
				break;
			}
			if (num <= 4294967118u)
			{
				if (num <= 72)
				{
					switch (num)
					{
					case 152u:
						if (!(EOKBKAKDMGH == "Farming yield"))
						{
							break;
						}
						return IBKNPIBHAFG();
					case 4294967111u:
						if (!(EOKBKAKDMGH == "ReceiveKick"))
						{
							break;
						}
						return IPFNPMLKHPI();
					case 4294967120u:
						if (!(EOKBKAKDMGH == "talent_name_107"))
						{
							break;
						}
						return FJPNLDPGJHO();
					}
					break;
				}
				if (num == 4294967200u)
				{
					if (!(EOKBKAKDMGH == "FishCuttingEvent/Talk1"))
					{
						break;
					}
					return OLDHMDMHDOD();
				}
				if (num == 4294967272u)
				{
					if (!(EOKBKAKDMGH == "Walk"))
					{
						break;
					}
					return JLDEDNNMBAJ();
				}
				if (num != 4294967203u || !(EOKBKAKDMGH == "Player2"))
				{
					break;
				}
			}
			else
			{
				if (num > 26)
				{
					switch (num)
					{
					case 71u:
						if (!(EOKBKAKDMGH == "MayaMinigames"))
						{
							break;
						}
						MineManager.AGGAGCBAGLL().CHKKKBGALKB(CDPAMNIPPEC: false);
						return true;
					case 11u:
						if (!(EOKBKAKDMGH == "Friend list retrieved"))
						{
							break;
						}
						return PEKAICCPANA();
					case 35u:
						if (!(EOKBKAKDMGH == "Dialogue System/Conversation/EnterTavernDrink/Entry/3/Dialogue Text"))
						{
							break;
						}
						return FNNNOKGMHHM();
					}
					break;
				}
				if (num == 4294967268u)
				{
					if (!(EOKBKAKDMGH == "\n"))
					{
						break;
					}
					return FCCJDHKEFBM();
				}
				if (num == 27)
				{
					if (!(EOKBKAKDMGH == "Items/item_name_647"))
					{
						break;
					}
					return BLMHPKBIDFI();
				}
				if (num != 4294967136u || !(EOKBKAKDMGH == "Items/item_name_652"))
				{
					break;
				}
			}
			goto IL_0efb;
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			{
				if (num <= 4294967156u)
				{
					if (num <= 4294967233u)
					{
						if (num <= 142)
						{
							if (num != 4294967237u)
							{
								if (num != 4294967146u)
								{
									if (num != 4294967252u || !(EOKBKAKDMGH == "wForWeeks"))
									{
										break;
									}
									return EOBHPPBKHIJ();
								}
								if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Gass_Stand/Entry/9/Dialogue Text"))
								{
									break;
								}
								goto IL_0efb;
							}
							if (!(EOKBKAKDMGH == "Resolucion nativa: "))
							{
								break;
							}
							return BKJGKACHINN();
						}
						switch (num)
						{
						case 166u:
							if (!(EOKBKAKDMGH == "Pause"))
							{
								break;
							}
							return JMGBBKPLBJM();
						case 4294967132u:
							if (!(EOKBKAKDMGH == ""))
							{
								break;
							}
							return JHHPAOPNNPG();
						case 26u:
							if (!(EOKBKAKDMGH == "OneShotVolume"))
							{
								break;
							}
							return CMONDIHNPBI();
						}
						break;
					}
					if (num <= 75)
					{
						if (num != 1)
						{
							switch (num)
							{
							case 94u:
								if (!(EOKBKAKDMGH == "start pirates"))
								{
									break;
								}
								return AIAGEJIAGPF();
							case 4294967238u:
								if (!(EOKBKAKDMGH == "Dialogue System/Conversation/EnterTavernNeutral/Entry/1/Dialogue Text"))
								{
									break;
								}
								return DDCAAGGBNKM();
							}
							break;
						}
						if (!(EOKBKAKDMGH == "dForDays"))
						{
							break;
						}
						goto IL_0f46;
					}
					if (num == 24)
					{
						if (!(EOKBKAKDMGH == "No room mode has been selected"))
						{
							break;
						}
						return GCDEDCGBMEE();
					}
					if (num == 4294967210u)
					{
						if (!(EOKBKAKDMGH == "petshop travelling"))
						{
							break;
						}
						return MCDCDBIGMMM("Occupied Positions");
					}
					if (num != 4294967222u || !(EOKBKAKDMGH == "Start"))
					{
						break;
					}
				}
				else
				{
					if (num <= 28)
					{
						if (num <= 4294967120u)
						{
							switch (num)
							{
							case 4294967123u:
								if (!(EOKBKAKDMGH == "FishCuttingEvent/Win2"))
								{
									break;
								}
								return KJAKKKEOEBG();
							case 4294967213u:
								if (!(EOKBKAKDMGH == "Pause"))
								{
									break;
								}
								return AIAGEJIAGPF();
							case 4294967206u:
								if (!(EOKBKAKDMGH == "ReceiveEnableTrigger"))
								{
									break;
								}
								return DGJEBGHMGHB();
							}
							break;
						}
						switch (num)
						{
						case 179u:
							if (!(EOKBKAKDMGH == "Items/item_description_683"))
							{
								break;
							}
							return LNCFOBHEABH();
						case 39u:
							if (!(EOKBKAKDMGH == "\n<color=#822F00>"))
							{
								break;
							}
							return KDJKLGEHJAC();
						case 199u:
							if (!(EOKBKAKDMGH == "Checking current game language"))
							{
								break;
							}
							return FFNMMACFBKP(MJHBHDAEDLF: false);
						}
						break;
					}
					if (num <= 56)
					{
						if (num == 4294967271u)
						{
							if (!(EOKBKAKDMGH == "castle interior travelling"))
							{
								break;
							}
							return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
						}
						if (num != 195)
						{
							if (num != 0 || !(EOKBKAKDMGH == "steam status"))
							{
								break;
							}
							goto IL_0f4d;
						}
						if (!(EOKBKAKDMGH == "PressToPlay"))
						{
							break;
						}
					}
					else
					{
						if (num <= 4294967252u)
						{
							switch (num)
							{
							case 148u:
								if (!(EOKBKAKDMGH == "Deserialize SettingsData error: /ExtraSettings.sd"))
								{
									break;
								}
								return FMOALABPHNF();
							case 4294967241u:
								if (!(EOKBKAKDMGH == " x "))
								{
									break;
								}
								return OAGCHNDPOLO();
							}
							break;
						}
						if (num == 4294967202u)
						{
							if (!(EOKBKAKDMGH == "Cider"))
							{
								break;
							}
							return NHCKDLCOAMO();
						}
						if (num != 183 || !(EOKBKAKDMGH == "Sleep"))
						{
							break;
						}
					}
				}
				goto IL_109c;
			}
			IL_0f4d:
			return OCJHJJFJAPN();
			IL_0f46:
			return EOOABCEHOKG();
			IL_0efb:
			return AFKKMBIDEBB();
			IL_109c:
			return GHPIMLBHMPP();
		}
		if (EOKBKAKDMGH.Contains("DogOfFriend"))
		{
			return NNBDLCLPKEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Attack/MainEvent 3"))
		{
			return MHIBNKHCDLI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_666"))
		{
			return PLOKNFMFBMI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Unlocked at Tavern Reputation {0}"))
		{
			return PMKNKFIKCPG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("City/Carpenters/Willow/Stand"))
		{
			return JMHEKECCFCN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_619"))
		{
			return MCDCDBIGMMM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Guest"))
		{
			return FLNOANAOAAC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" - "))
		{
			return JABEGCPGOPB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Left Stick Down"))
		{
			return KNLBNFACLJK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Player/Bark/Tutorial/T101"))
		{
			return PDKPNOLLELN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("start bath"))
		{
			return IIDFGNLMGDG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" name"))
		{
			return LDPFLLOGAND(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveActivateEatGameObjects"))
		{
			return HJHBPPAOGKN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("FocusedMod"))
		{
			return NDHJHDIKEKK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Calm down"))
		{
			return INBCACPBEKL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" because it has puzzle altar and this method is for restoring non-altar variants."))
		{
			return HKIFELEDFFD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_616"))
		{
			ItemInstance.showIdsNum = ItemInstance.showIdsNum;
		}
		if (EOKBKAKDMGH.Contains("SetBoolRPC"))
		{
			RandomOrderQuestsManager.HLMGBEGEAPC().FEIKEEMJMHJ();
			return true;
		}
		if (EOKBKAKDMGH.Contains(" </color>"))
		{
			return JGNBGECEINP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("add item 1444 20"))
		{
			return BAALKNEHBBM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Jump"))
		{
			return FLJFPPDNBMO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("LE_10"))
		{
			return EFAKLBHENPJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Chisel"))
		{
			return JIFGNOOEIEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Left Stick Down"))
		{
			return JIFOEPHOGEO();
		}
		if (EOKBKAKDMGH.Contains("Win"))
		{
			return JDFBLMEHPMP();
		}
		if (EOKBKAKDMGH.Contains("Attack/MainEvent 2"))
		{
			return HCKNEEPJNCB();
		}
		if (EOKBKAKDMGH.Contains("BarnTutorialDone"))
		{
			return AddMaterials(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("add item "))
		{
			return LONHAHGNIOF(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Bed without valid position"))
		{
			Utils.disableHalloweenEvent = !Utils.disableHalloweenEvent;
			return true;
		}
		if (EOKBKAKDMGH.Contains("talentPale"))
		{
			return PFFMBKBEGJH(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("0"))
		{
			return IJCFIKFDGPG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveLevelPoints"))
		{
			PlayerInputs.GetPlayer(0).debugControllers = PlayerInputs.DEGBDMMDIIL(0).debugControllers;
			return false;
		}
		if (EOKBKAKDMGH.Contains("Get Components "))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.None);
			return true;
		}
		if (EOKBKAKDMGH.Contains(" destroyed.") && !EOKBKAKDMGH.Contains("Could not find Quest with id: ") && !EOKBKAKDMGH.Contains("NotMyChest"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Wind);
			return false;
		}
		if (EOKBKAKDMGH.Contains("PanelToggleUI"))
		{
			Weather.ShowWeather(Weather.WeatherType.Snow | Weather.WeatherType.PrecipitationCloudy);
			return true;
		}
		if (EOKBKAKDMGH.Contains("<sprite name=\"woodIcon\">"))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.PrecipitationCloudy));
			return true;
		}
		if (EOKBKAKDMGH.Contains("ReceiveSick") && !EOKBKAKDMGH.Contains("ReceiveFireplaceMessage"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.None);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Walk Around cannot entry barn "))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Request begin replay"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Rain | Weather.WeatherType.Wind | Weather.WeatherType.Cloudy);
			return false;
		}
		if (EOKBKAKDMGH.Contains("itemCourgetteSeeds") && !EOKBKAKDMGH.Contains("Error_BarNotInADiningRoom"))
		{
			Weather.NGAHKOODEBL(~(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.SunnyClouds));
			return false;
		}
		if (EOKBKAKDMGH.Contains("Bomb"))
		{
			Weather.DAJEJCGGPGO(Weather.WeatherType.Snow);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Player"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Snow);
			return true;
		}
		if (EOKBKAKDMGH.Contains("ReceiveRequestChristmasEvent"))
		{
			List<Fish> list = ItemDatabaseAccessor.HJLAOCAJAEB();
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].displayMethod.HasFlag(Fish.DisplayMethod.None))
				{
					FishingManager.JOFHBLKMFEG(list[i], ((Vector2Int)(ref list[i].lenght)).x, CDPAMNIPPEC: false);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("fishDishes"))
		{
			List<Fish> list2 = ItemDatabaseAccessor.PCFCELEHIAN();
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.FBHFGECMPOI(list2[j]);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("UI"))
		{
			return IFJFLECIFII(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Numeric"))
		{
			return LCOBGLILEIG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ObjectVerticalMove"))
		{
			return FJKJNKEPENM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("itemRyeLager"))
		{
			return GAONHALIEAI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("UI2"))
		{
			return INIDNJOJJPD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Sleeve_R"))
		{
			return FMNEPHOJEFI(EOKBKAKDMGH);
		}
		return true;
	}

	private bool FNFLLJPCAOJ(string EOKBKAKDMGH)
	{
		if (SeasonManager.BLCGOEMGKGH() == Season.Spring)
		{
			SeasonManager.instance.NMMLELDCBBJ(Season.Spring);
		}
		else if (SeasonManager.KCJFCHNPIBJ() == Season.Spring)
		{
			SeasonManager.instance.ChangeSeason((Season)6);
		}
		else if (SeasonManager.BLCGOEMGKGH() == (Season)4)
		{
			SeasonManager.instance.CJGIEMCPPPF(Season.Summer);
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Spring)
		{
			SeasonManager.instance.NMMLELDCBBJ(Season.Summer);
		}
		return true;
	}

	private bool BFFNOKNGJLG()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return PPAMAJMMLLM(new Vector2(1058f, 715f), new Vector2(1693f, 314f));
	}

	private bool JMHEKECCFCN(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "ReceiveUnlockPerkLevel", "Items/item_description_679");
		int result = -18;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			Time.timeScale = result;
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "ReceiveStartKlaynDialogueOathFeast" + result;
			return true;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "roomsRented";
		return true;
	}

	public bool PDGCMHBCNBJ()
	{
		PiratesGameManager.DGEDIKLKHDE();
		return false;
	}

	private bool IBKNPIBHAFG()
	{
		FogManager[] array = Object.FindObjectsOfType<FogManager>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].FBLDCBFKNEE(array[i].FABINONGNCE());
		}
		return false;
	}

	private bool BAALKNEHBBM(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "add quest ", "");
		string[] array = Regex.Split(EOKBKAKDMGH, " ");
		int result = 9999;
		if (array.Length != 0 && int.TryParse(array[0], out result))
		{
			if (result >= 300)
			{
				MissionsManager.instance.StartMission(result);
			}
			else
			{
				Quest quest = QuestDatabaseAccessor.GetQuest(result);
				if (Object.op_Implicit((Object)(object)quest))
				{
					QuestManager.GGFJGHHHEJC.AddQuest(quest);
					QuestHighlightUI.ShowNewQuestAvailable(quest);
					return true;
				}
			}
		}
		return true;
	}

	public bool INKJPGENGFH(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "BarIdleNumber" + inputfield.text + "ChatLogRequest";
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(EOKBKAKDMGH);
		if (num <= 164)
		{
			if (num <= 164)
			{
				if (num <= 4294967223u)
				{
					if (num <= 118)
					{
						if (num <= 114)
						{
							if (num != 4294967170u)
							{
								if (num != 4294967246u)
								{
									if (num == 146 && EOKBKAKDMGH == "EmployeeLevelUp")
									{
										goto IL_0f46;
									}
								}
								else if (EOKBKAKDMGH == "A very important guest is visiting!")
								{
									return MIOFOMCEKJI();
								}
							}
							else if (EOKBKAKDMGH == "...Failed")
							{
								return CCLNLPDBJKC();
							}
						}
						else
						{
							switch (num)
							{
							case 65u:
								if (!(EOKBKAKDMGH == "in"))
								{
									break;
								}
								return AGOPFBEACPA();
							case 189u:
								if (!(EOKBKAKDMGH == "BARKDOOR"))
								{
									break;
								}
								return AGFFLMOHMBC();
							case 4294967256u:
								if (!(EOKBKAKDMGH == "</color>"))
								{
									break;
								}
								return NANGPPPHAEA();
							}
						}
					}
					else if (num <= 4294967166u)
					{
						if (num != 192)
						{
							switch (num)
							{
							case 4294967192u:
								if (!(EOKBKAKDMGH == "Right Control"))
								{
									break;
								}
								return ADNFEBOAGAD();
							case 4294967184u:
								if (!(EOKBKAKDMGH == "HeadToBed"))
								{
									break;
								}
								return PGNOLMJEJPD();
							}
						}
						else if (EOKBKAKDMGH == "Top")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 24u:
							if (!(EOKBKAKDMGH == "Starting New Game Coroutine"))
							{
								break;
							}
							MineManager.BGMJCCFNNDL().CHKKKBGALKB(CDPAMNIPPEC: false);
							return true;
						case 4294967207u:
							if (!(EOKBKAKDMGH == "Normal"))
							{
								break;
							}
							return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
						case 4294967143u:
							if (!(EOKBKAKDMGH == "/Female/"))
							{
								break;
							}
							return GFKGKOBEAGD();
						}
					}
				}
				else if (num <= 4294967177u)
				{
					if (num <= 4294967276u)
					{
						if (num != 47)
						{
							switch (num)
							{
							case 17u:
								if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Gass_Introduce/Entry/14/Dialogue Text"))
								{
									break;
								}
								return ANOOPFGHNCJ();
							case 4294967124u:
								if (!(EOKBKAKDMGH == "LE_10"))
								{
									break;
								}
								return OLBMOPFDOIH();
							}
						}
						else if (EOKBKAKDMGH == "Must")
						{
							goto IL_108e;
						}
					}
					else
					{
						switch (num)
						{
						case 4294967196u:
							if (!(EOKBKAKDMGH == "Dead"))
							{
								break;
							}
							return NCPPHJCICHD();
						case 4294967281u:
							if (!(EOKBKAKDMGH == " for reason "))
							{
								break;
							}
							return ABBLKDMCNEI();
						case 35u:
							if (!(EOKBKAKDMGH == "LevelAbbreviation"))
							{
								break;
							}
							return NLHAFDBGGAM();
						}
					}
				}
				else if (num <= 4294967119u)
				{
					switch (num)
					{
					case 133u:
						if (!(EOKBKAKDMGH == ". Time since startup: "))
						{
							break;
						}
						return AAIPJMFLDEJ();
					case 4294967281u:
						if (!(EOKBKAKDMGH == "No puzzle found for {0} torches, "))
						{
							break;
						}
						return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
					case 107u:
						if (!(EOKBKAKDMGH == "Item "))
						{
							break;
						}
						return OAIKONKMDGK();
					}
				}
				else if (num != 4294967115u)
				{
					switch (num)
					{
					case 4294967136u:
						if (!(EOKBKAKDMGH == "Calendar"))
						{
							break;
						}
						return KJDDNEIMAAB();
					case 42u:
						if (!(EOKBKAKDMGH == "{0} does not have a valid animation with the hash {1}. "))
						{
							break;
						}
						return GAFKLBJCBFI();
					}
				}
				else if (EOKBKAKDMGH == "itemLog")
				{
					goto IL_0f4d;
				}
			}
			else if (num <= 162)
			{
				if (num <= 4294967173u)
				{
					if (num <= 4294967159u)
					{
						switch (num)
						{
						case 170u:
							if (!(EOKBKAKDMGH == "The game's host has disconnected. Returning to title screen..."))
							{
								break;
							}
							return KFIJCCHECAH();
						case 4294967192u:
							if (!(EOKBKAKDMGH == "itemDillSeeds"))
							{
								break;
							}
							return JEMOACOJLPC();
						case 4294967172u:
							if (!(EOKBKAKDMGH == "DiscusionMineros/Main"))
							{
								break;
							}
							return AJDCAIMMGHJ();
						}
					}
					else if (num != 12)
					{
						if (num != 185)
						{
							if (num == 4294967188u && EOKBKAKDMGH == "00")
							{
								return CNNMDFJPMNK();
							}
						}
						else if (EOKBKAKDMGH == "fishCaught")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "Cat")
					{
						return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
					}
				}
				else if (num <= 4294967162u)
				{
					if (num != 4294967116u)
					{
						switch (num)
						{
						case 4294967221u:
							if (!(EOKBKAKDMGH == "UIInteract"))
							{
								break;
							}
							return FFNMMACFBKP(MJHBHDAEDLF: true);
						case 4294967189u:
							if (!(EOKBKAKDMGH == "Throw"))
							{
								break;
							}
							return StartPirates();
						}
					}
					else if (EOKBKAKDMGH == "Player2")
					{
						goto IL_109c;
					}
				}
				else
				{
					switch (num)
					{
					case 111u:
						if (!(EOKBKAKDMGH == "Hair"))
						{
							break;
						}
						return OABLIHKPNCF();
					case 79u:
						if (!(EOKBKAKDMGH == "ReceivePassOutActions"))
						{
							break;
						}
						return FFFEIEKLAJA();
					case 4294967131u:
						if (!(EOKBKAKDMGH == "DisableRight"))
						{
							break;
						}
						return PKJOGBPCDFP();
					}
				}
			}
			else if (num <= 116)
			{
				if (num <= 125)
				{
					switch (num)
					{
					case 22u:
						if (!(EOKBKAKDMGH == "ReceiveOfferingPuzzle"))
						{
							break;
						}
						return BIBOLJEFAED();
					case 106u:
						if (!(EOKBKAKDMGH == "Open"))
						{
							break;
						}
						return KGABMHNDMAA();
					case 135u:
						if (!(EOKBKAKDMGH == "Whiskey"))
						{
							break;
						}
						return PGDGLIHMBMK();
					}
				}
				else
				{
					switch (num)
					{
					case 95u:
						if (!(EOKBKAKDMGH == "ReciveSimpleDialogueStart"))
						{
							break;
						}
						return CDFBICNOECM();
					case 4294967165u:
						if (!(EOKBKAKDMGH == "Could not find shop with shopType: "))
						{
							break;
						}
						return FGCMHDGLGML();
					case 4294967117u:
						if (!(EOKBKAKDMGH == "Player2"))
						{
							break;
						}
						return ReplayFish();
					}
				}
			}
			else if (num <= 4294967141u)
			{
				switch (num)
				{
				case 176u:
					if (!(EOKBKAKDMGH == "Activated fishing key: {0}, isLeftPiece: {1}. Particle zone enabled."))
					{
						break;
					}
					return LBFKOCFDCBC();
				case 4294967206u:
					if (!(EOKBKAKDMGH == "MainProgress"))
					{
						break;
					}
					return HLKHPHFKOBH();
				case 180u:
					if (!(EOKBKAKDMGH == "Player/Bark/PickUpBlocker"))
					{
						break;
					}
					return HMNNDPAFKFB();
				}
			}
			else if (num <= 79)
			{
				switch (num)
				{
				case 4294967156u:
					if (!(EOKBKAKDMGH == "DecorationTile_9"))
					{
						break;
					}
					return KNHGAFKNOLC();
				case 21u:
					if (!(EOKBKAKDMGH == "Tutorial/T104/Dialogue1"))
					{
						break;
					}
					return BDCPHJICALJ();
				}
			}
			else if (num != 89)
			{
				if (num == 86 && EOKBKAKDMGH == "Farm/Buzz/Bark_Searching")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "L1")
			{
				return HNDHIPIILJB();
			}
		}
		else if (num <= 106)
		{
			if (num <= 165)
			{
				if (num <= 191)
				{
					if (num <= 4294967197u)
					{
						if (num != 176)
						{
							if (num != 4294967107u)
							{
								if (num == 4294967158u && EOKBKAKDMGH == "Received set minigame")
								{
									return CPNHFBKGOCB();
								}
							}
							else if (EOKBKAKDMGH == "Room ")
							{
								goto IL_109c;
							}
						}
						else if (EOKBKAKDMGH == ". Added to delivery chest")
						{
							return OCEMEODOKLH();
						}
					}
					else
					{
						switch (num)
						{
						case 53u:
							if (!(EOKBKAKDMGH == "ReceiveRequestChallengeRestart"))
							{
								break;
							}
							return ICGIKKIENDP();
						case 31u:
							if (!(EOKBKAKDMGH == "tutorialPopUp124"))
							{
								break;
							}
							return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
						case 151u:
							if (!(EOKBKAKDMGH == "Screenshot not found"))
							{
								break;
							}
							return StartBathhouse();
						}
					}
				}
				else if (num <= 145)
				{
					switch (num)
					{
					case 190u:
						if (!(EOKBKAKDMGH == "Down"))
						{
							break;
						}
						return MINIPFHJCIP();
					case 4294967118u:
						if (!(EOKBKAKDMGH == "ReceiveBeginPirateMinigame"))
						{
							break;
						}
						return IAHPEAFAFCK();
					case 4294967144u:
						if (!(EOKBKAKDMGH == "TorchPuzzleDatabase not assigned"))
						{
							break;
						}
						return ReplayPirates();
					}
				}
				else
				{
					switch (num)
					{
					case 4294967151u:
						if (!(EOKBKAKDMGH == "Melt"))
						{
							break;
						}
						return CDCCALONMGD();
					case 70u:
						if (!(EOKBKAKDMGH == ">"))
						{
							break;
						}
						return LBBNAJJGGJI();
					case 59u:
						if (!(EOKBKAKDMGH == "Bomb"))
						{
							break;
						}
						return OIMMOOFKFFE();
					}
				}
			}
			else if (num <= 4294967254u)
			{
				if (num <= 40)
				{
					switch (num)
					{
					case 4294967263u:
						if (!(EOKBKAKDMGH == "Items/item_name_1124"))
						{
							break;
						}
						return IBKNPIBHAFG();
					case 4294967288u:
						if (!(EOKBKAKDMGH == "HorizontalMove"))
						{
							break;
						}
						return BBCNMCDDPCD();
					case 4294967117u:
						if (!(EOKBKAKDMGH == "ReceiveInitialPosition"))
						{
							break;
						}
						return BIMHIKKACJD();
					}
				}
				else if (num != 39)
				{
					if (num != 99)
					{
						if (num == 77 && EOKBKAKDMGH == "Granting item ")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "HaveGoldenTicket")
					{
						return HMINCAELJNO();
					}
				}
				else if (EOKBKAKDMGH == "Enter")
				{
					return IFLKPHCBLBO();
				}
			}
			else if (num <= 4294967231u)
			{
				if (num != 4294967167u)
				{
					if (num != 168)
					{
						if (num == 4294967128u && EOKBKAKDMGH == "Items/item_name_651")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "quest_reward_")
					{
						return BLMHPKBIDFI();
					}
				}
				else if (EOKBKAKDMGH == "Items/item_description_1035")
				{
					return FCCJDHKEFBM();
				}
			}
			else
			{
				switch (num)
				{
				case 25u:
					if (!(EOKBKAKDMGH == "Day"))
					{
						break;
					}
					MineManager.AGGAGCBAGLL().JKNOFKDANMN(CDPAMNIPPEC: false);
					return false;
				case 4294967277u:
					if (!(EOKBKAKDMGH == "City/PetShop/Nessy/PerritosAbandonados"))
					{
						break;
					}
					return NOODKHHGKPI();
				case 4294967135u:
					if (!(EOKBKAKDMGH == "buildingObjective_9_0"))
					{
						break;
					}
					return FNNNOKGMHHM();
				}
			}
		}
		else if (num <= 4294967121u)
		{
			if (num <= 61)
			{
				if (num <= 4294967151u)
				{
					if (num != 31)
					{
						if (num != 4294967240u)
						{
							if (num == 4294967204u && EOKBKAKDMGH == "PreviousItem")
							{
								return JIBJBOEMKGM();
							}
						}
						else if (EOKBKAKDMGH == "\n<color=#822F00>")
						{
							goto IL_0efb;
						}
					}
					else if (EOKBKAKDMGH == "ReceiveDogPosition")
					{
						return BKJGKACHINN();
					}
				}
				else
				{
					switch (num)
					{
					case 4294967264u:
						if (!(EOKBKAKDMGH == "ops"))
						{
							break;
						}
						return JMGBBKPLBJM();
					case 42u:
						if (!(EOKBKAKDMGH == "tutorialPopUp124"))
						{
							break;
						}
						return BFDOOAIAMME();
					case 91u:
						if (!(EOKBKAKDMGH == "</color> to inventory?"))
						{
							break;
						}
						return POAEGGMIAGP();
					}
				}
			}
			else if (num <= 175)
			{
				if (num != 4294967182u)
				{
					switch (num)
					{
					case 4294967240u:
						if (!(EOKBKAKDMGH == "Side"))
						{
							break;
						}
						return AIAGEJIAGPF();
					case 177u:
						if (!(EOKBKAKDMGH == "[MineVariantsSelector] No valid variants available for piece {0} after full pool regeneration."))
						{
							break;
						}
						return DDCAAGGBNKM();
					}
				}
				else if (EOKBKAKDMGH == "/")
				{
					goto IL_0f46;
				}
			}
			else if (num != 26)
			{
				if (num != 59)
				{
					if (num == 173 && EOKBKAKDMGH == "ReceiveKeyPuzzle")
					{
						goto IL_109c;
					}
				}
				else if (EOKBKAKDMGH == "SetAnimationControllerIndexesRPC")
				{
					return OnPlayerSleep("ReceiveInstantiateDog");
				}
			}
			else if (EOKBKAKDMGH == "pirate")
			{
				return PHGHFLHBJDM();
			}
		}
		else if (num <= 4294967153u)
		{
			if (num <= 4294967181u)
			{
				switch (num)
				{
				case 20u:
					if (!(EOKBKAKDMGH == " will be destroyed in "))
					{
						break;
					}
					return KJAKKKEOEBG();
				case 4294967152u:
					if (!(EOKBKAKDMGH == ""))
					{
						break;
					}
					return AIAGEJIAGPF();
				case 40u:
					if (!(EOKBKAKDMGH == "Dialogue System/Conversation/Crowly_Standar/Entry/1/Dialogue Text"))
					{
						break;
					}
					return JDALGGKAGDG();
				}
			}
			else
			{
				switch (num)
				{
				case 89u:
					if (!(EOKBKAKDMGH == "itemRedGrapeMust"))
					{
						break;
					}
					return ILADCDMFPON();
				case 4294967265u:
					if (!(EOKBKAKDMGH == "TabernaClausurada/KlaynDialogue 01"))
					{
						break;
					}
					return KDJKLGEHJAC();
				case 105u:
					if (!(EOKBKAKDMGH == "Mussel parent not found!!. Parent unique ID: "))
					{
						break;
					}
					return FFNMMACFBKP(MJHBHDAEDLF: true);
				}
			}
		}
		else if (num <= 4294967246u)
		{
			if (num != 125)
			{
				if (num != 51)
				{
					if (num == 181 && EOKBKAKDMGH == "BuildMode_ExitAndSave")
					{
						goto IL_0f4d;
					}
				}
				else if (EOKBKAKDMGH == "Circle")
				{
					goto IL_109c;
				}
			}
			else if (EOKBKAKDMGH == "Close")
			{
				return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
			}
		}
		else if (num <= 179)
		{
			switch (num)
			{
			case 70u:
				if (!(EOKBKAKDMGH == "Numeric"))
				{
					break;
				}
				return FMOALABPHNF();
			case 35u:
				if (!(EOKBKAKDMGH == "Direction"))
				{
					break;
				}
				return NMDHHEAKPPA();
			}
		}
		else if (num != 4294967257u)
		{
			if (num == 118 && EOKBKAKDMGH == " already exists for ")
			{
				goto IL_109c;
			}
		}
		else if (EOKBKAKDMGH == "Error_StairsAreBlocking")
		{
			return ENMMPPBGHAA();
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_612"))
		{
			return NNBDLCLPKEE(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("hForHours"))
		{
			return BHJAHKJCBJF(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_1153"))
		{
			return FAOINCNMKPL(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Quit to desktop?"))
		{
			return IBEAIGOCMAB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("El componente ItemSetup del rotatedPrefab '"))
		{
			return PPFBJDAJBPK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" "))
		{
			return MCDCDBIGMMM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("quest_objective_"))
		{
			return FNFLLJPCAOJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" "))
		{
			return JABEGCPGOPB(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ReceiveCastleFormEndLucenEvent"))
		{
			return CMEEFLDCGHO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_687"))
		{
			return PDKPNOLLELN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("All bubbles in use!"))
		{
			return LDABLGMHDPC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("buildingObjective_25_4"))
		{
			return LPCKAOCMOHJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Rowdy"))
		{
			return HJHBPPAOGKN(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" state"))
		{
			return NDHJHDIKEKK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(" / "))
		{
			return BDIPKPLEGKM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Gameplay"))
		{
			return CBDMHEPOMJD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Interact"))
		{
			ItemInstance.showIdsNum = ItemInstance.showIdsNum;
		}
		if (EOKBKAKDMGH.Contains("add item "))
		{
			RandomOrderQuestsManager.HLMGBEGEAPC().FEIKEEMJMHJ();
			return true;
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_627"))
		{
			return JGNBGECEINP(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Income"))
		{
			return BAALKNEHBBM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Sick"))
		{
			return FLJFPPDNBMO(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Items/item_description_681"))
		{
			return CDHMKFJEKJG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("ClosePopUp"))
		{
			return NHBMIODBACK(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("KickedSpinDirection"))
		{
			return JIFOEPHOGEO();
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text"))
		{
			return HOFMPKCPJBH();
		}
		if (EOKBKAKDMGH.Contains("Bouncer"))
		{
			return HCKNEEPJNCB();
		}
		if (EOKBKAKDMGH.Contains("MaximumCapacity"))
		{
			return PFDIGPJCPBJ(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Fishing"))
		{
			return KOGAFKKIBGC(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(". Time since startup: "))
		{
			Utils.disableHalloweenEvent = Utils.disableHalloweenEvent;
			return true;
		}
		if (EOKBKAKDMGH.Contains("ProceduralMine instance is null when trying to assign mine ID."))
		{
			return EDEKHLKKODG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("TucanEgg"))
		{
			return IJCFIKFDGPG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains(":</color> "))
		{
			PlayerInputs.DEGBDMMDIIL(0).debugControllers = !PlayerInputs.GetPlayer(0).debugControllers;
			return true;
		}
		if (EOKBKAKDMGH.Contains("LucenGrab"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Snow);
			return true;
		}
		if (EOKBKAKDMGH.Contains("/") && !EOKBKAKDMGH.Contains("' no tiene el booleano rotated marcado") && !EOKBKAKDMGH.Contains("ReceiveDroppedItemMessage"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Rain | Weather.WeatherType.Wind);
			return false;
		}
		if (EOKBKAKDMGH.Contains("/kick 2/3/4: "))
		{
			Weather.DAJEJCGGPGO(~(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.SunnyClouds | Weather.WeatherType.PrecipitationCloudy));
			return true;
		}
		if (EOKBKAKDMGH.Contains("target fps"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Rain | Weather.WeatherType.Wind | Weather.WeatherType.Cloudy);
			return true;
		}
		if (EOKBKAKDMGH.Contains("ReceiveHerbs") && !EOKBKAKDMGH.Contains(" / "))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Wind);
			return false;
		}
		if (EOKBKAKDMGH.Contains("time"))
		{
			Weather.ShowWeather(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Sunny | Weather.WeatherType.SunnyClouds | Weather.WeatherType.StormClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("Items/item_name_1193"))
		{
			Weather.PMHBGNKDOMM(Weather.WeatherType.Wind | Weather.WeatherType.Sunny | Weather.WeatherType.SunnyClouds | Weather.WeatherType.StormClouds);
			return false;
		}
		if (EOKBKAKDMGH.Contains("itemBitterHopsSeeds") && !EOKBKAKDMGH.Contains("Idle"))
		{
			Weather.NGAHKOODEBL(Weather.WeatherType.Wind | Weather.WeatherType.Cloudy | Weather.WeatherType.SunnyClouds | Weather.WeatherType.StormClouds);
			return true;
		}
		if (EOKBKAKDMGH.Contains("Coming soon!"))
		{
			Weather.IOOBJHMLLLP(Weather.WeatherType.Snow | Weather.WeatherType.Rain | Weather.WeatherType.Wind);
			return true;
		}
		if (EOKBKAKDMGH.Contains("OnGameLobbyJoinRequested. \nLobby: {0} \nFriend: {1}"))
		{
			Weather.ShowWeather(Weather.WeatherType.Snow);
			return false;
		}
		if (EOKBKAKDMGH.Contains("ReceiveFishInfo"))
		{
			List<Fish> list = ItemDatabaseAccessor.LNBAODAAJLI();
			for (int i = 0; i < list.Count; i += 0)
			{
				if (list[i].displayMethod.HasFlag(Fish.DisplayMethod.None))
				{
					FishingManager.FOHEOELJMPF(list[i], ((Vector2Int)(ref list[i].lenght)).x, CDPAMNIPPEC: false);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("ReceiveFoodInstanceRequest"))
		{
			List<Fish> list2 = ItemDatabaseAccessor.ADCLABHMMAP();
			for (int j = 0; j < list2.Count; j += 0)
			{
				if (list2[j].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
				{
					FishingManager.FBHFGECMPOI(list2[j]);
				}
			}
			return false;
		}
		if (EOKBKAKDMGH.Contains("Xbox"))
		{
			return PDJNOOPABGM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("RecieveEndMaiEvent"))
		{
			return LCOBGLILEIG(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("LE_21"))
		{
			return FJKJNKEPENM(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/5/Dialogue Text"))
		{
			return GAONHALIEAI(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Malt"))
		{
			return INIDNJOJJPD(EOKBKAKDMGH);
		}
		if (EOKBKAKDMGH.Contains("Collider "))
		{
			return LCHBOGAHPCO(EOKBKAKDMGH);
		}
		return true;
		IL_109c:
		return GHPIMLBHMPP();
		IL_0efb:
		return AFKKMBIDEBB();
		IL_0f4d:
		return JEHJCFHEHBL();
		IL_108e:
		return JCHKJAEPBNK();
		IL_0f46:
		return EOOABCEHOKG();
	}

	public bool Cheat(string EOKBKAKDMGH)
	{
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "\n" + inputfield.text + "\n";
		switch (EOKBKAKDMGH)
		{
		case "info":
			return MIOFOMCEKJI();
		case "grow all plants":
			return CDFBICNOECM();
		case "decrease reputation":
			return KADGOIHAGDP();
		case "steam status":
			return JMGBBKPLBJM();
		case "next resolution":
			return DJGIEDHNKFN();
		case "windowed mode":
			return MOLEJPANHAE();
		case "add all resolutions":
			return CNNMDFJPMNK();
		case "check keybinds":
			return GEHNAGGBPEM();
		case "bed":
			return JEMOACOJLPC();
		case "tilled earth":
			return KJAKKKEOEBG();
		case "seeds":
			return ANOOPFGHNCJ();
		case "sprout seeds":
			return KJDDNEIMAAB();
		case "talents":
			return ILADCDMFPON();
		case "farmer":
			return HLKHPHFKOBH();
		case "sleep":
			return HNDHIPIILJB();
		case "on player sleep":
			return OnPlayerSleep("");
		case "tavern":
			return ADNFEBOAGAD();
		case "rooms":
			return MPHMCCKAAMB();
		case "road":
			return OLBMOPFDOIH();
		case "river":
			return AAIPJMFLDEJ();
		case "quarry":
			return KNHGAFKNOLC();
		case "camp":
			return HMINCAELJNO();
		case "castlegarden":
			return OCEMEODOKLH();
		case "forest":
			return GAFKLBJCBFI();
		case "port":
			return CEAOEFMLJKK();
		case "mine":
			return CCABKLMNLHO();
		case "kujaku":
			return NPAFILPDOAL();
		case "piratecave":
		case "pirate cave":
		case "piratescave":
		case "pirates cave":
			return AFKKMBIDEBB();
		case "pirate":
			return BKJGKACHINN();
		case "bathhouse":
			return JHHPAOPNNPG();
		case "bathhouseinterior":
			return AIAGEJIAGPF();
		case "zuzzu":
			return AIAGEJIAGPF();
		case "bob":
			return BDCPHJICALJ();
		case "generate forest":
			return MINIPFHJCIP();
		case "place bomb":
			MineManager.GGFJGHHHEJC.PlaceCharges();
			return true;
		case "place charges":
			MineManager.GGFJGHHHEJC.PlaceCharges();
			return true;
		case "banquetevent":
		case "start banquet":
			return EOOABCEHOKG();
		case "start ninja":
		case "ninjachallenge":
			return CHAFFHCGMNJ();
		case "nextround":
			return GCDEDCGBMEE();
		case "skip":
			return ABBLKDMCNEI();
		case "debug service":
			return ALDODOHNLIF();
		case "dirty info":
			return POAEGGMIAGP();
		case "vip":
			return PGDGLIHMBMK();
		case "fog":
			return GGFDGGHCPND();
		case "tavern travelling":
			return MHLGKEBGCLB();
		case "farm travelling":
			return PNNEFEALMMC();
		case "quarry travelling":
			return NOODKHHGKPI();
		case "petshop travelling":
			return JEHAECAPNNC();
		case "beach travelling":
			return PPAMAJMMLLM(beachTravellingStart, beachTravellingEnd);
		case "castle travelling":
			return PPAMAJMMLLM(castleTravellingStart, castleTravellingEnd);
		case "castle interior travelling":
			return PPAMAJMMLLM(castleInteriorTravellingStart, castleInteriorTravellingEnd);
		case "city travelling":
			return PPAMAJMMLLM(cityTravellingStart, cityTravellingEnd);
		case "bath travelling":
			return PPAMAJMMLLM(bathTravellingStart, bathTravellingEnd);
		case "travelling time +":
			return OLDHMDMHDOD();
		case "travelling time -":
			return FJAFBGFINNH();
		case "farm":
			return FMOALABPHNF();
		case "farminterior":
			return FNNNOKGMHHM();
		case "connect":
			return FCCJDHKEFBM();
		case "disconnect":
			return OAIKONKMDGK();
		case "caveinn":
			return DGJEBGHMGHB();
		case "fishing":
			return BLMHPKBIDFI();
		case "beach":
			return KDJKLGEHJAC();
		case "wilson":
			return LOEKLEACHCF();
		case "showui":
			return FFNMMACFBKP(MJHBHDAEDLF: true);
		case "hideui":
			return FFNMMACFBKP(MJHBHDAEDLF: false);
		case "city":
			return CCLNLPDBJKC();
		case "blacksmith":
			return KHDAGHPKDGK();
		case "sawmill":
			return KFIPNONCLBK();
		case "citytavern":
			return JFNILOGIOIH();
		case "christmas":
			return INKOAKJDEMG();
		case "vampirehouse":
			return NMDHHEAKPPA();
		case "petshop":
			return NIFGPIOKMCC();
		case "intro":
			return NANGPPPHAEA();
		case "tutorial":
			return GFKGKOBEAGD();
		case "force intro":
		case "forceintro":
			return JCHKJAEPBNK();
		case "castle":
			return LBBNAJJGGJI();
		case "endconversation":
		case "endconversations":
		case "end conversation":
		case "end conversations":
		case "enddialogue":
		case "end dialogue":
			return GHPIMLBHMPP();
		case "start pirates":
			return StartPirates();
		case "start fish":
			return StartFish();
		case "start bath":
			return StartBathhouse();
		case "replay pirates":
			return ReplayPirates();
		case "replay fish":
			return ReplayFish();
		case "replay bath":
			return ReplayBathhouse();
		case "replay ninja":
			return NKEFONDMLPH();
		case "replay banquet":
			return AJDCAIMMGHJ();
		case "challenges":
			return LFONIBMMHOB();
		case "sprint":
			return PKJOGBPCDFP();
		default:
			if (EOKBKAKDMGH.Contains("increase money"))
			{
				return NNBDLCLPKEE(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("recipe fragments"))
			{
				return MHIBNKHCDLI(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("increase reputation"))
			{
				return FAOINCNMKPL(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("world time"))
			{
				return IBEAIGOCMAB(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("time"))
			{
				return JEAHJILAIAP(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("ops"))
			{
				return OnPlayerSleep(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("change season"))
			{
				return IFMLPAIAMDI(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("increase xp"))
			{
				return JABEGCPGOPB(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("night"))
			{
				return CMEEFLDCGHO(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("hour"))
			{
				return CFBHCOJJIPK(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("day"))
			{
				return IIDFGNLMGDG(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("new save"))
			{
				return LPCKAOCMOHJ(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("save"))
			{
				return HJHBPPAOGKN(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("activate event"))
			{
				return NDHJHDIKEKK(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("add item"))
			{
				return INBCACPBEKL(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("dog"))
			{
				return HKIFELEDFFD(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("ids"))
			{
				ItemInstance.showIdsNum = !ItemInstance.showIdsNum;
			}
			if (EOKBKAKDMGH.Contains("create random quests"))
			{
				RandomOrderQuestsManager.GGFJGHHHEJC.GenerateAvailableOrders();
				return true;
			}
			if (EOKBKAKDMGH.Contains("complete quest"))
			{
				return JGNBGECEINP(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("add quest"))
			{
				return BAALKNEHBBM(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("unlock recipe"))
			{
				return FLJFPPDNBMO(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("unlock all recipes"))
			{
				return CDHMKFJEKJG(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("show popup"))
			{
				return IDMECGKHGMK(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("bomb materials"))
			{
				return JIFOEPHOGEO();
			}
			if (EOKBKAKDMGH.Contains("materials"))
			{
				return HOFMPKCPJBH();
			}
			if (EOKBKAKDMGH.Contains("new tools"))
			{
				return HCKNEEPJNCB();
			}
			if (EOKBKAKDMGH.Contains("add materials"))
			{
				return AddMaterials(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("input info"))
			{
				return FEAFKEGLBIB(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("halloween event"))
			{
				Utils.disableHalloweenEvent = !Utils.disableHalloweenEvent;
				return true;
			}
			if (EOKBKAKDMGH.Contains("mine level"))
			{
				return EDEKHLKKODG(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("increase workers level"))
			{
				return IncreaseWorkersLevel(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("controllers"))
			{
				PlayerInputs.GetPlayer(1).debugControllers = !PlayerInputs.GetPlayer(1).debugControllers;
				return true;
			}
			if (EOKBKAKDMGH.Contains("snow"))
			{
				Weather.ShowWeather(Weather.WeatherType.Snow);
				return true;
			}
			if (EOKBKAKDMGH.Contains("rain") && !EOKBKAKDMGH.Contains("cloudy") && !EOKBKAKDMGH.Contains("stormy"))
			{
				Weather.ShowWeather(Weather.WeatherType.Rain);
				return true;
			}
			if (EOKBKAKDMGH.Contains("rain cloudy"))
			{
				Weather.ShowWeather(Weather.WeatherType.PrecipitationCloudy);
				return true;
			}
			if (EOKBKAKDMGH.Contains("rain stormy"))
			{
				Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
				return true;
			}
			if (EOKBKAKDMGH.Contains("sunny") && !EOKBKAKDMGH.Contains("clouds"))
			{
				Weather.ShowWeather(Weather.WeatherType.Sunny);
				return true;
			}
			if (EOKBKAKDMGH.Contains("sunny clouds"))
			{
				Weather.ShowWeather(Weather.WeatherType.SunnyClouds);
				return true;
			}
			if (EOKBKAKDMGH.Contains("stormy clouds"))
			{
				Weather.ShowWeather(Weather.WeatherType.StormClouds);
				return true;
			}
			if (EOKBKAKDMGH.Contains("cloudy") && !EOKBKAKDMGH.Contains("rain"))
			{
				Weather.ShowWeather(Weather.WeatherType.StormClouds);
				return true;
			}
			if (EOKBKAKDMGH.Contains("windy"))
			{
				Weather.ShowWeather(Weather.WeatherType.Wind);
				return true;
			}
			if (EOKBKAKDMGH.Contains("stop weather"))
			{
				Weather.ShowWeather(Weather.WeatherType.None);
				return true;
			}
			if (EOKBKAKDMGH.Contains("fill fish collection"))
			{
				List<Fish> fishList = ItemDatabaseAccessor.GetFishList();
				for (int i = 0; i < fishList.Count; i++)
				{
					if (fishList[i].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
					{
						FishingManager.AddToRecordList(fishList[i], ((Vector2Int)(ref fishList[i].lenght)).x);
					}
				}
				return true;
			}
			if (EOKBKAKDMGH.Contains("fish collection clues"))
			{
				List<Fish> fishList2 = ItemDatabaseAccessor.GetFishList();
				for (int j = 0; j < fishList2.Count; j++)
				{
					if (fishList2[j].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
					{
						FishingManager.AddFishInformation(fishList2[j]);
					}
				}
				return true;
			}
			if (EOKBKAKDMGH.Contains("target fps"))
			{
				return LAAIHNGHMJL(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("tutorial phase"))
			{
				return ALJIOAGGDIC(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("onlinecode"))
			{
				return FJKJNKEPENM(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("add letter"))
			{
				return GAONHALIEAI(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("chat"))
			{
				return INIDNJOJJPD(EOKBKAKDMGH);
			}
			if (EOKBKAKDMGH.Contains("stuck recovery"))
			{
				return FMNEPHOJEFI(EOKBKAKDMGH);
			}
			return false;
		}
	}

	private bool JEMOACOJLPC()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Component)PlayerController.GetPlayer(1)).transform.position = Bed.GetPlayerBedPosition();
		return true;
	}

	private bool ABBLKDMCNEI()
	{
		EventRoundsManager.SkipChallenge();
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "BanquetEvent not activated";
		return true;
	}

	public void EnterCode()
	{
		if (opened)
		{
			if (FPFKFDKKLNG())
			{
				TextMeshProUGUI obj = consoleText;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "\n";
			}
			else
			{
				TextMeshProUGUI obj2 = consoleText;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "\nCode not found\n";
			}
			inputfield.text = "";
			((MonoBehaviour)this).StartCoroutine(PBFKNNOAMDI());
			((MonoBehaviour)this).StartCoroutine(AHLMLBCBHBP(((Component)inputfield).gameObject));
		}
	}

	private bool OAGCHNDPOLO()
	{
		TravelZonesManager.OACNNJCLEDE().ECFDFECLDFK(Location.River | Location.BarnInterior | Location.FarmShop, ~(Location.Road | Location.River | Location.Camp | Location.FarmShop)).StartTravelZone(1);
		return false;
	}

	private bool JIFOEPHOGEO()
	{
		INBCACPBEKL("add item " + 1041 + " " + 199);
		INBCACPBEKL("add item " + 1042 + " " + 199);
		INBCACPBEKL("add item " + 1055 + " " + 199);
		INBCACPBEKL("add item " + 1898 + " " + 199);
		INBCACPBEKL("add item " + 1889 + " " + 199);
		return true;
	}

	private bool PMKNKFIKCPG(string EOKBKAKDMGH)
	{
		EOKBKAKDMGH = Regex.Replace(EOKBKAKDMGH, "HotBath/Bark", "IdleCamp");
		int result = 174;
		if (int.TryParse(EOKBKAKDMGH, out result))
		{
			WorldTime.SetMultiplierDevConsole(result);
			TextMeshProUGUI obj = consoleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Struggle" + result;
			return false;
		}
		TextMeshProUGUI obj2 = consoleText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Items/item_name_1181";
		return false;
	}

	private bool GNILDAFLNBC()
	{
		TravelZonesManager.DGCNCEDIFOF().NKEBECDKDOO(Location.Road | Location.River | Location.BarnInterior, Location.Road | Location.River | Location.Farm | Location.BarnInterior).KACGDPCMGPL(0);
		return false;
	}

	private bool KNLBNFACLJK(string EOKBKAKDMGH)
	{
		GameDate aODONKKHPBP = WorldTime.HGIBNMBJMOC();
		aODONKKHPBP.hour = -103;
		WorldTime.LKEPKFBGKOH(aODONKKHPBP);
		WorldTime.CalcCurrentDayTimeSec();
		WorldTime.OnDevConsoleHourChanged?.Invoke();
		return true;
	}

	private bool BDCPHJICALJ()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.TeleportPlayer(1, ((Component)BobNPC.GGFJGHHHEJC).transform.position, Location.Farm);
		return true;
	}

	private bool CPFBOGBPPMN()
	{
		GeneratorsManager.instance.DestroyAllForestElements();
		KJAKKKEOEBG();
		ANOOPFGHNCJ();
		ILADCDMFPON();
		TalentUI.JOAAFGBPJOC(0).EDHEIFHAAKO();
		TalentUI.KDLDGFBDDCN(0).CloseUI();
		return false;
	}

	public bool StartBathhouse()
	{
		if (OnlineMinigameManager.GetMinigameState() == OnlineMinigameManager.PlayerState.Default)
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InTransition);
		}
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA != Location.BathhouseInterior)
		{
			((MonoBehaviour)this).StartCoroutine(IGNCIGCFIJP());
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsClient())
			{
				OnlineMinigameManager.RequestBeginBathhouseMinigame();
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(KNLFADCAEIN());
			}
		}
		else
		{
			BathhouseGameManager.Begin();
		}
		return true;
	}

	private IEnumerator KOEJDGOAFKJ()
	{
		return new BDPOMPHAIPG(1);
	}

	private bool KFIPNONCLBK()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.Sawmill).StartTravelZone(1);
		return true;
	}

	private bool GEHNAGGBPEM()
	{
		foreach (KeyValuePair<string, int> item in KeybindUI.GGFJGHHHEJC.keybindsSave.keybindSave)
		{
			TextMeshProUGUI val = consoleText;
			((TMP_Text)val).text = ((TMP_Text)val).text + "Key: " + item.Key + ", Value: " + item.Value + "\n";
		}
		TextMeshProUGUI obj = consoleText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "End of Dictionary.";
		return true;
	}

	private bool AJDCAIMMGHJ()
	{
		BanquetEvent.BeginReplay();
		return true;
	}

	private bool ADGONONOOLP()
	{
		INBCACPBEKL("windy" + 25 + "Dialogue System/Conversation/TooCold/Entry/2/Dialogue Text" + -80);
		BDIPKPLEGKM("Water Bowl" + 191 + "SalonDelTrono/RibellaTalk" + 87);
		INBCACPBEKL("Get Components " + 138 + "Month" + -128);
		INBCACPBEKL("Inventory full" + 41 + "SpriteRenderer not attached on " + 102);
		FFHEJCPLMCD("" + -191 + "Unique id " + -72);
		EJODODEHNII("Dialogue System/Conversation/NeutralInTavern/Entry/7/Dialogue Text" + 22 + "ReceiveFireplaceMessage" + -122);
		EJODODEHNII("Items/item_name_1065" + 12 + "ERROR: The object " + 83);
		INBCACPBEKL("Game" + -83 + "cheeseRepUnlockedPopUp" + 123);
		return false;
	}

	private bool LOEKLEACHCF()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Beach, Location.WilsonHouse).StartTravelZone(1);
		return true;
	}
}
