﻿using System;

namespace XCLCMS.Data.Model
{
    /// <summary>
    /// 用户角色关系表
    /// </summary>
    [Serializable]
    public partial class SysUserRole
    {
        private long _fk_userinfoid;
        private long _fk_sysroleid;
        private string _recordstate;
        private DateTime _createtime;
        private long _createrid;
        private string _creatername;
        private DateTime _updatetime;
        private long _updaterid;
        private string _updatername;

        /// <summary>
        /// 用户ID
        /// </summary>
        public long FK_UserInfoID
        {
            set { _fk_userinfoid = value; }
            get { return _fk_userinfoid; }
        }

        /// <summary>
        /// 角色ID
        /// </summary>
        public long FK_SysRoleID
        {
            set { _fk_sysroleid = value; }
            get { return _fk_sysroleid; }
        }

        /// <summary>
        /// 记录状态(RecordStateEnum)
        /// </summary>
        public string RecordState
        {
            set { _recordstate = value; }
            get { return _recordstate; }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }

        /// <summary>
        /// 创建者ID
        /// </summary>
        public long CreaterID
        {
            set { _createrid = value; }
            get { return _createrid; }
        }

        /// <summary>
        /// 创建者名
        /// </summary>
        public string CreaterName
        {
            set { _creatername = value; }
            get { return _creatername; }
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }

        /// <summary>
        /// 更新人ID
        /// </summary>
        public long UpdaterID
        {
            set { _updaterid = value; }
            get { return _updaterid; }
        }

        /// <summary>
        /// 更新人名
        /// </summary>
        public string UpdaterName
        {
            set { _updatername = value; }
            get { return _updatername; }
        }
    }
}