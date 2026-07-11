using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class MothersRecipeEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class CNNECHLIMGJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MothersRecipeEvent _003C_003E4__this;

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
		public CNNECHLIMGJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MothersRecipeEvent mothersRecipeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				MultiAudioManager.PlayAudioObject(mothersRecipeEvent.cofSound, ((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position);
				BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: false);
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

	public static MothersRecipeEvent instance;

	public Transform[] initialPosition;

	public GameObject treasureChest;

	public AudioObject cofSound;

	public void CGLIMGDPPBB()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(DGNIOEIGCFB());
	}

	private void MMBKLOGEPHM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.LCNGJIFNEOK()).transform.position = initialPosition[1].position;
		BrookDWittNPC.GGFJGHHHEJC.content.SetActive(true);
		BrookDWittNPC.DOIKFJDLKJP().animationBase.SetDirection(Direction.Down);
		((Component)ChumNPC.KMKILBCGJOI()).transform.position = initialPosition[0].position;
		ChumNPC.LKOABOAADCD().content.SetActive(true);
		ChumNPC.MAIDHAPANEB().animationBase.SetDirection(Direction.Up);
	}

	private void EIKEPBCHCDI()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.HGJMGNJOHGF()).transform.position = initialPosition[1].position;
		BrookDWittNPC.HGJMGNJOHGF().content.SetActive(false);
		BrookDWittNPC.ACPHFLBLJAA().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.GGFJGHHHEJC).transform.position = initialPosition[1].position;
		ChumNPC.KMKILBCGJOI().content.SetActive(false);
		ChumNPC.KMKILBCGJOI().animationBase.SetDirection(Direction.Down);
	}

	public void IEKIHOOFAKN()
	{
		PlayerInventory.NEKDDPIAOBE(instance.CJODOOFLLLB).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(107, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void CofEvent()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(MHANCCOGBHF());
	}

	public void CIDIKKCLPNL()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(LMBLADIKLKP());
	}

	private void FCHDOGDICLM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.FMIDAFEGDCD()).transform.position = initialPosition[1].position;
		BrookDWittNPC.FOPGLLMEEDE().content.SetActive(false);
		BrookDWittNPC.OJJDNLEFNPJ().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.OACNNJCLEDE()).transform.position = initialPosition[0].position;
		ChumNPC.MAIDHAPANEB().content.SetActive(true);
		ChumNPC.POINNCPMEIG().animationBase.SetDirection(Direction.Down);
	}

	public void AJAAELKOLKH()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(OMNGGIPLMLA());
	}

	public void BPKOIFLCEBH()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(MPAHKIHOIKE());
	}

	private void IDODLLIMEMO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		if (MissionsManager.instance.BHEDPICFPLG(125))
		{
			treasureChest.SetActive(false);
		}
	}

	private void CHIJGHPHCNA()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
	}

	public void JNPAPKBKDCF()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(DGNIOEIGCFB());
	}

	private void PKBHEKHOAAA()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JDFDLEEELFH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(JDFDLEEELFH));
	}

	private void JDFDLEEELFH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(AGFGKHAMAFP));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OAONKKIGGMH));
		if (MissionsManager.instance.IsMissionActive(93))
		{
			treasureChest.SetActive(false);
		}
	}

	public void BJFLCFAPLEC()
	{
		PlayerInventory.OGKNJNINGMH(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(13, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
	}

	private IEnumerator MHANCCOGBHF()
	{
		instance.EDGDFPPKGDL = null;
		MultiAudioManager.PlayAudioObject(cofSound, ((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: true);
		yield return CommonReferences.wait2;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: false);
	}

	private IEnumerator BGDOLIPIIMP()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AHNGDMEFGDD()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(LMBLADIKLKP());
	}

	private void EEGHAGAFIFP(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("NotMyChest" + BFLCJPHHDJM));
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.LFPEPJBNCBF();
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(CJMPLCDBOEP));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = BrookDWittNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void JOBCAIFOHNL()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.LCNGJIFNEOK()).transform.position = initialPosition[0].position;
		BrookDWittNPC.ACPHFLBLJAA().content.SetActive(true);
		BrookDWittNPC.BNDNMBGJEKP().animationBase.SetDirection(Direction.Down);
		((Component)ChumNPC.POINNCPMEIG()).transform.position = initialPosition[0].position;
		ChumNPC.POINNCPMEIG().content.SetActive(true);
		ChumNPC.KIALFDOKABP().animationBase.SetDirection(Direction.Down);
	}

	public void CHBLNAOMBNN()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(MPAHKIHOIKE());
	}

	private IEnumerator DAFJPGNDKBP()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ADFMHFLPNOF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CAKEKPKEPBG));
		if (MissionsManager.instance.LKKDCLPBABN(-112))
		{
			treasureChest.SetActive(false);
		}
	}

	public void IOHDIJMPJNL()
	{
		PlayerInventory.OGKNJNINGMH(instance.CJODOOFLLLB).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(43, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	private void GBEMIDGOFLI()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.OKAPNFPFPFP()).transform.position = initialPosition[1].position;
		BrookDWittNPC.LFPEPJBNCBF().content.SetActive(true);
		BrookDWittNPC.HGJMGNJOHGF().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.EJHDHCNILDH()).transform.position = initialPosition[1].position;
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		ChumNPC.MAIDHAPANEB().animationBase.SetDirection(Direction.Up);
	}

	public void DIFKLAICAAE()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(GPAHKENDIBE());
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.GGFJGHHHEJC;
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Combine(brookDWittNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	private void CAKEKPKEPBG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MNFCKONOLCB));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(ODPHMMINPPJ));
		if (MissionsManager.instance.IsMissionActive(-82))
		{
			treasureChest.SetActive(false);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void NMBKOIEPHPL()
	{
		PlayerInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(-127, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	private void CJMPLCDBOEP(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Items/item_description_650" + BFLCJPHHDJM));
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.ABHIDHPMLLD();
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = BrookDWittNPC.BNDNMBGJEKP().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void NFBGABDMKIE()
	{
		PlayerInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-94, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator DGNIOEIGCFB()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DOMAHGNLJCK()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(DGNIOEIGCFB());
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("OnConversationStarted MothersRecipe Event " + BFLCJPHHDJM));
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.GGFJGHHHEJC;
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = BrookDWittNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator EBPIFBOBIDF()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODPHMMINPPJ()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CAKEKPKEPBG));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		if (MissionsManager.instance.BHEDPICFPLG(-26))
		{
			treasureChest.SetActive(false);
		}
	}

	private void BGPGIOMKKAO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		if (MissionsManager.instance.IsMissionActive(317))
		{
			treasureChest.SetActive(true);
		}
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.GGFJGHHHEJC;
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MothersRecipe/MainEvent";
		if (!isActor && OnlineManager.PlayingOnline() && PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)this).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void NFINJEHPOBP(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("LicenciaDeApertura/TheloniousDialogue 04" + BFLCJPHHDJM));
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.FMIDAFEGDCD();
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(ACFGGGPIKKA));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = BrookDWittNPC.FOPGLLMEEDE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void NELNILIKDJO(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("FloorDirt" + BFLCJPHHDJM));
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.AJIGOHGPFPP();
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(NELNILIKDJO));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = BrookDWittNPC.FOPGLLMEEDE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		if (BFLCJPHHDJM)
		{
			PlayerInventory.GetPlayer(instance.CJODOOFLLLB).AddItem(ItemDatabaseAccessor.GetItem(1810).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
		instance.treasureChest.SetActive(true);
		MissionsManager.instance.StartMission(317, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
	}

	public void JDHLDCDKNGG()
	{
		PlayerInventory.NEKDDPIAOBE(instance.CJODOOFLLLB, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-69, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void HFFFFAJFIPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JDFDLEEELFH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MNFCKONOLCB));
	}

	private IEnumerator HMAADBMAFJB()
	{
		instance.EDGDFPPKGDL = null;
		MultiAudioManager.PlayAudioObject(cofSound, ((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: true);
		yield return CommonReferences.wait2;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: false);
	}

	private void MNFCKONOLCB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(MNFCKONOLCB));
		if (MissionsManager.instance.BHEDPICFPLG(-136))
		{
			treasureChest.SetActive(true);
		}
	}

	public void CMGFCMNFKEO()
	{
		PlayerInventory.NEKDDPIAOBE(instance.CJODOOFLLLB).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-68, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void NNNFEEONHEJ()
	{
		PlayerInventory.EIFPKCAFDIB(instance.CJODOOFLLLB).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(-53, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
	}

	private void OAONKKIGGMH()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CAKEKPKEPBG));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(ADFMHFLPNOF));
		if (MissionsManager.instance.BHEDPICFPLG(109))
		{
			treasureChest.SetActive(true);
		}
	}

	public void GNDJFCAGEPA()
	{
		PlayerInventory.NEKDDPIAOBE(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(-170, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void DEIAFOIKHAD()
	{
		PlayerInventory.EIFPKCAFDIB(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-133, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	public void HMAGNBJDJHL()
	{
		PlayerInventory.EIFPKCAFDIB(instance.CJODOOFLLLB, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.GetItem(111).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void GiveMap()
	{
		PlayerInventory.GetPlayer(instance.CJODOOFLLLB).AddItem(ItemDatabaseAccessor.GetItem(1810).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private IEnumerator MPAHKIHOIKE()
	{
		instance.EDGDFPPKGDL = null;
		MultiAudioManager.PlayAudioObject(cofSound, ((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: true);
		yield return CommonReferences.wait2;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: false);
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void NKDFMFFDGKC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ODPHMMINPPJ));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ODPHMMINPPJ));
	}

	private void DBNNEOKJKIN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.ABHIDHPMLLD()).transform.position = initialPosition[1].position;
		BrookDWittNPC.MPJJAPCFENH().content.SetActive(true);
		BrookDWittNPC.HFHPMKJGMPA().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.OJJDNLEFNPJ()).transform.position = initialPosition[0].position;
		ChumNPC.MAIDHAPANEB().content.SetActive(true);
		ChumNPC.EBAIHKJHCCA().animationBase.SetDirection(Direction.Up);
	}

	private void OIAHJHNPPCO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
	}

	private void GJBNMNBAJIP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position = initialPosition[0].position;
		BrookDWittNPC.GGFJGHHHEJC.content.SetActive(true);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		((Component)ChumNPC.GGFJGHHHEJC).transform.position = initialPosition[1].position;
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		ChumNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
	}

	public void OANIJLIFBPF()
	{
		PlayerInventory.NEKDDPIAOBE(instance.CJODOOFLLLB, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(41).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void HBMDEHPHAPF()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JDFDLEEELFH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MNFCKONOLCB));
	}

	private void LANGHIOBJIH()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
	}

	private IEnumerator OMNGGIPLMLA()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OJCFKPAEFEM()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(PCEJAMFIOPC());
	}

	private void ACFGGGPIKKA(bool BFLCJPHHDJM)
	{
		Debug.Log((object)(" not found (or not visible in lobby)" + BFLCJPHHDJM));
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.MAAAKALBBEE();
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(NELNILIKDJO));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = BrookDWittNPC.OKAPNFPFPFP().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator GPAHKENDIBE()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PCEJAMFIOPC()
	{
		instance.EDGDFPPKGDL = null;
		MultiAudioManager.PlayAudioObject(cofSound, ((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: true);
		yield return CommonReferences.wait2;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Cof", EGFGNGJGBOP: false);
	}

	public void MNBAAIPLEJG()
	{
		PlayerInventory.OGKNJNINGMH(instance.CJODOOFLLLB).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(20).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private IEnumerator EHPDNIKPAIA()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MKBFDGLHIFE()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(EBPIFBOBIDF());
	}

	public void CBAKGHHDLGG()
	{
		PlayerInventory.OGKNJNINGMH(instance.CJODOOFLLLB).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-47, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void AGFGKHAMAFP()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ODPHMMINPPJ));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CAKEKPKEPBG));
		if (MissionsManager.instance.LKKDCLPBABN(-3))
		{
			treasureChest.SetActive(true);
		}
	}

	public void ANKNPJLDKCE()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(HMAADBMAFJB());
	}

	private void ODBJHDEEPEB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.LCNGJIFNEOK()).transform.position = initialPosition[0].position;
		BrookDWittNPC.FOPGLLMEEDE().content.SetActive(false);
		BrookDWittNPC.LCNGJIFNEOK().animationBase.SetDirection(Direction.Down);
		((Component)ChumNPC.LKOABOAADCD()).transform.position = initialPosition[0].position;
		ChumNPC.EBAIHKJHCCA().content.SetActive(false);
		ChumNPC.EBAIHKJHCCA().animationBase.SetDirection(Direction.Down);
	}

	public void CIMJEBGLKLP()
	{
		PlayerInventory.EIFPKCAFDIB(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-116, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void IAGGPCCJHAJ()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(DAFJPGNDKBP());
	}

	private void GLHMBLEFPFP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.MPJJAPCFENH()).transform.position = initialPosition[0].position;
		BrookDWittNPC.ACPHFLBLJAA().content.SetActive(false);
		BrookDWittNPC.MNFMOEKMJKN().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.GGFJGHHHEJC).transform.position = initialPosition[0].position;
		ChumNPC.MAIDHAPANEB().content.SetActive(false);
		ChumNPC.CHKMFEFOFKJ().animationBase.SetDirection(Direction.Down);
	}

	private void JHJIBMBIKBH()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.LFPEPJBNCBF()).transform.position = initialPosition[0].position;
		BrookDWittNPC.MAIDHAPANEB().content.SetActive(true);
		BrookDWittNPC.JLNBMNKJCHE().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.EJHDHCNILDH()).transform.position = initialPosition[0].position;
		ChumNPC.MAIDHAPANEB().content.SetActive(false);
		ChumNPC.KIALFDOKABP().animationBase.SetDirection(Direction.Down);
	}

	private void IMIONHLAKIH()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(IDODLLIMEMO));
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
	}

	private IEnumerator LMBLADIKLKP()
	{
		return new CNNECHLIMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BODMGPJOOJK()
	{
		if (instance.isActor)
		{
			OnlineEventsManager.SendMothersRecipeEventCof();
		}
		((MonoBehaviour)instance).StartCoroutine(OMNGGIPLMLA());
	}

	private void GOLADNCKGOF()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Component)BrookDWittNPC.OMFKNGDCJFN()).transform.position = initialPosition[1].position;
		BrookDWittNPC.EKDNJDJHONF().content.SetActive(false);
		BrookDWittNPC.LCNGJIFNEOK().animationBase.SetDirection(Direction.Up);
		((Component)ChumNPC.OJJDNLEFNPJ()).transform.position = initialPosition[0].position;
		ChumNPC.POINNCPMEIG().content.SetActive(false);
		ChumNPC.LKOABOAADCD().animationBase.SetDirection(Direction.Down);
	}
}
