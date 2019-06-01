namespace lce.mis.api.Provider
{
    /// <summary>
    /// 排序
    /// </summary>
    public class OrderParam
    {
        public OrderParam()
        {
        }

        public OrderParam(string field) : this()
        {
            this.Field = field;
        }

        public OrderParam(string field, bool isAsc) : this(field)
        {
            this.IsAsc = isAsc;
        }

        public string Field { get; set; } = "Id";

        public bool IsAsc { get; set; } = false;
    }
}
