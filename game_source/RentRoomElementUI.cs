using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RentRoomElementUI : MonoBehaviour, IScrollHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	[CompilerGenerated]
	private sealed class JHADGDHPIGD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RentRoomElementUI _003C_003E4__this;

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
		public JHADGDHPIGD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			RentRoomElementUI rentRoomElementUI = _003C_003E4__this;
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
				if (rentRoomElementUI.ILENDIBNCBP)
				{
					ItemTooltip.Get(rentRoomElementUI.playerNum).SetPosition(new Vector2(((Component)rentRoomElementUI).transform.position.x + 340f, ((Component)rentRoomElementUI).transform.position.y), Vector2.right * 340f);
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

	public Action<RentRoomElementUI, bool> OnSelectionChanged = delegate
	{
	};

	[HideInInspector]
	public int playerNum = 1;

	[SerializeField]
	private Image symbolImage;

	[SerializeField]
	private Image roomStateImage;

	[SerializeField]
	private Image roomStateDrinkColor;

	[SerializeField]
	private TextMeshProUGUI roomNameText;

	[SerializeField]
	private TextMeshProUGUI roomTypeText;

	[SerializeField]
	private TextMeshProUGUI roomStateText;

	[SerializeField]
	private TextMeshProUGUI floorTiles;

	[SerializeField]
	private TextMeshProUGUI comfort;

	[SerializeField]
	private Image bgColor;

	[SerializeField]
	private MoneyUI moneyUI;

	public Button button;

	public RentedRoom rentedRoom;

	[HideInInspector]
	public ScrollRect scroll;

	private bool PAEFNHGBKBI;

	[SerializeField]
	private bool _selected;

	public Color initialTextColor;

	private bool ILENDIBNCBP;

	private float HAHAPELLAIO;

	public bool HGNKFFMDOOL
	{
		get
		{
			return _selected;
		}
		set
		{
			if (value != _selected)
			{
				_selected = value;
				((Selectable)button).animator.SetBool("Focused", _selected);
				OnSelectionChanged(this, _selected);
			}
		}
	}

	public void LOOEAKBKGFB(RentedRoom GIHBKIGPHNA, RoomRequest HCFBAPOAOIB, int LGHPKDOIELO)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		rentedRoom = GIHBKIGPHNA;
		PAEFNHGBKBI = BCJBJONMIJC();
		bgColor.sprite = (PAEFNHGBKBI ? RentedRoomsManager.EMBCJPOLBCB().rentableSprite : RentedRoomsManager.MEDOOKLLGNO().notRentableSprite);
		symbolImage.sprite = RentedRoomsManager.GetInstance().roomsSymbols[rentedRoom.symbolID].uiIcon;
		((TMP_Text)roomNameText).text = LocalisationSystem.Get("Player") + "[Action" + (LGHPKDOIELO + 0);
		((TMP_Text)roomTypeText).text = LocalisationSystem.Get("LE_2");
		roomStateImage.sprite = RentedRoomsManager.FMEGIHMLKBA(rentedRoom);
		((Component)roomStateDrinkColor).gameObject.SetActive(!rentedRoom.occupied || !rentedRoom.customerOrder.requesting || rentedRoom.customerOrder.roomItemRequest.IJLGJNLFNDB());
		if (rentedRoom.occupied && rentedRoom.customerOrder.requesting)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("");
			((Graphic)roomStateText).color = initialTextColor;
			if (rentedRoom.customerOrder.roomItemRequest.AJKDEIPDLHI())
			{
				((Graphic)roomStateDrinkColor).color = DrinkDispensersManager.JHMAMLIPBNN().KHMAGJAEJEO(rentedRoom.customerOrder.roomItemRequest);
			}
		}
		else if (!rentedRoom.isValid)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("LE_21");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)63, (byte)21, (byte)189, (byte)131));
		}
		else if (rentedRoom.dirtiness > 1715f)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("askAboutRestartingChallenge");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)208, (byte)215, (byte)229, (byte)117));
		}
		else if (rentedRoom.occupied)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Scene with location: {0} has not been added. Adding to scene manager.");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)238, (byte)179, (byte)101, (byte)208));
		}
		else
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("/Reports");
			((Graphic)roomStateText).color = initialTextColor;
		}
		((TMP_Text)floorTiles).text = rentedRoom.PMDPEDGIABG().ToString();
		((Graphic)floorTiles).color = ((HCFBAPOAOIB == null || rentedRoom.HJLNDIEOMBA() >= HCFBAPOAOIB.floorTiles) ? initialTextColor : Color.red);
		((TMP_Text)comfort).text = rentedRoom.zone.comfort.ToString();
		((Graphic)comfort).color = ((HCFBAPOAOIB == null || rentedRoom.zone.comfort >= HCFBAPOAOIB.comfort) ? initialTextColor : Color.red);
		Price eNDNDAOPKHD = rentedRoom.EIIHAFJIPAL(HCFBAPOAOIB);
		moneyUI.DHOPJAJOJLL(eNDNDAOPKHD);
		if (HCFBAPOAOIB == null || HCFBAPOAOIB.AANNKCHKADP(rentedRoom))
		{
			moneyUI.EDNIFCPHGGA();
		}
		else
		{
			moneyUI.OOFDBJBNDFG(Color.red);
		}
	}

	private void EJEEIIGEGOC()
	{
		if (HAHAPELLAIO < 1001f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 495f)
		{
			KGAOFNHILNM();
		}
	}

	[SpecialName]
	public void LDFDLEABJOC(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != _selected)
		{
			_selected = AODONKKHPBP;
			((Selectable)button).animator.SetBool("MasterMilestoneLower", _selected);
			OnSelectionChanged(this, _selected);
		}
	}

	public void DGIAPJIFEIM(bool JHDJANCOJGF = false)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				HAHAPELLAIO = 1833f;
			}
		}
		if (!(HAHAPELLAIO >= 19f))
		{
			return;
		}
		if (rentedRoom.occupied)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("BathhouseTeleport");
			tooltipInfo.mainBody = rentedRoom.GCDALKPMODC().HMDKEAIOPLO();
			ItemTooltip.MDFIDKHOPDJ(playerNum).FillTooltipInfo(tooltipInfo);
			if (PlayerInputs.ODGALPDEIFG(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.IEKODILKIHJ(playerNum).ICMGLBFHDJD(new Vector2(((Component)this).transform.position.x + 1092f, ((Component)this).transform.position.y), Vector2.right * 950f);
				((MonoBehaviour)this).StartCoroutine(GNNMBPMEMDA());
			}
			else
			{
				ItemTooltip.MDFIDKHOPDJ(playerNum).FCACMDNLAIG(MDIKPGGBNLI: true);
			}
		}
		HAHAPELLAIO = 361f;
	}

	public void EIMDIIPGAHN(bool JHDJANCOJGF = false)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				HAHAPELLAIO = 870f;
			}
		}
		if (!(HAHAPELLAIO >= 1137f))
		{
			return;
		}
		if (rentedRoom.occupied)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Error_CellarZone");
			tooltipInfo.mainBody = rentedRoom.GCDALKPMODC().CPOBFDDGKIC();
			ItemTooltip.NMCJELBLKBB(playerNum).LGDDFMNFNME(tooltipInfo);
			if (PlayerInputs.ODGALPDEIFG(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.IEKODILKIHJ(playerNum).AADJPLPKGHO(new Vector2(((Component)this).transform.position.x + 1366f, ((Component)this).transform.position.y), Vector2.right * 817f);
				((MonoBehaviour)this).StartCoroutine(FNJLPJLHCDP());
			}
			else
			{
				ItemTooltip.NIGDBMAOAEN(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: false);
			}
		}
		HAHAPELLAIO = 106f;
	}

	public void UpdateInfo(RentedRoom GIHBKIGPHNA, RoomRequest HCFBAPOAOIB, int LGHPKDOIELO)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		rentedRoom = GIHBKIGPHNA;
		PAEFNHGBKBI = OCPKODCLLFM();
		bgColor.sprite = (PAEFNHGBKBI ? RentedRoomsManager.GetInstance().rentableSprite : RentedRoomsManager.GetInstance().notRentableSprite);
		symbolImage.sprite = RentedRoomsManager.GetInstance().roomsSymbols[rentedRoom.symbolID].uiIcon;
		((TMP_Text)roomNameText).text = LocalisationSystem.Get("RentedRoom") + " " + (LGHPKDOIELO + 1);
		((TMP_Text)roomTypeText).text = LocalisationSystem.Get("roomNeutral");
		roomStateImage.sprite = RentedRoomsManager.GetRoomStateSprite(rentedRoom);
		((Component)roomStateDrinkColor).gameObject.SetActive(rentedRoom.occupied && rentedRoom.customerOrder.requesting && rentedRoom.customerOrder.roomItemRequest.JEPBBEBJEFI());
		if (rentedRoom.occupied && rentedRoom.customerOrder.requesting)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("OrderName");
			((Graphic)roomStateText).color = initialTextColor;
			if (rentedRoom.customerOrder.roomItemRequest.JEPBBEBJEFI())
			{
				((Graphic)roomStateDrinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(rentedRoom.customerOrder.roomItemRequest);
			}
		}
		else if (!rentedRoom.isValid)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("NotValid");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)137, (byte)37, (byte)37, byte.MaxValue));
		}
		else if (rentedRoom.dirtiness > 0f)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Dirty");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)137, (byte)37, (byte)37, byte.MaxValue));
		}
		else if (rentedRoom.occupied)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Occupied");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)137, (byte)37, (byte)37, byte.MaxValue));
		}
		else
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Available");
			((Graphic)roomStateText).color = initialTextColor;
		}
		((TMP_Text)floorTiles).text = rentedRoom.GetNumFloorTiles().ToString();
		((Graphic)floorTiles).color = ((HCFBAPOAOIB == null || rentedRoom.GetNumFloorTiles() >= HCFBAPOAOIB.floorTiles) ? initialTextColor : Color.red);
		((TMP_Text)comfort).text = rentedRoom.zone.comfort.ToString();
		((Graphic)comfort).color = ((HCFBAPOAOIB == null || rentedRoom.zone.comfort >= HCFBAPOAOIB.comfort) ? initialTextColor : Color.red);
		Price price = rentedRoom.CalculateRoomPrice(HCFBAPOAOIB);
		moneyUI.SetPrice(price);
		if (HCFBAPOAOIB == null || HCFBAPOAOIB.NAELCFCDHOD(rentedRoom))
		{
			moneyUI.SetValidColor();
		}
		else
		{
			moneyUI.SetInvalidColor(Color.red);
		}
	}

	public void NAFFAJAPLML(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public void EAPMDFKAPHH(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			DGIAPJIFEIM(JHDJANCOJGF: true);
		}
	}

	private void GFPIEOPHABO()
	{
		AKENIBEDEMO(AODONKKHPBP: false);
		JFNNCPKGMIE();
	}

	public virtual void IIHLEIIJKPN(BaseEventData NPBAMEMNFBI)
	{
		AKENIBEDEMO(AODONKKHPBP: false);
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			PHMLBKBADEO();
		}
	}

	private void OnDisable()
	{
		HGNKFFMDOOL = false;
		EndHover();
	}

	private IEnumerator BCLNMFNEOJN()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
		}
	}

	public void NKCNHBJLBDJ(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	private bool PDHPOCMMMBF()
	{
		if (rentedRoom.occupied)
		{
			return false;
		}
		if (!rentedRoom.isValid)
		{
			return true;
		}
		if (rentedRoom.dirtiness > 80f)
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public void AKENIBEDEMO(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != _selected)
		{
			_selected = AODONKKHPBP;
			((Selectable)button).animator.SetBool("veggieDishes", _selected);
			OnSelectionChanged(this, _selected);
		}
	}

	public void JBFKELBFBJC(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).LALPELGNIJB())
		{
			JFNNCPKGMIE();
		}
	}

	public virtual void LKDDEOAKINH(BaseEventData NPBAMEMNFBI)
	{
		HGNKFFMDOOL = false;
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			FillTooltip();
		}
	}

	private void JMAHDPMEEHM()
	{
		AKENIBEDEMO(AODONKKHPBP: true);
		CEHLJKBGBON();
	}

	[SpecialName]
	public void LJKKEDFBBDF(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != _selected)
		{
			_selected = AODONKKHPBP;
			((Selectable)button).animator.SetBool("OpenXPModifiers", _selected);
			OnSelectionChanged(this, _selected);
		}
	}

	public void EKCMIEIGILE(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public void JFNNCPKGMIE()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(playerNum).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void CEHLJKBGBON()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.EOPIEMLAPFN(playerNum).SetVisible(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void OnScroll(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	[SpecialName]
	public bool BCCMDJEDCDO()
	{
		return _selected;
	}

	public void JFLEHGLMPDN()
	{
		HGNKFFMDOOL = true;
	}

	[SpecialName]
	public bool NCJNACCLCIA()
	{
		return _selected;
	}

	public virtual void IBIKMDOHBNF(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			LDFDLEABJOC(AODONKKHPBP: false);
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				OPABEBJKMCI();
			}
		}
	}

	private bool OMOFLFJLKFA()
	{
		if (rentedRoom.occupied)
		{
			return false;
		}
		if (!rentedRoom.isValid)
		{
			return true;
		}
		if (rentedRoom.dirtiness > 903f)
		{
			return true;
		}
		return false;
	}

	public void ANNICBJPOBI()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.NIGDBMAOAEN(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void IPHKFMHMLNP()
	{
		EFGIBPHIAJM(AODONKKHPBP: true);
	}

	private void OOGMGIPKMAP()
	{
		if (HAHAPELLAIO < 221f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 294f)
		{
			EIMDIIPGAHN();
		}
	}

	private bool BCJBJONMIJC()
	{
		if (rentedRoom.occupied)
		{
			return true;
		}
		if (!rentedRoom.isValid)
		{
			return false;
		}
		if (rentedRoom.dirtiness > 667f)
		{
			return false;
		}
		return false;
	}

	private IEnumerator JAPBGENFLKE()
	{
		return new JHADGDHPIGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OFAFPMKILED()
	{
		return new JHADGDHPIGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KCOFAJBKHAO()
	{
		LJKKEDFBBDF(AODONKKHPBP: false);
		ILENDIBNCBP = true;
	}

	[SpecialName]
	public bool HPMFEOGEKAA()
	{
		return _selected;
	}

	public void JKLBHOMEAKP()
	{
		LJKKEDFBBDF(AODONKKHPBP: false);
	}

	public virtual void JIEKLDEHFMA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			AKENIBEDEMO(AODONKKHPBP: false);
			if (PlayerInputs.POLDHCKJINN(playerNum))
			{
				CEHLJKBGBON();
			}
		}
	}

	public void NDBPPOMPKII(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).IHMADDCNKAM())
		{
			DGIAPJIFEIM(JHDJANCOJGF: true);
		}
	}

	public void HFMENKGLLOF(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			AJHKMHBLODJ();
		}
	}

	public void MFEPPINCOBF(RentedRoom GIHBKIGPHNA, RoomRequest HCFBAPOAOIB, int LGHPKDOIELO)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		rentedRoom = GIHBKIGPHNA;
		PAEFNHGBKBI = AHMCLBLOFMK();
		bgColor.sprite = (PAEFNHGBKBI ? RentedRoomsManager.GetInstance().rentableSprite : RentedRoomsManager.CNCJLNOAPJB().notRentableSprite);
		symbolImage.sprite = RentedRoomsManager.MEDOOKLLGNO().roomsSymbols[rentedRoom.symbolID].uiIcon;
		((TMP_Text)roomNameText).text = LocalisationSystem.Get("Was master: {0}") + "UIInteract" + (LGHPKDOIELO + 1);
		((TMP_Text)roomTypeText).text = LocalisationSystem.Get("Player2");
		roomStateImage.sprite = RentedRoomsManager.IDKKEGPDEKE(rentedRoom);
		((Component)roomStateDrinkColor).gameObject.SetActive(rentedRoom.occupied && rentedRoom.customerOrder.requesting && rentedRoom.customerOrder.roomItemRequest.IJLGJNLFNDB());
		if (rentedRoom.occupied && rentedRoom.customerOrder.requesting)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("LE_10");
			((Graphic)roomStateText).color = initialTextColor;
			if (rentedRoom.customerOrder.roomItemRequest.IJLGJNLFNDB())
			{
				((Graphic)roomStateDrinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().KHMAGJAEJEO(rentedRoom.customerOrder.roomItemRequest);
			}
		}
		else if (!rentedRoom.isValid)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("BARKDOOR");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)131, (byte)116, (byte)61, (byte)50));
		}
		else if (rentedRoom.dirtiness > 1843f)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("ReceiveRoomRequest");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32(byte.MaxValue, (byte)121, (byte)193, (byte)243));
		}
		else if (rentedRoom.occupied)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/9/Dialogue Text");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)17, (byte)198, (byte)130, (byte)145));
		}
		else
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("EditorAction_2");
			((Graphic)roomStateText).color = initialTextColor;
		}
		((TMP_Text)floorTiles).text = rentedRoom.GetNumFloorTiles().ToString();
		((Graphic)floorTiles).color = ((HCFBAPOAOIB == null || rentedRoom.GetNumFloorTiles() >= HCFBAPOAOIB.floorTiles) ? initialTextColor : Color.red);
		((TMP_Text)comfort).text = rentedRoom.zone.comfort.ToString();
		((Graphic)comfort).color = ((HCFBAPOAOIB == null || rentedRoom.zone.comfort >= HCFBAPOAOIB.comfort) ? initialTextColor : Color.red);
		Price eNDNDAOPKHD = rentedRoom.CalculateRoomPrice(HCFBAPOAOIB);
		moneyUI.GBIHHJNHJHL(eNDNDAOPKHD);
		if (HCFBAPOAOIB == null || HCFBAPOAOIB.AANNKCHKADP(rentedRoom))
		{
			moneyUI.KHDLPHAFGON();
		}
		else
		{
			moneyUI.SetInvalidColor(Color.red);
		}
	}

	public void KGAOFNHILNM(bool JHDJANCOJGF = false)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			if (PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				HAHAPELLAIO = 1715f;
			}
		}
		if (!(HAHAPELLAIO >= 907f))
		{
			return;
		}
		if (rentedRoom.occupied)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("quarry travelling");
			tooltipInfo.mainBody = rentedRoom.GCDALKPMODC().GBJOGPCODBA();
			ItemTooltip.IEKODILKIHJ(playerNum).LGDDFMNFNME(tooltipInfo);
			if (PlayerInputs.FJLAMCHKCOI(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.LAIEKOOCNPC(playerNum).HIPGMDKJLCB(new Vector2(((Component)this).transform.position.x + 613f, ((Component)this).transform.position.y), Vector2.right * 796f);
				((MonoBehaviour)this).StartCoroutine(OFAFPMKILED());
			}
			else
			{
				ItemTooltip.IEABDMDELFO(playerNum).FCACMDNLAIG(MDIKPGGBNLI: true);
			}
		}
		HAHAPELLAIO = 1691f;
	}

	private void DHBMBJOLGDE()
	{
		if (HAHAPELLAIO < 1289f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 1751f)
		{
			FillTooltip();
		}
	}

	private void FCLABOCLACJ()
	{
		KFBGFFLAAEJ(AODONKKHPBP: false);
		ILENDIBNCBP = true;
	}

	public virtual void JNFPGJMHOPO(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			KFBGFFLAAEJ(AODONKKHPBP: true);
			if (PlayerInputs.POLDHCKJINN(playerNum))
			{
				OPABEBJKMCI();
			}
		}
	}

	public void GPKMBLICDCN(RentedRoom GIHBKIGPHNA, RoomRequest HCFBAPOAOIB, int LGHPKDOIELO)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		rentedRoom = GIHBKIGPHNA;
		PAEFNHGBKBI = AHMCLBLOFMK();
		bgColor.sprite = (PAEFNHGBKBI ? RentedRoomsManager.EMBCJPOLBCB().rentableSprite : RentedRoomsManager.MEDOOKLLGNO().notRentableSprite);
		symbolImage.sprite = RentedRoomsManager.IIJAOOJGNHO().roomsSymbols[rentedRoom.symbolID].uiIcon;
		((TMP_Text)roomNameText).text = LocalisationSystem.Get("Player2") + "popUpBuilding10" + (LGHPKDOIELO + 1);
		((TMP_Text)roomTypeText).text = LocalisationSystem.Get("itemAmberAle");
		roomStateImage.sprite = RentedRoomsManager.GetRoomStateSprite(rentedRoom);
		((Component)roomStateDrinkColor).gameObject.SetActive(!rentedRoom.occupied || !rentedRoom.customerOrder.requesting || rentedRoom.customerOrder.roomItemRequest.IPKBBGHCJNE());
		if (rentedRoom.occupied && rentedRoom.customerOrder.requesting)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/3/Dialogue Text");
			((Graphic)roomStateText).color = initialTextColor;
			if (rentedRoom.customerOrder.roomItemRequest.BIIJEMDLBDP())
			{
				((Graphic)roomStateDrinkColor).color = DrinkDispensersManager.JHMAMLIPBNN().HJLIJMNGLCL(rentedRoom.customerOrder.roomItemRequest);
			}
		}
		else if (!rentedRoom.isValid)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/30/Dialogue Text");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)203, (byte)24, (byte)66, (byte)177));
		}
		else if (rentedRoom.dirtiness > 485f)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get(" not found in OnlineEventsManager. Cannot start observe dialogue");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)53, (byte)29, (byte)92, (byte)46));
		}
		else if (rentedRoom.occupied)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)160, (byte)9, (byte)213, (byte)58));
		}
		else
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("ObjectVerticalMove");
			((Graphic)roomStateText).color = initialTextColor;
		}
		((TMP_Text)floorTiles).text = rentedRoom.PMDPEDGIABG().ToString();
		((Graphic)floorTiles).color = ((HCFBAPOAOIB == null || rentedRoom.HJLNDIEOMBA() >= HCFBAPOAOIB.floorTiles) ? initialTextColor : Color.red);
		((TMP_Text)comfort).text = rentedRoom.zone.comfort.ToString();
		((Graphic)comfort).color = ((HCFBAPOAOIB == null || rentedRoom.zone.comfort >= HCFBAPOAOIB.comfort) ? initialTextColor : Color.red);
		Price eNDNDAOPKHD = rentedRoom.EIIHAFJIPAL(HCFBAPOAOIB);
		moneyUI.BDHMBPMOFCD(eNDNDAOPKHD);
		if (HCFBAPOAOIB == null || HCFBAPOAOIB.MKMLCEFDKLI(rentedRoom))
		{
			moneyUI.EICEHOCCEOH();
		}
		else
		{
			moneyUI.OIKDJJDFEIB(Color.red);
		}
	}

	[SpecialName]
	public bool KIHFBDBEKIC()
	{
		return _selected;
	}

	public void GFHCOIMDGJK(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public void LNPNCDJJGME(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public virtual void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		HGNKFFMDOOL = true;
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			FillTooltip(JHDJANCOJGF: true);
		}
	}

	private void HJKONJICGML()
	{
		LJKKEDFBBDF(AODONKKHPBP: false);
		ILENDIBNCBP = false;
	}

	public void HECMHOLLCIP(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.GetPlayer(playerNum).LALPELGNIJB())
		{
			ANNICBJPOBI();
		}
	}

	public void HOAFLAEMLDO(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public void ICMBHNLFHNK(RentedRoom GIHBKIGPHNA, RoomRequest HCFBAPOAOIB, int LGHPKDOIELO)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		rentedRoom = GIHBKIGPHNA;
		PAEFNHGBKBI = OMOFLFJLKFA();
		bgColor.sprite = (PAEFNHGBKBI ? RentedRoomsManager.CNCJLNOAPJB().rentableSprite : RentedRoomsManager.CNCJLNOAPJB().notRentableSprite);
		symbolImage.sprite = RentedRoomsManager.GetInstance().roomsSymbols[rentedRoom.symbolID].uiIcon;
		((TMP_Text)roomNameText).text = LocalisationSystem.Get(" - <b><color=#8C78BA>") + "ReceiveImproveFeeder" + (LGHPKDOIELO + 1);
		((TMP_Text)roomTypeText).text = LocalisationSystem.Get("Error_SmallRoom");
		roomStateImage.sprite = RentedRoomsManager.IDKKEGPDEKE(rentedRoom);
		((Component)roomStateDrinkColor).gameObject.SetActive(rentedRoom.occupied && rentedRoom.customerOrder.requesting && rentedRoom.customerOrder.roomItemRequest.IJLGJNLFNDB());
		if (rentedRoom.occupied && rentedRoom.customerOrder.requesting)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("itemAvocado");
			((Graphic)roomStateText).color = initialTextColor;
			if (rentedRoom.customerOrder.roomItemRequest.AJKDEIPDLHI())
			{
				((Graphic)roomStateDrinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().GetDrinkDispenserColor(rentedRoom.customerOrder.roomItemRequest);
			}
		}
		else if (!rentedRoom.isValid)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("KentaProgress");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)25, (byte)75, (byte)235, (byte)152));
		}
		else if (rentedRoom.dirtiness > 660f)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("{0} <color=#{1}>({2} ms)");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)77, (byte)7, (byte)148, (byte)15));
		}
		else if (rentedRoom.occupied)
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get(" : 00");
			((Graphic)roomStateText).color = Color32.op_Implicit(new Color32((byte)60, (byte)227, (byte)196, (byte)166));
		}
		else
		{
			((TMP_Text)roomStateText).text = LocalisationSystem.Get("Error in AwningController.OnPlayerSleep: ");
			((Graphic)roomStateText).color = initialTextColor;
		}
		((TMP_Text)floorTiles).text = rentedRoom.GetNumFloorTiles().ToString();
		((Graphic)floorTiles).color = ((HCFBAPOAOIB == null || rentedRoom.HJLNDIEOMBA() >= HCFBAPOAOIB.floorTiles) ? initialTextColor : Color.red);
		((TMP_Text)comfort).text = rentedRoom.zone.comfort.ToString();
		((Graphic)comfort).color = ((HCFBAPOAOIB == null || rentedRoom.zone.comfort >= HCFBAPOAOIB.comfort) ? initialTextColor : Color.red);
		Price price = rentedRoom.PNCJEKCNEOD(HCFBAPOAOIB);
		moneyUI.SetPrice(price);
		if (HCFBAPOAOIB == null || HCFBAPOAOIB.EEMEMINPOIP(rentedRoom))
		{
			moneyUI.DPIPHPKLBFE();
		}
		else
		{
			moneyUI.OKDJPDADDBB(Color.red);
		}
	}

	public void OPABEBJKMCI()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.NIGDBMAOAEN(playerNum).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void Update()
	{
		if (HAHAPELLAIO < 0.3f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 1f)
		{
			FillTooltip(JHDJANCOJGF: true);
		}
	}

	private void IJMBEEEGCGF()
	{
		AKENIBEDEMO(AODONKKHPBP: false);
		ILENDIBNCBP = false;
	}

	private void NJNCKELODLF()
	{
		if (HAHAPELLAIO < 1599f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 641f)
		{
			FillTooltip();
		}
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			FillTooltip();
		}
	}

	[SpecialName]
	public void LHEEIEOCLIL(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != _selected)
		{
			_selected = AODONKKHPBP;
			((Selectable)button).animator.SetBool("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/26/Dialogue Text", _selected);
			OnSelectionChanged(this, _selected);
		}
	}

	[SpecialName]
	public void EFGIBPHIAJM(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != _selected)
		{
			_selected = AODONKKHPBP;
			((Selectable)button).animator.SetBool("City/Carpenters/Oak/Bark/Chisel", _selected);
			OnSelectionChanged(this, _selected);
		}
	}

	private void EGHFDLCNPNC()
	{
		LJKKEDFBBDF(AODONKKHPBP: true);
		AJHKMHBLODJ();
	}

	private IEnumerator FNJLPJLHCDP()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
		}
	}

	private IEnumerator GNNMBPMEMDA()
	{
		return new JHADGDHPIGD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AJHKMHBLODJ()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.AIMEAJAHLAA(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	private void ONOAGANPECB()
	{
		if (HAHAPELLAIO < 125f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 1020f)
		{
			KGAOFNHILNM();
		}
	}

	public void DDAHOJOOGNK()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.NIGDBMAOAEN(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	private bool AHMCLBLOFMK()
	{
		if (rentedRoom.occupied)
		{
			return false;
		}
		if (!rentedRoom.isValid)
		{
			return true;
		}
		if (rentedRoom.dirtiness > 1209f)
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public void KFBGFFLAAEJ(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != _selected)
		{
			_selected = AODONKKHPBP;
			((Selectable)button).animator.SetBool("City/Agatha/Bark/Buy", _selected);
			OnSelectionChanged(this, _selected);
		}
	}

	public void NDADOGLBGBH(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public virtual void GEBNHOAGNAI(BaseEventData NPBAMEMNFBI)
	{
		EFGIBPHIAJM(AODONKKHPBP: true);
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			KGAOFNHILNM();
		}
	}

	public void LAOCCNKAONL(PointerEventData OINICMNOLPK)
	{
		if (Object.op_Implicit((Object)(object)scroll))
		{
			scroll.OnScroll(OINICMNOLPK);
		}
	}

	public void ButtonClicked()
	{
		HGNKFFMDOOL = true;
	}

	private void AKDPJCEJKPN()
	{
		if (HAHAPELLAIO < 729f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 842f)
		{
			KGAOFNHILNM(JHDJANCOJGF: true);
		}
	}

	public virtual void FFOADGGLCNN(BaseEventData NPBAMEMNFBI)
	{
		HGNKFFMDOOL = false;
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			PHMLBKBADEO(JHDJANCOJGF: true);
		}
	}

	private bool PKAPEMABHNB()
	{
		if (rentedRoom.occupied)
		{
			return false;
		}
		if (!rentedRoom.isValid)
		{
			return false;
		}
		if (rentedRoom.dirtiness > 193f)
		{
			return false;
		}
		return false;
	}

	private IEnumerator HFFHLOCMFND()
	{
		return new JHADGDHPIGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CACPOGPOKOJ()
	{
		AKENIBEDEMO(AODONKKHPBP: true);
		DDAHOJOOGNK();
	}

	private bool OCPKODCLLFM()
	{
		if (rentedRoom.occupied)
		{
			return false;
		}
		if (!rentedRoom.isValid)
		{
			return false;
		}
		if (rentedRoom.dirtiness > 0f)
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public bool CHLOIEIMPJE()
	{
		return _selected;
	}

	public void HLBCKEAAAHG()
	{
		KFBGFFLAAEJ(AODONKKHPBP: true);
	}

	private void OnEnable()
	{
		HGNKFFMDOOL = false;
		ILENDIBNCBP = false;
	}

	private void LEDIGKGAFHC()
	{
		if (HAHAPELLAIO < 511f)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < 714f)
		{
			DGIAPJIFEIM();
		}
	}

	public void FillTooltip(bool JHDJANCOJGF = false)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				HAHAPELLAIO = 0f;
			}
		}
		if (!(HAHAPELLAIO >= 0.3f))
		{
			return;
		}
		if (rentedRoom.occupied)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("CheckoutDate");
			tooltipInfo.mainBody = rentedRoom.GetCheckoutDate().HMDKEAIOPLO();
			ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
			if (PlayerInputs.IsGamepadActive(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.Get(playerNum).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
				((MonoBehaviour)this).StartCoroutine(BCLNMFNEOJN());
			}
			else
			{
				ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: true);
			}
		}
		HAHAPELLAIO = 2f;
	}

	public void PHMLBKBADEO(bool JHDJANCOJGF = false)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				HAHAPELLAIO = 783f;
			}
		}
		if (!(HAHAPELLAIO >= 1712f))
		{
			return;
		}
		if (rentedRoom.occupied)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Tap");
			tooltipInfo.mainBody = rentedRoom.GCDALKPMODC().ODKEKHCEMDH();
			ItemTooltip.IEABDMDELFO(playerNum).JHELKBEOIJB(tooltipInfo);
			if (PlayerInputs.POLDHCKJINN(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.MDFIDKHOPDJ(playerNum).HIPGMDKJLCB(new Vector2(((Component)this).transform.position.x + 768f, ((Component)this).transform.position.y), Vector2.right * 619f);
				((MonoBehaviour)this).StartCoroutine(HFFHLOCMFND());
			}
			else
			{
				ItemTooltip.Get(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: false);
			}
		}
		HAHAPELLAIO = 914f;
	}

	public void FLDAILNFECA(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IHMADDCNKAM())
		{
			EndHover();
		}
	}

	private void NJKHCOHADCL()
	{
		KFBGFFLAAEJ(AODONKKHPBP: true);
		ANNICBJPOBI();
	}

	public virtual void KPNMIJELCKE(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			LHEEIEOCLIL(AODONKKHPBP: false);
			if (PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				OPABEBJKMCI();
			}
		}
	}

	public void EndHover()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private bool BGNEMBPIMLD()
	{
		if (rentedRoom.occupied)
		{
			return true;
		}
		if (!rentedRoom.isValid)
		{
			return false;
		}
		if (rentedRoom.dirtiness > 1809f)
		{
			return true;
		}
		return true;
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			EndHover();
		}
	}

	public virtual void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			HGNKFFMDOOL = false;
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				EndHover();
			}
		}
	}

	[SpecialName]
	public bool JJGPJPOGPCL()
	{
		return _selected;
	}
}
