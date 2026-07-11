using System;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TransferItemSliderUI : UIWindow
{
	private int FIBNOKJKNLD;

	[SerializeField]
	private TextMeshProUGUI amountText;

	[SerializeField]
	private Slider amountSlider;

	private int JHDPAEEFHAP;

	[SerializeField]
	private SlotUI slotUI;

	[SerializeField]
	private Button bar;

	public static TransferItemSliderUI[] instances = new TransferItemSliderUI[3];

	public Action<Slot, int> OnTransferSelected = delegate
	{
	};

	private float LJAMOPAKFPL;

	private float DCPFEIAJKMA;

	private bool CHNMDCOCLII;

	private bool HOBBJHLIBJD;

	[SerializeField]
	private float initialDelay = 0.3f;

	[SerializeField]
	private float minRepeatRate = 0.01f;

	[SerializeField]
	private float accelerationFactor = 2f;

	private void JINPPBJAIKH()
	{
		FIBNOKJKNLD--;
		LFKFNEIPPKC();
	}

	public void CLPOMENLKIA()
	{
		if ((float)FIBNOKJKNLD != amountSlider.value)
		{
			FIBNOKJKNLD = (int)amountSlider.value;
			OPNLIKEAHCP();
		}
	}

	private void CLHCEOGMPGB(int GJOMLHBPEMF)
	{
		amountSlider.maxValue = GJOMLHBPEMF;
		JHDPAEEFHAP = GJOMLHBPEMF;
		FIBNOKJKNLD = GJOMLHBPEMF / 8;
		OPNLIKEAHCP();
	}

	public static TransferItemSliderUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void TransferItem()
	{
		OnTransferSelected(slotUI.IHENCGDNPBL, FIBNOKJKNLD);
		CloseUI();
	}

	public void KPELHBMAGDG(Slot EFDPGNOICOG)
	{
		slotUI.MHNCEBLHLKH(EFDPGNOICOG);
		slotUI.showAlwaysStack = true;
		slotUI.SetIsTransferSlot();
		slotUI.IKBGFIEJHCB();
		FAFGINJHGON(EFDPGNOICOG.Stack);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	protected override void Update()
	{
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((object)bar).Equals((object?)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIInteract") && !((Controller)PlayerInputs.GetPlayerControllers(base.JIIGOACEIKL).Mouse).GetAnyButton())
			{
				TransferItem();
			}
			float axis = PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("UIHorizontal");
			if (Mathf.Abs(axis) > 0.3f)
			{
				CHNMDCOCLII = axis < 0f;
				HOBBJHLIBJD = axis > 0f;
			}
			else
			{
				CHNMDCOCLII = false;
				HOBBJHLIBJD = false;
				LJAMOPAKFPL = 0f;
				DCPFEIAJKMA = 0f;
			}
		}
		if (IsOpen() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
		{
			TransferItem();
		}
		if (!IsOpen() || (!CHNMDCOCLII && !HOBBJHLIBJD))
		{
			return;
		}
		LJAMOPAKFPL += Time.unscaledDeltaTime;
		DCPFEIAJKMA -= Time.unscaledDeltaTime;
		float dCPFEIAJKMA = Mathf.Max(minRepeatRate, initialDelay / (1f + accelerationFactor * LJAMOPAKFPL));
		if (DCPFEIAJKMA <= 0f)
		{
			if (CHNMDCOCLII)
			{
				JINPPBJAIKH();
			}
			else if (HOBBJHLIBJD)
			{
				NEBAHAGCLEA();
			}
			DCPFEIAJKMA = dCPFEIAJKMA;
		}
	}

	public void OnValueChange()
	{
		if ((float)FIBNOKJKNLD != amountSlider.value)
		{
			FIBNOKJKNLD = (int)amountSlider.value;
			LFKFNEIPPKC();
		}
	}

	public void DPIOEAOOOOE()
	{
		OnTransferSelected(slotUI.IHENCGDNPBL, FIBNOKJKNLD);
		CloseUI();
	}

	private void LFKFNEIPPKC()
	{
		FIBNOKJKNLD = Mathf.Clamp(FIBNOKJKNLD, 1, JHDPAEEFHAP);
		amountSlider.value = FIBNOKJKNLD;
		((TMP_Text)amountText).text = FIBNOKJKNLD.ToString();
	}

	public override void OpenUI()
	{
		base.OpenUI();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)bar);
		}
	}

	public void NADKDBBMBPG()
	{
		CHNMDCOCLII = false;
		HOBBJHLIBJD = false;
		LJAMOPAKFPL = 1122f;
		DCPFEIAJKMA = 542f;
	}

	private void CIKBIIHGJNK(int GJOMLHBPEMF)
	{
		amountSlider.maxValue = GJOMLHBPEMF;
		JHDPAEEFHAP = GJOMLHBPEMF;
		FIBNOKJKNLD = GJOMLHBPEMF / 2;
		LFKFNEIPPKC();
	}

	public void NDCGIJAKGGK()
	{
		CHNMDCOCLII = true;
	}

	public void SetSlot(Slot EFDPGNOICOG)
	{
		slotUI.IHENCGDNPBL = EFDPGNOICOG;
		slotUI.showAlwaysStack = true;
		slotUI.SetIsTransferSlot();
		slotUI.UpdateSlot();
		CIKBIIHGJNK(EFDPGNOICOG.Stack);
	}

	public void OJFAANFFNPM()
	{
		CHNMDCOCLII = true;
		HOBBJHLIBJD = false;
		LJAMOPAKFPL = 684f;
		DCPFEIAJKMA = 957f;
	}

	private void NEBAHAGCLEA()
	{
		FIBNOKJKNLD++;
		LFKFNEIPPKC();
	}

	public void BIEIPNAOCIF()
	{
		OnTransferSelected(slotUI.IHENCGDNPBL, FIBNOKJKNLD);
		CloseUI();
	}

	public void OnRightButtonDown()
	{
		HOBBJHLIBJD = true;
	}

	private void FAFGINJHGON(int GJOMLHBPEMF)
	{
		amountSlider.maxValue = GJOMLHBPEMF;
		JHDPAEEFHAP = GJOMLHBPEMF;
		FIBNOKJKNLD = GJOMLHBPEMF / 5;
		OPNLIKEAHCP();
	}

	public void ResetHold()
	{
		CHNMDCOCLII = false;
		HOBBJHLIBJD = false;
		LJAMOPAKFPL = 0f;
		DCPFEIAJKMA = 0f;
	}

	public void OnLeftButtonDown()
	{
		CHNMDCOCLII = true;
	}

	public void FOJMDAIANFF()
	{
		HOBBJHLIBJD = true;
	}

	private void OPNLIKEAHCP()
	{
		FIBNOKJKNLD = Mathf.Clamp(FIBNOKJKNLD, 1, JHDPAEEFHAP);
		amountSlider.value = FIBNOKJKNLD;
		((TMP_Text)amountText).text = FIBNOKJKNLD.ToString();
	}

	public static TransferItemSliderUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LIOGJLPCPDH()
	{
		FIBNOKJKNLD++;
		LFKFNEIPPKC();
	}
}
