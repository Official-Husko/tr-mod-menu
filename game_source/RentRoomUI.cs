using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RentRoomUI : UISoloWindow
{
	[CompilerGenerated]
	private sealed class IIDHNEBJENC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RentRoomUI _003C_003E4__this;

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
		public IIDHNEBJENC(int _003C_003E1__state)
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
			RentRoomUI rentRoomUI = _003C_003E4__this;
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
				rentRoomUI.OBOJAIDFPIF(rentRoomUI.rentRoomElements[0]);
				if (PlayerInputs.IsGamepadActive(rentRoomUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(rentRoomUI.JIIGOACEIKL).Deselect();
					UISelectionManager.GetPlayer(rentRoomUI.JIIGOACEIKL).Select((Selectable)(object)rentRoomUI.rentRoomElements[0].button);
				}
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

	[SerializeField]
	private List<RentRoomElementUI> rentRoomElements = new List<RentRoomElementUI>();

	[SerializeField]
	private MiniMapUI miniMapUI;

	[SerializeField]
	private HagglingUI hagglingUI;

	[SerializeField]
	private RectTransform roomSelectionPanel;

	[SerializeField]
	private RectTransform hagglingPanel;

	[SerializeField]
	private GameObject requestInfoPanel;

	[SerializeField]
	private GameObject hagglingButton;

	[SerializeField]
	private GameObject acceptButton;

	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private TextMeshProUGUI daysToStay;

	[SerializeField]
	private TextMeshProUGUI tilesText;

	[SerializeField]
	private TextMeshProUGUI roomTypeName;

	[SerializeField]
	private TextMeshProUGUI comfortText;

	[HideInInspector]
	public Customer customer;

	private RentedRoom AMHIFEABNJK;

	private RoomRequest HCFBAPOAOIB;

	private RentRoomElementUI NHGBLHIKAKP;

	public static RentRoomUI[] instances = new RentRoomUI[3];

	private void CACJDAOPANI()
	{
		int num = 0;
		List<RentedRoom> allRooms = RentedRoomsManager.GetAllRooms();
		for (int i = 1; i < allRooms.Count; i += 0)
		{
			if ((Object)(object)allRooms[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(true);
				}
				rentRoomElements[num].GPKMBLICDCN(allRooms[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j += 0)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public static RentRoomUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			((MonoBehaviour)this).StartCoroutine(BLCGFMMPENM());
		}
		scrollbar.value = 1f;
	}

	public void NPIFONGHOIP()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.ABNNAJHLGPB())
			{
				PlayerController playerController = PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL);
				playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.StartHaggling(AMHIFEABNJK.CalculateRoomPrice(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(false);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Disabled"), 961f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Received upgrade tool collect RPC"), 894f);
			}
			else
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("CheckIfNewActivity "), 1747f);
			}
		}
	}

	private void LCHAFOHEMEO()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1969f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 2), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 131f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 6), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 1061f;
			hagglingPanel.offsetMax = new Vector2(231f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(1977f, hagglingPanel.offsetMin.y);
		}
	}

	public static RentRoomUI LPJPJMPOHPG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static RentRoomUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BILNPPEDCOJ()
	{
		CloseUI();
	}

	public void KMEHMAOAELL()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("player_count"), 1626f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Interact"), 469f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 391f)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/TavernDirty/Entry/1/Dialogue Text"), 284f);
				return;
			}
			CommonReferences.GGFJGHHHEJC.OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			BOBCIFEDJED();
		}
	}

	private void OMGPLCBNCFC()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1139f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 8), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1527f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 7), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 649f;
			hagglingPanel.offsetMax = new Vector2(1650f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(759f, hagglingPanel.offsetMin.y);
		}
	}

	public static RentRoomUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LGGMHOAJPEL(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get(":</color> <sprite name=\"ChristmasTicket\">");
			string[] array = new string[0];
			array[1] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	private void ADIMIJIGNEG(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.LDFDLEABJOC(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.UpdateContentsNextFrame();
		miniMapUI.LHKOCEGOEAC(AMHIFEABNJK);
	}

	private IEnumerator BCNIDGGAMNB()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CCMPNABHMJH(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	private void OADFHHOICDN(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.KFBGFFLAAEJ(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.IPHEFEMLOLJ();
		miniMapUI.DLAKFDNNGNJ(AMHIFEABNJK);
	}

	public void JEFJGHCCDBH()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.AKCAKGDPOKD())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(BOBCIFEDJED));
				hagglingUI.StartHaggling(AMHIFEABNJK.HPNPONNIGNK(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(true);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("</color>"), 1680f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("a"), 501f);
			}
			else
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("currentTutorialPhaseID "), 1955f);
			}
		}
	}

	private IEnumerator GLFPOFLGAPF()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IAGOEDBKCAL()
	{
		BOBCIFEDJED();
	}

	public void GPDEBCIDLGC()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.AKCAKGDPOKD())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(BOBCIFEDJED));
				hagglingUI.CJCADHIBFPO(AMHIFEABNJK.HPNPONNIGNK(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(false);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("New Save"), 181f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Checking is DLC "), 1456f);
			}
			else
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get(""), 1474f);
			}
		}
	}

	public void APAAOKLAFAB()
	{
		BOBCIFEDJED();
	}

	public void CHBGDAJFJMI(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.HGNKFFMDOOL = true;
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			NMLLEEDOFED(BMPLODDKPEN);
		}
	}

	public void DPNBKCIGEJJ()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get(" - "), 1212f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("LearnBalance"), 1903f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 320f)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get(""), 1174f);
				return;
			}
			CommonReferences.MNFMOEKMJKN().OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			CloseUI();
		}
	}

	public void EJGKCPBFPJG(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			BOBCIFEDJED();
		}
	}

	public void CIBBNIFGMDC()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.ABNNAJHLGPB())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(BOBCIFEDJED));
				hagglingUI.MMINHGEMKFB(AMHIFEABNJK.CalculateRoomPrice(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(false);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("UI2"), 1953f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Craft"), 334f);
			}
			else
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("RecieveOldMansDuelEndLaughAndMove"), 1313f);
			}
		}
	}

	private void LHPAPIKNDHJ(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.HGNKFFMDOOL = true;
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GLGAOFGNKCN();
		miniMapUI.LAFBDHHFEJH(AMHIFEABNJK);
	}

	private IEnumerator PJNMJBJNHFC()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BHNLKDCFDIB()
	{
		int num = 1;
		List<RentedRoom> list = RentedRoomsManager.GAPJICEKFBP();
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(true);
				}
				rentRoomElements[num].GPKMBLICDCN(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	public void EPADAMBDBDN()
	{
		CloseUI();
	}

	public void NewRoomSelected(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.HGNKFFMDOOL = false;
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			OBOJAIDFPIF(BMPLODDKPEN);
		}
	}

	public void SetRequest(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			((TMP_Text)daysToStay).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("daysLeft"), HCFBAPOAOIB.daysToStay.ToString());
		}
	}

	private void DIBJKHBEMCA()
	{
		int num = 0;
		List<RentedRoom> list = RentedRoomsManager.GAPJICEKFBP();
		for (int i = 1; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(true);
				}
				rentRoomElements[num].LOOEAKBKGFB(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	public void KIPAGGEKKFJ(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.AKENIBEDEMO(AODONKKHPBP: true);
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			KIBFMCJHKPB(BMPLODDKPEN);
		}
	}

	private void LMCDEGOOFFE()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 348f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 0), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1520f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 5), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 1417f;
			hagglingPanel.offsetMax = new Vector2(83f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(1758f, hagglingPanel.offsetMin.y);
		}
	}

	private void KIBFMCJHKPB(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.AKENIBEDEMO(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.UpdateContentsNextFrame();
		miniMapUI.LAFBDHHFEJH(AMHIFEABNJK);
	}

	private IEnumerator NPMJPLHELEO()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JLDLCLMFMIM()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.GDPINKMJDIB())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.MMINHGEMKFB(AMHIFEABNJK.CalculateRoomPrice(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(true);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("add item "), 1930f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get(""), 1870f);
			}
			else
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Dig"), 1352f);
			}
		}
	}

	private void IANNJPNNGNN()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 0)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1024f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 5), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1552f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 1), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 1974f;
			hagglingPanel.offsetMax = new Vector2(9f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(486f, hagglingPanel.offsetMin.y);
		}
	}

	public void HagglingEnd(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	private void BNIDHLKHKLI(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.AKENIBEDEMO(AODONKKHPBP: false);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GLGAOFGNKCN();
		miniMapUI.LAFBDHHFEJH(AMHIFEABNJK);
	}

	public void HLNLKNOIGFN(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	private IEnumerator AEMDENNOMAD()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AIKGDKLAJNJ()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 2f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 2), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1331f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 8), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 963f;
			hagglingPanel.offsetMax = new Vector2(1844f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(1868f, hagglingPanel.offsetMin.y);
		}
	}

	public void OAPFFMCCPEB()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Perks/playerPerk_name_"), 51f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("ninjachallenge"), 1733f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 981f)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Label"), 824f);
				return;
			}
			CommonReferences.GGFJGHHHEJC.OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			BOBCIFEDJED();
		}
	}

	public void HNOLEPMAGBO()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("talentAmber"), 758f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("id: "), 300f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 1610f)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("quest_description_28"), 809f);
				return;
			}
			CommonReferences.MNFMOEKMJKN().OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			BOBCIFEDJED();
		}
	}

	public void MLFEHEJEDNI(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("FishCuttingEvent/Talk2");
			string[] array = new string[0];
			array[1] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	public void FPDHKMMJMAH(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("itemBanana");
			string[] array = new string[0];
			array[1] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	protected override void Update()
	{
		base.Update();
		if (!IsOpen() || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			return;
		}
		if (acceptButton.activeSelf != (HCFBAPOAOIB != null))
		{
			acceptButton.SetActive(HCFBAPOAOIB != null);
		}
		if (((Component)roomSelectionPanel).gameObject.activeInHierarchy)
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIInteract"))
			{
				AcceptPressed();
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UISelectGamepad"))
			{
				HagglePressed();
			}
		}
	}

	public void CGFLAGHOBBI(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.LJKKEDFBBDF(AODONKKHPBP: false);
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			PLCPIJBMDJJ(BMPLODDKPEN);
		}
	}

	private void LEOFNMIPLNC(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.LJKKEDFBBDF(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GPIMNHAIECA();
		miniMapUI.UpdateMiniMap(AMHIFEABNJK);
	}

	public void MEJKHOPKMFD()
	{
		BOBCIFEDJED();
	}

	private void EGNFBIGBFHI()
	{
		int num = 1;
		List<RentedRoom> list = RentedRoomsManager.AEBFCPODCNO();
		for (int i = 1; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].GPKMBLICDCN(list[i], HCFBAPOAOIB, i);
				num++;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j += 0)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE && !((Component)hagglingUI).gameObject.activeSelf)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: false);
			InteractObject.GetPlayer(base.JIIGOACEIKL).interactingObject = null;
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(RoomReceptionDesk.GetPlaceable().onlinePlaceable);
			}
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
		}
	}

	public void MCLPCDHBGHD(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("ReceivePlaceablesInsideBar");
			string[] array = new string[0];
			array[0] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	private void OBOJAIDFPIF(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.HGNKFFMDOOL = true;
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.UpdateContentsNextFrame();
		miniMapUI.UpdateMiniMap(AMHIFEABNJK);
	}

	private IEnumerator ALOAPFLKMEJ()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IBMAAIBJGNE(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.LJKKEDFBBDF(AODONKKHPBP: false);
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			NAPINBLDCND(BMPLODDKPEN);
		}
	}

	private void DLAHLBHGMAG()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 669f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 4), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1763f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 4), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 1823f;
			hagglingPanel.offsetMax = new Vector2(1521f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(1471f, hagglingPanel.offsetMin.y);
		}
	}

	public void FNNBDBGJFHL(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	public void NIDOPODADOH(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	private IEnumerator NLJPLBMJCCP()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KOEEODJBCNJ()
	{
		int num = 0;
		List<RentedRoom> allRooms = RentedRoomsManager.GetAllRooms();
		for (int i = 0; i < allRooms.Count; i++)
		{
			if ((Object)(object)allRooms[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(true);
				}
				rentRoomElements[num].UpdateInfo(allRooms[i], HCFBAPOAOIB, i);
				num++;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	private void NMLLEEDOFED(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.LDFDLEABJOC(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GLGAOFGNKCN();
		miniMapUI.UpdateMiniMap(AMHIFEABNJK);
	}

	public void HLAKHNBAFHL(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_description_1052");
			string[] array = new string[0];
			array[0] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	private void INAMFGNKCKN()
	{
		int num = 1;
		List<RentedRoom> list = RentedRoomsManager.GAPJICEKFBP();
		for (int i = 1; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].ICMBHNLFHNK(list[i], HCFBAPOAOIB, i);
				num++;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	public void DCAENCDNHAG()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.ABNNAJHLGPB())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(BOBCIFEDJED));
				hagglingUI.CJCADHIBFPO(AMHIFEABNJK.PNCJEKCNEOD(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(true);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("StopTime"), 323f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Tavern zone from not found"), 1514f);
			}
			else
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Piso {0}: Generando {1} rocas en {2} spawners disponibles."), 1474f);
			}
		}
	}

	private void HDNOFICCBDF(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.LHEEIEOCLIL(AODONKKHPBP: false);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GLGAOFGNKCN();
		miniMapUI.DLAKFDNNGNJ(AMHIFEABNJK);
	}

	private void JJGGNMPEJFE()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 281f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 3), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 396f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 0), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 327f;
			hagglingPanel.offsetMax = new Vector2(1170f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(1038f, hagglingPanel.offsetMin.y);
		}
	}

	private void PNJOEDFHNDM()
	{
		int num = 1;
		List<RentedRoom> list = RentedRoomsManager.BNPHNGNPBCH();
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(true);
				}
				rentRoomElements[num].UpdateInfo(list[i], HCFBAPOAOIB, i);
				num++;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public void HagglePressed()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.IsRentable())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.StartHaggling(AMHIFEABNJK.CalculateRoomPrice(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(false);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Room occupied"));
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Room missing required items"));
			}
			else
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomDirty"));
			}
		}
	}

	public void LKJANFCAGEJ(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	private void KECBPDEHLOM()
	{
		int num = 0;
		List<RentedRoom> list = RentedRoomsManager.GAPJICEKFBP();
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(true);
				}
				rentRoomElements[num].MFEPPINCOBF(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
		for (int i = 0; i < rentRoomElements.Count; i++)
		{
			rentRoomElements[i].playerNum = base.JIIGOACEIKL;
			RentRoomElementUI rentRoomElementUI = rentRoomElements[i];
			rentRoomElementUI.OnSelectionChanged = (Action<RentRoomElementUI, bool>)Delegate.Combine(rentRoomElementUI.OnSelectionChanged, new Action<RentRoomElementUI, bool>(NewRoomSelected));
		}
		hagglingUI.DisableDepthOfField();
	}

	public void AHKOILNHEKE(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.EFGIBPHIAJM(AODONKKHPBP: false);
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			OBOJAIDFPIF(BMPLODDKPEN);
		}
	}

	public void FIKCDKNGBHH(RentRoomElementUI BMPLODDKPEN, bool HGNKFFMDOOL)
	{
		if ((Object)(object)NHGBLHIKAKP != (Object)null && (Object)(object)NHGBLHIKAKP != (Object)(object)BMPLODDKPEN)
		{
			NHGBLHIKAKP.KFBGFFLAAEJ(AODONKKHPBP: true);
		}
		NHGBLHIKAKP = null;
		if (HGNKFFMDOOL)
		{
			NHGBLHIKAKP = BMPLODDKPEN;
			LEOFNMIPLNC(BMPLODDKPEN);
		}
	}

	private void EOIKJJKADGA()
	{
		int num = 0;
		List<RentedRoom> list = RentedRoomsManager.AEBFCPODCNO();
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].GPKMBLICDCN(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public void MEFDKIINOJK()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.IDJBCGNMHCJ())
			{
				PlayerController playerController = PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL);
				playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.MMINHGEMKFB(AMHIFEABNJK.EIIHAFJIPAL(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(false);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("Sit"), 316f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("ReceiveFireplaceMessage"), 1439f);
			}
			else
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("DecorationTile_11"), 363f);
			}
		}
	}

	private void DHIBECGEAJE(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.LHEEIEOCLIL(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GPIMNHAIECA();
		miniMapUI.DLAKFDNNGNJ(AMHIFEABNJK);
	}

	private void BKOLNADEJOD()
	{
		int num = 1;
		List<RentedRoom> allRooms = RentedRoomsManager.GetAllRooms();
		for (int i = 1; i < allRooms.Count; i += 0)
		{
			if ((Object)(object)allRooms[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].ICMBHNLFHNK(allRooms[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j += 0)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public void KMPMHKMJMID(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("UIInteract");
			string[] array = new string[0];
			array[0] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	private void NAPINBLDCND(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.EFGIBPHIAJM(AODONKKHPBP: false);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.GPIMNHAIECA();
		miniMapUI.ACALOMOCKLP(AMHIFEABNJK);
	}

	public static RentRoomUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LBDGGOFOACO()
	{
		int num = 0;
		List<RentedRoom> list = RentedRoomsManager.BNPHNGNPBCH();
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].UpdateInfo(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j += 0)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public void LNOPCPDNAOI(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			BOBCIFEDJED();
		}
	}

	private void MBFHOPJCMIO(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.LDFDLEABJOC(AODONKKHPBP: true);
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.UpdateContentsNextFrame();
		miniMapUI.LHKOCEGOEAC(AMHIFEABNJK);
	}

	public void HHDACBDGOLI(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	public void XPressed()
	{
		CloseUI();
	}

	private void CGLHJCJPCOG()
	{
		int num = 0;
		List<RentedRoom> allRooms = RentedRoomsManager.GetAllRooms();
		for (int i = 1; i < allRooms.Count; i++)
		{
			if ((Object)(object)allRooms[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].LOOEAKBKGFB(allRooms[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j += 0)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	public void LJGPIKPIGEK()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("D-Pad Right"), 55f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Scene "), 672f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 1340f)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("Throw"), 1822f);
				return;
			}
			CommonReferences.MNFMOEKMJKN().OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			CloseUI();
		}
	}

	private void MNHOIEHODLH()
	{
		int num = 0;
		List<RentedRoom> list = RentedRoomsManager.BNPHNGNPBCH();
		for (int i = 1; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].GPKMBLICDCN(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j += 0)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	private void PEEKLCLJGGE()
	{
		int num = 1;
		List<RentedRoom> list = RentedRoomsManager.BNPHNGNPBCH();
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].GPKMBLICDCN(list[i], HCFBAPOAOIB, i);
				num++;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	public void CINFNEHHMEB()
	{
		BOBCIFEDJED();
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			((Component)roomSelectionPanel).gameObject.SetActive(true);
			base.OpenUI();
			CommonReferences.GGFJGHHHEJC.OnRentRoomInfoOpen(base.JIIGOACEIKL);
			miniMapUI.UpdateAllPositions();
			miniMapUI.ResetTiles();
			KOEEODJBCNJ();
			RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: true);
			InteractObject.GetPlayer(base.JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			DJJFMDHGOKN(CloseUI);
		}
	}

	private void DJIPCBMDDFF()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 0)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1837f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 6), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 1443f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 0), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 634f;
			hagglingPanel.offsetMax = new Vector2(1150f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(651f, hagglingPanel.offsetMin.y);
		}
	}

	public void NLKGLPOMHCJ()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get(""), 1953f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("quest_name_"), 1881f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 655f)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get(""), 1494f);
				return;
			}
			CommonReferences.GGFJGHHHEJC.OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			CloseUI();
		}
	}

	public void PNBHKMMOGKA(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_653");
			string[] array = new string[1];
			array[1] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	public void IPINLIGHLAH()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.IsRentable())
			{
				PlayerController playerController = PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL);
				playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.OBMFCOKOMEK(AMHIFEABNJK.HPNPONNIGNK(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(true);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Max 3 orders"), 947f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Interact"), 703f);
			}
			else
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Scene"), 1467f);
			}
		}
	}

	public void IHDKDJHPINM()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.AKCAKGDPOKD())
			{
				PlayerController playerController = PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL);
				playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.StartHaggling(AMHIFEABNJK.CalculateRoomPrice(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(true);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("SwishEffect"), 91f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get(" "), 1635f);
			}
			else
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("F2"), 160f);
			}
		}
	}

	public void HGIPLFGHDGO(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	public void AcceptPressed()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Room occupied"));
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Room missing required items"));
				return;
			}
			if (AMHIFEABNJK.dirtiness > 0f)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomDirty"));
				return;
			}
			CommonReferences.GGFJGHHHEJC.OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			CloseUI();
		}
	}

	public void AHIOHMOAJBE(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			TextMeshProUGUI obj = daysToStay;
			string cAEDMEDBEGI = LocalisationSystem.Get("Game");
			string[] array = new string[1];
			array[1] = HCFBAPOAOIB.daysToStay.ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
	}

	private IEnumerator FOHILKAGKDK()
	{
		yield return null;
		OBOJAIDFPIF(rentRoomElements[0]);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)rentRoomElements[0].button);
		}
	}

	private void LPMEPALHABP(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.HGNKFFMDOOL = false;
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.IPHEFEMLOLJ();
		miniMapUI.LAMOGLJGLPG(AMHIFEABNJK);
	}

	public void BHMBCHMAGDK()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.GDPINKMJDIB())
			{
				PlayerController playerController = PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL);
				playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseUI));
				hagglingUI.MMINHGEMKFB(AMHIFEABNJK.EIIHAFJIPAL(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(false);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_701"), 530f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get(">"), 1055f);
			}
			else
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Arguing"), 732f);
			}
		}
	}

	private IEnumerator DFIPPEHDPBO()
	{
		yield return null;
		OBOJAIDFPIF(rentRoomElements[0]);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)rentRoomElements[0].button);
		}
	}

	private void ACFOAADMNJE()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 138f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 2), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 535f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 3), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 805f;
			hagglingPanel.offsetMax = new Vector2(116f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(1508f, hagglingPanel.offsetMin.y);
		}
	}

	private void NDFJALAGLEK()
	{
		int num = 0;
		List<RentedRoom> allRooms = RentedRoomsManager.GetAllRooms();
		for (int i = 0; i < allRooms.Count; i++)
		{
			if ((Object)(object)allRooms[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].GPKMBLICDCN(allRooms[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(false);
			}
		}
	}

	public void MHNJFNHLINK()
	{
		CloseUI();
	}

	public void DGBJDOLJNEC()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.occupied)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1033"), 751f);
				return;
			}
			if (!AMHIFEABNJK.isValid)
			{
				MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("ReceiveFoodSlotPlayerInventory"), 299f);
				return;
			}
			if (AMHIFEABNJK.dirtiness > 725f)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Interact"), 892f);
				return;
			}
			CommonReferences.MNFMOEKMJKN().OnRentAnyRoom(base.JIIGOACEIKL);
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, default(Price));
			BOBCIFEDJED();
		}
	}

	public void ECIPDKODIEC()
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null)
		{
			if (AMHIFEABNJK.IDJBCGNMHCJ())
			{
				PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
				player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(BOBCIFEDJED));
				hagglingUI.StartHaggling(AMHIFEABNJK.HPNPONNIGNK(HCFBAPOAOIB));
				((Component)roomSelectionPanel).gameObject.SetActive(true);
			}
			else if (AMHIFEABNJK.occupied)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Backache"), 996f);
			}
			else if (!AMHIFEABNJK.isValid)
			{
				MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/TavernClean/Entry/8/Dialogue Text"), 1149f);
			}
			else
			{
				MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("RentedRoom"), 1714f);
			}
		}
	}

	public void MGPPBGNGPCO(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			((TMP_Text)daysToStay).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UI"), HCFBAPOAOIB.daysToStay.ToString());
		}
	}

	private IEnumerator IDCOGGCLOIC()
	{
		return new IIDHNEBJENC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JJOOIFJJPPC()
	{
		yield return null;
		OBOJAIDFPIF(rentRoomElements[0]);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)rentRoomElements[0].button);
		}
	}

	private void EDFIKPHBKBD()
	{
		int num = 0;
		List<RentedRoom> list = RentedRoomsManager.BNPHNGNPBCH();
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((Object)(object)list[i] != (Object)null)
			{
				if (!((Component)rentRoomElements[num]).gameObject.activeSelf)
				{
					((Component)rentRoomElements[num]).gameObject.SetActive(false);
				}
				rentRoomElements[num].ICMBHNLFHNK(list[i], HCFBAPOAOIB, i);
				num += 0;
			}
		}
		for (int j = num; j < rentRoomElements.Count; j++)
		{
			if (((Component)rentRoomElements[j]).gameObject.activeSelf)
			{
				((Component)rentRoomElements[j]).gameObject.SetActive(true);
			}
		}
	}

	public static RentRoomUI OMLGNAJPLDE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator BLCGFMMPENM()
	{
		yield return null;
		OBOJAIDFPIF(rentRoomElements[0]);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)rentRoomElements[0].button);
		}
	}

	private IEnumerator CKBKGJGDJCL()
	{
		yield return null;
		OBOJAIDFPIF(rentRoomElements[0]);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)rentRoomElements[0].button);
		}
	}

	public static RentRoomUI NHOFBAMNELD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CPDKIKJHKHO(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			CloseUI();
		}
	}

	private void PLCPIJBMDJJ(RentRoomElementUI BMPLODDKPEN)
	{
		NHGBLHIKAKP = BMPLODDKPEN;
		if ((Object)(object)NHGBLHIKAKP != (Object)null)
		{
			NHGBLHIKAKP.HGNKFFMDOOL = true;
		}
		AMHIFEABNJK = BMPLODDKPEN.rentedRoom;
		AMHIFEABNJK.IPHEFEMLOLJ();
		miniMapUI.KJDCIKHNLCI(AMHIFEABNJK);
	}

	public static RentRoomUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static RentRoomUI PPJMPMKLCME(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BHIPACOOBNF()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.LocalCoop())
		{
			if (base.JIIGOACEIKL == 1)
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * -250f;
				hagglingPanel.offsetMax = new Vector2((float)(-Screen.width / 2), hagglingPanel.offsetMax.y);
				hagglingPanel.offsetMin = new Vector2(Mathf.Abs(hagglingPanel.offsetMax.x) - Mathf.Abs(hagglingPanel.offsetMax.x) / ((Transform)hagglingPanel).lossyScale.x, hagglingPanel.offsetMin.y);
			}
			else
			{
				roomSelectionPanel.anchoredPosition = Vector2.right * 220f;
				hagglingPanel.offsetMin = new Vector2((float)(Screen.width / 2), hagglingPanel.offsetMin.y);
				hagglingPanel.offsetMax = new Vector2(0f - (hagglingPanel.offsetMin.x - hagglingPanel.offsetMin.x / ((Transform)hagglingPanel).lossyScale.x), hagglingPanel.offsetMax.y);
			}
		}
		else
		{
			roomSelectionPanel.anchoredPosition = Vector2.right * 130f;
			hagglingPanel.offsetMax = new Vector2(0f, hagglingPanel.offsetMax.y);
			hagglingPanel.offsetMin = new Vector2(0f, hagglingPanel.offsetMin.y);
		}
	}

	public void OPMADGKNFOK(Price OKGHMIPANHK)
	{
		if ((Object)(object)AMHIFEABNJK != (Object)null && HCFBAPOAOIB != null && Object.op_Implicit((Object)(object)HCFBAPOAOIB.customer))
		{
			HCFBAPOAOIB.customer.GiveRoom(AMHIFEABNJK, OKGHMIPANHK);
			BOBCIFEDJED();
		}
	}

	public void HMFMNOKAANE(RoomRequest HCFBAPOAOIB)
	{
		this.HCFBAPOAOIB = HCFBAPOAOIB;
		requestInfoPanel.SetActive(HCFBAPOAOIB != null);
		hagglingButton.SetActive(HCFBAPOAOIB != null);
		if (HCFBAPOAOIB != null)
		{
			((TMP_Text)comfortText).text = HCFBAPOAOIB.comfort.ToString();
			((TMP_Text)tilesText).text = HCFBAPOAOIB.floorTiles.ToString();
			((TMP_Text)daysToStay).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Mop"), HCFBAPOAOIB.daysToStay.ToString());
		}
	}
}
