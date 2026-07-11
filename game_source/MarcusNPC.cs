using System.Runtime.CompilerServices;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class MarcusNPC : DialogueNPCBase
{
	private static MarcusNPC IADEMLIIDPC;

	public float timeBarks;

	public NPCRoutine[] routines;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_20";

	private bool MEMGFCDNICE;

	public static MarcusNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void GEJDBFKNLND()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 1)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[1]).enabled = false;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = false;
			((Behaviour)routines[1]).enabled = true;
		}
	}

	[SpecialName]
	public static MarcusNPC JHKLPLPBKCI()
	{
		return IADEMLIIDPC;
	}

	public void KDCHBIFCIBO(string emotion)
	{
		GGFJGHHHEJC.emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static MarcusNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	private void LJPPIKFAOAM()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && PlayerController.GetPlayer(3).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			KCEBLHNEAAC();
		}
	}

	[SpecialName]
	public static MarcusNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	private void MOGMNMADIKK()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 6)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[0]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[1]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[0]).enabled = false;
					((Behaviour)routines[1]).enabled = true;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 2)
		{
			dialogue.conversation = "City/PetShop/Markus/Intro";
		}
		else
		{
			dialogue.conversation = "City/PetShop/Markus/Stand";
		}
	}

	private void AJGNEDFLCGE()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 7)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[0]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[1]).enabled = false;
					((Behaviour)routines[0]).enabled = true;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = false;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	private void OHGHOJLMHBC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 1)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[0]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[0]).enabled = false;
					((Behaviour)routines[1]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[1]).enabled = true;
		}
	}

	private void OOEENAHJGPK()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && PlayerController.GetPlayer(6).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			BOBPOGCHBML();
		}
	}

	public void LAANEEHHDLL(string emotion)
	{
		NJNFHEPLEHL().emotionsController.StartEmotion(emotion);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void KCEBLHNEAAC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 2)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[0]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[1]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[0]).enabled = true;
					((Behaviour)routines[1]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = false;
			((Behaviour)routines[0]).enabled = false;
		}
	}

	private void BOBPOGCHBML()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 8)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[1]).enabled = false;
					((Behaviour)routines[1]).enabled = true;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[1]).enabled = false;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	public void IGNCCLNIIJM(string emotion)
	{
		NBKKEINELDN().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void OJKEDMIKKCE(string emotion)
	{
		NJNFHEPLEHL().emotionsController.GPLECKGJFKM(emotion);
	}

	private void PFNPHJJLHPO()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(0) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			INCAMAPILPM();
		}
	}

	[SpecialName]
	public static MarcusNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static MarcusNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	private void KDONDDGPKDO()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 6)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[1]).enabled = false;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	private void DBOFLCHOLOH()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(1).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			CDPICJMAKLP();
		}
	}

	public void MONKBNPGGIG(string emotion)
	{
		MAIDHAPANEB().emotionsController.GPLECKGJFKM(emotion);
	}

	private void GOMDCLKPGBH()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 6)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = true;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[1]).enabled = false;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[1]).enabled = false;
		}
	}

	private void LPONPJEJBBH()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.OPHDCMJLLEC(2).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			FCOHEEIAPLG();
		}
	}

	public void PAIMGGCBBMB(string emotion)
	{
		JHKLPLPBKCI().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void GFOJGNFJKID()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.OPHDCMJLLEC(4).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			KDONDDGPKDO();
		}
	}

	public void EPMNMALMHKN(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void CDPICJMAKLP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 2)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[0]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[0]).enabled = true;
					((Behaviour)routines[1]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = false;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	private void JPMFHEMGJBC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 7)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[0]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[1]).enabled = true;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = false;
			((Behaviour)routines[1]).enabled = true;
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			NessyNPC.GGFJGHHHEJC.StopAllDialogues();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(10);
			}
			return true;
		}
		return false;
	}

	protected override void Update()
	{
		base.Update();
	}

	[SpecialName]
	public static MarcusNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	public void IOKILGMHFNE(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.StartEmotion(emotion);
	}

	public void JAGIEEJADMN(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static MarcusNPC NEFIEJALANL()
	{
		return IADEMLIIDPC;
	}

	public void LMEMMBGFPII(string emotion)
	{
		POINNCPMEIG().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void FNOCAOPJFDB()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 6)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[0]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[0]).enabled = false;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = false;
			((Behaviour)routines[1]).enabled = true;
		}
	}

	[SpecialName]
	public static MarcusNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static MarcusNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	public void FACKKGAODPO(string emotion)
	{
		JHKLPLPBKCI().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void EGDOKNPALCJ()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && PlayerController.GetPlayer(0).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			INCAMAPILPM();
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static MarcusNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	private void ODIEONADJOO()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.GetPlayer(4).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			FNOCAOPJFDB();
		}
	}

	[SpecialName]
	public static MarcusNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	private void GKCFAMLIDFN()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 5)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[0]).enabled = true;
					((Behaviour)routines[1]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	[SpecialName]
	public static MarcusNPC NJNFHEPLEHL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static MarcusNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
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

	private void OEAACFEPJFC()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.OPHDCMJLLEC(0).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			MOGMNMADIKK();
		}
	}

	[SpecialName]
	public static MarcusNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	private void INCAMAPILPM()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 3)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[0]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[0]).enabled = false;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	public void LGJONNIEAOM(string emotion)
	{
		MAIDHAPANEB().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void HHECLDCGGBE(string emotion)
	{
		MAIDHAPANEB().emotionsController.StartEmotion(emotion);
	}

	private void PNNHMJGIEJL()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			KCEBLHNEAAC();
		}
	}

	public void GINJDLKFNMB(string emotion)
	{
		MAAAKALBBEE().emotionsController.StartEmotion(emotion);
	}

	private void GMOCJKBKDHG()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 3)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[0]).enabled = false;
					((Behaviour)routines[1]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = false;
			((Behaviour)routines[0]).enabled = false;
		}
	}

	public void OOJEGKJLOED(string emotion)
	{
		MAIDHAPANEB().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void CPGDOFFNPLD(string emotion)
	{
		HNNJEBNIPOI().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void ANELDEBJGGJ()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			MOGMNMADIKK();
		}
	}

	public void ALJAPDBHANO(string emotion)
	{
		OKAPNFPFPFP().emotionsController.StartEmotion(emotion);
	}

	private void MKNHNMNPCMB()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 8)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = true;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[0]).enabled = false;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.ClientOnline())
		{
			((Behaviour)routines[0]).enabled = false;
			((Behaviour)routines[0]).enabled = true;
		}
	}

	private void MGIKDAAJAIE()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 4)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = true;
						((Behaviour)routines[0]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[1]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[0]).enabled = true;
					((Behaviour)routines[0]).enabled = false;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[0]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[1]).enabled = true;
		}
	}

	public void BPDPPBDHJEL(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void KNBHOHJIJBE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.OPHDCMJLLEC(6).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			MOGMNMADIKK();
		}
	}

	[SpecialName]
	public static MarcusNPC HNNJEBNIPOI()
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

	[SpecialName]
	public static MarcusNPC OKAPNFPFPFP()
	{
		return IADEMLIIDPC;
	}

	private void GCPOPJMCGHA()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.GetPlayer(0).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			MOGMNMADIKK();
		}
	}

	private void FCOHEEIAPLG()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 1)
			{
				if (((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[1]).enabled = false;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			else if (((Behaviour)routines[0]).enabled)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					((Behaviour)routines[1]).enabled = true;
					((Behaviour)routines[0]).enabled = true;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[0];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[0]).enabled = false;
		}
	}

	[SpecialName]
	public static MarcusNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	private void IHANOOBEJFO()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (routine.currentRoutine == -1)
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 2)
			{
				if (((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = false;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			else if (((Behaviour)routines[1]).enabled)
			{
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)routines[1]).enabled = false;
					((Behaviour)routines[0]).enabled = true;
				}
				if ((Object)(object)onlineNPC != (Object)null)
				{
					onlineNPC.routine = routines[1];
				}
			}
		}
		if (((Behaviour)routines[1]).enabled && OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[1]).enabled = false;
		}
	}

	public void IBDHCOEBDPF(string emotion)
	{
		HNNJEBNIPOI().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static MarcusNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	private void FKHHIKGABAP()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.GetPlayer(2).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			OHGHOJLMHBC();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void EICNDMGMPLE(string emotion)
	{
		BGMJCCFNNDL().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void BEECLHMOEIP(string emotion)
	{
		OKAPNFPFPFP().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void MAOACOAHDHF(string emotion)
	{
		BDAGIEIJOOG().emotionsController.PIOCPGKDAOF(emotion);
	}
}
