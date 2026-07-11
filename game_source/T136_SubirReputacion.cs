using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T136_SubirReputacion : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T136_SubirReputacion _003C_003E4__this;

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
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T136_SubirReputacion t136_SubirReputacion = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
					goto IL_00fa;
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 4;
				return true;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00fa;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0154;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0154;
			case 5:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", t136_SubirReputacion.triggerPlayerNum);
				goto IL_01b5;
			case 6:
				_003C_003E1__state = -1;
				goto IL_01b5;
			case 7:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				goto IL_0212;
			case 8:
				_003C_003E1__state = -1;
				goto IL_0212;
			case 9:
				{
					_003C_003E1__state = -1;
					t136_SubirReputacion.LHKIJABBBPM();
					return false;
				}
				IL_0212:
				if (TavernReputation.GetMilestone() < 1)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 8;
					return true;
				}
				NewTutorialManager.instance.ObjectiveCompleted(0);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 9;
				return true;
				IL_01b5:
				if (t136_SubirReputacion.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
				Utils.OFHPCBLHJBL(1f, 1f);
				_003C_003E2__current = CommonReferences.waitRealtime3;
				_003C_003E1__state = 7;
				return true;
				IL_00fa:
				if (!t136_SubirReputacion.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
				IL_0154:
				_003C_003E2__current = ((MonoBehaviour)t136_SubirReputacion).StartCoroutine(t136_SubirReputacion.CDICFNAMCEE());
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

	private IEnumerator EOCBHNPFJLL()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OPCHFFMKPCN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IGFOJFFHNJF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DECKMELAPMA()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JDEDKABEHJM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 136;
	}

	private IEnumerator NBOCOLCBOIL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDOJMLFHCHD()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJJHBJHCACM()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PPMPKJECPDE()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LFKPHADFFDG()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FHCNAFEMIGK()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator EHDIMBMCIDK()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator ELPDKDFFJJD()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLNKHNHGFPB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ADFMBGJOMKK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAOCEAKDPDK()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OOFDOHFANIE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MDFFFPLNDAP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FAEKOKEINEH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGDNIGIMDKP()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator AAGGGIONDAG()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PIHPPADDGMG()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JHBNODHNMCI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LKAGLINOIMK()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JAMDPHHGCDP()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator KEBCOCFPNIG()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PBEKBJIJFDK()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NIKPIBICOPP()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FGLMKBOMOBA()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FBOBCKJGPMB()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MFFGIOALMIC()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OAIEBGHEBAK()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LNNCIOJHJMK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BBGHMMLBAME()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DBCADKNONKE()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IHBNOLLFNPA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FCJODFOFODL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MEGKLKNBNEL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHIPOAGIOJK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AEMAMJOHIOA()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator GJOCBPGGHLP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AKMGPONCFHL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCNGHNLFCBO()
	{
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			yield return CommonReferences.wait1;
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T136/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: true);
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime3;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (TavernReputation.GetMilestone() < 1)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHGECAFMHEA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DNAAOCABLNF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}
}
