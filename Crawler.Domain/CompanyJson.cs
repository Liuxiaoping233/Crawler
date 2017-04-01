using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Domain
{
    public class CompanyJson
    {
        #region 字段
        /// <summary>
        /// com_id
        /// </summary>
        public int com_id { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        public int c_id { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        public int site_id { get; set; }

        /// <summary>
        /// 实际URL
        /// </summary>
        public string com_url { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        public string register_code { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public string credit_code { get; set; }

        /// <summary>
        /// 组织结构代码
        /// </summary>
        public string org_code { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public string company { get; set; }


        /// <summary>
        /// 公司类型
        /// </summary>
        public string company_type { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        public string corporate { get; set; }


        /// <summary>
        /// 住所
        /// </summary>
        public string register_address { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        public string founded_date { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string business_term { get; set; }

        /// <summary>
        /// 核准日期
        /// </summary>
        public string approval_date { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        public string capital { get; set; }

        /// <summary>
        /// 发照日期
        /// </summary>
        public string issue_date { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        public string register_office { get; set; }

        /// <summary>
        /// 经营状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        public string business_scope { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime created { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? updated { get; set; }

        /// <summary>
        /// 站点数据更新时间
        /// </summary>
        public DateTime? site_updated { get; set; }
        #endregion

    }
}
