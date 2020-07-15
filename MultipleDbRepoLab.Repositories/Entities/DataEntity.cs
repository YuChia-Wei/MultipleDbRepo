namespace MultipleDbRepoLab.Repositories.Entities
{
    /// <summary>
    /// db 資料實體 
    /// </summary>
    public class DataEntity
    {
        /// <summary>
        ///     方法代號
        /// </summary>
        public string MethodCode { set; get; }

        /// <summary>
        ///     個別設定
        /// </summary>
        public bool IndividuallySet { set; get; }

        /// <summary>
        /// 產品號碼
        /// </summary>
        public string ProductCode { set; get; }

        /// <summary>
        /// 依照倉庫編號
        /// </summary>
        public bool ByLocationId { set; get; }

        /// <summary>
        /// 依照批號
        /// </summary>
        public bool ByLotNumber { set; get; }
    }
}