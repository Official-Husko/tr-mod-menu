using UnityEngine;
using psai.net;

public class PsaiTriggerOnButtonDown : PsaiSynchronizedTrigger
{
	public KeyCode triggerKeyCode = (KeyCode)323;

	public float minimumIntensity = 0.1f;

	public float maximumIntensity = 1f;

	public float intensityGainPerTick = 0.1f;

	public void POFDOILPANH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void JPHFCJIBBMI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void NIHJCJJKDBA()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void IIOHMDNGFDH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void JLPLLHKJEMH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void MMPMJNAFKHC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void MGMLDHPOLGK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void IBAPBHIBOOO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void CMDHELEDLBP()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void MNFMLJJBKNC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void OGNIDHAIABM()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void JMDOCHBJGKG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public override float CalculateTriggerIntensity()
	{
		if (PsaiCore.IsInstanceInitialized())
		{
			float num = Mathf.Min(PsaiCore.Instance.GetPsaiInfo().currentIntensity + intensityGainPerTick, maximumIntensity);
			if (num < minimumIntensity)
			{
				num = minimumIntensity;
			}
			Debug.Log((object)("CalculateTriggerInstensity() returns " + num));
			return num;
		}
		return 0f;
	}

	public void LAABMDDEGCG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void BHLHCOALABE()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void JBGFGOCPEFD()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void EBFJOAEJPGE()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void HIPNEFOEJPL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void NEPDNLPCCON()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void BBCPDBEOOKL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public new void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void IAICCKPOBMJ()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void MFPEIPCMEEB()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public override bool EvaluateTriggerCondition()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKey(triggerKeyCode);
	}

	public void AAOMCHHNKKM()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void DKNMGFDFLKL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void OGBGFLMKFHH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void OHGABHEDILE()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void PKEPBKHEDOD()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void EJEEIIGEGOC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void FPOIFOGELHC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void LMFICKFGEFI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void EMCCGDFOPEH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void DOKHLDBIDJB()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void ICMNODPLPBK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void FDHMOEDMPNG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void FGGPGOEAEKK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void OAKGHDAABPM()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void GOJHCINMAJD()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void AKLEFPLEGKK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void CKCHKHNBBFG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void PMPLNGEAAII()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void HCPKBJDHLAC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void GOJFGHKOFMF()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void PJLKGOACDEN()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void BHKNJOEBCKA()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void OFDEGDJGGGF()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public PsaiTriggerOnButtonDown()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		PGNDCDCGANJ = true;
	}

	public void MCLAJGDIIBK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void ELHCBGCEJDH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}

	public void LEDIGKGAFHC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!fireContinuously)
		{
			if (Input.GetKeyDown(triggerKeyCode))
			{
				PBIABMHBDCA();
			}
		}
		else
		{
			base.Update();
		}
	}
}
