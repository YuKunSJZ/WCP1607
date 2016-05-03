using System;
using System.Collections.Generic;
using System.Web;

namespace HourseRentSystem.Model
{
    /// <summary>
    ///Hourse 的摘要说明: 映射数据库中的房屋信息表
    /// </summary>
    public class Hourse
    {
        /*记录编号*/
        private int hourseId;
        public void setHourseId(int hourseId) { this.hourseId = hourseId; }
        public int getHourseId() { return this.hourseId; }
        /*月租金*/
        private float zujin;
        public void setZujin(float zujin) { this.zujin = zujin; }
        public float getZujin() { return this.zujin; }
        /*户型*/
        private string huxing;
        public void setHuxing(string huxing) { this.huxing = huxing; }
        public string getHuxing() { return this.huxing; }
        /*面积*/
        private float mianji;
        public void setMianji(float mianji) { this.mianji = mianji; }
        public float getMianji() { return this.mianji; }
        /*装修*/
        private string zhuangxiu;
        public void setZhuangxiu(string zhuangxiu) { this.zhuangxiu = zhuangxiu; }
        public string getZhuangxiu() { return this.zhuangxiu; }
        /*类型*/
        private string leixing;
        public void setLeixing(string leixing) { this.leixing = leixing; }
        public string getLeixing() { return this.leixing; }
        /*楼层*/
        private string louceng;
        public void setLouceng(string louceng) { this.louceng = louceng; }
        public string getLouceng() { return this.louceng; }
        /*区域*/
        private string quyu;
        public void setQuyu(string quyu) { this.quyu = quyu; }
        public string getQuyu() { return quyu; }
        /*小区*/
        private string xiaoqu;
        public void setXiaoqu(string xiaoqu) { this.xiaoqu = xiaoqu; }
        public string getXiaoqu() { return this.xiaoqu; }
        /*地址*/
        private string dizhi;
        public void setDizhi(string dizhi) { this.dizhi = dizhi; }
        public string getDizhi() { return this.dizhi; }
        /*是否有床*/
        private int chuangFlag;
        public void setChuangFlag(int chuangFlag) { this.chuangFlag = chuangFlag; }
        public int getChuangFlag() { return this.chuangFlag; }
        /*是否有电话*/
        private int dianhuaFlag;
        public void setDianhuaFlag(int dianhuaFlag) { this.dianhuaFlag = dianhuaFlag; }
        public int getDianhuaFlag() { return this.dianhuaFlag; }
        /*是否有电视*/
        private int dianshiFlag;
        public void setDianshiFlag(int dianshiFlag) { this.dianshiFlag = dianshiFlag; }
        public int getDianshiFlag() { return this.dianshiFlag; }
        /*是否有空调*/
        private int kongtiaoFlag;
        public void setKongtiaoFlag(int kongtiaoFlag) { this.kongtiaoFlag = kongtiaoFlag; }
        public int getKongtiaoFlag() { return this.kongtiaoFlag; }
        /*是否有冰箱*/
        private int bingxiangFlag;
        public void setBingxiangFlag(int bingxiangFlag) { this.bingxiangFlag = bingxiangFlag; }
        public int getBingxiangFlag() { return this.bingxiangFlag; }
        /*是否有热水器*/
        private int reshuiqiFlag;
        public void setReshuiqiFlag(int reshuiqiFlag) { this.reshuiqiFlag = reshuiqiFlag; }
        public int getReshuiqiFlag() { return this.reshuiqiFlag; }
        /*是否有洗衣机*/
        private int xiyijiFlag;
        public void setXiyijiFlag(int xiyijiFlag) { this.xiyijiFlag = xiyijiFlag; }
        public int getXiyijiFlag() { return this.xiyijiFlag; }
        /*是否有宽带*/
        private int kuandaiFlag;
        public void setKuandaiFlag(int kuandaiFlag) { this.kuandaiFlag = kuandaiFlag; }
        public int getKuandaiFlag() { return this.kuandaiFlag; } 
        /*房屋状态: 已租 未租*/
        private string zhuangtai;
        public void setZhuangtai(string zhuangtai) { this.zhuangtai = zhuangtai; }
        public string getZhuangtai() { return this.zhuangtai; }
        /*租用开始日期*/
        private DateTime kssj;
        public void setKssj(DateTime kssj) { this.kssj = kssj; }
        public DateTime getKssj() { return this.kssj; } 

        public Hourse()
        {
        }
    }

}

