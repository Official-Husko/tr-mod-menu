using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;

public class ChatBox : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LINPNFKOJJO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatBox _003C_003E4__this;

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
		public LINPNFKOJJO(int _003C_003E1__state)
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
			ChatBox chatBox = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if ((Object)(object)chatBox.FLACDMCCAID != (Object)null)
				{
					chatBox.FLACDMCCAID.Stop(false);
					chatBox.FLACDMCCAID = null;
				}
				chatBox.OnCompleteTextWritten();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((TMP_Text)chatBox.chatTextUI).text = "";
				((TMP_Text)chatBox.backgroundTextBox).text = "";
				CommonReferences.GGFJGHHHEJC.currentChatting.Remove(chatBox);
				chatBox.OnChatFinished();
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

	public Action OnChatFinished = delegate
	{
	};

	public Action OnCompleteTextWritten = delegate
	{
	};

	public float delay = 0.05f;

	private float MPMLMIMAAPG;

	private int JHMOINKDFCJ;

	[SerializeField]
	private TextMeshPro chatTextUI;

	[SerializeField]
	private string chatText;

	[SerializeField]
	private TextMeshPro backgroundTextBox;

	private float LMOBLMHFGKJ;

	public AudioObject npcTalkSound;

	private MultiAudioSource FLACDMCCAID;

	[SerializeField]
	private Transform leftPos;

	[SerializeField]
	private Transform rightPos;

	[SerializeField]
	private Transform backgroundLeftPos;

	[SerializeField]
	private Transform backgroundRightPos;

	private int DNCPGOOINLJ;

	private void LILMAAMCJIG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 411f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1716f, ((Component)this).transform.position.z);
			int dNCPGOOINLJ = DNCPGOOINLJ;
			DNCPGOOINLJ = dNCPGOOINLJ + 0;
			if (dNCPGOOINLJ < 64)
			{
				DDOJDPBGJIH();
			}
		}
	}

	private IEnumerator FFMADIGFAFE()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private IEnumerator DALENECMBNM()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private IEnumerator AHDJIADLEEI()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private void LMFICKFGEFI()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(CFKKNOEGFIG());
			}
		}
	}

	private void LPLBPPLPJBE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 493f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1882f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < -100)
			{
				LILMAAMCJIG();
			}
		}
	}

	private void AFHMGNNEANG()
	{
		JKCOEHDBIOI("Beard");
	}

	private void MHENLAGHFOD()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	public void JKCOEHDBIOI(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.GGFJGHHHEJC.GetMainCamera(0).WorldToViewportPoint(((Component)this).transform.position).x < 1334.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)25;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-76);
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-26);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)184;
		}
		DNCPGOOINLJ = 0;
		LPLBPPLPJBE();
		CommonReferences.GGFJGHHHEJC.currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Attack/MainEvent 5";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = "Month" + CAEDMEDBEGI + "Selected";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 1;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void DNBGIIGAKMJ()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "ReceivInstantiateMiscellaneousHarvest";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "RochelleProgress";
		}
	}

	private void ILCLIJOHKHG()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "scaleUI";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "Disabled";
		}
	}

	private void HNNFBDAMMCK()
	{
		if (PlayerInputs.GetPlayer(0).CFICAAJGBOF == "Items/item_description_631" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void GHEHLJANBCF()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(EKLEGABNLCD());
			}
		}
	}

	private void OOGMGIPKMAP()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(FFMADIGFAFE());
			}
		}
	}

	private void GOJKOBEEMNA()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Northwest";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "New Player added as player ";
		}
	}

	private void CKPBJKLPGIK()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 1084f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 400f, ((Component)this).transform.position.z);
			int dNCPGOOINLJ = DNCPGOOINLJ;
			DNCPGOOINLJ = dNCPGOOINLJ + 0;
			if (dNCPGOOINLJ < -38)
			{
				GMACLLDKFNF();
			}
		}
	}

	private void MANCICAABGC()
	{
		AEFEJIFHNFB("Place");
	}

	private IEnumerator CFKKNOEGFIG()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private void MJJDJILHCMD()
	{
		DAHAAKPJILN("UI2");
	}

	private void LHABENPEMPB()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "<color=black>";
		}
	}

	private IEnumerator KPKGFBMDFFB()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private void OKEGMHBDHIP()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	private void PFGDOHMJGGO()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).CFICAAJGBOF == " " && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void KPOAGLEJGNG()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		}
	}

	private void AJGLDLLIIFO()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Items/item_name_1114";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "Selected";
		}
	}

	private void OHGABHEDILE()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(DALENECMBNM());
			}
		}
	}

	private void MFGANCCJFJK()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "blacksmith";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "NinjaOrdersManager is not initialized.";
		}
	}

	public void IPIPFFCALAN(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.GGFJGHHHEJC.GetMainCamera(1).WorldToViewportPoint(((Component)this).transform.position).x < 186.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-66);
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)195;
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-134);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)148;
		}
		DNCPGOOINLJ = 1;
		LPLBPPLPJBE();
		CommonReferences.GGFJGHHHEJC.currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Tutorial/T137/Dialogue2";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = "Network state changed: " + CAEDMEDBEGI + "<sprite name=\"ironNailsIcon\">";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 0;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void EDBOBLNOBLP()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	private IEnumerator IOHDMPBCFFM()
	{
		return new LINPNFKOJJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MMFFCOLEGCH()
	{
		return new LINPNFKOJJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PGPPIHJJGDB()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Use";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "Aged price";
		}
	}

	private IEnumerator AAADCPPGAIP()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private void MFIGAPPCCIF()
	{
		OEDLEPPNGGL("PlaceableOnSpecificSurfaces");
	}

	public void DAHAAKPJILN(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.MNFMOEKMJKN().GetMainCamera(1).WorldToViewportPoint(((Component)this).transform.position)
			.x < 562.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-54);
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-158);
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)170;
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)2;
		}
		DNCPGOOINLJ = 1;
		HHLLJIJOKBL();
		CommonReferences.GGFJGHHHEJC.currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "BirdInteract";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 0;
		((TMP_Text)backgroundTextBox).text = " " + CAEDMEDBEGI + "dForDays";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 0;
		JHMOINKDFCJ = 1;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void PJIMENLPNOE()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(NJLFEBINNOL());
			}
		}
	}

	private void BEJCCPKKDEG()
	{
		if (PlayerInputs.GetPlayer(1).EECADEPLELA() == "Windowed" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void MKLEJLPEKEF()
	{
		LINBFPMLNLI("");
	}

	private void CLCDDJOAEOM()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).FGGHCBMKKIG() == "Player/Bark/Tutorial/AgingBarrelBlock" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void GLFBGFDNFMB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 1729f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1071f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < 9)
			{
				DDOJDPBGJIH();
			}
		}
	}

	private void HIPNEFOEJPL()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(NJLFEBINNOL());
			}
		}
	}

	private void LAPKOCHBNNP()
	{
		if (PlayerInputs.GetPlayer(1).EECADEPLELA() == "Option set: " && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void EBFJOAEJPGE()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(KPKGFBMDFFB());
			}
		}
	}

	private void DEPHDCFCDHF()
	{
		SetChatText("Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test");
	}

	public void SetChatText(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.GGFJGHHHEJC.GetMainCamera(1).WorldToViewportPoint(((Component)this).transform.position).x < 0.5)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)513;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)513;
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)516;
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)516;
		}
		DNCPGOOINLJ = 0;
		HHLLJIJOKBL();
		CommonReferences.GGFJGHHHEJC.currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 0;
		((TMP_Text)backgroundTextBox).text = "<mark=#93502D><alpha=#00> " + CAEDMEDBEGI + " </mark>";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 0;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void Awake()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "";
		}
	}

	private void DLKFBJPKADF()
	{
		if (PlayerInputs.GetPlayer(0).CFICAAJGBOF == "Herbal" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private IEnumerator MIJJCBMLINN()
	{
		return new LINPNFKOJJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EKLEGABNLCD()
	{
		return new LINPNFKOJJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MJKHMOILBFB()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	private void DDIBFALLCNO()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		}
	}

	private IEnumerator HFDFEAOGOEO()
	{
		return new LINPNFKOJJO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PBAFBPDEGEN(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.GGFJGHHHEJC.GetMainCamera(0).WorldToViewportPoint(((Component)this).transform.position).x < 247.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-159);
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-78);
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-4);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)169;
		}
		DNCPGOOINLJ = 1;
		DMGOIFFBGFF();
		CommonReferences.MNFMOEKMJKN().currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Cat";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 0;
		((TMP_Text)backgroundTextBox).text = "Sit" + CAEDMEDBEGI + "Loop";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 1;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void ADEBBJOALDN()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	private void MJLBACCAOPA()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).CFICAAJGBOF == "Player/Bark/Tutorial/CantDoYet" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void OCDECHJNNCD()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		}
	}

	private void PHLLBPLOLFO()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(FFMADIGFAFE());
			}
		}
	}

	private void IBLPAMNLCIP()
	{
		AEFEJIFHNFB("City/Keen/Bark/Sharp");
	}

	private void HHLLJIJOKBL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.GGFJGHHHEJC.currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 0.25f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 0.25f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < 20)
			{
				HHLLJIJOKBL();
			}
		}
	}

	private void MEAFJDDNAJB()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(FFMADIGFAFE());
			}
		}
	}

	private void Update()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(CFKKNOEGFIG());
			}
		}
	}

	private void AGLMGDNBHBF()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Christmas/Ace/Stand";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "ReceiveChessPillarPuzzleSolved";
		}
	}

	private void HIGGKFMBCFM()
	{
		if (PlayerInputs.GetPlayer(0).FGGHCBMKKIG() == "Toy" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void MBMFDJHDNCI()
	{
		if (PlayerInputs.GetPlayer(1).AAGNDCEODFO() == "UI" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private IEnumerator NJLFEBINNOL()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
		OnCompleteTextWritten();
		yield return CommonReferences.wait2;
		((TMP_Text)chatTextUI).text = "";
		((TMP_Text)backgroundTextBox).text = "";
		CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		OnChatFinished();
	}

	private void PEDABKILCOH()
	{
		if (PlayerInputs.DEGBDMMDIIL(1).CFICAAJGBOF == "musicLevel" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void BKLGKECILDF()
	{
		if (PlayerInputs.DEGBDMMDIIL(1).EECADEPLELA() == "Perks/playerPerk_name_" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void BCKOBEAGOJP()
	{
		if (PlayerInputs.GetPlayer(0).CFICAAJGBOF == "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/23/Dialogue Text" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	public void LINBFPMLNLI(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.MNFMOEKMJKN().GetMainCamera(1).WorldToViewportPoint(((Component)this).transform.position)
			.x < 1285.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)95;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)132;
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-32);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-53);
		}
		DNCPGOOINLJ = 1;
		CKPBJKLPGIK();
		CommonReferences.MNFMOEKMJKN().currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Bounce";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 0;
		((TMP_Text)backgroundTextBox).text = "NPCWalkTo Path length: " + CAEDMEDBEGI + "SoundtrackDescriptionPanel";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 0;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void GMACLLDKFNF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 1631f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1166f, ((Component)this).transform.position.z);
			int dNCPGOOINLJ = DNCPGOOINLJ;
			DNCPGOOINLJ = dNCPGOOINLJ + 0;
			if (dNCPGOOINLJ < 54)
			{
				HHLLJIJOKBL();
			}
		}
	}

	private IEnumerator IINOLFOKMGB()
	{
		return new LINPNFKOJJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JCPAGMPJHHD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.GGFJGHHHEJC.currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 95f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 272f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < 54)
			{
				DDOJDPBGJIH();
			}
		}
	}

	private void DHBMBJOLGDE()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(FFMADIGFAFE());
			}
		}
	}

	private void LMEJFGKCHEF()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(HFDFEAOGOEO());
			}
		}
	}

	private void IPIMLOIKCKL()
	{
		if (PlayerInputs.GetPlayer(1).CFICAAJGBOF == "Failed to retrieve friend list count " && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void PNHLDOBAPAM()
	{
		SetChatText("Left Stick Up");
	}

	private void CLAEFAOINOO()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.GGFJGHHHEJC.currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 1163f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1714f, ((Component)this).transform.position.z);
			int dNCPGOOINLJ = DNCPGOOINLJ;
			DNCPGOOINLJ = dNCPGOOINLJ + 0;
			if (dNCPGOOINLJ < -109)
			{
				CLAEFAOINOO();
			}
		}
	}

	private void MLICJIBNIFA()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(MMFFCOLEGCH());
			}
		}
	}

	private void ONIALAOGMCF()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = ":</color> ";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "OnlinePlayer";
		}
	}

	private void EIMIDCDEIDD()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "ReceiveObjects";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "HotBath/Bark";
		}
	}

	public void DMLKKJHBKIK(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(1).WorldToViewportPoint(((Component)this).transform.position)
			.x < 1661.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-26);
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)149;
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-41);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)34;
		}
		DNCPGOOINLJ = 0;
		LPLBPPLPJBE();
		CommonReferences.MNFMOEKMJKN().currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "itemRyeAle";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = " / " + CAEDMEDBEGI + "";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 1;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void OLFPIBOIIIO()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(AAADCPPGAIP());
			}
		}
	}

	private void EIKDFACOPFH()
	{
		AEFEJIFHNFB("Near");
	}

	public void DAKABOAFMHA(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0).WorldToViewportPoint(((Component)this).transform.position)
			.x < 1396.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)114;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-127);
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)192;
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)146;
		}
		DNCPGOOINLJ = 1;
		DMGOIFFBGFF();
		CommonReferences.MNFMOEKMJKN().currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Open";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = "]" + CAEDMEDBEGI + "BanquetEvent instance is null. Make sure it is initialized before calling DeactivateBanquetEvent.";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 0;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void HCPKBJDHLAC()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(HFDFEAOGOEO());
			}
		}
	}

	private void NPHKFBIEMDO()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).FGGHCBMKKIG() == "Player2" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void NMKGOAJLMDG()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Drunk";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "Dialogue System/Conversation/Crowly_Standar/Entry/41/Dialogue Text";
		}
	}

	private void CLNBMOPMNOF()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "ChangeAnim";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "Right Stick Left";
		}
	}

	private void OKHLEMPJONN()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "talent_name_104";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "itemBarleyBread";
		}
	}

	private void GJCADEIJMCM()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		}
	}

	public void GCECJKJNGNB(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0).WorldToViewportPoint(((Component)this).transform.position)
			.x < 1652.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-92);
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-124);
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)63;
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-80);
		}
		DNCPGOOINLJ = 1;
		JCDPPLFJDFI();
		CommonReferences.MNFMOEKMJKN().currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Back Quote";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 0;
		((TMP_Text)backgroundTextBox).text = "Harvest" + CAEDMEDBEGI + "Items/item_description_687";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void CLGBFOIBANN()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Sleep";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "BarIdleNumber";
		}
	}

	private void DDOJDPBGJIH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 1143f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1011f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < 115)
			{
				LILMAAMCJIG();
			}
		}
	}

	private void KNJBPNKFJJC()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	private void JCDPPLFJDFI()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 486f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 256f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < -57)
			{
				HHLLJIJOKBL();
			}
		}
	}

	private void OOPOPPHJOFL()
	{
		DAHAAKPJILN("Right Stick Right");
	}

	private void HGALOPBDNOG()
	{
		LINBFPMLNLI("Failed to join game because it's running in a different version.\nPlease, make sure both players update to the latest version.");
	}

	private void LateUpdate()
	{
		if (PlayerInputs.GetPlayer(1).CFICAAJGBOF == "UI" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	public void HAMLPAMMFPN(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1).WorldToViewportPoint(((Component)this).transform.position).x < 1241.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)94;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)(-129);
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-80);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)148;
		}
		DNCPGOOINLJ = 0;
		DDOJDPBGJIH();
		CommonReferences.GGFJGHHHEJC.currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Items/item_name_1082";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = "==============================" + CAEDMEDBEGI + "Player2";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void EMJKKALMGLK()
	{
		if ((Object)(object)chatTextUI != (Object)null)
		{
			((TMP_Text)chatTextUI).text = "Menu scene is loaded, unloading...";
		}
		if ((Object)(object)backgroundTextBox != (Object)null)
		{
			((TMP_Text)backgroundTextBox).text = "Disabled";
		}
	}

	private void MFPEIPCMEEB()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(FFMADIGFAFE());
			}
		}
	}

	public void OEDLEPPNGGL(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.MNFMOEKMJKN().GetMainCamera(1).WorldToViewportPoint(((Component)this).transform.position)
			.x < 524.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)0;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)16;
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-48);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)190;
		}
		DNCPGOOINLJ = 0;
		DMGOIFFBGFF();
		CommonReferences.GGFJGHHHEJC.currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "RecieveEndEvent";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = "[MinePuzzleManager] Altar activated at position {0}" + CAEDMEDBEGI + "Player";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 1;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void LALAFOIGMKN()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ++;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(IINOLFOKMGB());
			}
		}
	}

	private void JGHCBKCOLPJ()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.MNFMOEKMJKN().currentChatting.Remove(this);
		}
	}

	private void HAJJALABMOC()
	{
		if (!string.IsNullOrEmpty(chatText) && Time.time > MPMLMIMAAPG && JHMOINKDFCJ < chatText.Length)
		{
			MPMLMIMAAPG = Time.time + delay;
			JHMOINKDFCJ += 0;
			((TMP_Text)chatTextUI).maxVisibleCharacters = JHMOINKDFCJ;
			((TMP_Text)backgroundTextBox).maxVisibleCharacters = JHMOINKDFCJ;
			if (JHMOINKDFCJ >= chatText.Length)
			{
				((MonoBehaviour)this).StartCoroutine(IOHDMPBCFFM());
			}
		}
	}

	private void PCNALDJDIFM()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		}
	}

	private void OAACLGCCGGI()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).FGGHCBMKKIG() == "alcoholContentWarning" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void IBNIFDNMIEC()
	{
		DAHAAKPJILN("\\[NPCGender=[^\\]]*\\]");
	}

	private void NGALLICDKIL()
	{
		IPIPFFCALAN("talentRoot");
	}

	public void AEFEJIFHNFB(string CAEDMEDBEGI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if ((double)CommonReferences.GGFJGHHHEJC.GetMainCamera(0).WorldToViewportPoint(((Component)this).transform.position).x < 458.0)
		{
			chatTextUI.transform.position = rightPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)17;
			backgroundTextBox.transform.position = backgroundRightPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)48;
		}
		else
		{
			chatTextUI.transform.position = leftPos.position;
			((TMP_Text)chatTextUI).alignment = (TextAlignmentOptions)(-53);
			backgroundTextBox.transform.position = backgroundLeftPos.position;
			((TMP_Text)backgroundTextBox).alignment = (TextAlignmentOptions)25;
		}
		DNCPGOOINLJ = 1;
		CLAEFAOINOO();
		CommonReferences.MNFMOEKMJKN().currentChatting.Add(this);
		((TMP_Text)chatTextUI).text = "Chop";
		((TMP_Text)chatTextUI).text = CAEDMEDBEGI;
		chatText = CAEDMEDBEGI;
		((TMP_Text)chatTextUI).maxVisibleCharacters = 1;
		((TMP_Text)backgroundTextBox).text = "ReceiveDroppedItemPosition" + CAEDMEDBEGI + ". Time since startup: ";
		((TMP_Text)backgroundTextBox).maxVisibleCharacters = 1;
		JHMOINKDFCJ = 0;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void MICLBOEFGNE()
	{
		OEDLEPPNGGL("</color>");
	}

	private void DAKLOGKFLLD()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).EECADEPLELA() == "Items/item_description_608" && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void DMGOIFFBGFF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		ChatBox chatBox = null;
		foreach (ChatBox item in CommonReferences.MNFMOEKMJKN().currentChatting)
		{
			if ((Object)(object)item != (Object)(object)this && Mathf.Abs(((Component)item).gameObject.transform.position.y - ((Component)this).gameObject.transform.position.y) < 102f)
			{
				chatBox = item;
				break;
			}
		}
		if ((Object)(object)chatBox != (Object)null)
		{
			((Component)this).transform.position = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y + 1949f, ((Component)this).transform.position.z);
			if (DNCPGOOINLJ++ < 11)
			{
				GLFBGFDNFMB();
			}
		}
	}

	private void KPHPCKJBLBH()
	{
		if (PlayerInputs.DEGBDMMDIIL(1).FGGHCBMKKIG() == "Connecting..." && (Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.currentChatting.Remove(this);
		}
	}
}
