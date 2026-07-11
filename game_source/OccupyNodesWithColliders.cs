using UnityEngine;

public class OccupyNodesWithColliders : MonoBehaviour
{
	public bool useLocalPositions;

	public bool checkNodesOnEnable = true;

	public Vector2[] positions;

	private Coroutine GGMOLGBALMM;

	private void OnDrawGizmosSelected()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(DBOOKDLOKIJ(positions, i)), 0.035f);
			}
		}
	}

	private void GJCADEIJMCM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.LHCHKGAEFFP(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	public void CheckAllNodes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CheckAllNodes(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private Vector2 LLDEHHLKGFD(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	public void PJAJNOPGAHH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NPAHPODBKLP(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private void AEMNHHGAPIL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.GGKMBODCLGK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void FKPNIHJGFBJ()
	{
		if (checkNodesOnEnable)
		{
			OPPBPMBNNNI();
		}
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.GGFJGHHHEJC).StopCoroutine(GGMOLGBALMM);
			}
			MCIPNFIPCFL();
		}
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.ELGNEJNLBNO()).StopCoroutine(GGMOLGBALMM);
			}
			IJONBNOEEIP();
		}
	}

	public void FGFDPFKCBKO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NPAHPODBKLP(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private void LAPEOBADLHO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(FCDAJNCMIIA(positions, i)), 248f);
			}
		}
	}

	public void KPIBCIBOGEB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void Start()
	{
		if (checkNodesOnEnable)
		{
			CheckAllNodes();
		}
	}

	private Vector2 INEOMGOBDHO(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	public void EPLIDKBOBDD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.SetMoveNodeFree(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private void GBAKNAINDJM()
	{
		if (checkNodesOnEnable)
		{
			CheckAllNodes();
		}
	}

	public void HDEFJFOHBNH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ABPEJFPBDDH(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: true, useLocalPositions);
	}

	private Vector2 HJBHNNDMAJG(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void AJMMEPMCOFL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(HJBHNNDMAJG(positions, i)), 781f);
			}
		}
	}

	private void HKJCLFHCMKC()
	{
		if (checkNodesOnEnable)
		{
			OPPBPMBNNNI();
		}
	}

	private void HHMBCKCNPPN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.GGFJGHHHEJC).StopCoroutine(GGMOLGBALMM);
			}
			OPPBPMBNNNI();
		}
	}

	private void JCAJKNOGFLA()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 1; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(FCDAJNCMIIA(positions, i)), 777f);
			}
		}
	}

	private void FPJABCNDEEJ()
	{
		if (checkNodesOnEnable)
		{
			OPPBPMBNNNI();
		}
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.GGFJGHHHEJC).StopCoroutine(GGMOLGBALMM);
			}
			CheckAllNodes();
		}
	}

	private void OCAGFMDIHGM()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(DBOOKDLOKIJ(positions, i)), 998f);
			}
		}
	}

	private Vector2 KFMNDDFFNBN(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void KJOJLHCDFPP()
	{
		if (checkNodesOnEnable)
		{
			EODOPCKFBNG();
		}
	}

	private void MDIENLHEDGE()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.FMIDAFEGDCD()).StopCoroutine(GGMOLGBALMM);
			}
			KDNBFFIPFFE();
		}
	}

	private void NCIBKMLIIAJ()
	{
		if (checkNodesOnEnable)
		{
			KPIBCIBOGEB();
		}
	}

	private void PHKEOHMNECJ()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 1; i < positions.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(GGHCHHLDNCM(positions, i)), 386f);
			}
		}
	}

	public void NOFCBHNFHJI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ABPEJFPBDDH(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private Vector2 DBOOKDLOKIJ(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	public void IEKDHCHBOMF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ABPEJFPBDDH(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private void JMCEPBNDMDO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 1; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(LCGKEDFMPHN(positions, i)), 1595f);
			}
		}
	}

	private void CKEHLJPEJMI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 1; i < positions.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(DBOOKDLOKIJ(positions, i)), 254f);
			}
		}
	}

	private void IAEPFFMCKOH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.BFBOAOHKMHK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.ELGNEJNLBNO()).StopCoroutine(GGMOLGBALMM);
			}
			CheckAllNodes();
		}
	}

	public void KFPIBONAIHE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CheckAllNodes(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	public void FBMMCIBKHPK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.SetMoveNodeFree(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	public void BMJCGGODFFB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ABPEJFPBDDH(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: true, useLocalPositions);
	}

	public void OPPBPMBNNNI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void ONNAGOCFJML()
	{
		if (checkNodesOnEnable)
		{
			MCIPNFIPCFL();
		}
	}

	private void BFKCHCLJIPL()
	{
		if (checkNodesOnEnable)
		{
			EODOPCKFBNG();
		}
	}

	public void GPAJBAKJADO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NLDCPFFGJIM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void DCOEEADJLIK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.ELGNEJNLBNO()).StopCoroutine(GGMOLGBALMM);
			}
			EODOPCKFBNG();
		}
	}

	private void PJOAFKEIPPD()
	{
		if (checkNodesOnEnable)
		{
			IJONBNOEEIP();
		}
	}

	public void MPODBMPFGJF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NPAHPODBKLP(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: true, useLocalPositions);
	}

	private void FGFGCADFFBC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.BNBMNOMFFBE()).StopCoroutine(GGMOLGBALMM);
			}
			IJONBNOEEIP();
		}
	}

	private void NLFHFPHDNCF()
	{
		if (checkNodesOnEnable)
		{
			NCFDEOLIALM();
		}
	}

	public void MJDOEJJCCMM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.SetMoveNodeFree(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	public void OEGKHBEEFOK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NPAHPODBKLP(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: true, useLocalPositions);
	}

	private Vector2 IAFEGFLBBIF(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void MNEAOFNAKIP()
	{
		if (checkNodesOnEnable)
		{
			MHEECOJKLPJ();
		}
	}

	public void KCGKJGFGHLH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NPAHPODBKLP(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	public void PGFOIFEFKKJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NPAHPODBKLP(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private void OnDisable()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.CheckAllNodesNextFrame(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	public void PDGBIKOLALJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	public void NCFDEOLIALM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void MHENLAGHFOD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.GGKMBODCLGK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	public void CPABCHCKDEM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CheckAllNodes(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private Vector2 NLNJCKOBFGA(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void ECHHHBBHNLF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.LGGMCNINMAK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private Vector2 GGHCHHLDNCM(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void NDGFPPOBCNP()
	{
		if (checkNodesOnEnable)
		{
			KDNBFFIPFFE();
		}
	}

	private void PCNALDJDIFM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.LHCHKGAEFFP(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void GJJPNFHFBFP()
	{
		if (checkNodesOnEnable)
		{
			KPIBCIBOGEB();
		}
	}

	private void OJLGOCFKLJE()
	{
		if (checkNodesOnEnable)
		{
			OPPBPMBNNNI();
		}
	}

	private void CACPOGPOKOJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.BFBOAOHKMHK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void OILHJENGGEL()
	{
		if (checkNodesOnEnable)
		{
			EODOPCKFBNG();
		}
	}

	private void NBMJJFNKJBA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.LHCHKGAEFFP(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void BONEKIAPEIK()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.BFBOAOHKMHK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	public void LHPJJCEBJPN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.NLDCPFFGJIM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void CMEDJEGJLJN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.FMIDAFEGDCD()).StopCoroutine(GGMOLGBALMM);
			}
			EODOPCKFBNG();
		}
	}

	private void JJDEGMGCOCC()
	{
		if (checkNodesOnEnable)
		{
			EODOPCKFBNG();
		}
	}

	public void KDNBFFIPFFE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	public void OccupyNodes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.SetMoveNodeFree(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private void HIKLHJCHENA()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(FCDAJNCMIIA(positions, i)), 560f);
			}
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.BNBMNOMFFBE()).StopCoroutine(GGMOLGBALMM);
			}
			LHPJJCEBJPN();
		}
	}

	private void NBBFLJNPLEA()
	{
		if (checkNodesOnEnable)
		{
			MCIPNFIPCFL();
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.GGFJGHHHEJC).StopCoroutine(GGMOLGBALMM);
			}
			CheckAllNodes();
		}
	}

	private void HOKBBFHGACN()
	{
		if (checkNodesOnEnable)
		{
			GPAJBAKJADO();
		}
	}

	private Vector2 NBOPIIMHJEE(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void OHOHFGMJGAJ()
	{
		if (checkNodesOnEnable)
		{
			NCFDEOLIALM();
		}
	}

	private Vector2 LCGKEDFMPHN(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void FPNPLFALPHP()
	{
		if (checkNodesOnEnable)
		{
			OPPBPMBNNNI();
		}
	}

	private void JBBHDOMALDB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.FMIDAFEGDCD()).StopCoroutine(GGMOLGBALMM);
			}
			EODOPCKFBNG();
		}
	}

	private void OnEnable()
	{
		if (checkNodesOnEnable)
		{
			CheckAllNodes();
		}
	}

	private void MKHMCIFFOFJ()
	{
		if (checkNodesOnEnable)
		{
			CheckAllNodes();
		}
	}

	private void JMMBKMOBAFB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.DLCCOHCAGDA(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void KNPOIMBPKML()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.DLCCOHCAGDA(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void DMFMNEMDFNP()
	{
		if (checkNodesOnEnable)
		{
			KDNBFFIPFFE();
		}
	}

	private void FIBPHCEGKEO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(NLNJCKOBFGA(positions, i)), 1788f);
			}
		}
	}

	public void LCNJJDDAEFJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.SetMoveNodeFree(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: true, useLocalPositions);
	}

	private void HODEGNKOLJO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 1; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(HJBHNNDMAJG(positions, i)), 67f);
			}
		}
	}

	public void BNCECPNBFFK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.SetMoveNodeFree(Vector2.op_Implicit(((Component)this).transform.position), positions, GAKNPAMHAFB: false, useLocalPositions);
	}

	private Vector2 DOBOHJJHAIA(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private Vector2 FCDAJNCMIIA(Vector2[] HAEIAGKNEPC, int MENBAFNNBFB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (useLocalPositions)
		{
			return Vector2.op_Implicit(((Component)this).transform.position) + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void BPINJGFECPF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PathNodesManager.LGGMCNINMAK(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.GGFJGHHHEJC).StopCoroutine(GGMOLGBALMM);
			}
			KDNBFFIPFFE();
		}
	}

	private void EAJBGIPFGHB()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(NBOPIIMHJEE(positions, i)), 1763f);
			}
		}
	}

	private void LEPDLPEPEFD()
	{
		if (checkNodesOnEnable)
		{
			NCFDEOLIALM();
		}
	}

	public void EODOPCKFBNG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.GIHGMEOBMHC(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	public void IJONBNOEEIP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CheckAllNodes(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	public void MCIPNFIPCFL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void HEJJCDKKGFI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 1; i < positions.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(LCGKEDFMPHN(positions, i)), 1369f);
			}
		}
	}

	private void HBMBCANOPMH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (positions != null)
		{
			Gizmos.color = Color.cyan;
			for (int i = 0; i < positions.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(KFMNDDFFNBN(positions, i)), 776f);
			}
		}
	}

	private void KPOAGLEJGNG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PathNodesManager.LHCHKGAEFFP(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
		}
	}

	public void MHEECOJKLPJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.ALGOHKHHELM(Vector2.op_Implicit(((Component)this).transform.position), positions, useLocalPositions);
	}

	private void LAOMCDFAFGA()
	{
		if (checkNodesOnEnable)
		{
			IJONBNOEEIP();
		}
	}

	private void KOBNHPKEJJD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.DIHCEGINELM()).StopCoroutine(GGMOLGBALMM);
			}
			KFPIBONAIHE();
		}
	}

	private void CFIIEJDJFPB()
	{
		if (checkNodesOnEnable)
		{
			GPAJBAKJADO();
		}
	}

	private void BNIKICAEIND()
	{
		if (checkNodesOnEnable)
		{
			MCIPNFIPCFL();
		}
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (GGMOLGBALMM != null)
			{
				((MonoBehaviour)PathNodesManager.DIHCEGINELM()).StopCoroutine(GGMOLGBALMM);
			}
			EODOPCKFBNG();
		}
	}
}
