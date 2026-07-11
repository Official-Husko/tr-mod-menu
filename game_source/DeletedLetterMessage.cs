using System;

[Serializable]
public class DeletedLetterMessage : IOnlineSerializable
{
	public short index;

	public void PFOHEFAMENI()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.HEGPDGJEOPC(1).BGLJFMHCFJF() || PostboxPanelUI.instances[0].IsOpen())
		{
			PostboxUI.Get(0).UpdateUIOnOtherPlayerDelete(index);
		}
	}

	public void AELABIMHDNA()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.CGFJPHEFFLO(1).BGLJFMHCFJF() || PostboxPanelUI.instances[0].BGLJFMHCFJF())
		{
			PostboxUI.Get(0).IIPNPMCCCEM(index);
		}
	}

	public DeletedLetterMessage(int MOFKEDGAOEE)
	{
		index = (short)MOFKEDGAOEE;
	}

	public void FJFEIIIIAMJ()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.HEGPDGJEOPC(0).IsOpen() || PostboxPanelUI.instances[1].BGLJFMHCFJF())
		{
			PostboxUI.FHKGDLNJFFA(1).UpdateUIOnOtherPlayerDelete(index);
		}
	}

	public void GMNEAMHNMPB()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.HEGPDGJEOPC(1).HDEPMJIDJEM() || PostboxPanelUI.instances[0].BGLJFMHCFJF())
		{
			PostboxUI.BMFHCBOFHCN(0).HDKFIIHJBFI(index);
		}
	}

	public void FOGLECFMPMK()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.Get(1).BGLJFMHCFJF() || PostboxPanelUI.instances[0].IsOpen())
		{
			PostboxUI.BMFHCBOFHCN(1).AAFCBGODJNA(index);
		}
	}

	public void OKPIDPELELJ()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.BMFHCBOFHCN(0).IsOpen() || PostboxPanelUI.instances[0].IsOpen())
		{
			PostboxUI.CGFJPHEFFLO(1).IDNNGDFBOLB(index);
		}
	}

	public void OEJJGDMKIDN()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.Get(1).IsOpen() || PostboxPanelUI.instances[0].IsOpen())
		{
			PostboxUI.Get(1).UpdateUIOnOtherPlayerDelete(index);
		}
	}

	public void CCLMONNMMCJ()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.FHKGDLNJFFA(0).HDEPMJIDJEM() || PostboxPanelUI.instances[0].IsOpen())
		{
			PostboxUI.BMFHCBOFHCN(0).MIPAJFBOINI(index);
		}
	}

	public void KGNIEGOBNLD()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.HEGPDGJEOPC(1).HDEPMJIDJEM() || PostboxPanelUI.instances[0].HDEPMJIDJEM())
		{
			PostboxUI.BMFHCBOFHCN(0).CACONMIFINC(index);
		}
	}

	public void OAOACMPNMOK()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.ODLPIANFFFJ(0).HDEPMJIDJEM() || PostboxPanelUI.instances[1].HDEPMJIDJEM())
		{
			PostboxUI.DPBGKDNKDGM(0).AAFCBGODJNA(index);
		}
	}

	public void MOEHLFOHLLO()
	{
		LettersManager.instance.lettersSaved.RemoveAt(index);
		if (PostboxUI.FHKGDLNJFFA(1).HDEPMJIDJEM() || PostboxPanelUI.instances[1].HDEPMJIDJEM())
		{
			PostboxUI.FHKGDLNJFFA(0).IIPNPMCCCEM(index);
		}
	}
}
