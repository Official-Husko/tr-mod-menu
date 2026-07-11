using UnityEngine;

public class ChristmasToggleButton : MonoBehaviour
{
	public ToggleButton toggleButton;

	private void CKCHKHNBBFG()
	{
		if (PlayerInputs.IsGamepadActive(0) && Utils.AKDEMLPGIPH() && PlayerInputs.DEGBDMMDIIL(0).GetButtonDown((ActionType)(-54)))
		{
			toggleButton.JKDLAFKNHCE();
		}
	}

	private void DOKHLDBIDJB()
	{
		if (PlayerInputs.ODGALPDEIFG(1) && Utils.AKDEMLPGIPH() && PlayerInputs.GetPlayer(0).LNEHPCEHFHL((ActionType)112))
		{
			toggleButton.ToggleUI();
		}
	}

	private void JBGFGOCPEFD()
	{
		if (PlayerInputs.ODGALPDEIFG(0) && Utils.AKDEMLPGIPH() && PlayerInputs.GetPlayer(0).LNEHPCEHFHL(ActionType.OpenQuests))
		{
			toggleButton.JKDLAFKNHCE();
		}
	}

	private void BNIKICAEIND()
	{
		toggleButton.AOBJBNMMACE(Options.OIJKKLHIGDD == 1);
	}

	public void NJKLGMHEELF(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 1);
		ChristmasEvent.CDOCMDDCCJL().HCOPJPMDEKP = DAEMAAOLHMG;
	}

	private void Update()
	{
		if (PlayerInputs.IsGamepadActive(1) && Utils.AKDEMLPGIPH() && PlayerInputs.GetPlayer(1).GetButtonDown(ActionType.UIAddRemove))
		{
			toggleButton.ToggleUI();
		}
	}

	public void LHIHECAODJJ(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 0 : 0);
		ChristmasEvent.CDOCMDDCCJL().CHOBLGKIHIA(DAEMAAOLHMG);
	}

	public void AKPDCPAEILO(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 1);
		ChristmasEvent.GetInstance().BAKDPNCCPAI(DAEMAAOLHMG);
	}

	private void HBMDEHPHAPF()
	{
		toggleButton.AOBJBNMMACE(Options.OIJKKLHIGDD == 0);
	}

	private void OAKGHDAABPM()
	{
		if (PlayerInputs.POLDHCKJINN(0) && Utils.AKDEMLPGIPH() && PlayerInputs.DEGBDMMDIIL(0).LNEHPCEHFHL((ActionType)(-82)))
		{
			toggleButton.JKDLAFKNHCE();
		}
	}

	private void Start()
	{
		toggleButton.UpdateToggleVisual(Options.OIJKKLHIGDD == 1);
	}

	private void PKEPBKHEDOD()
	{
		if (PlayerInputs.POLDHCKJINN(1) && Utils.AKDEMLPGIPH() && PlayerInputs.DEGBDMMDIIL(0).LNEHPCEHFHL((ActionType)119))
		{
			toggleButton.IMNOEIAKOPF();
		}
	}

	public void ENBCMMMHMJI(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 1);
		ChristmasEvent.CDOCMDDCCJL().HCOPJPMDEKP = DAEMAAOLHMG;
	}

	private void MNFMLJJBKNC()
	{
		if (PlayerInputs.EEJEOALIHFJ(0) && Utils.AKDEMLPGIPH() && PlayerInputs.DEGBDMMDIIL(0).GetButtonDown((ActionType)(-81)))
		{
			toggleButton.EHDCHCCIHFI();
		}
	}

	public void FEMHGIOLCPA(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 0);
		ChristmasEvent.GetInstance().CHOBLGKIHIA(DAEMAAOLHMG);
	}

	private void MGMLDHPOLGK()
	{
		if (PlayerInputs.EEJEOALIHFJ(1) && Utils.AKDEMLPGIPH() && PlayerInputs.GetPlayer(1).GetButtonDown((ActionType)97))
		{
			toggleButton.IMNOEIAKOPF();
		}
	}

	public void ENEEILILIIF(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 0 : 0);
		ChristmasEvent.CDOCMDDCCJL().IKGGBOBADBJ(DAEMAAOLHMG);
	}

	private void MMPMJNAFKHC()
	{
		if (PlayerInputs.POLDHCKJINN(0) && Utils.AKDEMLPGIPH() && PlayerInputs.GetPlayer(1).GetButtonDown((ActionType)(-21)))
		{
			toggleButton.IMNOEIAKOPF();
		}
	}

	public void BIHFDDNPKPG(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 0);
		ChristmasEvent.GetInstance().HCOPJPMDEKP = DAEMAAOLHMG;
	}

	public void ToggleChristmasEvent(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 0);
		ChristmasEvent.GetInstance().HCOPJPMDEKP = DAEMAAOLHMG;
	}

	private void KJOJLHCDFPP()
	{
		toggleButton.GDNGPPCIHBH(Options.OIJKKLHIGDD == 0);
	}

	private void OIAHJHNPPCO()
	{
		toggleButton.AOBJBNMMACE(Options.OIJKKLHIGDD == 0);
	}

	private void ELHCBGCEJDH()
	{
		if (PlayerInputs.POLDHCKJINN(0) && Utils.AKDEMLPGIPH() && PlayerInputs.DEGBDMMDIIL(1).LNEHPCEHFHL((ActionType)(-41)))
		{
			toggleButton.EHDCHCCIHFI();
		}
	}

	public void FPINFCELFPG(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 0);
		ChristmasEvent.GetInstance().HCOPJPMDEKP = DAEMAAOLHMG;
	}

	public void EADMFHPFLLG(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = ((!DAEMAAOLHMG) ? 1 : 0);
		ChristmasEvent.CDOCMDDCCJL().IKGGBOBADBJ(DAEMAAOLHMG);
	}

	public void JADHJBEKGJD(bool DAEMAAOLHMG)
	{
		Options.OIJKKLHIGDD = (DAEMAAOLHMG ? 1 : 1);
		ChristmasEvent.GetInstance().HCOPJPMDEKP = DAEMAAOLHMG;
	}
}
