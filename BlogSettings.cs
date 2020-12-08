namespace Blog
{
    public class BlogSettings
    {
        public string Name { get; set; } = "Issun.SonOfGoran";
        public string Description { get; set; } = "A short description of the blog";
        public string Owner { get; set; } = "Issun";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 9999;

        /// <summary>
        /// Credit: https://stackoverflow.com/a/7135343/8306962
        /// </summary>
        public static bool IsDebug()
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }
    }
}
