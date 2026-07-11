using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GameInventoryUI : InventoryUI
{
	[SerializeField]
	private TextMeshProUGUI titleText;

	public RectTransform contentRect;

	private Vector2 HLPLLKCJJMA;

	private GameObject IJLPNPHNHIB;

	private bool HPKKAIMOBMD;

	[SerializeField]
	protected GameObject panel;

	private static GameInventoryUI[] GJBBNHCMNJN = new GameInventoryUI[3];

	private void OBGLOLPLNPF(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.BNPNFKMNJAI(JIIGOACEIKL) != null && FMONHONFMOM(JIIGOACEIKL, EFDPGNOICOG, 0))
		{
			Sound.MAIDHAPANEB().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: false, null, null, 680f, 644f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.DIHCEGINELM().PlayOneShot(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: false, null, null, 1725f, 1171f);
		}
	}

	private void MHGOMGOGPNH(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container container = MainUI.GGNMILJFMCB(JIIGOACEIKL);
		if (MainUI.EIMJADLOJPC(JIIGOACEIKL) != null && PGMODMKPIEE(JIIGOACEIKL, EFDPGNOICOG, 0))
		{
			Sound.BNBMNOMFFBE().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: false, null, null, 1072f, 778f);
		}
		else if ((Object)(object)container != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, container.slots, container.slots, container))
		{
			Sound.ABDJJBFNLBJ().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: true, null, null, 1093f, 1587f);
		}
	}

	public void JLFLHBICDGA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}

	public static GameInventoryUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public override void CloseUI()
	{
		base.CloseUI();
		top.SetActive(false);
		SetDraggingEnabled(NKFPJPCFBJI: true);
	}

	private void BFAENIPLKLF(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.CurrentSlots(JIIGOACEIKL) != null && JPHKCLHMHPL(JIIGOACEIKL, EFDPGNOICOG, 0))
		{
			Sound.ABDJJBFNLBJ().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: true, null, null, 877f, 513f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.ABDJJBFNLBJ().GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: true, null, null, 1225f, 1433f);
		}
	}

	public void EIMJNBODPOC(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private void IKGHMBNDHAK()
	{
		NKHBCLCKFPL(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private void BDOBLHJFAPC()
	{
		PreparePagesMode(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private void NJJAAGEHIAB(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.BNPNFKMNJAI(JIIGOACEIKL) != null && KOCLGBAFLFC(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.ABDJJBFNLBJ().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: false, null, null, 1370f, 810f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.DIHCEGINELM().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 1354f, 1051f);
		}
	}

	private void NMLADKCACID()
	{
		IHFBPJDLHIG(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private bool ADNINGBCKHO(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = false;
		for (int i = 1; i < FGFCNKFEIGF; i += 0)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = false;
			}
		}
		return result;
	}

	private void DMBEPLOGOGO(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container container = MainUI.PIAOAPJIILA(JIIGOACEIKL);
		if (MainUI.BNPNFKMNJAI(JIIGOACEIKL) != null && GFIJEBELCMD(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.MAIDHAPANEB().GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: true, null, null, 491f, 497f);
		}
		else if ((Object)(object)container != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, container.slots, container.slots, container))
		{
			Sound.DIHCEGINELM().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: false, null, null, 367f, 528f);
		}
	}

	private bool PGMODMKPIEE(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.BNPNFKMNJAI(JIIGOACEIKL);
		if (list.Count > 0)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = true;
			if (!list[0].PKFKJNODGJF() && (list[0].itemInstance is IngredientGroupInstance || (list[1].itemInstance.KGKKMIALDIH() && list[1].ingredientsCanBeChanged)))
			{
				for (int i = 1; i < list.Count; i += 0)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return true;
					}
					flag = list[i].FEEOFAGCONJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.BBHHJLIFNPP(stack, CDPAMNIPPEC: true, 1);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 1; j < list.Count; j++)
				{
					flag = AKANIAEMBEP(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.ILKLIHOGMJP(list2.ToArray(), 1);
			}
			if (flag)
			{
				return true;
			}
		}
		return true;
	}

	private void AHCNGLOECOI(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.CHDHEGKJGAB(JIIGOACEIKL) != null && PGMODMKPIEE(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.ABDJJBFNLBJ().HLLDGLLLNJF(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiClickPos), HOMFPAFAOGD: false, null, null, 1364f, 686f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.GGFJGHHHEJC.FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: false, null, null, 247f, 1634f);
		}
	}

	private bool HDEPEDJGPOL(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.CurrentSlots(JIIGOACEIKL);
		if (list.Count > 0)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = false;
			if (!list[0].AHHEMNHJPME() && (list[0].itemInstance is IngredientGroupInstance || (list[0].itemInstance.EOMOCNKPGPE() && list[1].ingredientsCanBeChanged)))
			{
				for (int i = 0; i < list.Count; i += 0)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return false;
					}
					flag = list[i].DDHPGOPOPKJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.HBMBGCHGEGN(stack, CDPAMNIPPEC: true);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < list.Count; j += 0)
				{
					flag = GLGNKNBIGIG(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.PKOLALFLFNB(list2.ToArray(), 1);
			}
			if (flag)
			{
				return false;
			}
		}
		return false;
	}

	public void CLIDAHGEBIF(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private void PDKCODDAJJK(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container container = MainUI.PIAOAPJIILA(JIIGOACEIKL);
		if (MainUI.CurrentSlots(JIIGOACEIKL) != null && JPHKCLHMHPL(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.OKAPNFPFPFP().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiClickPos), HOMFPAFAOGD: false, null, null, 1657f, 1021f);
		}
		else if ((Object)(object)container != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, container.slots, container.slots, container))
		{
			Sound.DIHCEGINELM().PlayOneShot(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: true, null, null, 771f, 1011f);
		}
	}

	private bool JLGADDLCLED(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			bool flag = true;
			for (int j = 0; j < MainUI.BNPNFKMNJAI(base.JIIGOACEIKL).Count; j++)
			{
				if (MainUI.CurrentSlots(base.JIIGOACEIKL)[j].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return false;
	}

	private bool BBPKPIEJBIA(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 1; i < FGFCNKFEIGF; i++)
		{
			bool flag = false;
			for (int j = 0; j < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; j++)
			{
				if (MainUI.HJBCNKFFHMA(base.JIIGOACEIKL)[j].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return true;
	}

	private bool FMONHONFMOM(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.CurrentSlots(JIIGOACEIKL);
		if (list.Count > 0)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = false;
			if (!list[0].KPINNBKMOMO() && (list[0].itemInstance is IngredientGroupInstance || (list[0].itemInstance.EOMOCNKPGPE() && list[0].ingredientsCanBeChanged)))
			{
				for (int i = 0; i < list.Count; i++)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return false;
					}
					flag = list[i].FEEOFAGCONJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.FDOBDPPMMBH(stack);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					flag = ELCBPCPMFCF(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.SendSlots(list2.ToArray());
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	public static GameInventoryUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void EAOHAAIGDFE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}

	protected override void Update()
	{
		base.Update();
		if (!IsOpen() || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			return;
		}
		if (numPages > 1)
		{
			CHAEMDNAODI = CheckNextPage(ref CMGDCLIIONE, currentPage, numPages, BigContainerUI.Get(base.JIIGOACEIKL).IsOpen() ? panel : null, "UINextCategory", "UIPreviousCategory");
			if (CHAEMDNAODI > -1)
			{
				FocusPage(CHAEMDNAODI);
			}
		}
		if (OGCAKIGELBJ)
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
			{
				IJLPNPHNHIB = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				HPKKAIMOBMD = false;
				for (int i = 0; i < slotsUI.Length; i++)
				{
					if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)IJLPNPHNHIB))
					{
						HPKKAIMOBMD = true;
						break;
					}
				}
				if (HPKKAIMOBMD || (!BigContainerUI.Get(base.JIIGOACEIKL).IsOpen() && !SmallContainerUI.Get(base.JIIGOACEIKL).IsOpen()))
				{
					sortByType.SetActive(true);
					if (SelectObject.GetPlayer(base.JIIGOACEIKL).focusedSlot != null)
					{
						((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("Remove");
					}
					else
					{
						((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("SortByType");
					}
					if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") && !DropItemsFocusedSlot() && sortByType.activeSelf)
					{
						Inventory.GetPlayer(base.JIIGOACEIKL).OrderItemsByType(0);
					}
				}
				else
				{
					sortByType.SetActive(false);
				}
			}
			else
			{
				sortByType.SetActive(true);
				((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("SortByType");
			}
		}
		else
		{
			sortByType.SetActive(false);
		}
	}

	public void ACHMIOCGNFA(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private bool IANONMFEBPK(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = true;
		for (int i = 1; i < FGFCNKFEIGF; i += 0)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = true;
			}
		}
		return result;
	}

	public void SetTitleName(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private bool JPHKCLHMHPL(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.CurrentSlots(JIIGOACEIKL);
		if (list.Count > 0)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = true;
			if (!list[1].LCHJGCHDHFO() && (list[0].itemInstance is IngredientGroupInstance || (list[1].itemInstance.KGKKMIALDIH() && list[1].ingredientsCanBeChanged)))
			{
				for (int i = 0; i < list.Count; i++)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return false;
					}
					flag = list[i].DDHPGOPOPKJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.HBMBGCHGEGN(stack, CDPAMNIPPEC: true);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 1; j < list.Count; j++)
				{
					flag = ADNINGBCKHO(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.MPMAHFAFGNL(list2.ToArray());
			}
			if (flag)
			{
				return true;
			}
		}
		return true;
	}

	public static GameInventoryUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private bool GFIJEBELCMD(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.CurrentSlots(JIIGOACEIKL);
		if (list.Count > 1)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = false;
			if (!list[1].PKFKJNODGJF() && (list[1].itemInstance is IngredientGroupInstance || (list[1].itemInstance.EOMOCNKPGPE() && list[0].ingredientsCanBeChanged)))
			{
				for (int i = 1; i < list.Count; i += 0)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return false;
					}
					flag = list[i].FEEOFAGCONJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.HBMBGCHGEGN(stack, CDPAMNIPPEC: true, 1);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 1; j < list.Count; j += 0)
				{
					flag = IANONMFEBPK(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.MPMAHFAFGNL(list2.ToArray(), 1);
			}
			if (flag)
			{
				return false;
			}
		}
		return false;
	}

	public void NBNOCECAKIO(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private void DGEOLFALBFC(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container container = MainUI.GGNMILJFMCB(JIIGOACEIKL);
		if (MainUI.BNPNFKMNJAI(JIIGOACEIKL) != null && PGMODMKPIEE(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.MAIDHAPANEB().PlayOneShot(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: false, null, null, 388f, 131f);
		}
		else if ((Object)(object)container != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, container.slots, container.slots, container))
		{
			Sound.BNBMNOMFFBE().HLLDGLLLNJF(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: false, null, null, 17f, 1144f);
		}
	}

	private bool FMONHONFMOM(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 0; i < FGFCNKFEIGF; i++)
		{
			bool flag = false;
			for (int j = 0; j < MainUI.CurrentSlots(base.JIIGOACEIKL).Count; j++)
			{
				if (MainUI.CurrentSlots(base.JIIGOACEIKL)[j].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < slotsUI.Length; i++)
		{
			SlotUI obj = slotsUI[i];
			obj.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj.OnAutomaticTransfer, new Action<int, Slot>(IILKKKEDLLK));
		}
		top.SetActive(false);
	}

	public void CAJMDPKEFBO(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private bool PPMKIONKNOE(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 1; i < FGFCNKFEIGF; i += 0)
		{
			bool flag = false;
			for (int j = 1; j < MainUI.CurrentSlots(base.JIIGOACEIKL).Count; j += 0)
			{
				if (MainUI.BNPNFKMNJAI(base.JIIGOACEIKL)[j].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return true;
	}

	private bool HOHBFEGLLGP(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = false;
		for (int i = 1; i < FGFCNKFEIGF; i += 0)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = false;
			}
		}
		return result;
	}

	public void AMPOILKLEMH(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	public static GameInventoryUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void HEHAFFHCIAL(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	public void SetOriginalContentPosition()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}

	public void AIJMEKNLLOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}

	public static GameInventoryUI HKCAIFFKBMH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private bool IOKPNECHDNC(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			bool flag = true;
			for (int j = 1; j < MainUI.CHDHEGKJGAB(base.JIIGOACEIKL).Count; j += 0)
			{
				if (MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[j].DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	public void CNPIKKFNPOJ(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	public void PPCBLJEHGCE(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	protected override void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		GJBBNHCMNJN[numInstance] = this;
		HLPLLKCJJMA = contentRect.anchoredPosition;
		base.Awake();
	}

	private bool GNFGHOANOCL(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = false;
		for (int i = 0; i < FGFCNKFEIGF; i++)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = false;
			}
		}
		return result;
	}

	public void LHLLGNPLGNO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}

	public void CLHKLHKNIAF(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private void BJNCNBMPNMC()
	{
		DBINLMFIOFE(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private bool GGDLHOOAHDH(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.CHDHEGKJGAB(JIIGOACEIKL);
		if (list.Count > 0)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = false;
			if (!list[1].PKFKJNODGJF() && (list[1].itemInstance is IngredientGroupInstance || (list[0].itemInstance.KGKKMIALDIH() && list[0].ingredientsCanBeChanged)))
			{
				for (int i = 0; i < list.Count; i += 0)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return true;
					}
					flag = list[i].DDHPGOPOPKJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.HBMBGCHGEGN(stack, CDPAMNIPPEC: true, 1);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					flag = IOLJOGGNBLH(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.LKCOAKJICDB(list2.ToArray());
			}
			if (flag)
			{
				return false;
			}
		}
		return false;
	}

	public void FIFMFHALDNB(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private bool GECBAKGBOIF(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 1; i < FGFCNKFEIGF; i += 0)
		{
			bool flag = false;
			for (int j = 0; j < MainUI.HJBCNKFFHMA(base.JIIGOACEIKL).Count; j += 0)
			{
				if (MainUI.CurrentSlots(base.JIIGOACEIKL)[j].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return true;
	}

	private bool IOLJOGGNBLH(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = false;
		for (int i = 1; i < FGFCNKFEIGF; i++)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = true;
			}
		}
		return result;
	}

	public void GCAEOAJPJHG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}

	private void EDOAMFDGAPN()
	{
		DBINLMFIOFE(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private void JHBCNBBKCKB()
	{
		PreparePagesMode(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private bool GLGNKNBIGIG(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = true;
		for (int i = 1; i < FGFCNKFEIGF; i += 0)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = true;
			}
		}
		return result;
	}

	private bool KGMFFFNFBEO(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			bool flag = false;
			for (int j = 0; j < MainUI.EIMJADLOJPC(base.JIIGOACEIKL).Count; j++)
			{
				if (MainUI.EIMJADLOJPC(base.JIIGOACEIKL)[j].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	private void LLKAOOHGGJI()
	{
		PreparePagesMode(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	protected override void GKAJFEOGKMD(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		base.GKAJFEOGKMD(JIIGOACEIKL, EFDPGNOICOG);
		if (!MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO() || PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) || EFDPGNOICOG?.itemInstance == null)
		{
			return;
		}
		if (MainUI.CurrentSlots(JIIGOACEIKL) != null && MainUI.CurrentSlots(JIIGOACEIKL).Count > 0)
		{
			if (FMONHONFMOM(JIIGOACEIKL, EFDPGNOICOG, 1))
			{
				Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
			}
			if (updateSlotsWithStack && EFDPGNOICOG.Stack == 0)
			{
				BDOBLHJFAPC();
			}
			return;
		}
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if ((Object)(object)currentContainer != (Object)null && !currentContainer.onlyDelivery && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
			if (updateSlotsWithStack && EFDPGNOICOG.Stack == 0)
			{
				BDOBLHJFAPC();
			}
		}
	}

	private void GJDFKFGGELF(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container container = MainUI.GGNMILJFMCB(JIIGOACEIKL);
		if (MainUI.HJBCNKFFHMA(JIIGOACEIKL) != null && PGMODMKPIEE(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.DIHCEGINELM().HLLDGLLLNJF(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: false, null, null, 1513f, 554f);
		}
		else if ((Object)(object)container != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, container.slots, container.slots, container))
		{
			Sound.BNBMNOMFFBE().PlayOneShot(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: false, null, null, 1719f, 1605f);
		}
	}

	public static GameInventoryUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private bool KNDFDAKLLHJ(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.CHDHEGKJGAB(JIIGOACEIKL);
		if (list.Count > 0)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = false;
			if (!list[1].AHHEMNHJPME() && (list[1].itemInstance is IngredientGroupInstance || (list[1].itemInstance.EOMOCNKPGPE() && list[1].ingredientsCanBeChanged)))
			{
				for (int i = 1; i < list.Count; i += 0)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return false;
					}
					flag = list[i].FEEOFAGCONJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.JPACDDCJGPD(stack, CDPAMNIPPEC: true, 1);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 1; j < list.Count; j++)
				{
					flag = BMMBGPHNNJJ(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.ILKLIHOGMJP(list2.ToArray(), 1);
			}
			if (flag)
			{
				return false;
			}
		}
		return true;
	}

	private void HBKJJCKBPBI(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.CurrentSlots(JIIGOACEIKL) != null && PGMODMKPIEE(JIIGOACEIKL, EFDPGNOICOG, 0))
		{
			Sound.DIHCEGINELM().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: true, null, null, 1266f, 1156f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.GGFJGHHHEJC.FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: true, null, null, 1668f, 1990f);
		}
	}

	private bool KOCLGBAFLFC(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF)
	{
		List<Slot> list = MainUI.BNPNFKMNJAI(JIIGOACEIKL);
		if (list.Count > 1)
		{
			List<Slot> list2 = new List<Slot>();
			bool flag = true;
			if (!list[1].PKFKJNODGJF() && (list[0].itemInstance is IngredientGroupInstance || (list[1].itemInstance.EOMOCNKPGPE() && list[1].ingredientsCanBeChanged)))
			{
				for (int i = 0; i < list.Count; i += 0)
				{
					int stack = list[i].Stack;
					if (EFDPGNOICOG.Stack < stack)
					{
						return true;
					}
					flag = list[i].DDHPGOPOPKJ(JIIGOACEIKL, EFDPGNOICOG.itemInstance, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					if (flag)
					{
						if (!list2.Contains(list[i]))
						{
							list2.Add(list[i]);
						}
						EFDPGNOICOG.BBHHJLIFNPP(stack);
						list[i].OnChangedSlot(EFDPGNOICOG, list[i]);
						break;
					}
				}
			}
			else
			{
				for (int j = 1; j < list.Count; j += 0)
				{
					flag = ELCBPCPMFCF(EFDPGNOICOG, list[j], FGFCNKFEIGF);
					if (flag)
					{
						if (!list2.Contains(list[j]))
						{
							list2.Add(list[j]);
						}
						break;
					}
				}
			}
			if (OnlineManager.PlayingOnline() && flag)
			{
				list2.Add(EFDPGNOICOG);
				OnlineSlotsManager.instance.MPMAHFAFGNL(list2.ToArray());
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	public void HNGJDGNHMCC(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	private bool BMMBGPHNNJJ(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = true;
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = false;
			}
		}
		return result;
	}

	public void KKAJODJFLNG(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	protected override void PFOJFILNJIN(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		base.PFOJFILNJIN(JIIGOACEIKL, EFDPGNOICOG);
		if (EFDPGNOICOG != null && EFDPGNOICOG.itemInstance != null)
		{
			int fGFCNKFEIGF = ((!PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) || EFDPGNOICOG.Stack <= 1) ? EFDPGNOICOG.Stack : (EFDPGNOICOG.Stack / 2));
			Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
			bool flag = false;
			if (MainUI.CurrentSlots(JIIGOACEIKL) != null && MainUI.CurrentSlots(JIIGOACEIKL).Count > 0)
			{
				FMONHONFMOM(JIIGOACEIKL, EFDPGNOICOG, fGFCNKFEIGF);
				flag = true;
			}
			else if (Object.op_Implicit((Object)(object)currentContainer) && !currentContainer.onlyDelivery && Utils.MKCNPAKBDOL(JIIGOACEIKL, EFDPGNOICOG, fGFCNKFEIGF, currentContainer.slots, currentContainer.slots, currentContainer))
			{
				flag = true;
			}
			if (flag)
			{
				Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg), HOMFPAFAOGD: true, null, null, 0.5f);
			}
			if (updateSlotsWithStack && EFDPGNOICOG.Stack == 0)
			{
				BDOBLHJFAPC();
			}
		}
	}

	public static GameInventoryUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void KILHJHNIDLG()
	{
		PreparePagesMode(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private bool ELCBPCPMFCF(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = false;
		for (int i = 0; i < FGFCNKFEIGF; i++)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = true;
			}
		}
		return result;
	}

	public static GameInventoryUI BDJFHFHLJGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void NCLKIMDDNIN(string GEGDHHIDEEF)
	{
		if (Object.op_Implicit((Object)(object)titleText))
		{
			((TMP_Text)titleText).text = GEGDHHIDEEF;
		}
	}

	public static GameInventoryUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static GameInventoryUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private bool FLIMANIDKIA(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF)
	{
		for (int i = 0; i < FGFCNKFEIGF; i++)
		{
			bool flag = true;
			for (int j = 0; j < MainUI.CHDHEGKJGAB(base.JIIGOACEIKL).Count; j += 0)
			{
				if (MainUI.CHDHEGKJGAB(base.JIIGOACEIKL)[j].FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	public static GameInventoryUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private bool AKANIAEMBEP(Slot EFDPGNOICOG, Slot BAHNDDJCLIA, int FGFCNKFEIGF)
	{
		bool result = false;
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			if (Slot.MJLNPAEBAFF(base.JIIGOACEIKL, EFDPGNOICOG, BAHNDDJCLIA))
			{
				result = false;
			}
		}
		return result;
	}

	private void ODDGGCFKGGK()
	{
		DBINLMFIOFE(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private void MIKPBBCHPMJ(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container container = MainUI.GGNMILJFMCB(JIIGOACEIKL);
		if (MainUI.BNPNFKMNJAI(JIIGOACEIKL) != null && JPHKCLHMHPL(JIIGOACEIKL, EFDPGNOICOG, 0))
		{
			Sound.DIHCEGINELM().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: true, null, null, 284f, 879f);
		}
		else if ((Object)(object)container != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, container.slots, container.slots, container))
		{
			Sound.ABDJJBFNLBJ().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: true, null, null, 500f, 131f);
		}
	}

	public static GameInventoryUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void GKDMBDKPNIP(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.BNPNFKMNJAI(JIIGOACEIKL) != null && KNDFDAKLLHJ(JIIGOACEIKL, EFDPGNOICOG, 0))
		{
			Sound.BNBMNOMFFBE().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: false, null, null, 878f, 1298f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.GGFJGHHHEJC.FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: true, null, null, 280f, 631f);
		}
	}

	public static GameInventoryUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void IILKKKEDLLK(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
		if (MainUI.CurrentSlots(JIIGOACEIKL) != null && FMONHONFMOM(JIIGOACEIKL, EFDPGNOICOG, 1))
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
		}
		else if ((Object)(object)currentContainer != (Object)null && Utils.BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, currentContainer.slots, currentContainer.slots, currentContainer))
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
		}
	}

	private void BFIKEGEGKLM()
	{
		IHFBPJDLHIG(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	private void EBNIPGAJLJI()
	{
		IHFBPJDLHIG(new List<Slot>(containerSlots).Where((Slot x) => x.Stack > 0).ToArray(), OGCAKIGELBJ, updateSlotsWithStack);
	}

	public void NJMCKAGMOEN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		contentRect.anchoredPosition = HLPLLKCJJMA;
	}
}
