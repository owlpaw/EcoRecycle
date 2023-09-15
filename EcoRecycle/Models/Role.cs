using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle.Models
{
    internal class Role
    {
        bool viewSettings; //查看设置      
        bool modifySettings;//修改设置
        bool deliverWaste;//投递废品
        bool openCleaningLock;//打开清运锁

        /// <summary>
        /// 查看设置
        /// </summary>
        public bool ViewSettings { get => viewSettings; set => viewSettings = value; }
        /// <summary>
        /// 修改设置
        /// </summary>
        public bool ModifySettings { get => modifySettings; set => modifySettings = value; }
        /// <summary>
        /// 投递废品
        /// </summary>
        public bool DeliverWaste { get => deliverWaste; set => deliverWaste = value; }
        /// <summary>
        /// 打开清运锁
        /// </summary>
        public bool OpenCleaningLock { get => openCleaningLock; set => openCleaningLock = value; }
    }
    /// <summary>
    /// 普通用户
    /// </summary>
    internal class OrdinaryUser : Role
    {
        public OrdinaryUser()
        {
            ViewSettings = false;
            ModifySettings = false;
            DeliverWaste = true;
            OpenCleaningLock = false;
        }
    }

    /// <summary>
    /// 清运人员
    /// </summary>
    internal class ClearingRemoval : Role
    {
        public ClearingRemoval()
        {
            ViewSettings = false; 
            ModifySettings = false;
            DeliverWaste = false;
            OpenCleaningLock = true;
        }
    }


}
