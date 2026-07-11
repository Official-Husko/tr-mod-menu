using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T135_EncenderChimenea : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T135_EncenderChimenea _003C_003E4__this;

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
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T135_EncenderChimenea t135_EncenderChimenea = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t135_EncenderChimenea).StartCoroutine(t135_EncenderChimenea.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
				goto IL_0140;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0140;
			case 5:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref t135_EncenderChimenea.JELIKOFDONK);
				TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
				TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
				goto IL_01df;
			case 6:
				_003C_003E1__state = -1;
				goto IL_01df;
			case 7:
				{
					_003C_003E1__state = -1;
					t135_EncenderChimenea.LHKIJABBBPM();
					return false;
				}
				IL_01df:
				if ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if ((Object)(object)t135_EncenderChimenea.JELIKOFDONK != (Object)null)
				{
					Object.Destroy((Object)(object)t135_EncenderChimenea.JELIKOFDONK);
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 7;
				return true;
				IL_0140:
				if (t135_EncenderChimenea.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				Utils.OFHPCBLHJBL(1f, 1f);
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

	private IEnumerator JDEDKABEHJM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FGLMKBOMOBA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IHBNOLLFNPA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
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

	private IEnumerator EOCBHNPFJLL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator AKMGPONCFHL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JHBNODHNMCI()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FHCNAFEMIGK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAOCEAKDPDK()
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

	private IEnumerator PPMPKJECPDE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LGDNIGIMDKP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FBOBCKJGPMB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 135;
	}

	private IEnumerator GDOJMLFHCHD()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MDFFFPLNDAP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLNKHNHGFPB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OBCHIKLEMKF()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LFKPHADFFDG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OAIEBGHEBAK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
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

	private IEnumerator NCNGHNLFCBO()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PIHPPADDGMG()
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

	private IEnumerator ELPDKDFFJJD()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NIKPIBICOPP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MFFGIOALMIC()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JAMDPHHGCDP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DECKMELAPMA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
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

	private IEnumerator MEGKLKNBNEL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LNNCIOJHJMK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LKAGLINOIMK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OPCHFFMKPCN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
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

	private IEnumerator AEMAMJOHIOA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IGFOJFFHNJF()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		yield return CommonReferences.wait3;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T135/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		Utils.OFHPCBLHJBL(1f, 1f);
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Fireplace.GetFirstFireplace()).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		TavernManager.GGFJGHHHEJC.tutorialHeatLevel = true;
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		while ((Object)(object)Fireplace.GetFirstFireplace() == (Object)null || !Fireplace.GetFirstFireplace().MAJLJNMJKON)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}
}
