using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BooksGirlNPC : DialogueNPCBase
{
	private static BooksGirlNPC IADEMLIIDPC;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_12";

	public static BooksGirlNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void BOIOLKHGNPO(string emotion)
	{
		NBKKEINELDN().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EFOEDOJOFEH(string emotion)
	{
		BNBMNOMFFBE().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	public void BPDPPBDHJEL(string emotion)
	{
		LANAINBEMCM().emotionsController.GPLECKGJFKM(emotion);
	}

	public void OJKEDMIKKCE(string emotion)
	{
		EFPJLFMBPLL().emotionsController.DCCNJLBLFGI(emotion);
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

	[SpecialName]
	public static BooksGirlNPC LDBJELPPBAI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC FOPGLLMEEDE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void ABCLGBAJPIK(string emotion)
	{
		OFLELHKKNKC().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void PFFAJBLGFDO(string emotion)
	{
		PDECKLKPKCG().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC AJIGOHGPFPP()
	{
		return IADEMLIIDPC;
	}

	protected override void NJJCCIBDAPM()
	{
	}

	[SpecialName]
	public static BooksGirlNPC MOJDNGDNCCO()
	{
		return IADEMLIIDPC;
	}

	public void FPKLJCGJBPL(string emotion)
	{
		PDECKLKPKCG().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void PJGJGBEADMB(string emotion)
	{
		DCAEBALADIM().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void IGNCCLNIIJM(string emotion)
	{
		EKDNJDJHONF().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	public void KDCHBIFCIBO(string emotion)
	{
		LDBJELPPBAI().emotionsController.NBFIDOGMLOK(emotion);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void HICGHFBHDHG(string emotion)
	{
		KGPJPILAHDE().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC EFPJLFMBPLL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC CHPEMJMLDCN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	public void JDJGFIJPCIF(string emotion)
	{
		DBJCACLEFGK().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC BNBMNOMFFBE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	public static BooksGirlNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BooksGirlNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void IOKILGMHFNE(string emotion)
	{
		AJIGOHGPFPP().emotionsController.GPLECKGJFKM(emotion);
	}

	public void IHFOJNJAALB(string emotion)
	{
		LDBJELPPBAI().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public void LMEMMBGFPII(string emotion)
	{
		MAIDHAPANEB().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC MMLBHCGFMMJ()
	{
		return IADEMLIIDPC;
	}

	public void KIOMHEIDHFN(string emotion)
	{
		BNBMNOMFFBE().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	public void KIBIHBFJOJH(string emotion)
	{
		EFPJLFMBPLL().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BooksGirlNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}
}
