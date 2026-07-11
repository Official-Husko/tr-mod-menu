using UnityEngine;

public class OnlineDog : OnlineObject
{
	private enum JDBLOKANBMI
	{
		StartWalking,
		HeadToBed,
		Eat,
		Pet,
		SetRelationship,
		Teleport
	}

	public DogNPC dogNpc;

	[HideInInspector]
	public bool reproduceInteraction;

	[HideInInspector]
	public DogNPC.DogInteractionType interactionType;

	private float DCGBADKLANM;

	public void SendSetInt(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		SendSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CNOBMCIJHCP(int IHNEJFGAENM)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = IHNEJFGAENM;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void OLJBNNJHAHD(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetTrigger(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	private void ICFHPJHBPDN()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDog(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void PPEIFPHEDPB(string GEGDHHIDEEF)
	{
		NBGHNKGJOEL(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void AIAAGFCKEKN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	protected virtual void FixedUpdate()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO && (Object)(object)((Component)this).transform.parent == (Object)null)
		{
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
	}

	public void MIMNIGBOGJD(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ReceiveSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	private void Start()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDog(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void PDLDLKIEGAO()
	{
		reproduceInteraction = true;
		dogNpc.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: false);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.SetRelationship:
			dogNpc.dogRelationship.SetRelationship((int)GEMFIOKGIMC[0]);
			break;
		case JDBLOKANBMI.Teleport:
			KJDJCMLGGLL = true;
			((Component)this).transform.position = Utils.EKCCGNEDPNO(new Vector3((float)GEMFIOKGIMC[0], (float)GEMFIOKGIMC[1], 0f), 1);
			break;
		}
	}

	public void DPANHCJILJE(int IHNEJFGAENM)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = IHNEJFGAENM;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void GBFGBBNHGAA(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		CJELOEOOEPE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetRelationship(int IHNEJFGAENM)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4, IHNEJFGAENM);
	}

	public void SendFollow()
	{
		OnlineObjectsManager.instance.SendFollow();
	}

	public void SendExitInteraction()
	{
		reproduceInteraction = false;
		OnlineObjectsManager.instance.SendExitInteraction(uniqueId);
	}

	public void GDLPDPCGNEH(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	private void MMPMJNAFKHC()
	{
		if (reproduceInteraction && OnlineManager.HHDBMDMFEMP())
		{
			dogNpc.dogAnimation.ACEPKGEJHDO(interactionType, CDPAMNIPPEC: false);
		}
	}

	public void LLDHLFLJMEE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void LDKNOMGLCNF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void PCHJAACDBBP(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void EGCGHCFLBEI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void EHGKNKDPAPO(int IHNEJFGAENM)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7, IHNEJFGAENM);
	}

	public void MELNFFGJECB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddDogMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void ReceiveSetInt(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void AECFKCDHAAN(int JJPJHIHBOIB)
	{
		dogNpc.Follow(PlayerController.OPHDCMJLLEC(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: false);
	}

	public void DDACFHAFJJF(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.HHDGLBAGEFL(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void APGAMHEPMOJ()
	{
		reproduceInteraction = true;
		OnlineObjectsManager.instance.LFGEJHFKOCC(uniqueId);
	}

	public void LBBCANANBGI(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LLDHLFLJMEE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void UpdateDogPosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddDogMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void OGNBHGDEKGC()
	{
		OnlineObjectsManager.instance.SendFollow();
	}

	public void HIPGDPCBNCL(DogNPC.DogInteractionType IKLDNKDBOPC)
	{
		reproduceInteraction = false;
		interactionType = IKLDNKDBOPC;
	}

	public void DADLADBCEMP(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	private void JHBBABPAJJC()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDog(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void OMJDHCLEHEM(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		KJGGDKELOLA(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JFOFDGEPPAN(int IHNEJFGAENM)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7, IHNEJFGAENM);
	}

	public void BPPPNHHBGON()
	{
		reproduceInteraction = true;
		OnlineObjectsManager.instance.SendExitInteraction(uniqueId);
	}

	public void DBBEBDPOEON(DogNPC.DogInteractionType IKLDNKDBOPC)
	{
		reproduceInteraction = true;
		interactionType = IKLDNKDBOPC;
	}

	public void LOIKFNGGBGN()
	{
		reproduceInteraction = false;
		OnlineObjectsManager.instance.SendExitInteraction(uniqueId);
	}

	public void SendSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MCAPHOCOLEA(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.HHDGLBAGEFL(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void FNNMKJONPBK()
	{
		OnlineObjectsManager.instance.SendUnfollow();
	}

	private void NELBHAMPBPL()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDog(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void IBIGIDLLOLP(string GEGDHHIDEEF)
	{
		DADLADBCEMP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void AAHCPJCKEPB(int GJKKNOKIKBJ)
	{
		dogNpc.dogAnimation.SetTrigger(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void SendReproduceInteraction(DogNPC.DogInteractionType IKLDNKDBOPC)
	{
		if (!reproduceInteraction || interactionType != IKLDNKDBOPC)
		{
			reproduceInteraction = true;
			interactionType = IKLDNKDBOPC;
			OnlineObjectsManager.instance.SendReproduceInteraction(uniqueId, IKLDNKDBOPC);
		}
	}

	public void FDGAAFCGOCH(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		KMELKCONOKI(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void IIICJJHHBGJ()
	{
		OnlineObjectsManager.instance.SendFollow();
	}

	public void GBCPGODJIJC(int IHNEJFGAENM)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = IHNEJFGAENM;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.StartWalking:
			dogNpc.StartWalking();
			break;
		case JDBLOKANBMI.Pet:
			dogNpc.Pet(1, CDPAMNIPPEC: false);
			break;
		}
	}

	public void KJGGDKELOLA(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetTrigger(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void JCDGMIKIKGM(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		MDMENOOLIGE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void JHHILONIIFI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void SendStartWalking()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void KCJCBKABIJK()
	{
		reproduceInteraction = false;
		OnlineObjectsManager.instance.SendExitInteraction(uniqueId);
	}

	public void JMEKBNCDPPH(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		MDMENOOLIGE(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PLDDJNOJOAO(int GJKKNOKIKBJ)
	{
		dogNpc.dogAnimation.FHOAPHBOOAH(GJKKNOKIKBJ);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		dogNpc = ((Component)this).gameObject.GetComponent<DogNPC>();
		dogNpc.onlineDog = this;
		dogNpc.dogAnimation.onlineDog = this;
		dogNpc.dogRelationship.onlineDog = this;
	}

	public void ReceiveReproduceInteraction(DogNPC.DogInteractionType IKLDNKDBOPC)
	{
		reproduceInteraction = true;
		interactionType = IKLDNKDBOPC;
	}

	public void SendPet()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3);
	}

	public void ReceiveSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CBKLLNMGHEG(int IHNEJFGAENM)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = IHNEJFGAENM;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void SendSetInt(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void NMBNKFGDMPK(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void CJELOEOOEPE(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void COEOOHGKCFB(DogNPC.DogInteractionType IKLDNKDBOPC)
	{
		if (!reproduceInteraction || interactionType != IKLDNKDBOPC)
		{
			reproduceInteraction = true;
			interactionType = IKLDNKDBOPC;
			OnlineObjectsManager.instance.SendReproduceInteraction(uniqueId, IKLDNKDBOPC);
		}
	}

	public void AALIPKFGHBJ(DogNPC.DogInteractionType IKLDNKDBOPC)
	{
		if (!reproduceInteraction || interactionType != IKLDNKDBOPC)
		{
			reproduceInteraction = false;
			interactionType = IKLDNKDBOPC;
			OnlineObjectsManager.instance.SendReproduceInteraction(uniqueId, IKLDNKDBOPC);
		}
	}

	public void ReceiveFollow(int JJPJHIHBOIB)
	{
		dogNpc.Follow(PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: false);
	}

	public void GABDIDCMNIL()
	{
		reproduceInteraction = false;
		dogNpc.dogAnimation.GIPAJJKDEJK(CDPAMNIPPEC: false);
	}

	public void CHABHBNKCNH(int JJPJHIHBOIB)
	{
		dogNpc.ICGGFMEPNON(PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: true);
	}

	public void KOPHAGOLKEP(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void BPCJLAJNHKC(int IHNEJFGAENM)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = IHNEJFGAENM;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void ReceiveExitInteraction()
	{
		reproduceInteraction = false;
		dogNpc.dogAnimation.ExitInteraction(CDPAMNIPPEC: false);
	}

	public void INLEIKHGIEB(int JJPJHIHBOIB)
	{
		dogNpc.AACKHOBBDNG(PlayerController.OPHDCMJLLEC(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: false);
	}

	public void NBGHNKGJOEL(int GJKKNOKIKBJ)
	{
		dogNpc.dogAnimation.IDNHDBIKNKP(GJKKNOKIKBJ);
	}

	public void OCHCEONLLMF(int JJPJHIHBOIB)
	{
		dogNpc.Follow(PlayerController.OPHDCMJLLEC(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: false);
	}

	private void LMEJFGKCHEF()
	{
		if (reproduceInteraction && OnlineManager.HHDBMDMFEMP())
		{
			dogNpc.dogAnimation.CKEDDNGKMMK(interactionType, CDPAMNIPPEC: false);
		}
	}

	public void MMPCBGAHBML(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	private void Update()
	{
		if (reproduceInteraction && OnlineManager.ClientOnline())
		{
			dogNpc.dogAnimation.DogAnimations(interactionType, CDPAMNIPPEC: false);
		}
	}

	public void BABGMGCKJCO(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void MDMENOOLIGE(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.HHDGLBAGEFL(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void APGKMHDMIKF(string GEGDHHIDEEF)
	{
		DADLADBCEMP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ABHNGOCKJDP(int GJKKNOKIKBJ)
	{
		dogNpc.dogAnimation.SetTrigger(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void IBGFJMLEIGI()
	{
		reproduceInteraction = true;
		OnlineObjectsManager.instance.LFGEJHFKOCC(uniqueId);
	}

	public void NAKFBDOPMEK(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		DDACFHAFJJF(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void EEIEGFHJOGI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddDogMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void SendSetTrigger(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendUnfollow()
	{
		OnlineObjectsManager.instance.SendUnfollow();
	}

	public void AKOBBHJLINB(string GEGDHHIDEEF)
	{
		GDLPDPCGNEH(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ReceiveSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		dogNpc.dogAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void ReceiveSetInt(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ReceiveSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void KMELKCONOKI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetTrigger(int GJKKNOKIKBJ)
	{
		dogNpc.dogAnimation.SetTrigger(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void ReceiveUnfollow(int JJPJHIHBOIB)
	{
		dogNpc.Unfollow(PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: false);
	}

	public void MALGOKMEACM(int JJPJHIHBOIB)
	{
		dogNpc.KKIJHAOIAHL(PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByActorNumber(JJPJHIHBOIB)), CDPAMNIPPEC: false);
	}

	public void AFFJAAGLCDB(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		EGCGHCFLBEI(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MLOHKGDEKLF()
	{
		OnlineObjectsManager.instance.SendUnfollow();
	}

	public void JDDODODGDKL(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	protected virtual void AHPNEDOLBII()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO && (Object)(object)((Component)this).transform.parent == (Object)null)
		{
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 0);
		}
	}
}
