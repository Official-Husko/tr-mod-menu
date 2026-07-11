using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T103_MesasYBancos : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class BGBGBBECCHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T103_MesasYBancos _003C_003E4__this;

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
		public BGBGBBECCHB(int _003C_003E1__state)
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
			T103_MesasYBancos t103_MesasYBancos = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(t103_MesasYBancos.FAAHFMEDIBK));
				if ((Object)(object)t103_MesasYBancos.JELIKOFDONK != (Object)null)
				{
					Object.Destroy((Object)(object)t103_MesasYBancos.JELIKOFDONK);
				}
				if ((Object)(object)t103_MesasYBancos.LJEJMMAEKJF != (Object)null)
				{
					Object.Destroy((Object)(object)t103_MesasYBancos.LJEJMMAEKJF);
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				t103_MesasYBancos.LHKIJABBBPM();
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

		public T103_MesasYBancos _003C_003E4__this;

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
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T103_MesasYBancos t103_MesasYBancos = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				t103_MesasYBancos.ResetMai();
				_003C_003E2__current = ((MonoBehaviour)t103_MesasYBancos).StartCoroutine(t103_MesasYBancos.CDICFNAMCEE());
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t103_MesasYBancos).StartCoroutine(t103_MesasYBancos.CCIOMPBMJMD());
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t103_MesasYBancos.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", t103_MesasYBancos.triggerPlayerNum);
				goto IL_010f;
			case 4:
				_003C_003E1__state = -1;
				goto IL_010f;
			case 5:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.ShowPopUp();
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref t103_MesasYBancos.JELIKOFDONK);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref t103_MesasYBancos.LJEJMMAEKJF);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(t103_MesasYBancos.FAAHFMEDIBK));
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(t103_MesasYBancos.ENNCOPANKND));
					return false;
				}
				IL_010f:
				if (t103_MesasYBancos.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
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

	private void AICCLMLJAAJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator OOBEJHHFIAN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void PPKLCCEHKCJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void KGKEPINLJEK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.GetAllTavernSeats();
		if (TavernSeatingManager.CDDAKMKNJLP().Length >= 3)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(LJJNDMMHOGL));
			((MonoBehaviour)this).StartCoroutine(JCKBLHHGOHC());
		}
	}

	private void NFJCODJAKNO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.HJPHJCCCJMH();
		if (TavernSeatingManager.IGNOOODLMDG().Length >= 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(NFJCODJAKNO));
			((MonoBehaviour)this).StartCoroutine(LNFHFIMPNHD());
		}
	}

	private void KCDFMCDKEJH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.MOPMFKFEAKH();
		if (TavernSeatingManager.MFJNPDIKNBA().Length >= 7)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(LPGCKAHDMNP));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void BLNPLNKFEAA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.MOPMFKFEAKH();
		if (TavernSeatingManager.IGNOOODLMDG().Length >= 4)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(ODHDNLPOMGG));
			((MonoBehaviour)this).StartCoroutine(FBHLJKDLPOB());
		}
	}

	private void BMBODMEDEEN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void JMAJMINCIGG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator OCHEOJEEFGA()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGEOMOOKOEP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OBJGHDLJICE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator JDEDKABEHJM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private IEnumerator MDFFFPLNDAP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LJJNDMMHOGL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.MOPMFKFEAKH();
		if (TavernSeatingManager.IGNOOODLMDG().Length >= 7)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(HMBMLGJEDCE));
			((MonoBehaviour)this).StartCoroutine(JCKBLHHGOHC());
		}
	}

	private IEnumerator EKMOJHNJOCG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOGKJFJEHFO()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator NLCIHJDPGFE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GLLMLANGBOJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DNAAOCABLNF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GEGPIAPKEBP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ODILJEKMFLO()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AGFLJLODJJK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BMNOCHGLGBF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.JELKEBBHJDJ();
		if (TavernSeatingManager.JJAAMOOGKCA().Length >= 6)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(DDHNFONMJJI));
			((MonoBehaviour)this).StartCoroutine(JCKBLHHGOHC());
		}
	}

	private IEnumerator LNFHFIMPNHD()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FAAHFMEDIBK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void NHCJEIGMNCP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.JELKEBBHJDJ();
		if (TavernSeatingManager.MFJNPDIKNBA().Length >= 4)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CFPGKLFLMGO));
			((MonoBehaviour)this).StartCoroutine(HGKFAONPGGB());
		}
	}

	private IEnumerator JLDPBKAEOJH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void BDJKBODPECE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.EFLFMEMNICA();
		if (TavernSeatingManager.OHPLFLNLGPD().Length >= 1)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
			((MonoBehaviour)this).StartCoroutine(NFKOJBMCIBI());
		}
	}

	private void IBHPMAHOAFC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.HLECFKADPHG();
		if (TavernSeatingManager.CBBAMFFKOGF().Length >= 2)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(BDJKBODPECE));
			((MonoBehaviour)this).StartCoroutine(LNFHFIMPNHD());
		}
	}

	private void PINOBHAOFHA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator CLCOEDFCDPK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void ECEGFJJBDHI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void OIKMOFAJCFG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.EFLFMEMNICA();
		if (TavernSeatingManager.OHPLFLNLGPD().Length >= 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(NHCJEIGMNCP));
			((MonoBehaviour)this).StartCoroutine(OOBEJHHFIAN());
		}
	}

	private IEnumerator MPJMCMIMHFC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void ENNCOPANKND(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.GetAllTavernSeats();
		if (TavernSeatingManager.FindAvailableSeats().Length >= 6)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator EMOIGJHIMIF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void OOJAFBLBEIP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void KOAEPAJKIEG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator NHPCNDODFAK()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FBPHDIGFFOB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator EGAGPFBFKIL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private IEnumerator NPCCKFEDCHI()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private void BNLEKOOJLKC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.MOPMFKFEAKH();
		if (TavernSeatingManager.IGNOOODLMDG().Length >= 5)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(BNLEKOOJLKC));
			((MonoBehaviour)this).StartCoroutine(GHMAHJJPJCD());
		}
	}

	private void MACBBNKIAMK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator GHMAHJJPJCD()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void JGIIGJANANM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.LMBFJBEACKL();
		if (TavernSeatingManager.OBHGDHFPDCO().Length >= 8)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CFPGKLFLMGO));
			((MonoBehaviour)this).StartCoroutine(HCKDBDMBMFL());
		}
	}

	private void KGIMAGFGKOA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.MOPMFKFEAKH();
		if (TavernSeatingManager.CDDAKMKNJLP().Length >= 4)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(BNLEKOOJLKC));
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
		}
	}

	private void ODHDNLPOMGG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.EFLFMEMNICA();
		if (TavernSeatingManager.FindAvailableSeats().Length >= 4)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(NFJCODJAKNO));
			((MonoBehaviour)this).StartCoroutine(EFKIBEABCPK());
		}
	}

	private void FOBBBEGJNCH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator NFKOJBMCIBI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GJKJBAMJFOJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void IADKJNEOFAP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void NDLGFKCAAIE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.EFLFMEMNICA();
		if (TavernSeatingManager.JJAAMOOGKCA().Length >= 6)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(DDHNFONMJJI));
			((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
		}
	}

	private IEnumerator AFHGHLOCAPA()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator FEEJKJJEEPO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JBBPOCHHHND()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private void GBGNENEJBNP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator LNNCIOJHJMK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MEGKLKNBNEL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private void MJINOFMAHGK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator IGFOJFFHNJF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EFKIBEABCPK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JCKBLHHGOHC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void BIBLIEJPCDL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.GetAllTavernSeats();
		if (TavernSeatingManager.CDDAKMKNJLP().Length >= 6)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(KGIMAGFGKOA));
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
		}
	}

	private void DDHNFONMJJI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.JELKEBBHJDJ();
		if (TavernSeatingManager.CBBAMFFKOGF().Length >= 6)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(BMNOCHGLGBF));
			((MonoBehaviour)this).StartCoroutine(JOBFBHOMJNC());
		}
	}

	private IEnumerator OFOLEPNOONG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HGKFAONPGGB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator MJKLEEHELIH()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCALBKDNAJH()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private IEnumerator OCCLCKFAILK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator FBHLJKDLPOB()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JOBFBHOMJNC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void HMBMLGJEDCE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.HLECFKADPHG();
		if (TavernSeatingManager.CDDAKMKNJLP().Length >= 6)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(NHCJEIGMNCP));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private IEnumerator GGACDGHOJEF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ELNHMAPENDB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DEBEJLPFFOF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private void PPBPOGGIJDA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.LMBFJBEACKL();
		if (TavernSeatingManager.CDDAKMKNJLP().Length >= 4)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(LPGCKAHDMNP));
			((MonoBehaviour)this).StartCoroutine(JOBFBHOMJNC());
		}
	}

	private IEnumerator IHBNOLLFNPA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MBFNACPCKMF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[0].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[1].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator FHCNAFEMIGK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MLAOLHNEEJC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CMMJDBDKAEO()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	public override int GetID()
	{
		return 103;
	}

	private void OECMIDKCPOA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)SceneReferences.instance.sitables[1].seats[1].placeable == (Object)(object)EAPCLAODGAE)
		{
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
		else if ((Object)(object)SceneReferences.instance.sitables[0].seats[0].placeable == (Object)(object)EAPCLAODGAE && (Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private void LPGCKAHDMNP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.LMBFJBEACKL();
		if (TavernSeatingManager.FindAvailableSeats().Length >= 7)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(ODHDNLPOMGG));
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
		}
	}

	private IEnumerator DIGIMPCLCCL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}

	private IEnumerator HCKDBDMBMFL()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJJPECIKMJN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AELFLHCNMBB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		if ((Object)(object)LJEJMMAEKJF != (Object)null)
		{
			Object.Destroy((Object)(object)LJEJMMAEKJF);
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ADFMBGJOMKK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFPGKLFLMGO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		TavernSeatingManager.GetAllTavernSeats();
		if (TavernSeatingManager.OBHGDHFPDCO().Length >= 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(BDJKBODPECE));
			((MonoBehaviour)this).StartCoroutine(OFOLEPNOONG());
		}
	}

	private IEnumerator NKOJNIDHGBJ()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CIBIOLGHPJF()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CNPIAJBODCG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		ResetMai();
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T103/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[0]).transform.position), Vector2.down * 0.7f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.sitables[1]).transform.position), Vector2.down * 0.7f, ref LJEJMMAEKJF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FAAHFMEDIBK));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(ENNCOPANKND));
	}
}
