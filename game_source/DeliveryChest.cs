using System.Collections.Generic;
using UnityEngine;

public class DeliveryChest : ItemContainer
{
	private static DeliveryChest GGFJGHHHEJC;

	private List<Slot> IPHABLLNILP = new List<Slot>();

	private Slot ADEBNALPEHE;

	public void AddItemInstances(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = AddItemInstance(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(IPHABLLNILP.ToArray());
		}
	}

	public static Slot GetSlot(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public static DeliveryChest MMNNKIOHKCI()
	{
		return GGFJGHHHEJC;
	}

	public Slot DJDMGBKKAMK(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: true, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.GCJGFICKJLC(0, FHHCDEOMPDH.LHBPOPOIFLE().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.MDJFFOHFGNG(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 0);
		}
		return ADEBNALPEHE;
	}

	public static Slot[] GetSlots()
	{
		return GGFJGHHHEJC.slots;
	}

	public static DeliveryChest GOBCANBKFEM()
	{
		return GGFJGHHHEJC;
	}

	private void AEDIIIAECIC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Slot HFBNLBJEGBE(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public bool AddItem(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return AddItemInstance(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	public void DNBAJAKABEF(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = LPCBOELPHMA(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(IPHABLLNILP.ToArray(), 1);
		}
	}

	public static Slot CPFGGHEMLNG(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public static Slot[] HHMAFABLBMH()
	{
		return GGFJGHHHEJC.slots;
	}

	public static Slot[] CJMBONKANHE()
	{
		return GGFJGHHHEJC.slots;
	}

	public void PJHKAHMDFMO(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 1; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = LPCBOELPHMA(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(IPHABLLNILP.ToArray());
		}
	}

	public Slot BPBDECHBLBO(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: false, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.GLLBFKGDNFH(1, FHHCDEOMPDH.AFOACBIHNCL().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.JBIAHBPAFPI(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 1, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
		}
		return ADEBNALPEHE;
	}

	private void OBHFJIDKBJN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void HCKPFBGAHIN(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 1; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = BGNCPMONPGH(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(IPHABLLNILP.ToArray());
		}
	}

	public static Slot[] ILEKDKMDJKB()
	{
		return GGFJGHHHEJC.slots;
	}

	public static Vector3 IMBDPODLKAP()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public Slot AddItemInstance(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AddItemInstance(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: false, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.AddItemCollected(1, FHHCDEOMPDH.LHBPOPOIFLE().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.SpawnDroppedItem(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 1, LHLJILLAHFO: true);
		}
		return ADEBNALPEHE;
	}

	public void MLHMGBHNHHK(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 1; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = AddItemInstance(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(IPHABLLNILP.ToArray());
		}
	}

	public Slot PCPJKEGNNGE(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: true, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.AddItemCollected(1, FHHCDEOMPDH.LHBPOPOIFLE().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.JBIAHBPAFPI(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 0);
		}
		return ADEBNALPEHE;
	}

	public Slot LPCBOELPHMA(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: true, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.GCJGFICKJLC(1, FHHCDEOMPDH.KNFNJFFCFNO().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.DHONIKFABCH(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH);
		}
		return ADEBNALPEHE;
	}

	public static Slot[] MLIKFLHFEPO()
	{
		return GGFJGHHHEJC.slots;
	}

	public static Slot JDIBIICACGD(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public static Slot[] MKMCMLPGHIJ()
	{
		return GGFJGHHHEJC.slots;
	}

	public static DeliveryChest GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void IIDEMCDFKGK(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 1; (float)i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = DJDMGBKKAMK(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(IPHABLLNILP.ToArray());
		}
	}

	protected override void Awake()
	{
		base.Awake();
		GGFJGHHHEJC = this;
	}

	public void BOOCLABLEEL(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 1; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = PCPJKEGNNGE(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(IPHABLLNILP.ToArray());
		}
	}

	public bool IFCOEGKNNID(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return BPBDECHBLBO(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	public static Slot[] EPBENFGFOOG()
	{
		return GGFJGHHHEJC.slots;
	}

	public static DeliveryChest CAJHNGGCJKM()
	{
		return GGFJGHHHEJC;
	}

	public static Slot[] BLPMAFAAFFF()
	{
		return GGFJGHHHEJC.slots;
	}

	public bool IKCIGIEDNAH(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return HEOLMBCOINK(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	public static Slot[] HGBANJBIIOF()
	{
		return GGFJGHHHEJC.slots;
	}

	public static DeliveryChest OAPIKOEJBHL()
	{
		return GGFJGHHHEJC;
	}

	public bool FEHLFJLLAFM(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return LPCBOELPHMA(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	public bool BCJLLNIBKNN(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return PCPJKEGNNGE(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	public static Slot[] GEBGANKGECM()
	{
		return GGFJGHHHEJC.slots;
	}

	public void IFPOKLDBJKA(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = BGNCPMONPGH(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(IPHABLLNILP.ToArray(), 1);
		}
	}

	public static Slot[] GDGIIOMDOAN()
	{
		return GGFJGHHHEJC.slots;
	}

	public Slot KEPAJCNLJMD(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AddItemInstance(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: false, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.AddItemCollected(1, FHHCDEOMPDH.LHBPOPOIFLE().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.SpawnDroppedItem(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 0, LHLJILLAHFO: true);
		}
		return ADEBNALPEHE;
	}

	public static DeliveryChest OMDDKLLCJID()
	{
		return GGFJGHHHEJC;
	}

	public static Vector3 OJJLADAEJCB()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static Vector3 HJBHNNDMAJG()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static DeliveryChest NIFEOHLOMAK()
	{
		return GGFJGHHHEJC;
	}

	private void ODBDHFBMDAG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Slot JKNAKEACAGL(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public static Slot ODIFNEALDKF(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public static Vector3 KBHNMMKNAAL()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static Vector3 JIJGHJAGAIO()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static Slot[] HNOEIENLNKF()
	{
		return GGFJGHHHEJC.slots;
	}

	private void KOBNHPKEJJD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Slot[] BOCJDPPKHLC()
	{
		return GGFJGHHHEJC.slots;
	}

	public bool NEPFJKABPHK(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return CANCHBINJNE(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void JHCGBJOPCEH(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = DJDMGBKKAMK(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(IPHABLLNILP.ToArray(), 1);
		}
	}

	public static Slot[] IEAFPBLENGM()
	{
		return GGFJGHHHEJC.slots;
	}

	public void JLEOKHKMLJK(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = KEPAJCNLJMD(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(IPHABLLNILP.ToArray());
		}
	}

	public void AMGCAFNJOOB(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = HEOLMBCOINK(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.MPMAHFAFGNL(IPHABLLNILP.ToArray());
		}
	}

	public static DeliveryChest CCFJIAFGENC()
	{
		return GGFJGHHHEJC;
	}

	public static DeliveryChest FFOMKKIAHKI()
	{
		return GGFJGHHHEJC;
	}

	private void OEAAPIBLALL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void IGBEKHCLKFD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public Slot CANCHBINJNE(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: true, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.AddItemCollected(1, FHHCDEOMPDH.KNFNJFFCFNO().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.SpawnDroppedItem(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
		return ADEBNALPEHE;
	}

	public static DeliveryChest CKBPMABAKJJ()
	{
		return GGFJGHHHEJC;
	}

	public Slot BGNCPMONPGH(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: false, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.GCJGFICKJLC(1, FHHCDEOMPDH.PHGLMBIEOMK().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.KDBHKBOAEDG(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 0, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		}
		return ADEBNALPEHE;
	}

	private void KPILPDFCHBG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Slot[] LGIACHCBFMK()
	{
		return GGFJGHHHEJC.slots;
	}

	public static Vector3 INIKHMJAJMN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public Slot HEOLMBCOINK(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: false, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.GCJGFICKJLC(1, FHHCDEOMPDH.LHBPOPOIFLE().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.SpawnDroppedItem(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH);
		}
		return ADEBNALPEHE;
	}

	private void FJBPFOIALMK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void AJMIGFBDLAA(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = KEPAJCNLJMD(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(IPHABLLNILP.ToArray(), 1);
		}
	}

	public static Slot[] NOKMCMGONHF()
	{
		return GGFJGHHHEJC.slots;
	}

	public static Slot BALIBAJFEKF(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	private void CDHBLKJEOPI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Vector3 AFDDAJJFEEN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static Slot MNIDFIJLHLL(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	public void KGBNCFMDCIA(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 1; (float)i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = HEOLMBCOINK(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC: false);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(IPHABLLNILP.ToArray());
		}
	}

	public static Vector3 CECJAHDFKEG()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public void AIPJHKFLDOM(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, float MGNOBNCMDJG, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		IPHABLLNILP.Clear();
		for (int i = 0; (float)i < MGNOBNCMDJG; i++)
		{
			Slot slot = BGNCPMONPGH(JIIGOACEIKL, FHHCDEOMPDH, BPJBJKJKHAL, IBCOKMGFPKB);
			if (slot != null && !IPHABLLNILP.Contains(slot))
			{
				IPHABLLNILP.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && IPHABLLNILP.Count > 0)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(IPHABLLNILP.ToArray(), 1);
		}
	}

	public Slot PJFMOLPMKIB(int JIIGOACEIKL, ItemInstance FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ADEBNALPEHE = base.AKNJFODFCID(JIIGOACEIKL, FHHCDEOMPDH, OJKJLIPNHOI: false, CDPAMNIPPEC);
		if (ADEBNALPEHE != null && IBCOKMGFPKB)
		{
			ItemsCollectedUI.AddItemCollected(0, FHHCDEOMPDH.PHGLMBIEOMK().JMDALJBNFML());
		}
		if (ADEBNALPEHE == null && BPJBJKJKHAL)
		{
			DroppedItem.KDBHKBOAEDG(((Component)GGFJGHHHEJC).transform.position + Vector3.down, FHHCDEOMPDH, 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
		}
		return ADEBNALPEHE;
	}

	public static DeliveryChest HCAIBKJKLOE()
	{
		return GGFJGHHHEJC;
	}

	public static Vector3 JLJHJHFAAIJ()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static Vector3 GetPosition()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static DeliveryChest HPCJAODINCN()
	{
		return GGFJGHHHEJC;
	}

	public static Vector3 PAMKCPCLHCL()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC).transform.position;
	}

	public static Slot[] KIMBBHECCII()
	{
		return GGFJGHHHEJC.slots;
	}

	private void LKHMCLABKLG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public bool NJNDGMPKCJF(int JIIGOACEIKL, Item FHHCDEOMPDH, bool BPJBJKJKHAL = true, bool IBCOKMGFPKB = false, bool CDPAMNIPPEC = true)
	{
		return BGNCPMONPGH(JIIGOACEIKL, FHHCDEOMPDH.JMDALJBNFML(), BPJBJKJKHAL, IBCOKMGFPKB, CDPAMNIPPEC) != null;
	}

	public static Slot[] OOAOFNNOPON()
	{
		return GGFJGHHHEJC.slots;
	}

	public static Slot FECLGAHLCFK(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	private void DKHCOKMIJME()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Slot IHACDLEEKMH(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.slots[BPDCFGHJNDA];
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OJAJLIAMGEJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}
}
