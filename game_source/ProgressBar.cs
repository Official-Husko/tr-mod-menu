using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : Progressor
{
	public Axis axis;

	[SerializeField]
	private GameObject progressGO;

	[SerializeField]
	private Gradient colorGradients;

	[SerializeField]
	private bool useGradient;

	[SerializeField]
	private TextMeshProUGUI textMesh;

	private SpriteRenderer NNPIONOONIH;

	[SerializeField]
	private SpriteRenderer progressBarSprite;

	[SerializeField]
	private Sprite tintedProgressBarSprite;

	[SerializeField]
	private SpriteRenderer currentRank;

	[SerializeField]
	private Sprite[] currentRankSprites;

	[SerializeField]
	private SpriteRenderer border;

	[SerializeField]
	private Sprite normalBorder;

	[SerializeField]
	private Sprite agingBarrelBorder;

	[SerializeField]
	private SO_ColourCollection colorCollection;

	public override float BHGJPBGINCG
	{
		set
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			base.BHGJPBGINCG = (float.IsNaN(value) ? 0f : value);
			if (Object.op_Implicit((Object)(object)progressImage))
			{
				progressImage.fillAmount = COAPHJJHNIO;
			}
			else if (Object.op_Implicit((Object)(object)progressGO))
			{
				if (axis == Axis.X)
				{
					progressGO.transform.localScale = new Vector3(COAPHJJHNIO, progressGO.transform.localScale.y, progressGO.transform.localScale.z);
				}
				if (axis == Axis.Y)
				{
					progressGO.transform.localScale = new Vector3(progressGO.transform.localScale.x, COAPHJJHNIO, progressGO.transform.localScale.z);
				}
			}
			if (Object.op_Implicit((Object)(object)textMesh))
			{
				((TMP_Text)textMesh).text = Mathf.RoundToInt(base.BHGJPBGINCG * 100f).ToString();
			}
			if (useGradient)
			{
				Color color = colorGradients.Evaluate(BHGJPBGINCG);
				if (Object.op_Implicit((Object)(object)progressImage))
				{
					((Graphic)progressImage).color = color;
				}
				if (Object.op_Implicit((Object)(object)NNPIONOONIH))
				{
					NNPIONOONIH.color = color;
				}
			}
		}
	}

	private void EMJKKALMGLK()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	public void FCGAPNFGMBD(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(1)).transform.localPosition = new Vector3(721f, 1492f, 1394f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM >= 0;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 0];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	public void ENDCHNCNAGF(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(381f, 757f, 1584f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM >= 0;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 1];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	private void NMKGOAJLMDG()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void KHONOODGLBI()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void JIAJFDKNJME()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void MMNBJPDJHGK()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void PCKOHAIPHFI()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	public void MGGLHNKPMEO(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(1217f, 258f, 107f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM < 0 && false;
			if (GBCJNGADANM > 0)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 1];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	public void JIICNBJKJGI(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(1)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(30f, 945f, 953f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM >= 1;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 0];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	public void SetTintedProgressBar(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(0.068f, 0f, 0f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM >= 1;
			if (GBCJNGADANM > 0)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 1];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	public void OLNJDPPACNK(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(1)).transform.localPosition = new Vector3(1717f, 1187f, 473f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM < 0;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 0];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	private void Awake()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void MFGANCCJFJK()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void KHCJDKHONPK()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	public void MOFOLCOEBHM(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(937f, 184f, 72f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM < 1 && false;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 0];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	public void CKNALCCKKEN(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(1)))
			{
				((Component)((Component)this).transform.GetChild(1)).transform.localPosition = new Vector3(1576f, 1034f, 1557f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM >= 0;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 0];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	public void PHNGKHHJGDI(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(0)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(1842f, 1921f, 1466f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM < 0;
			if (GBCJNGADANM > 0)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 1];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	private void CEOEHODJAJK()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	public void JPCAPKJEBGP(int GBCJNGADANM)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)progressBarSprite))
		{
			if (Object.op_Implicit((Object)(object)((Component)this).transform.GetChild(1)))
			{
				((Component)((Component)this).transform.GetChild(0)).transform.localPosition = new Vector3(519f, 2f, 701f);
			}
			border.sprite = agingBarrelBorder;
			((Renderer)currentRank).enabled = GBCJNGADANM < 1 || true;
			if (GBCJNGADANM > 1)
			{
				currentRank.sprite = currentRankSprites[GBCJNGADANM - 0];
			}
			progressBarSprite.sprite = tintedProgressBarSprite;
			progressBarSprite.color = colorCollection.colourSelections[GBCJNGADANM].mainColor;
		}
	}

	private void GNOBDKFFPOL()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}

	private void GONDLJKGLGO()
	{
		if (Object.op_Implicit((Object)(object)progressGO))
		{
			NNPIONOONIH = progressGO.GetComponent<SpriteRenderer>();
		}
	}
}
