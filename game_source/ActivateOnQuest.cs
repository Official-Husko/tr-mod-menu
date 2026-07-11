using System;
using UnityEngine;

public class ActivateOnQuest : MonoBehaviour
{
	[SerializeField]
	[Tooltip("The object will only be active while this quest is on.")]
	private int questID;

	private void CPJGJPDDMCA(Quest CIFJJBHINEF)
	{
		CHIGDCBFHJD();
	}

	private void LHANAHOINPE()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().NOCIKMFDNHF(questID));
	}

	private void BGIKDDKIHID()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().PBCPDMCLFLP(questID));
	}

	private void FEGFCCCAIIO(Quest CIFJJBHINEF)
	{
		EGJPILIBHIN();
	}

	private void AHFGOOHOLEL()
	{
		CPFCMGEBDMK();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(GCLIKINNJFB));
	}

	private void PCKAPNAFANC()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.NOCIKMFDNHF(questID));
	}

	private void EGJPILIBHIN()
	{
		((Component)this).gameObject.SetActive(QuestManager.KHMEGDIABBF().KLNAJBJJAOG(questID));
	}

	private void FJLEOMNAFKI()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().PBCPDMCLFLP(questID));
	}

	private void DHGCCCMCCCC()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().IsQuestActive(questID));
	}

	private void JNPFLMAKABD()
	{
		((Component)this).gameObject.SetActive(QuestManager.KHMEGDIABBF().KLNAJBJJAOG(questID));
	}

	private void LDEJALGFEEF(Quest CIFJJBHINEF)
	{
		JAGHFCHICIA();
	}

	private void CHIGDCBFHJD()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().KLNAJBJJAOG(questID));
	}

	private void GKKEHNMGGDD()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.IsQuestActive(questID));
	}

	private void DEKGNHEHKFB()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(IMHNFONNADL));
		}
	}

	private void MDGLECECOIG()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(FEGFCCCAIIO));
		}
	}

	private void OKEHELLPIHJ()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.IsQuestActive(questID));
	}

	private void PBFGFECPPPO()
	{
		GKKEHNMGGDD();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(FONOLOIHMMG));
	}

	private void CHDEOJALBFK()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(BFMEHOODBNL));
		}
	}

	private void FEJMALLPKPL(Quest CIFJJBHINEF)
	{
		LHANAHOINPE();
	}

	private void LJLKBKEADGI()
	{
		DHHGBEBADPM();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(LDEJALGFEEF));
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(LDEJALGFEEF));
		}
	}

	private void JHMLENBPNAP()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().IsQuestActive(questID));
	}

	private void MKLIAMJFHOF()
	{
		PCKAPNAFANC();
		QuestManager questManager = QuestManager.KHMEGDIABBF();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(FEJMALLPKPL));
	}

	private void KDIODHDPDPF()
	{
		((Component)this).gameObject.SetActive(QuestManager.KHMEGDIABBF().NOCIKMFDNHF(questID));
	}

	private void HMOMBAFIJAI()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(IMHNFONNADL));
		}
	}

	private void IOENKPJIGPM(Quest CIFJJBHINEF)
	{
		PCKAPNAFANC();
	}

	private void CAOKPIIFHBJ()
	{
		MDPCGOKOOFK();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(BOCLLNCCPDM));
	}

	private void GADEGOPBNGC()
	{
		if (Application.isPlaying)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(MIAONBBCGEE));
		}
	}

	private void FNFNLFOJHHA()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(CPJGJPDDMCA));
		}
	}

	private void FONOLOIHMMG(Quest CIFJJBHINEF)
	{
		JBBIPMLGILF();
	}

	private void GNMMELIJKML()
	{
		JAGHFCHICIA();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(IOENKPJIGPM));
	}

	private void ODNGBEOKEFK()
	{
		LHANAHOINPE();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(FEJMALLPKPL));
	}

	private void NJFDKCMBMDH()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(IMHNFONNADL));
		}
	}

	private void JBBHDOMALDB()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(MIAONBBCGEE));
		}
	}

	private void BLAJFMAAMDO()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(LDEJALGFEEF));
		}
	}

	private void DHHGBEBADPM()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.NOCIKMFDNHF(questID));
	}

	private void NCDBCDJKPLA()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(MIAONBBCGEE));
		}
	}

	private void IAAGKLPMAMK()
	{
		JHMLENBPNAP();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(CEEGBJDOMIB));
	}

	private void NFABFPFLNEE()
	{
		COHEMDDJPHC();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(FEGFCCCAIIO));
	}

	private void PKLIGLKEKAC()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().NOCIKMFDNHF(questID));
	}

	private void PKBHEKHOAAA()
	{
		BGIKDDKIHID();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(MFJOLCHFNBH));
	}

	private void BNIKICAEIND()
	{
		PKFFLNAIGMO();
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(EECGHFFPGIB));
	}

	private void Start()
	{
		JAGHFCHICIA();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(LDEJALGFEEF));
	}

	private void GLNPBOIOAPD()
	{
		((Component)this).gameObject.SetActive(QuestManager.GJFMMOPOKGJ().PBCPDMCLFLP(questID));
	}

	private void HINKPJCNPCF()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(EECGHFFPGIB));
		}
	}

	private void JPOLFKMLHNH()
	{
		FJLEOMNAFKI();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(NMDHCGIJCHE));
	}

	private void IFHLGOMBACP()
	{
		PKFFLNAIGMO();
		QuestManager questManager = QuestManager.KHMEGDIABBF();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(CEEGBJDOMIB));
	}

	private void AFCIKJPPLFA()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(BFMEHOODBNL));
		}
	}

	private void MFJOLCHFNBH(Quest CIFJJBHINEF)
	{
		JBBIPMLGILF();
	}

	private void DGOGKLMHJEG()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(BFMEHOODBNL));
		}
	}

	private void EECGHFFPGIB(Quest CIFJJBHINEF)
	{
		OKEHELLPIHJ();
	}

	private void BPOOAHKHPCL()
	{
		if (Application.isPlaying)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(IPJNCDBLEMB));
		}
	}

	private void COHEMDDJPHC()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.NOCIKMFDNHF(questID));
	}

	private void EGHOIJHBDBP()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(MIAONBBCGEE));
		}
	}

	private void IFBKCKHJAIK()
	{
		((Component)this).gameObject.SetActive(QuestManager.KHMEGDIABBF().BCPLFLAIJKN(questID));
	}

	private void FHEGBNMJADG()
	{
		JBBIPMLGILF();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(BFMEHOODBNL));
	}

	private void HHOBDBOFMEI()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().IsQuestActive(questID));
	}

	private void MIAONBBCGEE(Quest CIFJJBHINEF)
	{
		JAGHFCHICIA();
	}

	private void MFMMHDPGCBO()
	{
		GKKEHNMGGDD();
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(CEEGBJDOMIB));
	}

	private void NPHGFBJFLAM()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().PBCPDMCLFLP(questID));
	}

	private void ICFHPJHBPDN()
	{
		IFBKCKHJAIK();
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(NMDHCGIJCHE));
	}

	private void HELHNJDFPPF()
	{
		MDPCGOKOOFK();
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(MIAONBBCGEE));
	}

	private void DHKLPAJKLEG()
	{
		((Component)this).gameObject.SetActive(QuestManager.OPILDPFDFKJ().PBCPDMCLFLP(questID));
	}

	private void BOCLLNCCPDM(Quest CIFJJBHINEF)
	{
		HHOBDBOFMEI();
	}

	private void CMLLBIDFNEB()
	{
		PKLIGLKEKAC();
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(GCLIKINNJFB));
	}

	private void IAIDKPJKLIC()
	{
		EGJPILIBHIN();
		QuestManager questManager = QuestManager.KHMEGDIABBF();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(IOENKPJIGPM));
	}

	private void OLDDEAJMHNI()
	{
		GLNPBOIOAPD();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(EECGHFFPGIB));
	}

	private void JAGHFCHICIA()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.IsQuestActive(questID));
	}

	private void GCLIKINNJFB(Quest CIFJJBHINEF)
	{
		MDPCGOKOOFK();
	}

	private void HNNBAAJAHEN()
	{
		if (Application.isPlaying)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(MFJOLCHFNBH));
		}
	}

	private void HKDFODFOGIC()
	{
		((Component)this).gameObject.SetActive(QuestManager.KHMEGDIABBF().PBCPDMCLFLP(questID));
	}

	private void JBBIPMLGILF()
	{
		((Component)this).gameObject.SetActive(QuestManager.GJFMMOPOKGJ().KLNAJBJJAOG(questID));
	}

	private void MDPCGOKOOFK()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.NOCIKMFDNHF(questID));
	}

	private void CHIJGHPHCNA()
	{
		CHIGDCBFHJD();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(BFMEHOODBNL));
	}

	private void BFMEHOODBNL(Quest CIFJJBHINEF)
	{
		CPFCMGEBDMK();
	}

	private void CEEGBJDOMIB(Quest CIFJJBHINEF)
	{
		JAGHFCHICIA();
	}

	private void IMHNFONNADL(Quest CIFJJBHINEF)
	{
		DHHGBEBADPM();
	}

	private void KOBNHPKEJJD()
	{
		if (Application.isPlaying)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(NMDHCGIJCHE));
		}
	}

	private void DONGKOKMGMM()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(FEGFCCCAIIO));
		}
	}

	private void NMDHCGIJCHE(Quest CIFJJBHINEF)
	{
		PKLIGLKEKAC();
	}

	private void BDGCFCPFKKE()
	{
		GKKEHNMGGDD();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(IOENKPJIGPM));
	}

	private void IPJNCDBLEMB(Quest CIFJJBHINEF)
	{
		CPFCMGEBDMK();
	}

	private void CDFMNDEKBJE()
	{
		if (Application.isPlaying)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(IMHNFONNADL));
		}
	}

	private void KACEOJDPLKB()
	{
		JBBIPMLGILF();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(BFMEHOODBNL));
	}

	private void CPFCMGEBDMK()
	{
		((Component)this).gameObject.SetActive(QuestManager.KHMEGDIABBF().BCPLFLAIJKN(questID));
	}

	private void MLLADNLMIMP()
	{
		CPFCMGEBDMK();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(CPJGJPDDMCA));
	}

	private void PKFFLNAIGMO()
	{
		((Component)this).gameObject.SetActive(QuestManager.GGFJGHHHEJC.KLNAJBJJAOG(questID));
	}
}
