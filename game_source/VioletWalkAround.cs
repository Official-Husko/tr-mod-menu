using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VioletWalkAround : VioletStateBase
{
	[CompilerGenerated]
	private sealed class AJFNOLGGMID : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VioletWalkAround _003C_003E4__this;

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
		public AJFNOLGGMID(int _003C_003E1__state)
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
			VioletWalkAround violetWalkAround = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				violetWalkAround.violetNpc.waitToWalkCoroutine = null;
				violetWalkAround.DKFOJDHBGEJ();
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

	private bool walkingDone;

	private float nextWalk;

	private float waitingToWalkTime;

	public void CBKOCKLJMGF()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(OIDBJNAJCKK());
	}

	public void MMPGIKGMFMA()
	{
	}

	public void PGLDICAKJLN()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JJHFFLDAHCJ());
	}

	private IEnumerator KOOAINCPIFG()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void FDCJHADGFBO()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(KCOKIFODCJM());
	}

	private void BHKLMNJGLFN()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("└── ");
		}
	}

	public void NIKMCNDMJAF()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(ACJGHCBGGLD());
	}

	private void HEADJCFMKIP()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Already learnt!");
		}
	}

	private void CMELEOKAEHO()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Dialogue System/Conversation/BirdPositiveComments/Entry/4/Dialogue Text");
		}
	}

	public void IEJGDOPLBLB()
	{
	}

	private void LHEHNNJGINH()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Coster");
		}
	}

	private IEnumerator PNMHHEMBMCC()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void ALDAHNKKOGE()
	{
	}

	public void HEHJFLPEOLF()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(KOOAINCPIFG());
	}

	private void JMBOINMJEGI()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("???");
		}
	}

	private void INACOMEAINH()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(">");
		}
	}

	private IEnumerator NEAKIEFOIOG()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator JMAEEDKCLLJ()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void NOIHDAOBMFO()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JJHFFLDAHCJ());
	}

	private IEnumerator JJHFFLDAHCJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FOBPMBDMGBL()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("");
		}
	}

	public void BONBGPOPAGK()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(OLCKJFJADGM());
	}

	private IEnumerator CGIMCLLGKDB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CLOEFOFKDFC()
	{
	}

	private void PBMBOPDALGD()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" ");
		}
	}

	public void KEDBLNJIIGF()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JGHCKOGDMCB());
	}

	public void CDICGBJOBAP()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(KOOAINCPIFG());
	}

	public void CMGILNMGOMO()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(KOOAINCPIFG());
	}

	public void EIAMODMOLIL()
	{
	}

	private void KJMDNKCJFEF()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Players lose...");
		}
	}

	private IEnumerator KCOKIFODCJM()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void EBBAPFKABDB()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ReceiveHoeActionMaster");
		}
	}

	public void EGNKMKHDKHJ()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JJHFFLDAHCJ());
	}

	public void PKCODIDOBJO()
	{
	}

	private void KKDJEKACAIE()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("xpModDescFarming");
		}
	}

	public void LJGMDKAHDLF()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JMAEEDKCLLJ());
	}

	public void KNIBOAEFGPJ()
	{
	}

	private void NAKLGHHDBAN()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("LE_10");
		}
	}

	private IEnumerator OLCKJFJADGM()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JDOEBJBAINP()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JJHFFLDAHCJ());
	}

	public void AFNCHPDGEGJ()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JGHCKOGDMCB());
	}

	private IEnumerator JGHCKOGDMCB()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public override void NDMAAEFLPEL()
	{
		if (!walkingDone && violetNpc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.time + Random.Range(5f, 15f);
			walkingDone = true;
		}
		if (walkingDone && Time.time > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	public void ICPNACCECDA()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(KOOAINCPIFG());
	}

	public void CNJMNBAKEEK()
	{
	}

	private void KPNKHMHMBOF()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" to actorNumber ");
		}
	}

	public void DJNOFCBINHM()
	{
	}

	public void PDOBHPLPKHG()
	{
	}

	public void HGGNGLIKDAH()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JGHCKOGDMCB());
	}

	public void BEEDFJOOPAH()
	{
	}

	private void FKBOPOMCLBF()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("PlayerInBed");
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		walkingDone = false;
		nextWalk = Time.time + Random.Range(5f, 15f);
		FLMGBOAGFMO();
	}

	private IEnumerator ACJGHCBGGLD()
	{
		yield return CommonReferences.wait05;
		violetNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void ACOJHBFFFIF()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Walk");
		}
	}

	private IEnumerator CAKBILBNHGN()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)violetNpc).transform.position);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.minDistance = 5;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		violetNpc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)violetNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(5f, 5f)));
		violetNpc.walkTo.speed = violetNpc.speed;
		violetNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = violetNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = violetNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		violetNpc.walkTo.PEHELKCIECB();
	}

	public void HACNKBFKNHH()
	{
	}

	public void FLMGBOAGFMO()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(NEAKIEFOIOG());
	}

	private void GONBDDJHANF()
	{
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Wing");
		}
	}

	public void GOPIJNFDCME()
	{
	}

	public void KBCKFDDDEGE()
	{
	}

	public void NHCAPCCBNAL()
	{
	}

	private IEnumerator OIDBJNAJCKK()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HALAFIHDIAN()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(PNMHHEMBMCC());
	}

	public void DMMJODJMGEG()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(ACJGHCBGGLD());
	}

	public void EKELNAHGOMK()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(CGIMCLLGKDB());
	}

	public void NCHDNBKBIKD()
	{
		if (violetNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)violetNpc).StopCoroutine(violetNpc.waitToWalkCoroutine);
		}
		violetNpc.waitToWalkCoroutine = ((MonoBehaviour)violetNpc).StartCoroutine(JGHCKOGDMCB());
	}
}
