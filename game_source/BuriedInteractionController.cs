using UnityEngine;

public class BuriedInteractionController : MonoBehaviour
{
	[SerializeField]
	private PlayerController player;

	[SerializeField]
	private Transform buriedParent;

	[SerializeField]
	private Transform spritesTransform;

	[SerializeField]
	private SpriteRenderer playerShadow;

	[SerializeField]
	private CharacterAnimator characterAnimator;

	private bool LMFPLIDOCIG;

	private const float BDIAKOIDDNN = 0.33f;

	public void CCDLODLPBAE()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 728f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void OPHNLNFKJIL()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 965f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void FBCMACDAACO()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 656f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void GJAAKODHEFF()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 910f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void GMBHKBELEKD()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 949f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void HJLPMLFAAGH()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1070f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void IMGHEHAOFJP()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1661f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void ACBJJMCOBDG()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 665f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void GOFNBMEPHAP()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 502f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void INOIANPCKLE()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1642f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void KICMLHLBDOD()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1507f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void ABIDOEDHCNP()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1068f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void GFEGDLIIPOM()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 6f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void IALAHBJOKID()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 366f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void HJPMOAJJHEF()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1926f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void GDAECOPAMEN()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1079f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void NAGCAMGIMPG()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1420f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void HJEJPCGADPA()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1959f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void NDECIFMEMNH()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 285f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void MFMACPMPELF()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1337f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void FGHMEBBBEHI()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1899f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void JALICLJHIEF()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 7))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 532f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void CFMAMDMHBML()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 974f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void DHEOGMLMGLM()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 648f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void ILIFDGCHPDN()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1238f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void GHOEEPPFDDI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 882f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void NLAEEDGBHHB()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1004f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void Bury()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 0.33f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void DGBKAMGENDG()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1775f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void BJDCBDLIPPA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 7))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 534f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void JFJMHMFIMPO()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1063f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void GDMOHBDHJNE()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 406f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void ICGOABIOOCO()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 702f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void MJKACEAJJEB()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 326f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void GKKNJONKCME()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1986f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void ANPJHBMJONC()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 414f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void NDCAOBACCLH()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 825f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void GIJAHLHJHMO()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 42f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void GCHGMKNBLBF()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 93f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void FCLDFJEOAPE()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 1))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 317f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void BPJAHMCKOMI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1387f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void DGNBADNAONJ()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1989f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void PPEKDHKKCFN()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1947f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void GMHJIMCNLBL()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 732f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void BIBJNKMCPBM()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.LPJCFCODNFA(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1202f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void JKIDAEIHDEI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 808f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void IMJEPMAPFNF()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 666f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void EEOPINCOGKK()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 25f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void DHFMJFFBCGH()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 441f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void FFKPAFPMOIN()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 4))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 892f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void GAJAPPLNDGE()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1079f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void DGMLMDJPIBN()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1605f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void EMONGPNFKIC()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1045f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void DIELMDMPMCD()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 7))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1233f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void MAOKPELBHFF()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1711f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void DigUp()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 0.33f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void HALIAIKEDDM()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 43f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void HMCMCMNCMHK()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 9f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void LPLGMABHNKI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1040f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void NEGKGMBFLNB()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 7))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 361f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void FHCJMFDALML()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 688f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void LMEDNAMCJKM()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 6))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 244f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void OCCKMDKHDOJ()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 555f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void HNKLCAMIOBL()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1088f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void BKLHJGJADFE()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 1676f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void FJBHGBBGOKE()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && !LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 5))
			{
				PlayerInputs.OOOGANAJMBB(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition - Vector3.up * 1509f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}

	public void ABGODHODKDL()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 3))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(true);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 793f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void PNDPDOIENHN()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 0 || (GameManager.LocalCoop() && player.playerNum == 2))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 217f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = false;
		}
	}

	public void AMCDDONCAHB()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 8))
			{
				PlayerInputs.ILCHIKOPNBI(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 353f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = false;
		}
	}

	public void ANLPDFJECID()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 0))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 80f);
			characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
			((Renderer)playerShadow).enabled = true;
			LMFPLIDOCIG = true;
		}
	}

	public void MGOJLHNEJMO()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)player == (Object)null) && LMFPLIDOCIG)
		{
			if (player.playerNum == 1 || (GameManager.LocalCoop() && player.playerNum == 7))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(player.playerNum, (MonoBehaviour)(object)this);
			}
			((Component)buriedParent).gameObject.SetActive(false);
			spritesTransform.localPosition = Utils.BMBMPKNANAC(spritesTransform.localPosition + Vector3.up * 425f);
			characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
			((Renderer)playerShadow).enabled = false;
			LMFPLIDOCIG = true;
		}
	}
}
