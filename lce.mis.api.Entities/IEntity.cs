using System;

namespace lce.mis.api.Entities
{
    /// <summary>
    /// action：基础模型
    /// file name：lce.mis.api.Entities.IEntity
    /// author：lynx.kor @ 2019/6/1 14:59:47
    /// desc：
    /// > add description for IEntity
    /// revision：
    ///
    /// </summary>
    public class IEntity
    {
        /// <summary>
        /// 主键/ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题/名称/姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public int ModifiedBy { get; set; }
    }
}
