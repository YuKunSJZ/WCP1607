using System;
using System.Collections.Generic;
using System.Web;

using HourseRentSystem.DAO;
using HourseRentSystem.Model;

namespace HourseRentSystem.BLL
{
    /// <summary>
    ///HourseBLL 的摘要说明:房屋信息处理的业务层
    /// </summary>
    public class HourseBLL
    {
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }
        private HourseDAO hourseDAO = new HourseDAO();
        public HourseBLL()
        {
            this.errMessage = "";
        }

        /*登记新的房屋信息*/
        public bool AddHourse(Hourse hourse)
        {
            if (hourse.getHuxing() == "")
            {
                this.errMessage = "户型输入不能为空!";
                return false;
            }
            if (hourse.getZhuangxiu() == "")
            {
                this.errMessage = "装修信息输入不能为空!";
                return false;
            }
            if (!hourseDAO.AddHourse(hourse))
            {
                this.errMessage = "房屋信息登记失败!";
                return false;
            }

            return true;
        }

        /*更新房屋信息*/
        public bool UpdateHourse(Hourse hourse)
        {
            if (hourse.getHuxing() == "")
            {
                this.errMessage = "户型输入不能为空!";
                return false;
            }
            if (hourse.getZhuangxiu() == "")
            {
                this.errMessage = "装修信息输入不能为空!";
                return false;
            }
            if (!hourseDAO.UpdateHourse(hourse))
            {
                this.errMessage = "房屋信息更新失败!";
                return false;
            }
            return true;
        }

        /*根据房屋编号删除房屋信息*/
        public bool DeleteHourse(int hourseId)
        {
            /*首先查询房屋的当前状态*/
            Hourse hourse = hourseDAO.GetHourseById(hourseId);
            if (hourse.getZhuangtai() == "已租")
            {
                this.errMessage = "房屋已经被租用,不能删除!";
                return false;
            }
            if (!hourseDAO.DeleteHourse(hourseId))
            {
                this.errMessage = "房屋信息删除失败 !";
                return false;
            }
            return true;
        }

        /*根据类型，小区，起价，终止价查询房屋信息*/
        public System.Data.DataSet QueryHourseInfo(string leixing, string xiaoqu, string lowpriceString, string highpriceString)
        {
            return hourseDAO.QueryHourseInfo(leixing, xiaoqu, lowpriceString, highpriceString);
        }

        /*根据房屋信息记录编号返回房屋信息实体对象*/
        public Hourse GetHourseById(int hourseId)
        {
            return hourseDAO.GetHourseById(hourseId);
        }
    }

}
