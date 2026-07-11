using AlmenaraGames;
using UnityEngine;

public class PruebaPico : MonoBehaviour
{
	public Animator animator;

	public Rigidbody2D rb;

	public AudioObject pickSound;

	public float horizontalMove;

	public float verticalMove;

	private Vector3 EODIDNILDIF;

	private bool HFECMNIFMFI;

	private bool LNLEDKEDGPF;

	private float HGMFJBLNCJJ = 2f;

	private void EBFJOAEJPGE()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN("replay fish");
		verticalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN("Dialogue System/Conversation/Gass_Quest/Entry/40/Dialogue Text");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Dialogue System/Conversation/NeutralInTavern/Entry/9/Dialogue Text", HFECMNIFMFI);
		bool flag = PlayerInputs.DEGBDMMDIIL(1).ENIPCNOKAOM("Comfort");
		animator.SetBool("OnConversationStarted MothersRecipe Event ", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName(" CloseUI ConstructionUI") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1616f;
			EODIDNILDIF.y = 1528f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)8)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(723f, 1770f, 1187f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(423f, 1070f, 1365f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void DGDCMLPELHD()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void IDNLJFAIDFN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void JLPLLHKJEMH()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GetAxis("Bucket");
		verticalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN("RPC Receive Talent From Other ");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("hForHours", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).JDLEBBLKOFF("ReceiveUnfollow");
		animator.SetBool("VerticalMove", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Milk") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 611f;
			EODIDNILDIF.y = 971f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1683f, 652f, 243f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1170f, 1711f, 1277f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void MENCIOFBFIE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void ODJPLNDJKEA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void EEPKGNNILBE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void LEHEIGEJHAL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	public void IDIDJCCKPBI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	public void BECACCHEBNB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void NIHJCJJKDBA()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GetAxis("Fake");
		verticalMove = PlayerInputs.DEGBDMMDIIL(1).GetAxis(":");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting.", HFECMNIFMFI);
		bool button = PlayerInputs.DEGBDMMDIIL(0).GetButton("BobProgress");
		animator.SetBool("vibration", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Direction") && !button)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 250f;
			EODIDNILDIF.y = 1418f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Diagonal)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1582f, 1401f, 423f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(548f, 635f, 459f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void AFKGJCIANOF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void GHEHLJANBCF()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(1).GetAxis("LucenFall");
		verticalMove = PlayerInputs.GetPlayer(1).GetAxis("Dig");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("SkillPoints", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(1).ENIPCNOKAOM("ReceiveBarkInfoWithObjectAndLuaInt");
		animator.SetBool("LearnPrecision", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("parent null: {0}, ") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 643f;
			EODIDNILDIF.y = 1622f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Right)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1745f, 1267f, 1118f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1442f, 1965f, 769f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(0).GetAxis("Player2");
		verticalMove = PlayerInputs.DEGBDMMDIIL(0).GetAxis("ThemeListView");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Seed", HFECMNIFMFI);
		bool button = PlayerInputs.GetPlayer(1).GetButton("bed");
		animator.SetBool("NeedsRecipe", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("") && !button)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 176f;
			EODIDNILDIF.y = 178f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1539f, 936f, 1277f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(483f, 1086f, 706f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	public void HPJHHOIFKEI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void MJENOBKFPIN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void GJAHFEANJKH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	public void NJNJHNLLODN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void OONONNJFEFL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GetAxis("");
		verticalMove = PlayerInputs.GetPlayer(0).GetAxis("TabernaClausurada/MaiDialogue 02");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("City/Kujaku/Bark/Bye", HFECMNIFMFI);
		bool button = PlayerInputs.GetPlayer(1).GetButton("Festín del Juramento/JudgeDialogue 03");
		animator.SetBool("Chisel", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("A game with this code does not exist on this region.\nPlease, make sure both players are playing on the same region.") && !button)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 130f;
			EODIDNILDIF.y = 1807f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1196f, 1934f, 672f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(489f, 335f, 1157f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void DKNMGFDFLKL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN("UI");
		verticalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN("MainProgress");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Not enough recipe fragments", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).DEPIHKBMKLP("Pathfinding error startPos: ");
		animator.SetBool("Room Index: {0}, Selected Room: {1}", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Items/item_description_1181") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1147f;
			EODIDNILDIF.y = 514f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Up)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(3f, 1888f, 1120f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1542f, 1491f, 414f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	public void ToolAction()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	public void DCAFNFILPLH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void BBCPDBEOOKL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GNCBKEDHLHN("");
		verticalMove = PlayerInputs.GetPlayer(1).GetAxis("OnSeasonChanged to ");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("UI2", HFECMNIFMFI);
		bool flag = PlayerInputs.DEGBDMMDIIL(0).DEPIHKBMKLP("NoEresDigno/EndEvent");
		animator.SetBool("PlayerJoined_F", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Wilson/Trash") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 98f;
			EODIDNILDIF.y = 1567f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)8)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(851f, 1509f, 622f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(329f, 708f, 1768f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void NEPDNLPCCON()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(0).GetAxis("Player2");
		verticalMove = PlayerInputs.DEGBDMMDIIL(1).GNCBKEDHLHN("Dialogue System/Conversation/TooHot/Entry/1/Dialogue Text");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("ReceiveObjectActionSimple", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(1).JDLEBBLKOFF("ReceiveCalculateRandomPositionsInTavernMaster");
		animator.SetBool("Already learnt!", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName(" x ") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 791f;
			EODIDNILDIF.y = 805f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(587f, 254f, 1218f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(802f, 1490f, 1929f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void DGIFHBIJDDE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void OOGMGIPKMAP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(1).GNCBKEDHLHN(" x ");
		verticalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN(" : ");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Player/Bark/Error/NotAllPlayersHere", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).DEPIHKBMKLP("No seat found!");
		animator.SetBool("Year", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("\n\n\nMine Level Info:\n") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 116f;
			EODIDNILDIF.y = 1139f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1498f, 96f, 1292f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1307f, 128f, 1434f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void IGKPEBGHPGD()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.");
		verticalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN("Closed_eyebrows");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}", HFECMNIFMFI);
		bool button = PlayerInputs.DEGBDMMDIIL(0).GetButton("Cheese making");
		animator.SetBool("LoadGameplaySceneOnline masterClient", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text") && !button)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1101f;
			EODIDNILDIF.y = 837f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1213f, 753f, 328f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1829f, 537f, 1760f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void FixedUpdate()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void OGBGFLMKFHH()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(1).GetAxis("ReceivePipeTileSwap");
		verticalMove = PlayerInputs.GetPlayer(1).GetAxis("ReceiveTalentFromOther");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("ReceiveInfoCrops", HFECMNIFMFI);
		bool button = PlayerInputs.GetPlayer(0).GetButton("Unaged Brie");
		animator.SetBool(" not found", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Ach_") && !button)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 549f;
			EODIDNILDIF.y = 165f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Diagonal)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1807f, 481f, 1772f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1297f, 1527f, 769f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(0).GetAxis("SetHiddenAnimatorObjectTriggerRPC");
		verticalMove = PlayerInputs.DEGBDMMDIIL(1).GNCBKEDHLHN("onlineregion");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("[ControllerType:", HFECMNIFMFI);
		bool flag = PlayerInputs.DEGBDMMDIIL(1).DEPIHKBMKLP("Buy");
		animator.SetBool("Estufa duplicada eliminada", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("NewCharacters/") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1979f;
			EODIDNILDIF.y = 1523f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)6)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1513f, 60f, 915f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1082f, 1957f, 518f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void EHBFECEJGCE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void HFFBJFEOFDP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void GFABFDHPJOK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void OGFKFGAMGCE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void Update()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GetAxis("HorizontalMove");
		verticalMove = PlayerInputs.GetPlayer(1).GetAxis("VerticalMove");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Walk", HFECMNIFMFI);
		bool button = PlayerInputs.GetPlayer(1).GetButton("Interact");
		animator.SetBool("Pick", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Pick") && !button)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 0f;
			EODIDNILDIF.y = 0f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Left)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(-1f, float.NaN, float.NaN);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1f, float.NaN, float.NaN);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void PFNIPILPGFN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void MAGACCHLAOE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN("sForSeconds");
		verticalMove = PlayerInputs.DEGBDMMDIIL(1).GNCBKEDHLHN("[^0-9]");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("StaffCost", HFECMNIFMFI);
		bool flag = PlayerInputs.DEGBDMMDIIL(1).ENIPCNOKAOM("Cannot load old character saved");
		animator.SetBool(" ", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("DemolishConfirmationWithAnimals") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 481f;
			EODIDNILDIF.y = 305f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Right)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(130f, 750f, 1677f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1197f, 1283f, 214f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void EIOFKDODGKK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void LLLHAHJIKMO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void ADJMGPNBDGF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void BHKNJOEBCKA()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(0).GetAxis("Items/item_description_646");
		verticalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN("]");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("itemCourgette", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(1).JDLEBBLKOFF("Error_InvalidPositions");
		animator.SetBool("Items/item_name_", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Finished!") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 418f;
			EODIDNILDIF.y = 187f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Down)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1010f, 200f, 136f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1983f, 1157f, 1258f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	public void AFMOIDJHAPD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void MOEJIBLELHP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void DBNAJMBFJEG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	private void GIHCKNBINMG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void OKJINJCLPJC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void GJGMDNEKAEG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void BENLLIGGEEN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void JPHFCJIBBMI()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GNCBKEDHLHN("itemWheatBread");
		verticalMove = PlayerInputs.DEGBDMMDIIL(1).GetAxis(" / ");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Myu", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).ENIPCNOKAOM("Attack/MainEvent 11");
		animator.SetBool("Could not download shared file for reason ", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("New Text start") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1592f;
			EODIDNILDIF.y = 20f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Left)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1976f, 240f, 1937f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(848f, 21f, 1480f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	public void HPDBIBFGLPB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void JBGFGOCPEFD()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(1).GetAxis("ReceiveWorkArea");
		verticalMove = PlayerInputs.GetPlayer(1).GNCBKEDHLHN("Beard");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Sending upgrade tool RPC for toolID: ", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(1).ENIPCNOKAOM("waterBowlDesc");
		animator.SetBool("Toy", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("RecieveSetAmbience") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1578f;
			EODIDNILDIF.y = 272f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Left)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(910f, 325f, 849f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1810f, 993f, 1496f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void IBAPBHIBOOO()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GetAxis("Upgrade Tavern");
		verticalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN("popUpBuilding7");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Player2", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(1).ENIPCNOKAOM("");
		animator.SetBool("City/Hallmund/Bark/Buy", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("quest_description_") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 1453f;
			EODIDNILDIF.y = 628f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Right)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1061f, 1597f, 354f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1606f, 241f, 911f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void FDHMOEDMPNG()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(0).GNCBKEDHLHN("Player");
		verticalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN("Place");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("add item ", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).JDLEBBLKOFF("UISelectGamepad");
		animator.SetBool("dForDays", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("ReceiveInfoTerrain") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 860f;
			EODIDNILDIF.y = 591f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)8)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(188f, 1035f, 376f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1454f, 1850f, 322f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	public void LFBCHBMJGBF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void DDLLFPICOJK()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(0).GNCBKEDHLHN("D-Pad Down");
		verticalMove = PlayerInputs.GetPlayer(1).GNCBKEDHLHN("<color=#A87700>");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("' Please make sure the file is located within your Assets/Resources/ folder. [", HFECMNIFMFI);
		bool flag = PlayerInputs.DEGBDMMDIIL(0).ENIPCNOKAOM("Dialogue System/Conversation/Gass_Introduce/Entry/14/Dialogue Text");
		animator.SetBool("Dialogue System/Conversation/Gass_Quest/Entry/28/Dialogue Text", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName(":</color> ") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 669f;
			EODIDNILDIF.y = 1366f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Up)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1468f, 1428f, 1001f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1538f, 1476f, 893f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(1).GNCBKEDHLHN("Options");
		verticalMove = PlayerInputs.GetPlayer(1).GetAxis("Get Components ");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Chat end edit", HFECMNIFMFI);
		bool button = PlayerInputs.GetPlayer(1).GetButton("BockTopAbbreviation");
		animator.SetBool("LE_14", button);
		if (!LNLEDKEDGPF)
		{
			if (button)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName(" is Reading.") && !button)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 657f;
			EODIDNILDIF.y = 361f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Down)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1309f, 201f, 573f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(192f, 407f, 1262f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	public void GKEAIKMBFFB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void NODDNBFDJGO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (HFECMNIFMFI)
		{
			rb.MovePosition(Vector2.op_Implicit(Utils.BMBMPKNANAC(((Component)this).transform.position + EODIDNILDIF * HGMFJBLNCJJ * Time.fixedDeltaTime)));
		}
	}

	public void OCNOKDFBEMH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	public void PCPHJJDCPNI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(pickSound, Vector3.zero);
	}

	private void MCLAJGDIIBK()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.GetPlayer(0).GetAxis("ReceiveConstructionModeClosed");
		verticalMove = PlayerInputs.DEGBDMMDIIL(1).GNCBKEDHLHN("ReceiveSkipKlaynChallenge");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Items/item_description_729", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).ENIPCNOKAOM("[MinePuzzleManager] Puzzle {0} placed with {1} elements.");
		animator.SetBool("Items/item_name_1102", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("sprout seeds") && !flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 980f;
			EODIDNILDIF.y = 1565f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == Direction.Right)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(71f, 906f, 732f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(675f, 1687f, 1350f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}

	private void POFDOILPANH()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		horizontalMove = PlayerInputs.DEGBDMMDIIL(1).GetAxis("Next Item");
		verticalMove = PlayerInputs.GetPlayer(1).GNCBKEDHLHN("BarnTutorialDone");
		EODIDNILDIF = new Vector3(horizontalMove, verticalMove);
		HFECMNIFMFI = EODIDNILDIF != Vector3.zero;
		animator.SetBool("Tutorial/T300/Dialogue2", HFECMNIFMFI);
		bool flag = PlayerInputs.GetPlayer(0).DEPIHKBMKLP("connect");
		animator.SetBool("MainProgress", flag);
		if (!LNLEDKEDGPF)
		{
			if (flag)
			{
				LNLEDKEDGPF = true;
			}
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(1);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("Dialogue System/Conversation/Gass_Quest/Entry/5/Dialogue Text") && !flag)
			{
				LNLEDKEDGPF = false;
			}
		}
		if (LNLEDKEDGPF)
		{
			EODIDNILDIF.x = 705f;
			EODIDNILDIF.y = 1106f;
		}
		if (EODIDNILDIF != Vector3.zero)
		{
			if (Utils.EIDFHLPBICI(Vector2.op_Implicit(EODIDNILDIF)) == (Direction)7)
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(760f, 174f, 338f);
			}
			else
			{
				((Component)this).transform.localScale = ((Component)this).transform.localScale.PKDHIDFHFMO(1610f, 319f, 1208f);
			}
			((Vector3)(ref EODIDNILDIF)).Normalize();
		}
	}
}
