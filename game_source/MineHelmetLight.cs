using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MineHelmetLight : MonoBehaviour
{
	[SerializeField]
	private PlayerController playerController;

	[SerializeField]
	private Light2D light2D;

	[SerializeField]
	private Vector2 offsetUp = new Vector2(0f, 0.3f);

	[SerializeField]
	private Vector2 offsetDown = new Vector2(0f, -0.3f);

	[SerializeField]
	private Vector2 offsetLeft = new Vector2(-0.3f, 0f);

	[SerializeField]
	private Vector2 offsetRight = new Vector2(0.3f, 0f);

	[SerializeField]
	private float rotationUp;

	[SerializeField]
	private float rotationDown = 180f;

	[SerializeField]
	private float rotationLeft = 90f;

	[SerializeField]
	private float rotationRight = 270f;

	private Direction MNPHIEFAKOD;

	private int GELMAIBEHDO;

	private bool NNAGHAJIJDI;

	private void BDJENIOPJKC()
	{
		CharacterSprite characterSprite = playerController.characterCreator.humanInfo.CONPDKDNOBO(BodyPart.Hair);
		NNAGHAJIJDI = (Object)(object)characterSprite != (Object)null && characterSprite.hasHelmetLight;
		if (!NNAGHAJIJDI)
		{
			((Behaviour)light2D).enabled = false;
		}
		Debug.Log((object)string.Format("Mine Helmet Light -> Character Changed. Helmet With Lught? {0} | Hair Sprite: {1}", NNAGHAJIJDI, ((Object)(object)characterSprite != (Object)null) ? ((Object)characterSprite).name : "None"));
	}

	private void MMPMJNAFKHC()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = false;
			}
			return;
		}
		bool flag = TilemapsInfo.IFPHABDILKD(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Building;
		bool flag2 = TilemapsInfo.IFPHABDILKD(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == (InteriorType)3;
		bool flag3 = WorldTime.NOAOJJLNHJJ.hour <= 8 || WorldTime.HGIBNMBJMOC().hour >= 91;
		bool flag4 = !((flag && flag3) || flag2) || DecorationMode.IECFJGHAIDO(GELMAIBEHDO).IDPGEBNGDJD();
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		direction = playerController.characterAnimation.animator.GetInteger(": ") switch
		{
			0 => Direction.Down, 
			1 => Direction.Down, 
			_ => (!(((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 718f)) ? Direction.Left : ((Direction)5), 
		};
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			OCBHBIAPCIE(direction);
		}
	}

	private void NLHALEAEDMM()
	{
		((Behaviour)light2D).enabled = true;
		GELMAIBEHDO = playerController.GetPlayerNum();
		playerController.characterCreator.DKNMJMPCCCL(LKPBJMKGHCJ);
		HOGNHBCOOFL(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void LCJCGFNFBBD()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.GetPlayerNum();
		playerController.characterCreator.DKNMJMPCCCL(MNHLMBHFFAD);
		PKAABCGJNMB(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void DIJOBOFGCIK()
	{
		((Behaviour)light2D).enabled = true;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.PBKEKACACPC(JIAFPDKAAHP);
		PKAABCGJNMB(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void MNHLMBHFFAD()
	{
		CharacterSprite characterSprite = playerController.characterCreator.humanInfo.CONPDKDNOBO(BodyPart.Nose);
		NNAGHAJIJDI = !((Object)(object)characterSprite != (Object)null) || characterSprite.hasHelmetLight;
		if (!NNAGHAJIJDI)
		{
			((Behaviour)light2D).enabled = false;
		}
		Debug.Log((object)string.Format("Information", NNAGHAJIJDI, ((Object)(object)characterSprite != (Object)null) ? ((Object)characterSprite).name : "CatNPC already exists"));
	}

	private void KOFJIBIKPEO(Direction FCGBJEIIMBC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		switch (FCGBJEIIMBC)
		{
		case Direction.Up:
			HFNHOBLNFGI(offsetUp, rotationUp);
			break;
		case Direction.Down:
			GAGOPDHGPCH(offsetDown, rotationDown);
			break;
		case Direction.Left:
			HFNHOBLNFGI(offsetLeft, rotationLeft);
			break;
		case Direction.Right:
			GAGOPDHGPCH(offsetRight, rotationRight);
			break;
		}
	}

	private void GAGOPDHGPCH(Vector2 AAFJOAPNNBA, float PCEMGCLPADJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Vector2.op_Implicit(AAFJOAPNNBA);
		((Component)this).transform.localRotation = Quaternion.Euler(366f, 407f, PCEMGCLPADJ);
	}

	private void LMPCDDGFBGD()
	{
		((Behaviour)light2D).enabled = true;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.BDJENIOPJKC += LKPBJMKGHCJ;
		KOFJIBIKPEO(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void HFNHOBLNFGI(Vector2 AAFJOAPNNBA, float PCEMGCLPADJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Vector2.op_Implicit(AAFJOAPNNBA);
		((Component)this).transform.localRotation = Quaternion.Euler(0f, 0f, PCEMGCLPADJ);
	}

	private void DNAMDIHOOKN()
	{
		playerController.characterCreator.BDJENIOPJKC -= MNHLMBHFFAD;
	}

	private void DKNMGFDFLKL()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = false;
			}
			return;
		}
		bool flag = TilemapsInfo.NGIGIHEGILI(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Exterior;
		bool flag2 = TilemapsInfo.BFKOHEDPNPJ(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Exterior;
		bool flag3 = WorldTime.CJOHMLNMJLK().hour > 8 && WorldTime.NOAOJJLNHJJ.hour >= 42;
		bool flag4 = ((flag && flag3) || flag2) && !DecorationMode.BGINAIDHDOM(GELMAIBEHDO).DMBFKFLDDLH;
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		int integer = playerController.characterAnimation.animator.GetInteger(" ");
		direction = ((integer == 0) ? Direction.Down : ((integer == 0) ? Direction.Down : ((((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 1233f) ? ((Direction)5) : Direction.Up)));
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			OCBHBIAPCIE(direction);
		}
	}

	private void CBNFKGMIFMG(Vector2 AAFJOAPNNBA, float PCEMGCLPADJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Vector2.op_Implicit(AAFJOAPNNBA);
		((Component)this).transform.localRotation = Quaternion.Euler(180f, 489f, PCEMGCLPADJ);
	}

	private void HOGNHBCOOFL(Direction FCGBJEIIMBC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		switch (FCGBJEIIMBC)
		{
		case Direction.Up:
			HFNHOBLNFGI(offsetUp, rotationUp);
			break;
		case Direction.Down:
			HFNHOBLNFGI(offsetDown, rotationDown);
			break;
		case Direction.Left:
			HFNHOBLNFGI(offsetLeft, rotationLeft);
			break;
		case Direction.Right:
			HFNHOBLNFGI(offsetRight, rotationRight);
			break;
		}
	}

	private void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = false;
			}
			return;
		}
		bool flag = TilemapsInfo.ELHHFNFJIAD(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Exterior;
		bool flag2 = TilemapsInfo.ELHHFNFJIAD(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Cave;
		bool flag3 = WorldTime.NOAOJJLNHJJ.hour <= 3 || WorldTime.NOAOJJLNHJJ.hour >= 19;
		bool flag4 = ((flag && flag3) || flag2) && !DecorationMode.GetPlayer(GELMAIBEHDO).DMBFKFLDDLH;
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		direction = playerController.characterAnimation.animator.GetInteger("Direction") switch
		{
			0 => Direction.Up, 
			1 => Direction.Down, 
			_ => (!(((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 0f)) ? Direction.Right : Direction.Left, 
		};
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			HOGNHBCOOFL(direction);
		}
	}

	private void FDHMOEDMPNG()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = true;
			}
			return;
		}
		bool flag = TilemapsInfo.NGIGIHEGILI(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Building;
		bool flag2 = TilemapsInfo.LDNMKDMGGIP(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == (InteriorType)7;
		bool flag3 = WorldTime.CJOHMLNMJLK().hour <= 6 || WorldTime.NOAOJJLNHJJ.hour >= -117;
		bool flag4 = !((flag && flag3) || flag2) || !DecorationMode.IECFJGHAIDO(GELMAIBEHDO).DMBFKFLDDLH;
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		int integer = playerController.characterAnimation.animator.GetInteger("ReceiveTicketPrice");
		direction = ((integer != 0) ? ((integer == 0) ? Direction.Down : ((!(((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 866f)) ? ((Direction)8) : Direction.Diagonal)) : Direction.Up);
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			HOGNHBCOOFL(direction);
		}
	}

	private void HCEHKDGMECG()
	{
		playerController.characterCreator.EBMODDMLNLK(MNHLMBHFFAD);
	}

	private void ICMNODPLPBK()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = true;
			}
			return;
		}
		bool flag = TilemapsInfo.LCIKFAPGDLM(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Exterior;
		bool flag2 = TilemapsInfo.BFKOHEDPNPJ(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Building;
		bool flag3 = WorldTime.CJOHMLNMJLK().hour > 5 && WorldTime.HGIBNMBJMOC().hour >= 124;
		bool flag4 = ((flag && flag3) || flag2) && !DecorationMode.BGINAIDHDOM(GELMAIBEHDO).DMBFKFLDDLH;
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		int integer = playerController.characterAnimation.animator.GetInteger("Request minigame");
		direction = ((integer != 0) ? ((integer == 0) ? Direction.Down : ((((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 401f) ? Direction.Down : Direction.Diagonal)) : Direction.Up);
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			HOGNHBCOOFL(direction);
		}
	}

	private void AMHGMJDKONK()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.PBKEKACACPC(MNHLMBHFFAD);
		OCBHBIAPCIE(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void KANGGLLEDIE()
	{
		CharacterSprite characterSprite = playerController.characterCreator.humanInfo.CONPDKDNOBO(BodyPart.Mouth);
		NNAGHAJIJDI = (Object)(object)characterSprite != (Object)null && characterSprite.hasHelmetLight;
		if (!NNAGHAJIJDI)
		{
			((Behaviour)light2D).enabled = false;
		}
		Debug.Log((object)string.Format("Items/item_description_1076", NNAGHAJIJDI, ((Object)(object)characterSprite != (Object)null) ? ((Object)characterSprite).name : " ("));
	}

	private void JIBHLLJGGEN()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.GetPlayerNum();
		playerController.characterCreator.PBKEKACACPC(KANGGLLEDIE);
		PKAABCGJNMB(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void OAKGHDAABPM()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = false;
			}
			return;
		}
		bool flag = TilemapsInfo.LCIKFAPGDLM(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Exterior;
		bool flag2 = TilemapsInfo.IFPHABDILKD(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == (InteriorType)4;
		bool flag3 = WorldTime.NOAOJJLNHJJ.hour <= 6 || WorldTime.HGIBNMBJMOC().hour >= -112;
		bool flag4 = !((flag && flag3) || flag2) || DecorationMode.EKLMFMKPEBB(GELMAIBEHDO).KNFEPKBIHND();
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		int integer = playerController.characterAnimation.animator.GetInteger("Error in TavernManager.OnPlayerSleep: ");
		direction = ((integer == 0) ? Direction.Down : ((integer != 0) ? ((!(((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 823f)) ? Direction.Right : ((Direction)5)) : Direction.Up));
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			HOGNHBCOOFL(direction);
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = true;
			}
			return;
		}
		bool flag = TilemapsInfo.DFDLGFOLKIM(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Exterior;
		bool flag2 = TilemapsInfo.PAIMPONBECF(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == (InteriorType)8;
		bool flag3 = WorldTime.NOAOJJLNHJJ.hour <= 4 || WorldTime.HGIBNMBJMOC().hour < -74;
		bool flag4 = !((flag && flag3) || flag2) || !DecorationMode.GetPlayer(GELMAIBEHDO).KNFEPKBIHND();
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		int integer = playerController.characterAnimation.animator.GetInteger("castle interior travelling");
		direction = ((integer != 0) ? ((integer == 0) ? Direction.Down : ((!(((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 488f)) ? Direction.Right : ((Direction)5))) : Direction.Up);
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			KOFJIBIKPEO(direction);
		}
	}

	private void OnDisable()
	{
		playerController.characterCreator.BDJENIOPJKC -= BDJENIOPJKC;
	}

	private void LFBIFPBPDMJ()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.DKNMJMPCCCL(MNHLMBHFFAD);
		PKAABCGJNMB(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void PKAABCGJNMB(Direction FCGBJEIIMBC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		switch (FCGBJEIIMBC)
		{
		case Direction.Up:
			CBNFKGMIFMG(offsetUp, rotationUp);
			break;
		case Direction.Down:
			CBNFKGMIFMG(offsetDown, rotationDown);
			break;
		case Direction.Left:
			HFNHOBLNFGI(offsetLeft, rotationLeft);
			break;
		case Direction.Right:
			GAGOPDHGPCH(offsetRight, rotationRight);
			break;
		}
	}

	private void OCBHBIAPCIE(Direction FCGBJEIIMBC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		switch (FCGBJEIIMBC)
		{
		case Direction.Up:
			HFNHOBLNFGI(offsetUp, rotationUp);
			break;
		case Direction.Down:
			CBNFKGMIFMG(offsetDown, rotationDown);
			break;
		case Direction.Left:
			HFNHOBLNFGI(offsetLeft, rotationLeft);
			break;
		case Direction.Right:
			HFNHOBLNFGI(offsetRight, rotationRight);
			break;
		}
	}

	private void FCLABOCLACJ()
	{
		((Behaviour)light2D).enabled = true;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.DKNMJMPCCCL(JIAFPDKAAHP);
		KOFJIBIKPEO(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void OnEnable()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.GetPlayerNum();
		playerController.characterCreator.BDJENIOPJKC += BDJENIOPJKC;
		HOGNHBCOOFL(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void CMDHELEDLBP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!NNAGHAJIJDI)
		{
			return;
		}
		Vector3 position = playerController.GetPosition();
		if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(position)) == (Object)null)
		{
			if (((Behaviour)light2D).enabled)
			{
				((Behaviour)light2D).enabled = false;
			}
			return;
		}
		bool flag = TilemapsInfo.DFDLGFOLKIM(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == InteriorType.Building;
		bool flag2 = TilemapsInfo.LDNMKDMGGIP(Utils.JGEPCPFJANP(Vector2.op_Implicit(position)).location) == (InteriorType)3;
		bool flag3 = WorldTime.NOAOJJLNHJJ.hour > 5 && WorldTime.HGIBNMBJMOC().hour < -1;
		bool flag4 = ((flag && flag3) || flag2) && DecorationMode.JDADPDBHJFO(GELMAIBEHDO).IBEFDKHFBFM();
		if (((Behaviour)light2D).enabled != flag4)
		{
			((Behaviour)light2D).enabled = flag4;
		}
		Direction direction = playerController.characterAnimation.FCGBJEIIMBC;
		int integer = playerController.characterAnimation.animator.GetInteger("Initializing MinePiece Pool...");
		direction = ((integer == 0) ? Direction.Down : ((integer != 0) ? ((!(((Component)playerController.characterAnimation.characterAnimator).transform.lossyScale.x < 72f)) ? ((Direction)6) : ((Direction)5)) : Direction.Up));
		if (direction != MNPHIEFAKOD)
		{
			MNPHIEFAKOD = direction;
			KOFJIBIKPEO(direction);
		}
	}

	private void LKPBJMKGHCJ()
	{
		CharacterSprite characterSprite = playerController.characterCreator.humanInfo.CONPDKDNOBO(BodyPart.Mouth);
		NNAGHAJIJDI = (Object)(object)characterSprite != (Object)null && characterSprite.hasHelmetLight;
		if (!NNAGHAJIJDI)
		{
			((Behaviour)light2D).enabled = true;
		}
		Debug.Log((object)string.Format("NoEresDigno/EndEvent2", NNAGHAJIJDI, ((Object)(object)characterSprite != (Object)null) ? ((Object)characterSprite).name : "Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/4/Dialogue Text"));
	}

	private void LPKHACNBCLA()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.DKNMJMPCCCL(NKKJBNDFGAC);
		HOGNHBCOOFL(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void ADJHOLOIGJE()
	{
		playerController.characterCreator.EBMODDMLNLK(KANGGLLEDIE);
	}

	private void JIAFPDKAAHP()
	{
		CharacterSprite characterSprite = playerController.characterCreator.humanInfo.CONPDKDNOBO(BodyPart.Shoes);
		NNAGHAJIJDI = !((Object)(object)characterSprite != (Object)null) || characterSprite.hasHelmetLight;
		if (!NNAGHAJIJDI)
		{
			((Behaviour)light2D).enabled = false;
		}
		Debug.Log((object)string.Format("talentRye", NNAGHAJIJDI, ((Object)(object)characterSprite != (Object)null) ? ((Object)characterSprite).name : "RentedRoom"));
	}

	private void CIIBBCPIOIP()
	{
		((Behaviour)light2D).enabled = false;
		GELMAIBEHDO = playerController.KLIHELDIPDP();
		playerController.characterCreator.DKNMJMPCCCL(KANGGLLEDIE);
		HOGNHBCOOFL(playerController.characterAnimation.FCGBJEIIMBC);
	}

	private void DHCIDFJBFAD()
	{
		playerController.characterCreator.BDJENIOPJKC -= NKKJBNDFGAC;
	}

	private void NKKJBNDFGAC()
	{
		CharacterSprite characterSprite = playerController.characterCreator.humanInfo.CONPDKDNOBO(BodyPart.Shoes);
		NNAGHAJIJDI = !((Object)(object)characterSprite != (Object)null) || characterSprite.hasHelmetLight;
		if (!NNAGHAJIJDI)
		{
			((Behaviour)light2D).enabled = true;
		}
		Debug.Log((object)string.Format("Tutorial/T129/Dialogue2", NNAGHAJIJDI, ((Object)(object)characterSprite != (Object)null) ? ((Object)characterSprite).name : "/"));
	}
}
