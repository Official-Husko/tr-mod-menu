using UnityEngine;

public class PsaiTcSkipIfComponentIsDisabled : PsaiTriggerCondition
{
	public MonoBehaviour _componentToCheck;

	public override bool EvaluateTriggerCondition()
	{
		if (Object.op_Implicit((Object)(object)_componentToCheck))
		{
			return ((Behaviour)_componentToCheck).enabled;
		}
		return true;
	}
}
