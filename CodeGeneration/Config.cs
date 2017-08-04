using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 类说明
        /// </summary>
        public string ClassDes { get; set; }
        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSapace { get; set; }
        /// <summary>
        /// 继承
        /// </summary>
        public string Inherit { get; set; }
        /// <summary>
        /// 参数隔开方式
        /// </summary>
        public string SeparationType { get; set; }
        /// <summary>
        /// 引入命名空间
        /// </summary>
        public string Using { get; set; }

    }
}
