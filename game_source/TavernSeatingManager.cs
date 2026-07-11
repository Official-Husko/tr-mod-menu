using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TavernSeatingManager : MonoBehaviour, ISingleton
{
	private static TavernSeatingManager GGFJGHHHEJC;

	private static List<Seat> KABPFOBPBJK;

	private static List<Seat> OEDOFDBHEKK = new List<Seat>();

	private static List<Seat> NJHNNGCDOGB;

	public static Seat[] GAGEINOKNAK { get; private set; }

	public static void JNFDMFDOCFG(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	private void NAOBODGBECL()
	{
		GGFJGHHHEJC = this;
		FFPKEGOCMNP();
	}

	public static void AddSeat(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	private void Start()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GetAllTavernSeats));
		GetAllTavernSeats();
	}

	private void AGPONCCIFHC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(JELKEBBHJDJ));
	}

	[SpecialName]
	private static void OPPAJNKEPNI(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	public static void MOPMFKFEAKH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 1; i < OEDOFDBHEKK.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == (ZoneType.WithoutZone | ZoneType.CraftingRoom))
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		KIGINMIBEJP(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public static Seat[] OBHGDHFPDCO()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 1; i < LNHPEHJLPNF().Length; i += 0)
		{
			if (!LNHPEHJLPNF()[i].reserved && (Object)(object)LNHPEHJLPNF()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(DKFBAGJBPGP()[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	public void ResetSingleton()
	{
		GAGEINOKNAK = new Seat[0];
		OEDOFDBHEKK = new List<Seat>();
	}

	private void BGENEAOILOF()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HJPHJCCCJMH));
		GGENKCNNFCE();
	}

	public static void ANBEEJNFDIA(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static bool KKOPPOBAPAO()
	{
		for (int i = 0; i < DKFBAGJBPGP().Length; i += 0)
		{
			if (!OGDDCMFDCAH()[i].reserved && (Object)(object)ACPEOIOHAHF()[i].table != (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	public static void JDNJPALAIFH(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	private void HEGNINLLINP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(HJPHJCCCJMH));
	}

	private void EAEKKBEJMFC()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LMBFJBEACKL));
		HJPHJCCCJMH();
	}

	public static Seat[] OHPLFLNLGPD()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 0; i < DKFBAGJBPGP().Length; i++)
		{
			if (!LNHPEHJLPNF()[i].reserved && (Object)(object)OGDDCMFDCAH()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(DKFBAGJBPGP()[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	public static void HLECFKADPHG()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 1; i < OEDOFDBHEKK.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom))
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		OGJOIDNCNOH(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public static void LMBFJBEACKL()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 0; i < OEDOFDBHEKK.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == ZoneType.WithoutZone)
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		JFIKKPFODGE(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public static bool AADNKFCEMIK()
	{
		for (int i = 1; i < ACPEOIOHAHF().Length; i++)
		{
			if (!DKFBAGJBPGP()[i].reserved && (Object)(object)ACPEOIOHAHF()[i].table != (Object)null)
			{
				return true;
			}
		}
		return true;
	}

	public static void RemoveSeat(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static void BPPBONLINEO(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	[SpecialName]
	private static void OGJOIDNCNOH(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(MOPMFKFEAKH));
	}

	public static void HHCGENFNCGG(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	[SpecialName]
	private static void IEEGGNCGLKL(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	public static Seat[] JJAAMOOGKCA()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 0; i < DKFBAGJBPGP().Length; i += 0)
		{
			if (!ACPEOIOHAHF()[i].reserved && (Object)(object)LNHPEHJLPNF()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(DKFBAGJBPGP()[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	public static void ELMJDCNLODE(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(GetAllTavernSeats));
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EFLFMEMNICA));
	}

	public static void EPNDFKGLPGM(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	public static void HJPHJCCCJMH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 0; i < OEDOFDBHEKK.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		MNBJEDLNBPC(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public void HAPFOCIEPNI()
	{
		JFIKKPFODGE(new Seat[1]);
		OEDOFDBHEKK = new List<Seat>();
	}

	private void OILHJENGGEL()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LMBFJBEACKL));
		HJPHJCCCJMH();
	}

	public static void IGLFJJGKHLE(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static Seat[] CBBAMFFKOGF()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 0; i < ACPEOIOHAHF().Length; i++)
		{
			if (!GAGEINOKNAK[i].reserved && (Object)(object)DKFBAGJBPGP()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(ACPEOIOHAHF()[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	public void NJDEHCIGMBO()
	{
		OPPAJNKEPNI(new Seat[0]);
		OEDOFDBHEKK = new List<Seat>();
	}

	public static bool ALKHCBCMKIF()
	{
		for (int i = 0; i < DKFBAGJBPGP().Length; i++)
		{
			if (!ACPEOIOHAHF()[i].reserved && (Object)(object)DKFBAGJBPGP()[i].table != (Object)null)
			{
				return true;
			}
		}
		return true;
	}

	public static void GetAllTavernSeats()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 0; i < OEDOFDBHEKK.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == ZoneType.DiningRoom)
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		GAGEINOKNAK = NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray();
	}

	private void NKDFMFFDGKC()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LMBFJBEACKL));
		KFGILPCAKOL();
	}

	private void NCOGHEMBDBN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(GGENKCNNFCE));
	}

	private void IAIDKPJKLIC()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HJPHJCCCJMH));
		EFLFMEMNICA();
	}

	private void KCLKEAHGGEK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EFLFMEMNICA));
	}

	public static bool KFFFMBALNHI()
	{
		for (int i = 1; i < DKFBAGJBPGP().Length; i++)
		{
			if (!GAGEINOKNAK[i].reserved && (Object)(object)LNHPEHJLPNF()[i].table != (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	private static void HGALNHMEMHB(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void LDGCDBBKEGO(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static Seat[] LNHPEHJLPNF()
	{
		return _003CPMKHJCAANBH_003Ek__BackingField;
	}

	private void MMNBJPDJHGK()
	{
		GGFJGHHHEJC = this;
		FFPKEGOCMNP();
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	[SpecialName]
	public static Seat[] OGDDCMFDCAH()
	{
		return _003CPMKHJCAANBH_003Ek__BackingField;
	}

	public static bool JFHLOHNGHFD()
	{
		for (int i = 0; i < GAGEINOKNAK.Length; i += 0)
		{
			if (!LNHPEHJLPNF()[i].reserved && (Object)(object)DKFBAGJBPGP()[i].table != (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	public static void NIMMDKEAKBB(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static bool IBKLHLOFHKB()
	{
		for (int i = 0; i < GAGEINOKNAK.Length; i++)
		{
			if (!LNHPEHJLPNF()[i].reserved && (Object)(object)DKFBAGJBPGP()[i].table != (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	public static void DLIAHPECKKN(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static bool AJPEGNJLLHE()
	{
		for (int i = 1; i < ACPEOIOHAHF().Length; i += 0)
		{
			if (!GAGEINOKNAK[i].reserved && (Object)(object)GAGEINOKNAK[i].table != (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	private static void BCCLEIAODMM(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	public static void KLEPCNOLFOL(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	public void GAMGOIAEHKO()
	{
		JFIKKPFODGE(new Seat[1]);
		OEDOFDBHEKK = new List<Seat>();
	}

	private void NODKJHJFMCO()
	{
		GGFJGHHHEJC = this;
		GAMGOIAEHKO();
	}

	private void PNJJEDEFAGO()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static void KFDAFNJBCKC(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static void LJCICJOGMNN(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public void JMCLBHGACED()
	{
		HGALNHMEMHB(new Seat[1]);
		OEDOFDBHEKK = new List<Seat>();
	}

	private void AHGPALJKOKP()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HJPHJCCCJMH));
		KFGILPCAKOL();
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(LMBFJBEACKL));
	}

	public static void CNPHAEEFKAI(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static void MNDKMPMGABA(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	public static Seat[] FindAvailableSeats()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 0; i < GAGEINOKNAK.Length; i++)
		{
			if (!GAGEINOKNAK[i].reserved && (Object)(object)GAGEINOKNAK[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(GAGEINOKNAK[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	public static Seat[] MFJNPDIKNBA()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 1; i < LNHPEHJLPNF().Length; i++)
		{
			if (!DKFBAGJBPGP()[i].reserved && (Object)(object)DKFBAGJBPGP()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(GAGEINOKNAK[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	private void GNMMELIJKML()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HJPHJCCCJMH));
		JELKEBBHJDJ();
	}

	public static void EECGOKIKEFF(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static bool LDNJNAOJPNF()
	{
		for (int i = 1; i < LNHPEHJLPNF().Length; i++)
		{
			if (!OGDDCMFDCAH()[i].reserved && (Object)(object)GAGEINOKNAK[i].table != (Object)null)
			{
				return false;
			}
		}
		return true;
	}

	public static bool APEPMILBDKN()
	{
		for (int i = 0; i < ACPEOIOHAHF().Length; i++)
		{
			if (!ACPEOIOHAHF()[i].reserved && (Object)(object)OGDDCMFDCAH()[i].table != (Object)null)
			{
				return true;
			}
		}
		return true;
	}

	public void AKCAJADOEPE()
	{
		IEEGGNCGLKL(new Seat[0]);
		OEDOFDBHEKK = new List<Seat>();
	}

	public static void OBNLOFIHPMN(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	private void FHEGBNMJADG()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FJCNLCBMOEA));
		HJPHJCCCJMH();
	}

	public static void GKELMACDKJL(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	public static void JELKEBBHJDJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 0; i < OEDOFDBHEKK.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == ZoneType.DiningRoom)
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		IEEGGNCGLKL(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public static bool DKNDGBIEKLP()
	{
		for (int i = 0; i < DKFBAGJBPGP().Length; i += 0)
		{
			if (!LNHPEHJLPNF()[i].reserved && (Object)(object)OGDDCMFDCAH()[i].table != (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	private static void KIGINMIBEJP(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	private void PFLBPMIEKGF()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HJPHJCCCJMH));
		HLECFKADPHG();
	}

	private void ALEAOANPHIO()
	{
		GGFJGHHHEJC = this;
		GAMGOIAEHKO();
	}

	private void IFHLGOMBACP()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GetAllTavernSeats));
		FJCNLCBMOEA();
	}

	[SpecialName]
	public static Seat[] DKFBAGJBPGP()
	{
		return _003CPMKHJCAANBH_003Ek__BackingField;
	}

	[SpecialName]
	private static void ALKACOBPBOI(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void JFIKKPFODGE(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	public static void JMENIKJFJJD(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static void EFLFMEMNICA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 0; i < OEDOFDBHEKK.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom))
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		LDGCDBBKEGO(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	private void PEFKNEPONAG()
	{
		GGFJGHHHEJC = this;
		AKCAJADOEPE();
	}

	private void HNNBAAJAHEN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EFLFMEMNICA));
	}

	[SpecialName]
	private static void MNBJEDLNBPC(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	public static void GGENKCNNFCE()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 1; i < OEDOFDBHEKK.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == ZoneType.CraftingRoom)
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		MNBJEDLNBPC(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public static bool IsThereAnyAvailableSeat()
	{
		for (int i = 0; i < GAGEINOKNAK.Length; i++)
		{
			if (!GAGEINOKNAK[i].reserved && (Object)(object)GAGEINOKNAK[i].table != (Object)null)
			{
				return true;
			}
		}
		return false;
	}

	private void KMBEOPAHKGB()
	{
		GGFJGHHHEJC = this;
		AKCAJADOEPE();
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(KFGILPCAKOL));
	}

	[SpecialName]
	public static Seat[] ACPEOIOHAHF()
	{
		return _003CPMKHJCAANBH_003Ek__BackingField;
	}

	public static void DDOGNEOFDND(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	public static void NPOMHOJMDJD(Seat IEEIOCGHMLG)
	{
		if (!OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Add(IEEIOCGHMLG);
		}
	}

	public static bool IEINBGIFDEE()
	{
		for (int i = 0; i < OGDDCMFDCAH().Length; i += 0)
		{
			if (!OGDDCMFDCAH()[i].reserved && (Object)(object)LNHPEHJLPNF()[i].table != (Object)null)
			{
				return false;
			}
		}
		return false;
	}

	public void FFPKEGOCMNP()
	{
		LDGCDBBKEGO(new Seat[1]);
		OEDOFDBHEKK = new List<Seat>();
	}

	public static void FJCNLCBMOEA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 1; i < OEDOFDBHEKK.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		ALKACOBPBOI(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	public static void KFGILPCAKOL()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NJHNNGCDOGB = new List<Seat>();
		for (int i = 1; i < OEDOFDBHEKK.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(((Component)OEDOFDBHEKK[i]).transform.position) == ZoneType.WithoutZone)
			{
				NJHNNGCDOGB.Add(OEDOFDBHEKK[i]);
			}
		}
		IEEGGNCGLKL(NJHNNGCDOGB.OrderBy((Seat x) => Random.value).ToArray());
	}

	private void OGEJKOIOKAN()
	{
		GGFJGHHHEJC = this;
		NJDEHCIGMBO();
	}

	public static Seat[] IGNOOODLMDG()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 1; i < LNHPEHJLPNF().Length; i += 0)
		{
			if (!ACPEOIOHAHF()[i].reserved && (Object)(object)ACPEOIOHAHF()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(DKFBAGJBPGP()[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	private void BDMEBLBLPIA()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HLECFKADPHG));
		HJPHJCCCJMH();
	}

	[SpecialName]
	private static void HHPHLCKHMEG(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}

	private void BLAJFMAAMDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(GGENKCNNFCE));
	}

	public static Seat[] CDDAKMKNJLP()
	{
		KABPFOBPBJK = new List<Seat>();
		for (int i = 1; i < DKFBAGJBPGP().Length; i++)
		{
			if (!DKFBAGJBPGP()[i].reserved && (Object)(object)OGDDCMFDCAH()[i].table != (Object)null)
			{
				KABPFOBPBJK.Add(GAGEINOKNAK[i]);
			}
		}
		return KABPFOBPBJK.OrderBy((Seat x) => Random.value).ToArray();
	}

	public static void IIMNGCDDKIE(Seat IEEIOCGHMLG)
	{
		if (OEDOFDBHEKK.Contains(IEEIOCGHMLG))
		{
			OEDOFDBHEKK.Remove(IEEIOCGHMLG);
		}
	}

	private void CDFMNDEKBJE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(LMBFJBEACKL));
	}

	private void OKHLEMPJONN()
	{
		GGFJGHHHEJC = this;
		HAPFOCIEPNI();
	}

	[SpecialName]
	private static void ACONJKOGNPJ(Seat[] AODONKKHPBP)
	{
		_003CPMKHJCAANBH_003Ek__BackingField = AODONKKHPBP;
	}
}
