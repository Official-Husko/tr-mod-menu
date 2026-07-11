using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChickenGoHome : AnimalStateBase
{
	[CompilerGenerated]
	private sealed class JHNJFDLNBNN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChickenGoHome _003C_003E4__this;

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
		public JHNJFDLNBNN(int _003C_003E1__state)
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
			ChickenGoHome chickenGoHome = _003C_003E4__this;
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
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (!chickenGoHome.animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			chickenGoHome.animalNpc.FFHHEGALBKO.walking = true;
			chickenGoHome.animalNpc.waitToWalkCoroutine = null;
			chickenGoHome.DKFOJDHBGEJ();
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

	private bool walkingDone;

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)animalNpc != (Object)null)
		{
			animalNpc.FFHHEGALBKO.walking = false;
		}
	}

	private void LHEHNNJGINH()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void HEEOHKBPMAI()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	private void INACOMEAINH()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	private void BKKEBAFPNIA()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void MFELPPLNNIN()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AGLDNOHPHFD));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BKKEBAFPNIA));
		animalNpc.walkTo.EHDKLBLKBEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void EBLFKBEMCKL()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	public void FDCJHADGFBO()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(KCOKIFODCJM());
	}

	public void KIJAKOKLKDM()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(DGFHNNDJBPJ());
	}

	private void KLMENKODJNG()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void FLMGBOAGFMO()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(NEAKIEFOIOG());
	}

	public void FIMIBFLFOGE()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.JDHMPOJKOLF(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EJPFGEHOKPK));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LHEHNNJGINH));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void CNJMNBAKEEK()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	public void HALAFIHDIAN()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(JMAEEDKCLLJ());
	}

	public void AFNCHPDGEGJ()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(DGFHNNDJBPJ());
	}

	private IEnumerator KOOAINCPIFG()
	{
		return new JHNJFDLNBNN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKDBFNCODIK()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void GLKLGFBAOCC()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(INACOMEAINH));
		animalNpc.walkTo.EHDKLBLKBEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: true);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: true);
		}
	}

	private IEnumerator NEAKIEFOIOG()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void IHEHHCLJFDK()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	private void KJMDNKCJFEF()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void AGLOLKAIAMG()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	private void PBMBOPDALGD()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void DAOFIMMNEKO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHEHHCLJFDK));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LHEHNNJGINH));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void OMCOMDBHHJG()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(NEAKIEFOIOG());
	}

	public override void PPMIHMFFCEC()
	{
		base.PPMIHMFFCEC();
		if (!walkingDone && animalNpc.walkTo.IIMEFNIECLI())
		{
			walkingDone = true;
		}
	}

	private void ALBMMJPBAGA()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	private IEnumerator DGFHNNDJBPJ()
	{
		return new JHNJFDLNBNN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPBLPFDOBGD()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	private void FOBPMBDMGBL()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	private IEnumerator KCOKIFODCJM()
	{
		return new JHNJFDLNBNN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PDOBHPLPKHG()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: true);
	}

	private void ACOJHBFFFIF()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void DKFOJDHBGEJ()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position));
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	private IEnumerator FHJLOBMOICG()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void FKBOPOMCLBF()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void IKOIKCHBBNG()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		((Component)animalNpc).gameObject.SetActive(true);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: true);
	}

	private IEnumerator JMAEEDKCLLJ()
	{
		return new JHNJFDLNBNN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CAKIFDOCNKO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position));
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ALBMMJPBAGA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: true);
		}
	}

	public void CLOEFOFKDFC()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		((Component)animalNpc).gameObject.SetActive(true);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: true);
	}

	public void ALDAHNKKOGE()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(true);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	public void ICPNACCECDA()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(PNMHHEMBMCC());
	}

	public void HBPGCEKNHOH()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.JJDCANFBFMK(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FKBOPOMCLBF));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: true);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void BCNCEGDFJHO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EBLFKBEMCKL));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PPBLPFDOBGD));
		animalNpc.walkTo.EHDKLBLKBEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	private void OFEMFGCBLBH()
	{
		animalNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void AJDJBEMILKL()
	{
		if (animalNpc.waitToWalkCoroutine != null)
		{
			((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
		}
		animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(NEAKIEFOIOG());
	}

	public void IGDKBGMCIOE()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.GINPKMBGOFN(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position));
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BKKEBAFPNIA));
		animalNpc.walkTo.EHDKLBLKBEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: true);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: true);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		walkingDone = false;
		FLMGBOAGFMO();
	}

	public void EJPFGEHOKPK()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(true);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}

	public void FNKLJJOGABD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.JJDCANFBFMK(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AGLDNOHPHFD));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KLMENKODJNG));
		animalNpc.walkTo.EHDKLBLKBEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: true);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	private IEnumerator PNMHHEMBMCC()
	{
		return new JHNJFDLNBNN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HKIEDFHDAJD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.KBEENHPEOAB(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position));
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AGLDNOHPHFD));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		animalNpc.walkTo.NOFKEMGPFEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void OGBEGBJDNKJ()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: true);
	}

	private IEnumerator CAPCBHEBBII()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void JEJGIAPPCLG()
	{
		animalNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(AnimalStateBase.p_Walk);
		}
	}

	public void DHGFHNALOAH()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position));
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HEEOHKBPMAI));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PPBLPFDOBGD));
		animalNpc.walkTo.NOFKEMGPFEO();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void GOEHKDDOGBP()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkTo.JDHMPOJKOLF(Vector2.op_Implicit((animalNpc.currentBuilding as HenHouse).entrancePosition.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNJMNBAKEEK));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ALBMMJPBAGA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Dead, EGFGNGJGBOP: false);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Dead, AODONKKHPBP: false);
		}
	}

	public void AGLDNOHPHFD()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		((Component)animalNpc).gameObject.SetActive(false);
		WorldGrid.OCMBMAPHGDC(animalNpc.requestInfo.currentNodes, GAKNPAMHAFB: false);
	}
}
