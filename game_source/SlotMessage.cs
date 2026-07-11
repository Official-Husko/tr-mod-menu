using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class SlotMessage<T> : IOnlineSerializable where T : ItemInstanceMessage
{
	[JsonProperty("1")]
	public short slotId;

	[JsonProperty("2")]
	public int objectUniqueId;

	[JsonProperty("3")]
	public byte containerTypeEnum;

	[JsonProperty("4")]
	public short stack;

	[JsonProperty("5")]
	public T itemInstance;

	private static ItemInstanceMessage itemInstanceMessageAux;

	public void NNOLBEDINMK()
	{
		OnlineSlotsManager.JBFCOLMMPDB((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void LMHDLMCPDFB(int PAFEECBJICN)
	{
		OnlineSlotsManager.ONKDKBEJFCM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public static SlotMessage<T> MENBNCJDCEO(Slot ADEBNALPEHE)
	{
		SlotMessage<T> slotMessage = new SlotMessage<T>();
		slotMessage.slotId = ADEBNALPEHE.id;
		slotMessage.objectUniqueId = ADEBNALPEHE.uniqueObjectId;
		slotMessage.containerTypeEnum = (byte)ADEBNALPEHE.inventoryType;
		if (!ADEBNALPEHE.KPINNBKMOMO())
		{
			itemInstanceMessageAux = ItemInstanceMessage.MENBNCJDCEO(ADEBNALPEHE.itemInstance);
			if (itemInstanceMessageAux is T)
			{
				slotMessage.itemInstance = (T)itemInstanceMessageAux;
			}
			else
			{
				Debug.LogError((object)("Item Instance type error in SlotMessage inventoryType: " + ADEBNALPEHE.inventoryType.ToString() + " slotId: " + ADEBNALPEHE.id + " itemInstance: " + ADEBNALPEHE.itemInstance.IABAKHPEOAF()));
			}
		}
		slotMessage.stack = (short)ADEBNALPEHE.Stack;
		return slotMessage;
	}

	public void CHINOBCKKHK(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.PJKGGDAHNPM(ADEBNALPEHE, itemInstance, stack);
	}

	public void MAPAJECOBNH()
	{
		OnlineSlotsManager.DJNDENBPKEL((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void NEOAGKGNAKN(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIFCDDBFHKB((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void BDIOAOKJNMB()
	{
		OnlineSlotsManager.JBFCOLMMPDB((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void INCMOPCEOFC(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIFCDDBFHKB((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void AFFFHIOJCPK(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EOJDOBGPIEA(ADEBNALPEHE, itemInstance, stack);
	}

	public void BKBDJFBGDFC(int PAFEECBJICN)
	{
		OnlineSlotsManager.ONKDKBEJFCM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void CLBGFLBKFCB(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EGNHHLFJOAK(ADEBNALPEHE, itemInstance, stack);
	}

	public void GKACGKHCHGF(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EOJDOBGPIEA(ADEBNALPEHE, itemInstance, stack);
	}

	public void OBLLHPGHIOH()
	{
		OnlineSlotsManager.FNPAHLNHBBP((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void MLPKIKGIIEG()
	{
		OnlineSlotsManager.LNIOCEDBEED((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void DFIBJMGNJHL(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EGNHHLFJOAK(ADEBNALPEHE, itemInstance, stack);
	}

	public void OODKLENMNAP()
	{
		OnlineSlotsManager.DJNDENBPKEL((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void CBIEBMPFBDL(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIDHEFDJMLH((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void HILENACODCH()
	{
		OnlineSlotsManager.DJNDENBPKEL((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void FFECMGJKENK(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.LoadSlot(ADEBNALPEHE, itemInstance, stack);
	}

	public void EFGAGDJBDIL(int PAFEECBJICN)
	{
		OnlineSlotsManager.FGJPFCFPCLM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void DEHPBBPIMOJ(int PAFEECBJICN)
	{
		OnlineSlotsManager.ONKDKBEJFCM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void HGFIFEKHPJF(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.PJKGGDAHNPM(ADEBNALPEHE, itemInstance, stack);
	}

	public void GEFGOLEDEKN(int PAFEECBJICN)
	{
		OnlineSlotsManager.LoadSlotPlayerInventory((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void CNBDEONHDBJ()
	{
		OnlineSlotsManager.LNIOCEDBEED((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void IFIJPKIKMBP(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EOJDOBGPIEA(ADEBNALPEHE, itemInstance, stack);
	}

	public void ENJPGAPALMJ(int PAFEECBJICN)
	{
		OnlineSlotsManager.FGJPFCFPCLM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void CCAHPONJNMJ(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.LoadSlot(ADEBNALPEHE, itemInstance, stack);
	}

	public void PEKOAJGIGOM(int PAFEECBJICN)
	{
		OnlineSlotsManager.FGJPFCFPCLM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void HDDCBAFNKNG(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.IPCGGCKGOIK(ADEBNALPEHE, itemInstance, stack);
	}

	public void LLCFGHOFEEG(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.LoadSlot(ADEBNALPEHE, itemInstance, stack);
	}

	public void DEHKNLCGMLG(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EOJDOBGPIEA(ADEBNALPEHE, itemInstance, stack);
	}

	public void PBEAAENHMHI()
	{
		OnlineSlotsManager.LoadSlotContainer((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void FPMDNGGCCMA(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIFCDDBFHKB((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void OGEDNMFCFJG()
	{
		OnlineSlotsManager.LoadSlotContainer((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void JMPKOAAMAJF()
	{
		OnlineSlotsManager.FNPAHLNHBBP((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void GFCMPFMOELO()
	{
		OnlineSlotsManager.JBFCOLMMPDB((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void FJBODGJAION(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.LoadSlot(ADEBNALPEHE, itemInstance, stack);
	}

	public void MFHGPMHKEDF()
	{
		OnlineSlotsManager.FNPAHLNHBBP((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void BCOLCBOBDEH(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIDHEFDJMLH((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void KECCJKABFKE(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIDHEFDJMLH((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void KEBMLHKLFEF()
	{
		OnlineSlotsManager.LoadSlotContainer((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void NJJKMCNADHH()
	{
		OnlineSlotsManager.DJNDENBPKEL((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void EEAAKPGACJF(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIFCDDBFHKB((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void BHGNGJOCHHE()
	{
		OnlineSlotsManager.LoadSlotContainer((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void LBEAINGEBBI(int PAFEECBJICN)
	{
		OnlineSlotsManager.LFHGMHGPNKP((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void CJEJHJCPGAL(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIFCDDBFHKB((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void LFFAOPJACAF(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.LoadSlot(ADEBNALPEHE, itemInstance, stack);
	}

	public void POFFHBGOOCK(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.PJKGGDAHNPM(ADEBNALPEHE, itemInstance, stack);
	}

	public void MDFDMBHLHJM(int PAFEECBJICN)
	{
		OnlineSlotsManager.LoadSlotPlayerInventory((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void ENIJPMNLIPK()
	{
		OnlineSlotsManager.JBFCOLMMPDB((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void KLHIDKCOPME(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIDHEFDJMLH((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void EGBGHJEOKBE()
	{
		OnlineSlotsManager.FNPAHLNHBBP((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void JCMMFFNEKAL()
	{
		OnlineSlotsManager.LNIOCEDBEED((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void JNEHOALJBCI(int PAFEECBJICN)
	{
		OnlineSlotsManager.LFHGMHGPNKP((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void CFLHGAMBOHP()
	{
		OnlineSlotsManager.FNPAHLNHBBP((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void NFBIHKMEACG(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.EOJDOBGPIEA(ADEBNALPEHE, itemInstance, stack);
	}

	public void ILCNJJCMCAC(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.IPCGGCKGOIK(ADEBNALPEHE, itemInstance, stack);
	}

	public void HGNJGCAFNCC()
	{
		OnlineSlotsManager.JBFCOLMMPDB((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void DJGALDKKMFA(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.PJKGGDAHNPM(ADEBNALPEHE, itemInstance, stack);
	}

	public void JEHMAKGNPBA(int PAFEECBJICN)
	{
		OnlineSlotsManager.DLELJFDBKIM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void MFNJGFOMLMH(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.PJKGGDAHNPM(ADEBNALPEHE, itemInstance, stack);
	}

	public void KADGMFELFCD(int PAFEECBJICN)
	{
		OnlineSlotsManager.PIDHEFDJMLH((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void EEPKKPHIDBC()
	{
		OnlineSlotsManager.LoadSlotContainer((ContainerType)containerTypeEnum, slotId, objectUniqueId, itemInstance, stack);
	}

	public void BBAHGNBFBPA(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.IPCGGCKGOIK(ADEBNALPEHE, itemInstance, stack);
	}

	public void JIPDCLFJCAK(int PAFEECBJICN)
	{
		OnlineSlotsManager.DLELJFDBKIM((ContainerType)containerTypeEnum, slotId, itemInstance, stack, PAFEECBJICN);
	}

	public void KDKJBAMCFDE(Slot ADEBNALPEHE)
	{
		OnlineSlotsManager.IPCGGCKGOIK(ADEBNALPEHE, itemInstance, stack);
	}
}
