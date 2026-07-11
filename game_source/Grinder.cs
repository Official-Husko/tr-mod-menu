using UnityEngine;

public class Grinder : Crafter
{
	[SerializeField]
	private SpriteAnimation cerealSpriteAnimation;

	private void OELOMPMGHKN()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	protected override void LADOIOGPHKL()
	{
		base.LADOIOGPHKL();
		FMEKEFEIDPN();
	}

	public override void CancelAllCrafting(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		base.CancelAllCrafting(JIIGOACEIKL, GFNHAMCPEAK);
		FMEKEFEIDPN();
	}

	private void CEIAOPBLBIN()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}

	private void GOHAMEGHPNM()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void HKGAJAKGAKJ()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	protected override void IMEMCJJDDIG(bool NJHMBMGKCPL)
	{
		base.IMEMCJJDDIG(NJHMBMGKCPL);
		FMEKEFEIDPN();
	}

	private void FMPFPBKMPHH()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}

	private void NFNGDKHKMHJ()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void NECNDOEIPDJ()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void FLCIEOACMHN()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void FGBFOEDBMKI()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	protected override void GMMNIIKNGNH(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO, bool CDPAMNIPPEC)
	{
		base.GMMNIIKNGNH(JIIGOACEIKL, FFNGGJENDKI, OOMMCABDBGO, CDPAMNIPPEC);
		if (FFNGGJENDKI.recipe.time.LNPODHBKGCH())
		{
			FMEKEFEIDPN();
			return;
		}
		GameDate.Time lGLDPMAABLA = FFNGGJENDKI.recipe.EOLGJFPONID();
		cerealSpriteAnimation.CalculateFrameRate(GameDate.BJENFLGPHHN(lGLDPMAABLA));
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void POPELPPKDAJ()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}

	private void ABCNEBCICOP()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void FKBBKOPJPMK()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}

	private void FMEKEFEIDPN()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}

	private void MJJMKKGCEFH()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void JDAJDKGAOMA()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void OGIAIAENPNC()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}

	private void NEKIIFIPJAL()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(true);
	}

	private void GKKIAOLMFFI()
	{
		((Component)cerealSpriteAnimation).gameObject.SetActive(false);
	}
}
