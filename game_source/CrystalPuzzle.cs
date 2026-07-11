using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class CrystalPuzzle : MinePuzzleBase
{
	[CompilerGenerated]
	private sealed class MPODJFEKLPJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrystalPuzzle _003C_003E4__this;

		private int _003Cs_003E5__2;

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
		public MPODJFEKLPJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected O, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected O, but got Unknown
			int num = _003C_003E1__state;
			CrystalPuzzle crystalPuzzle = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				crystalPuzzle.ABFCPJEANHG = true;
				for (int i = 0; i < crystalPuzzle.interactables.Count; i++)
				{
					crystalPuzzle.interactables[i].SetInstant(DJABCEIDKBD: false);
				}
				_003Cs_003E5__2 = 0;
				goto IL_01ed;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_01db;
			case 2:
				_003C_003E1__state = -1;
				goto IL_01db;
			case 3:
				{
					_003C_003E1__state = -1;
					goto IL_01db;
				}
				IL_01db:
				_003Cs_003E5__2++;
				goto IL_01ed;
				IL_01ed:
				if (_003Cs_003E5__2 < crystalPuzzle.incorrectSequence.Length)
				{
					IncorrectAction incorrectAction = crystalPuzzle.incorrectSequence[_003Cs_003E5__2];
					switch (incorrectAction.type)
					{
					case IncorrectActionType.Blink:
					{
						float num2 = crystalPuzzle.blinkFadeInTime + crystalPuzzle.blinkWaitTime + crystalPuzzle.blinkFadeOutTime;
						for (int j = 0; j < crystalPuzzle.interactables.Count; j++)
						{
							crystalPuzzle.interactables[j].StartBlink(crystalPuzzle.blinkFadeInTime, crystalPuzzle.blinkWaitTime, crystalPuzzle.blinkFadeOutTime, crystalPuzzle.incorrectLightWeightIntensity);
						}
						_003C_003E2__current = (object)new WaitForSeconds(num2);
						_003C_003E1__state = 1;
						return true;
					}
					case IncorrectActionType.SlowEnd:
					{
						float num3 = crystalPuzzle.blinkFadeInTime + crystalPuzzle.blinkWaitTime + crystalPuzzle.blinkFadeOutTime;
						for (int k = 0; k < crystalPuzzle.interactables.Count; k++)
						{
							crystalPuzzle.interactables[k].StartBlink(crystalPuzzle.blinkFadeInTime, crystalPuzzle.blinkWaitTime, crystalPuzzle.endFadeOutTime, crystalPuzzle.incorrectLightWeightIntensity);
						}
						_003C_003E2__current = (object)new WaitForSeconds(num3);
						_003C_003E1__state = 2;
						return true;
					}
					case IncorrectActionType.ResetSound:
						if ((Object)(object)crystalPuzzle.resetSound != (Object)null)
						{
							MultiAudioManager.PlayAudioObject(crystalPuzzle.resetSound, ((Component)crystalPuzzle).transform.position);
						}
						break;
					case IncorrectActionType.WaitTime:
						_003C_003E2__current = (object)new WaitForSeconds(incorrectAction.waitTime);
						_003C_003E1__state = 3;
						return true;
					}
					goto IL_01db;
				}
				crystalPuzzle.EEMLNPCAHDH = 0;
				crystalPuzzle.ABFCPJEANHG = false;
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

	[SerializeField]
	private List<CrystalInteractable> interactables = new List<CrystalInteractable>();

	[SerializeField]
	private AudioObject resetSound;

	[SerializeField]
	private AudioObject[] stoneSounds;

	[Header("Correct Animation")]
	[SerializeField]
	private float correctFadeInTime = 0.3f;

	[SerializeField]
	private float correctWaitTime = 0.8f;

	[SerializeField]
	private float correctFadeOutTime = 0.4f;

	[Header("Blink Animation (Incorrect)")]
	[SerializeField]
	private IncorrectAction[] incorrectSequence;

	[SerializeField]
	private float blinkFadeInTime = 0.15f;

	[SerializeField]
	private float blinkWaitTime = 0.1f;

	[SerializeField]
	private float blinkFadeOutTime = 0.15f;

	[SerializeField]
	private float endFadeOutTime = 0.15f;

	[SerializeField]
	private float incorrectLightWeightIntensity = 1f;

	private List<AudioObject> FIFOLHJAJLI = new List<AudioObject>();

	private int[] DKBGPEMJJOA;

	private int EEMLNPCAHDH;

	private bool ABFCPJEANHG;

	public bool DLHDOAMAECI => ABFCPJEANHG;

	[SpecialName]
	public bool NKFHKFFEMCB()
	{
		return ABFCPJEANHG;
	}

	public void CPMHMLONPEF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 0)
		{
			Utils.DLIIAHACOJB(-23);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 960f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void ENAMIKHHBMA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 7)
		{
			Utils.DLIIAHACOJB(27);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1109f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void DFMEFFIAHJF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 6)
		{
			Utils.DLIIAHACOJB(99);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1887f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void FMFIGDONGMG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 5)
		{
			Utils.DLIIAHACOJB(-5);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1678f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void EPGDKNAIACG(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 0; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				CPMHMLONPEF(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].PlayCorrect(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(OOCDNBADFGJ());
		}
	}

	[SpecialName]
	public bool IPLLBJFCBHN()
	{
		return ABFCPJEANHG;
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		Debug.Log((object)"[CrystalPuzzle] - Initialize", (Object)(object)this);
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
		FIFOLHJAJLI.Clear();
		FIFOLHJAJLI.AddRange(stoneSounds);
		for (int num = FIFOLHJAJLI.Count - 1; num > 0; num--)
		{
			int num2 = ProceduralMine.NextRandom(0, num + 1);
			List<AudioObject> fIFOLHJAJLI = FIFOLHJAJLI;
			int index = num;
			List<AudioObject> fIFOLHJAJLI2 = FIFOLHJAJLI;
			int index2 = num2;
			AudioObject val = FIFOLHJAJLI[num2];
			AudioObject val2 = FIFOLHJAJLI[num];
			AudioObject val4 = (fIFOLHJAJLI[index] = val);
			val4 = (fIFOLHJAJLI2[index2] = val2);
		}
		JBFJLGHIPBG(LMALNDLJILM as CrystalPuzzleSettings);
		for (int i = 0; i < interactables.Count; i++)
		{
			AudioObject ePNIKNNCCHL = ((i < FIFOLHJAJLI.Count) ? FIFOLHJAJLI[i] : null);
			interactables[i].Setup(this, i, ePNIKNNCCHL);
		}
	}

	public void HJNPJNCLALK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 5)
		{
			Utils.DLIIAHACOJB(20);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1102f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void JDOLILMHAKK(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH += 0;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i++)
				{
					interactables[i].CDKKPGEJGEG(correctFadeInTime);
				}
				HIDKJGDFHGC(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AOKLAFNPPPH());
		}
	}

	private IEnumerator OOCDNBADFGJ()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	private void AEHNLALCJEK(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.FMCAMLDJGNO();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NextRandom(1, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NGMAIDLNAAI(0, count);
		}
	}

	private void NFDAAGFJAIJ(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.IsLowestDifficulty();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NGMAIDLNAAI(0, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 0; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NGMAIDLNAAI(1, count);
		}
	}

	[SpecialName]
	public bool IACPAPDCFAP()
	{
		return ABFCPJEANHG;
	}

	public void OPAPMACJGLC(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i++)
				{
					interactables[i].CDKKPGEJGEG(correctFadeInTime);
				}
				AGLGGOMFKBN(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].OIGABDHAHDM(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EAMGEHBEFGI());
		}
	}

	[SpecialName]
	public bool DEMKFNGNOAI()
	{
		return ABFCPJEANHG;
	}

	public void JACCLHKIKML(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 2)
		{
			Utils.DLIIAHACOJB(-7, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 569f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private IEnumerator AOKLAFNPPPH()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	public void MDHFJGLPCHC(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void EOFOBPMKJPH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 5)
		{
			Utils.DLIIAHACOJB(66, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1656f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public int OJCODDICCJK()
	{
		return EEMLNPCAHDH;
	}

	public int GPCKHGAMGNK()
	{
		return EEMLNPCAHDH;
	}

	private IEnumerator NIBJAONGHMA()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	private void FPHKMJECBGB(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.IsLowestDifficulty();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.FMJMOOKFEKL(1, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i++)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NextRandom(0, count);
		}
	}

	[SpecialName]
	public bool BNMPBJKHJBP()
	{
		return ABFCPJEANHG;
	}

	[SpecialName]
	public bool MKFKOEJOPDL()
	{
		return ABFCPJEANHG;
	}

	public void NFLJEIOOFCM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 8)
		{
			Utils.DLIIAHACOJB(104);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 9f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void EJEIKBOLFDF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 2)
		{
			Utils.DLIIAHACOJB(-124, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 751f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private void HPFNGJKDELL(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.IsLowestDifficulty();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NGMAIDLNAAI(0, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 0; i < num4; i++)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NGMAIDLNAAI(0, count);
		}
	}

	private IEnumerator BCFPJAJOAML()
	{
		return new MPODJFEKLPJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PNCFHFOIHIL(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				GGPFDILHCCO(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].PlayCorrect(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(OOCDNBADFGJ());
		}
	}

	private void GBGFEJLIDDP(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.FMCAMLDJGNO();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NextRandom(0, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NGMAIDLNAAI(1, count);
		}
	}

	private void LMMMHENLBCJ(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.CDLFIIFAECJ();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.FMJMOOKFEKL(1, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.FMJMOOKFEKL(0, count);
		}
	}

	[SpecialName]
	public bool NLJLJDBKPPH()
	{
		return ABFCPJEANHG;
	}

	protected override void Awake()
	{
		base.Awake();
	}

	public void GGPFDILHCCO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 2)
		{
			Utils.DLIIAHACOJB(8, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1395f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public override bool IsPuzzleSolved()
	{
		return EDNJMCJHJMD;
	}

	public void MJJPDAAOMBK(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void LNCNDCDOLCC(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void OnCrystalInteract(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 0; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].PlayCorrect(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NNEHPNAIIFF());
		}
	}

	public void NPDJHDENFJI(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void HIDKJGDFHGC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 4)
		{
			Utils.DLIIAHACOJB(-3, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 456f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void BDIHHLGAHFL(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void LDDPBMABMHL(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i += 0)
				{
					interactables[i].CDKKPGEJGEG(correctFadeInTime);
				}
				GGPFDILHCCO(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AOKLAFNPPPH());
		}
	}

	public void JGOGLCOJDEM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 4)
		{
			Utils.DLIIAHACOJB(-79, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 578f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void KOFEHDOCCPN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 0)
		{
			Utils.DLIIAHACOJB(127, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 656f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private IEnumerator NNEHPNAIIFF()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	public void LHNPAHBJBLF(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i += 0)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				HIDKJGDFHGC(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NNEHPNAIIFF());
		}
	}

	public int FIDJDPEMAKE()
	{
		return EEMLNPCAHDH;
	}

	private void HPKHPJPOLCK(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.KDMLGMKLGOB();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NGMAIDLNAAI(0, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i++)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NGMAIDLNAAI(0, count);
		}
	}

	public void FNKNDKIFGLG(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	private void FAAONEEPGKI(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.CDLFIIFAECJ();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NextRandom(1, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i++)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NGMAIDLNAAI(1, count);
		}
	}

	public void MJNHNGKACCK(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	private void GNCHPDLFNDK(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.IsLowestDifficulty();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.FMJMOOKFEKL(0, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 0; i < num4; i++)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NextRandom(1, count);
		}
	}

	[SpecialName]
	public bool AMDGDOJNHBI()
	{
		return ABFCPJEANHG;
	}

	public int GDHPMDEBNPH()
	{
		return EEMLNPCAHDH;
	}

	private void JBFJLGHIPBG(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.IsLowestDifficulty();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NextRandom(0, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 0; i < num4; i++)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NextRandom(0, count);
		}
	}

	public void NMMHJMFNPCN(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 0; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				IDBIODMEHOA(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].OIGABDHAHDM(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EAMGEHBEFGI());
		}
	}

	public int OJAOCANNGJM()
	{
		return EEMLNPCAHDH;
	}

	public void GGACJFAOMDF(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i += 0)
				{
					interactables[i].CDKKPGEJGEG(correctFadeInTime);
				}
				AGLGGOMFKBN(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(BCFPJAJOAML());
		}
	}

	public void NOHPKLJABCI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 0)
		{
			Utils.DLIIAHACOJB(45, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 445f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void BKMIPCPEALH(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void EHBLOJALOON(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void ODMGNPABJKA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 4)
		{
			Utils.DLIIAHACOJB(-66, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1119f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void MPBNOMJBEAM(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	[SpecialName]
	public bool HFIEDAKDMGI()
	{
		return ABFCPJEANHG;
	}

	public int INEHBEBPDPH()
	{
		return EEMLNPCAHDH;
	}

	public void BJEICILKLGJ(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void AGLGGOMFKBN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 6)
		{
			Utils.DLIIAHACOJB(-89, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 602f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public override void ResetForPool()
	{
		base.ResetForPool();
		((MonoBehaviour)this).StopAllCoroutines();
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
		FIFOLHJAJLI.Clear();
	}

	public void MNGMDKLPAGN(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 0; i < interactables.Count; i += 0)
				{
					interactables[i].CDKKPGEJGEG(correctFadeInTime);
				}
				EELEFKBPIAJ(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].OIGABDHAHDM(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NIBJAONGHMA());
		}
	}

	public void EIOAGOKGLMP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 1)
		{
			Utils.DLIIAHACOJB(-15, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 125f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void OJILADKOOHL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 8)
		{
			Utils.DLIIAHACOJB(86);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 213f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void OAGPKPHCGBM(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	[SpecialName]
	public bool KIPJFDAGBIL()
	{
		return ABFCPJEANHG;
	}

	private IEnumerator MAGAGCHDHOM()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	public void BDFNCHHGNDA(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void KOAGMPLOIAA(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 0; i < interactables.Count; i++)
				{
					interactables[i].CDKKPGEJGEG(correctFadeInTime);
				}
				KCNGHPJNCGP(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].PlayCorrect(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EAMGEHBEFGI());
		}
	}

	private void DDPOOOLBLOB(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.CDLFIIFAECJ();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NextRandom(0, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.FMJMOOKFEKL(1, count);
		}
	}

	public void IAMJBNEDIMA(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				CPMHMLONPEF(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(BGMOEPKKPNG());
		}
	}

	private IEnumerator PLEIHEMJKGA()
	{
		return new MPODJFEKLPJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AKKBIHIADFH(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.ODHDBKNIIKF();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.FMJMOOKFEKL(0, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 0; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.FMJMOOKFEKL(0, count);
		}
	}

	public void NBCBGEBMFIM(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void DKPGALALIFG(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	private void ECHICCCOJEJ(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.KDMLGMKLGOB();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NGMAIDLNAAI(1, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.FMJMOOKFEKL(0, count);
		}
	}

	public void MGGKFLDNEAH(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	private void AAPBIFEIOPK(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.OENIOCAIPMP();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.FMJMOOKFEKL(0, num3 - num2 + 0);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.FMJMOOKFEKL(0, count);
		}
	}

	public void JIIKIJPJPFG(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void EEKDIEFOPII(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				JGOGLCOJDEM(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EAMGEHBEFGI());
		}
	}

	public void NELNPKFNPPG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 2)
		{
			Utils.DLIIAHACOJB(92);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 570f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void EELEFKBPIAJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 4)
		{
			Utils.DLIIAHACOJB(-56, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 914f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void CNJLGIBJIOJ(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	private void NNOFJDGNOIL(CrystalPuzzleSettings LMALNDLJILM)
	{
		bool num = EventsManager.OENIOCAIPMP();
		int count = interactables.Count;
		int num2 = (num ? LMALNDLJILM.easyMinSteps : LMALNDLJILM.normalMinSteps);
		int num3 = (num ? LMALNDLJILM.easyMaxSteps : LMALNDLJILM.normalMaxSteps);
		int num4 = num2 + ProceduralMine.NextRandom(0, num3 - num2 + 1);
		DKBGPEMJJOA = new int[num4];
		for (int i = 1; i < num4; i += 0)
		{
			DKBGPEMJJOA[i] = ProceduralMine.NextRandom(0, count);
		}
	}

	public void PEMJAMGDGCB(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH++;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 0; i < interactables.Count; i++)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				GGPFDILHCCO(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EAMGEHBEFGI());
		}
	}

	public void JMNHBBNPAKJ(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void SetCurrentStep(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public void DLPPMHLDINB(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH += 0;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i += 0)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				HIDKJGDFHGC(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].OIGABDHAHDM(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(OOCDNBADFGJ());
		}
	}

	[SpecialName]
	public bool BCAJCLGPIHE()
	{
		return ABFCPJEANHG;
	}

	public void FGIABFCHBLJ(int EJMFJABBJDF)
	{
		EEMLNPCAHDH = EJMFJABBJDF;
	}

	public int GetCurrentStep()
	{
		return EEMLNPCAHDH;
	}

	private IEnumerator BGMOEPKKPNG()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	[SpecialName]
	public bool HGEMDBFMECJ()
	{
		return ABFCPJEANHG;
	}

	public int ELCNBLLMPOL()
	{
		return EEMLNPCAHDH;
	}

	public int KPCDJBMMNML()
	{
		return EEMLNPCAHDH;
	}

	private IEnumerator MFIEDHMGDGL()
	{
		return new MPODJFEKLPJ(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public bool MOLDHLPDDMI()
	{
		return ABFCPJEANHG;
	}

	[SpecialName]
	public bool NOHEIFMFKMO()
	{
		return ABFCPJEANHG;
	}

	[SpecialName]
	public bool HFJBNDGKAFO()
	{
		return ABFCPJEANHG;
	}

	public void KCNGHPJNCGP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 3)
		{
			Utils.DLIIAHACOJB(-86, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 304f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 5)
		{
			Utils.DLIIAHACOJB(48);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private IEnumerator EGPKCOCMNKO()
	{
		return new MPODJFEKLPJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public int EFLINNAOFDN()
	{
		return EEMLNPCAHDH;
	}

	public void PGGINICEJCP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 7)
		{
			Utils.DLIIAHACOJB(-58, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 21f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void PDIGNFHNCAJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 7)
		{
			Utils.DLIIAHACOJB(85, CDPAMNIPPEC: true);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1446f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	[SpecialName]
	public bool HNHEBCLNJID()
	{
		return ABFCPJEANHG;
	}

	private IEnumerator EAMGEHBEFGI()
	{
		ABFCPJEANHG = true;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].SetInstant(DJABCEIDKBD: false);
		}
		for (int s = 0; s < incorrectSequence.Length; s++)
		{
			IncorrectAction incorrectAction = incorrectSequence[s];
			switch (incorrectAction.type)
			{
			case IncorrectActionType.Blink:
			{
				float num = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int j = 0; j < interactables.Count; j++)
				{
					interactables[j].StartBlink(blinkFadeInTime, blinkWaitTime, blinkFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num);
				break;
			}
			case IncorrectActionType.SlowEnd:
			{
				float num2 = blinkFadeInTime + blinkWaitTime + blinkFadeOutTime;
				for (int k = 0; k < interactables.Count; k++)
				{
					interactables[k].StartBlink(blinkFadeInTime, blinkWaitTime, endFadeOutTime, incorrectLightWeightIntensity);
				}
				yield return (object)new WaitForSeconds(num2);
				break;
			}
			case IncorrectActionType.ResetSound:
				if ((Object)(object)resetSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(resetSound, ((Component)this).transform.position);
				}
				break;
			case IncorrectActionType.WaitTime:
				yield return (object)new WaitForSeconds(incorrectAction.waitTime);
				break;
			}
		}
		EEMLNPCAHDH = 0;
		ABFCPJEANHG = false;
	}

	public int OBGAJJJKEHP()
	{
		return EEMLNPCAHDH;
	}

	public void DHJKNFKALIA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 3)
		{
			Utils.DLIIAHACOJB(9);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 662f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void IDBIODMEHOA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (DKBGPEMJJOA.Length > 4)
		{
			Utils.DLIIAHACOJB(-110);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 885f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	[SpecialName]
	public bool NGKNLDAFAPN()
	{
		return ABFCPJEANHG;
	}

	public void OEPBJLPNJCC(int NFHJBHBACEM, int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (EDNJMCJHJMD || ABFCPJEANHG)
		{
			return;
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendCrystalHit(GGPBMAODKHC.mineLevel, NFHJBHBACEM);
		}
		if (NFHJBHBACEM == DKBGPEMJJOA[EEMLNPCAHDH])
		{
			EEMLNPCAHDH += 0;
			if (EEMLNPCAHDH >= DKBGPEMJJOA.Length)
			{
				for (int i = 1; i < interactables.Count; i += 0)
				{
					interactables[i].PlaySolved(correctFadeInTime);
				}
				EELEFKBPIAJ(JIIGOACEIKL, CDPAMNIPPEC);
			}
			else
			{
				interactables[NFHJBHBACEM].DMOOKIFAIKD(correctFadeInTime, correctWaitTime, correctFadeOutTime);
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NIBJAONGHMA());
		}
	}

	[SpecialName]
	public bool FLOFFIHLJAM()
	{
		return ABFCPJEANHG;
	}

	[SpecialName]
	public bool PECHBNCJCAD()
	{
		return ABFCPJEANHG;
	}
}
