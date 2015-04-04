﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCLCMS.Data.BLL.Strategy.UserInfo
{
    /// <summary>
    /// 保存用户角色信息
    /// </summary>
    public class RoleInfo : BaseStrategy
    {
        /// <summary>
        /// 构造
        /// </summary>
        public RoleInfo()
        {
            this.Name = "保存用户角色信息";
        }

        /// <summary>
        /// 执行策略
        /// </summary>
        public override void DoWork<T>(T context)
        {
            var userInfoContext = context as XCLCMS.Data.BLL.Strategy.UserInfo.UserInfoContext;

            if (null == userInfoContext.UserRoleIDs || userInfoContext.UserRoleIDs.Count == 0)
            {
                return;
            }

            XCLCMS.Data.BLL.SysUserRole bll = new XCLCMS.Data.BLL.SysUserRole();

            XCLCMS.Data.Model.SysUserRole model = new XCLCMS.Data.Model.SysUserRole();
            model.CreaterID = userInfoContext.CurrentUserInfo.UserInfoID;
            model.CreaterName = userInfoContext.CurrentUserInfo.UserName;
            model.CreateTime = DateTime.Now;
            model.UpdaterID = model.CreaterID;
            model.UpdaterName = model.CreaterName;
            model.UpdateTime = model.CreateTime;
            model.FK_UserInfoID = userInfoContext.UserInfo.UserInfoID;
            model.RecordState = XCLCMS.Data.CommonHelper.EnumType.RecordStateEnum.N.ToString();

            bool flag=bll.Add(model, userInfoContext.UserRoleIDs);

            if (flag)
            {
                this.Result = StrategyLib.ResultEnum.SUCCESS;
            }
            else
            {
                this.Result = StrategyLib.ResultEnum.FAIL;
                this.ResultMessage = "保存用户角色信息失败！";
            }
        }
    }
}
