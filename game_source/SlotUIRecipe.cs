using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotUIRecipe : SlotUI
{
	public Action<int, Slot, int> OnOptionSlotClicked = delegate
	{
	};

	private bool ACJFIEKCKEC = true;

	public GameObject redBox;

	[SerializeField]
	private Image imageSlotUI;

	[SerializeField]
	private Sprite[] spriteSlotUI;

	[SerializeField]
	private TextMeshProUGUI totalNumTextMesh;

	public bool FBBAFPGFLPE
	{
		get
		{
			return ACJFIEKCKEC;
		}
		set
		{
			ACJFIEKCKEC = value;
			if (Object.op_Implicit((Object)(object)redBox))
			{
				redBox.SetActive(!ACJFIEKCKEC);
			}
			if ((Object)(object)imageSlotUI != (Object)null)
			{
				if (ACJFIEKCKEC)
				{
					imageSlotUI.sprite = spriteSlotUI[0];
				}
				else
				{
					imageSlotUI.sprite = spriteSlotUI[1];
				}
			}
		}
	}

	public int FJCPBOFOGCO
	{
		set
		{
			if (!((Object)(object)totalNumTextMesh != (Object)null))
			{
				return;
			}
			if (value > 1)
			{
				if (!((Component)totalNumTextMesh).gameObject.activeSelf)
				{
					((Component)totalNumTextMesh).gameObject.SetActive(true);
				}
				((TMP_Text)totalNumTextMesh).text = value.ToString();
			}
			else if (((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	public void PKGGEIJGCDC(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public void KBHDAKNMHLL(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	[SpecialName]
	public void IIILBODPHHM(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public bool FHIHGNGGCAO()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void DODOLIHJEOP(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	public void BLKECMGLGEP(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void DOLNNNCALKE(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public bool AJJDDOEMCKM()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool IBPCKMKKDHA()
	{
		return ACJFIEKCKEC;
	}

	public void BPEHFIHJGAM(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public override void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			FillTooltip(JIIGOACEIKL);
			EGHPILDBOIB(NKFPJPCFBJI: true, JIIGOACEIKL);
		}
	}

	[SpecialName]
	public void FAPLKCKIOJM(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	[SpecialName]
	public void PBBMFMDIAJB(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	[SpecialName]
	public void LHFALNBMCIE(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public void AAGLAEIKHHC(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	protected override void Awake()
	{
		base.Awake();
		if ((Object)(object)totalNumTextMesh != (Object)null && ((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public void CKDEBFGEECF(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public bool JOHDHJENIKM()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool IIOCPHMLOJI()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool DOBGAIIFPIP()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void IDLMINDJBLH(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public bool BJACKAFILNL()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void GLBKFPCMIFL(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public bool IBLMNKFOHNP()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void LMBGBHAAODM(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	public void AOAPDGNBJLL(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void MGNPDPNCOPN(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	public void GHIJIDJCIEL(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public override void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EGHPILDBOIB(NKFPJPCFBJI: false, JIIGOACEIKL);
			EndHover();
		}
	}

	[SpecialName]
	public bool LCMJLKGFHNL()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool PJLJOHLLHHE()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool AKGLBGFJPKB()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void FEBIKPICADP(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public bool CNKBPIGPGNN()
	{
		return ACJFIEKCKEC;
	}

	public void OECMEMBLCPA(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public bool BCIOCDCHCBC()
	{
		return ACJFIEKCKEC;
	}

	public void FDKEHDGFBLP(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public bool OBAHMKHGKNJ()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void PCPBLEBJHAE(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public void DHFIIFNMAOI(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	[SpecialName]
	public void PEEFNLGEJEP(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	public void MFNHALOGJCF(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void IAAEKKLNMEJ(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	public void KPLNADBAJNI(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void CODNPKFLBFE(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void HNJAHDKEINH(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void PFPJGKCNOMO(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void MNAPPOGFFJA(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	public void LLOPKLNEIMF(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void HDPGAKKLPHA(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void OEFBCEIPHAP(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void CCKGNKFFDKH(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	[SpecialName]
	public void BCPDPLLNAOI(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public void HOKAPNACGAJ(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public void BHMAEAOBAMN(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public void AJFBIMGOHFB(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(true);
		}
	}

	public void FMPLKLLNMIG(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void IBOMMJEAFLH(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public bool MFEINDJCFFP()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool MKFOPIOBBNO()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void JLEGLPHCNIC(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(true);
		}
	}

	public void ADODPNJINMB(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public bool CGFOADDAKLM()
	{
		return ACJFIEKCKEC;
	}

	public void BBHEHFKDJFG(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public bool FAFPMOCIADJ()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public bool IDLDGHKCNHK()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void ILAPPCGNBMP(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	public void HKIBGCEBIIG(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void JJLCAPLAEFI(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	[SpecialName]
	public void FMEKDKEMBMN(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public void ACLCGMPDEAL(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(!ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}

	[SpecialName]
	public void MAABIHHANOJ(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public void DGHHBLAHJGK(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	public void LKPCBHJNDFH(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void CJMGGPAAMEF(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void HDPFNEAFCBP(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public bool LMAGGALKHDG()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void BAMOIPLOAMC(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public void FMGJBFNGNGM(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 1)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(false);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	public void DBMKKIANDHN(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void MEHDONKCEOL(int AODONKKHPBP)
	{
		if (!((Object)(object)totalNumTextMesh != (Object)null))
		{
			return;
		}
		if (AODONKKHPBP > 0)
		{
			if (!((Component)totalNumTextMesh).gameObject.activeSelf)
			{
				((Component)totalNumTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)totalNumTextMesh).text = AODONKKHPBP.ToString();
		}
		else if (((Component)totalNumTextMesh).gameObject.activeSelf)
		{
			((Component)totalNumTextMesh).gameObject.SetActive(false);
		}
	}

	public void ANJHLKFEMFL(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void LAACPDGHGHG(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public bool KHJHPBKNFBD()
	{
		return ACJFIEKCKEC;
	}

	public void RecipeClicked(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	public void NOIMKHGGPPH(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public bool MMHJJOHAGLB()
	{
		return ACJFIEKCKEC;
	}

	[SpecialName]
	public void GMKEFJHNCPP(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[1];
			}
		}
	}

	public void ENDFAAHENAM(int DLFEEPMHFHM)
	{
		OnOptionSlotClicked(JIIGOACEIKL, base.IHENCGDNPBL, DLFEEPMHFHM);
	}

	[SpecialName]
	public void DMLDKKELFOJ(bool AODONKKHPBP)
	{
		ACJFIEKCKEC = AODONKKHPBP;
		if (Object.op_Implicit((Object)(object)redBox))
		{
			redBox.SetActive(ACJFIEKCKEC);
		}
		if ((Object)(object)imageSlotUI != (Object)null)
		{
			if (ACJFIEKCKEC)
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
			else
			{
				imageSlotUI.sprite = spriteSlotUI[0];
			}
		}
	}
}
