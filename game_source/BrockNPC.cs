using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BrockNPC : DialogueNPCBase
{
	private static BrockNPC IADEMLIIDPC;

	public float timeBarks;

	public bool ferroEvent;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "BrockProgress";

	public static BrockNPC GGFJGHHHEJC => IADEMLIIDPC;

	[SpecialName]
	public static BrockNPC PFHFIJDDOME()
	{
		return IADEMLIIDPC;
	}

	public void MMBHJICBLND(string emotion)
	{
		EAGMIHGJKNB().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void NIAHHEDHHLJ(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NMAPMPBAGMM(emotion);
	}

	public void ALJAPDBHANO(string emotion)
	{
		HLMGBEGEAPC().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void OOJEGKJLOED(string emotion)
	{
		ABHIDHPMLLD().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void JCNKIPBPOFC(string emotion)
	{
		LKDJNKLJKGO().emotionsController.NMAPMPBAGMM(emotion);
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (ferroEvent)
		{
			dialogue.conversation = "HotBath/Brock Talk";
			return;
		}
		Result variable = DialogueLua.GetVariable("MineState");
		if (((Result)(ref variable)).asInt <= 1 && !EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			dialogue.conversation = "Miners/Camp/Brock/Talk";
		}
		else
		{
			dialogue.conversation = "Miners/Mine/Brock/Talk";
		}
	}

	public void FACKKGAODPO(string emotion)
	{
		HLMGBEGEAPC().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BrockNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	private void GNMMELIJKML()
	{
		SelectDialogueUI(1);
	}

	public void GMNIFLOBFMK(string emotion)
	{
		HLMGBEGEAPC().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BrockNPC MOAKANGAMBA()
	{
		return IADEMLIIDPC;
	}

	public void PAIMGGCBBMB(string emotion)
	{
		NJNFHEPLEHL().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrockNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC FMIDAFEGDCD()
	{
		return IADEMLIIDPC;
	}

	private void MFMMHDPGCBO()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrockNPC BIIOFAHFNPA()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
	}

	public void DOCHPOEOOAL(string emotion)
	{
		OLHBLKIAFOM().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void HELHNJDFPPF()
	{
		SelectDialogueUI(1);
	}

	private void CMLLBIDFNEB()
	{
		SelectDialogueUI();
	}

	public void IAFBGAMAOID(string emotion)
	{
		BIIOFAHFNPA().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void EEKOJEKPIMP()
	{
		SelectDialogueUI();
	}

	public void FPKLJCGJBPL(string emotion)
	{
		PFHFIJDDOME().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void GINJDLKFNMB(string emotion)
	{
		POAGAIBEFBF().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void HFFFFAJFIPB()
	{
		SelectDialogueUI();
	}

	private void OKAPGNGLOHO()
	{
		SelectDialogueUI();
	}

	public void HJBBGFPGGDO(string emotion)
	{
		CNDNOECMKME().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void LEADONDEOIC(string emotion)
	{
		HNNJEBNIPOI().emotionsController.GPLECKGJFKM(emotion);
	}

	private void PLHEHGHFCJI()
	{
		SelectDialogueUI(1);
	}

	private void HOKAPOOCJCC()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrockNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC MMLBHCGFMMJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	public void GLJBJKJNHAN(string emotion)
	{
		BIIOFAHFNPA().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OHILDJPNDEF(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BrockNPC OKAPNFPFPFP()
	{
		return IADEMLIIDPC;
	}

	public void LGOKBJEJDKK(string emotion)
	{
		JFNOOMJMHCB().emotionsController.StartEmotion(emotion);
	}

	private void JPOLFKMLHNH()
	{
		SelectDialogueUI();
	}

	public void LILHBLEFJMM(string emotion)
	{
		HLMGBEGEAPC().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void LJFLICPLPAE(string emotion)
	{
		MAMKICHCPON().emotionsController.StartEmotion(emotion);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void JECHMEFJABD()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrockNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC ECGIAEFKKNA()
	{
		return IADEMLIIDPC;
	}

	private void BNIKICAEIND()
	{
		SelectDialogueUI();
	}

	public void ELBPCLPMHHE(string emotion)
	{
		HFIJHDBKCIA().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BrockNPC FJAMHCAAEAM()
	{
		return IADEMLIIDPC;
	}

	public void IGNCCLNIIJM(string emotion)
	{
		MKIEMMGGFEE().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void GBLFKGMMBDM(string emotion)
	{
		PDECKLKPKCG().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BrockNPC HLMGBEGEAPC()
	{
		return IADEMLIIDPC;
	}

	private void OIAHJHNPPCO()
	{
		SelectDialogueUI(1);
	}

	public void GHHNOBDPPEP(string emotion)
	{
		JFNOOMJMHCB().emotionsController.GPLECKGJFKM(emotion);
	}

	public void KIDDNGOMMJH(string emotion)
	{
		FJAMHCAAEAM().emotionsController.StartEmotion(emotion);
	}

	private void ICFHPJHBPDN()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrockNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	private void NCIBKMLIIAJ()
	{
		SelectDialogueUI(1);
	}

	public void CPGDOFFNPLD(string emotion)
	{
		NJNFHEPLEHL().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BrockNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void CJKKCFLCMKA(string emotion)
	{
		POAGAIBEFBF().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BrockNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC OPILDPFDFKJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	private void HEHNBONKMGJ()
	{
		SelectDialogueUI();
	}

	private void MLLADNLMIMP()
	{
		SelectDialogueUI(1);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	[SpecialName]
	public static BrockNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	private void KACEOJDPLKB()
	{
		SelectDialogueUI(1);
	}

	private void OKHHJDNNNPF()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrockNPC DHDOLCONMFJ()
	{
		return IADEMLIIDPC;
	}

	public void GDEEGJFFBKN(string emotion)
	{
		JFNOOMJMHCB().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BrockNPC IBEGPMLJIOJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC MAMKICHCPON()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC POAGAIBEFBF()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void FPDDJNENJHJ(string emotion)
	{
		PDECKLKPKCG().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BrockNPC OLHBLKIAFOM()
	{
		return IADEMLIIDPC;
	}

	public void IBDHCOEBDPF(string emotion)
	{
		KNOKBLFFNLM().emotionsController.NBFIDOGMLOK(emotion);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void DOHLOJOIHFO()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrockNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	private void OEMIMEIDMFE()
	{
		SelectDialogueUI(1);
	}

	public void PDNOKJKMEEJ(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void MONKBNPGGIG(string emotion)
	{
		DICHPHEOINO().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void MCPDJHICBLA(string emotion)
	{
		IBEGPMLJIOJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void AKCJMLPHFEB(string emotion)
	{
		MOAKANGAMBA().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BrockNPC MPFJOKOJIOO()
	{
		return IADEMLIIDPC;
	}

	public void LGJONNIEAOM(string emotion)
	{
		OKAPNFPFPFP().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void EGDIINMEMGE()
	{
		SelectDialogueUI();
	}

	private void EACIGGOOKGD()
	{
		SelectDialogueUI(1);
	}

	public void JEBPGMHDCDC(string emotion)
	{
		EJHDHCNILDH().emotionsController.NBFIDOGMLOK(emotion);
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
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

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void EICNDMGMPLE(string emotion)
	{
		DICHPHEOINO().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void BMLJMLBEAOO(string emotion)
	{
		LKDJNKLJKGO().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void GNGADDPBJDC()
	{
		SelectDialogueUI();
	}

	public void BMNFEAHLBJB(string emotion)
	{
		LADDMEMMJFP().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BrockNPC NJNFHEPLEHL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC LKDJNKLJKGO()
	{
		return IADEMLIIDPC;
	}

	private void IDHCFOCEPMD()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrockNPC BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC EAGMIHGJKNB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrockNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	private void BDJKNKIOPIJ()
	{
		SelectDialogueUI(1);
	}

	public void OGEMNLDNDBM(string emotion)
	{
		NJNFHEPLEHL().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void IGIKNCOLCKL()
	{
		SelectDialogueUI();
	}

	private void KGPOCJEHHHH()
	{
		SelectDialogueUI(1);
	}

	public void MAOACOAHDHF(string emotion)
	{
		FJAMHCAAEAM().emotionsController.StartEmotion(emotion);
	}

	private void BDGCFCPFKKE()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrockNPC MKIEMMGGFEE()
	{
		return IADEMLIIDPC;
	}

	private void CFHOODNCOLK()
	{
		SelectDialogueUI(1);
	}

	private void HBMDEHPHAPF()
	{
		SelectDialogueUI();
	}

	private void JPHEOLEEAPB()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrockNPC DICHPHEOINO()
	{
		return IADEMLIIDPC;
	}
}
