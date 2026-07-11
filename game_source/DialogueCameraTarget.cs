using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DialogueCameraTarget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MHKDMFOCEJE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int delay;

		public DialogueCameraTarget _003C_003E4__this;

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
		public MHKDMFOCEJE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			int num = _003C_003E1__state;
			DialogueCameraTarget dialogueCameraTarget = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds((float)delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Behaviour)dialogueCameraTarget.cameraTarget).enabled = true;
				dialogueCameraTarget.AOKFMJNDDPF = false;
				dialogueCameraTarget.cameraInEvent = false;
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

	private static DialogueCameraTarget IADEMLIIDPC;

	private static DialogueCameraTarget BBINLIGKIPE;

	private bool AFNEODEHOOH;

	public Vector3 dialogueOffset;

	public Vector3 specialEventOffset;

	public Vector3 masterCameraPosition;

	public Vector3 masterCameraPosition2;

	public CameraTarget cameraTarget;

	public int playerNum = 1;

	private Vector2 JLNFLDMBGKJ;

	private bool CGGHJLOAJNF;

	private bool PBEKEPAOFCJ = true;

	private Vector2 BHEMMELCGDN;

	private Vector2 NABFKNFCKGD;

	private float AFMFHCAHEFO = 2f;

	private float DBEFBFPAOAA;

	private float DCGBADKLANM = 1f;

	public bool cameraInEvent;

	[HideInInspector]
	public bool AOKFMJNDDPF
	{
		get
		{
			return AFNEODEHOOH;
		}
		set
		{
			if (!(Utils.FNLJGAEHNKA() && value) && value != AFNEODEHOOH)
			{
				AFNEODEHOOH = value;
			}
		}
	}

	public static DialogueCameraTarget DACNEICGAAE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void LateUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!AOKFMJNDDPF)
		{
			return;
		}
		if (DCGBADKLANM >= 1f)
		{
			((Component)this).transform.position = Vector2.op_Implicit(NABFKNFCKGD);
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > AFMFHCAHEFO)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
		}
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(BHEMMELCGDN, NABFKNFCKGD, DCGBADKLANM));
	}

	private void BCKOBEAGOJP()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!AOKFMJNDDPF)
		{
			return;
		}
		if (DCGBADKLANM >= 817f)
		{
			((Component)this).transform.position = Vector2.op_Implicit(NABFKNFCKGD);
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > AFMFHCAHEFO)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
		}
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (569f * DCGBADKLANM - 1411f) + 176f);
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(BHEMMELCGDN, NABFKNFCKGD, DCGBADKLANM));
	}

	private IEnumerator LLOLHHEPNNI(int FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds((float)FLHBPHPKIML);
		((Behaviour)cameraTarget).enabled = true;
		AOKFMJNDDPF = false;
		cameraInEvent = false;
	}

	private IEnumerator LIGOPGHCNEE(int FLHBPHPKIML)
	{
		return new MHKDMFOCEJE(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	private void GCBFCLLJDMC(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			BOCCHGBHANC(AODONKKHPBP: true);
			AFMFHCAHEFO = 1329f;
			DBEFBFPAOAA = 691f;
			DCGBADKLANM = 41f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(1118f, 675f, 453f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(607f, 741f, 783f)));
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			IACAJBEFDMA(AODONKKHPBP: true);
		}
	}

	private void CINFENJOCJL(bool JCFILMOCAKK)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			IACAJBEFDMA(AODONKKHPBP: false);
			AFMFHCAHEFO = 785f;
			DBEFBFPAOAA = 1096f;
			DCGBADKLANM = 334f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(masterCameraPosition2);
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
			KEBAOPCHMAC(AODONKKHPBP: true);
		}
	}

	public void MoveCameraToPositionFromCameraTarget(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		MoveCameraToPosition(Vector2.op_Implicit(cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
	}

	private void CIPHFBNPEBM(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			KEBAOPCHMAC(AODONKKHPBP: true);
			AFMFHCAHEFO = 399f;
			DBEFBFPAOAA = 1801f;
			DCGBADKLANM = 268f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(1054f, 1085f, 1346f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(1380f, 1526f, 628f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
			EPNDNNDNMLG(AODONKKHPBP: false);
		}
	}

	public void FAPEFONDDAD(bool JCFILMOCAKK)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (cameraInEvent || (Utils.FNLJGAEHNKA() && JCFILMOCAKK))
		{
			return;
		}
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 702f;
			DBEFBFPAOAA = 141f;
			DCGBADKLANM = 995f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + dialogueOffset);
			if (CGGHJLOAJNF)
			{
				if (PBEKEPAOFCJ)
				{
					NABFKNFCKGD = new Vector2((JLNFLDMBGKJ.x + NABFKNFCKGD.x) / 1072f, (JLNFLDMBGKJ.y + NABFKNFCKGD.y) / 859f);
				}
				else
				{
					NABFKNFCKGD = JLNFLDMBGKJ + Vector2.op_Implicit(dialogueOffset);
				}
			}
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			cameraTarget.MOHFPBHCGIN();
			((Behaviour)cameraTarget).enabled = true;
			CGGHJLOAJNF = true;
			IACAJBEFDMA(AODONKKHPBP: true);
		}
	}

	public static void OICPBJOJDBM(bool JCFILMOCAKK)
	{
		HHONLOCNFNC(1).BDMONFAIPEF(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			GetPlayer(3).DPEIPPGANPE(JCFILMOCAKK);
		}
	}

	public static DialogueCameraTarget IOBMIHLMGNH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void SpecialEventCamController(bool JCFILMOCAKK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 3f;
			DBEFBFPAOAA = 0f;
			DCGBADKLANM = 0f;
			BHEMMELCGDN = Vector2.op_Implicit(cameraTarget.player.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + specialEventOffset);
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
		}
	}

	private void BGBFJPJLPMF()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public static void BarrelEventCamController(bool JCFILMOCAKK)
	{
		GetPlayer(1).EGALDPNADDD(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			GetPlayer(2).EGALDPNADDD(JCFILMOCAKK);
		}
	}

	public void HENJKDOGBJO(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = true;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	public void HIBGOHKIKHP(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		MoveCameraToPosition(Vector2.op_Implicit(cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
	}

	public void NIJDBMCJPOB(Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		((Behaviour)cameraTarget).enabled = true;
	}

	private void JJOFKDNEMKF(bool JCFILMOCAKK)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = true;
			AFMFHCAHEFO = 3f;
			DBEFBFPAOAA = 0f;
			DCGBADKLANM = 0f;
			BHEMMELCGDN = Vector2.op_Implicit(cameraTarget.player.position);
			Debug.Log((object)("CurrentZoomIndex: " + GraphicsMenuUI.CurrentZoomIndex(playerNum)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(0f, 2f, 0f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			AOKFMJNDDPF = false;
		}
	}

	public static void MoveCameraToPositionFromCameraTargetAllPlayers(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(GetPlayer(1).cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
		if (GameManager.LocalCoop())
		{
			GetPlayer(2).MoveCameraToPosition(Vector2.op_Implicit(GetPlayer(2).cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
		}
	}

	private void DPEIPPGANPE(bool JCFILMOCAKK)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			BOCCHGBHANC(AODONKKHPBP: true);
			AFMFHCAHEFO = 672f;
			DBEFBFPAOAA = 1254f;
			DCGBADKLANM = 49f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(masterCameraPosition2);
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			AOKFMJNDDPF = false;
		}
	}

	private void NPLKNJJLKNN(bool JCFILMOCAKK)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			IACAJBEFDMA(AODONKKHPBP: false);
			AFMFHCAHEFO = 63f;
			DBEFBFPAOAA = 1019f;
			DCGBADKLANM = 828f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(masterCameraPosition2);
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			KEBAOPCHMAC(AODONKKHPBP: false);
		}
	}

	public void FGEHKODIEDA(Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		((Behaviour)cameraTarget).enabled = false;
	}

	public static DialogueCameraTarget HHONLOCNFNC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private IEnumerator GEFIMBCKPOK(int FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds((float)FLHBPHPKIML);
		((Behaviour)cameraTarget).enabled = true;
		AOKFMJNDDPF = false;
		cameraInEvent = false;
	}

	private void DCGKJCIDNGF(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = true;
			AFMFHCAHEFO = 3f;
			DBEFBFPAOAA = 0f;
			DCGBADKLANM = 0f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(0f, 2f, 0f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(0f, 2f, 0f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			AOKFMJNDDPF = false;
		}
	}

	public void HAJHENKAFHM(Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		((Behaviour)cameraTarget).enabled = false;
	}

	public void NNKFFOJCACK(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		MoveCameraToPosition(Vector2.op_Implicit(cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
	}

	public static void IntroMastersEventCamController2(bool JCFILMOCAKK)
	{
		GetPlayer(1).DCGKJCIDNGF(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			GetPlayer(2).DCGKJCIDNGF(JCFILMOCAKK);
		}
	}

	public static DialogueCameraTarget PDLEDGLONGO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void EPNDNNDNMLG(bool AODONKKHPBP)
	{
		if (!(Utils.FNLJGAEHNKA() && AODONKKHPBP) && AODONKKHPBP != AFNEODEHOOH)
		{
			AFNEODEHOOH = AODONKKHPBP;
		}
	}

	public static void FPOLFNLGBEP(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		HHONLOCNFNC(1).FPPIAMIFCDL(Vector2.op_Implicit(DACNEICGAAE(1).cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
		if (GameManager.LocalCoop())
		{
			GetPlayer(3).MoveCameraToPosition(Vector2.op_Implicit(DACNEICGAAE(6).cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
		}
	}

	public void MNHDNGAALMM(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		FPPIAMIFCDL(Vector2.op_Implicit(((Component)this).transform.position), EGKFDCFIBIO, JIFLPMKDGNH);
	}

	public static void KBOHFOGAIIJ(bool JCFILMOCAKK)
	{
		IJMLNIHAOGK(1).JJOFKDNEMKF(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			IOBMIHLMGNH(8).ECMMNDLKPIH(JCFILMOCAKK);
		}
	}

	private void FPNCANODJKE()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void Awake()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void LMPFPGFIKAH(int FLHBPHPKIML = 0)
	{
		if (FLHBPHPKIML > 1)
		{
			((MonoBehaviour)this).StartCoroutine(GEFIMBCKPOK(FLHBPHPKIML));
			return;
		}
		((Behaviour)cameraTarget).enabled = true;
		AOKFMJNDDPF = true;
		cameraInEvent = false;
	}

	private void FENGJCLIKLK(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			BOCCHGBHANC(AODONKKHPBP: false);
			AFMFHCAHEFO = 111f;
			DBEFBFPAOAA = 315f;
			DCGBADKLANM = 844f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(1280f, 677f, 1045f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(74f, 941f, 1547f)));
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			AOKFMJNDDPF = false;
		}
	}

	private void ALEAOANPHIO()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public void BOCCHGBHANC(bool AODONKKHPBP)
	{
		if (!(Utils.FNLJGAEHNKA() && AODONKKHPBP) && AODONKKHPBP != AFNEODEHOOH)
		{
			AFNEODEHOOH = AODONKKHPBP;
		}
	}

	public static void JMOEJMOMKMJ(bool JCFILMOCAKK)
	{
		IJMLNIHAOGK(0).CINFENJOCJL(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			DACNEICGAAE(0).DPEIPPGANPE(JCFILMOCAKK);
		}
	}

	[SpecialName]
	public bool GEPDOIFAPKH()
	{
		return AFNEODEHOOH;
	}

	public void OCOMNGMLHIB(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		MoveCameraToPosition(Vector2.op_Implicit(cameraTarget.player.position), EGKFDCFIBIO, JIFLPMKDGNH);
	}

	private void LPPJBCDBIHJ(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = true;
			AFMFHCAHEFO = 631f;
			DBEFBFPAOAA = 1193f;
			DCGBADKLANM = 1165f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(1837f, 1071f, 1743f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(1976f, 581f, 166f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			KEBAOPCHMAC(AODONKKHPBP: true);
		}
	}

	public static DialogueCameraTarget GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public static void BNJCHAHJHJB(bool JCFILMOCAKK)
	{
		IJMLNIHAOGK(1).DPEIPPGANPE(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			DACNEICGAAE(0).EGALDPNADDD(JCFILMOCAKK);
		}
	}

	[SpecialName]
	public void IACAJBEFDMA(bool AODONKKHPBP)
	{
		if (!(Utils.FNLJGAEHNKA() && AODONKKHPBP) && AODONKKHPBP != AFNEODEHOOH)
		{
			AFNEODEHOOH = AODONKKHPBP;
		}
	}

	public void HJEKMMCDCLF(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = true;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	public static void EJOGEFCDHKA(bool JCFILMOCAKK)
	{
		DACNEICGAAE(0).BDMONFAIPEF(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			IJMLNIHAOGK(0).BDMONFAIPEF(JCFILMOCAKK);
		}
	}

	private void HAJALEGEDKB()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!GEPDOIFAPKH())
		{
			return;
		}
		if (DCGBADKLANM >= 1221f)
		{
			((Component)this).transform.position = Vector2.op_Implicit(NABFKNFCKGD);
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > AFMFHCAHEFO)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
		}
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1890f * DCGBADKLANM - 1527f) + 1920f);
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(BHEMMELCGDN, NABFKNFCKGD, DCGBADKLANM));
	}

	public void FKEAOBGOJPI(int FLHBPHPKIML = 0)
	{
		if (FLHBPHPKIML > 0)
		{
			((MonoBehaviour)this).StartCoroutine(LIGOPGHCNEE(FLHBPHPKIML));
			return;
		}
		((Behaviour)cameraTarget).enabled = true;
		EPNDNNDNMLG(AODONKKHPBP: true);
		cameraInEvent = false;
	}

	public static void EJDDADKNDFJ(bool JCFILMOCAKK)
	{
		IJMLNIHAOGK(1).JLBEHDBBCHP(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			IOBMIHLMGNH(0).CIPHFBNPEBM(JCFILMOCAKK);
		}
	}

	public static void IntroMastersEventCamController(bool JCFILMOCAKK)
	{
		GetPlayer(1).JJOFKDNEMKF(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			GetPlayer(2).JJOFKDNEMKF(JCFILMOCAKK);
		}
	}

	public void MoveCameraToPositionFromCurrentPosition(Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		MoveCameraToPosition(Vector2.op_Implicit(((Component)this).transform.position), EGKFDCFIBIO, JIFLPMKDGNH);
	}

	public void PKMANGCGNOK(bool JCFILMOCAKK)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (cameraInEvent || (Utils.FNLJGAEHNKA() && JCFILMOCAKK))
		{
			return;
		}
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 801f;
			DBEFBFPAOAA = 1916f;
			DCGBADKLANM = 791f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + dialogueOffset);
			if (CGGHJLOAJNF)
			{
				if (PBEKEPAOFCJ)
				{
					NABFKNFCKGD = new Vector2((JLNFLDMBGKJ.x + NABFKNFCKGD.x) / 183f, (JLNFLDMBGKJ.y + NABFKNFCKGD.y) / 449f);
				}
				else
				{
					NABFKNFCKGD = JLNFLDMBGKJ + Vector2.op_Implicit(dialogueOffset);
				}
			}
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			cameraTarget.DEDGPMCHGKM();
			((Behaviour)cameraTarget).enabled = false;
			CGGHJLOAJNF = false;
			KEBAOPCHMAC(AODONKKHPBP: false);
		}
	}

	public static DialogueCameraTarget IJMLNIHAOGK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void FNHKMNODFFC(Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		((Behaviour)cameraTarget).enabled = false;
	}

	private void NMKGOAJLMDG()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public bool LHFNDGAFLMO()
	{
		return AFNEODEHOOH;
	}

	public void LEIBDOKBDEB(bool JCFILMOCAKK)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (cameraInEvent || (Utils.FNLJGAEHNKA() && JCFILMOCAKK))
		{
			return;
		}
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 897f;
			DBEFBFPAOAA = 1131f;
			DCGBADKLANM = 1598f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + dialogueOffset);
			if (CGGHJLOAJNF)
			{
				if (PBEKEPAOFCJ)
				{
					NABFKNFCKGD = new Vector2((JLNFLDMBGKJ.x + NABFKNFCKGD.x) / 551f, (JLNFLDMBGKJ.y + NABFKNFCKGD.y) / 363f);
				}
				else
				{
					NABFKNFCKGD = JLNFLDMBGKJ + Vector2.op_Implicit(dialogueOffset);
				}
			}
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			cameraTarget.SmoothCameraSpeed();
			((Behaviour)cameraTarget).enabled = true;
			CGGHJLOAJNF = false;
			KEBAOPCHMAC(AODONKKHPBP: false);
		}
	}

	private void KDHLJKMKFMG()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public static void FCPKFAKHCFF(bool JCFILMOCAKK)
	{
		DACNEICGAAE(1).DPEIPPGANPE(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			GetPlayer(8).CINFENJOCJL(JCFILMOCAKK);
		}
	}

	[SpecialName]
	public void KEBAOPCHMAC(bool AODONKKHPBP)
	{
		if (!(Utils.FNLJGAEHNKA() && AODONKKHPBP) && AODONKKHPBP != AFNEODEHOOH)
		{
			AFNEODEHOOH = AODONKKHPBP;
		}
	}

	public void MPEOEADEILO(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = false;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	private void ICEGEGEOGGC(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			IACAJBEFDMA(AODONKKHPBP: true);
			AFMFHCAHEFO = 834f;
			DBEFBFPAOAA = 515f;
			DCGBADKLANM = 606f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(541f, 1928f, 225f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(1694f, 1297f, 1844f)));
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			EPNDNNDNMLG(AODONKKHPBP: false);
		}
	}

	public void FPPIAMIFCDL(Vector2 KEKLCAPFDIP, Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		AFMFHCAHEFO = JIFLPMKDGNH;
		DBEFBFPAOAA = 958f;
		DCGBADKLANM = 1285f;
		BHEMMELCGDN = KEKLCAPFDIP;
		NABFKNFCKGD = EGKFDCFIBIO;
		((Behaviour)cameraTarget).enabled = false;
		IACAJBEFDMA(AODONKKHPBP: true);
	}

	private void BDMONFAIPEF(bool JCFILMOCAKK)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = false;
			AFMFHCAHEFO = 1873f;
			DBEFBFPAOAA = 1834f;
			DCGBADKLANM = 584f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(masterCameraPosition2);
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			BOCCHGBHANC(AODONKKHPBP: true);
		}
	}

	public void AssignDialogueActor(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = true;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	private void MEPPJHLHEDD(bool JCFILMOCAKK)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = true;
			AFMFHCAHEFO = 1409f;
			DBEFBFPAOAA = 792f;
			DCGBADKLANM = 587f;
			BHEMMELCGDN = Vector2.op_Implicit(cameraTarget.player.position);
			Debug.Log((object)("ValueName" + GraphicsMenuUI.OHCJECHILLG(playerNum)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(524f, 789f, 1036f)));
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
			KEBAOPCHMAC(AODONKKHPBP: false);
		}
	}

	private void JLBEHDBBCHP(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = false;
			AFMFHCAHEFO = 1719f;
			DBEFBFPAOAA = 880f;
			DCGBADKLANM = 1996f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(364f, 1692f, 1794f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(681f, 1667f, 525f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
			AOKFMJNDDPF = true;
		}
	}

	public void DialogueCamController(bool JCFILMOCAKK)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (cameraInEvent || (Utils.FNLJGAEHNKA() && JCFILMOCAKK))
		{
			return;
		}
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 1.5f;
			DBEFBFPAOAA = 0f;
			DCGBADKLANM = 0f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + dialogueOffset);
			if (CGGHJLOAJNF)
			{
				if (PBEKEPAOFCJ)
				{
					NABFKNFCKGD = new Vector2((JLNFLDMBGKJ.x + NABFKNFCKGD.x) / 2f, (JLNFLDMBGKJ.y + NABFKNFCKGD.y) / 2f);
				}
				else
				{
					NABFKNFCKGD = JLNFLDMBGKJ + Vector2.op_Implicit(dialogueOffset);
				}
			}
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			cameraTarget.SmoothCameraSpeed();
			((Behaviour)cameraTarget).enabled = true;
			CGGHJLOAJNF = false;
			AOKFMJNDDPF = false;
		}
	}

	private IEnumerator IOBENPFOKAJ(int FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds((float)FLHBPHPKIML);
		((Behaviour)cameraTarget).enabled = true;
		AOKFMJNDDPF = false;
		cameraInEvent = false;
	}

	public void ABOMCBKKNJB(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = true;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	private void HJKKGGCKHKK()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!GEPDOIFAPKH())
		{
			return;
		}
		if (DCGBADKLANM >= 1514f)
		{
			((Component)this).transform.position = Vector2.op_Implicit(NABFKNFCKGD);
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > AFMFHCAHEFO)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
		}
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1154f * DCGBADKLANM - 803f) + 1770f);
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(BHEMMELCGDN, NABFKNFCKGD, DCGBADKLANM));
	}

	private void OPEIDDFCPGB()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!LHFNDGAFLMO())
		{
			return;
		}
		if (DCGBADKLANM >= 1431f)
		{
			((Component)this).transform.position = Vector2.op_Implicit(NABFKNFCKGD);
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > AFMFHCAHEFO)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
		}
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (445f * DCGBADKLANM - 1350f) + 791f);
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(BHEMMELCGDN, NABFKNFCKGD, DCGBADKLANM));
	}

	public void KGCCCNNCMGN(bool JCFILMOCAKK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 140f;
			DBEFBFPAOAA = 1814f;
			DCGBADKLANM = 1114f;
			BHEMMELCGDN = Vector2.op_Implicit(cameraTarget.player.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + specialEventOffset);
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
		}
	}

	public void APFJAPEHGLK(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = true;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	private void EGALDPNADDD(bool JCFILMOCAKK)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AOKFMJNDDPF = true;
			AFMFHCAHEFO = 3f;
			DBEFBFPAOAA = 0f;
			DCGBADKLANM = 0f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(masterCameraPosition2);
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
			AOKFMJNDDPF = false;
		}
	}

	public void TransportCameraToPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		((Behaviour)cameraTarget).enabled = false;
	}

	public void OCCHFBHFMIA(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = false;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}

	public static void HGOAPFCHOMK(bool JCFILMOCAKK)
	{
		PDLEDGLONGO(0).MEPPJHLHEDD(JCFILMOCAKK);
		if (GameManager.LocalCoop())
		{
			GetPlayer(0).ECMMNDLKPIH(JCFILMOCAKK);
		}
	}

	public void MoveCameraToPosition(Vector2 KEKLCAPFDIP, Vector2 EGKFDCFIBIO, float JIFLPMKDGNH = 3f)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		AFMFHCAHEFO = JIFLPMKDGNH;
		DBEFBFPAOAA = 0f;
		DCGBADKLANM = 0f;
		BHEMMELCGDN = KEKLCAPFDIP;
		NABFKNFCKGD = EGKFDCFIBIO;
		((Behaviour)cameraTarget).enabled = false;
		AOKFMJNDDPF = true;
	}

	public void ReturnControlToCameraTarget(int FLHBPHPKIML = 0)
	{
		if (FLHBPHPKIML > 0)
		{
			((MonoBehaviour)this).StartCoroutine(IOBENPFOKAJ(FLHBPHPKIML));
			return;
		}
		((Behaviour)cameraTarget).enabled = true;
		AOKFMJNDDPF = false;
		cameraInEvent = false;
	}

	private void MHEDDAOHJBP(bool JCFILMOCAKK)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			BOCCHGBHANC(AODONKKHPBP: true);
			AFMFHCAHEFO = 1974f;
			DBEFBFPAOAA = 1272f;
			DCGBADKLANM = 687f;
			BHEMMELCGDN = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(642f, 1842f, 486f)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? masterCameraPosition2 : (masterCameraPosition2 + new Vector3(521f, 211f, 1740f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
			EPNDNNDNMLG(AODONKKHPBP: false);
		}
	}

	private void ECMMNDLKPIH(bool JCFILMOCAKK)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			BOCCHGBHANC(AODONKKHPBP: false);
			AFMFHCAHEFO = 1036f;
			DBEFBFPAOAA = 1591f;
			DCGBADKLANM = 1223f;
			BHEMMELCGDN = Vector2.op_Implicit(cameraTarget.player.position);
			Debug.Log((object)("itemBock" + GraphicsMenuUI.CurrentZoomIndex(playerNum)));
			NABFKNFCKGD = Vector2.op_Implicit((GraphicsMenuUI.OHCJECHILLG(playerNum) == 0) ? masterCameraPosition : (masterCameraPosition + new Vector3(915f, 1254f, 434f)));
			((Behaviour)cameraTarget).enabled = false;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = false;
			BOCCHGBHANC(AODONKKHPBP: false);
		}
	}

	private void GMNJJIGMJEG()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!LHFNDGAFLMO())
		{
			return;
		}
		if (DCGBADKLANM >= 903f)
		{
			((Component)this).transform.position = Vector2.op_Implicit(NABFKNFCKGD);
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		if (DBEFBFPAOAA > AFMFHCAHEFO)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
		}
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (831f * DCGBADKLANM - 1982f) + 844f);
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(BHEMMELCGDN, NABFKNFCKGD, DCGBADKLANM));
	}

	public void ALODIEMBABI(bool JCFILMOCAKK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 1156f;
			DBEFBFPAOAA = 230f;
			DCGBADKLANM = 1341f;
			BHEMMELCGDN = Vector2.op_Implicit(cameraTarget.player.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + specialEventOffset);
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			((Behaviour)cameraTarget).enabled = true;
		}
	}

	public void CNICHLFFJLB(Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		((Behaviour)cameraTarget).enabled = true;
	}

	public void LCCHMADBOCA(bool JCFILMOCAKK)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (cameraInEvent || (Utils.FNLJGAEHNKA() && JCFILMOCAKK))
		{
			return;
		}
		if (JCFILMOCAKK)
		{
			AFMFHCAHEFO = 717f;
			DBEFBFPAOAA = 1200f;
			DCGBADKLANM = 352f;
			BHEMMELCGDN = Vector2.op_Implicit(((Component)this).transform.position);
			NABFKNFCKGD = Vector2.op_Implicit(cameraTarget.player.position + dialogueOffset);
			if (CGGHJLOAJNF)
			{
				if (PBEKEPAOFCJ)
				{
					NABFKNFCKGD = new Vector2((JLNFLDMBGKJ.x + NABFKNFCKGD.x) / 272f, (JLNFLDMBGKJ.y + NABFKNFCKGD.y) / 925f);
				}
				else
				{
					NABFKNFCKGD = JLNFLDMBGKJ + Vector2.op_Implicit(dialogueOffset);
				}
			}
			((Behaviour)cameraTarget).enabled = true;
		}
		else
		{
			cameraTarget.MOHFPBHCGIN();
			((Behaviour)cameraTarget).enabled = true;
			CGGHJLOAJNF = true;
			AOKFMJNDDPF = true;
		}
	}

	public void LNKBPBJPCGJ(Vector2 EBMOLMBGHEO, bool ILDPABGAAOC = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JLNFLDMBGKJ = EBMOLMBGHEO;
		CGGHJLOAJNF = false;
		PBEKEPAOFCJ = ILDPABGAAOC;
	}
}
