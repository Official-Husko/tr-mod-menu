using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ToolInstance : ItemInstance, IActionable, ITool
{
	[CompilerGenerated]
	private sealed class CCNDNGLJHFG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public ToolInstance _003C_003E4__this;

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
		public CCNDNGLJHFG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			ToolInstance toolInstance = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)toolInstance.MLKAICLMFLG());
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

	public int selectedRowCount = 1;

	protected Vector2 BIPAILENDLH;

	protected Vector2 JHAFFFNJIJH;

	protected int KDLIFDDLPHO;

	private Coroutine NBDLHLOJHFC;

	protected Direction PKKABPMIAKB;

	private Vector2 ELJJMCCJEGH = new Vector2(0f, 0f);

	private Vector2 DKKDCMABJKJ = new Vector2(0f, 0f);

	private bool AAOPAIDJEAL;

	private float DBEFBFPAOAA;

	private bool NKEPKDBENHM;

	private float LOHBIEBPKMG;

	protected Vector2 DEACEMMGPHA;

	private static List<Vector2> JPMFPKOEENP = new List<Vector2>();

	private static bool IFHNAJLPFDF = false;

	private static bool GDIGPFGIGPL = false;

	private static bool KKHOIFKIGPE = false;

	private static bool MMPKLNMBOMO = false;

	private static bool MFMBLELHKMA = false;

	private static bool OFIPCIEEMLG = false;

	private static bool JOFGLBONHDC = false;

	private static bool AGIMAAPHGDO = false;

	private static Vector2 ANHBAFNFHPI;

	private static Vector2 MCPBHONDOLK;

	protected GridInfo KNIMLGOGFPA => MLKAICLMFLG().gridInfo;

	protected int IGCPCEKPHCI => MLKAICLMFLG().toolLevel;

	public virtual bool NMLEAHMCIEA(int JIIGOACEIKL)
	{
		return false;
	}

	protected void KGGNKGFPOHF(int JIIGOACEIKL, int OKNOJJEFEBE)
	{
		KDLIFDDLPHO = OKNOJJEFEBE;
	}

	protected void OADMFDJAEHO(int JIIGOACEIKL, float DBEFBFPAOAA)
	{
		this.DBEFBFPAOAA = DBEFBFPAOAA;
	}

	protected void MDLDPLCDEMA(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(NBDLHLOJHFC);
		}
	}

	public void MBDMEFMMGEI(int JIIGOACEIKL)
	{
		ECCOJOMGCFA(JIIGOACEIKL);
		if (selectedRowCount < LMHDGKJIHMK().toolLevel)
		{
			selectedRowCount += 0;
		}
		else
		{
			selectedRowCount = 0;
		}
	}

	public virtual bool GDDADHNEIBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	protected Vector2 KDBOCIGNBJL(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD + 1739f * new Vector2(0f - Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL)).y, Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)).x);
	}

	public bool BNFEOMPAOAF()
	{
		return LPNELFNCDMC().usesGrid;
	}

	protected float AEPBKIHMMLN(int JIIGOACEIKL)
	{
		return DBEFBFPAOAA;
	}

	protected float NNJIJNAAFDG(int JIIGOACEIKL)
	{
		return DBEFBFPAOAA;
	}

	protected Vector2 MMBONNFKKKG(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD + 732f * new Vector2(0f - Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)).y, Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL)).x);
	}

	public virtual void GMLNCJAOEOI(int JIIGOACEIKL)
	{
	}

	public virtual void ALIFAADPGJJ(int JIIGOACEIKL)
	{
	}

	protected void HPFCEDGAFCH(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StopCoroutine(NBDLHLOJHFC);
		}
	}

	public Vector2 EEKKNPDOLLE(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BIPAILENDLH;
	}

	protected Direction MKJKBKAKMAB(int JIIGOACEIKL)
	{
		return PKKABPMIAKB;
	}

	public Vector2 FOMOOMKHMPB(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BIPAILENDLH;
	}

	protected void PLNGELGLDLP(int JIIGOACEIKL)
	{
		if (AAOPAIDJEAL && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = PKKABPMIAKB;
		}
	}

	[SpecialName]
	protected int DAEOCFODOML()
	{
		return LPNELFNCDMC().toolLevel;
	}

	public virtual bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		return false;
	}

	public virtual void ANDIKJDCMHD(int JIIGOACEIKL)
	{
	}

	protected Direction EHODBEAJFLF(int JIIGOACEIKL)
	{
		return PKKABPMIAKB;
	}

	private IEnumerator IKIOHKNPBAM(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
	}

	public void GFLJEJNLOPA(int JIIGOACEIKL)
	{
		selectedRowCount = MLKAICLMFLG().toolLevel;
	}

	public bool BFCJLLFCCNM(int JIIGOACEIKL, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return EJBPONAAEIL(JIIGOACEIKL, item, EPLKICANCAL, LLGNLGENLHD, KNIMLGOGFPA, selectedRowCount);
	}

	public bool IDEFPECPOOM()
	{
		return BLIKNGGCLID().usesGrid;
	}

	protected bool FGONNFHKPAA(int JIIGOACEIKL)
	{
		return NKEPKDBENHM;
	}

	public virtual void BLJILGCBAPC(int JIIGOACEIKL)
	{
	}

	public void ODLENFDNCND(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BIPAILENDLH = IMOBLFMHKOD;
	}

	public virtual void JMHEPONCBDC(int JIIGOACEIKL)
	{
	}

	protected float MBMBLLKCMNL(int JIIGOACEIKL)
	{
		return DBEFBFPAOAA;
	}

	public void LFDCIMLCBKN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JHAFFFNJIJH = IMOBLFMHKOD;
	}

	public Vector2 DCEFMJDIFGM(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return JHAFFFNJIJH;
	}

	protected float CPIDKGEGGHJ(int JIIGOACEIKL)
	{
		return DBEFBFPAOAA;
	}

	public virtual void FOLIBMJAAMH(int JIIGOACEIKL)
	{
	}

	public virtual void BDJLEFMCMNG(int JIIGOACEIKL)
	{
	}

	public void MDELNLBDIOG(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BIPAILENDLH = IMOBLFMHKOD;
	}

	public Tool LMHDGKJIHMK()
	{
		return (Tool)item;
	}

	public virtual void ACMFFDODECH(int JIIGOACEIKL)
	{
	}

	public virtual bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if ((Object)(object)MLKAICLMFLG().skin != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).toolSkinController.ChangeSkin(MLKAICLMFLG().bodyPart, MLKAICLMFLG().skin);
		}
		if (KLGOCJMGKFO)
		{
			NOCJKKFCNKG(JIIGOACEIKL, 0);
		}
		return true;
	}

	public virtual void DBLLGLMMGNC(int JIIGOACEIKL)
	{
	}

	public virtual void ECCOJOMGCFA(int JIIGOACEIKL)
	{
	}

	public bool GPDPNDPCKPC(int JIIGOACEIKL, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return POLFPDKFMHM(JIIGOACEIKL, item, EPLKICANCAL, LLGNLGENLHD, OELPLBOEBML(), selectedRowCount);
	}

	protected void PCEHBFMDBMG(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(NBDLHLOJHFC);
		}
	}

	public virtual bool FNKPGMMOAMB(int JIIGOACEIKL)
	{
		return true;
	}

	public virtual void MDDMJAMDMNI(int JIIGOACEIKL)
	{
	}

	protected Vector2 GMAFNNMMFAK(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DKKDCMABJKJ;
	}

	public bool HBEBAFHEMAP(int JIIGOACEIKL, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return HBEBAFHEMAP(JIIGOACEIKL, item, EPLKICANCAL, LLGNLGENLHD, KNIMLGOGFPA, selectedRowCount);
	}

	public static bool EJBPONAAEIL(int JIIGOACEIKL, Item MEMGMDOCBOJ, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD, GridInfo KNIMLGOGFPA, int IGCPCEKPHCI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		ANHBAFNFHPI = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(LLGNLGENLHD)));
		MCPBHONDOLK = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EPLKICANCAL)));
		JPMFPKOEENP.Clear();
		IFHNAJLPFDF = IGCPCEKPHCI > 1;
		GDIGPFGIGPL = IGCPCEKPHCI > 1;
		KKHOIFKIGPE = IGCPCEKPHCI > 1;
		MMPKLNMBOMO = IGCPCEKPHCI > 1;
		MFMBLELHKMA = IGCPCEKPHCI > 2;
		OFIPCIEEMLG = IGCPCEKPHCI > 3;
		JOFGLBONHDC = IGCPCEKPHCI > 0;
		AGIMAAPHGDO = IGCPCEKPHCI > 3;
		if (IGCPCEKPHCI > 1)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1131f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1350f, MCPBHONDOLK.y + 906f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1926f, MCPBHONDOLK.y - 482f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1084f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 741f, MCPBHONDOLK.y + 246f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 335f, MCPBHONDOLK.y - 1362f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1638f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1736f, MCPBHONDOLK.y - 719f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 473f, MCPBHONDOLK.y - 167f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 839f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 984f, MCPBHONDOLK.y + 820f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1443f, MCPBHONDOLK.y + 73f));
		}
		if (IGCPCEKPHCI > 3)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 410f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1363f, MCPBHONDOLK.y + 1110f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1355f, MCPBHONDOLK.y - 1586f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1097f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1713f, MCPBHONDOLK.y + 986f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 713f, MCPBHONDOLK.y - 232f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1825f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 650f, MCPBHONDOLK.y - 82f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 744f, MCPBHONDOLK.y - 1914f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 841f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1581f, MCPBHONDOLK.y + 769f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1888f, MCPBHONDOLK.y + 1144f));
		}
		PlayerGridController gridController = PlayerController.GetPlayer(JIIGOACEIKL).gridController;
		gridController.ChangeGrid(IGCPCEKPHCI, IFHNAJLPFDF, GDIGPFGIGPL, MMPKLNMBOMO, KKHOIFKIGPE, MFMBLELHKMA, OFIPCIEEMLG, AGIMAAPHGDO, JOFGLBONHDC);
		gridController.FJJAPOPCKCD();
		gridController.KNBJCKLEOKJ(MEMGMDOCBOJ);
		return (Object)(object)gridController.LCPBFEOBOAL(Vector2.op_Implicit(LLGNLGENLHD)) != (Object)null;
	}

	public virtual void MAGMKFLPGKJ(int JIIGOACEIKL)
	{
	}

	public void OEABCJJMBNO(int JIIGOACEIKL)
	{
		selectedRowCount = MLKAICLMFLG().toolLevel;
	}

	public bool EJJIBBFBPAI(int JIIGOACEIKL, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return HBEBAFHEMAP(JIIGOACEIKL, item, EPLKICANCAL, LLGNLGENLHD, OELPLBOEBML(), selectedRowCount);
	}

	public bool EGOCNHNBCDC()
	{
		return LPNELFNCDMC().usesGrid;
	}

	public void PFGHKEJDPMJ(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public bool JMNCMIKEIAP(int JIIGOACEIKL, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return LDMJBJLKPKD(JIIGOACEIKL, item, EPLKICANCAL, LLGNLGENLHD, KNIMLGOGFPA, selectedRowCount);
	}

	public virtual void NFHHKCIBLDC(int JIIGOACEIKL)
	{
	}

	public void LEPKFPEMJMC(int JIIGOACEIKL)
	{
		ECCOJOMGCFA(JIIGOACEIKL);
		if (selectedRowCount < LMHDGKJIHMK().toolLevel)
		{
			selectedRowCount += 0;
		}
		else
		{
			selectedRowCount = 1;
		}
	}

	protected void PHDGPJAGMAA(int JIIGOACEIKL)
	{
		if (AAOPAIDJEAL && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			PlayerController.GetPlayer(1).characterAnimation.NCAJNNHBHJM(PKKABPMIAKB);
		}
	}

	public void MDOJJKOGMBG(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public float FHMDFFIDFAI(int JIIGOACEIKL)
	{
		return LOHBIEBPKMG;
	}

	public void HCJIFAGBKHL(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DEACEMMGPHA = IMOBLFMHKOD;
	}

	public virtual void EIFFKPDDJJC(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	protected int OCLFIAMHFAC()
	{
		return LMHDGKJIHMK().toolLevel;
	}

	public void IPDFPHOCKBE(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BIPAILENDLH = IMOBLFMHKOD;
	}

	[SpecialName]
	protected int OGCEOPDOEAB()
	{
		return OMAPDOLLKGA().toolLevel;
	}

	public virtual void IEINJIAEKDP(ToolInstance ACFLBADEHDN)
	{
		selectedRowCount = ACFLBADEHDN.selectedRowCount;
	}

	protected void MAKCDKOGBHK(int JIIGOACEIKL, Vector2 FPDGKFJIMJH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		DKKDCMABJKJ = ELJJMCCJEGH + FPDGKFJIMJH;
	}

	protected void FOPJAIJDFKP(int JIIGOACEIKL, int OKNOJJEFEBE)
	{
		KDLIFDDLPHO = OKNOJJEFEBE;
	}

	private IEnumerator BCOLIKMFEKF(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
	}

	public void NEBBLGIFMHN(int JIIGOACEIKL)
	{
		selectedRowCount = MLKAICLMFLG().toolLevel;
	}

	protected int LCNPHFHDLOM(int JIIGOACEIKL)
	{
		return KDLIFDDLPHO;
	}

	protected float CIHBHMINMFD(int JIIGOACEIKL)
	{
		return DBEFBFPAOAA;
	}

	public virtual void FHHLPOACHKK(int JIIGOACEIKL)
	{
	}

	private IEnumerator AEKIADBAAPK(int JIIGOACEIKL)
	{
		return new CCNDNGLJHFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public virtual void BDICJHGOPGO(int JIIGOACEIKL)
	{
	}

	public static bool CIMLMENGDDD(int JIIGOACEIKL, Item MEMGMDOCBOJ, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD, GridInfo KNIMLGOGFPA, int IGCPCEKPHCI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		ANHBAFNFHPI = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(LLGNLGENLHD)));
		MCPBHONDOLK = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EPLKICANCAL)));
		JPMFPKOEENP.Clear();
		IFHNAJLPFDF = IGCPCEKPHCI > 1;
		GDIGPFGIGPL = IGCPCEKPHCI > 0;
		KKHOIFKIGPE = IGCPCEKPHCI > 0;
		MMPKLNMBOMO = IGCPCEKPHCI > 1;
		MFMBLELHKMA = IGCPCEKPHCI > 0;
		OFIPCIEEMLG = IGCPCEKPHCI > 7;
		JOFGLBONHDC = IGCPCEKPHCI > 2;
		AGIMAAPHGDO = IGCPCEKPHCI > 0;
		if (IGCPCEKPHCI > 0)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1532f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 811f, MCPBHONDOLK.y + 681f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1531f, MCPBHONDOLK.y - 366f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1849f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1725f, MCPBHONDOLK.y + 1213f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1129f, MCPBHONDOLK.y - 87f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1649f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 807f, MCPBHONDOLK.y - 749f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 51f, MCPBHONDOLK.y - 569f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 579f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1688f, MCPBHONDOLK.y + 1870f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1109f, MCPBHONDOLK.y + 1554f));
		}
		if (IGCPCEKPHCI > 7)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1433f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1215f, MCPBHONDOLK.y + 575f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 762f, MCPBHONDOLK.y - 740f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1102f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 720f, MCPBHONDOLK.y + 301f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 371f, MCPBHONDOLK.y - 1683f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 280f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 355f, MCPBHONDOLK.y - 1f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 516f, MCPBHONDOLK.y - 941f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 421f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1453f, MCPBHONDOLK.y + 802f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 10f, MCPBHONDOLK.y + 286f));
		}
		PlayerGridController gridController = PlayerController.GetPlayer(JIIGOACEIKL).gridController;
		gridController.BGBKOFBJJDG(IGCPCEKPHCI, IFHNAJLPFDF, GDIGPFGIGPL, MMPKLNMBOMO, KKHOIFKIGPE, MFMBLELHKMA, OFIPCIEEMLG, AGIMAAPHGDO, JOFGLBONHDC);
		gridController.ILLFOADLKCG();
		gridController.OAPFBBKNNKO(MEMGMDOCBOJ);
		return (Object)(object)gridController.GLLEFMIDKDO(Vector2.op_Implicit(LLGNLGENLHD)) != (Object)null;
	}

	protected float GABGNOOMJJE(int JIIGOACEIKL)
	{
		return DBEFBFPAOAA;
	}

	public virtual bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HJINPCNEJCB(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BIPAILENDLH = IMOBLFMHKOD;
	}

	public virtual void HNEHLKDOAHG(ToolInstance ACFLBADEHDN)
	{
		selectedRowCount = ACFLBADEHDN.selectedRowCount;
	}

	public virtual bool MPMNMCMGLMA(int JIIGOACEIKL)
	{
		return false;
	}

	public static bool LDMJBJLKPKD(int JIIGOACEIKL, Item MEMGMDOCBOJ, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD, GridInfo KNIMLGOGFPA, int IGCPCEKPHCI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		ANHBAFNFHPI = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(LLGNLGENLHD)));
		MCPBHONDOLK = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EPLKICANCAL)));
		JPMFPKOEENP.Clear();
		IFHNAJLPFDF = IGCPCEKPHCI > 1;
		GDIGPFGIGPL = IGCPCEKPHCI > 0;
		KKHOIFKIGPE = IGCPCEKPHCI > 0;
		MMPKLNMBOMO = IGCPCEKPHCI > 1;
		MFMBLELHKMA = IGCPCEKPHCI > 4;
		OFIPCIEEMLG = IGCPCEKPHCI > 5;
		JOFGLBONHDC = IGCPCEKPHCI > 3;
		AGIMAAPHGDO = IGCPCEKPHCI > 7;
		if (IGCPCEKPHCI > 1)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1303f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 393f, MCPBHONDOLK.y + 606f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1913f, MCPBHONDOLK.y - 820f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1714f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 202f, MCPBHONDOLK.y + 774f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1221f, MCPBHONDOLK.y - 1326f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1197f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1084f, MCPBHONDOLK.y - 1294f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1784f, MCPBHONDOLK.y - 1524f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 229f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 581f, MCPBHONDOLK.y + 607f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 647f, MCPBHONDOLK.y + 536f));
		}
		if (IGCPCEKPHCI > 7)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 65f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1695f, MCPBHONDOLK.y + 233f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1991f, MCPBHONDOLK.y - 1067f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1245f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1204f, MCPBHONDOLK.y + 429f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1922f, MCPBHONDOLK.y - 492f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 40f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 280f, MCPBHONDOLK.y - 936f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 409f, MCPBHONDOLK.y - 319f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 915f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1370f, MCPBHONDOLK.y + 90f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1403f, MCPBHONDOLK.y + 1477f));
		}
		PlayerGridController gridController = PlayerController.GetPlayer(JIIGOACEIKL).gridController;
		gridController.PAMKNDDKCJH(IGCPCEKPHCI, IFHNAJLPFDF, GDIGPFGIGPL, MMPKLNMBOMO, KKHOIFKIGPE, MFMBLELHKMA, OFIPCIEEMLG, AGIMAAPHGDO, JOFGLBONHDC);
		gridController.FJJAPOPCKCD();
		gridController.LMAJPADFJLE(MEMGMDOCBOJ);
		return (Object)(object)gridController.GLLEFMIDKDO(Vector2.op_Implicit(LLGNLGENLHD)) != (Object)null;
	}

	public Vector2 HGECFPCPOHN(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DEACEMMGPHA;
	}

	public void EDOOONIKJHA(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public virtual void HPBGDNILFBP(int JIIGOACEIKL)
	{
	}

	protected void JGALICBLIHB(int JIIGOACEIKL, Direction FCGBJEIIMBC)
	{
		PKKABPMIAKB = FCGBJEIIMBC;
	}

	public Vector2 DMJBEGINKAG(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DEACEMMGPHA;
	}

	protected void HNJEDEJNPNL(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StopCoroutine(NBDLHLOJHFC);
		}
	}

	[SpecialName]
	protected GridInfo OELPLBOEBML()
	{
		return BLIKNGGCLID().gridInfo;
	}

	public virtual void LNEHCCHDJFN(int JIIGOACEIKL)
	{
	}

	public virtual void AKFMFCMPAPO(int JIIGOACEIKL)
	{
	}

	public Vector2 IMMLPHODPFK(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DEACEMMGPHA;
	}

	[SpecialName]
	protected int IFHCKFKOHOI()
	{
		return MLKAICLMFLG().toolLevel;
	}

	public void HNBJFLFGKGF(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public Vector2 ELEMCNBELCE(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BIPAILENDLH;
	}

	protected Vector2 LJJKGAICKOE(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD + 1084f * new Vector2(0f - Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)).y, Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)).x);
	}

	protected void OMNPNNPEEFL(int JIIGOACEIKL, Vector2 FPDGKFJIMJH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		DKKDCMABJKJ = ELJJMCCJEGH + FPDGKFJIMJH;
	}

	public virtual void ECCJGIHHPFJ(ToolInstance ACFLBADEHDN)
	{
		selectedRowCount = ACFLBADEHDN.selectedRowCount;
	}

	[SpecialName]
	protected GridInfo GMMFDHOFHCC()
	{
		return MLKAICLMFLG().gridInfo;
	}

	protected void DFNFNIPKEBD(int JIIGOACEIKL)
	{
		if (AAOPAIDJEAL && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			PlayerController.OPHDCMJLLEC(0).characterAnimation.NCAJNNHBHJM(PKKABPMIAKB);
		}
	}

	protected Vector2 FANPFCEDDCJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD + 1480f * new Vector2(0f - Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)).y, Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL)).x);
	}

	public void NDJLMNIJLFI(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DEACEMMGPHA = IMOBLFMHKOD;
	}

	protected void JONHEOKBPIC(int JIIGOACEIKL, int OKNOJJEFEBE)
	{
		KDLIFDDLPHO = OKNOJJEFEBE;
	}

	protected Vector2 FHIKFFPGAEG(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD + 0.5f * new Vector2(0f - Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)).y, Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)).x);
	}

	protected void PMILEJPHHIJ(int JIIGOACEIKL, Direction FCGBJEIIMBC)
	{
		PKKABPMIAKB = FCGBJEIIMBC;
	}

	protected Direction HIBLKHFCLHH(int JIIGOACEIKL)
	{
		return PKKABPMIAKB;
	}

	public void JOACJBCCCKM(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BIPAILENDLH = IMOBLFMHKOD;
	}

	public Tool MLKAICLMFLG()
	{
		return (Tool)item;
	}

	public void AGAJDKDCEHJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JHAFFFNJIJH = IMOBLFMHKOD;
	}

	public virtual void NGGLKEJGBOK(int JIIGOACEIKL)
	{
	}

	protected void MKCJJIIANJD(int JIIGOACEIKL, Vector2 FPDGKFJIMJH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		DKKDCMABJKJ = ELJJMCCJEGH + FPDGKFJIMJH;
	}

	protected void PHNPBNDPMCA(int JIIGOACEIKL, float DBEFBFPAOAA)
	{
		this.DBEFBFPAOAA = DBEFBFPAOAA;
	}

	public virtual void FNECDOKGGLM(int JIIGOACEIKL)
	{
	}

	public virtual void ActionEnd(int JIIGOACEIKL)
	{
	}

	public Vector2 INGEAJAMBGM(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BIPAILENDLH;
	}

	protected void GBPBIOAKLHI(int JIIGOACEIKL, Vector2 FPDGKFJIMJH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		DKKDCMABJKJ = ELJJMCCJEGH + FPDGKFJIMJH;
	}

	[SpecialName]
	protected int BIBBFHILPPH()
	{
		return LMHDGKJIHMK().toolLevel;
	}

	public virtual void ANAJNGFDLEO(int JIIGOACEIKL)
	{
	}

	public static bool POLFPDKFMHM(int JIIGOACEIKL, Item MEMGMDOCBOJ, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD, GridInfo KNIMLGOGFPA, int IGCPCEKPHCI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		ANHBAFNFHPI = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(LLGNLGENLHD)));
		MCPBHONDOLK = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EPLKICANCAL)));
		JPMFPKOEENP.Clear();
		IFHNAJLPFDF = IGCPCEKPHCI > 0;
		GDIGPFGIGPL = IGCPCEKPHCI > 1;
		KKHOIFKIGPE = IGCPCEKPHCI > 1;
		MMPKLNMBOMO = IGCPCEKPHCI > 1;
		MFMBLELHKMA = IGCPCEKPHCI > 5;
		OFIPCIEEMLG = IGCPCEKPHCI > 7;
		JOFGLBONHDC = IGCPCEKPHCI > 1;
		AGIMAAPHGDO = IGCPCEKPHCI > 7;
		if (IGCPCEKPHCI > 1)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 332f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 729f, MCPBHONDOLK.y + 309f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1440f, MCPBHONDOLK.y - 1822f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1412f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 140f, MCPBHONDOLK.y + 550f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1704f, MCPBHONDOLK.y - 233f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 954f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 594f, MCPBHONDOLK.y - 1133f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1050f, MCPBHONDOLK.y - 1845f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 1669f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1812f, MCPBHONDOLK.y + 1738f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 426f, MCPBHONDOLK.y + 1071f));
		}
		if (IGCPCEKPHCI > 0)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 207f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1477f, MCPBHONDOLK.y + 170f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 243f, MCPBHONDOLK.y - 1910f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1494f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1260f, MCPBHONDOLK.y + 637f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 855f, MCPBHONDOLK.y - 892f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1454f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1707f, MCPBHONDOLK.y - 144f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1478f, MCPBHONDOLK.y - 631f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 816f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1868f, MCPBHONDOLK.y + 162f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1764f, MCPBHONDOLK.y + 238f));
		}
		PlayerGridController gridController = PlayerController.GetPlayer(JIIGOACEIKL).gridController;
		gridController.BGBKOFBJJDG(IGCPCEKPHCI, IFHNAJLPFDF, GDIGPFGIGPL, MMPKLNMBOMO, KKHOIFKIGPE, MFMBLELHKMA, OFIPCIEEMLG, AGIMAAPHGDO, JOFGLBONHDC);
		gridController.FJJAPOPCKCD();
		gridController.UpdateBlueSquaresEnabled(MEMGMDOCBOJ);
		return (Object)(object)gridController.EIIBOHKPOIN(Vector2.op_Implicit(LLGNLGENLHD)) != (Object)null;
	}

	public virtual void FNLCMMOOMKP(int JIIGOACEIKL)
	{
	}

	protected void LOMHCBDFPCM(int JIIGOACEIKL, int OKNOJJEFEBE)
	{
		KDLIFDDLPHO = OKNOJJEFEBE;
	}

	protected bool EAGINEBDIGA(int JIIGOACEIKL)
	{
		return NKEPKDBENHM;
	}

	protected void EPEECLGBHMI(int JIIGOACEIKL, bool GLLNEFAPDDF = false)
	{
		if (GLLNEFAPDDF)
		{
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		}
		else
		{
			NBDLHLOJHFC = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BCOLIKMFEKF(JIIGOACEIKL));
		}
	}

	public void EFGDCGFFKFF(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	protected void AMAJBOOJNIG(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		this.NKEPKDBENHM = NKEPKDBENHM;
	}

	protected void NOCJKKFCNKG(int JIIGOACEIKL, int OKNOJJEFEBE)
	{
		KDLIFDDLPHO = OKNOJJEFEBE;
	}

	public ToolInstance(Item MEMGMDOCBOJ)
		: base(MEMGMDOCBOJ)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		HJMFDIGFOLN();
	}

	protected void HKACPJAFFGN(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StopCoroutine(NBDLHLOJHFC);
		}
	}

	protected void OOJEMLIJNHM(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StopCoroutine(NBDLHLOJHFC);
		}
	}

	protected void HCCMIIHENMP(int JIIGOACEIKL, float DBEFBFPAOAA)
	{
		this.DBEFBFPAOAA = DBEFBFPAOAA;
	}

	public virtual void LBMKLIDKHJD(int JIIGOACEIKL)
	{
	}

	public Tool JCFHHFMPMAH()
	{
		return (Tool)item;
	}

	protected void INBMIFPIKKI(int JIIGOACEIKL, bool GLLNEFAPDDF = false)
	{
		if (GLLNEFAPDDF)
		{
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		}
		else
		{
			NBDLHLOJHFC = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BCOLIKMFEKF(JIIGOACEIKL));
		}
	}

	public ToolInstance(ToolInstance ACFLBADEHDN)
		: base(ACFLBADEHDN)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		ECCJGIHHPFJ(ACFLBADEHDN);
	}

	public bool AICBOBNFOCE()
	{
		return LPNELFNCDMC().usesGrid;
	}

	protected void GJDOGKEFFHE(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		this.NKEPKDBENHM = NKEPKDBENHM;
	}

	public virtual bool BAJPJFPEHKM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public virtual void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	protected void GNKMEPDGPCB(int JIIGOACEIKL, Vector2 FPDGKFJIMJH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		DKKDCMABJKJ = ELJJMCCJEGH + FPDGKFJIMJH;
	}

	protected Vector2 NLCBPLKNGPI(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD + 1595f * new Vector2(0f - Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)).y, Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)).x);
	}

	protected void PGBKOLMPPHF(int JIIGOACEIKL)
	{
		if (NBDLHLOJHFC != null)
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(NBDLHLOJHFC);
		}
	}

	public virtual void KHBLOPADBAF(int JIIGOACEIKL)
	{
	}

	public Tool LPNELFNCDMC()
	{
		return (Tool)item;
	}

	protected void IKLOIEJLPCG(int JIIGOACEIKL)
	{
		if (AAOPAIDJEAL && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			PlayerController.OPHDCMJLLEC(1).characterAnimation.NCAJNNHBHJM(PKKABPMIAKB);
		}
	}

	protected void GAJPGNMNGFM(int JIIGOACEIKL, Direction FCGBJEIIMBC)
	{
		PKKABPMIAKB = FCGBJEIIMBC;
	}

	public Vector2 MGJICJHGOHC(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BIPAILENDLH;
	}

	protected bool NJGGMEJGKBM(int JIIGOACEIKL)
	{
		return NKEPKDBENHM;
	}

	public virtual void IOCKFAELDMD(int JIIGOACEIKL)
	{
	}

	public void APEELDIJBHM(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public void ADNJCCKCOOK()
	{
		selectedRowCount = JCFHHFMPMAH().toolLevel;
	}

	public virtual bool CHJEJJLHCGO(int JIIGOACEIKL)
	{
		return true;
	}

	public void PBIOECKEELH(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public virtual bool OLAGABMMNGM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if ((Object)(object)JCFHHFMPMAH().skin != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).toolSkinController.NHILJFBDDDF(MLKAICLMFLG().bodyPart, OMAPDOLLKGA().skin);
		}
		if (KLGOCJMGKFO)
		{
			JONHEOKBPIC(JIIGOACEIKL, 1);
		}
		return true;
	}

	public virtual void OFGFEBCCFEA(ToolInstance ACFLBADEHDN)
	{
		selectedRowCount = ACFLBADEHDN.selectedRowCount;
	}

	public virtual bool AEJJBGLKHIJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public Vector2 GFEBNOIMOGI(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DEACEMMGPHA;
	}

	public Tool OMAPDOLLKGA()
	{
		return (Tool)item;
	}

	public void DFBMDJPINNN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DEACEMMGPHA = IMOBLFMHKOD;
	}

	public virtual void JHHBCMMMIEA(int JIIGOACEIKL)
	{
	}

	public static bool JJAKDILDPPB(int JIIGOACEIKL, Item MEMGMDOCBOJ, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD, GridInfo KNIMLGOGFPA, int IGCPCEKPHCI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		ANHBAFNFHPI = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(LLGNLGENLHD)));
		MCPBHONDOLK = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EPLKICANCAL)));
		JPMFPKOEENP.Clear();
		IFHNAJLPFDF = IGCPCEKPHCI > 1;
		GDIGPFGIGPL = IGCPCEKPHCI > 1;
		KKHOIFKIGPE = IGCPCEKPHCI > 0;
		MMPKLNMBOMO = IGCPCEKPHCI > 0;
		MFMBLELHKMA = IGCPCEKPHCI > 1;
		OFIPCIEEMLG = IGCPCEKPHCI > 2;
		JOFGLBONHDC = IGCPCEKPHCI > 6;
		AGIMAAPHGDO = IGCPCEKPHCI > 6;
		if (IGCPCEKPHCI > 0)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1464f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 993f, MCPBHONDOLK.y + 1419f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 667f, MCPBHONDOLK.y - 1250f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1405f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1310f, MCPBHONDOLK.y + 354f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1759f, MCPBHONDOLK.y - 1912f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 923f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 324f, MCPBHONDOLK.y - 1869f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1792f, MCPBHONDOLK.y - 1755f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 381f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 865f, MCPBHONDOLK.y + 1015f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 662f, MCPBHONDOLK.y + 1748f));
		}
		if (IGCPCEKPHCI > 4)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1543f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 217f, MCPBHONDOLK.y + 1655f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1735f, MCPBHONDOLK.y - 804f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 205f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 959f, MCPBHONDOLK.y + 611f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1002f, MCPBHONDOLK.y - 344f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1310f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 186f, MCPBHONDOLK.y - 470f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1095f, MCPBHONDOLK.y - 18f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 388f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 712f, MCPBHONDOLK.y + 317f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 891f, MCPBHONDOLK.y + 559f));
		}
		PlayerGridController gridController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController;
		gridController.DHBENOMNDAL(IGCPCEKPHCI, IFHNAJLPFDF, GDIGPFGIGPL, MMPKLNMBOMO, KKHOIFKIGPE, MFMBLELHKMA, OFIPCIEEMLG, AGIMAAPHGDO, JOFGLBONHDC);
		gridController.PJOHKPMJLHI();
		gridController.LNCPCNGFKDK(MEMGMDOCBOJ);
		return (Object)(object)gridController.ALELPNMKLNG(Vector2.op_Implicit(LLGNLGENLHD)) != (Object)null;
	}

	[SpecialName]
	protected int LCEMDNCKAMJ()
	{
		return JCFHHFMPMAH().toolLevel;
	}

	public void CBMEOBPDDOO(int JIIGOACEIKL)
	{
		IOCKFAELDMD(JIIGOACEIKL);
		if (selectedRowCount < MLKAICLMFLG().toolLevel)
		{
			selectedRowCount++;
		}
		else
		{
			selectedRowCount = 1;
		}
	}

	public float LNKPOACDFJB(int JIIGOACEIKL)
	{
		return LOHBIEBPKMG;
	}

	protected int HCFJKBIIMIK(int JIIGOACEIKL)
	{
		return KDLIFDDLPHO;
	}

	public bool FDKEMPDCHFB()
	{
		return MLKAICLMFLG().usesGrid;
	}

	protected void OHMHPBIJJAL(int JIIGOACEIKL, Direction FCGBJEIIMBC)
	{
		PKKABPMIAKB = FCGBJEIIMBC;
	}

	public virtual void CNBEHAHIKBB(int JIIGOACEIKL)
	{
	}

	public virtual bool KIAFJBGFEBC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if ((Object)(object)LMHDGKJIHMK().skin != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).toolSkinController.GHPNNIJAIHK(BLIKNGGCLID().bodyPart, MLKAICLMFLG().skin);
		}
		if (KLGOCJMGKFO)
		{
			FOPJAIJDFKP(JIIGOACEIKL, 1);
		}
		return false;
	}

	public void HJMFDIGFOLN()
	{
		selectedRowCount = MLKAICLMFLG().toolLevel;
	}

	public void JMDOGNOHHKP()
	{
		selectedRowCount = LMHDGKJIHMK().toolLevel;
	}

	public void IFDADFBDIHF(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		LOHBIEBPKMG = LGLDPMAABLA;
	}

	public virtual void AONJJGAIDBG(int JIIGOACEIKL)
	{
	}

	public float CBJGCJNCBMO(int JIIGOACEIKL)
	{
		return LOHBIEBPKMG;
	}

	public Tool BLIKNGGCLID()
	{
		return (Tool)item;
	}

	public Vector2 NJBOCFNALEJ(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return JHAFFFNJIJH;
	}

	public static bool HBEBAFHEMAP(int JIIGOACEIKL, Item MEMGMDOCBOJ, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD, GridInfo KNIMLGOGFPA, int IGCPCEKPHCI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		ANHBAFNFHPI = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(LLGNLGENLHD)));
		MCPBHONDOLK = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EPLKICANCAL)));
		JPMFPKOEENP.Clear();
		IFHNAJLPFDF = IGCPCEKPHCI > 1;
		GDIGPFGIGPL = IGCPCEKPHCI > 1;
		KKHOIFKIGPE = IGCPCEKPHCI > 1;
		MMPKLNMBOMO = IGCPCEKPHCI > 1;
		MFMBLELHKMA = IGCPCEKPHCI > 2;
		OFIPCIEEMLG = IGCPCEKPHCI > 2;
		JOFGLBONHDC = IGCPCEKPHCI > 2;
		AGIMAAPHGDO = IGCPCEKPHCI > 2;
		if (IGCPCEKPHCI > 1)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1f, MCPBHONDOLK.y + 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1f, MCPBHONDOLK.y - 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1f, MCPBHONDOLK.y + 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1f, MCPBHONDOLK.y - 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 0.5f, MCPBHONDOLK.y - 1f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 0.5f, MCPBHONDOLK.y - 1f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 1f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 0.5f, MCPBHONDOLK.y + 1f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 0.5f, MCPBHONDOLK.y + 1f));
		}
		if (IGCPCEKPHCI > 2)
		{
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1.5f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1.5f, MCPBHONDOLK.y + 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 1.5f, MCPBHONDOLK.y - 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1.5f, MCPBHONDOLK.y));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1.5f, MCPBHONDOLK.y + 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 1.5f, MCPBHONDOLK.y - 0.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y - 1.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 0.5f, MCPBHONDOLK.y - 1.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 0.5f, MCPBHONDOLK.y - 1.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x, MCPBHONDOLK.y + 1.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x + 0.5f, MCPBHONDOLK.y + 1.5f));
			JPMFPKOEENP.Add(new Vector2(MCPBHONDOLK.x - 0.5f, MCPBHONDOLK.y + 1.5f));
		}
		PlayerGridController gridController = PlayerController.GetPlayer(JIIGOACEIKL).gridController;
		gridController.ChangeGrid(IGCPCEKPHCI, IFHNAJLPFDF, GDIGPFGIGPL, MMPKLNMBOMO, KKHOIFKIGPE, MFMBLELHKMA, OFIPCIEEMLG, AGIMAAPHGDO, JOFGLBONHDC);
		gridController.SetPositionGrid();
		gridController.UpdateBlueSquaresEnabled(MEMGMDOCBOJ);
		return (Object)(object)gridController.GetBlueSquareAtPosition(Vector2.op_Implicit(LLGNLGENLHD)) != (Object)null;
	}

	public virtual bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		return false;
	}

	protected Vector2 PLDMPLKKFFH(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DKKDCMABJKJ;
	}
}
