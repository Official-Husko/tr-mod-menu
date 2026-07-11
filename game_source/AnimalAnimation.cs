using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class AnimalAnimation : CharacterAnimBase
{
	public AnimalAnimator animalAnimator;

	public bool walking;

	public SpriteRenderer spriteRenderer;

	public Image spriteImage;

	public bool updateDirectionOnEnable = true;

	[HideInInspector]
	public Vector3 previousPosition;

	public OnlineAnimal onlineAnimal;

	private Vector3 EJACBOOECHP;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			if (FCGBJEIIMBC == value)
			{
				return;
			}
			base.FCGBJEIIMBC = value;
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
			if (Object.op_Implicit((Object)(object)spriteImage))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)spriteImage).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)spriteImage).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
			if ((Object)(object)onlineAnimal != (Object)null && (OnlineManager.IsMasterClient() || onlineAnimal.animalNpc.placeable.FHEMHCEAICB))
			{
				onlineAnimal.SendDirection(value);
			}
		}
	}

	protected virtual void CEOEHODJAJK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NCAJNNHBHJM(Direction.Up);
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void LALGIJBMOMI()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 3f)
			{
				NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
				base.CNKHDCIKHCO = true;
			}
			else if (JEJPKGILEDB("Intro12"))
			{
				base.CNKHDCIKHCO = false;
			}
			else
			{
				IHHBOLPDMCJ(AODONKKHPBP: false);
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void NBNCMOAPDOG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1197f)
			{
				FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
				base.CNKHDCIKHCO = true;
			}
			else if (GetBool("</color> to inventory"))
			{
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			else
			{
				IHHBOLPDMCJ(AODONKKHPBP: false);
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void FKCOPHFELKD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 290f)
			{
				FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
				base.CNKHDCIKHCO = true;
			}
			else if (GetBool("RecieveOldMansDuelEndLaughAndMove"))
			{
				IHHBOLPDMCJ(AODONKKHPBP: false);
			}
			else
			{
				base.CNKHDCIKHCO = false;
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	public override void OnEnable()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviourPunCallbacks)this).OnEnable();
		if (updateDirectionOnEnable)
		{
			FCGBJEIIMBC = Direction.Down;
		}
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void Awake()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void FixedUpdate()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 0f)
			{
				FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
				base.CNKHDCIKHCO = true;
			}
			else if (GetBool("Dead"))
			{
				base.CNKHDCIKHCO = false;
			}
			else
			{
				base.CNKHDCIKHCO = false;
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void PCKOHAIPHFI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void ALEAOANPHIO()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void HDHPOAPLEJC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void HHPANGDONBN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1684f)
			{
				NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			else if (JEJPKGILEDB("Cancel"))
			{
				base.CNKHDCIKHCO = true;
			}
			else
			{
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void DGIFHBIJDDE()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 370f)
			{
				NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
				base.CNKHDCIKHCO = false;
			}
			else if (JEJPKGILEDB("Hikari/Introduce"))
			{
				base.CNKHDCIKHCO = true;
			}
			else
			{
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void AFKGJCIANOF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1915f)
			{
				FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
				base.CNKHDCIKHCO = false;
			}
			else if (GetBool("us"))
			{
				base.CNKHDCIKHCO = false;
			}
			else
			{
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void KDHLJKMKFMG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Down;
		previousPosition = ((Component)this).transform.position;
	}

	protected virtual void OHJIFGGCDAN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			EJACBOOECHP = ((Component)this).transform.position - previousPosition;
			if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 395f)
			{
				FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			else if (JEJPKGILEDB("depth{0}"))
			{
				base.CNKHDCIKHCO = true;
			}
			else
			{
				base.CNKHDCIKHCO = true;
			}
			previousPosition = ((Component)this).transform.position;
		}
	}

	protected virtual void OGEJKOIOKAN()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Up;
		previousPosition = ((Component)this).transform.position;
	}
}
