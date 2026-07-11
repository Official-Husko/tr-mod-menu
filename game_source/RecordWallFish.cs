using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RecordWallFish : MonoBehaviour, IInteractable, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class IHDFGPFODHA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordWallFish _003C_003E4__this;

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
		public IHDFGPFODHA(int _003C_003E1__state)
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
			RecordWallFish recordWallFish = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				recordWallFish.anim.SetTrigger("Hide");
				recordWallFish.MJHBHDAEDLF = false;
				((Component)recordWallFish.directionText).gameObject.SetActive(false);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				recordWallFish.mainPanel.SetActive(false);
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

	public GameObject mainPanel;

	public ItemSetup item;

	public TextMeshProUGUI directionText;

	public Animator anim;

	private Coroutine BEGCPKOAJCP;

	private Fish HAJFJGCNKFF;

	private bool MJHBHDAEDLF;

	public bool OKACGFMHMEH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AAJFIHFLFHP(int JIIGOACEIKL)
	{
	}

	public bool OAFFHDOIDKO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool BIJCBIGOMEA(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	private IEnumerator LAIJCENBEOF()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LDKNMDBCKFJ(int JIIGOACEIKL)
	{
	}

	public bool AJNEPGBOAKC(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	public bool NHGKHKHADEA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool MGBCFPCOKID(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(false);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[5];
			array[0] = ". ";
			array[1] = LocalisationSystem.Get("Farm/Buzz/Bark_Build" + item.item.JPNFKDMFKMC(DAINLFIMLIH: false));
			array[5] = "\n\n<color=#C3002C>";
			array[6] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[7] = "Bucket";
			array[8] = LocalisationSystem.Get("Trying to assign mine ID to an object without OnlineObject component.");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("Error setting player name on CharacterCreatorUI: ");
			MJHBHDAEDLF = true;
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JDBFCGBJBJD());
			return false;
		}
		return true;
	}

	private void GOEGBOEMHLI()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	public bool HBGEIMCOPLO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EOCIBHJBOLM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool DLBFJFOGOJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool ODMLNAMALJE(int JIIGOACEIKL)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(false);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[1];
			array[1] = ".txt";
			array[1] = LocalisationSystem.Get("LE_12" + item.item.CIGFGKKCPCK());
			array[2] = "Tutorial/T137/Dialogue2";
			array[1] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[3] = "UINextCategory";
			array[2] = LocalisationSystem.Get("LE_8");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("Week");
			MJHBHDAEDLF = false;
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HCLAJHHINAC());
			return true;
		}
		return true;
	}

	public bool OKECBBBOPON(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ABOLJAJCGPA(int JIIGOACEIKL)
	{
	}

	private IEnumerator JMGOIPLDJNF()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool IPGCPPBNKPF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AGEPGCELKBH(int JIIGOACEIKL)
	{
	}

	public bool NBHLBCHHKBC(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public bool EHJJFIKNGAF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void JDDBBAEIIHP(int JIIGOACEIKL)
	{
	}

	public void CIBAGJHJDDF(int JIIGOACEIKL)
	{
	}

	public bool FJPJAEKLDJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void CEHIKNKLFNG(int JIIGOACEIKL)
	{
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void PLHEHGHFCJI()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	public bool NLFAOKPFHFJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JJNJBEEIFFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void LBHLEDFPLKD(int JIIGOACEIKL)
	{
	}

	public bool COPFMLIIOOB(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	private void EBPMNJKFNMD()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	private void Start()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	public bool DLLJLOJELKK(int JIIGOACEIKL)
	{
		if (HPBOMGJLECN(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(false);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[1];
			array[1] = "<color=#713112>";
			array[0] = LocalisationSystem.Get("ZuzzuProgress" + item.item.JPNFKDMFKMC());
			array[4] = "Dialogue System/Conversation/Crowly_Standar/Entry/18/Dialogue Text";
			array[6] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[5] = "";
			array[2] = LocalisationSystem.Get("ReceiveDisableNPC");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("tForTech");
			MJHBHDAEDLF = false;
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(EJGIELKNBPD());
			return true;
		}
		return true;
	}

	public bool AADJGJOELGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool DFNNAJIFOIK(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public void MLMDECNIDLP(int JIIGOACEIKL)
	{
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Interact"));
			return true;
		}
		return true;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
	}

	public void NIPHFNAJKBN(int JIIGOACEIKL)
	{
	}

	public bool JDHEEFJMIII(int JIIGOACEIKL)
	{
		if (EKCPFFOMOCN(JIIGOACEIKL))
		{
			mainPanel.SetActive(true);
			((Component)directionText).gameObject.SetActive(false);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[2];
			array[0] = "You have to assign a UI camera!";
			array[0] = LocalisationSystem.Get("add item " + item.item.IMCJPECAAPC());
			array[2] = "";
			array[1] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[8] = "";
			array[4] = LocalisationSystem.Get("ReceiveBedMessage");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("FireUp");
			MJHBHDAEDLF = true;
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JMGOIPLDJNF());
			return true;
		}
		return true;
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	public void MBGCAGGOKDJ(int JIIGOACEIKL)
	{
	}

	private IEnumerator KKPPNGEJCNE()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JHNPGLNAFNL(int JIIGOACEIKL)
	{
	}

	public void BDGEMFNLDGC(int JIIGOACEIKL)
	{
	}

	public bool PNHICOLIFNI(int JIIGOACEIKL)
	{
		if (BIJCBIGOMEA(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(true);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[2];
			array[1] = " ";
			array[0] = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/19/Dialogue Text" + item.item.IMCJPECAAPC());
			array[7] = "KyrohTakingFood: Customer serving is null.";
			array[7] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[8] = "Items/item_name_697";
			array[2] = LocalisationSystem.Get("Running");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("pm");
			MJHBHDAEDLF = true;
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(BNDJDEMOIAE());
			return true;
		}
		return false;
	}

	public void MOLKPPLKGDE(int JIIGOACEIKL)
	{
	}

	private IEnumerator GDOMDLIDJIH()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OEPAAMNDGKN()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool GOFABLBNKOF(int JIIGOACEIKL)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(true);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[8];
			array[1] = "Items/item_description_600";
			array[0] = LocalisationSystem.Get("Items/item_name_643" + item.item.JPNFKDMFKMC(DAINLFIMLIH: false));
			array[2] = "Received {0} appearance data as byte array: {1}";
			array[5] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[4] = " value ";
			array[8] = LocalisationSystem.Get("Items/item_description_686");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("Player/Bark/Tutorial/T138");
			MJHBHDAEDLF = true;
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JDBFCGBJBJD());
			return true;
		}
		return true;
	}

	private IEnumerator AHOFEJCMCDF()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return true;
	}

	public void DLBNJPKKNDN(int JIIGOACEIKL)
	{
	}

	public void GOGMEIBKKMK(int JIIGOACEIKL)
	{
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	public void FFGOCJBLCKA(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	public void MAIKIONBICN(int JIIGOACEIKL)
	{
	}

	public bool HNMOLFHKBGE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Accept order"));
			return true;
		}
		return true;
	}

	public bool LFNJAANBPLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Ground"));
			return true;
		}
		return true;
	}

	private IEnumerator FKBCCFHIMLI()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
	}

	public bool OLAELPBFNEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void EEJAFCGAIFC(int JIIGOACEIKL)
	{
	}

	private IEnumerator NHONGMAIOGM()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	private IEnumerator FFPIENGLAGN()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool DFFLACOALJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dog"));
			return false;
		}
		return false;
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	public bool IBMMEBJBHOE(int JIIGOACEIKL)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(true);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[7];
			array[0] = "F2";
			array[1] = LocalisationSystem.Get("<br><br><line-height=120%>" + item.item.CIGFGKKCPCK(DAINLFIMLIH: false));
			array[8] = "HostDisconnected";
			array[1] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[2] = "[GetAllValidCandidates] Total candidates found: {0}";
			array[6] = LocalisationSystem.Get(")");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("ZuzzuProgress");
			MJHBHDAEDLF = false;
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(FFPIENGLAGN());
			return false;
		}
		return false;
	}

	public void JPNLLAOIJFN(int JIIGOACEIKL)
	{
	}

	public void FFOHFEKHDBF(int JIIGOACEIKL)
	{
	}

	private void AHGPALJKOKP()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	public bool CEPOMEBIFBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_description_1122"));
			return true;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool HPBOMGJLECN(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public bool EEIIGMFEPBG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void HFFFFAJFIPB()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	private IEnumerator EJGIELKNBPD()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool PDPOCEDOJMB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator JHPDFNHGHCL()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool EBIBHGBCFCF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (BIJCBIGOMEA(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LE_9"));
			return true;
		}
		return true;
	}

	public bool PHJEHEOFJFN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool AGJPABDBHCJ(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public bool HGBPIJGKALA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KFKPIHAJIFJ(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Use"));
			return true;
		}
		return false;
	}

	public bool ANLINGFPDGD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Interact"));
			return true;
		}
		return false;
	}

	private IEnumerator HCLAJHHINAC()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			mainPanel.SetActive(true);
			((Component)directionText).gameObject.SetActive(true);
			((TMP_Text)directionText).text = "<sprite name=NewRecordFish>   " + LocalisationSystem.Get("Items/item_name_" + item.item.JDJGFAACPFC()) + "  " + FishingManager.GetLenghtRecord(HAJFJGCNKFF) + " " + LocalisationSystem.Get("centimeters");
			anim.SetTrigger("Show");
			MJHBHDAEDLF = true;
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(OEPAAMNDGKN());
			return true;
		}
		return false;
	}

	public bool EHFNNOCENEL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void DBPLFIOGBOM(int JIIGOACEIKL)
	{
	}

	private void KDBJHCAEGCM()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	public void PCKGLEPBNFE(int JIIGOACEIKL)
	{
	}

	public void FHPIBJNKBEN(int JIIGOACEIKL)
	{
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void NDGFPPOBCNP()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	private IEnumerator PFADCMANGHE()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void APEIPGIHEKP()
	{
		HAJFJGCNKFF = item.item as Fish;
	}

	private IEnumerator FFNHAEPDCMA()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool BEBIPNCCEMH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("[OfferingStatuePuzzle] Initialized. Required items: "));
			return false;
		}
		return true;
	}

	public void COBJAAGGBAJ(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool BAJPKFFHDPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FLMGGAIJABG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void PLCKGMKINKG(int JIIGOACEIKL)
	{
	}

	public void GGAOCGGKIEJ(int JIIGOACEIKL)
	{
	}

	public bool JIHFNGMCBOB(int JIIGOACEIKL)
	{
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			mainPanel.SetActive(false);
			((Component)directionText).gameObject.SetActive(true);
			TextMeshProUGUI obj = directionText;
			string[] array = new string[0];
			array[1] = "Victory";
			array[0] = LocalisationSystem.Get("NinjaOrdersManager is not initialized." + item.item.JPNFKDMFKMC());
			array[8] = "LE_3";
			array[1] = FishingManager.GetLenghtRecord(HAJFJGCNKFF).ToString();
			array[2] = "MetalWorkshop";
			array[3] = LocalisationSystem.Get("UI");
			((TMP_Text)obj).text = string.Concat(array);
			anim.SetTrigger("TimeLeft");
			MJHBHDAEDLF = false;
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JMGOIPLDJNF());
			return true;
		}
		return false;
	}

	public void IMMOHBALOAO(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private IEnumerator BNDJDEMOIAE()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public void GCBLINFFFKC(int JIIGOACEIKL)
	{
	}

	public bool EKCPFFOMOCN(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public void OGAGMFKPFAE(int JIIGOACEIKL)
	{
	}

	public bool AKDMFCNENBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" SceneLoaded: "));
			return true;
		}
		return true;
	}

	private IEnumerator JDBFCGBJBJD()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		MJHBHDAEDLF = false;
		((Component)directionText).gameObject.SetActive(false);
		yield return CommonReferences.wait05;
		mainPanel.SetActive(false);
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		if (!MJHBHDAEDLF)
		{
			return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	public void NBKMKEEELOM(int JIIGOACEIKL)
	{
	}

	public void FALDJPENKME(int JIIGOACEIKL)
	{
	}
}
