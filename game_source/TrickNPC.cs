using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TrickNPC : DialogueNPCBase
{
	[HideInInspector]
	public float barkOutroTime;

	public BobAnimation trickAnim;

	[HideInInspector]
	public bool inUseTrick;

	private static TrickNPC IADEMLIIDPC;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_9";

	public static TrickNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		base.OnHover(JIIGOACEIKL);
		return true;
	}

	public void PEOMJDDEFDD()
	{
		ShopUI.EAONFFENMCE(CHPEMJMLDCN().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void HLFLPNOOMNF()
	{
		ShopUI.EAONFFENMCE(CHPEMJMLDCN().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(AJIGOHGPFPP().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void APPNAMFJDOA(string emotion)
	{
		MLPCDJPLBAC().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
	}

	public void LAANEEHHDLL(string emotion)
	{
		MAIDHAPANEB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void CPGDOFFNPLD(string emotion)
	{
		GGFJGHHHEJC.emotionsController.DCCNJLBLFGI(emotion);
	}

	public void JDJGFIJPCIF(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void BNGJIMBJEOA()
	{
		ShopUI.NALKHGMLALJ(AJIGOHGPFPP().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(MAIDHAPANEB().EHHOHCPHAAO).OpenUI();
	}

	public void OJKEDMIKKCE(string emotion)
	{
		CHPEMJMLDCN().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OPGHBDIBDPC()
	{
		ShopUI.IEABDMDELFO(BDAGIEIJOOG().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(AJIGOHGPFPP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	protected override void NJJCCIBDAPM()
	{
		dialogue.conversation = "Halloween/Trick/Main";
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
	}

	protected override void Update()
	{
		base.Update();
		inUseTrick = inUse;
	}

	[SpecialName]
	public static TrickNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TrickNPC CHPEMJMLDCN()
	{
		return IADEMLIIDPC;
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (Time.time > barkOutroTime && !inUse)
		{
			DialogueLua.SetVariable("BARKTRICK", (object)0);
			DialogueManager.Bark("Halloween/Trick/Bark", ((Component)this).transform);
			barkOutroTime = Random.Range(15f, 25f) + Time.time;
		}
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	public void LANFOHBIMNO()
	{
		ShopUI.IEABDMDELFO(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(BDAGIEIJOOG().EHHOHCPHAAO).OpenUI();
	}

	public void DNGFKNIPLBM()
	{
		ShopUI.AGNKKAPMHLN(AJIGOHGPFPP().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(MLPCDJPLBAC().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void GBDMLNGDHFP()
	{
		ShopUI.IEABDMDELFO(AJIGOHGPFPP().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(CHPEMJMLDCN().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		base.MouseUp(JIIGOACEIKL);
		return true;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	[SpecialName]
	public static TrickNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void BOIOLKHGNPO(string emotion)
	{
		AJIGOHGPFPP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
	}

	[SpecialName]
	public static TrickNPC AJIGOHGPFPP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TrickNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}
}
