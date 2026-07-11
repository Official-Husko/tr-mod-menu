using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RoomOrdersBubble : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JMDLKANKPPO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomOrdersBubble _003C_003E4__this;

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
		public JMDLKANKPPO(int _003C_003E1__state)
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
			RoomOrdersBubble roomOrdersBubble = _003C_003E4__this;
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
				((Component)roomOrdersBubble.rectContent).gameObject.SetActive(false);
				((Component)roomOrdersBubble.rectContent).gameObject.SetActive(true);
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

	public static RoomOrdersBubble _instance;

	public static RoomOrdersBubble _instance2;

	public RectTransform rect;

	public RectTransform rectContent;

	public GameObject bubble;

	public GameObject secondBeerLine;

	public GameObject bubbleNoticeContent;

	public GameObject[] orders;

	public Image noticeFoodIcon;

	public Image[] symbolIcons;

	public Image[] foodIcons;

	public Image[] drinkColors;

	[HideInInspector]
	public bool updatePos;

	private Vector2 MAFKIOMFHKE;

	private int JIIGOACEIKL = 1;

	private void BFKCHCLJIPL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void ODIEJEILKPJ(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(DCLNLCFGBKN());
		}
	}

	private void PKPHKBMPJGJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("RoomDoor")) ? 0 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void UpdateBubble()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i++)
		{
			orders[i].SetActive(false);
		}
		if (RentedRoomsManager.GetRoomOrders().Count > 0)
		{
			if (RentedRoomsManager.GetRoomOrders().Count > 3)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < RentedRoomsManager.GetRoomOrders().Count; j++)
			{
				CustomerOrder customerOrder = RentedRoomsManager.GetRoomOrders()[j];
				if (j >= 5)
				{
					break;
				}
				orders[j].SetActive(true);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.GetSymbol();
				if (customerOrder.roomItemRequest.JEPBBEBJEFI())
				{
					foodIcons[j].sprite = RentedRoomsManager.GetInstance().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.GetInstance().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.JEPBBEBJEFI());
				if (customerOrder.roomItemRequest.JEPBBEBJEFI())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"Force");
			}
			((MonoBehaviour)this).StartCoroutine(IPDJLADOPBH());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void OMBHDODDHNO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_21")) ? 4 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private IEnumerator HHPKPOMFOGO()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	public void SetBubblePosition(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(IPDJLADOPBH());
		}
	}

	private IEnumerator IPDJLADOPBH()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	public void BMPJMBMEFGM()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < orders.Length; i += 0)
		{
			orders[i].SetActive(false);
		}
		if (RentedRoomsManager.KEGINBPMPNA().Count > 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF().Count > 3)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 1; j < RentedRoomsManager.GetRoomOrders().Count; j++)
			{
				CustomerOrder customerOrder = RentedRoomsManager.KEGINBPMPNA()[j];
				if (j >= 5)
				{
					break;
				}
				orders[j].SetActive(false);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.GetSymbol();
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					foodIcons[j].sprite = RentedRoomsManager.GetInstance().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.GetInstance().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.AJKDEIPDLHI());
				if (customerOrder.roomItemRequest.IJLGJNLFNDB())
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.OPILDPFDFKJ().GetDrinkDispenserColor(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"Customise Character");
			}
			((MonoBehaviour)this).StartCoroutine(PCOOKFCLHIL());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void FCLABOCLACJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void IBMDFNKKPJF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" exist in dictionary but is null")) ? 1 : 5);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Drink")) ? 1 : 1);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private IEnumerator OHGPCOHGOCG()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	private void MKHMCIFFOFJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private IEnumerator DCLNLCFGBKN()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	public static RoomOrdersBubble JHEHMLIPPAA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void FDAEKDDOJHN(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(OHGPCOHGOCG());
		}
	}

	public void PDMGKIIKOOG()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < orders.Length; i++)
		{
			orders[i].SetActive(true);
		}
		if (RentedRoomsManager.KEGINBPMPNA().Count > 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA().Count > 7)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 1; j < RentedRoomsManager.GetRoomOrders().Count; j += 0)
			{
				CustomerOrder customerOrder = RentedRoomsManager.GLJNFKFJMFF()[j];
				if (j >= 0)
				{
					break;
				}
				orders[j].SetActive(true);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.GetSymbol();
				if (customerOrder.roomItemRequest.IJLGJNLFNDB())
				{
					foodIcons[j].sprite = RentedRoomsManager.CNCJLNOAPJB().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.AJKDEIPDLHI());
				if (customerOrder.roomItemRequest.BIIJEMDLBDP())
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.BNDNMBGJEKP().LHOIHOGNBKI(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"Items/item_description_671");
			}
			((MonoBehaviour)this).StartCoroutine(OFFKJPCHIDL());
		}
		else
		{
			bubble.SetActive(true);
		}
	}

	public static RoomOrdersBubble HELHJMDEDNL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void DPBDKABBNAH(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(PHJCPANGACP());
		}
	}

	public void ADLAEBKBOCC()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < orders.Length; i++)
		{
			orders[i].SetActive(true);
		}
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 1)
		{
			if (RentedRoomsManager.GLJNFKFJMFF().Count > 2)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 0; j < RentedRoomsManager.KEGINBPMPNA().Count; j++)
			{
				CustomerOrder customerOrder = RentedRoomsManager.KEGINBPMPNA()[j];
				if (j >= 3)
				{
					break;
				}
				orders[j].SetActive(false);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.CJMLBNFGMDC();
				if (customerOrder.roomItemRequest.IPKBBGHCJNE())
				{
					foodIcons[j].sprite = RentedRoomsManager.IIJAOOJGNHO().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.JLCBECDECBP());
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().GetDrinkDispenserColor(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"");
			}
			((MonoBehaviour)this).StartCoroutine(NBKCHCHFDLE());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void LMNKOMLKIAA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.KEGINBPMPNA().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.GKEKLFBGDMO() + new Vector3(249f, 331f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(true);
				if (RentedRoomsManager.KEGINBPMPNA()[0].roomItemRequest.JLCBECDECBP())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.GetInstance().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(true);
			}
			ODDKBGCLCOG(RoomReceptionDesk.FEODGKFADIF() + new Vector3(1387f, 1040f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void DKNNLPFIBIK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Game")) ? 2 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void LCJCGFNFBBD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private IEnumerator OFFKJPCHIDL()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	public static RoomOrdersBubble FCGLFOJDIBM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void HKJCLFHCMKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void OIHPFDGFCHF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.FIGFLHCEJLL() + new Vector3(425f, 105f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(false);
				if (RentedRoomsManager.KEGINBPMPNA()[0].roomItemRequest.IJLGJNLFNDB())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.MEDOOKLLGNO().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.CNCJLNOAPJB().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			DBPLOAEMEEA(RoomReceptionDesk.FFPIHLPKMHO() + new Vector3(1448f, 1929f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private IEnumerator IAMNCEOLMKC()
	{
		return new JMDLKANKPPO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKFGDMNBAAK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.GKEKLFBGDMO() + new Vector3(1099f, 1988f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(false);
				if (RentedRoomsManager.KEGINBPMPNA()[1].roomItemRequest.BIIJEMDLBDP())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.GetInstance().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(true);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(true);
			}
			NNIBHNMPBGD(RoomReceptionDesk.OFPLAFKBEHE() + new Vector3(30f, 927f));
		}
		else
		{
			bubble.SetActive(true);
		}
	}

	private void FFBDJIJJDMK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.GetPosition() + new Vector3(209f, 902f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(false);
				if (RentedRoomsManager.GetRoomOrders()[0].roomItemRequest.JEPBBEBJEFI())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.MEDOOKLLGNO().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.MEDOOKLLGNO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			ODDKBGCLCOG(RoomReceptionDesk.GOEONNCGKGJ() + new Vector3(886f, 1049f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void GNOBDKFFPOL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("WorkAnimationLoop")) ? 1 : 7);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void CIAIAEJIMCM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private IEnumerator NBKCHCHFDLE()
	{
		return new JMDLKANKPPO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKHLEMPJONN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("VERSION")) ? 6 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private IEnumerator PCOOKFCLHIL()
	{
		return new JMDLKANKPPO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ODDKBGCLCOG(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((MonoBehaviour)this).StartCoroutine(HHKGPBDLCAD());
		}
	}

	private void OnEnable()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void POCNCNOIFDM()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i += 0)
		{
			orders[i].SetActive(false);
		}
		if (RentedRoomsManager.KEGINBPMPNA().Count > 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF().Count > 2)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 0; j < RentedRoomsManager.KEGINBPMPNA().Count; j += 0)
			{
				CustomerOrder customerOrder = RentedRoomsManager.GetRoomOrders()[j];
				if (j >= 3)
				{
					break;
				}
				orders[j].SetActive(false);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.CJMLBNFGMDC();
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.IPKBBGHCJNE());
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().HJLIJMNGLCL(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"BackPain");
			}
			((MonoBehaviour)this).StartCoroutine(DCLNLCFGBKN());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	public void DIOEAKNDHCI()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i++)
		{
			orders[i].SetActive(false);
		}
		if (RentedRoomsManager.GetRoomOrders().Count > 1)
		{
			if (RentedRoomsManager.KEGINBPMPNA().Count > 6)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < RentedRoomsManager.GLJNFKFJMFF().Count; j += 0)
			{
				CustomerOrder customerOrder = RentedRoomsManager.GetRoomOrders()[j];
				if (j >= 8)
				{
					break;
				}
				orders[j].SetActive(false);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.GetSymbol();
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					foodIcons[j].sprite = RentedRoomsManager.IIJAOOJGNHO().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.IIJAOOJGNHO().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.JLCBECDECBP());
				if (customerOrder.roomItemRequest.BIIJEMDLBDP())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.OLHBLKIAFOM().HJLIJMNGLCL(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"Waiter");
			}
			((MonoBehaviour)this).StartCoroutine(IPDJLADOPBH());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void IJMBEEEGCGF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void PADFHAMCFJB()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i++)
		{
			orders[i].SetActive(true);
		}
		if (RentedRoomsManager.GetRoomOrders().Count > 1)
		{
			if (RentedRoomsManager.KEGINBPMPNA().Count > 2)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < RentedRoomsManager.KEGINBPMPNA().Count; j += 0)
			{
				CustomerOrder customerOrder = RentedRoomsManager.GLJNFKFJMFF()[j];
				if (j >= 4)
				{
					break;
				}
				orders[j].SetActive(true);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.GetSymbol();
				if (customerOrder.roomItemRequest.IPKBBGHCJNE())
				{
					foodIcons[j].sprite = RentedRoomsManager.MEDOOKLLGNO().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.MEDOOKLLGNO().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.JEPBBEBJEFI());
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.OPILDPFDFKJ().GetDrinkDispenserColor(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"unlock all recipes");
			}
			((MonoBehaviour)this).StartCoroutine(OFFKJPCHIDL());
		}
		else
		{
			bubble.SetActive(true);
		}
	}

	private IEnumerator DMIEDAMMMDM()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	private void LFBIFPBPDMJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public static RoomOrdersBubble MBDFOJAKELO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void AFGJLAACCFN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public static RoomOrdersBubble IMJOOACMADK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private IEnumerator JGMBJNAELKN()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}

	private void GONDLJKGLGO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("TavernFilthy")) ? 1 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void GMNJJIGMJEG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.FIGFLHCEJLL() + new Vector3(656f, 505f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(true);
				if (RentedRoomsManager.GLJNFKFJMFF()[1].roomItemRequest.JLCBECDECBP())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.CNCJLNOAPJB().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(true);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			ODDKBGCLCOG(RoomReceptionDesk.FIGFLHCEJLL() + new Vector3(1203f, 1698f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void PPJMHGFLEDF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.KEGINBPMPNA().Count > 1 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.FFJEFLNODOL() + new Vector3(1840f, 61f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(false);
				if (RentedRoomsManager.GLJNFKFJMFF()[0].roomItemRequest.IPKBBGHCJNE())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.EMBCJPOLBCB().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.CNCJLNOAPJB().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			ODDKBGCLCOG(RoomReceptionDesk.GetPosition() + new Vector3(1025f, 455f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	public static RoomOrdersBubble NPANPNIDKDG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void BDIHPJDEFBM(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(PCOOKFCLHIL());
		}
	}

	private void HCKMHIHALBL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void JINLGFOFJAN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void FPNCANODJKE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" 2")) ? 1 : 4);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void PBDNKBPBCHM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Festín del Juramento/ComensalesBarks")) ? 1 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void FPNPLFALPHP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void DADPOICMNPI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(". Now the actor is the host.")) ? 1 : 8);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void OIEJIBAPDMM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void NNIBHNMPBGD(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(IAMNCEOLMKC());
		}
	}

	public static RoomOrdersBubble NBEGPFFBKPO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	private void DNKEFFMOCKP()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_name_638")) ? 1 : 8);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private IEnumerator MJFKDDFHPHH()
	{
		return new JMDLKANKPPO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BIEEFOFHKKE(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.KEGINBPMPNA().Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((MonoBehaviour)this).StartCoroutine(NBKCHCHFDLE());
		}
	}

	private void DIMOLCECNGD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.FIGFLHCEJLL() + new Vector3(707f, 1241f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(false);
				if (RentedRoomsManager.KEGINBPMPNA()[1].roomItemRequest.IPKBBGHCJNE())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.MEDOOKLLGNO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(true);
			}
			CGDKAIFLCDF(RoomReceptionDesk.IAIMGPELBJM() + new Vector3(1823f, 1964f));
		}
		else
		{
			bubble.SetActive(true);
		}
	}

	public static RoomOrdersBubble OGKNJNINGMH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	public void NFCPLAOKDLE(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((MonoBehaviour)this).StartCoroutine(IPDJLADOPBH());
		}
	}

	public void CGDKAIFLCDF(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(IAMNCEOLMKC());
		}
	}

	private void GOBPJEDFOAC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 1 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.GetPosition() + new Vector3(1160f, 1355f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(false);
				if (RentedRoomsManager.GLJNFKFJMFF()[1].roomItemRequest.BIIJEMDLBDP())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.MEDOOKLLGNO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(true);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			BIEEFOFHKKE(RoomReceptionDesk.FEODGKFADIF() + new Vector3(450f, 1543f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 1 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.FFJEFLNODOL() + new Vector3(1394f, 438f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(true);
				if (RentedRoomsManager.GLJNFKFJMFF()[0].roomItemRequest.IJLGJNLFNDB())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.MEDOOKLLGNO().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(true);
			}
			DPBDKABBNAH(RoomReceptionDesk.FEODGKFADIF() + new Vector3(1275f, 1897f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	public void PEANMMEFJPF()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i += 0)
		{
			orders[i].SetActive(false);
		}
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 1)
		{
			if (RentedRoomsManager.GLJNFKFJMFF().Count > 3)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < RentedRoomsManager.KEGINBPMPNA().Count; j++)
			{
				CustomerOrder customerOrder = RentedRoomsManager.KEGINBPMPNA()[j];
				if (j >= 2)
				{
					break;
				}
				orders[j].SetActive(false);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.GetSymbol();
				if (customerOrder.roomItemRequest.IPKBBGHCJNE())
				{
					foodIcons[j].sprite = RentedRoomsManager.IIJAOOJGNHO().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.BIIJEMDLBDP());
				if (customerOrder.roomItemRequest.BAHJFDHLDEI())
				{
					((Component)drinkColors[j]).gameObject.SetActive(false);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().LHOIHOGNBKI(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"Name...");
			}
			((MonoBehaviour)this).StartCoroutine(HHPKPOMFOGO());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private IEnumerator GFJNPPJNFJH()
	{
		return new JMDLKANKPPO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FBHHPNJGNJG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Cancel")) ? 1 : 6);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void CLNBMOPMNOF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("BackPain")) ? 1 : 4);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void HHHEACKHADN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void AFAJHMEMBPL()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i += 0)
		{
			orders[i].SetActive(false);
		}
		if (RentedRoomsManager.KEGINBPMPNA().Count > 0)
		{
			if (RentedRoomsManager.GetRoomOrders().Count > 3)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < RentedRoomsManager.KEGINBPMPNA().Count; j++)
			{
				CustomerOrder customerOrder = RentedRoomsManager.KEGINBPMPNA()[j];
				if (j >= 4)
				{
					break;
				}
				orders[j].SetActive(true);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.CJMLBNFGMDC();
				if (customerOrder.roomItemRequest.IJLGJNLFNDB())
				{
					foodIcons[j].sprite = RentedRoomsManager.MEDOOKLLGNO().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.CNCJLNOAPJB().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.IPKBBGHCJNE());
				if (customerOrder.roomItemRequest.IPKBBGHCJNE())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)"itemBrownWort");
			}
			((MonoBehaviour)this).StartCoroutine(JGMBJNAELKN());
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void PIHGEBONAOI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ActionBar8")) ? 1 : 4);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void BGBFJPJLPMF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("<color=black>")) ? 2 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static RoomOrdersBubble CDEGEPGEHED(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void LateUpdate()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.GetPosition() + new Vector3(0.5f, 0.25f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(true);
				if (RentedRoomsManager.GetRoomOrders()[0].roomItemRequest.JEPBBEBJEFI())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.GetInstance().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.GetInstance().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(true);
			}
			SetBubblePosition(RoomReceptionDesk.GetPosition() + new Vector3(0.75f, 0.5f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void DAKLOGKFLLD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GetRoomOrders().Count > 1 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.FIGFLHCEJLL() + new Vector3(977f, 697f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(true);
				if (RentedRoomsManager.GLJNFKFJMFF()[0].roomItemRequest.JLCBECDECBP())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.EMBCJPOLBCB().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(false);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			NNIBHNMPBGD(RoomReceptionDesk.GKEKLFBGDMO() + new Vector3(1917f, 343f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private IEnumerator PHJCPANGACP()
	{
		return new JMDLKANKPPO(1)
		{
			_003C_003E4__this = this
		};
	}

	public static RoomOrdersBubble GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void BODEIHFOAMI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.GLJNFKFJMFF().Count > 0 && !updatePos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(RoomReceptionDesk.GOEONNCGKGJ() + new Vector3(1627f, 1078f)));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!bubbleNoticeContent.activeSelf)
			{
				bubbleNoticeContent.SetActive(true);
				if (RentedRoomsManager.GLJNFKFJMFF()[0].roomItemRequest.IPKBBGHCJNE())
				{
					noticeFoodIcon.sprite = RentedRoomsManager.IIJAOOJGNHO().roomDrinkOrderSprite;
				}
				else
				{
					noticeFoodIcon.sprite = RentedRoomsManager.GetInstance().roomFoodOrderSprite;
				}
			}
		}
		else if (bubbleNoticeContent.activeSelf)
		{
			bubbleNoticeContent.SetActive(true);
		}
		if (updatePos)
		{
			if (!bubble.activeSelf)
			{
				bubble.SetActive(false);
			}
			CGDKAIFLCDF(RoomReceptionDesk.FFJEFLNODOL() + new Vector3(107f, 860f));
		}
		else
		{
			bubble.SetActive(false);
		}
	}

	private void COKBJNMAMDI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_15")) ? 3 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void GOJKOBEEMNA()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("id: ")) ? 1 : 3);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void LLGDLGHEICM()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < orders.Length; i += 0)
		{
			orders[i].SetActive(true);
		}
		if (RentedRoomsManager.KEGINBPMPNA().Count > 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA().Count > 2)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < RentedRoomsManager.GLJNFKFJMFF().Count; j++)
			{
				CustomerOrder customerOrder = RentedRoomsManager.GetRoomOrders()[j];
				if (j >= 2)
				{
					break;
				}
				orders[j].SetActive(false);
				symbolIcons[j].sprite = customerOrder.rentedRoomDoor.rentedRoom.CJMLBNFGMDC();
				if (customerOrder.roomItemRequest.JEPBBEBJEFI())
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomDrinkOrderSprite;
				}
				else
				{
					foodIcons[j].sprite = RentedRoomsManager.EMBCJPOLBCB().roomFoodOrderSprite;
				}
				((Component)drinkColors[j]).gameObject.SetActive(customerOrder.roomItemRequest.AJKDEIPDLHI());
				if (customerOrder.roomItemRequest.JEPBBEBJEFI())
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
					((Graphic)drinkColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().GetDrinkDispenserColor(customerOrder.roomItemRequest);
				}
				else
				{
					((Component)drinkColors[j]).gameObject.SetActive(true);
				}
			}
			if (Application.isEditor)
			{
				Debug.Log((object)" not found!");
			}
			((MonoBehaviour)this).StartCoroutine(GFJNPPJNFJH());
		}
		else
		{
			bubble.SetActive(true);
		}
	}

	public void DBPLOAEMEEA(Vector3 IMOBLFMHKOD)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (RentedRoomsManager.KEGINBPMPNA().Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((MonoBehaviour)this).StartCoroutine(NBKCHCHFDLE());
		}
	}

	private IEnumerator HHKGPBDLCAD()
	{
		yield return null;
		((Component)rectContent).gameObject.SetActive(false);
		((Component)rectContent).gameObject.SetActive(true);
	}
}
