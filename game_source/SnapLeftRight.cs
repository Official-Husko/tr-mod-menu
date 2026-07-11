using System.Collections.Generic;
using UnityEngine;

public class SnapLeftRight : MonoBehaviour
{
	public List<Item> itemsAllowed;

	public Placeable placeable;

	public SnapTrigger snapTriggerLeft;

	public SnapTrigger snapTriggerRight;

	private Vector3 ECJLMIPAFGP;

	private SnapTrigger[] PJCPNJGCCEO;

	private SnapTrigger BOLFDILFFGK;

	public bool DGDFGMJHIKB(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == CFJGMFDBPMH(MFBEMAOGHIG) && !IOHAIIMDPPM(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return true;
	}

	public void Snap(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		GetTrigger(MFBEMAOGHIG).Snap(KLDCFPLDOHB: true, BOLFDILFFGK);
		BOLFDILFFGK.Snap(KLDCFPLDOHB: true, GetTrigger(MFBEMAOGHIG));
		Vector3 position = ((Component)BOLFDILFFGK.snapLeftRight.GetTrigger(GetOppositePole(MFBEMAOGHIG))).transform.position;
		position -= ((Component)GetTrigger(MFBEMAOGHIG)).transform.localPosition;
		((Component)placeable).transform.position = Utils.BMBMPKNANAC(position);
	}

	private void JPHEOLEEAPB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeable.HELBDKNMGID(((Component)this).transform.position);
	}

	public bool DLNLPJINPFB(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == DCOHOHMCJMM(MFBEMAOGHIG) && !BNIECMOLGHA(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return true;
	}

	public SnapTrigger MFBGGAODJCK(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public SnapTrigger IOHAIIMDPPM(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public bool IsLeftSnapped()
	{
		return snapTriggerLeft.snapped;
	}

	public void GMNHIOBAMPP(SnapTriggerPole MFBEMAOGHIG)
	{
		OENHBHEAKCP(MFBEMAOGHIG).CODLKPOBJAH(KLDCFPLDOHB: true, null);
	}

	public bool IsSnapped(SnapTriggerPole MFBEMAOGHIG)
	{
		return GetTrigger(MFBEMAOGHIG).snapped;
	}

	public void LeftRightSnap(SnapTriggerPole MFBEMAOGHIG, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		PJCPNJGCCEO = Utils.CCCCIKOMAEN<SnapTrigger>(Vector2.op_Implicit(ECJLMIPAFGP + ((Component)GetTrigger(MFBEMAOGHIG)).transform.localPosition));
		BOLFDILFFGK = null;
		for (int i = 0; i < PJCPNJGCCEO.Length; i++)
		{
			if ((Object)(object)PJCPNJGCCEO[i] != (Object)(object)GetTrigger(SnapTriggerPole.Left) && (Object)(object)PJCPNJGCCEO[i] != (Object)(object)GetTrigger(SnapTriggerPole.Right))
			{
				BOLFDILFFGK = PJCPNJGCCEO[i];
				break;
			}
		}
		if (Object.op_Implicit((Object)(object)BOLFDILFFGK))
		{
			if (!IsSnapped(MFBEMAOGHIG) && CanSnap(BOLFDILFFGK, MFBEMAOGHIG))
			{
				Snap(BOLFDILFFGK, MFBEMAOGHIG);
			}
		}
		else if (IsSnapped(MFBEMAOGHIG))
		{
			UnSnap(MFBEMAOGHIG);
		}
	}

	public static SnapTriggerPole EHLEEBKOFFJ(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG != 0)
		{
			return SnapTriggerPole.Left;
		}
		return SnapTriggerPole.Left;
	}

	public bool PDBKMKIGFML(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == DCOHOHMCJMM(MFBEMAOGHIG) && !GetTrigger(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return true;
	}

	public bool IsRightSnapped()
	{
		return snapTriggerRight.snapped;
	}

	public bool KFJGIMOPOIG()
	{
		return snapTriggerRight.snapped;
	}

	private void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeable.SnapAll(((Component)this).transform.position);
	}

	public void LNDGEDDIHAP(SnapTriggerPole MFBEMAOGHIG)
	{
		IOHAIIMDPPM(MFBEMAOGHIG).IGCKKMBHEAJ(KLDCFPLDOHB: true, null);
	}

	public bool CanSnap(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == GetOppositePole(MFBEMAOGHIG) && !GetTrigger(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return false;
	}

	public void AEBLIAEKHOE(SnapTriggerPole MFBEMAOGHIG, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		PJCPNJGCCEO = Utils.CCCCIKOMAEN<SnapTrigger>(Vector2.op_Implicit(ECJLMIPAFGP + ((Component)DJDONHDFAIK(MFBEMAOGHIG)).transform.localPosition), 14);
		BOLFDILFFGK = null;
		for (int i = 1; i < PJCPNJGCCEO.Length; i++)
		{
			if ((Object)(object)PJCPNJGCCEO[i] != (Object)(object)OENHBHEAKCP(SnapTriggerPole.Left) && (Object)(object)PJCPNJGCCEO[i] != (Object)(object)IOHAIIMDPPM(SnapTriggerPole.Right))
			{
				BOLFDILFFGK = PJCPNJGCCEO[i];
				break;
			}
		}
		if (Object.op_Implicit((Object)(object)BOLFDILFFGK))
		{
			if (!IAEIFJLJCCD(MFBEMAOGHIG) && KIALCGKKIBP(BOLFDILFFGK, MFBEMAOGHIG))
			{
				FNMAPIIGEPE(BOLFDILFFGK, MFBEMAOGHIG);
			}
		}
		else if (IsSnapped(MFBEMAOGHIG))
		{
			FKODNDPIJGG(MFBEMAOGHIG);
		}
	}

	public SnapTrigger GetTrigger(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public static SnapTriggerPole MDOCCLDLBCA(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG != 0)
		{
			return SnapTriggerPole.Left;
		}
		return SnapTriggerPole.Right;
	}

	public bool AOPMPHLODPG()
	{
		return snapTriggerLeft.snapped;
	}

	public SnapTrigger BNIECMOLGHA(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public SnapTrigger FBFLJDBECIA(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public bool HHNMCPDCACG(SnapTriggerPole MFBEMAOGHIG)
	{
		return FBFLJDBECIA(MFBEMAOGHIG).snapped;
	}

	public bool BDDJNAPFMCA(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == JOMGGICDKKN(MFBEMAOGHIG) && !FJBNDNPAGLN(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return false;
	}

	public void CCNGPBHKHBA(SnapTriggerPole MFBEMAOGHIG)
	{
		GetTrigger(MFBEMAOGHIG).OJPGHHNDKJK(KLDCFPLDOHB: false, null);
	}

	public static SnapTriggerPole CFJGMFDBPMH(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG != 0)
		{
			return SnapTriggerPole.Right;
		}
		return SnapTriggerPole.Left;
	}

	public SnapTrigger DJDONHDFAIK(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public bool JBMNCOCJPHA()
	{
		return snapTriggerLeft.snapped;
	}

	public SnapTrigger HBCPPNOECCH(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	public static SnapTriggerPole DCOHOHMCJMM(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG != 0)
		{
			return SnapTriggerPole.Right;
		}
		return SnapTriggerPole.Left;
	}

	public bool IAEIFJLJCCD(SnapTriggerPole MFBEMAOGHIG)
	{
		return HBCPPNOECCH(MFBEMAOGHIG).snapped;
	}

	public bool PMHDHDKADBG(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == GetOppositePole(MFBEMAOGHIG) && !OENHBHEAKCP(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return true;
	}

	public void FKODNDPIJGG(SnapTriggerPole MFBEMAOGHIG)
	{
		OENHBHEAKCP(MFBEMAOGHIG).OJPGHHNDKJK(KLDCFPLDOHB: true, null);
	}

	public void CAGHJBKLHGG(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		FBFLJDBECIA(MFBEMAOGHIG).BDMAGMLHJPP(KLDCFPLDOHB: true, BOLFDILFFGK);
		BOLFDILFFGK.BDMAGMLHJPP(KLDCFPLDOHB: false, OENHBHEAKCP(MFBEMAOGHIG));
		Vector3 position = ((Component)BOLFDILFFGK.snapLeftRight.BNIECMOLGHA(CFJGMFDBPMH(MFBEMAOGHIG))).transform.position;
		position -= ((Component)FJBNDNPAGLN(MFBEMAOGHIG)).transform.localPosition;
		((Component)placeable).transform.position = Utils.BMBMPKNANAC(position);
	}

	public void FMCBNGBBNKC(SnapTriggerPole MFBEMAOGHIG)
	{
		HBCPPNOECCH(MFBEMAOGHIG).OJPGHHNDKJK(KLDCFPLDOHB: false, null);
	}

	public SnapTrigger FJBNDNPAGLN(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	private void NFABFPFLNEE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeable.HELBDKNMGID(((Component)this).transform.position);
	}

	public bool GPGPGOFIBLJ()
	{
		return snapTriggerLeft.snapped;
	}

	public void KALBOHOMOHI(SnapTriggerPole MFBEMAOGHIG)
	{
		FBFLJDBECIA(MFBEMAOGHIG).BEJBEHJCAFI(KLDCFPLDOHB: false, null);
	}

	public bool BGANFHMNCIC(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == DCOHOHMCJMM(MFBEMAOGHIG) && !OENHBHEAKCP(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return true;
	}

	public void MAKGKKJFJPF(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		DJDONHDFAIK(MFBEMAOGHIG).CNEINDBOIEC(KLDCFPLDOHB: false, BOLFDILFFGK);
		BOLFDILFFGK.EFNBHJDBAME(KLDCFPLDOHB: false, HBCPPNOECCH(MFBEMAOGHIG));
		Vector3 position = ((Component)BOLFDILFFGK.snapLeftRight.FBFLJDBECIA(EHLEEBKOFFJ(MFBEMAOGHIG))).transform.position;
		position -= ((Component)IOHAIIMDPPM(MFBEMAOGHIG)).transform.localPosition;
		((Component)placeable).transform.position = Utils.BMBMPKNANAC(position);
	}

	public bool ICGBIEMOFCB()
	{
		return snapTriggerRight.snapped;
	}

	public void MBHIKPPPKMB(SnapTriggerPole MFBEMAOGHIG, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		PJCPNJGCCEO = Utils.CCCCIKOMAEN<SnapTrigger>(Vector2.op_Implicit(ECJLMIPAFGP + ((Component)GetTrigger(MFBEMAOGHIG)).transform.localPosition), 47);
		BOLFDILFFGK = null;
		for (int i = 0; i < PJCPNJGCCEO.Length; i++)
		{
			if ((Object)(object)PJCPNJGCCEO[i] != (Object)(object)GetTrigger(SnapTriggerPole.Left) && (Object)(object)PJCPNJGCCEO[i] != (Object)(object)HBCPPNOECCH(SnapTriggerPole.Left))
			{
				BOLFDILFFGK = PJCPNJGCCEO[i];
				break;
			}
		}
		if (Object.op_Implicit((Object)(object)BOLFDILFFGK))
		{
			if (!OEBPLMFFCDO(MFBEMAOGHIG) && BDDJNAPFMCA(BOLFDILFFGK, MFBEMAOGHIG))
			{
				MAKGKKJFJPF(BOLFDILFFGK, MFBEMAOGHIG);
			}
		}
		else if (AJOPPPNPMBI(MFBEMAOGHIG))
		{
			KALBOHOMOHI(MFBEMAOGHIG);
		}
	}

	public void APMMOOJMBPE(SnapTriggerPole MFBEMAOGHIG)
	{
		HBCPPNOECCH(MFBEMAOGHIG).LADBELDJCDB(KLDCFPLDOHB: true, null);
	}

	public bool JEHLHNCLPDF()
	{
		return snapTriggerLeft.snapped;
	}

	private void DCKKIDMJKJM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeable.SnapAll(((Component)this).transform.position);
	}

	public SnapTrigger OENHBHEAKCP(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG == SnapTriggerPole.Left)
		{
			return snapTriggerLeft;
		}
		return snapTriggerRight;
	}

	private void IFHLGOMBACP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeable.SnapAll(((Component)this).transform.position);
	}

	public void FNMAPIIGEPE(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		IOHAIIMDPPM(MFBEMAOGHIG).NBCOCHMDHJL(KLDCFPLDOHB: true, BOLFDILFFGK);
		BOLFDILFFGK.HEIPNKAKFBL(KLDCFPLDOHB: false, MFBGGAODJCK(MFBEMAOGHIG));
		Vector3 position = ((Component)BOLFDILFFGK.snapLeftRight.HBCPPNOECCH(CFJGMFDBPMH(MFBEMAOGHIG))).transform.position;
		position -= ((Component)MFBGGAODJCK(MFBEMAOGHIG)).transform.localPosition;
		((Component)placeable).transform.position = Utils.BMBMPKNANAC(position);
	}

	public bool KGNMEOOHDGK()
	{
		return snapTriggerLeft.snapped;
	}

	private void KDBJHCAEGCM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeable.HELBDKNMGID(((Component)this).transform.position);
	}

	public bool GGBCOFNLNDJ()
	{
		return snapTriggerLeft.snapped;
	}

	public bool NEGALIFKLDG()
	{
		return snapTriggerRight.snapped;
	}

	public bool KOKIAIBDOHN()
	{
		return snapTriggerRight.snapped;
	}

	public bool EOIIMFDMBJG()
	{
		return snapTriggerLeft.snapped;
	}

	public static SnapTriggerPole JOMGGICDKKN(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG != 0)
		{
			return SnapTriggerPole.Right;
		}
		return SnapTriggerPole.Left;
	}

	public void ILJGHNDCEOE(SnapTriggerPole MFBEMAOGHIG)
	{
		FBFLJDBECIA(MFBEMAOGHIG).HJINGDOHJKP(KLDCFPLDOHB: false, null);
	}

	public bool OEBPLMFFCDO(SnapTriggerPole MFBEMAOGHIG)
	{
		return GetTrigger(MFBEMAOGHIG).snapped;
	}

	public void UnSnap(SnapTriggerPole MFBEMAOGHIG)
	{
		GetTrigger(MFBEMAOGHIG).Snap(KLDCFPLDOHB: false, null);
	}

	public bool KIALCGKKIBP(SnapTrigger BOLFDILFFGK, SnapTriggerPole MFBEMAOGHIG)
	{
		if (BOLFDILFFGK.pole == GetOppositePole(MFBEMAOGHIG) && !GetTrigger(MFBEMAOGHIG).snapped && !BOLFDILFFGK.snapped && BOLFDILFFGK.snapLeftRight.itemsAllowed.Contains(placeable.itemSetup.item) && itemsAllowed.Contains(BOLFDILFFGK.snapLeftRight.placeable.itemSetup.item))
		{
			return (Object)(object)BOLFDILFFGK.snapLeftRight.placeable.currentSurface == (Object)(object)placeable.currentSurface;
		}
		return false;
	}

	public bool AJOPPPNPMBI(SnapTriggerPole MFBEMAOGHIG)
	{
		return OENHBHEAKCP(MFBEMAOGHIG).snapped;
	}

	public static SnapTriggerPole GetOppositePole(SnapTriggerPole MFBEMAOGHIG)
	{
		if (MFBEMAOGHIG != 0)
		{
			return SnapTriggerPole.Left;
		}
		return SnapTriggerPole.Right;
	}

	public void FNALKIOMHAL(SnapTriggerPole MFBEMAOGHIG, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		PJCPNJGCCEO = Utils.CCCCIKOMAEN<SnapTrigger>(Vector2.op_Implicit(ECJLMIPAFGP + ((Component)IOHAIIMDPPM(MFBEMAOGHIG)).transform.localPosition), 3);
		BOLFDILFFGK = null;
		for (int i = 0; i < PJCPNJGCCEO.Length; i++)
		{
			if ((Object)(object)PJCPNJGCCEO[i] != (Object)(object)HBCPPNOECCH(SnapTriggerPole.Right) && (Object)(object)PJCPNJGCCEO[i] != (Object)(object)MFBGGAODJCK(SnapTriggerPole.Right))
			{
				BOLFDILFFGK = PJCPNJGCCEO[i];
				break;
			}
		}
		if (Object.op_Implicit((Object)(object)BOLFDILFFGK))
		{
			if (!AJOPPPNPMBI(MFBEMAOGHIG) && DGDFGMJHIKB(BOLFDILFFGK, MFBEMAOGHIG))
			{
				CAGHJBKLHGG(BOLFDILFFGK, MFBEMAOGHIG);
			}
		}
		else if (IAEIFJLJCCD(MFBEMAOGHIG))
		{
			CCNGPBHKHBA(MFBEMAOGHIG);
		}
	}
}
