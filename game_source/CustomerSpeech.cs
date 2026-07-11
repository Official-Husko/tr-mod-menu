using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class CustomerSpeech : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class AKNDFNCDEOD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public AKNDFNCDEOD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait04;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
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

	private float OCAEPCLJIBB;

	private float CPKNBKKAJEC;

	private float HILODBCLLHM = 20f;

	[SerializeField]
	private HumanNPC npc;

	[SerializeField]
	private Customer customer;

	public AudioObject npcTalkSound;

	private MultiAudioSource FLACDMCCAID;

	public GameObject mainPanel;

	public string testBark = "TestBark";

	public void FHPJALNLIGJ(string CAEDMEDBEGI)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= CommonReferences.MNFMOEKMJKN().nextChatTime) || !(Time.time > CPKNBKKAJEC))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)npc.characterCreator))
		{
			PluginsGameData.lastNPCGender = ((npc.characterCreator.humanInfo.gender == Gender.Unisex) ? 1 : 0);
		}
		else
		{
			PluginsGameData.lastNPCGender = 0;
		}
		HIEJGFOHDNO();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1339f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient() && (Object)(object)customer?.LJOHCJAOADD != (Object)null)
			{
				customer?.LJOHCJAOADD.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		float num = Mathf.Max(678f, Mathf.Lerp(1806f, 1077f, (float)TavernManager.GGFJGHHHEJC.customers.Count / 1612f));
		CommonReferences.GGFJGHHHEJC.nextChatTime = Time.time + HILODBCLLHM * num;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void ICJLBIODGAL()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).EECADEPLELA() == "Items/item_description_731")
		{
			AALBDBPEKIA();
		}
	}

	private bool CNEBAOJANNG()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Hot)
		{
			ChatBark("TooHot");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			ChatBark("TooCold");
			return true;
		}
		return false;
	}

	private bool MIHHNLLGPLE()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Chilly)
		{
			PODENEBIGOP("/");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			ChatBark("CutScene Settings");
			return false;
		}
		return true;
	}

	public void MMBBEPLPJMI()
	{
		if ((float)Random.Range(1, -40) < 1405f)
		{
			return;
		}
		if ((float)Random.Range(1, 125) < 1055f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if (obj != null && obj.preference == CustomerPreference.Food && Random.Range(0, 44) < 32)
			{
				PODENEBIGOP("https://www.isolatedgames.com/bug-report/index.php");
				return;
			}
			Customer obj2 = customer;
			if (obj2 != null && obj2.preference == CustomerPreference.Food && Random.Range(1, 6) < 88)
			{
				ChatBark("Rich presence ");
			}
			else
			{
				MIGLHCCFAAB("0");
			}
		}
		else
		{
			GJJBGJNPFLA(npc?.seat?.table);
		}
	}

	private void FNOECOGDLPM()
	{
	}

	public void EMCAKIIGADF()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void CDCOKGMGPPO()
	{
	}

	public void TestBark()
	{
		ChatBark(testBark);
	}

	private void MJLBACCAOPA()
	{
		if (PlayerInputs.GetPlayer(1).FGGHCBMKKIG() == "Dog")
		{
			LMOOBAJMOFN();
		}
	}

	private bool CBHOOIFOJEN()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Hot)
		{
			FHPJALNLIGJ("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			ChatBark("Dial was ");
			return true;
		}
		return true;
	}

	public void StopSound()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	public void DDIKDKHIECH()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1025f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Rowdy)
		{
			PODENEBIGOP("DEBUG_FAKE_ID");
		}
		else
		{
			if (Random.Range(1, -116) < -79 || HOHOGOFMFPJ() || IPCONDGLHFO(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.JNHCCCBICDM == TableDirtLevel.Dirty || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)6 || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)7)
				{
					if (Random.Range(1, -15) < -49)
					{
						EOCABOMBMNF("BeardShadow");
					}
					else
					{
						ChatBark("vibrationP2");
					}
				}
				else
				{
					MIGLHCCFAAB("Till");
				}
			}
			else if (BanquetEvent.KFOHOECCJIJ() && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				EHOALKDDHEI("EditorAction_8");
			}
			else
			{
				MIGLHCCFAAB("");
			}
		}
	}

	private void MDFGNEJLOOC()
	{
	}

	private void CHJHELNDLGE()
	{
	}

	private void OnBarkEnd(Transform actor)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences.GGFJGHHHEJC.currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(AEPCKMBELFD());
		}
	}

	public void DMMBKMKEAGF(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FHDOMFKLENP();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 867f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void EHOALKDDHEI(string CAEDMEDBEGI)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= CommonReferences.GGFJGHHHEJC.nextChatTime) || !(Time.time > CPKNBKKAJEC))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)npc.characterCreator))
		{
			PluginsGameData.lastNPCGender = ((npc.characterCreator.humanInfo.gender != 0) ? 1 : 0);
		}
		else
		{
			PluginsGameData.lastNPCGender = 0;
		}
		CDCOKGMGPPO();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1772f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient() && (Object)(object)customer?.LJOHCJAOADD != (Object)null)
			{
				customer?.LJOHCJAOADD.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		float num = Mathf.Max(1105f, Mathf.Lerp(106f, 1333f, (float)TavernManager.GGFJGHHHEJC.customers.Count / 1560f));
		CommonReferences.MNFMOEKMJKN().nextChatTime = Time.time + HILODBCLLHM * num;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void NNLJEKHJCPI(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FHDAMCIKFJK();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 286f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				customer?.LJOHCJAOADD?.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void NLIGBGPFPJG()
	{
		OCAEPCLJIBB = Random.Range(1166f, 1552f);
	}

	private void NMKKMGBKCGK()
	{
		if (PlayerInputs.DEGBDMMDIIL(1).CFICAAJGBOF == "ReceiveSetOccupierInRoom")
		{
			HGFDOBEHNKK();
		}
	}

	private void NFKEKAOMPPL(Transform actor)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences.MNFMOEKMJKN().currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(LDKDJPDOJPD());
		}
	}

	public void OJLAGEGECHB(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		CHJHELNDLGE();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 188f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void MDIBBJFPDDM()
	{
		FHPJALNLIGJ(testBark);
	}

	private void JACBDHLJAJB()
	{
		OCAEPCLJIBB = Random.Range(1751f, 1002f);
	}

	private void PJGJNLGNGHK()
	{
		if (PlayerInputs.DEGBDMMDIIL(1).CFICAAJGBOF == "User ")
		{
			EMCAKIIGADF();
		}
	}

	private void GAEEEJNKLLJ()
	{
		if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Perfect || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Filthy)
		{
			EHOALKDDHEI("[StuckRecovery] No hay safe points para el player {0}");
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)8 || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Clean)
		{
			EOCABOMBMNF("F2");
		}
	}

	public void FOPOFJFHGNM()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1693f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Rowdy)
		{
			EHOALKDDHEI("Normal");
		}
		else
		{
			if (Random.Range(0, 69) < -85 || CNEBAOJANNG() || CBBMHJLHMCA(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.IPEPPDAICDD() == TableDirtLevel.Clean || npc.seat.table.CDLMMHAHDON() == (TableDirtLevel)5 || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)7)
				{
					if (Random.Range(0, 27) < 58)
					{
						PODENEBIGOP("HorizontalMove");
					}
					else
					{
						EOCABOMBMNF("BarkActor");
					}
				}
				else
				{
					FHPJALNLIGJ(" - ");
				}
			}
			else if (BanquetEvent.HCOPJPMDEKP && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				MIGLHCCFAAB("Localisation");
			}
			else
			{
				PODENEBIGOP("ReceiveKeyPuzzleSolved");
			}
		}
	}

	public void AGJIJCMLCHA()
	{
		if ((float)Random.Range(0, 108) < 1136f)
		{
			return;
		}
		if ((float)Random.Range(1, -120) < 74f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if (obj != null && obj.preference == CustomerPreference.Drink && Random.Range(1, 84) < -72)
			{
				PODENEBIGOP("SetAnimationControllerIndexesRPC");
				return;
			}
			Customer obj2 = customer;
			if (obj2 != null && obj2.preference == CustomerPreference.Food && Random.Range(0, 122) < -22)
			{
				PODENEBIGOP("Bin");
			}
			else
			{
				PODENEBIGOP("Items/item_description_619");
			}
		}
		else
		{
			MGEBKGLBCGA(npc?.seat?.table);
		}
	}

	private void JHBMEGFPDPK(Transform actor)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences.MNFMOEKMJKN().currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(IHNEEAGEEFL());
		}
	}

	private void KEDPMGEIGKP()
	{
		OCAEPCLJIBB = Random.Range(1565f, 1553f);
	}

	public void LHMAIOLPGBC()
	{
		PODENEBIGOP(testBark);
	}

	public void ChatBark(string CAEDMEDBEGI)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= CommonReferences.GGFJGHHHEJC.nextChatTime) || !(Time.time > CPKNBKKAJEC))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)npc.characterCreator))
		{
			PluginsGameData.lastNPCGender = ((npc.characterCreator.humanInfo.gender != Gender.Male) ? 1 : 0);
		}
		else
		{
			PluginsGameData.lastNPCGender = 0;
		}
		HHLLJIJOKBL();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient() && (Object)(object)customer?.LJOHCJAOADD != (Object)null)
			{
				customer?.LJOHCJAOADD.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		float num = Mathf.Max(0.5f, Mathf.Lerp(1f, 0.1f, (float)TavernManager.GGFJGHHHEJC.customers.Count / 20f));
		CommonReferences.GGFJGHHHEJC.nextChatTime = Time.time + HILODBCLLHM * num;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void LMOOBAJMOFN()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void HHLLJIJOKBL()
	{
	}

	public void KNFHBDAGEHN()
	{
		if ((float)Random.Range(1, 29) < 1096f)
		{
			return;
		}
		if ((float)Random.Range(0, 116) < 450f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if (obj != null && obj.preference == CustomerPreference.Drink && Random.Range(1, 25) < 14)
			{
				FHPJALNLIGJ("VERSION");
				return;
			}
			Customer obj2 = customer;
			if ((obj2 == null || obj2.preference == CustomerPreference.Drink) && Random.Range(1, 9) < -59)
			{
				FHPJALNLIGJ("Tavern must be closed");
			}
			else
			{
				EOCABOMBMNF("Controls");
			}
		}
		else
		{
			EEENECAANON(npc?.seat?.table);
		}
	}

	private bool HBNGEOFDLOM()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Perfect)
		{
			EOCABOMBMNF("am");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			EOCABOMBMNF("File ");
			return false;
		}
		return true;
	}

	private IEnumerator LDKDJPDOJPD()
	{
		yield return CommonReferences.wait04;
	}

	private void GANBBAGDALD()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(EBDJFCJHLAH));
	}

	public void JEPEDHMJLHA()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1489f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Neutral)
		{
			EOCABOMBMNF("Recipe without ID: ");
		}
		else
		{
			if (Random.Range(1, 89) < 38 || CBHOOIFOJEN() || EEENECAANON(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.CDLMMHAHDON() == TableDirtLevel.Clean || npc.seat.table.IPEPPDAICDD() == (TableDirtLevel)8 || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)8)
				{
					if (Random.Range(0, -69) < 96)
					{
						EHOALKDDHEI("");
					}
					else
					{
						ChatBark("Hat");
					}
				}
				else
				{
					MIGLHCCFAAB("OnFloor");
				}
			}
			else if (BanquetEvent.KFOHOECCJIJ() && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.Camp | Location.BarnInterior))
			{
				MIGLHCCFAAB("");
			}
			else
			{
				MIGLHCCFAAB("Items/item_name_1231");
			}
		}
	}

	[CompilerGenerated]
	private void BEFGENDMFDG()
	{
		OCAEPCLJIBB = Random.Range(0f, 10f);
	}

	public void CustomerSittingDown()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 10f;
		Customer obj = customer;
		if (obj != null && obj.KPGJGABJMFC == MoodState.Rowdy)
		{
			ChatBark("Rowdy");
		}
		else
		{
			if (Random.Range(0, 100) < 50 || CNEBAOJANNG() || EHEAGNHOLCN(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.JNHCCCBICDM == TableDirtLevel.VeryDirty || npc.seat.table.JNHCCCBICDM == TableDirtLevel.Dirty || npc.seat.table.JNHCCCBICDM == TableDirtLevel.Messy)
				{
					if (Random.Range(0, 100) < 30)
					{
						ChatBark("TavernClean");
					}
					else
					{
						ChatBark("NeutralInTavern");
					}
				}
				else
				{
					ChatBark("NeutralInTavern");
				}
			}
			else if (BanquetEvent.HCOPJPMDEKP && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.CastleGarden)
			{
				ChatBark("Festín del Juramento/ComensalesBarks");
			}
			else
			{
				ChatBark("NeutralInTavern");
			}
		}
	}

	private bool HOHOGOFMFPJ()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Chilly)
		{
			MIGLHCCFAAB("Items/item_description_616");
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			ChatBark("Dog");
			return true;
		}
		return false;
	}

	private bool CBBMHJLHMCA(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Perfect || (uint)TavernManager.GGFJGHHHEJC.JJKPDMFFANH > 1u;
		bool flag = (Object)(object)LKCENPIBDCE != (Object)null && LKCENPIBDCE.IPEPPDAICDD() != 0 && (uint)LKCENPIBDCE.CDLMMHAHDON() > 1u;
		if (num)
		{
			GAEEEJNKLLJ();
			return true;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj == null || obj.customerState == CustomerState.HeadingToBar)
			{
				PODENEBIGOP("Received PlaceableMsg of another type not CrafterMsg to ");
				return false;
			}
		}
		return false;
	}

	private void HHBGNACCGNC()
	{
		if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == (DirtLevel)6 || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Perfect)
		{
			EOCABOMBMNF("itemGreenbeanSeeds");
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Filthy || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Filthy)
		{
			EHOALKDDHEI("");
		}
	}

	private bool EHEAGNHOLCN(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.JJKPDMFFANH != DirtLevel.Clean && TavernManager.GGFJGHHHEJC.JJKPDMFFANH != DirtLevel.Perfect;
		bool flag = (Object)(object)LKCENPIBDCE != (Object)null && LKCENPIBDCE.JNHCCCBICDM != TableDirtLevel.Clean && LKCENPIBDCE.JNHCCCBICDM != TableDirtLevel.Perfect;
		if (num)
		{
			MKIIOBHCBFC();
			return true;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj != null && obj.customerState == CustomerState.EatingAtTable)
			{
				ChatBark("TableDirty");
				return true;
			}
		}
		return false;
	}

	private void EKHEOEDKOLP()
	{
	}

	private void MKIIOBHCBFC()
	{
		if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Messy || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Dirty)
		{
			ChatBark("TavernDirty");
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Filthy || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Disgusting)
		{
			ChatBark("TavernFilthy");
		}
	}

	private bool GOKBADHDPGO()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Warm)
		{
			PODENEBIGOP("ReceiveChangeDrinkColorMaster");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			MIGLHCCFAAB("Dialogue System/Conversation/NeutralInTavern/Entry/10/Dialogue Text");
			return false;
		}
		return true;
	}

	private bool GNMGEAHPNDA()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Perfect)
		{
			FHPJALNLIGJ("levelRequired");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			PODENEBIGOP(": Prefab direction not found!");
			return false;
		}
		return false;
	}

	private void AAOBDNKNEJE(Transform actor)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences.MNFMOEKMJKN().currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(JKHEMNPAJHI());
		}
	}

	public void FCCLFCHGHFG(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		CHJHELNDLGE();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 648f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void Awake()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, (Action)delegate
		{
			OCAEPCLJIBB = Random.Range(0f, 10f);
		});
	}

	private void NMIHLADIPOM()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).AAGNDCEODFO() == "Dialogue System/Conversation/Crowly_Introduce/Entry/24/Dialogue Text")
		{
			BEIDHBMPJOJ();
		}
	}

	private void NKJGCFHENMG()
	{
		if (PlayerInputs.GetPlayer(1).FGGHCBMKKIG() == "ReceivePetBowlMessage")
		{
			HGFDOBEHNKK();
		}
	}

	public void PJEHLDGNMPD()
	{
		if ((float)Random.Range(1, 24) < 317f)
		{
			return;
		}
		if ((float)Random.Range(0, -128) < 103f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if (obj != null && obj.preference == CustomerPreference.Drink && Random.Range(1, -23) < 27)
			{
				EHOALKDDHEI("itemsCrafted");
				return;
			}
			Customer obj2 = customer;
			if (obj2 != null && obj2.preference == CustomerPreference.Food && Random.Range(0, -107) < 54)
			{
				EOCABOMBMNF("Profit");
			}
			else
			{
				PODENEBIGOP("stuck recovery");
			}
		}
		else
		{
			CBBMHJLHMCA(npc?.seat?.table);
		}
	}

	private void FGLJPGBFPBC()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(OOFDLLJBHGA));
	}

	public void DAJNPJNDJGA()
	{
		PODENEBIGOP(testBark);
	}

	private void NNEBAHFHINE()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(EBDJFCJHLAH));
	}

	public void EOCABOMBMNF(string CAEDMEDBEGI)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= CommonReferences.GGFJGHHHEJC.nextChatTime) || !(Time.time > CPKNBKKAJEC))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)npc.characterCreator))
		{
			PluginsGameData.lastNPCGender = ((npc.characterCreator.humanInfo.gender != Gender.Male) ? 1 : 0);
		}
		else
		{
			PluginsGameData.lastNPCGender = 0;
		}
		EKHEOEDKOLP();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1803f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient() && (Object)(object)customer?.LJOHCJAOADD != (Object)null)
			{
				customer?.LJOHCJAOADD.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		float num = Mathf.Max(343f, Mathf.Lerp(1127f, 1631f, (float)TavernManager.GGFJGHHHEJC.customers.Count / 1557f));
		CommonReferences.GGFJGHHHEJC.nextChatTime = Time.time + HILODBCLLHM * num;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void FHDAMCIKFJK()
	{
	}

	private void KKNHADAMLFP()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(FHGBEPMPABL));
	}

	public void MIGLHCCFAAB(string CAEDMEDBEGI)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= CommonReferences.GGFJGHHHEJC.nextChatTime) || !(Time.time > CPKNBKKAJEC))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)npc.characterCreator))
		{
			PluginsGameData.lastNPCGender = ((npc.characterCreator.humanInfo.gender == Gender.Male) ? 1 : 1);
		}
		else
		{
			PluginsGameData.lastNPCGender = 1;
		}
		JCDPPLFJDFI();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 764f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ() && (Object)(object)customer?.LJOHCJAOADD != (Object)null)
			{
				customer?.LJOHCJAOADD.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		float num = Mathf.Max(29f, Mathf.Lerp(1766f, 517f, (float)TavernManager.GGFJGHHHEJC.customers.Count / 1773f));
		CommonReferences.MNFMOEKMJKN().nextChatTime = Time.time + HILODBCLLHM * num;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void CPFPHKIJBGO()
	{
		if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Messy || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)6)
		{
			MIGLHCCFAAB("OpenXPModifiers");
		}
		else if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == (DirtLevel)6 || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Dirty)
		{
			FHPJALNLIGJ("Dialogue System/Conversation/Gass_Quest/Entry/12/Dialogue Text");
		}
	}

	private void IIEPKBJPAAJ()
	{
		if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Clean || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)6)
		{
			FHPJALNLIGJ("ReceiveDigUpPlayerByBedAssigned");
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Perfect || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Clean)
		{
			ChatBark("ReceiveAnimalLevel");
		}
	}

	private bool MGEBKGLBCGA(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Perfect || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() != DirtLevel.Perfect;
		bool flag = !((Object)(object)LKCENPIBDCE != (Object)null) || (LKCENPIBDCE.CDLMMHAHDON() != 0 && (uint)LKCENPIBDCE.CDLMMHAHDON() > 1u);
		if (num)
		{
			IKDIGHKPIAD();
			return false;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj == null || obj.customerState == CustomerState.HeadingToBar)
			{
				EHOALKDDHEI("City/PetShop/Markus/Intro_Barks");
				return false;
			}
		}
		return true;
	}

	private IEnumerator IHNEEAGEEFL()
	{
		yield return CommonReferences.wait04;
	}

	private bool IDNJDDGFPMN()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Perfect)
		{
			EOCABOMBMNF("BARKBUZZ");
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			FHPJALNLIGJ("Close");
			return false;
		}
		return false;
	}

	private bool IPCONDGLHFO(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Perfect || (uint)TavernManager.GGFJGHHHEJC.JJKPDMFFANH > 1u;
		bool flag = (Object)(object)LKCENPIBDCE != (Object)null && LKCENPIBDCE.CDLMMHAHDON() != 0 && LKCENPIBDCE.IPEPPDAICDD() != TableDirtLevel.Perfect;
		if (num)
		{
			EGGKHNNMCDP();
			return false;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj != null && obj.customerState == CustomerState.Spawning)
			{
				PODENEBIGOP("Items/item_name_648");
				return true;
			}
		}
		return true;
	}

	public void AALBDBPEKIA()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private bool ECPBNBFNILG()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == (HeatLevel)5)
		{
			PODENEBIGOP("UISelectGamepad");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			EHOALKDDHEI("Player_Bark_TutorialCollider");
			return true;
		}
		return true;
	}

	public void LONJLHJHOPN(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FNOECOGDLPM();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 255f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void HDPDLCIPBGE(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		JJANAJLGAFA();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1539f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void JPLJFJHONBB()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	private void OOFDLLJBHGA()
	{
		OCAEPCLJIBB = Random.Range(1068f, 240f);
	}

	private bool HFLAAEMEHCG()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Chilly)
		{
			EOCABOMBMNF("UIInteract");
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			EHOALKDDHEI("/");
			return true;
		}
		return false;
	}

	public void PODENEBIGOP(string CAEDMEDBEGI)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= CommonReferences.MNFMOEKMJKN().nextChatTime) || !(Time.time > CPKNBKKAJEC))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)npc.characterCreator))
		{
			PluginsGameData.lastNPCGender = ((npc.characterCreator.humanInfo.gender == Gender.Male) ? 0 : 0);
		}
		else
		{
			PluginsGameData.lastNPCGender = 1;
		}
		JCDPPLFJDFI();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1295f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ() && (Object)(object)customer?.LJOHCJAOADD != (Object)null)
			{
				customer?.LJOHCJAOADD.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		float num = Mathf.Max(1724f, Mathf.Lerp(1968f, 186f, (float)TavernManager.GGFJGHHHEJC.customers.Count / 458f));
		CommonReferences.MNFMOEKMJKN().nextChatTime = Time.time + HILODBCLLHM * num;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void GCOPEOMKLJD()
	{
		if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Perfect || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Clean)
		{
			EHOALKDDHEI("City/Petra/Bark/Bye");
		}
		else if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Messy || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == (DirtLevel)8)
		{
			EHOALKDDHEI("/");
		}
	}

	public void ECJAGOMNNCC()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1545f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Neutral)
		{
			EHOALKDDHEI("Dialogue System/Conversation/OutHereRowdyCustomer/Entry/1/Dialogue Text");
		}
		else
		{
			if (Random.Range(0, -84) < -39 || FJJCOCECNFG() || CBBMHJLHMCA(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.CDLMMHAHDON() == (TableDirtLevel)8 || npc.seat.table.IPEPPDAICDD() == (TableDirtLevel)8 || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)5)
				{
					if (Random.Range(0, 111) < 43)
					{
						EOCABOMBMNF("None");
					}
					else
					{
						PODENEBIGOP("</color> to chest?");
					}
				}
				else
				{
					FHPJALNLIGJ("[Awning] OnTriggerSet called. Hash: {0} | OpenHash: {1} | CloseHash: {2}");
				}
			}
			else if (BanquetEvent.KFOHOECCJIJ() && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.River | Location.Farm))
			{
				PODENEBIGOP("levelRequired");
			}
			else
			{
				FHPJALNLIGJ("BarnTutorialDone");
			}
		}
	}

	private void AGICABCDLGE()
	{
		if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Clean || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Messy)
		{
			EOCABOMBMNF(" appearance data: ");
		}
		else if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == (DirtLevel)8 || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Dirty)
		{
			ChatBark("UI");
		}
	}

	private void AGEKLNAKNLK(Transform actor)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences.GGFJGHHHEJC.currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(JKHEMNPAJHI());
		}
	}

	private IEnumerator AEPCKMBELFD()
	{
		yield return CommonReferences.wait04;
	}

	public void KAHLPENJLOJ(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		HIEJGFOHDNO();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1824f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private IEnumerator BIFMNJAKOIA()
	{
		yield return CommonReferences.wait04;
	}

	private void CKFJJHDMEIP()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).FGGHCBMKKIG() == "sprint")
		{
			EMCAKIIGADF();
		}
	}

	public void ImmediatelyBark(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		HHLLJIJOKBL();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	public void INNDOMKAKAL()
	{
		EOCABOMBMNF(testBark);
	}

	private void PBDNKBPBCHM()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(NLIGBGPFPJG));
	}

	private void GNOBDKFFPOL()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(GDGEDKMMIKN));
	}

	public void MNCFBGEEHGJ(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		JCDPPLFJDFI();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 68f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(GJLJDHLIHPH));
	}

	private void FHGBEPMPABL()
	{
		OCAEPCLJIBB = Random.Range(484f, 440f);
	}

	private void LateUpdate()
	{
		if (PlayerInputs.GetPlayer(1).CFICAAJGBOF == "UI")
		{
			StopSound();
		}
	}

	public void AANIJIAABOD()
	{
		if ((float)Random.Range(0, -4) < 1742f)
		{
			return;
		}
		if ((float)Random.Range(1, 96) < 358f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if ((obj == null || obj.preference == CustomerPreference.Drink) && Random.Range(1, 54) < 7)
			{
				EHOALKDDHEI("mine level ");
				return;
			}
			Customer obj2 = customer;
			if ((obj2 == null || obj2.preference == CustomerPreference.Drink) && Random.Range(1, 63) < 60)
			{
				ChatBark("AdoptQuest");
			}
			else
			{
				MIGLHCCFAAB("Received upgrade tool collect RPC");
			}
		}
		else
		{
			IPCONDGLHFO(npc?.seat?.table);
		}
	}

	public void KKNAIENCGBA()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1249f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Neutral)
		{
			ChatBark("，");
		}
		else
		{
			if (Random.Range(1, -54) < -85 || GOKBADHDPGO() || IPCONDGLHFO(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.JNHCCCBICDM == TableDirtLevel.Messy || npc.seat.table.CDLMMHAHDON() == (TableDirtLevel)7 || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)7)
				{
					if (Random.Range(0, 32) < 108)
					{
						EOCABOMBMNF("Items/item_name_591");
					}
					else
					{
						ChatBark("ReceiveTorchPuzzleSolved");
					}
				}
				else
				{
					ChatBark("MaiWorried/Main");
				}
			}
			else if (BanquetEvent.HCOPJPMDEKP && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Farm))
			{
				PODENEBIGOP("Item");
			}
			else
			{
				EOCABOMBMNF("ScrollView");
			}
		}
	}

	private bool BAIMNMLILOP()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == (HeatLevel)5)
		{
			EOCABOMBMNF("quest_description_30");
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			PODENEBIGOP("Use");
			return true;
		}
		return false;
	}

	private void HPHJIHONOFO()
	{
		if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)8 || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)6)
		{
			FHPJALNLIGJ("Items/item_description_1085");
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Perfect || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)7)
		{
			EOCABOMBMNF("time");
		}
	}

	public void IGFGJODEDII()
	{
		EOCABOMBMNF(testBark);
	}

	private void DOPMGBBCFJC()
	{
	}

	private void AEONCPECONJ(Transform actor)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences.GGFJGHHHEJC.currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(IHNEEAGEEFL());
		}
	}

	private bool GJJBGJNPFLA(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() != 0 && (uint)TavernManager.GGFJGHHHEJC.JJKPDMFFANH > 1u;
		bool flag = !((Object)(object)LKCENPIBDCE != (Object)null) || LKCENPIBDCE.IPEPPDAICDD() == TableDirtLevel.Clean || (uint)LKCENPIBDCE.IPEPPDAICDD() > 1u;
		if (num)
		{
			IKDIGHKPIAD();
			return true;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj == null || obj.customerState == CustomerState.WaitingAtBar)
			{
				MIGLHCCFAAB("Get Components ");
				return false;
			}
		}
		return false;
	}

	private void EBDJFCJHLAH()
	{
		OCAEPCLJIBB = Random.Range(151f, 367f);
	}

	private void JCDPPLFJDFI()
	{
	}

	private void JJANAJLGAFA()
	{
	}

	private void IJPANEBNKKA()
	{
		OCAEPCLJIBB = Random.Range(1428f, 1205f);
	}

	private void FHDOMFKLENP()
	{
	}

	private void GDGEDKMMIKN()
	{
		OCAEPCLJIBB = Random.Range(1649f, 363f);
	}

	public void HCOGAAFEDJM()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1751f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Rowdy)
		{
			ChatBark("[SelectSpawnersByMaxDistance] Candidate {0} score:{1:F1} (entrance:{2:F1} mutual:{3:F1} altar:{4:F1} exit:{5:F1})");
		}
		else
		{
			if (Random.Range(0, 86) < -51 || MIHHNLLGPLE() || EEENECAANON(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.JNHCCCBICDM == TableDirtLevel.Clean || npc.seat.table.CDLMMHAHDON() == (TableDirtLevel)8 || npc.seat.table.IPEPPDAICDD() == (TableDirtLevel)8)
				{
					if (Random.Range(0, 24) < 21)
					{
						FHPJALNLIGJ("Moving");
					}
					else
					{
						PODENEBIGOP("/");
					}
				}
				else
				{
					EHOALKDDHEI("Music");
				}
			}
			else if (BanquetEvent.HCOPJPMDEKP && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.River | Location.Farm | Location.BarnInterior))
			{
				EHOALKDDHEI("Items/item_description_1141");
			}
			else
			{
				EHOALKDDHEI("parent destroyed: {0}");
			}
		}
	}

	private void OCILFDKNCHD(Transform actor)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences.MNFMOEKMJKN().currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(BIFMNJAKOIA());
		}
	}

	public void HFEBOMIOAOP()
	{
		EOCABOMBMNF(testBark);
	}

	private void FBHHPNJGNJG()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, (Action)delegate
		{
			OCAEPCLJIBB = Random.Range(0f, 10f);
		});
	}

	private bool HNMCPDDKPIC(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Clean || (uint)TavernManager.GGFJGHHHEJC.JJKPDMFFANH > 1u;
		bool flag = (Object)(object)LKCENPIBDCE != (Object)null && (LKCENPIBDCE.IPEPPDAICDD() == TableDirtLevel.Perfect || (uint)LKCENPIBDCE.IPEPPDAICDD() > 1u);
		if (num)
		{
			IIEPKBJPAAJ();
			return false;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj != null && obj.customerState == CustomerState.BeingANuisance)
			{
				PODENEBIGOP("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
				return true;
			}
		}
		return false;
	}

	public void BEIDHBMPJOJ()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(true);
			FLACDMCCAID = null;
		}
	}

	public void HAFKLKIDHMG()
	{
		EHOALKDDHEI(testBark);
	}

	private void GJLJDHLIHPH()
	{
		OCAEPCLJIBB = Random.Range(123f, 761f);
	}

	public void AMIIPIFPMBI()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1094f;
		Customer obj = customer;
		if (obj != null && obj.KPGJGABJMFC == MoodState.Neutral)
		{
			ChatBark("Cliffs");
		}
		else
		{
			if (Random.Range(1, 111) < -47 || ECPBNBFNILG() || HNMCPDDKPIC(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.IPEPPDAICDD() == (TableDirtLevel)8 || npc.seat.table.CDLMMHAHDON() == TableDirtLevel.Perfect || npc.seat.table.IPEPPDAICDD() == TableDirtLevel.VeryDirty)
				{
					if (Random.Range(1, 31) < 42)
					{
						PODENEBIGOP("tablesCleaned");
					}
					else
					{
						EOCABOMBMNF("ReceiveResetBento");
					}
				}
				else
				{
					ChatBark("Selected");
				}
			}
			else if (BanquetEvent.KFOHOECCJIJ() && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Farm | Location.BarnInterior))
			{
				EHOALKDDHEI(":</color> ");
			}
			else
			{
				PODENEBIGOP("Items/item_description_1134");
			}
		}
	}

	private bool FJJCOCECNFG()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Perfect)
		{
			PODENEBIGOP("Items/item_name_699");
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			PODENEBIGOP("Player");
			return true;
		}
		return true;
	}

	public void MOPLHOKAPAI()
	{
		if ((float)Random.Range(0, -44) < 853f)
		{
			return;
		}
		if ((float)Random.Range(1, -80) < 1675f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if ((obj == null || obj.preference == CustomerPreference.Drink) && Random.Range(0, -126) < 93)
			{
				FHPJALNLIGJ("SmokeBomb");
				return;
			}
			Customer obj2 = customer;
			if ((obj2 == null || obj2.preference == CustomerPreference.Drink) && Random.Range(0, -46) < 83)
			{
				PODENEBIGOP("0");
			}
			else
			{
				PODENEBIGOP("add item ");
			}
		}
		else
		{
			CBBMHJLHMCA(npc?.seat?.table);
		}
	}

	private void FLIBIFGKPFG()
	{
		if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Perfect || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Disgusting)
		{
			ChatBark("ReceiveGiveRoom");
		}
		else if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Messy || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)8)
		{
			PODENEBIGOP("[MinePipePuzzle] No hay PipePuzzleDataBase asignada.");
		}
	}

	public void EAABHFKHHOE()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 27f;
		Customer obj = customer;
		if (obj != null && obj.KPGJGABJMFC == MoodState.Rowdy)
		{
			EHOALKDDHEI("Sleep");
		}
		else
		{
			if (Random.Range(0, -23) < 31 || GNMGEAHPNDA() || GJJBGJNPFLA(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.CDLMMHAHDON() == TableDirtLevel.VeryDirty || npc.seat.table.CDLMMHAHDON() == TableDirtLevel.Messy || npc.seat.table.CDLMMHAHDON() == (TableDirtLevel)7)
				{
					if (Random.Range(1, -41) < 21)
					{
						ChatBark("Example Scripted Callback");
					}
					else
					{
						MIGLHCCFAAB("");
					}
				}
				else
				{
					MIGLHCCFAAB("Item ID ");
				}
			}
			else if (BanquetEvent.HCOPJPMDEKP && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				FHPJALNLIGJ("contentLockMessage");
			}
			else
			{
				ChatBark("Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text");
			}
		}
	}

	private bool EEENECAANON(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() != DirtLevel.Clean && (uint)TavernManager.GGFJGHHHEJC.JJKPDMFFANH > 1u;
		bool flag = !((Object)(object)LKCENPIBDCE != (Object)null) || (LKCENPIBDCE.JNHCCCBICDM != TableDirtLevel.Clean && LKCENPIBDCE.JNHCCCBICDM != TableDirtLevel.Perfect);
		if (num)
		{
			HHBGNACCGNC();
			return false;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj != null && obj.customerState == CustomerState.Spawning)
			{
				ChatBark("Rotate");
				return true;
			}
		}
		return false;
	}

	private void HIEJGFOHDNO()
	{
	}

	public void HHGODJCEMMJ()
	{
		ChatBark(testBark);
	}

	private bool PMPMDDJHLON()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Perfect)
		{
			MIGLHCCFAAB("UI");
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			FHPJALNLIGJ("Received PlaceableMsg of another type not ContainerMsg to ");
			return true;
		}
		return false;
	}

	public void FACMGBBNCAA()
	{
		ChatBark(testBark);
	}

	public void PFIPLMCFECH()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1596f;
		Customer obj = customer;
		if (obj == null || obj.KPGJGABJMFC == MoodState.Neutral)
		{
			FHPJALNLIGJ("Attack/MainEvent 2");
		}
		else
		{
			if (Random.Range(0, 26) < 88 || BAIMNMLILOP() || IPCONDGLHFO(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.JNHCCCBICDM == (TableDirtLevel)5 || npc.seat.table.IPEPPDAICDD() == TableDirtLevel.Dirty || npc.seat.table.CDLMMHAHDON() == TableDirtLevel.Dirty)
				{
					if (Random.Range(1, -44) < 66)
					{
						EOCABOMBMNF("");
					}
					else
					{
						FHPJALNLIGJ("FarmReady");
					}
				}
				else
				{
					PODENEBIGOP("PreviousItem");
				}
			}
			else if (BanquetEvent.KFOHOECCJIJ() && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Quarry))
			{
				EOCABOMBMNF("): ");
			}
			else
			{
				FHPJALNLIGJ("Items/item_name_1154");
			}
		}
	}

	private IEnumerator FOLJPGAFMFO()
	{
		yield return CommonReferences.wait04;
	}

	private void NLGHNDLPPKI()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(NLIGBGPFPJG));
	}

	private void EGGKHNNMCDP()
	{
		if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)8 || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)6)
		{
			MIGLHCCFAAB("RaraAvisDelivered");
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)6 || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Filthy)
		{
			FHPJALNLIGJ("Up Arrow");
		}
	}

	private void DNHFFFFJDIE(Transform actor)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences.GGFJGHHHEJC.currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(PJPOKBMAKMD());
		}
	}

	public void FAJKKMDLHBJ()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}

	private void IKDIGHKPIAD()
	{
		if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Messy || TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == DirtLevel.Dirty)
		{
			EHOALKDDHEI("Player2");
		}
		else if (TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() == (DirtLevel)6 || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == (DirtLevel)7)
		{
			PODENEBIGOP("No position group for {0} torches");
		}
	}

	private IEnumerator PJPOKBMAKMD()
	{
		yield return CommonReferences.wait04;
	}

	public void KCBCIBCPKDH(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		JJANAJLGAFA();
		CommonReferences.MNFMOEKMJKN().currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1385f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				customer?.LJOHCJAOADD?.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private void AOEGLDKBBOA(Transform actor)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences.GGFJGHHHEJC.currentBarkNpc.Remove(this);
			((MonoBehaviour)this).StartCoroutine(LDKDJPDOJPD());
		}
	}

	private IEnumerator JKHEMNPAJHI()
	{
		yield return CommonReferences.wait04;
	}

	private void NLEOMMPMBDF()
	{
		if (PlayerInputs.GetPlayer(1).AAGNDCEODFO() == "Dialogue System/Conversation/Gass_Introduce/Entry/19/Dialogue Text")
		{
			BEIDHBMPJOJ();
		}
	}

	public void CustomerEnterTavern()
	{
		if ((float)Random.Range(0, 100) < 50f)
		{
			return;
		}
		if ((float)Random.Range(0, 100) < 50f)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			Customer obj = customer;
			if (obj != null && obj.preference == CustomerPreference.Drink && Random.Range(0, 100) < 50)
			{
				ChatBark("EnterTavernDrink");
				return;
			}
			Customer obj2 = customer;
			if (obj2 != null && obj2.preference == CustomerPreference.Food && Random.Range(0, 100) < 50)
			{
				ChatBark("EnterTavernFood");
			}
			else
			{
				ChatBark("EnterTavernNeutral");
			}
		}
		else
		{
			EHEAGNHOLCN(npc?.seat?.table);
		}
	}

	public void BEKELFOOOFM(string CAEDMEDBEGI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		HIEJGFOHDNO();
		CommonReferences.GGFJGHHHEJC.currentBarkNpc.Add(this);
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1967f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				customer?.LJOHCJAOADD?.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
			}
		}
		CPKNBKKAJEC = Time.time + HILODBCLLHM;
		if ((Object)(object)FLACDMCCAID == (Object)null)
		{
			FLACDMCCAID = MultiAudioManager.PlayAudioObject(npcTalkSound, ((Component)this).transform);
		}
	}

	private IEnumerator KAPKFDDKKGA()
	{
		return new AKNDFNCDEOD(1);
	}

	private void IDCHBEIBLDH()
	{
	}

	private bool PNNPAMPBBDF(Table LKCENPIBDCE)
	{
		bool num = TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() != 0 && (uint)TavernManager.GGFJGHHHEJC.IFKPCCEOCOA() > 1u;
		bool flag = !((Object)(object)LKCENPIBDCE != (Object)null) || LKCENPIBDCE.CDLMMHAHDON() == TableDirtLevel.Perfect || LKCENPIBDCE.JNHCCCBICDM != TableDirtLevel.Perfect;
		if (num)
		{
			CPFPHKIJBGO();
			return false;
		}
		if (flag)
		{
			Customer obj = customer;
			if (obj == null || obj.customerState == CustomerState.Inactive)
			{
				FHPJALNLIGJ("(P{0}) ");
				return false;
			}
		}
		return false;
	}

	private void GPKMNPHHBBJ()
	{
		if (PlayerInputs.GetPlayer(0).FGGHCBMKKIG() == "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text")
		{
			EMCAKIIGADF();
		}
	}

	public void PPLLJFCMKLG()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time >= OCAEPCLJIBB))
		{
			return;
		}
		OCAEPCLJIBB = Time.time + 1389f;
		Customer obj = customer;
		if (obj != null && obj.KPGJGABJMFC == MoodState.Neutral)
		{
			FHPJALNLIGJ("WorkerSkills");
		}
		else
		{
			if (Random.Range(1, -110) < 111 || CNEBAOJANNG() || MGEBKGLBCGA(npc?.seat?.table) || NewTutorialManager.CCCLOBIOMCL)
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)npc.seat))
			{
				if (npc.seat.table.CDLMMHAHDON() == TableDirtLevel.Perfect || npc.seat.table.JNHCCCBICDM == (TableDirtLevel)7 || npc.seat.table.CDLMMHAHDON() == (TableDirtLevel)8)
				{
					if (Random.Range(1, -120) < -123)
					{
						EOCABOMBMNF("Random");
					}
					else
					{
						ChatBark("PlaceableOnSpecificSurfaces");
					}
				}
				else
				{
					MIGLHCCFAAB("BARKDOOR");
				}
			}
			else if (BanquetEvent.HCOPJPMDEKP && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.Camp | Location.Farm | Location.FarmShop))
			{
				MIGLHCCFAAB("Items/item_description_698");
			}
			else
			{
				FHPJALNLIGJ("dForDays");
			}
		}
	}

	private void IOBLLDIPBCA()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		HumanNPC humanNPC = npc;
		humanNPC.OnSit = (Action)Delegate.Combine(humanNPC.OnSit, new Action(EBDJFCJHLAH));
	}

	public void HGFDOBEHNKK()
	{
		if ((Object)(object)FLACDMCCAID != (Object)null)
		{
			FLACDMCCAID.Stop(false);
			FLACDMCCAID = null;
		}
	}
}
