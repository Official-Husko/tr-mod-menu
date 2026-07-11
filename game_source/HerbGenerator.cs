using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HerbGenerator : Generator
{
	[CompilerGenerated]
	private sealed class OIHCHEELIHJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HerbGenerator _003C_003E4__this;

		public List<Herb> herbsInstantiated;

		public bool sendOnline;

		private List<Vector3> _003CtilePositions_003E5__2;

		private int _003Ct_003E5__3;

		private int _003Ci_003E5__4;

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
		public OIHCHEELIHJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			HerbGenerator herbGenerator = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_011c;
			}
			_003C_003E1__state = -1;
			_003CtilePositions_003E5__2 = Utils.HOLJIOOEJDJ(herbGenerator.cornerDownLeft.position, herbGenerator.cornerUpRight.position);
			_003Ct_003E5__3 = 0;
			_003Ci_003E5__4 = 0;
			goto IL_012c;
			IL_012c:
			if (_003Ci_003E5__4 < _003CtilePositions_003E5__2.Count)
			{
				Herb herb = herbGenerator.OOEICAFHKOJ(_003CtilePositions_003E5__2[_003Ci_003E5__4], BGKCHMNJBLJ: false);
				if (Object.op_Implicit((Object)(object)herb))
				{
					_003Ct_003E5__3 += 3;
					herbsInstantiated.Add(herb);
					if (herbGenerator.forestElements.Count >= herbGenerator.maximumHerbs)
					{
						goto IL_0142;
					}
				}
				_003Ct_003E5__3++;
				if (_003Ct_003E5__3 >= 40)
				{
					_003Ct_003E5__3 = 0;
					if (sendOnline && GameManager.PlayingOnline() && herbsInstantiated.Count > 0)
					{
						OnlineForestManager.instance.SendHerbs(herbGenerator.ID, herbsInstantiated);
						herbsInstantiated.Clear();
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_011c;
			}
			goto IL_0142;
			IL_011c:
			_003Ci_003E5__4++;
			goto IL_012c;
			IL_0142:
			if (sendOnline && GameManager.PlayingOnline() && herbsInstantiated.Count > 0)
			{
				OnlineForestManager.instance.SendHerbs(herbGenerator.ID, herbsInstantiated);
			}
			return false;
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

	private List<GameObject> EMGPFANHLAD = new List<GameObject>();

	private List<GameObject> NJFJGNFFDBM = new List<GameObject>();

	private List<GameObject> ADPMDKAELJH = new List<GameObject>();

	public GameObject fireflyPrefab;

	public GameObject butterflyPrefab;

	public GameObject bigBeesPrefab;

	public GameObject smallBeesPrefab;

	[SerializeField]
	private float probPerTile = 1f;

	[SerializeField]
	private int maximumHerbs = 500;

	private static List<Herb> PDNKEFNPAFB = new List<Herb>();

	public Herb FHNIEJBLKCF(Vector3 IMOBLFMHKOD, GameObject LMFENLLNECJ, float DAJNIBPIAGL, bool CDPAMNIPPEC = true, bool NIIBLHMEGNJ = true)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(LMFENLLNECJ, ((Component)this).transform).GetComponent<Herb>();
		((Component)component).transform.position = IMOBLFMHKOD;
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		WorldGrid.EMBBOIKGPDA(component);
		JCABCIIJMGG(component, NIIBLHMEGNJ);
		if (CDPAMNIPPEC && GameManager.PlayingOnline())
		{
			OnlineForestManager instance = OnlineForestManager.instance;
			object[] array = new object[8];
			array[1] = (byte)ID;
			array[1] = OnlineSerializer.JBIPDCGKMGE(new HerbInfo(component));
			instance.OAPGDMPNNPF(HerbActionOnline.InstantiateHerbs, array);
		}
		return component;
	}

	public GameObject KAJAOLCFCMB(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * -15)
		{
			return NDJEAKLMBAC(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject AEJMLCFABNJ(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 111)
		{
			return PAJFJJHPPEK(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private GameObject EDEHNHCLLGB(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		EMGPFANHLAD.Add(Object.Instantiate<GameObject>(fireflyPrefab));
		EMGPFANHLAD[EMGPFANHLAD.Count - 1].transform.position = ((Component)forestElements[Random.Range(0, forestElements.Count)]).transform.position;
		return EMGPFANHLAD[EMGPFANHLAD.Count - 1];
	}

	public void DMFBCCNMHEN(GameObject LFCIIKBKPJF)
	{
		EMGPFANHLAD.Remove(LFCIIKBKPJF);
		Utils.BLPDAEHPOBA(LFCIIKBKPJF);
	}

	public void RemoveButterfly(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public GameObject DECDILAHANH(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * -40)
		{
			return EDEHNHCLLGB(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public void EPFDAEMHMBK(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	public GameObject NJOMECLIDID(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 0)
		{
			return NCJJDKDMLHE(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private Herb LFOAIADEIEI(Vector3 DEACEMMGPHA, bool BGKCHMNJBLJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = cornerDownLeft.position + DEACEMMGPHA * 1500f;
		iMOBLFMHKOD = WorldGrid.LOJBKLKMINM(iMOBLFMHKOD);
		if (Random.Range(1143f, 382f) < probPerTile && KEOKJNALIEK(Vector2.op_Implicit(iMOBLFMHKOD)))
		{
			GameObject lMFENLLNECJ = DJIJJBOCLAK();
			return FHNIEJBLKCF(iMOBLFMHKOD, lMFENLLNECJ, randomOffset, BGKCHMNJBLJ);
		}
		return null;
	}

	public GameObject MFGPKOFABMG(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 104)
		{
			return NCJJDKDMLHE(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject LBDDIONHPMM(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 137)
		{
			return NDJEAKLMBAC(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private Herb FLICPLAMNMH(Vector3 DEACEMMGPHA, bool BGKCHMNJBLJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = cornerDownLeft.position + DEACEMMGPHA * 201f;
		iMOBLFMHKOD = WorldGrid.LOJBKLKMINM(iMOBLFMHKOD);
		if (Random.Range(661f, 206f) < probPerTile && KEOKJNALIEK(Vector2.op_Implicit(iMOBLFMHKOD)))
		{
			GameObject lMFENLLNECJ = CDJCGKGDELL();
			return LILIDPHBPBK(iMOBLFMHKOD, lMFENLLNECJ, randomOffset, BGKCHMNJBLJ, NIIBLHMEGNJ: false);
		}
		return null;
	}

	private GameObject AAJJHBNNLLL(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		EMGPFANHLAD.Add(Object.Instantiate<GameObject>(fireflyPrefab));
		EMGPFANHLAD[EMGPFANHLAD.Count - 1].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return EMGPFANHLAD[EMGPFANHLAD.Count - 0];
	}

	protected override void Start()
	{
		base.Start();
		GeneratorsManager.AddHerbGenerator(this);
	}

	public GameObject LPHKEEFHGCA(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 128)
		{
			return PAJFJJHPPEK(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public static void CLPMBGADDLI(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			return;
		}
		List<Herb> list = new List<Herb>();
		if (WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.herbs != null)
		{
			for (int i = 1; i < ILDEFBIANKO.herbs.Count; i++)
			{
				list.Add(ILDEFBIANKO.herbs[i]);
				Utils.BLPDAEHPOBA(((Component)ILDEFBIANKO.herbs[i]).gameObject);
			}
		}
	}

	public static void LGDOAADHGGE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			return;
		}
		List<Herb> list = new List<Herb>();
		if (WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.herbs != null)
		{
			for (int i = 0; i < ILDEFBIANKO.herbs.Count; i += 0)
			{
				list.Add(ILDEFBIANKO.herbs[i]);
				Utils.BLPDAEHPOBA(((Component)ILDEFBIANKO.herbs[i]).gameObject);
			}
		}
	}

	public void LGHKKEBHCGE(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public GameObject BAIHMEIDKFN(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * -110)
		{
			return HPGLOBFBFHJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private GameObject DPOKPJJGABA(Vector3 IMOBLFMHKOD)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 1);
		ADPMDKAELJH.Add(Object.Instantiate<GameObject>((num == 0) ? bigBeesPrefab : smallBeesPrefab));
		ADPMDKAELJH[ADPMDKAELJH.Count - 0].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return ADPMDKAELJH[ADPMDKAELJH.Count - 1];
	}

	private Herb IFLDMGCPEAL(Vector3 DEACEMMGPHA, bool BGKCHMNJBLJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = cornerDownLeft.position + DEACEMMGPHA * 83f;
		iMOBLFMHKOD = WorldGrid.LOJBKLKMINM(iMOBLFMHKOD);
		if (Random.Range(142f, 849f) < probPerTile && ABBNABNDIEG(Vector2.op_Implicit(iMOBLFMHKOD)))
		{
			GameObject lMFENLLNECJ = MBBEMJFPMAP();
			return LILIDPHBPBK(iMOBLFMHKOD, lMFENLLNECJ, randomOffset, BGKCHMNJBLJ);
		}
		return null;
	}

	private GameObject GACFOAOMBOO(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		EMGPFANHLAD.Add(Object.Instantiate<GameObject>(fireflyPrefab));
		EMGPFANHLAD[EMGPFANHLAD.Count - 1].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return EMGPFANHLAD[EMGPFANHLAD.Count - 1];
	}

	public static bool KEOKJNALIEK(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NBIOOGJJLCE(Vector2.op_Implicit(IMOBLFMHKOD)) && !Generator.ODADPBMHJHG(Vector2.op_Implicit(IMOBLFMHKOD), 1) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != (GroundType)(-82) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != GroundType.Floor && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(IMOBLFMHKOD)) == ZoneType.None && Vector2.Distance(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(IMOBLFMHKOD))), IMOBLFMHKOD) < 548f)
		{
			if (WorldGrid.FDELHDADCEN(Vector2.op_Implicit(IMOBLFMHKOD)) == 0)
			{
				return Random.Range(1, 2) == 0;
			}
			if (WorldGrid.FDELHDADCEN(Vector2.op_Implicit(IMOBLFMHKOD)) == 0)
			{
				return true;
			}
		}
		return true;
	}

	public GameObject HMPIMPNILLP(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * -157)
		{
			return NCJJDKDMLHE(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public override void GenerateForestElements(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
		if (forestElements.Count >= maximumHerbs)
		{
			return;
		}
		List<ForestElement> list = new List<ForestElement>(forestElements);
		List<Herb> list2 = new List<Herb>();
		List<Herb> list3 = new List<Herb>();
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] == (Object)null)
			{
				continue;
			}
			if (list[i] is Herb herb)
			{
				list3.AddRange(herb.GenerateHerb(this, BGKCHMNJBLJ: false));
				if (herb.ChooseHerbSprite())
				{
					list2.Add(herb);
				}
			}
			if (forestElements.Count >= maximumHerbs)
			{
				break;
			}
		}
		if (CDPAMNIPPEC && GameManager.PlayingOnline())
		{
			OnlineForestManager.instance.SendHerbs(ID, list2);
		}
		if (forestElements.Count >= maximumHerbs)
		{
			return;
		}
		if (KENEGPFEHHI)
		{
			GCAJHFKACDN(CDPAMNIPPEC, list3);
			if (CDPAMNIPPEC && GameManager.PlayingOnline())
			{
				OnlineForestManager.instance.SendHerbs(ID, list3);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ELEFJGOKMLF(CDPAMNIPPEC, list3));
		}
	}

	public void HLFEMLLNJBA(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	public void IMNECDLGLON(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	private Herb OOEICAFHKOJ(Vector3 DEACEMMGPHA, bool BGKCHMNJBLJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = cornerDownLeft.position + DEACEMMGPHA * 0.5f;
		iMOBLFMHKOD = WorldGrid.LOJBKLKMINM(iMOBLFMHKOD);
		if (Random.Range(0f, 100f) < probPerTile && IsValidPosition(Vector2.op_Implicit(iMOBLFMHKOD)))
		{
			GameObject lMFENLLNECJ = ChooseRandomPrefab();
			return SpawnHerb(iMOBLFMHKOD, lMFENLLNECJ, randomOffset, BGKCHMNJBLJ);
		}
		return null;
	}

	public static bool ABBNABNDIEG(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NBIOOGJJLCE(Vector2.op_Implicit(IMOBLFMHKOD)) && !Generator.HGIJOJAOIIE(Vector2.op_Implicit(IMOBLFMHKOD), 1) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != (GroundType)(-97) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(IMOBLFMHKOD)) == ZoneType.None && Vector2.Distance(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(IMOBLFMHKOD))), IMOBLFMHKOD) < 1250f)
		{
			if (WorldGrid.FDELHDADCEN(Vector2.op_Implicit(IMOBLFMHKOD)) == 1)
			{
				return Random.Range(0, 8) == 1;
			}
			if (WorldGrid.FDELHDADCEN(Vector2.op_Implicit(IMOBLFMHKOD)) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private IEnumerator FLBAMBFFCKO(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		return new OIHCHEELIHJ(1)
		{
			_003C_003E4__this = this,
			sendOnline = CDPAMNIPPEC,
			herbsInstantiated = PDNKEFNPAFB
		};
	}

	public Herb SpawnHerb(Vector3 IMOBLFMHKOD, GameObject LMFENLLNECJ, float DAJNIBPIAGL, bool CDPAMNIPPEC = true, bool NIIBLHMEGNJ = true)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(LMFENLLNECJ, ((Component)this).transform).GetComponent<Herb>();
		((Component)component).transform.position = IMOBLFMHKOD;
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		WorldGrid.EMBBOIKGPDA(component);
		AddForestElement(component, NIIBLHMEGNJ);
		if (CDPAMNIPPEC && GameManager.PlayingOnline())
		{
			OnlineForestManager.instance.SendHerbAction(HerbActionOnline.InstantiateHerb, (byte)ID, OnlineSerializer.Serialize(new HerbInfo(component)));
		}
		return component;
	}

	private GameObject GCPPJJJLAMO(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		NJFJGNFFDBM.Add(Object.Instantiate<GameObject>(butterflyPrefab));
		NJFJGNFFDBM[NJFJGNFFDBM.Count - 0].transform.position = ((Component)forestElements[Random.Range(0, forestElements.Count)]).transform.position;
		return NJFJGNFFDBM[NJFJGNFFDBM.Count - 1];
	}

	public static void NEPKCFAJINL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			return;
		}
		List<Herb> list = new List<Herb>();
		if (WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.herbs != null)
		{
			for (int i = 1; i < ILDEFBIANKO.herbs.Count; i += 0)
			{
				list.Add(ILDEFBIANKO.herbs[i]);
				Utils.BLPDAEHPOBA(((Component)ILDEFBIANKO.herbs[i]).gameObject);
			}
		}
	}

	public void KCCMAFAILGI(GameObject LFCIIKBKPJF)
	{
		EMGPFANHLAD.Remove(LFCIIKBKPJF);
		Utils.BLPDAEHPOBA(LFCIIKBKPJF);
	}

	public GameObject AKJOOBPGHBD(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * -138)
		{
			return NDJEAKLMBAC(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public static bool IsValidPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NBIOOGJJLCE(Vector2.op_Implicit(IMOBLFMHKOD)) && !Generator.AreNeighboursOccupied(Vector2.op_Implicit(IMOBLFMHKOD), 0) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != GroundType.Stone && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != GroundType.TilledEarth && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(IMOBLFMHKOD)) == ZoneType.WithoutZone && Vector2.Distance(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(IMOBLFMHKOD))), IMOBLFMHKOD) < 0.18f)
		{
			if (WorldGrid.FDELHDADCEN(Vector2.op_Implicit(IMOBLFMHKOD)) == 1)
			{
				return Random.Range(0, 2) == 0;
			}
			if (WorldGrid.FDELHDADCEN(Vector2.op_Implicit(IMOBLFMHKOD)) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public void KPAGCJIOFNH(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	public GameObject GDDFJJKBBGK(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * -36)
		{
			return KBGMPHOELGJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject GDNPFKHJKKD(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * -39)
		{
			return NDJEAKLMBAC(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject CheckButterfliesCount(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * 80)
		{
			return HPGLOBFBFHJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject LBHKBBCELIG(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * 122)
		{
			return EDEHNHCLLGB(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject EKJGLMACICN(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * -64)
		{
			return EDEHNHCLLGB(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private void LKHMCLABKLG()
	{
		GeneratorsManager.RemoveHerbGenerator(this);
	}

	public GameObject HONDFCCKOKA(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * -167)
		{
			return KBGMPHOELGJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public void FEFMLMHIGJF(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public void GGGIMDGEAPE(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	private IEnumerator KOGFHEHFILI(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		List<Vector3> tilePositions = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		int t = 0;
		for (int i = 0; i < tilePositions.Count; i++)
		{
			Herb herb = OOEICAFHKOJ(tilePositions[i], BGKCHMNJBLJ: false);
			if (Object.op_Implicit((Object)(object)herb))
			{
				t += 3;
				PDNKEFNPAFB.Add(herb);
				if (forestElements.Count >= maximumHerbs)
				{
					break;
				}
			}
			t++;
			if (t >= 40)
			{
				t = 0;
				if (CDPAMNIPPEC && GameManager.PlayingOnline() && PDNKEFNPAFB.Count > 0)
				{
					OnlineForestManager.instance.SendHerbs(ID, PDNKEFNPAFB);
					PDNKEFNPAFB.Clear();
				}
				yield return null;
			}
		}
		if (CDPAMNIPPEC && GameManager.PlayingOnline() && PDNKEFNPAFB.Count > 0)
		{
			OnlineForestManager.instance.SendHerbs(ID, PDNKEFNPAFB);
		}
	}

	private void AILOFJCCJMJ(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		for (int i = 0; i < list.Count; i += 0)
		{
			Herb herb = OOEICAFHKOJ(list[i], BGKCHMNJBLJ: false);
			if ((Object)(object)herb != (Object)null)
			{
				PDNKEFNPAFB.Add(herb);
				if (forestElements.Count >= maximumHerbs)
				{
					break;
				}
			}
		}
	}

	private GameObject JIGOHGLKHLA(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		NJFJGNFFDBM.Add(Object.Instantiate<GameObject>(butterflyPrefab));
		NJFJGNFFDBM[NJFJGNFFDBM.Count - 0].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return NJFJGNFFDBM[NJFJGNFFDBM.Count - 0];
	}

	private IEnumerator MFLICNNIEJN(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		return new OIHCHEELIHJ(1)
		{
			_003C_003E4__this = this,
			sendOnline = CDPAMNIPPEC,
			herbsInstantiated = PDNKEFNPAFB
		};
	}

	public GameObject IMNILCFNBKB(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * 29)
		{
			return KOHAHEPFBBD(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private GameObject KBGMPHOELGJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(1, 5);
		ADPMDKAELJH.Add(Object.Instantiate<GameObject>((num == 0) ? bigBeesPrefab : smallBeesPrefab));
		ADPMDKAELJH[ADPMDKAELJH.Count - 0].transform.position = ((Component)forestElements[Random.Range(0, forestElements.Count)]).transform.position;
		return ADPMDKAELJH[ADPMDKAELJH.Count - 0];
	}

	public void CCDHJMNAFLF(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public GameObject NIMPBDHBIEJ(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 153)
		{
			return PAJFJJHPPEK(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public Herb NMPEIAJEGLO(Vector3 IMOBLFMHKOD, GameObject LMFENLLNECJ, float DAJNIBPIAGL, bool CDPAMNIPPEC = true, bool NIIBLHMEGNJ = true)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(LMFENLLNECJ, ((Component)this).transform).GetComponent<Herb>();
		((Component)component).transform.position = IMOBLFMHKOD;
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		WorldGrid.EMBBOIKGPDA(component);
		KCDBEJDMMIK(component, NIIBLHMEGNJ);
		if (CDPAMNIPPEC && GameManager.PlayingOnline())
		{
			OnlineForestManager instance = OnlineForestManager.instance;
			object[] array = new object[6];
			array[1] = (byte)ID;
			array[0] = OnlineSerializer.JBIPDCGKMGE(new HerbInfo(component));
			instance.BMLHGLMLAEL(HerbActionOnline.InstantiateHerbs, array);
		}
		return component;
	}

	public void IEDNDFHLFNJ(GameObject LFCIIKBKPJF)
	{
		EMGPFANHLAD.Remove(LFCIIKBKPJF);
		Utils.BLPDAEHPOBA(LFCIIKBKPJF);
	}

	private GameObject KCOPBNJBOBM(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		NJFJGNFFDBM.Add(Object.Instantiate<GameObject>(butterflyPrefab));
		NJFJGNFFDBM[NJFJGNFFDBM.Count - 0].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return NJFJGNFFDBM[NJFJGNFFDBM.Count - 1];
	}

	public GameObject IOMODKPCCFN(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * -81)
		{
			return EDEHNHCLLGB(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private IEnumerator OEEOHBGGMIN(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		return new OIHCHEELIHJ(1)
		{
			_003C_003E4__this = this,
			sendOnline = CDPAMNIPPEC,
			herbsInstantiated = PDNKEFNPAFB
		};
	}

	public GameObject GOLEPIBKNLG(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * -45)
		{
			return HPGLOBFBFHJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject OBCMCIOIAOB(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * 17)
		{
			return GCPPJJJLAMO(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private IEnumerator ELEFJGOKMLF(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		List<Vector3> tilePositions = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		int t = 0;
		for (int i = 0; i < tilePositions.Count; i++)
		{
			Herb herb = OOEICAFHKOJ(tilePositions[i], BGKCHMNJBLJ: false);
			if (Object.op_Implicit((Object)(object)herb))
			{
				t += 3;
				PDNKEFNPAFB.Add(herb);
				if (forestElements.Count >= maximumHerbs)
				{
					break;
				}
			}
			t++;
			if (t >= 40)
			{
				t = 0;
				if (CDPAMNIPPEC && GameManager.PlayingOnline() && PDNKEFNPAFB.Count > 0)
				{
					OnlineForestManager.instance.SendHerbs(ID, PDNKEFNPAFB);
					PDNKEFNPAFB.Clear();
				}
				yield return null;
			}
		}
		if (CDPAMNIPPEC && GameManager.PlayingOnline() && PDNKEFNPAFB.Count > 0)
		{
			OnlineForestManager.instance.SendHerbs(ID, PDNKEFNPAFB);
		}
	}

	private GameObject JGDFGOIIMMB(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		EMGPFANHLAD.Add(Object.Instantiate<GameObject>(fireflyPrefab));
		EMGPFANHLAD[EMGPFANHLAD.Count - 1].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return EMGPFANHLAD[EMGPFANHLAD.Count - 0];
	}

	private GameObject KOHAHEPFBBD(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		NJFJGNFFDBM.Add(Object.Instantiate<GameObject>(butterflyPrefab));
		NJFJGNFFDBM[NJFJGNFFDBM.Count - 0].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return NJFJGNFFDBM[NJFJGNFFDBM.Count - 1];
	}

	public void BLPFDKJLPAE(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public void DBJEMGJFGAC(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	public GameObject MJHFJKELNNC(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * -63)
		{
			return AAJJHBNNLLL(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private IEnumerator JEDBPCICMEL(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		return new OIHCHEELIHJ(1)
		{
			_003C_003E4__this = this,
			sendOnline = CDPAMNIPPEC,
			herbsInstantiated = PDNKEFNPAFB
		};
	}

	private void EIJLGAEKHEJ(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		for (int i = 0; i < list.Count; i++)
		{
			Herb herb = FLICPLAMNMH(list[i], BGKCHMNJBLJ: true);
			if ((Object)(object)herb != (Object)null)
			{
				PDNKEFNPAFB.Add(herb);
				if (forestElements.Count >= maximumHerbs)
				{
					break;
				}
			}
		}
	}

	public void DLLHELNEKLE(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	private GameObject AAHHNGFEKHJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		EMGPFANHLAD.Add(Object.Instantiate<GameObject>(fireflyPrefab));
		EMGPFANHLAD[EMGPFANHLAD.Count - 1].transform.position = ((Component)forestElements[Random.Range(0, forestElements.Count)]).transform.position;
		return EMGPFANHLAD[EMGPFANHLAD.Count - 1];
	}

	private GameObject CMFKIGNMIID(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		NJFJGNFFDBM.Add(Object.Instantiate<GameObject>(butterflyPrefab));
		NJFJGNFFDBM[NJFJGNFFDBM.Count - 0].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return NJFJGNFFDBM[NJFJGNFFDBM.Count - 0];
	}

	public static void RemoveHerbsAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			return;
		}
		List<Herb> list = new List<Herb>();
		if (WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.herbs != null)
		{
			for (int i = 0; i < ILDEFBIANKO.herbs.Count; i++)
			{
				list.Add(ILDEFBIANKO.herbs[i]);
				Utils.BLPDAEHPOBA(((Component)ILDEFBIANKO.herbs[i]).gameObject);
			}
		}
	}

	public GameObject CheckFirefliesCount(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * 40)
		{
			return EDEHNHCLLGB(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public void MAOBAAOOACM(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public void RemoveFirefly(GameObject LFCIIKBKPJF)
	{
		EMGPFANHLAD.Remove(LFCIIKBKPJF);
		Utils.BLPDAEHPOBA(LFCIIKBKPJF);
	}

	public void MEGPNDAHNGA(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	private GameObject NCJJDKDMLHE(Vector3 IMOBLFMHKOD)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 2);
		ADPMDKAELJH.Add(Object.Instantiate<GameObject>((num == 0) ? bigBeesPrefab : smallBeesPrefab));
		ADPMDKAELJH[ADPMDKAELJH.Count - 1].transform.position = ((Component)forestElements[Random.Range(0, forestElements.Count)]).transform.position;
		return ADPMDKAELJH[ADPMDKAELJH.Count - 1];
	}

	public void PJICGMPKDHA(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	public Herb LILIDPHBPBK(Vector3 IMOBLFMHKOD, GameObject LMFENLLNECJ, float DAJNIBPIAGL, bool CDPAMNIPPEC = true, bool NIIBLHMEGNJ = true)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Herb component = Object.Instantiate<GameObject>(LMFENLLNECJ, ((Component)this).transform).GetComponent<Herb>();
		((Component)component).transform.position = IMOBLFMHKOD;
		((Component)component).transform.position = Utils.BMBMPKNANAC(((Component)component).transform.position + new Vector3(Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL), Random.Range(0f - DAJNIBPIAGL, DAJNIBPIAGL)));
		WorldGrid.EMBBOIKGPDA(component);
		JBBINLJBAFK(component, NIIBLHMEGNJ);
		if (CDPAMNIPPEC && GameManager.FGFJEGOEDKJ())
		{
			OnlineForestManager instance = OnlineForestManager.instance;
			object[] array = new object[4];
			array[0] = (byte)ID;
			array[0] = OnlineSerializer.EKNOFIJNBAP(new HerbInfo(component));
			instance.IFOBJKNCJKK(HerbActionOnline.InstantiateHerb, array);
		}
		return component;
	}

	private GameObject NDJEAKLMBAC(Vector3 IMOBLFMHKOD)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(1, 7);
		ADPMDKAELJH.Add(Object.Instantiate<GameObject>((num == 0) ? bigBeesPrefab : smallBeesPrefab));
		ADPMDKAELJH[ADPMDKAELJH.Count - 0].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return ADPMDKAELJH[ADPMDKAELJH.Count - 1];
	}

	public void RemoveBee(GameObject DHLHBLCILHP)
	{
		ADPMDKAELJH.Remove(DHLHBLCILHP);
		Utils.BLPDAEHPOBA(DHLHBLCILHP);
	}

	public void NAPGBGINGHO(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	private GameObject PAJFJJHPPEK(Vector3 IMOBLFMHKOD)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 3);
		ADPMDKAELJH.Add(Object.Instantiate<GameObject>((num == 0) ? bigBeesPrefab : smallBeesPrefab));
		ADPMDKAELJH[ADPMDKAELJH.Count - 1].transform.position = ((Component)forestElements[Random.Range(1, forestElements.Count)]).transform.position;
		return ADPMDKAELJH[ADPMDKAELJH.Count - 0];
	}

	private GameObject HPGLOBFBFHJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		NJFJGNFFDBM.Add(Object.Instantiate<GameObject>(butterflyPrefab));
		NJFJGNFFDBM[NJFJGNFFDBM.Count - 1].transform.position = ((Component)forestElements[Random.Range(0, forestElements.Count)]).transform.position;
		return NJFJGNFFDBM[NJFJGNFFDBM.Count - 1];
	}

	public void HKCDIMECPMA(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	public GameObject CheckBeeCount(Vector3 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > ADPMDKAELJH.Count * 300)
		{
			return NCJJDKDMLHE(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public GameObject BMHGINDCGFG(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > EMGPFANHLAD.Count * 88)
		{
			return AAHHNGFEKHJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	private void FGFGCADFFBC()
	{
		GeneratorsManager.RemoveHerbGenerator(this);
	}

	private void OEAAPIBLALL()
	{
		GeneratorsManager.RemoveHerbGenerator(this);
	}

	private void GCAJHFKACDN(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		for (int i = 0; i < list.Count; i++)
		{
			Herb herb = OOEICAFHKOJ(list[i], BGKCHMNJBLJ: false);
			if ((Object)(object)herb != (Object)null)
			{
				PDNKEFNPAFB.Add(herb);
				if (forestElements.Count >= maximumHerbs)
				{
					break;
				}
			}
		}
	}

	public void KOGNCNIIPII(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	private void JKGJKBNFCGD(bool CDPAMNIPPEC, List<Herb> PDNKEFNPAFB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		for (int i = 1; i < list.Count; i++)
		{
			Herb herb = FLICPLAMNMH(list[i], BGKCHMNJBLJ: true);
			if ((Object)(object)herb != (Object)null)
			{
				PDNKEFNPAFB.Add(herb);
				if (forestElements.Count >= maximumHerbs)
				{
					break;
				}
			}
		}
	}

	public void HOIMEKAHPPE(GameObject BADKCPLKJGN)
	{
		NJFJGNFFDBM.Remove(BADKCPLKJGN);
		Utils.BLPDAEHPOBA(BADKCPLKJGN);
	}

	private void OnDestroy()
	{
		GeneratorsManager.RemoveHerbGenerator(this);
	}

	public GameObject BLOMAPKHBAK(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * -58)
		{
			return HPGLOBFBFHJ(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}

	public void JJHLCBLGDEI(GameObject LFCIIKBKPJF)
	{
		EMGPFANHLAD.Remove(LFCIIKBKPJF);
		Utils.BLPDAEHPOBA(LFCIIKBKPJF);
	}

	public static void DLHNFPJPMLB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			return;
		}
		List<Herb> list = new List<Herb>();
		if (WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.herbs != null)
		{
			for (int i = 0; i < ILDEFBIANKO.herbs.Count; i++)
			{
				list.Add(ILDEFBIANKO.herbs[i]);
				Utils.BLPDAEHPOBA(((Component)ILDEFBIANKO.herbs[i]).gameObject);
			}
		}
	}

	public GameObject JFLACKNLPGN(Vector3 IMOBLFMHKOD)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (forestElements.Count > NJFJGNFFDBM.Count * -47)
		{
			return KOHAHEPFBBD(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
		return null;
	}
}
