using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PIDataSave.Entities
{
    [ Table("PIPoint")]
    class PIPoint
    {
        /// <summary>
        /// 主键Id  = GobalPrefix + numberId
        /// </summary>
        //[PrimaryKey, AutoIncrement, System.ComponentModel.ReadOnly(true)]
        //[DisplayName("ID")]
        public long id { get; set; }
        /// <summary>
        /// 脱销反应器B入口原烟气O2含量
        /// </summary>
        public double U80HSA12CQ102A_O { get; set; }
        /// <summary>
        /// 脱销反应器A入口原烟气O2含量
        /// </summary>
        public double U80HSA11CQ102A_O { get; set; }

        /// <summary>
        /// 空预器B出口烟气含氧量
        /// </summary>
        public double U80HNA10CQ104 { get; set; }
        /// <summary>
        /// 空预器A出口烟气含氧量
        /// </summary>
        public double U80HNA20CQ104 { get; set; }


        /// <summary>
        /// 一次风机A风量
        /// </summary>
        public double U80HLB10CF101 { get; set; }
        /// <summary>
        /// 一次风机B风量
        /// </summary>
        public double U80HLB20CF101 { get; set; }


        /// <summary>
        ///A侧二次风量计算值
        /// </summary>
        public double U80HHL10CF101_SEL { get; set; }

        /// <summary>
        ///B侧二次风量计算值
        /// </summary>
        public double U80HHL20CF101_SEL { get; set; }

        /// <summary>
        /// #8机组锅炉给水流量
        /// </summary>
        public double K80DCS01QUA { get; set; }

        /// <summary>
        /// 1分钟平均气温
        /// </summary>
        public double CY0SWS01CT0012131 { get; set; }
        /// <summary>
        /// 1分钟相对湿度平均值
        /// </summary>
        public double CY0SWS01CM0012131 { get; set; }
        /// <summary>
        /// 1分钟气压平均值
        /// </summary>
        public double CY0SWS01CP0012131 { get; set; }


        /// <summary>
        /// 过热器A侧出口蒸汽压力
        /// </summary>
        public double U80LBA01CP101_SEL { get; set; }

        /// <summary>
        /// 过热器B侧出口蒸汽压力
        /// </summary>
        public double U80LBA02CP101_SEL { get; set; }

        /// <summary>
        /// 中间点过热度
        /// </summary>
        public double U8SHRWSI { get; set; }



        /// <summary>
        /// 末级再热器出口压力
        /// </summary>
        public double U80LBB01CP101_SEL { get; set; }
        /// <summary>
        /// 末级再热器A侧出口温度
        /// </summary>
        public double U80LBB01CT701_SEL { get; set; }

        /// <summary>
        /// 末级再热器B侧出口温度
        /// </summary>
        public double U80LBB01CT704_SEL { get; set; }


        /// <summary>
        /// 锅炉负荷
        /// </summary>
        public double U80DCS01HLA { get; set; }
        /// <summary>
        /// 年累计发电量
        /// </summary>
        public double DCSNFDL_CALC8 { get; set; }

        /// <summary>
        /// 当日累计发电量
        /// </summary>
        public double DCSRFDL_CALC8 { get; set; }


        /// <summary>
        ///给煤机A给煤机反馈
        /// </summary>
        public double U80HFB10AF00193 { get; set; }

        /// <summary>
        ///给煤机B给煤机反馈
        /// </summary>
        public double U80HFB20AF00193 { get; set; }
        /// <summary>
        ///给煤机C给煤机反馈
        /// </summary>
        public double U80HFB30AF00193 { get; set; }
        /// <summary>
        ///给煤机D给煤机反馈
        /// </summary>
        public double U80HFB40AF00193 { get; set; }
        /// <summary>
        ///给煤机E给煤机反馈
        /// </summary>
        public double U80HFB50AF00193 { get; set; }
        /// <summary>
        ///给煤机F给煤机反馈
        /// </summary>
        public double U80HFB60AF00193 { get; set; }

        public string time { get; set; }
  
   


    }
}
