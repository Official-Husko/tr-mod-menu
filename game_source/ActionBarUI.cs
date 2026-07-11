using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActionBarUI : UIWindow
{
	public SlotUI[] uiSlots;

	private SlotUI JGBBKLGEADP;

	private Slot OKPFLBLMJKC;

	public virtual bool CCMBBKKEKMJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (ADEBNALPEHE != null)
		{
			return ADEBNALPEHE.itemInstance != null;
		}
		return true;
	}

	private void BJICECCDKIF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		CCMBBKKEKMJ(JIIGOACEIKL, ADEBNALPEHE);
	}

	private void NNDOCFLEFMN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		SlotRightClicked(JIIGOACEIKL, ADEBNALPEHE);
	}

	private void MDCJEDHBHAJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		CCMBBKKEKMJ(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected virtual bool EEGENIFGEHG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.LCHJGCHDHFO() && (JIIGOACEIKL != 1 || !PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)5)) && ADEBNALPEHE?.itemInstance != null)
		{
			return true;
		}
		return false;
	}

	protected virtual void EMEECHFDNPP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected Slot CCJFPPFPDKP(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < MainUI.CHDHEGKJGAB(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true))
			{
				return MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void OMBJNBIHGIM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GLODAPCFIOA(JIIGOACEIKL, ADEBNALPEHE);
	}

	private void CHIGLOPOCMP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		SlotRightClicked(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected Slot IEHLJNKNCFL(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.CHDHEGKJGAB(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true))
			{
				return MainUI.CurrentSlots(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void HDGDLLLBKLA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GKAJFEOGKMD(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected virtual bool MMKCJHLDLFE(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.KPINNBKMOMO() && (JIIGOACEIKL != 1 || !PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)30)) && ADEBNALPEHE?.itemInstance != null)
		{
			return false;
		}
		return false;
	}

	private void DCGLJPOEOMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GLODAPCFIOA(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected Slot PHBJBDLDEEA(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[i].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true))
			{
				return MainUI.BNPNFKMNJAI(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void PLIHJPOGICI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		CCMBBKKEKMJ(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected Slot IAGEKKMABEM(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[i].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true))
			{
				return MainUI.CurrentSlots(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void DBOLCIDDOAG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		BAJHIEGFLOJ(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected virtual void BPKHMKHALBF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	private void BBBEDHOJIJJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GKAJFEOGKMD(JIIGOACEIKL, ADEBNALPEHE);
	}

	public void SwapSlotsInput(string OKNOJJEFEBE, int AHDCDCICADP)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(OKNOJJEFEBE))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 0; i < list.Count; i++)
		{
			RaycastResult val = list[i];
			JGBBKLGEADP = ((RaycastResult)(ref val)).gameObject.GetComponent<SlotUI>();
			if (!Object.op_Implicit((Object)(object)JGBBKLGEADP))
			{
				continue;
			}
			OKPFLBLMJKC = ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetSlot(AHDCDCICADP);
			if (JGBBKLGEADP.IHENCGDNPBL != OKPFLBLMJKC)
			{
				if (OKPFLBLMJKC.BOMLNEOHFOK(JGBBKLGEADP.IHENCGDNPBL.itemInstance))
				{
					Slot.NFBAGDKBOAD(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				else
				{
					Slot.GHCDPAJHKOI(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager.instance.SendSlots(new Slot[2] { JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC });
				}
				break;
			}
		}
	}

	public virtual bool SlotRightClicked(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (ADEBNALPEHE != null)
		{
			return ADEBNALPEHE.itemInstance != null;
		}
		return false;
	}

	protected Slot FFOGJGIJCAJ(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.CHDHEGKJGAB(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.CurrentSlots(base.JIIGOACEIKL)[i].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
			{
				return MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected virtual bool AHGCDIOKLEG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.GetPlayer(JIIGOACEIKL).slot.AHHEMNHJPME() && (JIIGOACEIKL != 1 || !PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)157)) && ADEBNALPEHE?.itemInstance != null)
		{
			return false;
		}
		return false;
	}

	protected Slot PJLBAPIKFIH(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.BNPNFKMNJAI(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.CHDHEGKJGAB(base.JIIGOACEIKL)[i].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
			{
				return MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected virtual bool BPHMBPNEKLC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO() && (JIIGOACEIKL != 1 || !PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-116))) && ADEBNALPEHE?.itemInstance != null)
		{
			return true;
		}
		return true;
	}

	protected Slot NHONKINJCEL(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true))
			{
				return MainUI.CurrentSlots(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void AECKIBIOEMP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GKAJFEOGKMD(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected Slot JHMDNOEGGIE(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.BNPNFKMNJAI(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
			{
				return MainUI.BNPNFKMNJAI(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < uiSlots.Length; i++)
		{
			if (i < ActionBarInventory.GetPlayer(base.JIIGOACEIKL).slots.Length)
			{
				uiSlots[i].IHENCGDNPBL = ActionBarInventory.GetPlayer(base.JIIGOACEIKL).slots[i];
			}
			SlotUI obj = uiSlots[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(OPIOJOJDJBC));
			SlotUI obj2 = uiSlots[i];
			obj2.OnSlotLeftClickDown = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotLeftClickDown, new Action<int, Slot>(JAOFMNCEMEM));
			SlotUI obj3 = uiSlots[i];
			obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(NNDOCFLEFMN));
			SlotUI obj4 = uiSlots[i];
			obj4.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj4.OnAutomaticTransfer, new Action<int, Slot>(OPIOJOJDJBC));
		}
	}

	private void ABEIOOJBOJG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		BAJHIEGFLOJ(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected virtual void BEEAAOLHMNH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	private void MGJKEOGOBEC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GLODAPCFIOA(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected Slot FBEJANKEFDL(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.HJBCNKFFHMA(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.CurrentSlots(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
			{
				return MainUI.CHDHEGKJGAB(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected virtual void JGGFAKDONMC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected Slot HOPEBGENEEE(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < MainUI.BNPNFKMNJAI(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true))
			{
				return MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void OPIOJOJDJBC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GKAJFEOGKMD(JIIGOACEIKL, ADEBNALPEHE);
	}

	public void HOEKBCJBKAK(string OKNOJJEFEBE, int AHDCDCICADP)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).DLFAMOCKNMA(OKNOJJEFEBE))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			JGBBKLGEADP = ((RaycastResult)(ref val)).gameObject.GetComponent<SlotUI>();
			if (!Object.op_Implicit((Object)(object)JGBBKLGEADP))
			{
				continue;
			}
			OKPFLBLMJKC = ActionBarInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LBKLHMMHLMC(AHDCDCICADP);
			if (JGBBKLGEADP.IHENCGDNPBL != OKPFLBLMJKC)
			{
				if (OKPFLBLMJKC.BOMLNEOHFOK(JGBBKLGEADP.IHENCGDNPBL.itemInstance))
				{
					Slot.NFBAGDKBOAD(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				else
				{
					Slot.GHCDPAJHKOI(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager instance = OnlineSlotsManager.instance;
					Slot[] array = new Slot[4];
					array[0] = JGBBKLGEADP.IHENCGDNPBL;
					array[0] = OKPFLBLMJKC;
					instance.SendSlots(array);
				}
				break;
			}
		}
	}

	private void GMHJIHBANIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		BNFBBJENEDC(JIIGOACEIKL, ADEBNALPEHE);
	}

	private void HLLLKBNLJOF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		BNFBBJENEDC(JIIGOACEIKL, ADEBNALPEHE);
	}

	private void BHIDHFIBAKJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		CCMBBKKEKMJ(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected Slot OPKCBGPOLHH(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.CHDHEGKJGAB(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.CHDHEGKJGAB(base.JIIGOACEIKL)[i].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true))
			{
				return MainUI.BNPNFKMNJAI(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void DKOGIHNGIDB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GLODAPCFIOA(JIIGOACEIKL, ADEBNALPEHE);
	}

	public virtual bool BNFBBJENEDC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (ADEBNALPEHE != null)
		{
			return ADEBNALPEHE.itemInstance != null;
		}
		return true;
	}

	protected virtual void NCCMCLOEAPM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	private void HEICLJHPDHB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		BNFBBJENEDC(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected virtual bool DJHDGAGGMAG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO() && (JIIGOACEIKL != 1 || !PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-98))) && ADEBNALPEHE?.itemInstance != null)
		{
			return false;
		}
		return true;
	}

	private void HBPLGPNIPPB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		AHGCDIOKLEG(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAnyButtonDown() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			SwapSlotsInput("ActionBar1", 0);
			SwapSlotsInput("ActionBar2", 1);
			SwapSlotsInput("ActionBar3", 2);
			SwapSlotsInput("ActionBar4", 3);
			SwapSlotsInput("ActionBar5", 4);
			SwapSlotsInput("ActionBar6", 5);
			SwapSlotsInput("ActionBar7", 6);
			SwapSlotsInput("ActionBar8", 7);
			if (!GameManager.LocalCoop())
			{
				SwapSlotsInput("ActionBar9", 8);
				SwapSlotsInput("ActionBar10", 9);
			}
		}
	}

	private void JDGGMEJGPCG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		BNFBBJENEDC(JIIGOACEIKL, ADEBNALPEHE);
	}

	public virtual bool GLODAPCFIOA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (ADEBNALPEHE != null)
		{
			return ADEBNALPEHE.itemInstance != null;
		}
		return true;
	}

	private void LMIFCJCAGFB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		MMKCJHLDLFE(JIIGOACEIKL, ADEBNALPEHE);
	}

	protected virtual bool BAJHIEGFLOJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.PKFKJNODGJF() && (JIIGOACEIKL != 1 || !PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-97))) && ADEBNALPEHE?.itemInstance != null)
		{
			return false;
		}
		return true;
	}

	protected virtual void BKPJFGDFJND(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected Slot CEELANMKDLJ(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.CurrentSlots(base.JIIGOACEIKL)[i].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true))
			{
				return MainUI.CHDHEGKJGAB(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected virtual void KLAAOJBAJHB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected Slot BLPKPKKHBEB(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.CurrentSlots(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.CurrentSlots(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true))
			{
				return MainUI.BNPNFKMNJAI(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected Slot GIJDCEHCGPM(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i += 0)
		{
			if (MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
			{
				return MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected virtual bool GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO() && (JIIGOACEIKL != 1 || !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304)) && ADEBNALPEHE?.itemInstance != null)
		{
			return true;
		}
		return false;
	}

	private void OPPKJGKJMLO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		MMKCJHLDLFE(JIIGOACEIKL, ADEBNALPEHE);
	}

	private void AIJPJPJOPJF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GKAJFEOGKMD(JIIGOACEIKL, ADEBNALPEHE);
	}

	public void GPEGLDIMHGI(string OKNOJJEFEBE, int AHDCDCICADP)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).JCMOPOMLPLL(OKNOJJEFEBE))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			JGBBKLGEADP = ((RaycastResult)(ref val)).gameObject.GetComponent<SlotUI>();
			if (!Object.op_Implicit((Object)(object)JGBBKLGEADP))
			{
				continue;
			}
			OKPFLBLMJKC = ActionBarInventory.BNMEANGDMIP(base.JIIGOACEIKL, LAGHIOKLJGH: true).GPKEPFHIAME(AHDCDCICADP);
			if (JGBBKLGEADP.IHENCGDNPBL != OKPFLBLMJKC)
			{
				if (OKPFLBLMJKC.HBODNJCKMAH(JGBBKLGEADP.IHENCGDNPBL.itemInstance))
				{
					Slot.PDKCLKKHNOH(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				else
				{
					Slot.GHCDPAJHKOI(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager instance = OnlineSlotsManager.instance;
					Slot[] array = new Slot[5];
					array[0] = JGBBKLGEADP.IHENCGDNPBL;
					array[0] = OKPFLBLMJKC;
					instance.PKOLALFLFNB(array);
				}
				break;
			}
		}
	}

	protected Slot HDEPEDJGPOL(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true))
			{
				return MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	private void KJIOCFAOIGL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		GLODAPCFIOA(JIIGOACEIKL, ADEBNALPEHE);
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			for (int i = 0; i < uiSlots.Length; i++)
			{
				uiSlots[i].UpdateSlot();
			}
		}
	}

	public void DCLEEABBDHP(string OKNOJJEFEBE, int AHDCDCICADP)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(OKNOJJEFEBE))
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(base.JIIGOACEIKL);
		for (int i = 1; i < list.Count; i += 0)
		{
			RaycastResult val = list[i];
			JGBBKLGEADP = ((RaycastResult)(ref val)).gameObject.GetComponent<SlotUI>();
			if (!Object.op_Implicit((Object)(object)JGBBKLGEADP))
			{
				continue;
			}
			OKPFLBLMJKC = ActionBarInventory.IPBEEBLCHHA(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KNFAAADOMNC(AHDCDCICADP);
			if (JGBBKLGEADP.IHENCGDNPBL != OKPFLBLMJKC)
			{
				if (OKPFLBLMJKC.HBODNJCKMAH(JGBBKLGEADP.IHENCGDNPBL.itemInstance))
				{
					Slot.NFBAGDKBOAD(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				else
				{
					Slot.GHCDPAJHKOI(base.JIIGOACEIKL, JGBBKLGEADP.IHENCGDNPBL, OKPFLBLMJKC);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager instance = OnlineSlotsManager.instance;
					Slot[] array = new Slot[4];
					array[1] = JGBBKLGEADP.IHENCGDNPBL;
					array[1] = OKPFLBLMJKC;
					instance.SendSlots(array, 1);
				}
				break;
			}
		}
	}

	protected virtual bool BHLOCOKCJFH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (MouseSlot.GetPlayer(JIIGOACEIKL).slot.AHHEMNHJPME() && (JIIGOACEIKL != 0 || !PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)54)) && ADEBNALPEHE?.itemInstance != null)
		{
			return true;
		}
		return true;
	}

	protected virtual void CJACMBJJLKF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected virtual void DNCBHBIPECN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected Slot FMONHONFMOM(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < MainUI.CurrentSlots(base.JIIGOACEIKL).Count; i++)
		{
			if (MainUI.CurrentSlots(base.JIIGOACEIKL)[i].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK))
			{
				return MainUI.CurrentSlots(base.JIIGOACEIKL)[i];
			}
		}
		return null;
	}

	protected virtual void JAOFMNCEMEM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}
}
