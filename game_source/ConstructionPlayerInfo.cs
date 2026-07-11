using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConstructionPlayerInfo : MonoBehaviour
{
	[SerializeField]
	private Item planks;

	[SerializeField]
	private Item nails;

	[SerializeField]
	private Item stones;

	[SerializeField]
	private Item mortar;

	[SerializeField]
	private TextMeshProUGUI playerPlanksTextMesh;

	[SerializeField]
	private TextMeshProUGUI playerNailsTextMesh;

	[SerializeField]
	private TextMeshProUGUI playerStonesTextMesh;

	[SerializeField]
	private TextMeshProUGUI playerMortarTextMesh;

	public Transform originalParent;

	private Container ALPOKDOCCGM;

	private MoneyMaterials OEKCAMMBBND;

	private MoneyMaterials MMPBEBGMHCP;

	public MoneyMaterials KJLGKKDALAJ
	{
		get
		{
			return OEKCAMMBBND;
		}
		set
		{
			OEKCAMMBBND = value;
		}
	}

	[SpecialName]
	public void DBFAPKILGKL(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	[SpecialName]
	public MoneyMaterials LEKFELDNEHK()
	{
		return OEKCAMMBBND;
	}

	[SpecialName]
	public void KFFMFKFPHMG(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	[SpecialName]
	public void PNLDAPEJOIK(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	public void GetMaterialsFromPlayer(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(planks);
		OEKCAMMBBND.nails = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(nails);
		OEKCAMMBBND.stones = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(stones);
		OEKCAMMBBND.mortar = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		UpdateMaterials();
	}

	public void APOEOIHIGHB(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).NAENGEHEGHP(planks);
		OEKCAMMBBND.nails = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HMCBIANPIKD(nails);
		OEKCAMMBBND.stones = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).KIHAKOFNNPI(stones);
		OEKCAMMBBND.mortar = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).HMCBIANPIKD(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		OIHEIPLCBHF();
	}

	public void FMIAPFFFHBO()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.BMDNOGNAPJJ();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.NCILNCAACAN();
		if (dictionary.TryGetValue(planks.CIGFGKKCPCK(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 1;
		}
		if (dictionary.TryGetValue(nails.IMCJPECAAPC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.JGHNDJBCFAJ(), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.ODENMDOJPLC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		LFFFJMNCNHD();
	}

	public Image MHJICNACNAI()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public bool CPEEFIHMDCH(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	public Image DDKLKBLOFKE()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void EJAGFMBAKMK()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	public void HDDFEKFGFCP()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.GDAEMIPHAHH();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.FFFJDOOBMNO();
		if (dictionary.TryGetValue(planks.JDJGFAACPFC(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 1;
		}
		if (dictionary.TryGetValue(nails.JGHNDJBCFAJ(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.CIGFGKKCPCK(), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 0;
		}
		if (dictionary.TryGetValue(mortar.ODENMDOJPLC(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		EJAGFMBAKMK();
	}

	[SpecialName]
	public MoneyMaterials EONGGEDBGMF()
	{
		return OEKCAMMBBND;
	}

	public bool CanPay(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	public void IAHNFGNPKAM(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KIHAKOFNNPI(planks);
		OEKCAMMBBND.nails = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).KIHAKOFNNPI(nails);
		OEKCAMMBBND.stones = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NAENGEHEGHP(stones);
		OEKCAMMBBND.mortar = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEGAJPFIJDD(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		EJAGFMBAKMK();
	}

	public void EGINICGPOJP()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.GDAEMIPHAHH();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i += 0)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(planks);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 0; j < num2; j++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(nails);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(stones);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 0; l < num4; l++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(mortar, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (list.Count > 1 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.MPMAHFAFGNL(list.ToArray());
		}
	}

	public void RemoveMaterialsUsed()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.GetInstance();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(planks, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 0; j < num2; j++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(nails, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(stones, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 0; l < num4; l++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(mortar, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (list.Count > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
	}

	public void PKFANCIGKOL()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.EBPNKOMGCPB();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.GKGPBIEBFKL();
		if (dictionary.TryGetValue(planks.JGHNDJBCFAJ(DAINLFIMLIH: false), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.JGHNDJBCFAJ(), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 0;
		}
		if (dictionary.TryGetValue(stones.CIGFGKKCPCK(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.ODENMDOJPLC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		EJAGFMBAKMK();
	}

	public void AKNPMJHCGCF(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEGAJPFIJDD(planks);
		OEKCAMMBBND.nails = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).KIHAKOFNNPI(nails);
		OEKCAMMBBND.stones = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NAENGEHEGHP(stones);
		OEKCAMMBBND.mortar = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KIHAKOFNNPI(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		OIHEIPLCBHF();
	}

	[SpecialName]
	public void BMDFBDKCLNN(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	public void HBEIILPGIEL(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).NAENGEHEGHP(planks);
		OEKCAMMBBND.nails = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HMCBIANPIKD(nails);
		OEKCAMMBBND.stones = PlayerInventory.GetPlayer(JIIGOACEIKL).KIHAKOFNNPI(stones);
		OEKCAMMBBND.mortar = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).HMCBIANPIKD(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		FDBMDOPCIAL();
	}

	public void OIHEIPLCBHF()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	public void DCBFOLAJNLE(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NumberOfItems(planks);
		OEKCAMMBBND.nails = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).DEGAJPFIJDD(nails);
		OEKCAMMBBND.stones = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(stones);
		OEKCAMMBBND.mortar = PlayerInventory.GetPlayer(JIIGOACEIKL).KIHAKOFNNPI(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		LFFFJMNCNHD();
	}

	[SpecialName]
	public void BFMGMENKPHG(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	[SpecialName]
	public MoneyMaterials ACIALGHFLMD()
	{
		return OEKCAMMBBND;
	}

	public bool KJMLBCMIFPC(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	[SpecialName]
	public void HGHDKOHIINF(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	[SpecialName]
	public void MEDAKADLPFE(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	public bool FBHAFHMPJIN(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	private void EMJKKALMGLK()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.HHDPBIFCIBO(Money.CADNHAGELGN());
	}

	public void NIKLEAOGFHD(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.GetPlayer(JIIGOACEIKL).NAENGEHEGHP(planks);
		OEKCAMMBBND.nails = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NAENGEHEGHP(nails);
		OEKCAMMBBND.stones = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NAENGEHEGHP(stones);
		OEKCAMMBBND.mortar = PlayerInventory.GetPlayer(JIIGOACEIKL).KIHAKOFNNPI(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		FDBMDOPCIAL();
	}

	public bool NCFGLMODLKA(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	[SpecialName]
	public MoneyMaterials MBOMLBPPGEO()
	{
		return OEKCAMMBBND;
	}

	public void LADFDKCNDEO()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.CAJHNGGCJKM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.GKGPBIEBFKL();
		if (dictionary.TryGetValue(planks.JGHNDJBCFAJ(DAINLFIMLIH: false), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.JDJGFAACPFC(), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 0;
		}
		if (dictionary.TryGetValue(stones.CIGFGKKCPCK(), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 0;
		}
		if (dictionary.TryGetValue(mortar.IMCJPECAAPC(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		CLOFJEGCBNA();
	}

	private void ILCLIJOHKHG()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.GJDGHBGJACG(Money.JOBFHDLGMDP());
	}

	public void NAHFFJFCFKM()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.LMFCIEFLABM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.IGHLECJCPLG();
		if (dictionary.TryGetValue(planks.ODENMDOJPLC(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.JPNFKDMFKMC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.IMCJPECAAPC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 0;
		}
		if (dictionary.TryGetValue(mortar.IMCJPECAAPC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		CLOFJEGCBNA();
	}

	public void INHGHAMLBGD(int JIIGOACEIKL)
	{
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i += 0)
		{
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItem(planks, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 0; j < num2; j += 0)
		{
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).RemoveItem(nails);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k += 0)
		{
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItem(stones);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 0; l < num4; l += 0)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(mortar, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray());
		}
	}

	public void CKHHADONCAF()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.MDDCPOILOOM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < num; i++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(planks);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 1; j < num2; j++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(nails);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 1; k < num3; k++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(stones, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 1; l < num4; l++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(mortar);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (list.Count > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.MPMAHFAFGNL(list.ToArray());
		}
	}

	public Image FEDCOJCLBJC()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void KOKBHKAGAOO()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.CAJHNGGCJKM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.OGENLMLPNAF();
		if (dictionary.TryGetValue(planks.JGHNDJBCFAJ(DAINLFIMLIH: false), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.CIGFGKKCPCK(), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.JPNFKDMFKMC(), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.JPNFKDMFKMC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		PHLKHLNGNPB();
	}

	public void UpdateMaterials()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	public bool NHOGBFDIDBO(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	public Image NEGOKFODEEI()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public Image CBNNLBEJNIH()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public bool NHAJBNPIJIN(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	public Image GetOutlineImage()
	{
		return ((Component)this).GetComponent<Image>();
	}

	[SpecialName]
	public MoneyMaterials PPEOOLCNAGN()
	{
		return OEKCAMMBBND;
	}

	public void NNKDGPIHPIJ()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.DCILOFEFFAG();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> allItems = ALPOKDOCCGM.GetAllItems();
		if (allItems.TryGetValue(planks.IMCJPECAAPC(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 1;
		}
		if (allItems.TryGetValue(nails.ODENMDOJPLC(), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 0;
		}
		if (allItems.TryGetValue(stones.IMCJPECAAPC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (allItems.TryGetValue(mortar.JDJGFAACPFC(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		EGHNLNKCNJO();
	}

	[SpecialName]
	public void IPBBEBMGIMA(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	public void FDBMDOPCIAL()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	public void BODDNFLGAPP(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HMCBIANPIKD(planks);
		OEKCAMMBBND.nails = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).KIHAKOFNNPI(nails);
		OEKCAMMBBND.stones = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).HMCBIANPIKD(stones);
		OEKCAMMBBND.mortar = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).NAENGEHEGHP(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		CLOFJEGCBNA();
	}

	private void DMFMNEMDFNP()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(OIHEIPLCBHF));
	}

	public void EKBFEMCECIP(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KIHAKOFNNPI(planks);
		OEKCAMMBBND.nails = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(nails);
		OEKCAMMBBND.stones = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HMCBIANPIKD(stones);
		OEKCAMMBBND.mortar = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).NAENGEHEGHP(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		LFFFJMNCNHD();
	}

	[SpecialName]
	public void DNHCGOHILAJ(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	private void IBMDFNKKPJF()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.GJDGHBGJACG(Money.PJDFPKDPFHG());
	}

	private void HNEGFBCKIIJ()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(CLOFJEGCBNA));
	}

	public void RemoveMaterialsFromPlayer(int JIIGOACEIKL)
	{
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i++)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(planks, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 0; j < num2; j++)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(nails, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k++)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(stones, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 0; l < num4; l++)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(mortar, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
	}

	[SpecialName]
	public void LJJDIMOIJBG(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	public void EKPMJPFOOIH(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).DEGAJPFIJDD(planks);
		OEKCAMMBBND.nails = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).NumberOfItems(nails);
		OEKCAMMBBND.stones = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).KIHAKOFNNPI(stones);
		OEKCAMMBBND.mortar = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NumberOfItems(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		PHLKHLNGNPB();
	}

	public Image MKOIMPBENPP()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void PABBLFALODH()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.EBPNKOMGCPB();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.NCILNCAACAN();
		if (dictionary.TryGetValue(planks.CIGFGKKCPCK(DAINLFIMLIH: false), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.JDJGFAACPFC(), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.IMCJPECAAPC(), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.JPNFKDMFKMC(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		FDBMDOPCIAL();
	}

	public void KOOLHDOHDPL()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	public void JNDCIMMOFMJ(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(planks);
		OEKCAMMBBND.nails = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(nails);
		OEKCAMMBBND.stones = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).NAENGEHEGHP(stones);
		OEKCAMMBBND.mortar = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).KIHAKOFNNPI(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		FDBMDOPCIAL();
	}

	public bool BPHDJCCKKPN(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	public void GetMaterialsFromContainer()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.GetInstance();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> allItems = ALPOKDOCCGM.GetAllItems();
		if (allItems.TryGetValue(planks.JDJGFAACPFC(DAINLFIMLIH: false), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (allItems.TryGetValue(nails.JDJGFAACPFC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 0;
		}
		if (allItems.TryGetValue(stones.JDJGFAACPFC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 0;
		}
		if (allItems.TryGetValue(mortar.JDJGFAACPFC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		UpdateMaterials();
	}

	[SpecialName]
	public MoneyMaterials BLFALIKICFH()
	{
		return OEKCAMMBBND;
	}

	public void HNKDKMPKMDF()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.DCEBHEAHHID();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.OGENLMLPNAF();
		if (dictionary.TryGetValue(planks.IMCJPECAAPC(DAINLFIMLIH: false), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.JGHNDJBCFAJ(), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.CIGFGKKCPCK(), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.JGHNDJBCFAJ(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		KOOLHDOHDPL();
	}

	public bool JICOBCNODBF(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	public void DIBNIPBENNM(int JIIGOACEIKL)
	{
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < num; i++)
		{
			Slot slot = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItem(planks, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 0; j < num2; j += 0)
		{
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItem(nails);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 1; k < num3; k++)
		{
			Slot slot = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OOEJMKIAPLC(stones);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 1; l < num4; l++)
		{
			Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OOEJMKIAPLC(mortar, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.MPMAHFAFGNL(list.ToArray());
		}
	}

	public Image CADIPDIJPNE()
	{
		return ((Component)this).GetComponent<Image>();
	}

	[SpecialName]
	public MoneyMaterials ACJOEAKNIBH()
	{
		return OEKCAMMBBND;
	}

	private void AHFGOOHOLEL()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(KGHJGFCFLDO));
	}

	public void GCPGMHDOBEK(int JIIGOACEIKL)
	{
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i++)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).OOEJMKIAPLC(planks);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 1; j < num2; j += 0)
		{
			Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).RemoveItem(nails);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k++)
		{
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OOEJMKIAPLC(stones);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 1; l < num4; l += 0)
		{
			Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItem(mortar);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray(), 1);
		}
	}

	[SpecialName]
	public void HPNCFBJFBHH(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	private void Start()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(UpdateMaterials));
	}

	public Image KCLOBKHHIPO()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void FLPBLJLJHIN()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.GJJELMFOGPC();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.NCILNCAACAN();
		if (dictionary.TryGetValue(planks.IMCJPECAAPC(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 1;
		}
		if (dictionary.TryGetValue(nails.JGHNDJBCFAJ(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 0;
		}
		if (dictionary.TryGetValue(stones.JDJGFAACPFC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.JGHNDJBCFAJ(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		LFFFJMNCNHD();
	}

	[SpecialName]
	public void GNODGKCLLIK(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}

	public Image KEPODBOLOLH()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void KGHJGFCFLDO()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	public bool BBPLCJFBHHJ(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	private void CHIJGHPHCNA()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(KOOLHDOHDPL));
	}

	public void CLOFJEGCBNA()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	private void KMEJBPOOBJK()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.GJDGHBGJACG(Money.OGNEAEMNLLD());
	}

	public void IOFFBDHKIJI()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.NIDNAAKOPFI();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < num; i++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(planks);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 1; j < num2; j++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(nails);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 1; k < num3; k++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(stones);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 0; l < num4; l++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(mortar, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (list.Count > 1 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray());
		}
	}

	public void CHIGNEGDHNG()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.CAJHNGGCJKM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i += 0)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(planks);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 1; j < num2; j += 0)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(nails, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(stones, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 0; l < num4; l += 0)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(mortar);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (list.Count > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray(), 1);
		}
	}

	public void FDBJEAFMEFN()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.LMFCIEFLABM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.OGENLMLPNAF();
		if (dictionary.TryGetValue(planks.ODENMDOJPLC(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.ODENMDOJPLC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.JPNFKDMFKMC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 0;
		}
		if (dictionary.TryGetValue(mortar.JDJGFAACPFC(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		EJAGFMBAKMK();
	}

	public void ALFJGJMOFBN()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.PPPDBCPNACC();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> allItems = ALPOKDOCCGM.GetAllItems();
		if (allItems.TryGetValue(planks.JPNFKDMFKMC(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (allItems.TryGetValue(nails.CIGFGKKCPCK(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (allItems.TryGetValue(stones.JGHNDJBCFAJ(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (allItems.TryGetValue(mortar.JDJGFAACPFC(), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 1;
		}
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		KGHJGFCFLDO();
	}

	public bool NEPKKFLDAKI(ConstructionAction DGINFJFHMJC)
	{
		return OEKCAMMBBND.JEANPDCCPEF(DGINFJFHMJC);
	}

	private void AAEAAEBBFKG()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.HHDPBIFCIBO(Money.OGNEAEMNLLD());
	}

	public Image LJPMHMNEHEH()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void FKOPCEIMBIP(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).HMCBIANPIKD(planks);
		OEKCAMMBBND.nails = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEGAJPFIJDD(nails);
		OEKCAMMBBND.stones = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEGAJPFIJDD(stones);
		OEKCAMMBBND.mortar = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEGAJPFIJDD(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.MFGBCMGGDDC();
		EGHNLNKCNJO();
	}

	public void ANHEDFFALAL(int JIIGOACEIKL)
	{
		OEKCAMMBBND.planks = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(planks);
		OEKCAMMBBND.nails = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KIHAKOFNNPI(nails);
		OEKCAMMBBND.stones = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(stones);
		OEKCAMMBBND.mortar = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KIHAKOFNNPI(mortar);
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		UpdateMaterials();
	}

	public void AGMLADJMHKM()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.CMBAAHFGOAM();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		int num = MMPBEBGMHCP.planks - OEKCAMMBBND.planks;
		int num2 = MMPBEBGMHCP.nails - OEKCAMMBBND.nails;
		int num3 = MMPBEBGMHCP.stones - OEKCAMMBBND.stones;
		int num4 = MMPBEBGMHCP.mortar - OEKCAMMBBND.mortar;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < num; i++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(planks, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int j = 1; j < num2; j += 0)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(nails, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int k = 0; k < num3; k += 0)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(stones, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		for (int l = 1; l < num4; l++)
		{
			Slot slot = ALPOKDOCCGM.RemoveItem(mortar);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (list.Count > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray(), 1);
		}
	}

	public void PHLKHLNGNPB()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	private void Awake()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.JLBNNNOCEGN(Money.GetBalance());
	}

	private void LANGHIOBJIH()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(PHLKHLNGNPB));
	}

	public void KOPMMFCFNGH()
	{
		if ((Object)(object)ALPOKDOCCGM == (Object)null)
		{
			ALPOKDOCCGM = BuildingInventory.EBPNKOMGCPB();
			if ((Object)(object)ALPOKDOCCGM == (Object)null)
			{
				return;
			}
		}
		Dictionary<int, ItemAmount> dictionary = ALPOKDOCCGM.OGENLMLPNAF();
		if (dictionary.TryGetValue(planks.CIGFGKKCPCK(), out var value))
		{
			OEKCAMMBBND.planks = value.amount;
		}
		else
		{
			OEKCAMMBBND.planks = 0;
		}
		if (dictionary.TryGetValue(nails.ODENMDOJPLC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.nails = value.amount;
		}
		else
		{
			OEKCAMMBBND.nails = 1;
		}
		if (dictionary.TryGetValue(stones.JGHNDJBCFAJ(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.stones = value.amount;
		}
		else
		{
			OEKCAMMBBND.stones = 1;
		}
		if (dictionary.TryGetValue(mortar.JPNFKDMFKMC(DAINLFIMLIH: false), out value))
		{
			OEKCAMMBBND.mortar = value.amount;
		}
		else
		{
			OEKCAMMBBND.mortar = 0;
		}
		MMPBEBGMHCP = OEKCAMMBBND.CCCAKKCFAIP();
		FDBMDOPCIAL();
	}

	private void IIPKPMPGLOL()
	{
		OEKCAMMBBND = new MoneyMaterials();
		MMPBEBGMHCP = new MoneyMaterials();
		OEKCAMMBBND.HHDPBIFCIBO(Money.PJDFPKDPFHG());
	}

	public void LFFFJMNCNHD()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	private void OKAPGNGLOHO()
	{
		MoneyMaterials oEKCAMMBBND = OEKCAMMBBND;
		oEKCAMMBBND.OnModified = (Action)Delegate.Combine(oEKCAMMBBND.OnModified, new Action(EJAGFMBAKMK));
	}

	public void EGHNLNKCNJO()
	{
		((TMP_Text)playerPlanksTextMesh).text = OEKCAMMBBND.planks.ToString();
		((TMP_Text)playerNailsTextMesh).text = OEKCAMMBBND.nails.ToString();
		((TMP_Text)playerStonesTextMesh).text = OEKCAMMBBND.stones.ToString();
		((TMP_Text)playerMortarTextMesh).text = OEKCAMMBBND.mortar.ToString();
	}

	[SpecialName]
	public void MCHMCMIOEHC(MoneyMaterials AODONKKHPBP)
	{
		OEKCAMMBBND = AODONKKHPBP;
	}
}
