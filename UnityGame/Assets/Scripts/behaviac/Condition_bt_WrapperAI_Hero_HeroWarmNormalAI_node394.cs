using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroWarmNormalAI_node394 : Condition
	{
		private int opl_p1;

		public Condition_bt_WrapperAI_Hero_HeroWarmNormalAI_node394()
		{
			this.opl_p1 = 15000;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(3990708623u);
			bool flag = ((ObjAgent)pAgent).IsDistanceToActorLessThanRange(objID, this.opl_p1);
			bool flag2 = true;
			return (flag == flag2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
