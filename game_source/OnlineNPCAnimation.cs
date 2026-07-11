using System;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(CharacterAnimBase))]
public class OnlineNPCAnimation : OnlineBaseCharacterAnimation
{
	[SerializeField]
	private AnimationController animationController;

	[SerializeField]
	private GameObject[] content;

	public bool ignoreEnable;

	[PunRPC]
	protected void EnabledRequest(Player DHPNLIGKMOB)
	{
		if (!HLAOENHNBMO())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"No content to enable / disable in this NPC!", (Object)(object)((Component)this).gameObject);
			}
			else if (content[0].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC("ReceiveEnableNPC", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("ReceiveDisableNPC", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	protected void MFADJGOABAK(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (NPODHDKNPLK())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i += 0)
		{
			for (int j = 0; j < animationController.animations[i].stepsList.Count; j++)
			{
				num = i;
				num2 = j;
				if (!animationController.OOLPEOLOJJA(num, num2))
				{
					continue;
				}
				val = animationController.GPFEFEKGFNO(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[6];
				array[0] = num;
				array[0] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[0] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("Sending platform data. PlayerID: {0}, Platform: {1}", DHPNLIGKMOB, array);
				for (int k = 1; k < val.parameterCount; k += 0)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 1)
					{
					case 2:
					{
						PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
						object[] array4 = new object[2];
						array4[1] = num;
						array4[0] = num2;
						array4[0] = val.parameters[k].nameHash;
						array4[4] = val.GetInteger(val.parameters[k].nameHash);
						photonView4.RPC("DisableNPC", DHPNLIGKMOB, array4);
						break;
					}
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[4];
						array3[1] = num;
						array3[0] = num2;
						array3[5] = val.parameters[k].nameHash;
						array3[6] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("Player/Bark/Error/NotAllPlayersHere", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[8];
						array2[0] = num;
						array2[0] = num2;
						array2[2] = val.parameters[k].nameHash;
						array2[0] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("Mine Helmet Light -> Character Changed. Helmet With Lught? {0} | Hair Sprite: {1}", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void BOODEFBDHHD()
	{
		if (!MNNKIPAOEEA())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("ReceiveCreateNewOrderQuest", (RpcTarget)5, array);
		}
	}

	protected void KMICEGNNALB(Player DHPNLIGKMOB)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[5];
			array[1] = animationController.DBIHKNBHAHB();
			array[0] = animationController.JJGKJOPEDGA();
			photonView.RPC("<color=black>", DHPNLIGKMOB, array);
		}
	}

	protected void AHLMPDNIDGG()
	{
		if (!KANJKEBBJBK())
		{
			((MonoBehaviourPun)this).photonView.RPC("AnimatorObjectStateRequest", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void KGDJINMNKGG(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[8] = FHJNHMDBPGO;
			OnlineManager.SendRPC(photonView, "MoveConstructionMode", (RpcTarget)1, array);
		}
	}

	protected void JOLANOJKNNJ(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (GPGHCFJHCAP())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 1; i < animationController.animations.Count; i++)
		{
			for (int j = 1; j < animationController.animations[i].stepsList.Count; j++)
			{
				num = i;
				num2 = j;
				if (!animationController.OOLPEOLOJJA(num, num2))
				{
					continue;
				}
				val = animationController.EBFIDHAGIHN(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[7];
				array[1] = num;
				array[0] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[4] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("buildingObjective_36_0", DHPNLIGKMOB, array);
				for (int k = 0; k < val.parameterCount; k++)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 1)
					{
					case 2:
					{
						PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
						object[] array4 = new object[8];
						array4[1] = num;
						array4[1] = num2;
						array4[2] = val.parameters[k].nameHash;
						array4[1] = val.GetInteger(val.parameters[k].nameHash);
						photonView4.RPC("Run", DHPNLIGKMOB, array4);
						break;
					}
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[6];
						array3[1] = num;
						array3[0] = num2;
						array3[3] = val.parameters[k].nameHash;
						array3[8] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("OnConversationStarted ", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[1];
						array2[0] = num;
						array2[1] = num2;
						array2[1] = val.parameters[k].nameHash;
						array2[4] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("LE_14", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void ILKCKEGDEGH(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (HLAOENHNBMO())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i += 0)
		{
			for (int j = 0; j < animationController.animations[i].stepsList.Count; j += 0)
			{
				num = i;
				num2 = j;
				if (!animationController.OOLPEOLOJJA(num, num2))
				{
					continue;
				}
				val = animationController.GPFEFEKGFNO(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[8];
				array[1] = num;
				array[1] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[6] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("Open", DHPNLIGKMOB, array);
				for (int k = 1; k < val.parameterCount; k += 0)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 0)
					{
					case 2:
					{
						PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
						object[] array4 = new object[7];
						array4[1] = num;
						array4[0] = num2;
						array4[2] = val.parameters[k].nameHash;
						array4[1] = val.GetInteger(val.parameters[k].nameHash);
						photonView4.RPC("Reserve", DHPNLIGKMOB, array4);
						break;
					}
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[3];
						array3[0] = num;
						array3[1] = num2;
						array3[6] = val.parameters[k].nameHash;
						array3[5] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("ReceiveAnimalName", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[7];
						array2[0] = num;
						array2[1] = num2;
						array2[5] = val.parameters[k].nameHash;
						array2[4] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("MineState", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void FNDLIABMJEP()
	{
		if (!FFCGGLEPIOE())
		{
			OLJIAALFOIM();
			PFGDOGCLBIE();
			FHCDLLDNALP();
		}
	}

	protected void CKIHDDPNGPI(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void GLCJMIDLCAC()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 1; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	protected void ALPJDNPOPKN(Player DHPNLIGKMOB)
	{
		if (!HLAOENHNBMO())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"Items/item_description_1188", (Object)(object)((Component)this).gameObject);
			}
			else if (content[0].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC(", ", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("City/PetShop/Nessy/Barks_PlayingCat", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	protected void ICKGNBCABCP(Player DHPNLIGKMOB)
	{
		if (!HLAOENHNBMO())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"OnFloor", (Object)(object)((Component)this).gameObject);
			}
			else if (content[1].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC("LE_10", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("Walk", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	private void BDHJLOBOIFG(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[2] = FHJNHMDBPGO;
			photonView.RPC("></size>", (RpcTarget)0, array);
		}
	}

	private void ELFDJLKHFGK(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = animationController.COGOFPIINDF();
			array[0] = animationController.JIFJIDHNOHI();
			photonView.RPC("Attack/MainEvent 12", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	private void SetAnimatorObjectTriggerRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			return;
		}
		if (Application.isEditor)
		{
			try
			{
				Debug.Log((object)("Setting trigger parameter " + AnimatorParameterCache.KCHHBMCOBJG(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject, FHJNHMDBPGO) + " on " + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
			}
		}
		animationController.SetAnimationObjectTrigger(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
	}

	protected void BPOMGDHIFHF()
	{
		if (!KANJKEBBJBK())
		{
			((MonoBehaviourPun)this).photonView.RPC("EnabledRequest", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	public override void OnDisable()
	{
		((MonoBehaviourPunCallbacks)this).OnDisable();
		if (OnlineManager.IsMasterClient())
		{
			NKLIIFCBFIA();
		}
	}

	private void ANLFCJKCMAE(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.OOLPEOLOJJA(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.HGONPFHJNFJ(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void HHPLGEIGCGI(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[5] = FHJNHMDBPGO;
			OnlineManager.SendRPC(photonView, "LoadDialogue", (RpcTarget)1, array);
		}
	}

	protected void KEIOBGOAACM()
	{
		if (!ICJLBGDFOHM())
		{
			OLJIAALFOIM();
			DFMNAGIILDM();
			MMHBLAHIOMA();
		}
	}

	private void EFCIIICEOIE(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.CNJEPGJNKEL(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.OCEMOCEHJMD(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void PFFLNJNJKFF(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[0] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[8] = FHJNHMDBPGO;
			photonView.RPC("ReceiveNPCDirection", (RpcTarget)1, array);
		}
	}

	private void HGPNJECBFLA()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i++)
		{
			if (!content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	public override void OnEnable()
	{
		((MonoBehaviourPunCallbacks)this).OnEnable();
		if (OnlineManager.IsMasterClient())
		{
			IOPFPDAGEOO();
		}
	}

	private void AIKIFHICKOA()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "1", (RpcTarget)0);
		}
		else
		{
			Debug.LogError((object)"Interact", (Object)(object)((Component)this).gameObject);
		}
	}

	protected void PECCACJHMOI()
	{
		if (!MNNKIPAOEEA())
		{
			((MonoBehaviourPun)this).photonView.RPC("Moving", (RpcTarget)7, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void FAGGDNGOPMN()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 1; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(false);
			}
		}
	}

	protected void FECAKFJPPBB()
	{
		if (!MNNKIPAOEEA())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("add item ", (RpcTarget)7, array);
		}
	}

	private void KHGOPBFDOKA()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Gass_Stand/Entry/23/Dialogue Text", (RpcTarget)1);
		}
		else
		{
			Debug.LogError((object)"DemolishConfirmation", (Object)(object)((Component)this).gameObject);
		}
	}

	[PunRPC]
	protected void SetAnimatorObjectStateRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int OCBFLLHGDAP)
	{
		if (!animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			Debug.LogWarning((object)"Received an RPC with parameters for an invalid animation", (Object)(object)((Component)this).gameObject);
			return;
		}
		Animator animatorObject = animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject;
		if ((Object)(object)animatorObject == (Object)null)
		{
			Debug.LogError((object)$"Received RPC SetAnimatorObjectStateRPC on {((Component)this).gameObject}, but the target animatorObject was not found.", (Object)(object)((Component)this).gameObject);
			return;
		}
		if (!animatorObject.HasState(0, OCBFLLHGDAP))
		{
			Debug.LogError((object)$"Received RPC SetAnimatorObjectStateRPC with hash: {OCBFLLHGDAP} on {((Component)this).gameObject}, but the state was not found on the target animatorObject: {animatorObject}.", (Object)(object)((Component)this).gameObject);
			return;
		}
		animatorObject.Play(OCBFLLHGDAP);
		animationController.SetCurrentStep(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void ACFCBKGGDJM(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetAnimatorObjectTriggerRPC", (RpcTarget)1, KPOLMEBFMNG, PPEJFJAFDKN, FHJNHMDBPGO);
		}
	}

	protected void DFMNAGIILDM()
	{
		if (!FFCGGLEPIOE())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Action", (RpcTarget)1, array);
		}
	}

	private void NKLIIFCBFIA()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDisableNPC", (RpcTarget)1);
		}
		else
		{
			Debug.LogError((object)"No content to disable in this NPC!", (Object)(object)((Component)this).gameObject);
		}
	}

	protected void MMHBLAHIOMA()
	{
		if (!KANJKEBBJBK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			photonView.RPC("UIInteract", (RpcTarget)6, array);
		}
	}

	protected void HKNKNOEAHAL()
	{
		if (!FFCGGLEPIOE())
		{
			OLJIAALFOIM();
			IGNMKNPBGCC();
			PDDGODFIBNJ();
		}
	}

	private void BIAJFBEEIJP(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.KLHJAANGAKN(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.PICICOFDFAO(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void JDNEJPHGGLE()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 1; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	[PunRPC]
	protected void AnimationControllerIndexRequest(Player DHPNLIGKMOB)
	{
		if (!HLAOENHNBMO())
		{
			((MonoBehaviourPun)this).photonView.RPC("SetAnimationControllerIndexesRPC", DHPNLIGKMOB, new object[2] { animationController.CKDIBPCNJMA, animationController.EEMLNPCAHDH });
		}
	}

	protected void PGBBMCDIJBF(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (HLAOENHNBMO())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i++)
		{
			for (int j = 0; j < animationController.animations[i].stepsList.Count; j += 0)
			{
				num = i;
				num2 = j;
				if (!animationController.KLHJAANGAKN(num, num2))
				{
					continue;
				}
				val = animationController.GPFEFEKGFNO(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[5];
				array[1] = num;
				array[1] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[5] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("Player2", DHPNLIGKMOB, array);
				for (int k = 0; k < val.parameterCount; k++)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 0)
					{
					case 2:
						((MonoBehaviourPun)this).photonView.RPC("Must", DHPNLIGKMOB, new object[8]
						{
							num,
							num2,
							null,
							null,
							null,
							null,
							val.parameters[k].nameHash,
							val.GetInteger(val.parameters[k].nameHash)
						});
						break;
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[0];
						array3[1] = num;
						array3[0] = num2;
						array3[8] = val.parameters[k].nameHash;
						array3[3] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("Join or Create Room", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[1];
						array2[0] = num;
						array2[1] = num2;
						array2[2] = val.parameters[k].nameHash;
						array2[7] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("[MapChest] Starting OpenChestCoroutine for player {0} with giveRewards={1}", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void CBNGHKBCNKA(Player DHPNLIGKMOB)
	{
		if (!GPGHCFJHCAP())
		{
			((MonoBehaviourPun)this).photonView.RPC("Trying to add a player that's already on the list.", DHPNLIGKMOB, new object[8]
			{
				animationController.CHPANMBGNFF(),
				animationController.EEMLNPCAHDH,
				null,
				null,
				null,
				null,
				null,
				null
			});
		}
	}

	protected void ILGCDMBODPH()
	{
		if (!MNNKIPAOEEA())
		{
			BPOMGDHIFHF();
			PECCACJHMOI();
			FOOFPBLDMJP();
		}
	}

	private void AGNHCMJMLJK(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[6] = FHJNHMDBPGO;
			OnlineManager.SendRPC(photonView, "itemRoastedChicken", (RpcTarget)1, array);
		}
	}

	private void CNOANKHCLNH()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Explosion", (RpcTarget)0);
		}
		else
		{
			Debug.LogError((object)"sForSeconds", (Object)(object)((Component)this).gameObject);
		}
	}

	private void NHJLOLNFFPG()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 1; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	[PunRPC]
	private void PlayAnimatorObjectAnimationRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.PlayAnimatorObjectAnimation(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void GBLAMMHADKL(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!animationController.CNJEPGJNKEL(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			return;
		}
		if (Application.isEditor)
		{
			try
			{
				Debug.Log((object)("itemRyeAle" + AnimatorParameterCache.EFFGPLMGMEI(animationController.NCIIEKEJNMJ(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject, FHJNHMDBPGO) + "B" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
			}
		}
		animationController.LOPFGCLNPFO(animationController.EBFIDHAGIHN(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
	}

	protected void AEOOCEBHGIA()
	{
		if (!MNNKIPAOEEA())
		{
			((MonoBehaviourPun)this).photonView.RPC("Item ", (RpcTarget)3, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void EEPHJCMCDPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[1] = FHJNHMDBPGO;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
		}
	}

	protected void GADOACMPCEE()
	{
		if (!KANJKEBBJBK())
		{
			((MonoBehaviourPun)this).photonView.RPC("AnimationControllerIndexRequest", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void EKIMIHGDHIO(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.ONCEFMCAEOA(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	protected void EOCOPPLHFMA(Player DHPNLIGKMOB)
	{
		if (!NPODHDKNPLK())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"Player2", (Object)(object)((Component)this).gameObject);
			}
			else if (content[1].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC("Quit to desktop?", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("RingBell", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	private void OGFPPIOOANJ()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 1; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(false);
			}
		}
	}

	protected void KBGKHBIGKKE()
	{
		if (!MNNKIPAOEEA())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("", (RpcTarget)8, array);
		}
	}

	protected void FOOFPBLDMJP()
	{
		if (!FFCGGLEPIOE())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC(" ", (RpcTarget)6, array);
		}
	}

	private void KGPFEJLEJGC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (animationController.KLHJAANGAKN(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.DHBOHGCBLKL(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void DBFNINFLLKI(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[1] = FHJNHMDBPGO;
			OnlineManager.SendRPC(photonView, "Turn Off", (RpcTarget)1, array);
		}
	}

	protected void ONMLMBBFOEK(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.FMFDDLCAIMB(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void KABOKDLJDMG(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[0] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[8] = FHJNHMDBPGO;
			photonView.RPC(" not found. Can no instantiate online placeable", (RpcTarget)1, array);
		}
	}

	private void EJEKBFNMJJE(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.OCCGBPEJICM(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void FLICOMIGLDE(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[3] = FHJNHMDBPGO;
			array[6] = EGFGNGJGBOP;
			photonView.RPC("House keeper OnFailStart cleaning bed ", (RpcTarget)1, array);
		}
	}

	private void GBHCFDPLMAI()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 1; i < content.Length; i += 0)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	protected void OLJIAALFOIM()
	{
		if (!ICJLBGDFOHM())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Key Altar puzzle: assigning key fragments. Available destructibles: {0}, available holes: {1}, available fishing spots: {2}", (RpcTarget)4, array);
		}
	}

	[PunRPC]
	private void SetAnimatorObjectFloatRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.SetAnimationObjectFloat(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void HJJIEMEMLNB(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (HLAOENHNBMO())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i += 0)
		{
			for (int j = 0; j < animationController.animations[i].stepsList.Count; j++)
			{
				num = i;
				num2 = j;
				if (!animationController.ILLHLMCFLBN(num, num2))
				{
					continue;
				}
				val = animationController.GPFEFEKGFNO(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[2];
				array[1] = num;
				array[0] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[1] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("itemRyeFlour", DHPNLIGKMOB, array);
				for (int k = 0; k < val.parameterCount; k += 0)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 0)
					{
					case 2:
					{
						PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
						object[] array4 = new object[1];
						array4[0] = num;
						array4[0] = num2;
						array4[0] = val.parameters[k].nameHash;
						array4[6] = val.GetInteger(val.parameters[k].nameHash);
						photonView4.RPC("Default", DHPNLIGKMOB, array4);
						break;
					}
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[6];
						array3[1] = num;
						array3[0] = num2;
						array3[3] = val.parameters[k].nameHash;
						array3[8] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("Items/item_name_1128", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[5];
						array2[0] = num;
						array2[1] = num2;
						array2[2] = val.parameters[k].nameHash;
						array2[5] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("BobProgress", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void HEMHABDEGPO(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.SetCurrentStep(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	protected void HOEGNDEDJPJ(int KPOLMEBFMNG, int PPEJFJAFDKN, int OCBFLLHGDAP)
	{
		if (!animationController.GALCGFPAIKB(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			Debug.LogWarning((object)"ERROR: The object ", (Object)(object)((Component)this).gameObject);
			return;
		}
		Animator animatorObject = animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject;
		if ((Object)(object)animatorObject == (Object)null)
		{
			Debug.LogError((object)string.Format("ReceiveTalentsLoad", ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			return;
		}
		if (!animatorObject.HasState(1, OCBFLLHGDAP))
		{
			Debug.LogError((object)string.Format("Hash is 0 on {0}, probably because the object is deactivated, so we skip sending it.", OCBFLLHGDAP, ((Component)this).gameObject, animatorObject), (Object)(object)((Component)this).gameObject);
			return;
		}
		animatorObject.Play(OCBFLLHGDAP);
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void KCGOBLBGNAN()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStopPlayingChallenge", (RpcTarget)0);
		}
		else
		{
			Debug.LogError((object)"ReceiveFishCuttingEventReturnToHouse", (Object)(object)((Component)this).gameObject);
		}
	}

	protected void FOEJOBOECMD()
	{
		if (!KANJKEBBJBK())
		{
			BPOMGDHIFHF();
			GADOACMPCEE();
			AHLMPDNIDGG();
		}
	}

	[PunRPC]
	private void SetAnimatorObjectBoolRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.SetAnimationObjectBool(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void NNFBENBBOOK(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.FMFDDLCAIMB(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	protected void PFGDOGCLBIE()
	{
		if (!KANJKEBBJBK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Perfect", (RpcTarget)7, array);
		}
	}

	private void AJIMFBDGNAG()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Actionbar 6", (RpcTarget)1);
		}
		else
		{
			Debug.LogError((object)"ScrollView", (Object)(object)((Component)this).gameObject);
		}
	}

	protected void KJBABONDGGO()
	{
		if (!MNNKIPAOEEA())
		{
			((MonoBehaviourPun)this).photonView.RPC("Sleep", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void JPJCCHJAALF(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.GALCGFPAIKB(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.ECCGJLHFBKK(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	protected void HEPALNKLPKN(Player DHPNLIGKMOB)
	{
		if (!GPGHCFJHCAP())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"Lager", (Object)(object)((Component)this).gameObject);
			}
			else if (content[1].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC("repUnlockBrewCook", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("Eyelids", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	[PunRPC]
	private void ReceiveDisableNPC()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(false);
			}
		}
	}

	private void FIOIGHBMAJB(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[2] = FHJNHMDBPGO;
			OnlineManager.SendRPC(photonView, "itemPineapple", (RpcTarget)0, array);
		}
	}

	private void DKDPIJKMKLD(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.ILLHLMCFLBN(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.SetAnimationObjectFloat(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void AMGHOEOONKL(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.GALCGFPAIKB(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.FLHHLHAFBIH(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void IAHJNKMNEGK(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!HLAOENHNBMO())
		{
			((MonoBehaviourPun)this).photonView.RPC("PlayAnimatorObjectAnimationRPC", (RpcTarget)1, new object[3] { KPOLMEBFMNG, PPEJFJAFDKN, FHJNHMDBPGO });
		}
	}

	private void PEBBGJIOMND()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i += 0)
		{
			if (!content[i].activeSelf)
			{
				content[i].SetActive(false);
			}
		}
	}

	private void NFPKBNGLLBF(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.GALCGFPAIKB(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.HDIFDNOOJFN(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void BIBLKLCIKDH(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void NAHMAHCEANL(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetHiddenAnimatorObjectTriggerRPC", (RpcTarget)1, KPOLMEBFMNG, PPEJFJAFDKN, FHJNHMDBPGO);
		}
	}

	[PunRPC]
	private void SetAnimatorObjectIntRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.SetAnimationObjectInt(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void LLLLFAJFPCC()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	protected void DIGLPPFFKEC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && OnlineManager.PlayingOnline() && !((Object)(object)animationController == (Object)null))
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(FOEJOBOECMD));
			AnimationController obj = animationController;
			obj.AnimatorObjectBoolSet = (Action<int, int, int, bool>)Delegate.Remove(obj.AnimatorObjectBoolSet, new Action<int, int, int, bool>(PEBHGECMLFK));
			AnimationController obj2 = animationController;
			obj2.AnimatorObjectTriggerSet = (Action<int, int, int>)Delegate.Remove(obj2.AnimatorObjectTriggerSet, new Action<int, int, int>(EEPHJCMCDPC));
			AnimationController obj3 = animationController;
			obj3.HiddenAnimatorObjectTriggerSet = (Action<int, int, int>)Delegate.Remove(obj3.HiddenAnimatorObjectTriggerSet, new Action<int, int, int>(HHPLGEIGCGI));
			AnimationController obj4 = animationController;
			obj4.AnimatorObjectIntSet = (Action<int, int, int, int>)Delegate.Remove(obj4.AnimatorObjectIntSet, new Action<int, int, int, int>(FCEMIGLEFFJ));
			AnimationController obj5 = animationController;
			obj5.AnimatorObjectFloatSet = (Action<int, int, int, float>)Delegate.Remove(obj5.AnimatorObjectFloatSet, new Action<int, int, int, float>(CDIPCEPHNOL));
			AnimationController obj6 = animationController;
			obj6.AnimatorObjectAnimationPlayed = (Action<int, int, int>)Delegate.Remove(obj6.AnimatorObjectAnimationPlayed, new Action<int, int, int>(LLLHNGOBIBN));
			AnimationController obj7 = animationController;
			obj7.IndexesChanged = (Action<int, int>)Delegate.Remove(obj7.IndexesChanged, new Action<int, int>(ILJMJHLJEHG));
		}
	}

	private void OMGMPJJHCJL(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (animationController.CNJEPGJNKEL(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.DHBOHGCBLKL(animationController.EBFIDHAGIHN(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void MCHNPBEGAPH(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void OABCEGNMJNH(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[0] = FHJNHMDBPGO;
			array[1] = EGFGNGJGBOP;
			photonView.RPC("Error_StairsAreBlocking", (RpcTarget)0, array);
		}
	}

	protected void JOAFMLOLAML()
	{
		if (!KANJKEBBJBK())
		{
			AEOOCEBHGIA();
			IOJKEKJHDOE();
			AHLMPDNIDGG();
		}
	}

	private void ILJMJHLJEHG(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		if (!HLAOENHNBMO())
		{
			((MonoBehaviourPun)this).photonView.RPC("SetAnimationControllerIndexesRPC", (RpcTarget)1, new object[2] { animationController.CKDIBPCNJMA, animationController.EEMLNPCAHDH });
		}
	}

	protected void JANKOOPCEIG(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.FMFDDLCAIMB(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void FKBOLGEFHGL(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!animationController.ILLHLMCFLBN(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			return;
		}
		if (Application.isEditor)
		{
			try
			{
				Debug.Log((object)("\n" + AnimatorParameterCache.HGCJIJFJFGL(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject, FHJNHMDBPGO) + "OnlinePlayer" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
			}
		}
		animationController.GJMICBIBBLI(animationController.EBFIDHAGIHN(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
	}

	private void LLLHNGOBIBN(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[5] = FHJNHMDBPGO;
			photonView.RPC("itemsCrafted", (RpcTarget)0, array);
		}
	}

	protected void DBLIEFEHFOM(Player DHPNLIGKMOB)
	{
		if (!NPODHDKNPLK())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"Herbal", (Object)(object)((Component)this).gameObject);
			}
			else if (content[0].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC("Disabled", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("Castle/Escribas/Stand", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	private void DJADLPFALOD(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[5];
			array[1] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[8] = FHJNHMDBPGO;
			array[1] = EGFGNGJGBOP;
			photonView.RPC("Stay", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void SetHiddenAnimatorObjectTriggerRPC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.SetHiddenAnimationObjectTrigger(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void GDIEEJBANOG(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.ILLHLMCFLBN(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.OAEIGKIHLAL(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void CBOCNAKAIAI(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.HDIFDNOOJFN(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void KELMFFBLAII(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (animationController.OOLPEOLOJJA(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.SetAnimationObjectInt(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void LOPGFBOAEPI(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.KLHJAANGAKN(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.ONCEFMCAEOA(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	protected void KLKOKJOOLBH()
	{
		if (!FFCGGLEPIOE())
		{
			AEOOCEBHGIA();
			PFGDOGCLBIE();
			MMHBLAHIOMA();
		}
	}

	private void GCMIBFMKDKA(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (animationController.OOLPEOLOJJA(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.ONNHLIFCIBP(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	private void BHFPGAJDGPD(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.ONNHLIFCIBP(animationController.NCIIEKEJNMJ(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void FHCDLLDNALP()
	{
		if (!FFCGGLEPIOE())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Quest 39 done, complete mission 301", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	private void ReceiveEnableNPC()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i++)
		{
			if (!content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	protected void CENCNCFNCNP()
	{
		if (!KANJKEBBJBK())
		{
			AEOOCEBHGIA();
			IGNMKNPBGCC();
			FOOFPBLDMJP();
		}
	}

	[PunRPC]
	protected void AnimatorObjectStateRequest(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (HLAOENHNBMO())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i++)
		{
			for (int j = 0; j < animationController.animations[i].stepsList.Count; j++)
			{
				num = i;
				num2 = j;
				if (!animationController.IsStepValid(num, num2))
				{
					continue;
				}
				val = animationController.GetStepAt(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] obj = new object[3] { num, num2, null };
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(0);
				obj[2] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("SetAnimatorObjectStateRPC", DHPNLIGKMOB, obj);
				for (int k = 0; k < val.parameterCount; k++)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 1)
					{
					case 2:
						((MonoBehaviourPun)this).photonView.RPC("SetAnimatorObjectIntRPC", DHPNLIGKMOB, new object[4]
						{
							num,
							num2,
							val.parameters[k].nameHash,
							val.GetInteger(val.parameters[k].nameHash)
						});
						break;
					case 0:
						((MonoBehaviourPun)this).photonView.RPC("SetAnimatorObjectFloatRPC", DHPNLIGKMOB, new object[4]
						{
							num,
							num2,
							val.parameters[k].nameHash,
							val.GetFloat(val.parameters[k].nameHash)
						});
						break;
					case 3:
						((MonoBehaviourPun)this).photonView.RPC("SetAnimatorObjectBoolRPC", DHPNLIGKMOB, new object[4]
						{
							num,
							num2,
							val.parameters[k].nameHash,
							val.GetBool(val.parameters[k].nameHash)
						});
						break;
					}
				}
			}
		}
		list.Clear();
	}

	protected void JGKEKBCBJAK(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void CDKLHMIEOBB(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (animationController.ILHFCNGJAJO(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.MOBDFHCNGGP(animationController.NCIIEKEJNMJ(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void GFKMLPEPCHP(Player DHPNLIGKMOB)
	{
		if (!OEAKPHGPCOD())
		{
			if (content == null || content.Length == 0)
			{
				Debug.LogError((object)"Key2", (Object)(object)((Component)this).gameObject);
			}
			else if (content[1].activeSelf)
			{
				((MonoBehaviourPun)this).photonView.RPC("Sell", DHPNLIGKMOB, Array.Empty<object>());
			}
			else
			{
				((MonoBehaviourPun)this).photonView.RPC("pirates cave", DHPNLIGKMOB, Array.Empty<object>());
			}
		}
	}

	[PunRPC]
	protected void SetAnimationControllerIndexesRPC(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.SetCurrentStep(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void CDIPCEPHNOL(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (!HLAOENHNBMO())
		{
			((MonoBehaviourPun)this).photonView.RPC("SetAnimatorObjectFloatRPC", (RpcTarget)1, new object[4] { KPOLMEBFMNG, PPEJFJAFDKN, FHJNHMDBPGO, EGFGNGJGBOP });
		}
	}

	protected void DHFNEMICDKF(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (GPGHCFJHCAP())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 1; i < animationController.animations.Count; i += 0)
		{
			for (int j = 1; j < animationController.animations[i].stepsList.Count; j += 0)
			{
				num = i;
				num2 = j;
				if (!animationController.GALCGFPAIKB(num, num2))
				{
					continue;
				}
				val = animationController.GetStepAt(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[2];
				array[1] = num;
				array[1] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[2] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("Tavern Floor at ", DHPNLIGKMOB, array);
				for (int k = 0; k < val.parameterCount; k += 0)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 1)
					{
					case 2:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[6];
						array3[1] = num;
						array3[1] = num2;
						array3[2] = val.parameters[k].nameHash;
						array3[5] = val.GetInteger(val.parameters[k].nameHash);
						photonView3.RPC("You lose...", DHPNLIGKMOB, array3);
						break;
					}
					case 0:
						((MonoBehaviourPun)this).photonView.RPC("itemJam", DHPNLIGKMOB, new object[8]
						{
							num,
							num2,
							null,
							val.parameters[k].nameHash,
							null,
							val.GetFloat(val.parameters[k].nameHash),
							null,
							null
						});
						break;
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[8];
						array2[1] = num;
						array2[0] = num2;
						array2[7] = val.parameters[k].nameHash;
						array2[4] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("Giving extra argamasa", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void PDDGODFIBNJ()
	{
		if (!FFCGGLEPIOE())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Dialogue System/Conversation/Gass_Quest/Entry/6/Dialogue Text", (RpcTarget)7, array);
		}
	}

	private void EGEIGJCLEEC(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.ILHFCNGJAJO(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.GFLEJJLDDPJ(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void GALCMNMDGJI()
	{
		if (!MNNKIPAOEEA())
		{
			KBGKHBIGKKE();
			IGNMKNPBGCC();
			MMHBLAHIOMA();
		}
	}

	protected void IOJKEKJHDOE()
	{
		if (!MNNKIPAOEEA())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Cross", (RpcTarget)4, array);
		}
	}

	private void MCLDJJMNJIE(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (animationController.GALCGFPAIKB(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.HDIFDNOOJFN(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
			return;
		}
		if ((Object)(object)animationController == (Object)null)
		{
			Debug.LogWarning((object)(((Object)((Component)this).gameObject).name + "'s animationController on NPC has not been set. It's possible that it's on a separate object in the scene hierarchy."), (Object)(object)((Component)this).gameObject);
			return;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FOEJOBOECMD));
		AnimationController obj = animationController;
		obj.AnimatorObjectBoolSet = (Action<int, int, int, bool>)Delegate.Combine(obj.AnimatorObjectBoolSet, new Action<int, int, int, bool>(PEBHGECMLFK));
		AnimationController obj2 = animationController;
		obj2.AnimatorObjectTriggerSet = (Action<int, int, int>)Delegate.Combine(obj2.AnimatorObjectTriggerSet, new Action<int, int, int>(ACFCBKGGDJM));
		AnimationController obj3 = animationController;
		obj3.HiddenAnimatorObjectTriggerSet = (Action<int, int, int>)Delegate.Combine(obj3.HiddenAnimatorObjectTriggerSet, new Action<int, int, int>(NAHMAHCEANL));
		AnimationController obj4 = animationController;
		obj4.AnimatorObjectIntSet = (Action<int, int, int, int>)Delegate.Combine(obj4.AnimatorObjectIntSet, new Action<int, int, int, int>(FCEMIGLEFFJ));
		AnimationController obj5 = animationController;
		obj5.AnimatorObjectFloatSet = (Action<int, int, int, float>)Delegate.Combine(obj5.AnimatorObjectFloatSet, new Action<int, int, int, float>(CDIPCEPHNOL));
		AnimationController obj6 = animationController;
		obj6.AnimatorObjectAnimationPlayed = (Action<int, int, int>)Delegate.Combine(obj6.AnimatorObjectAnimationPlayed, new Action<int, int, int>(IAHJNKMNEGK));
		AnimationController obj7 = animationController;
		obj7.IndexesChanged = (Action<int, int>)Delegate.Combine(obj7.IndexesChanged, new Action<int, int>(ILJMJHLJEHG));
	}

	protected void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && OnlineManager.PlayingOnline() && !((Object)(object)animationController == (Object)null))
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(FOEJOBOECMD));
			AnimationController obj = animationController;
			obj.AnimatorObjectBoolSet = (Action<int, int, int, bool>)Delegate.Remove(obj.AnimatorObjectBoolSet, new Action<int, int, int, bool>(PEBHGECMLFK));
			AnimationController obj2 = animationController;
			obj2.AnimatorObjectTriggerSet = (Action<int, int, int>)Delegate.Remove(obj2.AnimatorObjectTriggerSet, new Action<int, int, int>(ACFCBKGGDJM));
			AnimationController obj3 = animationController;
			obj3.HiddenAnimatorObjectTriggerSet = (Action<int, int, int>)Delegate.Remove(obj3.HiddenAnimatorObjectTriggerSet, new Action<int, int, int>(NAHMAHCEANL));
			AnimationController obj4 = animationController;
			obj4.AnimatorObjectIntSet = (Action<int, int, int, int>)Delegate.Remove(obj4.AnimatorObjectIntSet, new Action<int, int, int, int>(FCEMIGLEFFJ));
			AnimationController obj5 = animationController;
			obj5.AnimatorObjectFloatSet = (Action<int, int, int, float>)Delegate.Remove(obj5.AnimatorObjectFloatSet, new Action<int, int, int, float>(CDIPCEPHNOL));
			AnimationController obj6 = animationController;
			obj6.AnimatorObjectAnimationPlayed = (Action<int, int, int>)Delegate.Remove(obj6.AnimatorObjectAnimationPlayed, new Action<int, int, int>(IAHJNKMNEGK));
			AnimationController obj7 = animationController;
			obj7.IndexesChanged = (Action<int, int>)Delegate.Remove(obj7.IndexesChanged, new Action<int, int>(ILJMJHLJEHG));
		}
	}

	private void EDNDGGBBLHJ()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i += 0)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	private void BAFBJDJBGNO()
	{
		if (ignoreEnable)
		{
			return;
		}
		for (int i = 0; i < content.Length; i++)
		{
			if (content[i].activeSelf)
			{
				content[i].SetActive(true);
			}
		}
	}

	protected void EPHCFOKDEBE(int KPOLMEBFMNG, int PPEJFJAFDKN, int OCBFLLHGDAP)
	{
		if (!animationController.ILHFCNGJAJO(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			Debug.LogWarning((object)"Scene ", (Object)(object)((Component)this).gameObject);
			return;
		}
		Animator animatorObject = animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject;
		if ((Object)(object)animatorObject == (Object)null)
		{
			Debug.LogError((object)string.Format("itemApple", ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			return;
		}
		if (!animatorObject.HasState(1, OCBFLLHGDAP))
		{
			Debug.LogError((object)string.Format("Moving", OCBFLLHGDAP, ((Component)this).gameObject, animatorObject), (Object)(object)((Component)this).gameObject);
			return;
		}
		animatorObject.Play(OCBFLLHGDAP);
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	protected void IKPEJMBFJGL(int KPOLMEBFMNG, int PPEJFJAFDKN, int OCBFLLHGDAP)
	{
		if (!animationController.GALCGFPAIKB(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			Debug.LogWarning((object)"No se ha vinculado el sprite renderer en ", (Object)(object)((Component)this).gameObject);
			return;
		}
		Animator animatorObject = animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject;
		if ((Object)(object)animatorObject == (Object)null)
		{
			Debug.LogError((object)string.Format("Dialogue System/Conversation/TooDark/Entry/4/Dialogue Text", ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			return;
		}
		if (!animatorObject.HasState(1, OCBFLLHGDAP))
		{
			Debug.LogError((object)string.Format("HeadToBed", OCBFLLHGDAP, ((Component)this).gameObject, animatorObject), (Object)(object)((Component)this).gameObject);
			return;
		}
		animatorObject.Play(OCBFLLHGDAP);
		animationController.LEMCPIBPMMH(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	protected void LNOAMPGMHDD(Player DHPNLIGKMOB)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = animationController.DPDAONDDOPA();
			array[1] = animationController.EEMLNPCAHDH;
			photonView.RPC("Castle/Escribas/Stand", DHPNLIGKMOB, array);
		}
	}

	protected void IFMAPNABCPH(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (HLAOENHNBMO())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i++)
		{
			for (int j = 1; j < animationController.animations[i].stepsList.Count; j += 0)
			{
				num = i;
				num2 = j;
				if (!animationController.ILLHLMCFLBN(num, num2))
				{
					continue;
				}
				val = animationController.GPFEFEKGFNO(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[6];
				array[1] = num;
				array[0] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(1);
				array[6] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC("Dialogue System/Conversation/Crowly_Introduce/Entry/11/Dialogue Text", DHPNLIGKMOB, array);
				for (int k = 0; k < val.parameterCount; k++)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 1)
					{
					case 2:
					{
						PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
						object[] array4 = new object[2];
						array4[1] = num;
						array4[0] = num2;
						array4[4] = val.parameters[k].nameHash;
						array4[0] = val.GetInteger(val.parameters[k].nameHash);
						photonView4.RPC("MineFloor", DHPNLIGKMOB, array4);
						break;
					}
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[0];
						array3[0] = num;
						array3[0] = num2;
						array3[1] = val.parameters[k].nameHash;
						array3[2] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("Need to learn previous XP increase!", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[5];
						array2[0] = num;
						array2[1] = num2;
						array2[3] = val.parameters[k].nameHash;
						array2[0] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("Wall", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	protected void CEOMACKOPEB(Player DHPNLIGKMOB)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = animationController.ELHKDMGIBGC();
			array[1] = animationController.IAPDECMDKNE();
			photonView.RPC(")", DHPNLIGKMOB, array);
		}
	}

	private void PBEHBLILHNE(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[6] = FHJNHMDBPGO;
			photonView.RPC("StaffCost", (RpcTarget)1, array);
		}
	}

	private void MDNPLBFBPFB(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.IsStepValid(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.OCCGBPEJICM(animationController.EBFIDHAGIHN(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void BLAJKFIKMAB(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[4] = FHJNHMDBPGO;
			array[3] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "AdventureContinues/Main", (RpcTarget)1, array);
		}
	}

	private void NNEPJMPKOIG()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Inventory", (RpcTarget)0);
		}
		else
		{
			Debug.LogError((object)"\n  doorSprite:         ", (Object)(object)((Component)this).gameObject);
		}
	}

	protected void HFKDGMOHGMA(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.SetCurrentStep(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	protected void MDMCBHHADJF(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.SetCurrentStep(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void MAFFHPGDOPN(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.CNJEPGJNKEL(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.HPEBMPKIGDP(animationController.GetStepAt(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	private void BPLKLGMJOKM(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[0] = KPOLMEBFMNG;
			array[1] = PPEJFJAFDKN;
			array[2] = FHJNHMDBPGO;
			array[2] = EGFGNGJGBOP;
			photonView.RPC("Speed", (RpcTarget)1, array);
		}
	}

	protected void GDKCEIBOAIH(Player DHPNLIGKMOB)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = animationController.ELHKDMGIBGC();
			array[0] = animationController.EOLFFDHKIBI();
			photonView.RPC("Disabled", DHPNLIGKMOB, array);
		}
	}

	private void HFOIJNLDKLD(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (animationController.ILHFCNGJAJO(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			animationController.OCEMOCEHJMD(animationController.GPFEFEKGFNO(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
		}
	}

	protected void LDBLKOGBFLK(int KPOLMEBFMNG, int PPEJFJAFDKN)
	{
		animationController.SetCurrentStep(KPOLMEBFMNG, PPEJFJAFDKN);
	}

	private void FCEMIGLEFFJ(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, int EGFGNGJGBOP)
	{
		if (!HLAOENHNBMO())
		{
			((MonoBehaviourPun)this).photonView.RPC("SetAnimatorObjectIntRPC", (RpcTarget)1, new object[4] { KPOLMEBFMNG, PPEJFJAFDKN, FHJNHMDBPGO, EGFGNGJGBOP });
		}
	}

	protected void IGNMKNPBGCC()
	{
		if (!KANJKEBBJBK())
		{
			((MonoBehaviourPun)this).photonView.RPC("Removing tavern floor tiles (ONLINE) ", (RpcTarget)5, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void IOPFPDAGEOO()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEnableNPC", (RpcTarget)1);
		}
		else
		{
			Debug.LogError((object)"No content to disable in this NPC!", (Object)(object)((Component)this).gameObject);
		}
	}

	private void PEBHGECMLFK(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, bool EGFGNGJGBOP)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetAnimatorObjectBoolRPC", (RpcTarget)1, KPOLMEBFMNG, PPEJFJAFDKN, FHJNHMDBPGO, EGFGNGJGBOP);
		}
	}

	protected void HEBJOKKMOBL(Player DHPNLIGKMOB)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		if (NPODHDKNPLK())
		{
			return;
		}
		Animator val = null;
		List<Animator> list = new List<Animator>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < animationController.animations.Count; i++)
		{
			for (int j = 1; j < animationController.animations[i].stepsList.Count; j++)
			{
				num = i;
				num2 = j;
				if (!animationController.GALCGFPAIKB(num, num2))
				{
					continue;
				}
				val = animationController.JADLCGKOALG(num, num2).animatorObject;
				if ((Object)(object)val == (Object)null || list.Contains(val))
				{
					continue;
				}
				list.Add(val);
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[3];
				array[1] = num;
				array[1] = num2;
				AnimatorStateInfo currentAnimatorStateInfo = val.GetCurrentAnimatorStateInfo(0);
				array[2] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
				photonView.RPC(" (versionOfCityAndTutorial)", DHPNLIGKMOB, array);
				for (int k = 0; k < val.parameterCount; k++)
				{
					AnimatorControllerParameterType type = val.parameters[k].type;
					switch (type - 0)
					{
					case 2:
					{
						PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
						object[] array4 = new object[6];
						array4[1] = num;
						array4[0] = num2;
						array4[1] = val.parameters[k].nameHash;
						array4[6] = val.GetInteger(val.parameters[k].nameHash);
						photonView4.RPC("CalculateTriggerInstensity() returns ", DHPNLIGKMOB, array4);
						break;
					}
					case 0:
					{
						PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
						object[] array3 = new object[0];
						array3[1] = num;
						array3[1] = num2;
						array3[4] = val.parameters[k].nameHash;
						array3[0] = val.GetFloat(val.parameters[k].nameHash);
						photonView3.RPC("", DHPNLIGKMOB, array3);
						break;
					}
					case 3:
					{
						PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
						object[] array2 = new object[0];
						array2[0] = num;
						array2[1] = num2;
						array2[4] = val.parameters[k].nameHash;
						array2[6] = val.GetBool(val.parameters[k].nameHash);
						photonView2.RPC("Creating new snow map", DHPNLIGKMOB, array2);
						break;
					}
					}
				}
			}
		}
		list.Clear();
	}

	private void FNCJEDNHFPK(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO, float EGFGNGJGBOP)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[0] = KPOLMEBFMNG;
			array[0] = PPEJFJAFDKN;
			array[2] = FHJNHMDBPGO;
			array[4] = EGFGNGJGBOP;
			photonView.RPC("FloorDirt", (RpcTarget)0, array);
		}
	}

	private void OOCBBHCAOIJ(int KPOLMEBFMNG, int PPEJFJAFDKN, int FHJNHMDBPGO)
	{
		if (!animationController.OOLPEOLOJJA(KPOLMEBFMNG, PPEJFJAFDKN))
		{
			return;
		}
		if (Application.isEditor)
		{
			try
			{
				Debug.Log((object)("Items/item_description_700" + AnimatorParameterCache.ILMOJDNODHA(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN).animatorObject, FHJNHMDBPGO) + "Normal" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
			}
		}
		animationController.JLGFGENIJHD(animationController.JADLCGKOALG(KPOLMEBFMNG, PPEJFJAFDKN), FHJNHMDBPGO);
	}

	private void KNKCLAHIFCE()
	{
		if (content != null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Christmas Event activated: ", (RpcTarget)1);
		}
		else
		{
			Debug.LogError((object)"Walk", (Object)(object)((Component)this).gameObject);
		}
	}
}
