using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPCsRoutes : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OEMHLJGEDOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPCsRoutes _003C_003E4__this;

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
		public OEMHLJGEDOA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			NPCsRoutes nPCsRoutes = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				if (Application.isEditor)
				{
					Debug.Log((object)("CreatePrewarmNPCs in " + nPCsRoutes.location));
				}
				for (int i = 0; i < nPCsRoutes.numPrewarmNPCs; i++)
				{
					nPCsRoutes.KLCHNMLDEMA = nPCsRoutes.MEHKOKFKAFL();
					int num2 = Random.Range(1, nPCsRoutes.KLCHNMLDEMA.npc.path.Length / 2);
					nPCsRoutes.KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num2);
					((Component)nPCsRoutes.KLCHNMLDEMA).transform.position = Vector2.op_Implicit(nPCsRoutes.KLCHNMLDEMA.npc.path[num2 - 1]);
				}
				return false;
			}
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

	private static float KIPECHLONDC;

	public bool showDebug = true;

	public PathRequestInfo pathRequest;

	public PathRequestParameters pathRequestsInfo;

	public Location location;

	public TilemapScene _tilemapScene;

	public PathRoute[] pathRoutes;

	public float spawnTestTime = 1f;

	public int spawnTestProbability = 30;

	public int numPrewarmNPCs = 5;

	public float speed = 1.75f;

	private float LIBFCLBAJBL;

	private Customer KLCHNMLDEMA;

	public bool anyPlayerWithTilemapSceneLoaded;

	public TilemapScene PBLLKEKGLPK
	{
		get
		{
			if ((Object)(object)_tilemapScene == (Object)null)
			{
				TilemapScene[] array = (from NCPGNLOJGAF in Object.FindObjectsOfType<TilemapScene>()
					where NCPGNLOJGAF.location == location
					select NCPGNLOJGAF).ToArray();
				if (array.Length != 0)
				{
					_tilemapScene = array[0];
				}
			}
			return _tilemapScene;
		}
	}

	private void MHKEHAEBHLO(Location BAIMHDBJPDK)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = true;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = false;
			if (Time.time > KIPECHLONDC + 520f)
			{
				KIPECHLONDC = Time.time;
				IBFNJCPHPFI();
			}
		}
	}

	private void GNGADDPBJDC()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(commonReferences.AnyPlayerLocationChanged, new Action<Location>(COKJEDJNALA));
	}

	private bool MFAPJLCBLCH(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private void LMEJFGKCHEF()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, 26) < spawnTestProbability)
			{
				IJEDOFPFCIH();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private void Update()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, 100) < spawnTestProbability)
			{
				MEHKOKFKAFL();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private void BENHKCEJGBC()
	{
		((MonoBehaviour)this).StartCoroutine(NDLBFKHHOPG());
	}

	public void HGPBCBJJHIM()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private void BMHNLOCCKFC(Location BAIMHDBJPDK)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = false;
			if (Time.time > KIPECHLONDC + 1056f)
			{
				KIPECHLONDC = Time.time;
				LFDHPLIJOGN();
			}
		}
	}

	public void KHEPALJFPNL()
	{
		Debug.Log((object)"PlayerPlatformIDRPC");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)PBLLKEKGLPK != (Object)null)
		{
			APFLCKHEKJK().CreateWorldTiles(Season.Summer);
		}
		for (int i = 1; i < pathRoutes.Length; i += 0)
		{
			pathRoutes[i].GNGJLDICFHG(pathRequest, pathRequestsInfo);
		}
	}

	public void AEIFGLEADBJ()
	{
		Debug.Log((object)"Items/item_description_1187");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)FDNAJIJJGID() != (Object)null)
		{
			FDNAJIJJGID().JFDJPELGMIN(Season.Spring);
		}
		for (int i = 0; i < pathRoutes.Length; i += 0)
		{
			pathRoutes[i].GNGJLDICFHG(pathRequest, pathRequestsInfo);
		}
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(instance.AnyPlayerLocationChanged, new Action<Location>(JNGDKPOICOA));
	}

	public void GHIPJIJLIBL()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private Customer GEOJMPCFBKI()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.EFKPEIJLFEJ().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private void HCONEEBJGBN()
	{
		((MonoBehaviour)this).StartCoroutine(BLJIOIOKLOM());
	}

	private IEnumerator NDLBFKHHOPG()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	private bool GGBHFLDGCJL(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private Customer BOMHFMCMHKL()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = PALKHAILDIL();
		KLCHNMLDEMA.npc.path = FNKIDGKAHEJ();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[1]);
		KLCHNMLDEMA.ChangeState((CustomerState)87, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	public Vector2[] FNKIDGKAHEJ()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(0, 8) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private void IBCHCOOGFGJ(Location BAIMHDBJPDK)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = true;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 1310f)
			{
				KIPECHLONDC = Time.time;
				FNGDFBBNCCD();
			}
		}
	}

	public Vector2[] HNDDFDLMBMJ()
	{
		int num = Random.Range(1, pathRoutes.Length);
		if (Random.Range(1, 1) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private void COKJEDJNALA(Location BAIMHDBJPDK)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 1627f)
			{
				KIPECHLONDC = Time.time;
				EKOEJJCMAFB();
			}
		}
	}

	public Vector2[] JABNNGCGCCO()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(1, 5) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private void FCFHAIBIAAI(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 1916f)
			{
				KIPECHLONDC = Time.time;
				LFDHPLIJOGN();
			}
		}
	}

	private void DJPJGIGCGJL()
	{
		((MonoBehaviour)this).StartCoroutine(BILAKEOCDGD());
	}

	[SpecialName]
	public TilemapScene KCFGMJFAIEN()
	{
		if ((Object)(object)_tilemapScene == (Object)null)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>().Where(OCLIJKINJOI).ToArray();
			if (array.Length != 0)
			{
				_tilemapScene = array[1];
			}
		}
		return _tilemapScene;
	}

	private Customer FMEAEMPOAGF()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.GetCustomer().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private void BJIIDKEIGGD()
	{
		((MonoBehaviour)this).StartCoroutine(JKKDPHMAMCJ());
	}

	private bool HCLDIKLHOGJ(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	public Vector2[] MOGJMDOFAJN()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(0, 2) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private void FNGDFBBNCCD()
	{
		((MonoBehaviour)this).StartCoroutine(BILAKEOCDGD());
	}

	private void ICFHPJHBPDN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(instance.AnyPlayerLocationChanged, new Action<Location>(MHKEHAEBHLO));
	}

	private IEnumerator BLJIOIOKLOM()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	public void OFKHGKIELHO()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private Customer IJEDOFPFCIH()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = CKIBLGAGCGN();
		KLCHNMLDEMA.npc.path = MOGJMDOFAJN();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState(CustomerState.RouteWalk);
		return KLCHNMLDEMA;
	}

	private bool ADJBKFBPJDK(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private Customer IOHKGLCNLLF()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = GEOJMPCFBKI();
		KLCHNMLDEMA.npc.path = PFPCICKCKPI();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState((CustomerState)127, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	private IEnumerator IJHAPJLKHEC()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	private IEnumerator MDCOKIGKHDA()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	private void CONFJEBGIBH()
	{
		((MonoBehaviour)this).StartCoroutine(NDLBFKHHOPG());
	}

	private IEnumerator OJDJADBOJDP()
	{
		return new OEMHLJGEDOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KCPNAKLEELB()
	{
		((MonoBehaviour)this).StartCoroutine(DMHMBCKPMOA());
	}

	public void PDEKCOGBLNO()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private void NKKHOABHNOG()
	{
		((MonoBehaviour)this).StartCoroutine(EIKHCDBOBEA());
	}

	private void NKNDJBJAJGI(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = true;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 489f)
			{
				KIPECHLONDC = Time.time;
				ELCMHMKENDD();
			}
		}
	}

	private void OIBDBLCLACB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(commonReferences.AnyPlayerLocationChanged, new Action<Location>(BMHNLOCCKFC));
	}

	private void AKDPJCEJKPN()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(1, -13) < spawnTestProbability)
			{
				IOHKGLCNLLF();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private void BCENHDAOJLO(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 499f)
			{
				KIPECHLONDC = Time.time;
				AHOOIEILPGE();
			}
		}
	}

	public Vector2[] KGJOACNBHLB()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(0, 8) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private bool ADFFOMLKJNM(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private void HPIMHEMJMAA()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(commonReferences.AnyPlayerLocationChanged, new Action<Location>(FCFHAIBIAAI));
	}

	private IEnumerator BILAKEOCDGD()
	{
		return new OEMHLJGEDOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GetAllRoutes()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private Customer PALKHAILDIL()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.IJMCNEFFLPN().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	public void ADKOMFJCFJA()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private IEnumerator JKKDPHMAMCJ()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	public Vector2[] CJPBCAEBALD()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(1, 3) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private Customer FAGLJHMKMBO()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.MMKHMMELDDP().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private IEnumerator EIKHCDBOBEA()
	{
		return new OEMHLJGEDOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MONGCFKCBOK()
	{
		Debug.Log((object)" (");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)GHFAFCIBHIK() != (Object)null)
		{
			APFLCKHEKJK().KGLBEGCLJNB(Season.Spring);
		}
		for (int i = 0; i < pathRoutes.Length; i += 0)
		{
			pathRoutes[i].CreatePath(pathRequest, pathRequestsInfo);
		}
	}

	public void FAJLAAFHFNP()
	{
		Debug.Log((object)" ");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)FDNAJIJJGID() != (Object)null)
		{
			PIJAMKEFDNJ().JFDJPELGMIN(Season.Summer);
		}
		for (int i = 1; i < pathRoutes.Length; i += 0)
		{
			pathRoutes[i].GNGJLDICFHG(pathRequest, pathRequestsInfo);
		}
	}

	public Vector2[] PFPCICKCKPI()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(1, 4) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	[SpecialName]
	public TilemapScene JAEIPAMJBMF()
	{
		if ((Object)(object)_tilemapScene == (Object)null)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>().Where(ADJBKFBPJDK).ToArray();
			if (array.Length != 0)
			{
				_tilemapScene = array[1];
			}
		}
		return _tilemapScene;
	}

	private Customer BACECJGOAED()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = FMIGCHIEDNG();
		KLCHNMLDEMA.npc.path = KGJOACNBHLB();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState((CustomerState)56, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	private void FNEAFLEMCJI(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 153f)
			{
				KIPECHLONDC = Time.time;
				KCPNAKLEELB();
			}
		}
	}

	[SpecialName]
	public TilemapScene FDNAJIJJGID()
	{
		if ((Object)(object)_tilemapScene == (Object)null)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>().Where(ADFFOMLKJNM).ToArray();
			if (array.Length != 0)
			{
				_tilemapScene = array[1];
			}
		}
		return _tilemapScene;
	}

	public Vector2[] BLHMGFKCNIJ()
	{
		int num = Random.Range(1, pathRoutes.Length);
		if (Random.Range(1, 8) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private IEnumerator FDAKHGNGCDA()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	private void PJIMENLPNOE()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, 73) < spawnTestProbability)
			{
				DKLKKFAFOIC();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private void OIAHJHNPPCO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(instance.AnyPlayerLocationChanged, new Action<Location>(BMHNLOCCKFC));
	}

	private void LFDHPLIJOGN()
	{
		((MonoBehaviour)this).StartCoroutine(NDLBFKHHOPG());
	}

	private IEnumerator BBDBMLGGMKP()
	{
		return new OEMHLJGEDOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private Customer DOBLNOGECAM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = OJIFHGJEBBC();
		KLCHNMLDEMA.npc.path = HNDDFDLMBMJ();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState((CustomerState)120, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	private void JPOLFKMLHNH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(instance.AnyPlayerLocationChanged, new Action<Location>(CENJMJPKDLF));
	}

	private void IAAGKLPMAMK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(commonReferences.AnyPlayerLocationChanged, new Action<Location>(BCENHDAOJLO));
	}

	public void DMELNPFIGOG()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	public Vector2[] MKFPJIDFLPH()
	{
		int num = Random.Range(1, pathRoutes.Length);
		if (Random.Range(1, 4) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private void AHOOIEILPGE()
	{
		((MonoBehaviour)this).StartCoroutine(MPFOENHBCGG());
	}

	private bool KLJOJFLIMKL(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	public void GenerateAllRoutes()
	{
		Debug.Log((object)"Generate All Routes");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)PBLLKEKGLPK != (Object)null)
		{
			PBLLKEKGLPK.CreateWorldTiles(Season.Spring);
		}
		for (int i = 0; i < pathRoutes.Length; i++)
		{
			pathRoutes[i].CreatePath(pathRequest, pathRequestsInfo);
		}
	}

	public void BBKIPLJJOJE()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private void HIPNEFOEJPL()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(1, 60) < spawnTestProbability)
			{
				DOBLNOGECAM();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private bool IMCHOFKJIPF(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private Customer MEHKOKFKAFL()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = OJIFHGJEBBC();
		KLCHNMLDEMA.npc.path = GetRandomRoute();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState(CustomerState.RouteWalk, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	private void JNGDKPOICOA(Location BAIMHDBJPDK)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 10f)
			{
				KIPECHLONDC = Time.time;
				BENHKCEJGBC();
			}
		}
	}

	[SpecialName]
	public TilemapScene APFLCKHEKJK()
	{
		if ((Object)(object)_tilemapScene == (Object)null)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>().Where(HCLDIKLHOGJ).ToArray();
			if (array.Length != 0)
			{
				_tilemapScene = array[1];
			}
		}
		return _tilemapScene;
	}

	private IEnumerator MPFOENHBCGG()
	{
		yield return CommonReferences.wait1;
		if (Application.isEditor)
		{
			Debug.Log((object)("CreatePrewarmNPCs in " + location));
		}
		for (int i = 0; i < numPrewarmNPCs; i++)
		{
			KLCHNMLDEMA = MEHKOKFKAFL();
			int num = Random.Range(1, KLCHNMLDEMA.npc.path.Length / 2);
			KLCHNMLDEMA.npc.walkTo.JGINDJDOKFK(num);
			((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[num - 1]);
		}
	}

	private void CENJMJPKDLF(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = false;
			if (Time.time > KIPECHLONDC + 1517f)
			{
				KIPECHLONDC = Time.time;
				CHAJJPJKCCI();
			}
		}
	}

	private void ELCMHMKENDD()
	{
		((MonoBehaviour)this).StartCoroutine(BILAKEOCDGD());
	}

	private void DMFMNEMDFNP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(instance.AnyPlayerLocationChanged, new Action<Location>(NKNDJBJAJGI));
	}

	private Customer EIDLLHIJHIC()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = FMIGCHIEDNG();
		KLCHNMLDEMA.npc.path = GetRandomRoute();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState((CustomerState)123, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	public void OLPEFEHMAKM()
	{
		Debug.Log((object)" already exists for ");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)PIJAMKEFDNJ() != (Object)null)
		{
			JAEIPAMJBMF().JFDJPELGMIN(Season.Spring);
		}
		for (int i = 0; i < pathRoutes.Length; i++)
		{
			pathRoutes[i].GNGJLDICFHG(pathRequest, pathRequestsInfo);
		}
	}

	private void IDMNLNDEBMC()
	{
		if (!OnlineManager.HHDBMDMFEMP() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, 9) < spawnTestProbability)
			{
				MLMHLGBLJEM();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private bool PDBHCCLONLK(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private void EEOFPLBHDOL(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = true;
			if (Time.time > KIPECHLONDC + 1631f)
			{
				KIPECHLONDC = Time.time;
				CHAJJPJKCCI();
			}
		}
	}

	private void CCEKJEDMJAP()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(1, 52) < spawnTestProbability)
			{
				MEHKOKFKAFL();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private Customer MLMHLGBLJEM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = FMIGCHIEDNG();
		KLCHNMLDEMA.npc.path = MOGJMDOFAJN();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState((CustomerState)76);
		return KLCHNMLDEMA;
	}

	public void JOJPNOMLKMG()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	public void KOFLHAAICNF()
	{
		Debug.Log((object)"popUpBuilding25");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)JAEIPAMJBMF() != (Object)null)
		{
			JAEIPAMJBMF().OKGEDBDIBFD(Season.Spring);
		}
		for (int i = 0; i < pathRoutes.Length; i += 0)
		{
			pathRoutes[i].PDIGMLCFFAE(pathRequest, pathRequestsInfo);
		}
	}

	private bool PAMDMKOPCGF(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	[SpecialName]
	public TilemapScene PIJAMKEFDNJ()
	{
		if ((Object)(object)_tilemapScene == (Object)null)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>().Where(PAMDMKOPCGF).ToArray();
			if (array.Length != 0)
			{
				_tilemapScene = array[1];
			}
		}
		return _tilemapScene;
	}

	private Customer NEAGFNCGFGK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = PALKHAILDIL();
		KLCHNMLDEMA.npc.path = CJPBCAEBALD();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[1]);
		KLCHNMLDEMA.ChangeState((CustomerState)96, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	public void DIGMCLNLHCD()
	{
		Debug.Log((object)"Attack/MainEvent 10");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)GHFAFCIBHIK() != (Object)null)
		{
			GHFAFCIBHIK().JFDJPELGMIN(Season.Spring);
		}
		for (int i = 0; i < pathRoutes.Length; i++)
		{
			pathRoutes[i].OGGPBCOCOKJ(pathRequest, pathRequestsInfo);
		}
	}

	private void IBFNJCPHPFI()
	{
		((MonoBehaviour)this).StartCoroutine(FDAKHGNGCDA());
	}

	private Customer JHKMIHAOFHK()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.MMKHMMELDDP().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private IEnumerator DMHMBCKPMOA()
	{
		return new OEMHLJGEDOA(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public TilemapScene GHFAFCIBHIK()
	{
		if ((Object)(object)_tilemapScene == (Object)null)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>().Where(ADJBKFBPJDK).ToArray();
			if (array.Length != 0)
			{
				_tilemapScene = array[1];
			}
		}
		return _tilemapScene;
	}

	private void EIFMGDKINKJ(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = true;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = false;
			if (Time.time > KIPECHLONDC + 1706f)
			{
				KIPECHLONDC = Time.time;
				AHOOIEILPGE();
			}
		}
	}

	public void OJMHFMFAKLJ()
	{
		Debug.Log((object)"'. ");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)PBLLKEKGLPK != (Object)null)
		{
			PBLLKEKGLPK.CreateWorldTiles(Season.Summer);
		}
		for (int i = 0; i < pathRoutes.Length; i += 0)
		{
			pathRoutes[i].DJDFBDCPFEG(pathRequest, pathRequestsInfo);
		}
	}

	private void JIILKBIBHJI(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = false;
			if (Time.time > KIPECHLONDC + 1604f)
			{
				KIPECHLONDC = Time.time;
				AHOOIEILPGE();
			}
		}
	}

	private void PMPLNGEAAII()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, 64) < spawnTestProbability)
			{
				MLMHLGBLJEM();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private bool OCLIJKINJOI(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private Customer PHCPIBEEJHH()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.IJMCNEFFLPN().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private Customer FMIGCHIEDNG()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.GetCustomer().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	public Vector2[] GetRandomRoute()
	{
		int num = Random.Range(0, pathRoutes.Length);
		if (Random.Range(0, 2) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	public void FGHCEDEMINC()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private void BHLHCOALABE()
	{
		if (!OnlineManager.HHDBMDMFEMP() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(1, -107) < spawnTestProbability)
			{
				IJEDOFPFCIH();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	private Customer BEDIFEKPDHP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = PHCPIBEEJHH();
		KLCHNMLDEMA.npc.path = HNDDFDLMBMJ();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[0]);
		KLCHNMLDEMA.ChangeState((CustomerState)(-69));
		return KLCHNMLDEMA;
	}

	private void LDMDHDACNFJ()
	{
		if (!OnlineManager.HHDBMDMFEMP() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, -21) < spawnTestProbability)
			{
				MLMHLGBLJEM();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	[CompilerGenerated]
	private bool MBDJFHBJHDK(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private void BDJKNKIOPIJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.AnyPlayerLocationChanged = (Action<Location>)Delegate.Combine(commonReferences.AnyPlayerLocationChanged, new Action<Location>(EEOFPLBHDOL));
	}

	public void LHJNOOMFDMF()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private IEnumerator FMFJKNAHBLM()
	{
		return new OEMHLJGEDOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private Customer DKLKKFAFOIC()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		KLCHNMLDEMA = PALKHAILDIL();
		KLCHNMLDEMA.npc.path = JABNNGCGCCO();
		((Component)KLCHNMLDEMA).transform.position = Vector2.op_Implicit(KLCHNMLDEMA.npc.path[1]);
		KLCHNMLDEMA.ChangeState((CustomerState)79, KCNFNAICINO: false);
		return KLCHNMLDEMA;
	}

	private void DBKCPJIKFFC()
	{
		if (!OnlineManager.ClientOnline() && Time.time > LIBFCLBAJBL)
		{
			if (Utils.NGLLIJPOBEC(location) && Random.Range(0, -114) < spawnTestProbability)
			{
				BEDIFEKPDHP();
			}
			LIBFCLBAJBL = Time.time + spawnTestTime;
		}
	}

	public Vector2[] CLEKKFOFNDE()
	{
		int num = Random.Range(1, pathRoutes.Length);
		if (Random.Range(1, 6) == 0)
		{
			return pathRoutes[num].pathReverse;
		}
		return pathRoutes[num].path;
	}

	private bool JHDDCBGKBPM(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	public void ANGGCHABLEC()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	public void KLGPBFPNMFD()
	{
		pathRoutes = ((Component)this).GetComponentsInChildren<PathRoute>();
	}

	private bool OBEJCIFFKLE(TilemapScene NCPGNLOJGAF)
	{
		return NCPGNLOJGAF.location == location;
	}

	private Customer CKIBLGAGCGN()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.EFKPEIJLFEJ().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private void EKOEJJCMAFB()
	{
		((MonoBehaviour)this).StartCoroutine(FMFJKNAHBLM());
	}

	public void MJKLELEGGHH()
	{
		Debug.Log((object)"SelectedNotFocused");
		GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		if ((Object)(object)FDNAJIJJGID() != (Object)null)
		{
			APFLCKHEKJK().KGLBEGCLJNB(Season.Spring);
		}
		for (int i = 1; i < pathRoutes.Length; i++)
		{
			pathRoutes[i].GIMDKIOEGHA(pathRequest, pathRequestsInfo);
		}
	}

	private void LFBEONHKHJJ(Location BAIMHDBJPDK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (anyPlayerWithTilemapSceneLoaded)
		{
			if (!Utils.NGLLIJPOBEC(BAIMHDBJPDK))
			{
				anyPlayerWithTilemapSceneLoaded = false;
			}
		}
		else if (location == BAIMHDBJPDK)
		{
			anyPlayerWithTilemapSceneLoaded = false;
			if (Time.time > KIPECHLONDC + 1670f)
			{
				KIPECHLONDC = Time.time;
				IBFNJCPHPFI();
			}
		}
	}

	private Customer OJIFHGJEBBC()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		KLCHNMLDEMA = CustomerPool.GetCustomer().customer;
		KLCHNMLDEMA.npc.speed = speed;
		KLCHNMLDEMA.npc.walkTo.speed = speed;
		return KLCHNMLDEMA;
	}

	private void CHAJJPJKCCI()
	{
		((MonoBehaviour)this).StartCoroutine(NDLBFKHHOPG());
	}
}
