using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class NPCHoldObject : MonoBehaviour
{
	private ItemInstance DGJMAKOMOIB;

	public GameObject itemGO;

	public CharacterAnimation characterAnim;

	public Transform spritesParent;

	public SpriteRenderer holdRightSR;

	public SortingGroup holdRightGroup;

	[SerializeField]
	private GameObject heldItemDefaultPrefab;

	public ItemInstance ODDHGLHEHLA
	{
		get
		{
			return DGJMAKOMOIB;
		}
		set
		{
			DGJMAKOMOIB = value;
			ACCAKFFNDDK();
		}
	}

	[SpecialName]
	public void EMAAKKKGKFE(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		DBEEKECEJJF();
	}

	[SpecialName]
	public void AGHGEMAPJIP(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		LOPJMGCEHKH();
	}

	[SpecialName]
	public ItemInstance FJPAKOHOHHG()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void FDEENEAHFAD(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		OGFHPMKFJIA();
	}

	private void ILOJJPNAFJC()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public ItemInstance EAGDFHNCKOH()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void JCLNKJIJGBC(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HCMBMOPEDJO();
	}

	[SpecialName]
	public void NFGOCJMPEJN(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HMMHBKNCHHK();
	}

	[SpecialName]
	public ItemInstance EHLJCKJEPLM()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance EKCNNCCDBOB()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void OLIFNKHJFCC(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		NMMGKGHAPLO();
	}

	private void MHBMFDFBJLM()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	private void AEFINBPBKOI()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void DCAOOABJFOP(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		DBEEKECEJJF();
	}

	[SpecialName]
	public ItemInstance EOKCDECHBGJ()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void PJLHOECEDID(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		MJFOAPMLNMN();
	}

	private void FHFCGADJOLN()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void KNCNCGADDEB(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HLFNAKPLPCD();
	}

	[SpecialName]
	public ItemInstance IOLBNIKPKLE()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance BFOGICFIEMC()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void ABJJOHMLEAH(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		IEFKGELPEEP();
	}

	private void HBJHKHLELAD()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void HCMBMOPEDJO()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.PHGLMBIEOMK().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void IOCOOCOPNGF(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		MMNBHAONKJM();
	}

	[SpecialName]
	public ItemInstance KIANKMFHOEF()
	{
		return DGJMAKOMOIB;
	}

	private void IEFKGELPEEP()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void JNIHPKPOLBC(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		BAGAHCOIHMG();
	}

	private void LLBMBBMOKEN()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	private void IKJBBLCIGEB()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void HCFCPEILFKL(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		GKEPKMIFABM();
	}

	private void IEKHBFPAKHK()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public ItemInstance KNMIOKMPJDO()
	{
		return DGJMAKOMOIB;
	}

	private void IGOGKEBIHFE()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void JLODGHHJMPG(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		KHNAOJPECKI();
	}

	[SpecialName]
	public void AMOKFPNBLOE(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		LBBFLBDCJBL();
	}

	[SpecialName]
	public void IIDNKLLODEB(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		MJFOAPMLNMN();
	}

	[SpecialName]
	public ItemInstance OOGIDNIEHAP()
	{
		return DGJMAKOMOIB;
	}

	private void PFPNEPLDMIN()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void ANKBKCEKIDH(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		AOCCMEDHMNG();
	}

	[SpecialName]
	public ItemInstance LCEIOHMPBMJ()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance OFNKGJAFLBA()
	{
		return DGJMAKOMOIB;
	}

	private void FCBMOMMKIMD()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void OJMCMPOCKDP()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public ItemInstance GPODMCPABOE()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance BNLPPMPINHA()
	{
		return DGJMAKOMOIB;
	}

	private void MJFOAPMLNMN()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void OELKJDLLDLN(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		FCBMOMMKIMD();
	}

	[SpecialName]
	public ItemInstance FAHGJOLENBE()
	{
		return DGJMAKOMOIB;
	}

	private void PFGFPFANEOB()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	private void NMMGKGHAPLO()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.PHGLMBIEOMK().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void AOCCMEDHMNG()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void PICKDCLNCCB(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		AEFINBPBKOI();
	}

	[SpecialName]
	public ItemInstance KLDDGAONACP()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance LNFNHPHHIGD()
	{
		return DGJMAKOMOIB;
	}

	private void CJBJKADOOAH()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.PHGLMBIEOMK().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void OHIGDMHHAHA()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.PHGLMBIEOMK().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void CMIGMJJDAIC(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		IKJBBLCIGEB();
	}

	[SpecialName]
	public ItemInstance CFCNMLABMDG()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void LLDBGOPNBDA(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		ACCAKFFNDDK();
	}

	[SpecialName]
	public void FJKANFOJLFL(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		LOPJMGCEHKH();
	}

	[SpecialName]
	public ItemInstance EOFPAKLOBML()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void INKAMGAPPEP(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		AJGCENICDMD();
	}

	private void GKEPKMIFABM()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	private void HMMHBKNCHHK()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void OLIGJOMFELC(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		AOCCMEDHMNG();
	}

	[SpecialName]
	public ItemInstance APKNLDMDIKM()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void MBNGAAMPBPG(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		LBBFLBDCJBL();
	}

	private void OGFHPMKFJIA()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public ItemInstance KGAOAOGKLLE()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void GBEILLLPHOO(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		FHFCGADJOLN();
	}

	[SpecialName]
	public void OEPMNLDPJAD(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		OJMCMPOCKDP();
	}

	[SpecialName]
	public void DEGIGEEMFJH(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		LLBMBBMOKEN();
	}

	[SpecialName]
	public void IBNIPHJNADC(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		IEKHBFPAKHK();
	}

	[SpecialName]
	public void IEJFJNGCFMB(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		LOPJMGCEHKH();
	}

	[SpecialName]
	public ItemInstance BNLDLPHMEKF()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance AADKKJEKJGF()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void HJDDLNELGKN(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HBJHKHLELAD();
	}

	private void BHAHLMIPNFL()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.PHGLMBIEOMK().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void CPGLHDFOGIP(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HCMBMOPEDJO();
	}

	[SpecialName]
	public void IENJAJNHIPP(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		IEFKGELPEEP();
	}

	[SpecialName]
	public void CMLCBMANBJG(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		AOCCMEDHMNG();
	}

	private void OEICJDPHHIE()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.PHGLMBIEOMK().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public ItemInstance NPJJLJOGGEK()
	{
		return DGJMAKOMOIB;
	}

	private void LOPJMGCEHKH()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void HLFNAKPLPCD()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.PHGLMBIEOMK().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.PHGLMBIEOMK().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	private void BAGAHCOIHMG()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public void AAHKKNOBMIN(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		IEKHBFPAKHK();
	}

	[SpecialName]
	public ItemInstance ACHIFKIDMGF()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void BEGAHCCFOGJ(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HBJHKHLELAD();
	}

	private void KHNAOJPECKI()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public ItemInstance DHAPJNGPMJK()
	{
		return DGJMAKOMOIB;
	}

	private void AJGCENICDMD()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.PHGLMBIEOMK().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void DBEEKECEJJF()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.PHGLMBIEOMK().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public void DPNDFNGLPOL(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		NMMGKGHAPLO();
	}

	[SpecialName]
	public void DGCKMDICIBD(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		CJBJKADOOAH();
	}

	[SpecialName]
	public ItemInstance IECGOGJFINN()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance JKNKHFGFKLK()
	{
		return DGJMAKOMOIB;
	}

	private void DBKLBKLHKHL()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public ItemInstance IBLMPONJCLN()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void GCDELBBFIHD(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		OJMCMPOCKDP();
	}

	[SpecialName]
	public void ODHABMPPAIG(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		IEKHBFPAKHK();
	}

	[SpecialName]
	public ItemInstance DJDFFABGMFL()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void OKPNNMGBGBI(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		HMMHBKNCHHK();
	}

	private void MMNBHAONKJM()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public ItemInstance CLELJDLCMMO()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public void HDLKCCCMKMP(ItemInstance AODONKKHPBP)
	{
		DGJMAKOMOIB = AODONKKHPBP;
		MMNBHAONKJM();
	}

	private void IBIPBDKGNHO()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().LLCLICBABLN());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.HFHDFKAIMJM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	private void ENMCFEPBKNA()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.PHGLMBIEOMK().LLCLICBABLN() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.KNFNJFFCFNO().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(true);
		}
	}

	[SpecialName]
	public ItemInstance HHHJBHCHPJD()
	{
		return DGJMAKOMOIB;
	}

	[SpecialName]
	public ItemInstance GIDHFCHIIJI()
	{
		return DGJMAKOMOIB;
	}

	private void ACCAKFFNDDK()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.LHBPOPOIFLE().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.IKAHNKLABDM();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}

	[SpecialName]
	public ItemInstance OLAAMNJMNNK()
	{
		return DGJMAKOMOIB;
	}

	private void LBBFLBDCJBL()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (DGJMAKOMOIB == null)
		{
			if (Object.op_Implicit((Object)(object)itemGO))
			{
				Utils.BLPDAEHPOBA(itemGO);
			}
			return;
		}
		if ((Object)(object)itemGO != (Object)null)
		{
			Utils.BLPDAEHPOBA(itemGO);
		}
		if ((Object)(object)DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI() != (Object)null)
		{
			itemGO = Object.Instantiate<GameObject>(DGJMAKOMOIB.AFOACBIHNCL().PHGCBMPGGLI());
			itemGO.transform.parent = spritesParent;
			itemGO.transform.position = Vector3.zero;
		}
		else
		{
			itemGO = Object.Instantiate<GameObject>(heldItemDefaultPrefab);
			itemGO.GetComponentInChildren<SpriteRenderer>().sprite = DGJMAKOMOIB.AAOBBPPDGKB();
			itemGO.transform.parent = spritesParent;
			itemGO.transform.localPosition = Vector3.zero;
			itemGO.SetActive(false);
		}
	}
}
