using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SlotUIOrder : SlotUI
{
	[SerializeField]
	private Slot orderSlot;

	public Slot DLOJCEAJBLF
	{
		get
		{
			return orderSlot;
		}
		set
		{
			if (orderSlot != null)
			{
				Slot obj = orderSlot;
				obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
			}
			orderSlot = value;
			if (orderSlot != null)
			{
				Slot obj2 = orderSlot;
				obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(UpdateSlot));
			}
			UpdateSlot();
		}
	}

	[SpecialName]
	public void COAFDCLHHOD(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(UpdateSlot));
		}
		PAMDPKDMLGC();
	}

	[SpecialName]
	public Slot NCNHGCCNAPN()
	{
		return orderSlot;
	}

	[SpecialName]
	public void OCJDHEIGELB(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PAMDPKDMLGC));
		}
		JOGLJKIFGNL();
	}

	[SpecialName]
	public void MBINJHIDBNJ(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PDPFLAKIMKL));
		}
		UpdateSlot();
	}

	[SpecialName]
	public Slot FFBKOLFOLLJ()
	{
		return orderSlot;
	}

	[SpecialName]
	public void CNKDKNEFNCA(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(JOGLJKIFGNL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(UpdateSlot));
		}
		JOGLJKIFGNL();
	}

	[SpecialName]
	public void OEFLHGOMGEO(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(JOGLJKIFGNL));
		}
		IKBGFIEJHCB();
	}

	[SpecialName]
	public void PPLDLDLADAM(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(IKBGFIEJHCB));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		JOGLJKIFGNL();
	}

	[SpecialName]
	public void MMJBKFIHPND(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PDPFLAKIMKL));
		}
		UpdateSlot();
	}

	[SpecialName]
	public Slot AGPLJJPAPEN()
	{
		return orderSlot;
	}

	[SpecialName]
	public void PFPGFNBOKAI(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(IKBGFIEJHCB));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(JOGLJKIFGNL));
		}
		IKBGFIEJHCB();
	}

	[SpecialName]
	public void OKOPPBKPINB(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		IKBGFIEJHCB();
	}

	public override void UpdateSlot()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (base.IHENCGDNPBL.KPINNBKMOMO() && !DLOJCEAJBLF.KPINNBKMOMO())
		{
			GJDPLEIAEBH(DLOJCEAJBLF);
			((Graphic)stackText).color = Color.white;
		}
		else
		{
			base.UpdateSlot();
		}
	}

	protected override void Awake()
	{
		if (!JGNIDGOOLNC)
		{
			DLOJCEAJBLF = orderSlot;
		}
		base.Awake();
	}

	[SpecialName]
	public Slot DLIGPCILPFG()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot OBILHJCALAO()
	{
		return orderSlot;
	}

	[SpecialName]
	public void JMIIKGIBJMM(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(IKBGFIEJHCB));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		IKBGFIEJHCB();
	}

	[SpecialName]
	public void EHFFPIFCFDK(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(JOGLJKIFGNL));
		}
		IKBGFIEJHCB();
	}

	[SpecialName]
	public void ENAMCPKEKPI(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PAMDPKDMLGC));
		}
		UpdateSlot();
	}

	[SpecialName]
	public void DIDNLKICIKC(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(JOGLJKIFGNL));
		}
		UpdateSlot();
	}

	[SpecialName]
	public Slot CJPNKJGMFOK()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot PNLIILHMIFP()
	{
		return orderSlot;
	}

	[SpecialName]
	public void CCCMPFHMMLJ(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(JOGLJKIFGNL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PAMDPKDMLGC));
		}
		JOGLJKIFGNL();
	}

	[SpecialName]
	public void NOCDOOOKCHC(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		JOGLJKIFGNL();
	}

	protected override void OnEnable()
	{
		Slot obj = base.IHENCGDNPBL;
		obj.OnDirtied = (Action)Delegate.Combine(obj.OnDirtied, new Action(UpdateSlot));
		Slot obj2 = base.IHENCGDNPBL;
		obj2.OnItemAdded = (Action)Delegate.Combine(obj2.OnItemAdded, new Action(UpdateSlot));
		Slot obj3 = base.IHENCGDNPBL;
		obj3.OnItemRemoved = (Action)Delegate.Combine(obj3.OnItemRemoved, new Action(UpdateSlot));
	}

	[SpecialName]
	public void FMMBGBJDACD(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(IKBGFIEJHCB));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PDPFLAKIMKL));
		}
		UpdateSlot();
	}

	[SpecialName]
	public void CBECLMEFAOO(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		IKBGFIEJHCB();
	}

	protected override void OnDisable()
	{
		Slot obj = base.IHENCGDNPBL;
		obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		Slot obj2 = base.IHENCGDNPBL;
		obj2.OnItemAdded = (Action)Delegate.Remove(obj2.OnItemAdded, new Action(UpdateSlot));
		Slot obj3 = base.IHENCGDNPBL;
		obj3.OnItemRemoved = (Action)Delegate.Remove(obj3.OnItemRemoved, new Action(UpdateSlot));
	}

	[SpecialName]
	public Slot DOJHDCLIPOI()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot BPAHGLBAPJI()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot DFIFEFAHGPJ()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot OABFFNLGBAA()
	{
		return orderSlot;
	}

	[SpecialName]
	public void NDGCGMINICE(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		UpdateSlot();
	}

	[SpecialName]
	public Slot PHHFPMDKPPD()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot ADDMGAIDBDK()
	{
		return orderSlot;
	}

	[SpecialName]
	public void LPJJKDAFJHE(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(JOGLJKIFGNL));
		}
		JOGLJKIFGNL();
	}

	protected override void GJDPLEIAEBH(Slot ADEBNALPEHE)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		base.GJDPLEIAEBH(ADEBNALPEHE);
		if (!base.IHENCGDNPBL.KPINNBKMOMO() && (Object)(object)base.IHENCGDNPBL.quest != (Object)null)
		{
			((Component)stackText).gameObject.SetActive(true);
			if (base.IHENCGDNPBL.Stack < base.IHENCGDNPBL.quest.requiredAmount)
			{
				((Graphic)stackText).color = Color.red;
			}
			else
			{
				((Graphic)stackText).color = Color.white;
			}
		}
	}

	[SpecialName]
	public void PFGNCALIELK(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(JOGLJKIFGNL));
		}
		PDPFLAKIMKL();
	}

	[SpecialName]
	public void PNBLADDADHD(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(IKBGFIEJHCB));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(UpdateSlot));
		}
		PAMDPKDMLGC();
	}

	[SpecialName]
	public Slot HENPCDMFPMN()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot DMKGLDKMNFM()
	{
		return orderSlot;
	}

	[SpecialName]
	public void MEMMIEDEKIA(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PAMDPKDMLGC));
		}
		PDPFLAKIMKL();
	}

	[SpecialName]
	public Slot FAHMLCLFJHA()
	{
		return orderSlot;
	}

	[SpecialName]
	public Slot MLJDEDPGHDB()
	{
		return orderSlot;
	}

	[SpecialName]
	public void HENLEINDBCO(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PDPFLAKIMKL));
		}
		IKBGFIEJHCB();
	}

	[SpecialName]
	public void OGALNKKGEMD(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(UpdateSlot));
		}
		IKBGFIEJHCB();
	}

	[SpecialName]
	public Slot IHEMDJMJHMM()
	{
		return orderSlot;
	}

	[SpecialName]
	public void CCONGNBBNBP(Slot AODONKKHPBP)
	{
		if (orderSlot != null)
		{
			Slot obj = orderSlot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PAMDPKDMLGC));
		}
		orderSlot = AODONKKHPBP;
		if (orderSlot != null)
		{
			Slot obj2 = orderSlot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PDPFLAKIMKL));
		}
		JOGLJKIFGNL();
	}

	[SpecialName]
	public Slot DGMLPINFDJB()
	{
		return orderSlot;
	}
}
