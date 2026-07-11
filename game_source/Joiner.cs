using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Joiner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class CNGMIDPEABG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public Joiner _003C_003E4__this;

		public int playerNum;

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
		public CNGMIDPEABG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Joiner joiner = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(waitTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				joiner.JoinerPlaced(playerNum);
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

	public ItemSetup itemSetup;

	public Item[] acceptedJoiners;

	public float shortDistance = 0.5f;

	public float longDistance = 1f;

	[SerializeField]
	private Placeable placeable;

	[SerializeField]
	private GameObject vertical;

	[SerializeField]
	private GameObject horizontal;

	[SerializeField]
	private GameObject verticalLong;

	[SerializeField]
	private GameObject horizontalLong;

	[SerializeField]
	private ItemSpace verticalItemSpaceLong;

	[SerializeField]
	private ItemSpace horizontalItemSpaceLong;

	[SerializeField]
	private ItemSpace verticalItemSpaceShort;

	[SerializeField]
	private ItemSpace horizontalItemSpaceShort;

	[SerializeField]
	private bool setUpOnLoad;

	private bool IOJLFEBMCON;

	private bool HIMMHPEHMKH;

	private bool NNDOEMBNFOF;

	private bool KFFPJKANGAM;

	public bool placed;

	public bool KFNCLFIJJII
	{
		get
		{
			return IOJLFEBMCON;
		}
		set
		{
			if (value != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
			{
				if (value)
				{
					vertical.SetActive(true);
					if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
					{
						verticalItemSpaceShort.Place(NMLKLAGDNPF: true);
					}
				}
				else
				{
					vertical.SetActive(false);
					if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
					{
						verticalItemSpaceShort.Place(NMLKLAGDNPF: false);
					}
				}
			}
			IOJLFEBMCON = value;
		}
	}

	public bool MLFKLJAHGNM
	{
		get
		{
			return HIMMHPEHMKH;
		}
		set
		{
			if (value != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
			{
				if (value)
				{
					horizontal.SetActive(true);
					if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
					{
						horizontalItemSpaceShort.Place(NMLKLAGDNPF: true);
					}
				}
				else
				{
					horizontal.SetActive(false);
					if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
					{
						horizontalItemSpaceShort.Place(NMLKLAGDNPF: false);
					}
				}
			}
			HIMMHPEHMKH = value;
		}
	}

	public bool PAAFFALEMBF
	{
		get
		{
			return NNDOEMBNFOF;
		}
		set
		{
			if (value != NNDOEMBNFOF && Object.op_Implicit((Object)(object)verticalLong))
			{
				if (value)
				{
					verticalLong.SetActive(true);
					verticalItemSpaceLong.Place(NMLKLAGDNPF: true);
				}
				else
				{
					verticalLong.SetActive(false);
					verticalItemSpaceLong.Place(NMLKLAGDNPF: false);
				}
			}
			NNDOEMBNFOF = value;
		}
	}

	public bool LDODNJGKNDI
	{
		get
		{
			return KFFPJKANGAM;
		}
		set
		{
			if (value != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
			{
				if (value)
				{
					horizontalLong.SetActive(true);
					horizontalItemSpaceLong.Place(NMLKLAGDNPF: true);
				}
				else
				{
					horizontalLong.SetActive(false);
					horizontalItemSpaceLong.Place(NMLKLAGDNPF: false);
				}
			}
			KFFPJKANGAM = value;
		}
	}

	[SpecialName]
	public void ANMLKOBNBCG(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != NNDOEMBNFOF && Object.op_Implicit((Object)(object)verticalLong))
		{
			if (AODONKKHPBP)
			{
				verticalLong.SetActive(true);
				verticalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
			else
			{
				verticalLong.SetActive(false);
				verticalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
		}
		NNDOEMBNFOF = AODONKKHPBP;
	}

	private void NGEHFPOIJFK(int JIIGOACEIKL)
	{
		JoinerPlaced(JIIGOACEIKL);
	}

	private void GJADNELLKCI(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		IMOLAMKDEJP(AODONKKHPBP: false);
		ABGIGEIDFID(AODONKKHPBP: true);
		LDODNJGKNDI = true;
		HNAEEGOCILC(AODONKKHPBP: true);
		if (placed)
		{
			MNBMPJNKOKO();
		}
		placed = true;
	}

	[SpecialName]
	public bool ALDMHBHCDDE()
	{
		return KFFPJKANGAM;
	}

	private bool EDOPLHOAHKN(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.JPNFKDMFKMC() == KPKNCIJFOGM.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false))
		{
			return false;
		}
		for (int i = 0; i < acceptedJoiners.Length; i++)
		{
			if (acceptedJoiners[i].ODENMDOJPLC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false))
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public void CPHAMIFNHNF(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
			else
			{
				horizontalLong.SetActive(false);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	private Joiner AMGFAFEINKG(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		for (int i = 1; i < array.Length; i += 0)
		{
			Collider2D val = array[i];
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (((Vector3)(ref val2)).magnitude > 420f)
			{
				continue;
			}
			Joiner component = ((Component)val).GetComponent<Joiner>();
			if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && FDDAAPLPEAA(component) && placed)
			{
				if (GNLBBNHNIJF)
				{
					component.BCJKJIFFNKP();
				}
				return component;
			}
		}
		return null;
	}

	[SpecialName]
	public bool NLKAKHAKMHK()
	{
		return KFFPJKANGAM;
	}

	private void EJODGHELGJK(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = AIMDCNEIPOE(new Vector3(1198f, 0f - shortDistance));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && placed && joiner.placed))
			{
				joiner.EKHEGIMEHMC(BJFHJCFOEHG);
			}
		}
		else
		{
			joiner = LKEBDHDKBFG(new Vector3(954f, 0f - longDistance), GNLBBNHNIJF: true);
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.LJCPGDDLJKL() && placed && joiner.placed)))
			{
				joiner.ENFCKFMAEDA(BJFHJCFOEHG);
			}
		}
		joiner = NFJNICLDLHP(new Vector3(0f - shortDistance, 195f));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: false, ELKPPAAMMIM: false)) && placed && joiner.placed))
			{
				joiner.EHDMPNBALCD(BJFHJCFOEHG);
			}
			return;
		}
		joiner = AMGFAFEINKG(new Vector3(0f - longDistance, 90f));
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false) && placed && joiner.placed)))
		{
			joiner.LDODNJGKNDI = BJFHJCFOEHG;
		}
	}

	private List<Joiner> LLKFFNOLNAD(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = new List<Joiner>();
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		foreach (Collider2D val in array)
		{
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (!(((Vector3)(ref val2)).magnitude > 0.25f))
			{
				Joiner component = ((Component)val).GetComponent<Joiner>();
				if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && MGDLFMIDMGN(component))
				{
					list.Add(component);
				}
			}
		}
		return list;
	}

	[SpecialName]
	public bool HAHKPJGBEME()
	{
		return HIMMHPEHMKH;
	}

	[SpecialName]
	public void HADDILILEFI(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != NNDOEMBNFOF && Object.op_Implicit((Object)(object)verticalLong))
		{
			if (AODONKKHPBP)
			{
				verticalLong.SetActive(false);
				verticalItemSpaceLong.Place(NMLKLAGDNPF: true);
			}
			else
			{
				verticalLong.SetActive(true);
				verticalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
		}
		NNDOEMBNFOF = AODONKKHPBP;
	}

	private void LKEBDHDKBFG(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.IsItemSpaceValid()) && Object.op_Implicit((Object)(object)horizontal))
		{
			MLFKLJAHGNM = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(shortDistance, 0f), GNLBBNHNIJF));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.IsItemSpaceValid()) && Object.op_Implicit((Object)(object)vertical))
		{
			KFNCLFIJJII = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(0f, shortDistance), GNLBBNHNIJF));
		}
		if (!KFNCLFIJJII && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.IsItemSpaceValid() && Object.op_Implicit((Object)(object)verticalLong))
		{
			PAAFFALEMBF = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(0f, longDistance), GNLBBNHNIJF));
		}
		if (!MLFKLJAHGNM && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.IsItemSpaceValid() && Object.op_Implicit((Object)(object)horizontalLong))
		{
			LDODNJGKNDI = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(longDistance, 0f), GNLBBNHNIJF));
		}
	}

	[SpecialName]
	public void ANLJBHHHLNK(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(false);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
			else
			{
				horizontalLong.SetActive(false);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	[SpecialName]
	public void ENFCKFMAEDA(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != NNDOEMBNFOF && Object.op_Implicit((Object)(object)verticalLong))
		{
			if (AODONKKHPBP)
			{
				verticalLong.SetActive(false);
				verticalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
			else
			{
				verticalLong.SetActive(true);
				verticalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
		}
		NNDOEMBNFOF = AODONKKHPBP;
	}

	private void CMMMINEGNFP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(MHIJNKKHDFH));
	}

	private void GNMMELIJKML()
	{
		if (Object.op_Implicit((Object)(object)verticalLong))
		{
			verticalLong.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)horizontalLong))
		{
			horizontalLong.SetActive(true);
		}
		if ((setUpOnLoad && !placeable.FHEMHCEAICB) || !DecorationMode.IFFOPKEMMNP())
		{
			placed = true;
			LNGFCCBLFBL(0, OKNOJJEFEBE: true);
			MCNFLGKNGHI(1, 963f);
		}
	}

	[SpecialName]
	public void FHCKMNDKELL(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	[SpecialName]
	public bool CECKEKOEDDM()
	{
		return KFFPJKANGAM;
	}

	public void BGCBIBEPLEI()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	private void KAECMBNKNEH(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true)) && Object.op_Implicit((Object)(object)horizontal))
		{
			LDLIFKCEOBL(Object.op_Implicit((Object)(object)AMGFAFEINKG(new Vector3(shortDistance, 790f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.LJCPGDDLJKL()) && Object.op_Implicit((Object)(object)vertical))
		{
			LIFAMGGNPND(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(257f, shortDistance), GNLBBNHNIJF)));
		}
		if (!LOCCDNPDLML() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)verticalLong))
		{
			GPLIFACFLGI(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(1834f, longDistance), GNLBBNHNIJF)));
		}
		if (!LJIMHPLKDPA() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.IsItemSpaceValid() && Object.op_Implicit((Object)(object)horizontalLong))
		{
			LDODNJGKNDI = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(longDistance, 1853f), GNLBBNHNIJF));
		}
	}

	public IEnumerator MLLNHFCFNPM(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		JoinerPlaced(JIIGOACEIKL);
	}

	[SpecialName]
	public void NANLJEGJGKD(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
		{
			if (AODONKKHPBP)
			{
				horizontal.SetActive(true);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				horizontal.SetActive(true);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
		}
		HIMMHPEHMKH = AODONKKHPBP;
	}

	private void BEOIOFIHCKN()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(BOCANBDHCGB));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(PBBGLLGJLGO));
	}

	[SpecialName]
	public void ABGIGEIDFID(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	public void JoinerPlaced(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 0f)
		{
			((MonoBehaviour)this).StartCoroutine(JoinerPlacedCoroutine(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = true;
		LKEBDHDKBFG(GNLBBNHNIJF: false);
		OOJBJLMHGMD(BJFHJCFOEHG: true);
	}

	private void OIHAMLCIFNH()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(MHIJNKKHDFH));
	}

	public void IKPCBJBCCDJ()
	{
		MLGMHNANKJF(GNLBBNHNIJF: true);
	}

	private List<Joiner> IMBONEHBGNM(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = new List<Joiner>();
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		for (int i = 0; i < array.Length; i += 0)
		{
			Collider2D val = array[i];
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (!(((Vector3)(ref val2)).magnitude > 620f))
			{
				Joiner component = ((Component)val).GetComponent<Joiner>();
				if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && EDOPLHOAHKN(component))
				{
					list.Add(component);
				}
			}
		}
		return list;
	}

	[SpecialName]
	public bool CFPGBIEFJEB()
	{
		return IOJLFEBMCON;
	}

	private bool LGKDMGPMLOF(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.JPNFKDMFKMC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.JGHNDJBCFAJ())
		{
			return false;
		}
		for (int i = 1; i < acceptedJoiners.Length; i += 0)
		{
			if (acceptedJoiners[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false))
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public void BMLINONAGJC(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	private void EBDINMDEDPB()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = EKDHIJENLEM(new Vector3(1015f, 0f - shortDistance));
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].FHCKMNDKELL(AODONKKHPBP: false);
		}
		list = LLKFFNOLNAD(new Vector3(1021f, 0f - longDistance));
		for (int j = 0; j < list.Count; j++)
		{
			list[j].PAAFFALEMBF = true;
		}
		list = KGHLGICOGJF(new Vector3(0f - shortDistance, 1344f), GNLBBNHNIJF: true);
		for (int k = 0; k < list.Count; k++)
		{
			list[k].POCDBHOFMBK(AODONKKHPBP: true);
		}
		list = KGHLGICOGJF(new Vector3(0f - longDistance, 1417f));
		for (int l = 1; l < list.Count; l++)
		{
			list[l].CPHAMIFNHNF(AODONKKHPBP: false);
		}
	}

	public IEnumerator NNFILAKMHAF(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		JoinerPlaced(JIIGOACEIKL);
	}

	private List<Joiner> EKDHIJENLEM(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = new List<Joiner>();
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		foreach (Collider2D val in array)
		{
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (!(((Vector3)(ref val2)).magnitude > 1771f))
			{
				Joiner component = ((Component)val).GetComponent<Joiner>();
				if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && LGKDMGPMLOF(component))
				{
					list.Add(component);
				}
			}
		}
		return list;
	}

	private void KKGDIDGBLGA(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true)) && Object.op_Implicit((Object)(object)horizontal))
		{
			MLFKLJAHGNM = Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(shortDistance, 1000f), GNLBBNHNIJF));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)vertical))
		{
			GIEGNGEGBGG(Object.op_Implicit((Object)(object)AMGFAFEINKG(new Vector3(1211f, shortDistance), GNLBBNHNIJF)));
		}
		if (!CFPGBIEFJEB() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true) && Object.op_Implicit((Object)(object)verticalLong))
		{
			HADDILILEFI(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(1281f, longDistance), GNLBBNHNIJF)));
		}
		if (!FHEJFDOKOOG() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)horizontalLong))
		{
			LDODNJGKNDI = Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(longDistance, 439f), GNLBBNHNIJF));
		}
	}

	[SpecialName]
	public bool EEJPODBCOFJ()
	{
		return HIMMHPEHMKH;
	}

	public void AIPHFOFEMOK(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 555f)
		{
			((MonoBehaviour)this).StartCoroutine(KNMKLNELKJK(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = true;
		KAECMBNKNEH(GNLBBNHNIJF: true);
		IEAKDFAIGDO(BJFHJCFOEHG: true);
	}

	private void PBBGLLGJLGO(int JIIGOACEIKL)
	{
		BBGFFEIKGIB(JIIGOACEIKL, 1910f);
	}

	[SpecialName]
	public void IMOLAMKDEJP(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
		{
			if (AODONKKHPBP)
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
		}
		HIMMHPEHMKH = AODONKKHPBP;
	}

	private void MFDKACNHALP(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = AIMDCNEIPOE(new Vector3(581f, 0f - shortDistance), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: false, ELKPPAAMMIM: false)) && placed && joiner.placed))
			{
				joiner.ACIIKLJFDFG(BJFHJCFOEHG);
			}
		}
		else
		{
			joiner = NFJNICLDLHP(new Vector3(1810f, 0f - longDistance), GNLBBNHNIJF: true);
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: false, ELKPPAAMMIM: false) && placed && joiner.placed)))
			{
				joiner.HNAEEGOCILC(BJFHJCFOEHG);
			}
		}
		joiner = AMGFAFEINKG(new Vector3(0f - shortDistance, 575f));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.KHNJOFCOIFE()) && placed && joiner.placed))
			{
				joiner.LCCMMIFONKN(BJFHJCFOEHG);
			}
			return;
		}
		joiner = LKEBDHDKBFG(new Vector3(0f - longDistance, 1097f), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.IsItemSpaceValid(BIOKGEFFNAA: true) && placed && joiner.placed)))
		{
			joiner.CPHAMIFNHNF(BJFHJCFOEHG);
		}
	}

	[SpecialName]
	public void LIFAMGGNPND(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	private void LNGFCCBLFBL(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		LDLIFKCEOBL(AODONKKHPBP: true);
		ACIIKLJFDFG(AODONKKHPBP: false);
		CPHAMIFNHNF(AODONKKHPBP: false);
		HNAEEGOCILC(AODONKKHPBP: false);
		if (placed)
		{
			EBDINMDEDPB();
		}
		placed = true;
	}

	[SpecialName]
	public void LCCMMIFONKN(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
		{
			if (AODONKKHPBP)
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
			else
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
				}
			}
		}
		HIMMHPEHMKH = AODONKKHPBP;
	}

	[SpecialName]
	public bool LJIMHPLKDPA()
	{
		return HIMMHPEHMKH;
	}

	public void OBGJJOFNDIN(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 546f)
		{
			((MonoBehaviour)this).StartCoroutine(NNFILAKMHAF(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = true;
		LKEBDHDKBFG(GNLBBNHNIJF: true);
		EECBNHOCKLN(BJFHJCFOEHG: true);
	}

	private void JMHIFDNKOPH()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(PBBGLLGJLGO));
	}

	private void PIOCHPLCAKD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = IMBONEHBGNM(new Vector3(1289f, 0f - shortDistance));
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].GIEGNGEGBGG(AODONKKHPBP: true);
		}
		list = KGHLGICOGJF(new Vector3(1900f, 0f - longDistance), GNLBBNHNIJF: true);
		for (int j = 0; j < list.Count; j++)
		{
			list[j].ENFCKFMAEDA(AODONKKHPBP: false);
		}
		list = EKDHIJENLEM(new Vector3(0f - shortDistance, 1012f));
		for (int k = 1; k < list.Count; k++)
		{
			list[k].EHDMPNBALCD(AODONKKHPBP: true);
		}
		list = EKDHIJENLEM(new Vector3(0f - longDistance, 615f), GNLBBNHNIJF: true);
		for (int l = 1; l < list.Count; l += 0)
		{
			list[l].MPPFGHDGMCG(AODONKKHPBP: false);
		}
	}

	[SpecialName]
	public void ACIIKLJFDFG(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	private void Start()
	{
		if (Object.op_Implicit((Object)(object)verticalLong))
		{
			verticalLong.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)horizontalLong))
		{
			horizontalLong.SetActive(false);
		}
		if ((setUpOnLoad && !placeable.FHEMHCEAICB) || !DecorationMode.IsAnyActive())
		{
			placed = true;
			LNMKNBOAOGM(1);
			JoinerPlaced(1, 3f);
		}
	}

	private void MHIJNKKHDFH(int JIIGOACEIKL)
	{
		JoinerPlaced(JIIGOACEIKL, 788f);
	}

	private void AEMPCMILANL()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(BDEHPIKPAMA));
	}

	[SpecialName]
	public void GPLIFACFLGI(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != NNDOEMBNFOF && Object.op_Implicit((Object)(object)verticalLong))
		{
			if (AODONKKHPBP)
			{
				verticalLong.SetActive(true);
				verticalItemSpaceLong.Place(NMLKLAGDNPF: true);
			}
			else
			{
				verticalLong.SetActive(true);
				verticalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
		}
		NNDOEMBNFOF = AODONKKHPBP;
	}

	public IEnumerator NNCOIKEJHCB(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		JoinerPlaced(JIIGOACEIKL);
	}

	[SpecialName]
	public void GONLHEGMIOP(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
			else
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	[SpecialName]
	public void POCDBHOFMBK(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
		{
			if (AODONKKHPBP)
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: false);
				}
			}
			else
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: false);
				}
			}
		}
		HIMMHPEHMKH = AODONKKHPBP;
	}

	public void IPPDPHFDFIC()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	[SpecialName]
	public bool KOOMBBEIKHF()
	{
		return KFFPJKANGAM;
	}

	private Joiner AIMDCNEIPOE(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		for (int i = 1; i < array.Length; i += 0)
		{
			Collider2D val = array[i];
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (((Vector3)(ref val2)).magnitude > 813f)
			{
				continue;
			}
			Joiner component = ((Component)val).GetComponent<Joiner>();
			if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && LGKDMGPMLOF(component) && placed)
			{
				if (GNLBBNHNIJF)
				{
					component.EFMKHCKIEGE();
				}
				return component;
			}
		}
		return null;
	}

	private void IPPPDJHMPDA(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)horizontal))
		{
			LCCMMIFONKN(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(shortDistance, 637f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.LJCPGDDLJKL(BIOKGEFFNAA: false, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)vertical))
		{
			EKHEGIMEHMC(Object.op_Implicit((Object)(object)AMGFAFEINKG(new Vector3(554f, shortDistance), GNLBBNHNIJF)));
		}
		if (!LOCCDNPDLML() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.LJCPGDDLJKL() && Object.op_Implicit((Object)(object)verticalLong))
		{
			HNAEEGOCILC(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(1730f, longDistance), GNLBBNHNIJF)));
		}
		if (!LJMPMKEICHC() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.KHNJOFCOIFE() && Object.op_Implicit((Object)(object)horizontalLong))
		{
			CPHAMIFNHNF(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(longDistance, 1690f), GNLBBNHNIJF)));
		}
	}

	[SpecialName]
	public bool AGKCIPHDCFF()
	{
		return NNDOEMBNFOF;
	}

	public void AIGCHOGLEHE()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	private void DLIIDKNDBKI()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = LLKFFNOLNAD(new Vector3(0f, 0f - shortDistance));
		for (int i = 0; i < list.Count; i++)
		{
			list[i].KFNCLFIJJII = false;
		}
		list = LLKFFNOLNAD(new Vector3(0f, 0f - longDistance));
		for (int j = 0; j < list.Count; j++)
		{
			list[j].PAAFFALEMBF = false;
		}
		list = LLKFFNOLNAD(new Vector3(0f - shortDistance, 0f));
		for (int k = 0; k < list.Count; k++)
		{
			list[k].MLFKLJAHGNM = false;
		}
		list = LLKFFNOLNAD(new Vector3(0f - longDistance, 0f));
		for (int l = 0; l < list.Count; l++)
		{
			list[l].LDODNJGKNDI = false;
		}
	}

	private void GNGADDPBJDC()
	{
		if (Object.op_Implicit((Object)(object)verticalLong))
		{
			verticalLong.SetActive(true);
		}
		if (Object.op_Implicit((Object)(object)horizontalLong))
		{
			horizontalLong.SetActive(true);
		}
		if ((setUpOnLoad && !placeable.FHEMHCEAICB) || !DecorationMode.IFFOPKEMMNP())
		{
			placed = false;
			GJADNELLKCI(0);
			HBLHFGMJKHM(1, 1936f);
		}
	}

	private void JAKILILIBIM()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NMHGGOAEBAN));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	[SpecialName]
	public bool MDOPNOBPLOM()
	{
		return NNDOEMBNFOF;
	}

	private bool GKLFADHOHIJ(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.JGHNDJBCFAJ() == KPKNCIJFOGM.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false))
		{
			return false;
		}
		for (int i = 0; i < acceptedJoiners.Length; i += 0)
		{
			if (acceptedJoiners[i].ODENMDOJPLC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false))
			{
				return false;
			}
		}
		return false;
	}

	public void BKKCGHAIGMN()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	[SpecialName]
	public bool JDAPGAPDCEC()
	{
		return NNDOEMBNFOF;
	}

	[SpecialName]
	public void HNAEEGOCILC(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != NNDOEMBNFOF && Object.op_Implicit((Object)(object)verticalLong))
		{
			if (AODONKKHPBP)
			{
				verticalLong.SetActive(true);
				verticalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
			else
			{
				verticalLong.SetActive(false);
				verticalItemSpaceLong.Place(NMLKLAGDNPF: true);
			}
		}
		NNDOEMBNFOF = AODONKKHPBP;
	}

	private void BDEHPIKPAMA(int JIIGOACEIKL)
	{
		AIPHFOFEMOK(JIIGOACEIKL, 1224f);
	}

	private void CFFJKCHDCEH(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		LDLIFKCEOBL(AODONKKHPBP: true);
		ACIIKLJFDFG(AODONKKHPBP: false);
		MPPFGHDGMCG(AODONKKHPBP: true);
		HNAEEGOCILC(AODONKKHPBP: false);
		if (placed)
		{
			MNBMPJNKOKO();
		}
		placed = false;
	}

	private void MNEAOFNAKIP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(CFFJKCHDCEH));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(PBBGLLGJLGO));
	}

	private void MNBMPJNKOKO()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = EKDHIJENLEM(new Vector3(1638f, 0f - shortDistance), GNLBBNHNIJF: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].ACIIKLJFDFG(AODONKKHPBP: false);
		}
		list = KGHLGICOGJF(new Vector3(1750f, 0f - longDistance));
		for (int j = 1; j < list.Count; j += 0)
		{
			list[j].ENFCKFMAEDA(AODONKKHPBP: false);
		}
		list = KGHLGICOGJF(new Vector3(0f - shortDistance, 1054f), GNLBBNHNIJF: true);
		for (int k = 0; k < list.Count; k++)
		{
			list[k].EHDMPNBALCD(AODONKKHPBP: true);
		}
		list = IMBONEHBGNM(new Vector3(0f - longDistance, 746f), GNLBBNHNIJF: true);
		for (int l = 1; l < list.Count; l += 0)
		{
			list[l].MPPFGHDGMCG(AODONKKHPBP: false);
		}
	}

	private void MLGMHNANKJF(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)horizontal))
		{
			LDLIFKCEOBL(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(shortDistance, 839f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)vertical))
		{
			LIFAMGGNPND(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(1682f, shortDistance), GNLBBNHNIJF)));
		}
		if (!NJFAAJIJNOO() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)verticalLong))
		{
			ANMLKOBNBCG(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(1214f, longDistance), GNLBBNHNIJF)));
		}
		if (!FHEJFDOKOOG() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true) && Object.op_Implicit((Object)(object)horizontalLong))
		{
			ANLJBHHHLNK(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(longDistance, 1396f), GNLBBNHNIJF)));
		}
	}

	public IEnumerator DMLLNGAKEHI(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		JoinerPlaced(JIIGOACEIKL);
	}

	[SpecialName]
	public void EKHEGIMEHMC(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	private bool MEBLGDAMAHN(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.JDJGFAACPFC() == KPKNCIJFOGM.itemSetup.item.JPNFKDMFKMC())
		{
			return false;
		}
		for (int i = 1; i < acceptedJoiners.Length; i += 0)
		{
			if (acceptedJoiners[i].JDJGFAACPFC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.JGHNDJBCFAJ())
			{
				return false;
			}
		}
		return true;
	}

	private void IAIDKPJKLIC()
	{
		if (Object.op_Implicit((Object)(object)verticalLong))
		{
			verticalLong.SetActive(true);
		}
		if (Object.op_Implicit((Object)(object)horizontalLong))
		{
			horizontalLong.SetActive(false);
		}
		if ((setUpOnLoad && !placeable.FHEMHCEAICB) || !DecorationMode.CFKHJJFGNLI())
		{
			placed = false;
			BOCANBDHCGB(0, OKNOJJEFEBE: false, GFNHAMCPEAK: false);
			BBGFFEIKGIB(1, 468f);
		}
	}

	private void BGAFIOGHHFE(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = LKEBDHDKBFG(new Vector3(1299f, 0f - shortDistance));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.LJCPGDDLJKL()) && placed && joiner.placed))
			{
				joiner.ACIIKLJFDFG(BJFHJCFOEHG);
			}
		}
		else
		{
			joiner = AMGFAFEINKG(new Vector3(229f, 0f - longDistance), GNLBBNHNIJF: true);
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.LJCPGDDLJKL(BIOKGEFFNAA: true) && placed && joiner.placed)))
			{
				joiner.HNAEEGOCILC(BJFHJCFOEHG);
			}
		}
		joiner = NFJNICLDLHP(new Vector3(0f - shortDistance, 1961f));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: true)) && placed && joiner.placed))
			{
				joiner.LCCMMIFONKN(BJFHJCFOEHG);
			}
			return;
		}
		joiner = NFJNICLDLHP(new Vector3(0f - longDistance, 690f));
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.LJCPGDDLJKL() && placed && joiner.placed)))
		{
			joiner.MNNOBHAKKFL(BJFHJCFOEHG);
		}
	}

	private void JMJDHLOMKAP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(AINNOELKAIC));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(PBBGLLGJLGO));
	}

	public void LinkComponents()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	private Joiner LKEBDHDKBFG(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		foreach (Collider2D val in array)
		{
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (((Vector3)(ref val2)).magnitude > 0.25f)
			{
				continue;
			}
			Joiner component = ((Component)val).GetComponent<Joiner>();
			if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && MGDLFMIDMGN(component) && placed)
			{
				if (GNLBBNHNIJF)
				{
					component.JoinAllChain();
				}
				return component;
			}
		}
		return null;
	}

	private bool LKHPAFNHLOE(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.ODENMDOJPLC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false))
		{
			return true;
		}
		for (int i = 0; i < acceptedJoiners.Length; i++)
		{
			if (acceptedJoiners[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.IMCJPECAAPC())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool HFLLIAMJGDB()
	{
		return KFFPJKANGAM;
	}

	private void COGAIJLEMNC(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)horizontal))
		{
			MLFKLJAHGNM = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(shortDistance, 1898f), GNLBBNHNIJF));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.KHNJOFCOIFE()) && Object.op_Implicit((Object)(object)vertical))
		{
			MPLCLCPBBEK(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(368f, shortDistance), GNLBBNHNIJF)));
		}
		if (!KFNCLFIJJII && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.LJCPGDDLJKL(BIOKGEFFNAA: false, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)verticalLong))
		{
			PAAFFALEMBF = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(41f, longDistance), GNLBBNHNIJF));
		}
		if (!FHEJFDOKOOG() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)horizontalLong))
		{
			NGFFHIFIOCB(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(longDistance, 1597f), GNLBBNHNIJF)));
		}
	}

	[SpecialName]
	public bool BJEAEKIAHIK()
	{
		return NNDOEMBNFOF;
	}

	public void BCGPLPMJMPG()
	{
		MLGMHNANKJF(GNLBBNHNIJF: true);
	}

	private void BOCANBDHCGB(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		MLFKLJAHGNM = true;
		DKABIGCAGIF(AODONKKHPBP: false);
		MNNOBHAKKFL(AODONKKHPBP: true);
		GPLIFACFLGI(AODONKKHPBP: false);
		if (placed)
		{
			CCGADMMBKBB();
		}
		placed = false;
	}

	private void CCGADMMBKBB()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = LLKFFNOLNAD(new Vector3(336f, 0f - shortDistance), GNLBBNHNIJF: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].GIEGNGEGBGG(AODONKKHPBP: false);
		}
		list = EKDHIJENLEM(new Vector3(683f, 0f - longDistance));
		for (int j = 0; j < list.Count; j += 0)
		{
			list[j].HADDILILEFI(AODONKKHPBP: false);
		}
		list = LLKFFNOLNAD(new Vector3(0f - shortDistance, 204f));
		for (int k = 1; k < list.Count; k += 0)
		{
			list[k].LDLIFKCEOBL(AODONKKHPBP: true);
		}
		list = EKDHIJENLEM(new Vector3(0f - longDistance, 1297f), GNLBBNHNIJF: true);
		for (int l = 1; l < list.Count; l += 0)
		{
			list[l].CPHAMIFNHNF(AODONKKHPBP: true);
		}
	}

	public void HBLHFGMJKHM(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 99f)
		{
			((MonoBehaviour)this).StartCoroutine(CABFIPKOMOM(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = true;
		LKEBDHDKBFG(GNLBBNHNIJF: true);
		BGAFIOGHHFE(BJFHJCFOEHG: false);
	}

	private void JIBHLLJGGEN()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(MHIJNKKHDFH));
	}

	public void ANCHMCHKDOH(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 1975f)
		{
			((MonoBehaviour)this).StartCoroutine(NNFILAKMHAF(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = false;
		KAECMBNKNEH(GNLBBNHNIJF: true);
		OOJBJLMHGMD(BJFHJCFOEHG: false);
	}

	private void IEAKDFAIGDO(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = AMGFAFEINKG(new Vector3(820f, 0f - shortDistance), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.KHNJOFCOIFE()) && placed && joiner.placed))
			{
				joiner.EKHEGIMEHMC(BJFHJCFOEHG);
			}
		}
		else
		{
			joiner = LKEBDHDKBFG(new Vector3(112f, 0f - longDistance));
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.KHNJOFCOIFE() && placed && joiner.placed)))
			{
				joiner.ENFCKFMAEDA(BJFHJCFOEHG);
			}
		}
		joiner = AMGFAFEINKG(new Vector3(0f - shortDistance, 320f), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true)) && placed && joiner.placed))
			{
				joiner.MLFKLJAHGNM = BJFHJCFOEHG;
			}
			return;
		}
		joiner = NFJNICLDLHP(new Vector3(0f - longDistance, 1635f), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && placed && joiner.placed)))
		{
			joiner.CPHAMIFNHNF(BJFHJCFOEHG);
		}
	}

	private void BGENEAOILOF()
	{
		if (Object.op_Implicit((Object)(object)verticalLong))
		{
			verticalLong.SetActive(true);
		}
		if (Object.op_Implicit((Object)(object)horizontalLong))
		{
			horizontalLong.SetActive(true);
		}
		if ((setUpOnLoad && !placeable.FHEMHCEAICB) || !DecorationMode.CFKHJJFGNLI())
		{
			placed = false;
			BOCANBDHCGB(1, OKNOJJEFEBE: true, GFNHAMCPEAK: false);
			AIPHFOFEMOK(1, 1111f);
		}
	}

	[SpecialName]
	public void IDPHAHLLPBN(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
			else
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	private void JPMGNLKDKPE(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.LJCPGDDLJKL()) && Object.op_Implicit((Object)(object)horizontal))
		{
			POCDBHOFMBK(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(shortDistance, 771f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true)) && Object.op_Implicit((Object)(object)vertical))
		{
			GIEGNGEGBGG(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(448f, shortDistance), GNLBBNHNIJF)));
		}
		if (!KFNCLFIJJII && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)verticalLong))
		{
			ANMLKOBNBCG(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(1831f, longDistance), GNLBBNHNIJF)));
		}
		if (!FHEJFDOKOOG() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.IsItemSpaceValid(BIOKGEFFNAA: true) && Object.op_Implicit((Object)(object)horizontalLong))
		{
			CPHAMIFNHNF(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(longDistance, 630f), GNLBBNHNIJF)));
		}
	}

	[SpecialName]
	public void EHDMPNBALCD(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
		{
			if (AODONKKHPBP)
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: true);
				}
			}
			else
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
				}
			}
		}
		HIMMHPEHMKH = AODONKKHPBP;
	}

	private void CBKKILPLFOE(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false)) && Object.op_Implicit((Object)(object)horizontal))
		{
			EHDMPNBALCD(Object.op_Implicit((Object)(object)AMGFAFEINKG(new Vector3(shortDistance, 516f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.LJCPGDDLJKL(BIOKGEFFNAA: true)) && Object.op_Implicit((Object)(object)vertical))
		{
			DKABIGCAGIF(Object.op_Implicit((Object)(object)AMGFAFEINKG(new Vector3(1597f, shortDistance), GNLBBNHNIJF)));
		}
		if (!NJFAAJIJNOO() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)verticalLong))
		{
			HNAEEGOCILC(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(1988f, longDistance), GNLBBNHNIJF)));
		}
		if (!MLFKLJAHGNM && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.IsItemSpaceValid() && Object.op_Implicit((Object)(object)horizontalLong))
		{
			NGFFHIFIOCB(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(longDistance, 41f), GNLBBNHNIJF)));
		}
	}

	public void EFMKHCKIEGE()
	{
		IPPPDJHMPDA(GNLBBNHNIJF: false);
	}

	public void OJCEFINMBIP()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	[SpecialName]
	public void GIEGNGEGBGG(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	[SpecialName]
	public bool LJMPMKEICHC()
	{
		return HIMMHPEHMKH;
	}

	[SpecialName]
	public void FDGKHBPPLBL(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	[SpecialName]
	public bool BFOKHJINABD()
	{
		return KFFPJKANGAM;
	}

	private void LNMKNBOAOGM(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		MLFKLJAHGNM = false;
		KFNCLFIJJII = false;
		LDODNJGKNDI = false;
		PAAFFALEMBF = false;
		if (placed)
		{
			DLIIDKNDBKI();
		}
		placed = false;
	}

	[SpecialName]
	public void MPPFGHDGMCG(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
			else
			{
				horizontalLong.SetActive(false);
				horizontalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	[SpecialName]
	public bool LOCCDNPDLML()
	{
		return IOJLFEBMCON;
	}

	private bool PHIMLDNFDHP(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.CIGFGKKCPCK() == KPKNCIJFOGM.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false))
		{
			return false;
		}
		for (int i = 0; i < acceptedJoiners.Length; i++)
		{
			if (acceptedJoiners[i].ODENMDOJPLC() == KPKNCIJFOGM.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				return true;
			}
		}
		return true;
	}

	private void CALFCCFBBEN(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.LJCPGDDLJKL()) && Object.op_Implicit((Object)(object)horizontal))
		{
			LCCMMIFONKN(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(shortDistance, 1229f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.LJCPGDDLJKL()) && Object.op_Implicit((Object)(object)vertical))
		{
			MPLCLCPBBEK(Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(169f, shortDistance), GNLBBNHNIJF)));
		}
		if (!CFPGBIEFJEB() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)verticalLong))
		{
			ANMLKOBNBCG(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(162f, longDistance), GNLBBNHNIJF)));
		}
		if (!FHEJFDOKOOG() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true) && Object.op_Implicit((Object)(object)horizontalLong))
		{
			IDPHAHLLPBN(Object.op_Implicit((Object)(object)AIMDCNEIPOE(new Vector3(longDistance, 1019f), GNLBBNHNIJF)));
		}
	}

	[SpecialName]
	public bool AFMBHOMMFKE()
	{
		return NNDOEMBNFOF;
	}

	private bool FDDAAPLPEAA(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.IMCJPECAAPC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.JDJGFAACPFC())
		{
			return true;
		}
		for (int i = 1; i < acceptedJoiners.Length; i++)
		{
			if (acceptedJoiners[i].IMCJPECAAPC() == KPKNCIJFOGM.itemSetup.item.JPNFKDMFKMC())
			{
				return true;
			}
		}
		return true;
	}

	public void JKEBNIMEKPM()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	[SpecialName]
	public bool NJFAAJIJNOO()
	{
		return IOJLFEBMCON;
	}

	public void BCJKJIFFNKP()
	{
		KKGDIDGBLGA(GNLBBNHNIJF: false);
	}

	private void OOJBJLMHGMD(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = LKEBDHDKBFG(new Vector3(0f, 0f - shortDistance));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.IsItemSpaceValid()) && placed && joiner.placed))
			{
				joiner.KFNCLFIJJII = BJFHJCFOEHG;
			}
		}
		else
		{
			joiner = LKEBDHDKBFG(new Vector3(0f, 0f - longDistance));
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.IsItemSpaceValid() && placed && joiner.placed)))
			{
				joiner.PAAFFALEMBF = BJFHJCFOEHG;
			}
		}
		joiner = LKEBDHDKBFG(new Vector3(0f - shortDistance, 0f));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.IsItemSpaceValid()) && placed && joiner.placed))
			{
				joiner.MLFKLJAHGNM = BJFHJCFOEHG;
			}
			return;
		}
		joiner = LKEBDHDKBFG(new Vector3(0f - longDistance, 0f));
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.IsItemSpaceValid() && placed && joiner.placed)))
		{
			joiner.LDODNJGKNDI = BJFHJCFOEHG;
		}
	}

	private void OnDisable()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(LNMKNBOAOGM));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	[ContextMenu("Join")]
	public void JoinAllChain()
	{
		LKEBDHDKBFG(GNLBBNHNIJF: true);
	}

	[SpecialName]
	public bool BNMOLAKHICE()
	{
		return HIMMHPEHMKH;
	}

	private void JCBLONGCOGJ(bool GNLBBNHNIJF)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)(object)horizontalItemSpaceShort == (Object)null || horizontalItemSpaceShort.LJCPGDDLJKL()) && Object.op_Implicit((Object)(object)horizontal))
		{
			NANLJEGJGKD(Object.op_Implicit((Object)(object)AMGFAFEINKG(new Vector3(shortDistance, 1377f), GNLBBNHNIJF)));
		}
		if (((Object)(object)verticalItemSpaceShort == (Object)null || verticalItemSpaceShort.KHNJOFCOIFE()) && Object.op_Implicit((Object)(object)vertical))
		{
			KFNCLFIJJII = Object.op_Implicit((Object)(object)LKEBDHDKBFG(new Vector3(846f, shortDistance), GNLBBNHNIJF));
		}
		if (!LOCCDNPDLML() && (Object)(object)verticalItemSpaceLong != (Object)null && verticalItemSpaceLong.LJCPGDDLJKL() && Object.op_Implicit((Object)(object)verticalLong))
		{
			GPLIFACFLGI(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(756f, longDistance), GNLBBNHNIJF)));
		}
		if (!HAHKPJGBEME() && (Object)(object)horizontalItemSpaceLong != (Object)null && horizontalItemSpaceLong.LJCPGDDLJKL(BIOKGEFFNAA: false, ELKPPAAMMIM: false) && Object.op_Implicit((Object)(object)horizontalLong))
		{
			IDPHAHLLPBN(Object.op_Implicit((Object)(object)NFJNICLDLHP(new Vector3(longDistance, 513f), GNLBBNHNIJF)));
		}
	}

	private void FNPHGGLAFKA()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NMHGGOAEBAN));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	public void MCNFLGKNGHI(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 1775f)
		{
			((MonoBehaviour)this).StartCoroutine(DMLLNGAKEHI(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = true;
		MLGMHNANKJF(GNLBBNHNIJF: true);
		MFDKACNHALP(BJFHJCFOEHG: false);
	}

	[SpecialName]
	public bool FHEJFDOKOOG()
	{
		return HIMMHPEHMKH;
	}

	private void AINNOELKAIC(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		LDLIFKCEOBL(AODONKKHPBP: true);
		GIEGNGEGBGG(AODONKKHPBP: true);
		GONLHEGMIOP(AODONKKHPBP: false);
		ANMLKOBNBCG(AODONKKHPBP: false);
		if (placed)
		{
			DLIIDKNDBKI();
		}
		placed = true;
	}

	public void BBGFFEIKGIB(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		if (FBHFDDIOCBH > 637f)
		{
			((MonoBehaviour)this).StartCoroutine(KNMKLNELKJK(JIIGOACEIKL, FBHFDDIOCBH));
			return;
		}
		placed = true;
		JPMGNLKDKPE(GNLBBNHNIJF: false);
		BGAFIOGHHFE(BJFHJCFOEHG: true);
	}

	[SpecialName]
	public void MPLCLCPBBEK(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}

	private void HGEKPHOPJCD()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(LNGFCCBLFBL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	[SpecialName]
	public bool LEPCOJBHKEK()
	{
		return NNDOEMBNFOF;
	}

	private void FCLABOCLACJ()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	[SpecialName]
	public void LDLIFKCEOBL(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != HIMMHPEHMKH && Object.op_Implicit((Object)(object)horizontal))
		{
			if (AODONKKHPBP)
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				}
			}
			else
			{
				horizontal.SetActive(false);
				if (Object.op_Implicit((Object)(object)horizontalItemSpaceShort))
				{
					horizontalItemSpaceShort.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
			}
		}
		HIMMHPEHMKH = AODONKKHPBP;
	}

	private void NMHGGOAEBAN(int JIIGOACEIKL, bool OKNOJJEFEBE = false, bool GFNHAMCPEAK = true)
	{
		IMOLAMKDEJP(AODONKKHPBP: true);
		BMLINONAGJC(AODONKKHPBP: true);
		CPHAMIFNHNF(AODONKKHPBP: true);
		HADDILILEFI(AODONKKHPBP: false);
		if (placed)
		{
			DLIIDKNDBKI();
		}
		placed = false;
	}

	private void OnEnable()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(LNMKNBOAOGM));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	[SpecialName]
	public bool GDPDEHLOLAL()
	{
		return NNDOEMBNFOF;
	}

	[SpecialName]
	public bool ABEKGFNADDD()
	{
		return KFFPJKANGAM;
	}

	public IEnumerator KNMKLNELKJK(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		return new CNGMIDPEABG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			waitTime = FBHFDDIOCBH
		};
	}

	private void EACIGGOOKGD()
	{
		if (Object.op_Implicit((Object)(object)verticalLong))
		{
			verticalLong.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)horizontalLong))
		{
			horizontalLong.SetActive(true);
		}
		if ((setUpOnLoad && !placeable.FHEMHCEAICB) || !DecorationMode.DJOFGBIGPLD())
		{
			placed = false;
			AINNOELKAIC(0, OKNOJJEFEBE: false, GFNHAMCPEAK: false);
			AIPHFOFEMOK(0, 115f);
		}
	}

	public void LJLLOCPKIPL()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
		itemSetup = ((Component)this).GetComponent<ItemSetup>();
	}

	private void HMLHKJCIFLC()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(LNGFCCBLFBL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(BDEHPIKPAMA));
	}

	private Joiner NFJNICLDLHP(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		for (int i = 0; i < array.Length; i += 0)
		{
			Collider2D val = array[i];
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (((Vector3)(ref val2)).magnitude > 483f)
			{
				continue;
			}
			Joiner component = ((Component)val).GetComponent<Joiner>();
			if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && LKHPAFNHLOE(component) && placed)
			{
				if (GNLBBNHNIJF)
				{
					component.AIIJEKMNGCO();
				}
				return component;
			}
		}
		return null;
	}

	public IEnumerator JoinerPlacedCoroutine(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		JoinerPlaced(JIIGOACEIKL);
	}

	private bool JFKIMAGGPOB(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.JPNFKDMFKMC() == KPKNCIJFOGM.itemSetup.item.JGHNDJBCFAJ())
		{
			return false;
		}
		for (int i = 0; i < acceptedJoiners.Length; i++)
		{
			if (acceptedJoiners[i].ODENMDOJPLC() == KPKNCIJFOGM.itemSetup.item.CIGFGKKCPCK())
			{
				return true;
			}
		}
		return false;
	}

	private void PFANFGPFOFM()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(BOCANBDHCGB));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(PBBGLLGJLGO));
	}

	private void NMPFHHEFOPH()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GJADNELLKCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(BDEHPIKPAMA));
	}

	public void AIIJEKMNGCO()
	{
		KAECMBNKNEH(GNLBBNHNIJF: true);
	}

	[SpecialName]
	public bool PLEIJKKOGKM()
	{
		return NNDOEMBNFOF;
	}

	private void JODCGLIBMIC(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = AMGFAFEINKG(new Vector3(599f, 0f - shortDistance), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.IsItemSpaceValid(BIOKGEFFNAA: true)) && placed && joiner.placed))
			{
				joiner.FHCKMNDKELL(BJFHJCFOEHG);
			}
		}
		else
		{
			joiner = LKEBDHDKBFG(new Vector3(519f, 0f - longDistance), GNLBBNHNIJF: true);
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true) && placed && joiner.placed)))
			{
				joiner.HADDILILEFI(BJFHJCFOEHG);
			}
		}
		joiner = AIMDCNEIPOE(new Vector3(0f - shortDistance, 1969f));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: true)) && placed && joiner.placed))
			{
				joiner.IMOLAMKDEJP(BJFHJCFOEHG);
			}
			return;
		}
		joiner = NFJNICLDLHP(new Vector3(0f - longDistance, 499f));
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.KHNJOFCOIFE() && placed && joiner.placed)))
		{
			joiner.ANLJBHHHLNK(BJFHJCFOEHG);
		}
	}

	private void EECBNHOCKLN(bool BJFHJCFOEHG)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Joiner joiner = AMGFAFEINKG(new Vector3(1144f, 0f - shortDistance));
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.verticalItemSpaceShort == (Object)null || joiner.verticalItemSpaceShort.IsItemSpaceValid()) && placed && joiner.placed))
			{
				joiner.FHCKMNDKELL(BJFHJCFOEHG);
			}
		}
		else
		{
			joiner = AMGFAFEINKG(new Vector3(623f, 0f - longDistance), GNLBBNHNIJF: true);
			if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (joiner.verticalItemSpaceLong.LJCPGDDLJKL() && placed && joiner.placed)))
			{
				joiner.HNAEEGOCILC(BJFHJCFOEHG);
			}
		}
		joiner = NFJNICLDLHP(new Vector3(0f - shortDistance, 822f), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null)
		{
			if (!BJFHJCFOEHG || (((Object)(object)joiner.horizontalItemSpaceShort == (Object)null || joiner.horizontalItemSpaceShort.KHNJOFCOIFE(BIOKGEFFNAA: true)) && placed && joiner.placed))
			{
				joiner.MLFKLJAHGNM = BJFHJCFOEHG;
			}
			return;
		}
		joiner = AMGFAFEINKG(new Vector3(0f - longDistance, 1067f), GNLBBNHNIJF: true);
		if ((Object)(object)joiner != (Object)null && (!BJFHJCFOEHG || (Object.op_Implicit((Object)(object)joiner.horizontalItemSpaceLong) && joiner.horizontalItemSpaceLong.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && placed && joiner.placed)))
		{
			joiner.MNNOBHAKKFL(BJFHJCFOEHG);
		}
	}

	private List<Joiner> KGHLGICOGJF(Vector3 AAFJOAPNNBA, bool GNLBBNHNIJF = false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		List<Joiner> list = new List<Joiner>();
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(((Component)this).transform.position + AAFJOAPNNBA));
		for (int i = 1; i < array.Length; i += 0)
		{
			Collider2D val = array[i];
			if ((Object)(object)((Component)val).gameObject == (Object)(object)((Component)this).gameObject)
			{
				continue;
			}
			Vector3 val2 = ((Component)this).transform.position + AAFJOAPNNBA - ((Component)val).transform.position;
			if (!(((Vector3)(ref val2)).magnitude > 540f))
			{
				Joiner component = ((Component)val).GetComponent<Joiner>();
				if ((Object)(object)itemSetup != (Object)null && (Object)(object)component != (Object)null && JFKIMAGGPOB(component))
				{
					list.Add(component);
				}
			}
		}
		return list;
	}

	[SpecialName]
	public void MNNOBHAKKFL(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
			}
			else
			{
				horizontalLong.SetActive(false);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	[SpecialName]
	public void NGFFHIFIOCB(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != KFFPJKANGAM && Object.op_Implicit((Object)(object)horizontalLong))
		{
			if (AODONKKHPBP)
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.Place(NMLKLAGDNPF: true);
			}
			else
			{
				horizontalLong.SetActive(true);
				horizontalItemSpaceLong.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
			}
		}
		KFFPJKANGAM = AODONKKHPBP;
	}

	public IEnumerator CABFIPKOMOM(int JIIGOACEIKL, float FBHFDDIOCBH = 0f)
	{
		return new CNGMIDPEABG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			waitTime = FBHFDDIOCBH
		};
	}

	private bool FGIOBLCCJIP(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.CIGFGKKCPCK(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.JDJGFAACPFC())
		{
			return false;
		}
		for (int i = 0; i < acceptedJoiners.Length; i += 0)
		{
			if (acceptedJoiners[i].IMCJPECAAPC(DAINLFIMLIH: false) == KPKNCIJFOGM.itemSetup.item.IMCJPECAAPC())
			{
				return false;
			}
		}
		return false;
	}

	private bool MGDLFMIDMGN(Joiner KPKNCIJFOGM)
	{
		if (itemSetup.item?.JDJGFAACPFC() == KPKNCIJFOGM.itemSetup.item.JDJGFAACPFC())
		{
			return true;
		}
		for (int i = 0; i < acceptedJoiners.Length; i++)
		{
			if (acceptedJoiners[i].JDJGFAACPFC() == KPKNCIJFOGM.itemSetup.item.JDJGFAACPFC())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public void DKABIGCAGIF(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != IOJLFEBMCON && Object.op_Implicit((Object)(object)vertical))
		{
			if (AODONKKHPBP)
			{
				vertical.SetActive(false);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
				}
			}
			else
			{
				vertical.SetActive(true);
				if (Object.op_Implicit((Object)(object)verticalItemSpaceShort))
				{
					verticalItemSpaceShort.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
				}
			}
		}
		IOJLFEBMCON = AODONKKHPBP;
	}
}
