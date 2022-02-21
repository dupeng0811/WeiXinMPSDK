namespace Senparc.Weixin.MP.AdvancedAPIs.Draft.DraftJson
{
    public class DraftModel
    {
        /// <summary>
        /// 图文消息的标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 图文消息的作者
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// 图文消息的描述
        /// </summary>
        public string digest { get; set; }

        /// <summary>
        /// 图文消息页面的内容，支持HTML标签
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 在图文消息页面点击“阅读原文”后的页面
        /// </summary>
        public string content_source_url { get; set; }

        /// <summary>
        /// 图文消息缩略图的media_id，可以在基础支持上传多媒体文件接口中获得
        /// </summary>
        public string thumb_media_id { get; set; }

        /// <summary>
        /// 是否打开评论，0不打开，1打开
        /// </summary>
        public int need_open_comment { get; set; }
        /// <summary>
        /// 是否粉丝才可评论，0所有人可评论，1粉丝才可评论
        /// </summary>
        public int only_fans_can_comment { get; set; }
    }
}