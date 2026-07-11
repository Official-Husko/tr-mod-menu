using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaiterWaiting : WaiterBaseState
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public WaiterWaiting _003C_003E4__this;

		public Direction direction;

		public Animator animator;

		internal void MCGGOAKFPLO()
		{
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}

		internal void CCMNDPOJOEB()
		{
			_003C_003E4__this.waiter.characterAnimation.LookDirection(direction);
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		}
	}

	private Vector3 AIHFBFFCCDJ(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 GCMNBPIKGDC(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, false);
		waiter.waiterState = WaiterState.Waiting;
		waiter.tableServing = null;
		if (waiter.StartTask())
		{
			return;
		}
		Direction direction;
		Vector3 val = OAFLLOKNPCA(out direction);
		if (val != ((Component)waiter).transform.position)
		{
			waiter.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(val));
			NPCWalkTo walkTo = waiter.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				waiter.characterAnimation.LookDirection(direction);
				CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			});
			NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
			waiter.OEONGPFALKH.PEHELKCIECB();
		}
		else
		{
			waiter.characterAnimation.LookDirection(direction);
		}
	}

	private Vector3 HMHBPGIGHIH(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.FGFMHMFHCOA().position;
	}

	private Vector3 KFNEIADFACJ(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 BOIKJBFNAMH(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.FGFMHMFHCOA().position;
	}

	private Vector3 JOJCLKAKJOI(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 HHGJFPMMEIL(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 LACKNLOKDOI(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 NPDKEDPFBGH(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 KJMAPLMFPOL(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	private Vector3 EDPJHKIHCFP(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 JMHKLENCGIA(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		waiter.OEONGPFALKH.IIMEFNIECLI();
	}

	private Vector3 LKGNCKMHHDA(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	private Vector3 KALNBLBHHLL(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 BJDJDNLOBKK(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.FGFMHMFHCOA().position;
	}

	private Vector3 CPMFJKGPBHM(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 FMJBCPBLDOO(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 MLEKDHEMGEK(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 CBHAJIPDIKC(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 EGLBCFLCFLI(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	private Vector3 LHLDMOOOCEO(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 OKFDAODFOLD(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.FGFMHMFHCOA().position;
	}

	private Vector3 AAIBOCOMALK(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 MGEEFIKDBMD(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.FGFMHMFHCOA().position;
	}

	private Vector3 DDDBAGKPAOH(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	private Vector3 KODMBMOEAKE(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.PMEAJJDDMIH().position;
	}

	private Vector3 AMJHCAHHLLH(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	private Vector3 OOMIJKKJNKH(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.FGFMHMFHCOA().position;
	}

	private Vector3 LPFMPPILDPC(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 FKJDNAFABKF(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.StartTask();
	}

	private Vector3 MNIAFNGIDHF(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 FOINDLNFKAB(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 KIJADBJHONM(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.BHCKGEAJBAB().position;
	}

	private Vector3 BADNOKBLGKD(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 OAFLLOKNPCA(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}

	private Vector3 COMNFDDJDPP(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.DCGEGFPGJJK().position;
	}

	private Vector3 BABECFMLJDD(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.PMEAJJDDMIH().position;
	}

	private Vector3 OLBGKBEHGLK(out Direction FCGBJEIIMBC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		return Bar.instance.IJMLIFLNOJJ.position;
	}
}
