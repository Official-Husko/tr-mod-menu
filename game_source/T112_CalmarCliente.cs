using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T112_CalmarCliente : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ELDKFGGEFBH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T112_CalmarCliente _003C_003E4__this;

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
		public ELDKFGGEFBH(int _003C_003E1__state)
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
			T112_CalmarCliente t112_CalmarCliente = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				Utils.OFHPCBLHJBL(0f, 1f);
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (t112_CalmarCliente.AAOPIEDAKKD(2))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (Time.timeScale != 1f)
			{
				Utils.OFHPCBLHJBL(1f, 1f);
			}
			NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
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

	[CompilerGenerated]
	private sealed class JPPPCGGCDCK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T112_CalmarCliente _003C_003E4__this;

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
		public JPPPCGGCDCK(int _003C_003E1__state)
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
			T112_CalmarCliente t112_CalmarCliente = _003C_003E4__this;
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
				_003C_003E1__state = -1;
				t112_CalmarCliente.LHKIJABBBPM();
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

	[CompilerGenerated]
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T112_CalmarCliente _003C_003E4__this;

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
		public DBHBDMOHMPM(int _003C_003E1__state)
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
			T112_CalmarCliente t112_CalmarCliente = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0069;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0069;
			case 3:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", t112_CalmarCliente.triggerPlayerNum);
				goto IL_00d8;
			case 4:
				_003C_003E1__state = -1;
				goto IL_00d8;
			case 5:
				{
					_003C_003E1__state = -1;
					for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
					{
						if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
						{
							TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
							break;
						}
					}
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					if (Time.timeScale != 1f)
					{
						Utils.OFHPCBLHJBL(1f, 1f);
					}
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(t112_CalmarCliente.NCEKHDIIIGO));
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(t112_CalmarCliente.AOHOOHLIEHO));
					return false;
				}
				IL_0069:
				if (!t112_CalmarCliente.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t112_CalmarCliente).StartCoroutine(t112_CalmarCliente.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
				IL_00d8:
				if (t112_CalmarCliente.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.waitRealtime1;
				_003C_003E1__state = 5;
				return true;
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

	private void JIMKJDBDBDH()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(")", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(LDPBMCJKKKJ));
		((MonoBehaviour)this).StartCoroutine(PDJAFPNIAOO());
	}

	private void BHHFANBBGMO()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Acaba el tutorial primero", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(JLDACMFOFNJ));
		((MonoBehaviour)this).StartCoroutine(CLDMBNMPBCD());
	}

	private void ONOJPCCMOIO()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("LE_19", triggerPlayerNum, DHELBHAICMM: false, CGKNJONAKGD: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(ONOJPCCMOIO));
		((MonoBehaviour)this).StartCoroutine(BACNAONONLG());
	}

	private IEnumerator JIICBOOJNMB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JBOADLPAGHG()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("RoadBlocked/Main", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(FMCBJNJAPPM));
		((MonoBehaviour)this).StartCoroutine(CMLGHILOBDH());
	}

	private IEnumerator GMINFBNDKKG()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LEPHHOBOPAB()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NPILKAECJDN()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(IBJJAAHFIGI));
		((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
	}

	private IEnumerator PABCFPPHCLO()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHIPOAGIOJK()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void IMDMJPDBEFK()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Attack/MainEvent 8", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(GLLCOGJEBHE));
		((MonoBehaviour)this).StartCoroutine(LODIKAHHPGH());
	}

	private IEnumerator PPMPKJECPDE()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void NNGMNJBPLBP()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("\n", triggerPlayerNum);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(LDPBMCJKKKJ));
		((MonoBehaviour)this).StartCoroutine(HCMBPGPDBCB());
	}

	private void FFHPDIDBEPG()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("City/Woody/Bark/Buy", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(IIADAFFCPGC));
		((MonoBehaviour)this).StartCoroutine(FLKOCEELNDL());
	}

	private void OLEPEDOAIMO()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("plantedTrees", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(AHCLKBJADMN));
		((MonoBehaviour)this).StartCoroutine(FHHONABIAOJ());
	}

	private IEnumerator GBONEOKNNEB()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MOODFHJBNPM()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(IEDJKNHOBHE));
		((MonoBehaviour)this).StartCoroutine(BJPOAPIPEPN());
	}

	private IEnumerator NPPIHHJGGGA()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void IFOIEJIFEAC()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(PILBBDIIIDL));
		((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
	}

	private IEnumerator FDAPBNJHNJG()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GGGKNEANNMJ()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OAHIHCAGDCM()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("BanquetEvent instance is null. Make sure it is initialized before calling FinishKlaynChallenge.", triggerPlayerNum, DHELBHAICMM: false, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(JGJFBDCPAAG));
		((MonoBehaviour)this).StartCoroutine(HFAFLGBFCNI());
	}

	private IEnumerator ALLNELLCCFL()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void GKEBGACOGFJ()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(GKEBGACOGFJ));
		((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
	}

	private void ALBJFGGPBOE()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(IEDJKNHOBHE));
		((MonoBehaviour)this).StartCoroutine(OJDFLKEELHG());
	}

	private IEnumerator FOGCBBFMDHJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GKCJPNNEOEH()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Invalid playerNum", triggerPlayerNum, DHELBHAICMM: false, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(JLDACMFOFNJ));
		((MonoBehaviour)this).StartCoroutine(PHIJIADMFPM());
	}

	private IEnumerator FPIHNICAJHI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CGELHLOMBIA()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("k", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(PJHPDBHLCFK));
		((MonoBehaviour)this).StartCoroutine(LODIKAHHPGH());
	}

	private IEnumerator FBDJFDDPKDN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CMLGHILOBDH()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNHIBHFECGD()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator ELNHMAPENDB()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GDNGALENMKB()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(NPAGCKPHMAP));
		((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FLKOCEELNDL()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void HIBIMLCLOBP()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("FarmReady", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		((MonoBehaviour)this).StartCoroutine(AJBBPAAKCHN());
	}

	private void DJHNOAIOMNO()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(ACOLKDEJAOH));
		((MonoBehaviour)this).StartCoroutine(JEBLBIJIDPL());
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void HIJOBOGCNDJ()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Farm/Buzz/Main", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(JGJFBDCPAAG));
		((MonoBehaviour)this).StartCoroutine(PDJAFPNIAOO());
	}

	private IEnumerator PAONJEAFLDC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HCKCEGEOJLO()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PGGLCNBNAFB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FMCBJNJAPPM()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("UIHorizontal", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(DCEKMPCBBOI));
		((MonoBehaviour)this).StartCoroutine(FLKOCEELNDL());
	}

	private IEnumerator HEAFCDJINCN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPCBFGNHNLI()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(IFNKEDEJENH));
		((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
	}

	private IEnumerator NFKOJBMCIBI()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CIBIOLGHPJF()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHELOALDDGO()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPLMFHICMED()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(LNPKLHHAGID));
		((MonoBehaviour)this).StartCoroutine(BJPOAPIPEPN());
	}

	private IEnumerator NEOIOEDHOCL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator GABJFJLAPMK()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IFNKEDEJENH()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(HPLMFHICMED));
		((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
	}

	private IEnumerator GFBLBEEHEMJ()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BFLPDMKIGIH()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Price sell", triggerPlayerNum, DHELBHAICMM: false, CGKNJONAKGD: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(PJHPDBHLCFK));
		((MonoBehaviour)this).StartCoroutine(CGKBDAGJMON());
	}

	public override int GetID()
	{
		return 112;
	}

	private IEnumerator GLBHLKLKMNN()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void OFIOPJADBLO()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(" (", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(AJGNFEFHBFL));
		((MonoBehaviour)this).StartCoroutine(DMGPLGHAOEG());
	}

	private IEnumerator DIKOFPFKCOB()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator HCMBPGPDBCB()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void GLLCOGJEBHE()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Perks/playerPerk_name_", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(AHCLKBJADMN));
		((MonoBehaviour)this).StartCoroutine(KPIDLFDBENP());
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IEDJKNHOBHE()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(IEDJKNHOBHE));
		((MonoBehaviour)this).StartCoroutine(NFKOJBMCIBI());
	}

	private IEnumerator JDEDKABEHJM()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator AJBBPAAKCHN()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OJDFLKEELHG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void AHCLKBJADMN()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("stop weather", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(DMLOINLPAIB));
		((MonoBehaviour)this).StartCoroutine(FHHONABIAOJ());
	}

	private void PBJBFGJMCMN()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(LNPKLHHAGID));
		((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
	}

	private void EFMKLDJIAON()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(DAJFIIFHIMK));
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private IEnumerator NBONAPPPLMN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator MJKLEEHELIH()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DAJFIIFHIMK()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(GKEBGACOGFJ));
		((MonoBehaviour)this).StartCoroutine(GBONEOKNNEB());
	}

	private IEnumerator DMGPLGHAOEG()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PDJAFPNIAOO()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IBJJAAHFIGI()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(IDOGCJEONNL));
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private void ACOLKDEJAOH()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(PBJBFGJMCMN));
		((MonoBehaviour)this).StartCoroutine(CIBIOLGHPJF());
	}

	private IEnumerator HFAFLGBFCNI()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JNOOAENGMHL()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EKMOJHNJOCG()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void DAHJCCPNMGB()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(AOHOOHLIEHO));
		((MonoBehaviour)this).StartCoroutine(NFKOJBMCIBI());
	}

	private IEnumerator NCHPMDFONEL()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator ONEHLMDPDPM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NPAGCKPHMAP()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(DAHJCCPNMGB));
		((MonoBehaviour)this).StartCoroutine(JEBLBIJIDPL());
	}

	private IEnumerator NAMHCGEICNE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CBNJMAKPBAA()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator CAKPGBAIIPI()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PILBBDIIIDL()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(LNPKLHHAGID));
		((MonoBehaviour)this).StartCoroutine(JNOOAENGMHL());
	}

	private void GBGBJMPLIAJ()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(ADMNGPDPCMB));
		((MonoBehaviour)this).StartCoroutine(FOGCBBFMDHJ());
	}

	private void IBNGFLMILAM()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Player", triggerPlayerNum);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(ONOJPCCMOIO));
		((MonoBehaviour)this).StartCoroutine(CMLGHILOBDH());
	}

	private void JLDACMFOFNJ()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("ReceiveRestartChallenge", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(DCEKMPCBBOI));
		((MonoBehaviour)this).StartCoroutine(HNHIBHFECGD());
	}

	private IEnumerator KPIDLFDBENP()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator CKPACONJNOC()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void AOHOOHLIEHO()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(AOHOOHLIEHO));
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LODIKAHHPGH()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void AJGNFEFHBFL()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("DecorationTile_24", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(DAEHOOLLFDJ));
		((MonoBehaviour)this).StartCoroutine(KKDKGPCKGNF());
	}

	private void JGJFBDCPAAG()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Recipe in hole: ", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(JIMKJDBDBDH));
		((MonoBehaviour)this).StartCoroutine(LODIKAHHPGH());
	}

	private IEnumerator ADFMBGJOMKK()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator AOGGKPMBLBK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LMFOGLKKIJP()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(DAHJCCPNMGB));
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void GDODLDHKEHA()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(IBJJAAHFIGI));
		((MonoBehaviour)this).StartCoroutine(JNOOAENGMHL());
	}

	private IEnumerator PBPKJEAAGFE()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void ALCPLEIOIKB()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Body_Up", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(AJGNFEFHBFL));
		((MonoBehaviour)this).StartCoroutine(HCMBPGPDBCB());
	}

	private IEnumerator LFANGJJGBFG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void IJPDLKNDIMA()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(GDNGALENMKB));
		((MonoBehaviour)this).StartCoroutine(CBNJMAKPBAA());
	}

	private IEnumerator OCCLCKFAILK()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GKCBDIHPGCE()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void PGHOAKPKIHE()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Dog", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(PGHOAKPKIHE));
		((MonoBehaviour)this).StartCoroutine(PABCFPPHCLO());
	}

	private void DAEHOOLLFDJ()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Idle", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(HIBIMLCLOBP));
		((MonoBehaviour)this).StartCoroutine(AJBBPAAKCHN());
	}

	private void ADMNGPDPCMB()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(MOODFHJBNPM));
		((MonoBehaviour)this).StartCoroutine(JEBLBIJIDPL());
	}

	private IEnumerator NDFMAMKPANE()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator GPJBJOLLDII()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDCMANLMBDB()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator CLDMBNMPBCD()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JCCOIPDDMDM()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Player/Bark/Tutorial/T100", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(OLEPEDOAIMO));
		((MonoBehaviour)this).StartCoroutine(NPPIHHJGGGA());
	}

	private IEnumerator FAPDHBILIID()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator JAKPMNEGELN()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GKDFHMFNDBL()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(LMFOGLKKIJP));
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private void LNPKLHHAGID()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(PILBBDIIIDL));
		((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
	}

	private void CNJKKMHMDDO()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("On Simple Event ", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(IBNGFLMILAM));
		((MonoBehaviour)this).StartCoroutine(AJBBPAAKCHN());
	}

	private IEnumerator LKEFOLEFCPI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator KKDKGPCKGNF()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void DMLOINLPAIB()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Satisfaction", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(JIMKJDBDBDH));
		((MonoBehaviour)this).StartCoroutine(HNHIBHFECGD());
	}

	private IEnumerator CFCMKAPFPCE()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FHHONABIAOJ()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LDPBMCJKKKJ()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Treasure Open!", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(OAHIHCAGDCM));
		((MonoBehaviour)this).StartCoroutine(GPJBJOLLDII());
	}

	private void OMFCFMFOJBP()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("ReceiveKick", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(AHCLKBJADMN));
		((MonoBehaviour)this).StartCoroutine(FHHONABIAOJ());
	}

	private IEnumerator CGKBDAGJMON()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGEOMOOKOEP()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private IEnumerator AELFLHCNMBB()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BBGHMMLBAME()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		for (int i = 0; i < TavernSeatingManager.GAGEINOKNAK.Length; i++)
		{
			if ((Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier != (Object)null && (Object)(object)TavernSeatingManager.GAGEINOKNAK[i].occupier.customer != (Object)null && TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.customerState == CustomerState.EatingAtTable)
			{
				TavernSeatingManager.GAGEINOKNAK[i].occupier.customer.CustomerRowdy();
				break;
			}
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Combine(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCustomerIsHit = (Action)Delegate.Combine(instance2.OnCustomerIsHit, new Action(AOHOOHLIEHO));
	}

	private void KKNLDFFKPII()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(GBGBJMPLIAJ));
		((MonoBehaviour)this).StartCoroutine(OCCLCKFAILK());
	}

	private IEnumerator NHCLFALMCGN()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator PHIJIADMFPM()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		Utils.OFHPCBLHJBL(0f, 1f);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		if (Time.timeScale != 1f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator HHLKPNANHKK()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BJPOAPIPEPN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IOOGNPHDILD()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JEBLBIJIDPL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void NCEKHDIIIGO()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T112/Dialogue2", triggerPlayerNum);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(NCEKHDIIIGO));
		((MonoBehaviour)this).StartCoroutine(KKDKGPCKGNF());
	}

	private void PJHPDBHLCFK()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("New player entered the room: ", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(MJFDJMELLLI));
		((MonoBehaviour)this).StartCoroutine(KPIDLFDBENP());
	}

	private IEnumerator KMOGEGDEDPC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DCEKMPCBBOI()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("", triggerPlayerNum, DHELBHAICMM: false, CGKNJONAKGD: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(PJHPDBHLCFK));
		((MonoBehaviour)this).StartCoroutine(FHHONABIAOJ());
	}

	private void HGBPDNMIOBK()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("MainProgress", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerBecomeNuisance = (Action)Delegate.Remove(instance.OnCustomerBecomeNuisance, new Action(JBOADLPAGHG));
		((MonoBehaviour)this).StartCoroutine(GMINFBNDKKG());
	}

	private void IJBDAKNNIHE()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Interact", triggerPlayerNum);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(GKCJPNNEOEH));
		((MonoBehaviour)this).StartCoroutine(FHHONABIAOJ());
	}

	private void IIADAFFCPGC()
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("EditorAction_6", triggerPlayerNum, DHELBHAICMM: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(JBOADLPAGHG));
		((MonoBehaviour)this).StartCoroutine(DMGPLGHAOEG());
	}

	private void LLJGMNAAAIK()
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCustomerIsHit = (Action)Delegate.Remove(instance.OnCustomerIsHit, new Action(IEDJKNHOBHE));
		((MonoBehaviour)this).StartCoroutine(OJDFLKEELHG());
	}

	private IEnumerator NBOCOLCBOIL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BACNAONONLG()
	{
		return new ELDKFGGEFBH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MJFDJMELLLI()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Income", triggerPlayerNum, DHELBHAICMM: true, CGKNJONAKGD: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerBecomeNuisance = (Action)Delegate.Remove(commonReferences.OnCustomerBecomeNuisance, new Action(FMCBJNJAPPM));
		((MonoBehaviour)this).StartCoroutine(HNHIBHFECGD());
	}

	private void IDOGCJEONNL()
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnCustomerIsHit = (Action)Delegate.Remove(commonReferences.OnCustomerIsHit, new Action(IFNKEDEJENH));
		((MonoBehaviour)this).StartCoroutine(CIBIOLGHPJF());
	}
}
